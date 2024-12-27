namespace XuLyVideo
{
    partial class ExtractAudioForm
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
            this.txtVideoPath = new System.Windows.Forms.TextBox();
            this.txtAudioPath = new System.Windows.Forms.TextBox();
            this.btnExtractAudio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVideoPath
            // 
            this.txtVideoPath.Location = new System.Drawing.Point(92, 72);
            this.txtVideoPath.Multiline = true;
            this.txtVideoPath.Name = "txtVideoPath";
            this.txtVideoPath.Size = new System.Drawing.Size(228, 161);
            this.txtVideoPath.TabIndex = 0;
            // 
            // txtAudioPath
            // 
            this.txtAudioPath.Location = new System.Drawing.Point(451, 71);
            this.txtAudioPath.Multiline = true;
            this.txtAudioPath.Name = "txtAudioPath";
            this.txtAudioPath.Size = new System.Drawing.Size(233, 162);
            this.txtAudioPath.TabIndex = 1;
            // 
            // btnExtractAudio
            // 
            this.btnExtractAudio.Location = new System.Drawing.Point(269, 294);
            this.btnExtractAudio.Name = "btnExtractAudio";
            this.btnExtractAudio.Size = new System.Drawing.Size(223, 36);
            this.btnExtractAudio.TabIndex = 2;
            this.btnExtractAudio.Text = "Tách âm thanh từ video";
            this.btnExtractAudio.UseVisualStyleBackColor = true;
            this.btnExtractAudio.Click += new System.EventHandler(this.btnExtractAudio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Link video đầu vào";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Link âm thanh đầu ra";
            // 
            // ExtractAudioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExtractAudio);
            this.Controls.Add(this.txtAudioPath);
            this.Controls.Add(this.txtVideoPath);
            this.Name = "ExtractAudioForm";
            this.Text = "ExtractAudioForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVideoPath;
        private System.Windows.Forms.TextBox txtAudioPath;
        private System.Windows.Forms.Button btnExtractAudio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}