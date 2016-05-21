using Magus.Model;
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

namespace Magus.Tabs.STabs2.STabs21 {
    /// <summary>
    /// Interaction logic for CharacteristicView.xaml
    /// </summary>
    public partial class CharacteristicView : UserControl {
        public CharacteristicView() {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e) {
            cb_Characteristic_2.ItemsSource = ((CharacterViewModel)((FrameworkElement)this.Parent).DataContext).availableCharacteristicFor2();
            cb_Characteristic_2.SelectedItem = Characteristic.Üres;
            btn_Characteristic_next.IsEnabled = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            ((CharacterViewModel)((FrameworkElement)this.Parent).DataContext).Index++;
        }
    }
}
