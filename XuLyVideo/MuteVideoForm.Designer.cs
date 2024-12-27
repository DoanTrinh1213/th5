namespace XuLyVideo
{
    partial class MuteVideoForm
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
            this.txtMutedVideoPath = new System.Windows.Forms.TextBox();
            this.txtVideoPath = new System.Windows.Forms.TextBox();
            this.btnMuteVideo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Link video tắt tiếng đầu ra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Link video đầu vào";
            // 
            // txtMutedVideoPath
            // 
            this.txtMutedVideoPath.Location = new System.Drawing.Point(462, 124);
            this.txtMutedVideoPath.Multiline = true;
            this.txtMutedVideoPath.Name = "txtMutedVideoPath";
            this.txtMutedVideoPath.Size = new System.Drawing.Size(236, 136);
            this.txtMutedVideoPath.TabIndex = 7;
            // 
            // txtVideoPath
            // 
            this.txtVideoPath.Location = new System.Drawing.Point(103, 128);
            this.txtVideoPath.Multiline = true;
            this.txtVideoPath.Name = "txtVideoPath";
            this.txtVideoPath.Size = new System.Drawing.Size(232, 133);
            this.txtVideoPath.TabIndex = 6;
            // 
            // btnMuteVideo
            // 
            this.btnMuteVideo.Location = new System.Drawing.Point(290, 315);
            this.btnMuteVideo.Name = "btnMuteVideo";
            this.btnMuteVideo.Size = new System.Drawing.Size(246, 44);
            this.btnMuteVideo.TabIndex = 5;
            this.btnMuteVideo.Text = "Tắt âm thanh trong video";
            this.btnMuteVideo.UseVisualStyleBackColor = true;
            this.btnMuteVideo.Click += new System.EventHandler(this.btnMuteVideo_Click);
            // 
            // MuteVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMutedVideoPath);
            this.Controls.Add(this.txtVideoPath);
            this.Controls.Add(this.btnMuteVideo);
            this.Name = "MuteVideoForm";
            this.Text = "MuteVideoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMutedVideoPath;
        private System.Windows.Forms.TextBox txtVideoPath;
        private System.Windows.Forms.Button btnMuteVideo;
    }
}