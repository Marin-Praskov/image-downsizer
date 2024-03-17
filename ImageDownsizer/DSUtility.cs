using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ImageDownsizer
{
    internal class DSUtility
    {
        public static long DownscaleSequential(string imagePath, double factor)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            using (Bitmap srcBM = new Bitmap(imagePath))
            {
                int newWidth = (int)(srcBM.Width * factor);
                int newHeight = (int)(srcBM.Height * factor);

                using (Bitmap newBM = new Bitmap(newWidth, newHeight))
                {
                    BitmapData srcData = srcBM.LockBits(new Rectangle(0, 0, srcBM.Width, srcBM.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                    BitmapData newData = newBM.LockBits(new Rectangle(0, 0, newWidth, newHeight), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                    float xRatio = srcBM.Width / (float)newWidth;
                    float yRatio = srcBM.Height / (float)newHeight;

                    unsafe
                    {
                        for (int y = 0; y <newHeight; y++)
                        {
                            for (int x = 0; x <newWidth; x++)
                            {
                                // Calculate the dimension of the rectangle that will be used for sampling
                                float srcX1 = x * xRatio;
                                float srcY1 = y * yRatio;
                                float srcX2 = (x + 1) * xRatio;
                                float srcY2 = (y + 1) * yRatio;

                                long sumRed = 0, sumGreen = 0, sumBlue = 0;
                                int pixelCount = 0;

                                // Itterate throught the sample rectangle and avarage the pixel data in it
                                for (int yy = (int)srcY1; yy <srcY2; yy++)
                                {
                                    for (int xx = (int)srcX1; xx <srcX2; xx++)
                                    {
                                        byte* newPixel = (byte*)srcData.Scan0 + (yy * srcData.Stride) + (xx * 4);
                                        sumBlue += newPixel[0];
                                        sumGreen += newPixel[1];
                                        sumRed += newPixel[2];
                                        pixelCount++;
                                    }
                                }

                                byte blue = (byte)(sumBlue/ pixelCount);
                                byte green = (byte)(sumGreen/ pixelCount);
                                byte red = (byte)(sumRed/ pixelCount);

                                byte* destPixel = (byte*)newData.Scan0 + (y * newData.Stride) + (x * 4);
                                destPixel[0] = blue;
                                destPixel[1] = green;
                                destPixel[2] = red;
                                destPixel[3] = 255;
                            }
                        }
                    }

                    srcBM.UnlockBits(srcData);
                    newBM.UnlockBits(newData);

                    string newImagePath = Path.Combine(Path.GetDirectoryName(imagePath),
                        Path.GetFileNameWithoutExtension(imagePath) + "_downscaled" + Path.GetExtension(imagePath));
                    newBM.Save(newImagePath);
                }
            }

            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }

        public static long DownscaleParallel(string imagePath, double factor)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            using (Bitmap srcBM = new Bitmap(imagePath))
            {
                int srcWidth = srcBM.Width;
                int srcHeight = srcBM.Height;
                int newWidth = (int)(srcWidth * factor);
                int newHeight = (int)(srcHeight * factor);

                using (Bitmap newBM = new Bitmap(newWidth, newHeight))
                {
                    BitmapData srcData = srcBM.LockBits(new Rectangle(0, 0, srcWidth, srcHeight), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                    BitmapData newData = newBM.LockBits(new Rectangle(0, 0, newWidth, newHeight), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                    int processorCount = Environment.ProcessorCount;
                    var threads = new List<Thread>();

                    // Divide the image into sectors based on the number of processors and process it in parallel.
                    for (int index = 0; index < processorCount; index++)
                    {
                        int startY = index * newHeight / processorCount;
                        int endY = (index + 1) * newHeight / processorCount;

                        Thread thread = new Thread(() =>
                        {
                            for (int y = startY; y < endY; y++)
                            {
                                for (int x = 0; x < newWidth; x++)
                                {
                                    float srcX1 = x * srcWidth / (float)newWidth;
                                    float srcY1 = y * srcHeight / (float)newHeight;
                                    float srcX2 = (x + 1) * srcWidth / (float)newWidth;
                                    float srcY2 = (y + 1) * srcHeight / (float)newHeight;

                                    long sumRed = 0, sumGreen = 0, sumBlue =0;
                                    int pixelCount = 0;


                                    for (int yy = (int)srcY1; yy < srcY2 && yy < srcHeight; yy++)
                                    {
                                        for (int xx = (int)srcX1; xx < srcX2 && xx < srcWidth; xx++)
                                        {
                                            unsafe
                                            {
                                                byte* newPixel = (byte*)srcData.Scan0 + (yy * srcData.Stride) + (xx * 4);
                                                sumBlue += newPixel[0];
                                                sumGreen += newPixel[1];
                                                sumRed += newPixel[2];
                                                pixelCount++;
                                            }
                                        }
                                    }

                                    byte blue = (byte)(sumBlue / pixelCount);
                                    byte green = (byte)(sumGreen / pixelCount);
                                    byte red = (byte)(sumRed / pixelCount);

                                    unsafe
                                    {
                                        byte* destPixel = (byte*)newData.Scan0 + (y * newData.Stride) + (x* 4);
                                        destPixel[0] = blue;
                                        destPixel[1] = green;
                                        destPixel[2] = red;
                                        destPixel[3] = 255;
                                    }
                                }
                            }
                        });

                        threads.Add(thread);
                        thread.Start();
                    }

                    foreach (Thread thread in threads)
                    {
                        thread.Join();
                    }

                    srcBM.UnlockBits(srcData);
                    newBM.UnlockBits(newData);

                    string newImagePath = Path.Combine(Path.GetDirectoryName(imagePath),
                        Path.GetFileNameWithoutExtension(imagePath) + "_downscaled_parallel" + Path.GetExtension(imagePath));
                    newBM.Save(newImagePath);
                }
            }

            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }
    }
}
