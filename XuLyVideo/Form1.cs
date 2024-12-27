using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLyVideo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExtractAudio_Click(object sender, EventArgs e)
        {
            var extractAudioForm = new ExtractAudioForm();
            extractAudioForm.ShowDialog();
        }

        private void btnExtractFrames_Click(object sender, EventArgs e)
        {
            var extractFramesForm = new ExtractFramesForm();
            extractFramesForm.ShowDialog();
        }

        private void btnMuteVideo_Click(object sender, EventArgs e)
        {
            var muteVideoForm = new MuteVideoForm();
            muteVideoForm.ShowDialog();
        }

        private void btnMergeImages_Click(object sender, EventArgs e)
        {
            var mergeImagesForm = new MergeImagesForm();
            mergeImagesForm.ShowDialog();
        }
    }
}
