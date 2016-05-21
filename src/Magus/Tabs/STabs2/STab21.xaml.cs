using Magus.ViewModel;
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
using System.Text.RegularExpressions;

namespace Magus.Tabs.STabs2
{
    /// <summary>
    /// Interaction logic for STab21.xaml
    /// </summary>
    public partial class STab21 : UserControl
    {
        CharacterViewModel cvm;

        public STab21()
        {
            InitializeComponent();
            cvm = new CharacterViewModel();
            this.DataContext = cvm;
        }

        private void next_click(object sender, RoutedEventArgs e) {
            cvm.Index++;
        }

        private void prev_click(object sender, RoutedEventArgs e) {
            cvm.Index--;
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e) {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btn_Lvl_start(object sender, RoutedEventArgs e) {
            cvm = new CharacterViewModel();
            this.DataContext = cvm;
            cvm.Index++;
        }

        private void btn_Lvl_startingLvl(object sender, RoutedEventArgs e) {
            cvm = new CharacterViewModel();
            this.DataContext = cvm;
            cvm.AvailableLvlPoints = int.Parse(tb_Lvl_startingLvl.Text);
            cvm.Index++;
        }

    }
}
