using Magus.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Magus.Controls {
    /// <summary>
    /// Interaction logic for AudioPlayer.xaml
    /// </summary>
    public partial class AudioPlayer : UserControl {

        private bool mediaPlayerIsPlaying = false;
        private bool userIsDraggingSlider = false;

        public AudioPlayer() {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e) {
            if ((mePlayer.Source != null) && (mePlayer.NaturalDuration.HasTimeSpan) && (!userIsDraggingSlider)) {
                sliProgress.Minimum = 0;
                sliProgress.Maximum = mePlayer.NaturalDuration.TimeSpan.TotalSeconds;
                sliProgress.Value = mePlayer.Position.TotalSeconds;
            }
        }

        public void playSong(String songFile) {
            if (mePlayer != null) {
                mePlayer.Source = new Uri(songFile);
                mePlayer.Play();
                mediaPlayerIsPlaying = true;
            }
        }

        public void setSongLabel(String labelContent) {
            songLbl.Content = labelContent;
        }

        private void sliProgress_DragStarted(object sender, DragStartedEventArgs e) {
            userIsDraggingSlider = true;
        }

        private void sliProgress_DragCompleted(object sender, DragCompletedEventArgs e) {
            userIsDraggingSlider = false;
            mePlayer.Position = TimeSpan.FromSeconds(sliProgress.Value);
        }

        private void sliProgress_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            lblProgressStatus.Text = TimeSpan.FromSeconds(sliProgress.Value).ToString(@"hh\:mm\:ss");
        }

        private void Grid_MouseWheel(object sender, MouseWheelEventArgs e) {
            mePlayer.Volume += (e.Delta > 0) ? 0.1 : -0.1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Media files (*.mp3;*.mpg;*.mpeg)|*.mp3;*.mpg;*.mpeg|All files (*.*)|*.*";
            if (ofd.ShowDialog() == true) {
                Songs songs = Songs.Instance;
                Song s = new Song();
                String name;
                TextDialog td = new TextDialog();
                if (td.ShowDialog() == true) {
                    name = td.ResponseText;
                } else {
                    name = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName);
                }
                s.Name = name;
                s.FilePath = ofd.FileName;
                Songs.getSongs().Add(s);
                mePlayer.Source = new Uri(ofd.FileName);
                setSongLabel(s.Name);
            }
        }

        private void playBtn_Click_1(object sender, RoutedEventArgs e) {
            if ((mePlayer != null) && (mePlayer.Source != null)) {
                mePlayer.Play();
                mediaPlayerIsPlaying = true;
            } else {
                MessageBox.Show("Előbb meg kell nyitni egy zenét, hogy lejátszható legyen!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void pauseBtn_Click_1(object sender, RoutedEventArgs e) {
            if (mediaPlayerIsPlaying)
                mePlayer.Pause();
        }

        private void stopBtn_Click_1(object sender, RoutedEventArgs e) {
            if (mediaPlayerIsPlaying) {
                mePlayer.Stop();
                mediaPlayerIsPlaying = false;
            }
        }
    }
}