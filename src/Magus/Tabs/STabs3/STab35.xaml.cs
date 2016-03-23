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
    /// Interaction logic for STab35.xaml
    /// </summary>
    public partial class STab35 : UserControl
    {
        public STab35()
        {
            InitializeComponent();
            Messages messages = Messages.Instance;
            tcMessages.ItemsSource = Messages.getMessages();
        }

        private void loadButton_Click_1(object sender, RoutedEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "RTF files (*.rtf)|*.rtf|All files(*.*)|*";
            if (ofd.ShowDialog() == true) {
                String name;
                TextDialog td = new TextDialog();
                if (td.ShowDialog() == true) {
                    name = td.ResponseText;
                } else {
                    name = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName);
                }
                Message m = new Message();
                m.Name = name;
                m.FilePath = ofd.FileName;
                Messages.getMessages().Add(m);
                tcMessages.SelectedItem = m;
                //TODO save list
            }
        }

        private void removeButton_Click_1(object sender, RoutedEventArgs e) {
            Messages.getMessages().Remove(tcMessages.SelectedItem as Message);
        }
    }
}
