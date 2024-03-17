# Image Downsizer

This project was completed as part of an assignment for the Parallel Programming course.

To run the application, clone the repository and start the project.

This WinForm application allows the user to select an image and downscale it based on a chosen factor. It implements a weighted average algorithm, where values for the pixels of the new image are calculated based on an area of the original image determined by the scaling factor. This algorithm is implemented both sequentially and in parallel. The parallel method splits the image into equal sectors and runs the downscaling process in separate threads.

Here are some results from running both algorithms against images with different resolutions:

| Resolution (px)  | Sequential (ms) | Parallel (ms) |
|-------------|------------|----------|
| 200x200     | 11         | 89       |
| 1000x1000   | 65         | 152      |
| 4000x2000   | 597        | 389      |
| 8000x4000   | 2039       | 1260     |
| 25000x15000 | 41606      | 31686    |
<br>
And this is what the UI looks like: 
<br>

![DownSizer](https://github.com/Marin-Praskov/image-downsizer/assets/107186067/1e5bd3d8-e71f-4143-b846-6a4a17ac1f52)

