using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projet_Subtitle
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Program test;
        TextBlock T;
        string cheminVideo;
        public MainWindow()
        {
            InitializeComponent();
            button1.IsEnabled = false;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog boite = new Microsoft.Win32.OpenFileDialog();
            boite.Filter = "Fichiers Vidéo (*.avi;*.mpg;*.mpeg; *.mkv)|*.avi;*.mpg;*.mpeg; *.mkv";
            boite.Multiselect = false;
            boite.FilterIndex = 1;
            boite.ShowDialog();

            if (boite.Filter != string.Empty)
            {
                mediaElement.Source = new Uri(boite.FileName);
                T = textBlock;
                test = new Program(T,cheminVideo);
            }
        }

        private void Chemin_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog boite = new Microsoft.Win32.OpenFileDialog();
            boite.Filter = "Fichiers Texte (*.srt;)|*.srt";
            boite.Multiselect = false;
            boite.FilterIndex = 1;
            boite.ShowDialog();
            if (boite.Filter != string.Empty)
            {
                cheminVideo = boite.FileName;
                button1.IsEnabled = true;
            }
        }

        /*private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            media.LoadedBehavior = MediaState.Stop;
            pause.Reset();
            if (workerSub.WorkerSupportsCancellation == true)
            {
                workerSub.CancelAsync();
            }

        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            media.LoadedBehavior = MediaState.Pause;
            pause.Reset();
        }

        private void ChangeMediaVolume(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            media.Volume = (double)volumeSlider.Value;
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            private void Button_Click(object sender, RoutedEventArgs e)
            {
                media.LoadedBehavior = MediaState.Stop;
                pause.Reset();
                if (workerSub.WorkerSupportsCancellation == true)
                {
                    workerSub.CancelAsync();
                }

            }
            controlPanel.Opacity = 0.1;
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            controlPanel.Opacity = 1;
        }*/
    }
}
