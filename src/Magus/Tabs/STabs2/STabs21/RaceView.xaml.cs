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
    /// Interaction logic for RaceView.xaml
    /// </summary>
    public partial class RaceView : UserControl {
        public RaceView() {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            ((CharacterViewModel)((FrameworkElement)this.Parent).DataContext).Index++;
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e) {
            var characterVM = ((CharacterViewModel)((FrameworkElement)this.Parent).DataContext);
            tb_Race_title.Visibility = Visibility.Visible;
            sp_Race_stats.Visibility = Visibility.Visible;
            sp_Race_modifiers.Visibility = Visibility.Visible;
            btn_Race_next.IsEnabled = true;
            characterVM.getAvailableClassesForRace();
            characterVM.removeDependantCharacterClasses();
        }
    }
}
