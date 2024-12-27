using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLyVideo
{
    public partial class ExtractFramesForm : Form
    {
        public ExtractFramesForm()
        {
            InitializeComponent();
        }

        private void btnExtractFrames_Click(object sender, EventArgs e)
        {
            string inputPath = txtVideoPath.Text;
            string outputFolder = txtOutputFolder.Text;

            if (string.IsNullOrWhiteSpace(inputPath) || string.IsNullOrWhiteSpace(outputFolder))
            {
                MessageBox.Show("Please provide valid input and output paths.");
                return;
            }

            string arguments = $"-i \"{inputPath}\" \"{outputFolder}\\image%d.png\"";
            ExecuteFFmpeg(arguments);
        }

        private void ExecuteFFmpeg(string arguments)
        {
            try
            {
                Process ffmpeg = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "ffmpeg",
                        Arguments = arguments,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };
                ffmpeg.Start();
                ffmpeg.WaitForExit();
                MessageBox.Show("Frames extracted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
