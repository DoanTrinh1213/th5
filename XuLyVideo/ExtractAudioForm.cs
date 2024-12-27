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
    public partial class ExtractAudioForm : Form
    {
        public ExtractAudioForm()
        {
            InitializeComponent();
        }

        private void btnExtractAudio_Click(object sender, EventArgs e)
        {
            string inputPath = txtVideoPath.Text;
            string outputPath = txtAudioPath.Text;

            if (string.IsNullOrWhiteSpace(inputPath) || string.IsNullOrWhiteSpace(outputPath))
            {
                MessageBox.Show("Please provide valid input and output paths.");
                return;
            }

            string arguments = $"-i \"{inputPath}\" -vn -ar 44100 -ac 2 -ab 129k -f mp3 \"{outputPath}\"";
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
                MessageBox.Show("Audio extracted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
