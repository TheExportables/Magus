using Magus.Data;
using Magus.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Magus.Tabs.STabs2.STabs21 {
    /// <summary>
    /// Interaction logic for SumView.xaml
    /// </summary>
    public partial class SumView : UserControl {
        public SumView() {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e) {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btn_Sum_end_Click_1(object sender, RoutedEventArgs e) {
            DataManager.Characters.Add(((CharacterViewModel)((FrameworkElement)this.Parent).DataContext).GetCharacter);
        }

        private void tb_Sum_name_TextChanged_1(object sender, TextChangedEventArgs e) {
            if (tb_Sum_name.Text != null || tb_Sum_name.Text != "")
                btn_Sum_end.IsEnabled = true;
            else
                btn_Sum_end.IsEnabled = false;
        }
    }
}
