using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace ChildCafe
{
    public partial class FrmBaseCapture : Form
    {
        public FrmBaseCapture()
        {
            InitializeComponent();
        }

        private FilterInfoCollection _captureDevice;
        private VideoCaptureDevice _finalFrame;

        private void FrmBaseCapture_Load(object sender, EventArgs e)
        {
            _captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if(_captureDevice.Count != 0)
            {
                foreach (FilterInfo device in _captureDevice)
                {
                    cbDevices.Items.Add(device.Name);
                }

                cbDevices.SelectedIndex = 0;
            }


            _finalFrame = new VideoCaptureDevice();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _finalFrame = new VideoCaptureDevice(_captureDevice[cbDevices.SelectedIndex].MonikerString);
            _finalFrame.NewFrame += FinalFrame_NewFrame;
            _finalFrame.Start();
        }

        void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }
    }
}
