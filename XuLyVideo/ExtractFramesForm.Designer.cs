namespace XuLyVideo
{
    partial class ExtractFramesForm
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
            this.btnExtractFrames = new System.Windows.Forms.Button();
            this.txtVideoPath = new System.Windows.Forms.TextBox();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExtractFrames
            // 
            this.btnExtractFrames.Location = new System.Drawing.Point(282, 285);
            this.btnExtractFrames.Name = "btnExtractFrames";
            this.btnExtractFrames.Size = new System.Drawing.Size(246, 44);
            this.btnExtractFrames.TabIndex = 0;
            this.btnExtractFrames.Text = "Tách video thành danh sách ảnh";
            this.btnExtractFrames.UseVisualStyleBackColor = true;
            this.btnExtractFrames.Click += new System.EventHandler(this.btnExtractFrames_Click);
            // 
            // txtVideoPath
            // 
            this.txtVideoPath.Location = new System.Drawing.Point(95, 98);
            this.txtVideoPath.Multiline = true;
            this.txtVideoPath.Name = "txtVideoPath";
            this.txtVideoPath.Size = new System.Drawing.Size(232, 133);
            this.txtVideoPath.TabIndex = 1;
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(454, 94);
            this.txtOutputFolder.Multiline = true;
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(236, 136);
            this.txtOutputFolder.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Link video đầu vào";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Link folder đầu ra";
            // 
            // ExtractFramesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutputFolder);
            this.Controls.Add(this.txtVideoPath);
            this.Controls.Add(this.btnExtractFrames);
            this.Name = "ExtractFramesForm";
            this.Text = "ExtractFramesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExtractFrames;
        private System.Windows.Forms.TextBox txtVideoPath;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}