
namespace ImageDownsizer
{
    partial class ImageDownsizer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageDownsizer));
            label_title = new Label();
            label_description = new Label();
            textBox_factor = new TextBox();
            label_factor = new Label();
            openFileDialog1 = new OpenFileDialog();
            button_selectImage = new Button();
            button_downsize = new Button();
            label_results = new Label();
            label_imageName = new Label();
            label_imageSize = new Label();
            label_imageResolution = new Label();
            groupBox_algorithm = new GroupBox();
            radioButton_par = new RadioButton();
            radioButton_seq = new RadioButton();
            label_sequential = new Label();
            label_parallel = new Label();
            label_sequential_time = new Label();
            label_parallel_time = new Label();
            groupBox_algorithm.SuspendLayout();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 32F);
            label_title.Location = new Point(195, 9);
            label_title.Name = "label_title";
            label_title.Size = new Size(348, 59);
            label_title.TabIndex = 0;
            label_title.Text = "Image Downsizer";
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.Font = new Font("Segoe UI", 11F);
            label_description.Location = new Point(253, 84);
            label_description.MaximumSize = new Size(500, 0);
            label_description.Name = "label_description";
            label_description.Size = new Size(488, 80);
            label_description.TabIndex = 1;
            label_description.Text = resources.GetString("label_description.Text");
            // 
            // textBox_factor
            // 
            textBox_factor.Location = new Point(83, 94);
            textBox_factor.Name = "textBox_factor";
            textBox_factor.Size = new Size(99, 23);
            textBox_factor.TabIndex = 2;
            // 
            // label_factor
            // 
            label_factor.AutoSize = true;
            label_factor.Font = new Font("Segoe UI", 11F);
            label_factor.Location = new Point(25, 93);
            label_factor.Name = "label_factor";
            label_factor.Size = new Size(52, 20);
            label_factor.TabIndex = 3;
            label_factor.Text = "Factor:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_selectImage
            // 
            button_selectImage.Font = new Font("Segoe UI", 10F);
            button_selectImage.Location = new Point(27, 138);
            button_selectImage.Name = "button_selectImage";
            button_selectImage.Size = new Size(157, 26);
            button_selectImage.TabIndex = 4;
            button_selectImage.Text = "Select Image";
            button_selectImage.UseVisualStyleBackColor = true;
            button_selectImage.Click += button_selectImage_Click;
            // 
            // button_downsize
            // 
            button_downsize.Font = new Font("Segoe UI", 13F);
            button_downsize.Location = new Point(27, 331);
            button_downsize.Name = "button_downsize";
            button_downsize.Size = new Size(174, 45);
            button_downsize.TabIndex = 5;
            button_downsize.Text = "Downsize";
            button_downsize.UseVisualStyleBackColor = true;
            button_downsize.Click += button_downsize_Click;
            // 
            // label_results
            // 
            label_results.AutoSize = true;
            label_results.Font = new Font("Segoe UI", 16F);
            label_results.Location = new Point(459, 181);
            label_results.Name = "label_results";
            label_results.Size = new Size(79, 30);
            label_results.TabIndex = 6;
            label_results.Text = "Results";
            // 
            // label_imageName
            // 
            label_imageName.AutoSize = true;
            label_imageName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_imageName.Location = new Point(27, 181);
            label_imageName.Name = "label_imageName";
            label_imageName.Size = new Size(83, 20);
            label_imageName.TabIndex = 7;
            label_imageName.Text = "Name: N/A";
            // 
            // label_imageSize
            // 
            label_imageSize.AutoSize = true;
            label_imageSize.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_imageSize.Location = new Point(28, 206);
            label_imageSize.Name = "label_imageSize";
            label_imageSize.Size = new Size(70, 20);
            label_imageSize.TabIndex = 8;
            label_imageSize.Text = "Size: N/A";
            // 
            // label_imageResolution
            // 
            label_imageResolution.AutoSize = true;
            label_imageResolution.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_imageResolution.Location = new Point(29, 231);
            label_imageResolution.Name = "label_imageResolution";
            label_imageResolution.Size = new Size(113, 20);
            label_imageResolution.TabIndex = 9;
            label_imageResolution.Text = "Resolution: N/A";
            // 
            // groupBox_algorithm
            // 
            groupBox_algorithm.Controls.Add(radioButton_par);
            groupBox_algorithm.Controls.Add(radioButton_seq);
            groupBox_algorithm.Location = new Point(28, 281);
            groupBox_algorithm.Name = "groupBox_algorithm";
            groupBox_algorithm.Size = new Size(173, 44);
            groupBox_algorithm.TabIndex = 10;
            groupBox_algorithm.TabStop = false;
            groupBox_algorithm.Text = "Algorithm";
            // 
            // radioButton_par
            // 
            radioButton_par.AutoSize = true;
            radioButton_par.Location = new Point(64, 18);
            radioButton_par.Name = "radioButton_par";
            radioButton_par.Size = new Size(46, 19);
            radioButton_par.TabIndex = 1;
            radioButton_par.TabStop = true;
            radioButton_par.Text = "PAR";
            radioButton_par.UseVisualStyleBackColor = true;
            // 
            // radioButton_seq
            // 
            radioButton_seq.AutoSize = true;
            radioButton_seq.Location = new Point(12, 18);
            radioButton_seq.Name = "radioButton_seq";
            radioButton_seq.Size = new Size(46, 19);
            radioButton_seq.TabIndex = 0;
            radioButton_seq.TabStop = true;
            radioButton_seq.Text = "SEQ";
            radioButton_seq.UseVisualStyleBackColor = true;
            // 
            // label_sequential
            // 
            label_sequential.AutoSize = true;
            label_sequential.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label_sequential.Location = new Point(336, 224);
            label_sequential.Name = "label_sequential";
            label_sequential.Size = new Size(86, 21);
            label_sequential.TabIndex = 11;
            label_sequential.Text = "Sequential:";
            // 
            // label_parallel
            // 
            label_parallel.AutoSize = true;
            label_parallel.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label_parallel.Location = new Point(568, 224);
            label_parallel.Name = "label_parallel";
            label_parallel.Size = new Size(63, 21);
            label_parallel.TabIndex = 12;
            label_parallel.Text = "Parallel:";
            // 
            // label_sequential_time
            // 
            label_sequential_time.AutoSize = true;
            label_sequential_time.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_sequential_time.Location = new Point(336, 256);
            label_sequential_time.Name = "label_sequential_time";
            label_sequential_time.Size = new Size(129, 20);
            label_sequential_time.TabIndex = 13;
            label_sequential_time.Text = "Elapsed time: N/A";
            // 
            // label_parallel_time
            // 
            label_parallel_time.AutoSize = true;
            label_parallel_time.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_parallel_time.Location = new Point(568, 256);
            label_parallel_time.Name = "label_parallel_time";
            label_parallel_time.Size = new Size(132, 20);
            label_parallel_time.TabIndex = 14;
            label_parallel_time.Text = "Elapsed Time: N/A";
            // 
            // ImageDownsizer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 432);
            Controls.Add(label_parallel_time);
            Controls.Add(label_sequential_time);
            Controls.Add(label_parallel);
            Controls.Add(label_sequential);
            Controls.Add(groupBox_algorithm);
            Controls.Add(label_imageResolution);
            Controls.Add(label_imageSize);
            Controls.Add(label_imageName);
            Controls.Add(label_results);
            Controls.Add(button_downsize);
            Controls.Add(button_selectImage);
            Controls.Add(label_factor);
            Controls.Add(textBox_factor);
            Controls.Add(label_description);
            Controls.Add(label_title);
            Name = "ImageDownsizer";
            Text = "Image Downsizer";
            groupBox_algorithm.ResumeLayout(false);
            groupBox_algorithm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label_title;
        private Label label_description;
        private TextBox textBox_factor;
        private Label label_factor;
        private OpenFileDialog openFileDialog1;
        private Button button_selectImage;
        private Button button_downsize;
        private Label label_results;
        private Label label_imageName;
        private Label label_imageSize;
        private Label label_imageResolution;
        private GroupBox groupBox_algorithm;
        private RadioButton radioButton_par;
        private RadioButton radioButton_seq;
        private Label label_sequential;
        private Label label_parallel;
        private Label label_sequential_time;
        private Label label_parallel_time;
    }
}
