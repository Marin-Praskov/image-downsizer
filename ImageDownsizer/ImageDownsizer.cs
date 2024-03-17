using System.Diagnostics;
using System.Drawing.Imaging;

namespace ImageDownsizer
{
    public partial class ImageDownsizer : Form
    {
        string filePath = "";

        public ImageDownsizer()
        {
            InitializeComponent();
        }

        private void button_selectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                this.filePath = filePath;

                label_imageName.Text = "Name: " + Path.GetFileName(filePath);
                FileInfo fileInfo = new FileInfo(filePath);
                double sizeInMb = fileInfo.Length / (1024.0 * 1024.0);
                label_imageSize.Text = "Size: " + sizeInMb.ToString("F2") +"MB";

                Image img = Image.FromFile(filePath);
                label_imageResolution.Text = "Resolution: " + img.Width + " x " + img.Height;

            }
        }

        private async void button_downsize_Click(object sender, EventArgs e)
        {
            long reponseTimeSeq = 0, responseTimePar = 0;

            if (!double.TryParse(textBox_factor.Text, out double downscaleFactor)
                || downscaleFactor <= 0
                || downscaleFactor > 1)
            {
                MessageBox.Show("Please enter a valid factor (number between 0 and 1)", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            button_downsize.Enabled = false;

            if (radioButton_seq.Checked)
            {
                reponseTimeSeq = await Task.Run(() => DSUtility.DownscaleSequential(this.filePath, downscaleFactor));
                label_sequential_time.Text = "Elapsed time: " + reponseTimeSeq + "ms";
            }
            if (radioButton_par.Checked)
            {
                responseTimePar = await Task.Run(() => DSUtility.DownscaleParallel(this.filePath, downscaleFactor));
                label_parallel_time.Text = "Elapsed time: " + responseTimePar + "ms";

            }

            button_downsize.Enabled = true;
        }
    }
}

