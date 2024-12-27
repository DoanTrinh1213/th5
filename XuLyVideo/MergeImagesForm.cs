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
    public partial class MergeImagesForm : Form
    {
        public MergeImagesForm()
        {
            InitializeComponent();
        }

        private void btnMergeImages_Click(object sender, EventArgs e)
        {
            string inputFolder = txtImageFolder.Text;
            string outputPath = txtVideoPath.Text;

            if (string.IsNullOrWhiteSpace(inputFolder) || string.IsNullOrWhiteSpace(outputPath))
            {
                MessageBox.Show("Please provide valid input and output paths.");
                return;
            }

            string arguments = $"-f image2 -i \"{inputFolder}\\image%d.png\" \"{outputPath}\"";
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
                MessageBox.Show("Video created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
