using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DotNetSpeech;

namespace ChildCafe
{
    public partial class FrmBaseInfoTextToSpeech : Form
    {
        SpeechVoiceSpeakFlags spFlags = SpeechVoiceSpeakFlags.SVSFlagsAsync;
        SpVoice sp = new SpVoice();


        public FrmBaseInfoTextToSpeech()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            sp.Volume = trackBar1.Value;
            sp.Rate = trackBar2.Value;
            sp.Speak(tbTextInput.Text, spFlags);

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            sp.Speak(string.Empty, SpeechVoiceSpeakFlags.SVSFPurgeBeforeSpeak);  
        }

        private void btnToWave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "All files (*.*)|*.*|wav files (*.wav)|*.wav";
            sfd.Title = "Save to a wave file";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SpeechStreamFileMode spFileMode = SpeechStreamFileMode.SSFMCreateForWrite;
                SpFileStream spFileStream = new SpFileStream();
                spFileStream.Open(sfd.FileName, spFileMode, false);
                sp.AudioOutputStream = spFileStream;
                sp.Volume = trackBar1.Value;
                sp.Rate = trackBar2.Value;
                sp.Speak(tbTextInput.Text, spFlags);
                sp.WaitUntilDone(System.Threading.Timeout.Infinite);
                spFileStream.Close();
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar2.Value.ToString();
        }

        private void FrmBaseInfoTextToSpeech_Load(object sender, EventArgs e)
        {
            label3.Text = trackBar1.Value.ToString();
            label4.Text = trackBar2.Value.ToString();
        }

       
    }
}
