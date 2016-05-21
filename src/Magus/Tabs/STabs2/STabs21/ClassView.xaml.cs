using Magus.Data;
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
    /// Interaction logic for ClassView.xaml
    /// </summary>
    public partial class ClassView : UserControl {
        public ClassView() {
            InitializeComponent();
        }

        private void addButton_Click_1(object sender, RoutedEventArgs e) {
            ((CharacterViewModel)((FrameworkElement)this.Parent).DataContext).addCharacterClass(DataManager.BaseClasses.ElementAt(cb_Class_base.SelectedIndex));
            tab_Class_pickedClasses.ItemsSource = ((CharacterViewModel)((FrameworkElement)this.Parent).DataContext).GetCharacter.CharClasses;
            btn_Class_addBaseClass.IsEnabled = false;
        }

        private void addButton_Click_2(object sender, RoutedEventArgs e) {
            var context = ((CharacterViewModel)((FrameworkElement)this.Parent).DataContext);
            context.addCharacterClass(context.AvailableClassesForRace.ElementAt(cb_Class_adventurer.SelectedIndex));
            tab_Class_pickedClasses.ItemsSource = context.GetCharacter.CharClasses;
            btn_Class_addAdventurerClass.IsEnabled = false;
        }

        private void cb_Class_adventurer_DropDownOpened_1(object sender, EventArgs e) {
            cb_Class_adventurer.ItemsSource = ((CharacterViewModel)((FrameworkElement)this.Parent).DataContext).AvailableClassesForRace;
        }

        private void cb_Class_base_SelectionChanged_1(object sender, SelectionChangedEventArgs e) {
            btn_Class_addBaseClass.IsEnabled = !((CharacterViewModel)((FrameworkElement)this.Parent).DataContext).alreadyHasClass(DataManager.BaseClasses.ElementAt(cb_Class_base.SelectedIndex));
        }

        private void cb_Class_adventurer_SelectionChanged_1(object sender, SelectionChangedEventArgs e) {
            var context = ((CharacterViewModel)((FrameworkElement)this.Parent).DataContext);
            btn_Class_addAdventurerClass.IsEnabled = !context.alreadyHasClass(context.AvailableClassesForRace.ElementAt(cb_Class_adventurer.SelectedIndex));
        }

    }
}
