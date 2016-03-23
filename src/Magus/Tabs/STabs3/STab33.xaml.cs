using Magus.Controls;
using Magus.Model;
using Microsoft.Win32;
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

namespace Magus.Tabs.STabs3
{
    /// <summary>
    /// Interaction logic for STab33.xaml
    /// </summary>
    public partial class STab33 : UserControl
    {
        public STab33()
        {
            InitializeComponent();
            Songs song = Songs.Instance;
            lvSongs.ItemsSource = Songs.getSongs();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            Button btn = sender as Button;
            Song s = btn.DataContext as Song;
            auPlayer.playSong(s.FilePath);
            auPlayer.setSongLabel(s.Name);
        }

        private void loadButton_Click_1(object sender, RoutedEventArgs e) {
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
            }
        }

        private void removeButton_Click_1(object sender, RoutedEventArgs e) {
            Songs.getSongs().Remove(lvSongs.SelectedItem as Song);
        }
    }
}