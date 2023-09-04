using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace WebcamApp
{
    public partial class ComboBox : Form
    {
        private FilterInfoCollection captureDevice;
        private VideoCaptureDevice videoSource;
        public ComboBox()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo listDevice in captureDevice)
            {
                comboBoxWebcamList.Items.Add(listDevice.Name);
            }
            comboBoxWebcamList.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
            }
            videoSource = new VideoCaptureDevice(captureDevice[comboBoxWebcamList.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            videoSource.Start();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // throw new NotImplementedException();
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCapture_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
        }

        private void ButtonSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Image As";
            saveFileDialog.Filter = "Image files (*.jpg, *.png) | *.jpg, *.png";
            ImageFormat imageFormat = ImageFormat.Png;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog.FileName);
                switch (ext)
                {
                    case ".jpg":
                        imageFormat = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        imageFormat = ImageFormat.Png;
                        break;
                }
                pictureBox2.Image.Save(saveFileDialog.FileName, imageFormat);
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
                pictureBox2.Image = null;
                pictureBox2.Invalidate();
            }
            Application.Exit(null);
        }
    }
}