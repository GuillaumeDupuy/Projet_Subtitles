using System;
using System.Windows;
using System.Windows.Controls;

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

        //fonction qui permet de parcourir l'ordinateur pour récuperer le film
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
                test = new Program(T, cheminVideo);
            }
        }

        //fonction qui permet de parcourir l'ordinateur pour récuperer les sous-titres
        private void Chemin_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog boite = new Microsoft.Win32.OpenFileDialog();
            boite.Filter = "Fichiers Texte (*.srt; *.txt)|*.srt; *.txt";
            boite.Multiselect = false;
            boite.FilterIndex = 1;
            boite.ShowDialog();
            if (boite.Filter != string.Empty)
            {
                cheminVideo = boite.FileName;
                button1.IsEnabled = true;
            }
        }

        //fonction du bouton stop
        /*private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            media.LoadedBehavior = MediaState.Stop;
            pause.Reset();
            if (workerSub.WorkerSupportsCancellation == true)
            {
                workerSub.CancelAsync();
            }

        }

        //fonction du bouton pause
        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            media.LoadedBehavior = MediaState.Pause;
            pause.Reset();
        }

        //fonction du slider volume
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
