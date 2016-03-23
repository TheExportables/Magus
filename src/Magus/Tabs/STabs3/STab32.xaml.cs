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
    /// Interaction logic for STab32.xaml
    /// </summary>
    public partial class STab32 : UserControl
    {
        public STab32()
        {
            InitializeComponent();
            Pictures pics = Pictures.Instance;
            tcPictures.ItemsSource = Pictures.getPictures();
        }

        private void loadButton_Click_1(object sender, RoutedEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp|All files(*.*)|*";
            if (ofd.ShowDialog() == true) {
                Uri uri = new Uri(ofd.FileName, UriKind.RelativeOrAbsolute);
                BitmapImage bitmap = new BitmapImage(uri);
                Image img = new Image();
                img.Source = bitmap;
                String name;
                TextDialog td = new TextDialog();
                if (td.ShowDialog() == true) {
                    name = td.ResponseText;
                } else {
                    name = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName);
                }
                Picture p = new Picture();
                p.Name = name;
                p.FilePath = ofd.FileName;
                Pictures.getPictures().Add(p);
                tcPictures.SelectedItem = p;
                //TODO save list
            }
        }

        /*private void editButton_Click_1(object sender, RoutedEventArgs e) {
            //TODO
        }*/

        private void removeButton_Click_1(object sender, RoutedEventArgs e) {
            Pictures.getPictures().Remove(tcPictures.SelectedItem as Picture);
        }
    }
}