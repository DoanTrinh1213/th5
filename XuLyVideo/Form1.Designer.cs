namespace XuLyVideo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExtractAudio = new System.Windows.Forms.Button();
            this.btnExtractFrames = new System.Windows.Forms.Button();
            this.btnMuteVideo = new System.Windows.Forms.Button();
            this.btnMergeImages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExtractAudio
            // 
            this.btnExtractAudio.Location = new System.Drawing.Point(123, 93);
            this.btnExtractAudio.Name = "btnExtractAudio";
            this.btnExtractAudio.Size = new System.Drawing.Size(176, 43);
            this.btnExtractAudio.TabIndex = 0;
            this.btnExtractAudio.Text = "Tách âm thanh từ video";
            this.btnExtractAudio.UseVisualStyleBackColor = true;
            this.btnExtractAudio.Click += new System.EventHandler(this.btnExtractAudio_Click);
            // 
            // btnExtractFrames
            // 
            this.btnExtractFrames.Location = new System.Drawing.Point(453, 93);
            this.btnExtractFrames.Name = "btnExtractFrames";
            this.btnExtractFrames.Size = new System.Drawing.Size(179, 43);
            this.btnExtractFrames.TabIndex = 1;
            this.btnExtractFrames.Text = "Tách video thành danh sách ảnh";
            this.btnExtractFrames.UseVisualStyleBackColor = true;
            this.btnExtractFrames.Click += new System.EventHandler(this.btnExtractFrames_Click);
            // 
            // btnMuteVideo
            // 
            this.btnMuteVideo.Location = new System.Drawing.Point(123, 223);
            this.btnMuteVideo.Name = "btnMuteVideo";
            this.btnMuteVideo.Size = new System.Drawing.Size(176, 44);
            this.btnMuteVideo.TabIndex = 2;
            this.btnMuteVideo.Text = "Tắt âm thanh trong video";
            this.btnMuteVideo.UseVisualStyleBackColor = true;
            this.btnMuteVideo.Click += new System.EventHandler(this.btnMuteVideo_Click);
            // 
            // btnMergeImages
            // 
            this.btnMergeImages.Location = new System.Drawing.Point(453, 223);
            this.btnMergeImages.Name = "btnMergeImages";
            this.btnMergeImages.Size = new System.Drawing.Size(179, 44);
            this.btnMergeImages.TabIndex = 3;
            this.btnMergeImages.Text = "Hợp danh sách ảnh thành video";
            this.btnMergeImages.UseVisualStyleBackColor = true;
            this.btnMergeImages.Click += new System.EventHandler(this.btnMergeImages_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMergeImages);
            this.Controls.Add(this.btnMuteVideo);
            this.Controls.Add(this.btnExtractFrames);
            this.Controls.Add(this.btnExtractAudio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExtractAudio;
        private System.Windows.Forms.Button btnExtractFrames;
        private System.Windows.Forms.Button btnMuteVideo;
        private System.Windows.Forms.Button btnMergeImages;
    }
}

