namespace XuLyVideo
{
    partial class MergeImagesForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVideoPath = new System.Windows.Forms.TextBox();
            this.txtImageFolder = new System.Windows.Forms.TextBox();
            this.btnMergeImages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Link video đầu ra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Link folder ảnh đầu vào";
            // 
            // txtVideoPath
            // 
            this.txtVideoPath.Location = new System.Drawing.Point(462, 124);
            this.txtVideoPath.Multiline = true;
            this.txtVideoPath.Name = "txtVideoPath";
            this.txtVideoPath.Size = new System.Drawing.Size(236, 136);
            this.txtVideoPath.TabIndex = 12;
            // 
            // txtImageFolder
            // 
            this.txtImageFolder.Location = new System.Drawing.Point(103, 128);
            this.txtImageFolder.Multiline = true;
            this.txtImageFolder.Name = "txtImageFolder";
            this.txtImageFolder.Size = new System.Drawing.Size(232, 133);
            this.txtImageFolder.TabIndex = 11;
            // 
            // btnMergeImages
            // 
            this.btnMergeImages.Location = new System.Drawing.Point(290, 315);
            this.btnMergeImages.Name = "btnMergeImages";
            this.btnMergeImages.Size = new System.Drawing.Size(246, 44);
            this.btnMergeImages.TabIndex = 10;
            this.btnMergeImages.Text = "Hợp danh sách ảnh thành video";
            this.btnMergeImages.UseVisualStyleBackColor = true;
            this.btnMergeImages.Click += new System.EventHandler(this.btnMergeImages_Click);
            // 
            // MergeImagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVideoPath);
            this.Controls.Add(this.txtImageFolder);
            this.Controls.Add(this.btnMergeImages);
            this.Name = "MergeImagesForm";
            this.Text = "MergeImagesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVideoPath;
        private System.Windows.Forms.TextBox txtImageFolder;
        private System.Windows.Forms.Button btnMergeImages;
    }
}