using System.Collections.ObjectModel;
using System.Windows;
using WinForms = System.Windows.Forms;
using System.Windows.Media;
using Microsoft.Win32;
using System;

namespace wpfsandbox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        MediaPlayer mediaPlayer = new MediaPlayer();

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = ".mp3 & .wav Files|*.mp3;*.wav";
            bool? dialogOk = dialog.ShowDialog();
            if (dialogOk == true)
            {
                string name = dialog.SafeFileName;
                fileName.Text = name;
                mediaPlayer.Open(new Uri(dialog.FileName));

            }


        }
    }
}
