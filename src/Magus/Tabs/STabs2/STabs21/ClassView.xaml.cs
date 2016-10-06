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

        bool changedByUser;
        bool nonTabChange;

        public ClassView() {
            InitializeComponent();
            changedByUser = true;
            nonTabChange = true;
        }

        private CharacterViewModel Context {
            get { return ((CharacterViewModel)((FrameworkElement)this.Parent).DataContext); } 
        }

        private void addButton_Click_1(object sender, RoutedEventArgs e) {
            Context.addCharacterClass(DataManager.BaseClasses.ElementAt(cb_Class_base.SelectedIndex));
            btn_Class_addBaseClass.IsEnabled = false;
        }

        private void addButton_Click_2(object sender, RoutedEventArgs e) {
            Context.addCharacterClass(Context.AvailableClassesForRace.ElementAt(cb_Class_adventurer.SelectedIndex));
            btn_Class_addAdventurerClass.IsEnabled = false;
        }

        private void cb_Class_base_SelectionChanged_1(object sender, SelectionChangedEventArgs e) {
            btn_Class_addBaseClass.IsEnabled = !Context.alreadyHasClass(DataManager.BaseClasses.ElementAt(cb_Class_base.SelectedIndex)) && Context.AvailableLvlPoints != 0;
        }

        private void cb_Class_adventurer_SelectionChanged_1(object sender, SelectionChangedEventArgs e) {
            if (cb_Class_adventurer.SelectedIndex != -1)
                btn_Class_addAdventurerClass.IsEnabled = !Context.alreadyHasClass(Context.AvailableClassesForRace.ElementAt(cb_Class_adventurer.SelectedIndex)) && Context.AvailableLvlPoints != 0;
        }

        private void btn_Class_DecreaseLvl(object sender, RoutedEventArgs e) {
            changedByUser = false;
            Context.decreaseClassLvl(tab_Class_pickedClasses.SelectedIndex);
            changedByUser = true;
        }

        private void btn_Class_IncreaseLvl(object sender, RoutedEventArgs e) {
            changedByUser = false;
            if (!Context.hasCharacterClassReachedMaxLvl(tab_Class_pickedClasses.SelectedIndex))
                Context.lvlUpClass(tab_Class_pickedClasses.SelectedIndex);
            changedByUser = true;
        }

        private void btn_Class_RemoveClass(object sender, RoutedEventArgs e) {
            Context.removeCharacterClass(tab_Class_pickedClasses.SelectedIndex);
        }

        private void dg_Class_lvl_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            e.Handled = true;
            if (changedByUser && nonTabChange) {
                changedByUser = false;
                DataGrid dg = sender as DataGrid;
                int selectedLvl = dg.SelectedIndex + 1;
                int index = tab_Class_pickedClasses.SelectedIndex;
                if (e.RemovedItems.Count >= 1) {
                    int previousLvl = (e.RemovedItems[0] as ClassValuesPerLvl).ValuesAtLvl;
                    if (selectedLvl < previousLvl)
                        Context.decreaseClassLvl(index, previousLvl - selectedLvl);
                    else {
                        if (Context.AvailableLvlPoints >= selectedLvl - previousLvl)
                            Context.lvlUpClass(index, selectedLvl - previousLvl);
                        else {
                            dg.UnselectAllCells();
                            dg.SelectedIndex = previousLvl - 1;
                        }
                    }
                }
                changedByUser = true;
            }
            nonTabChange = true;
        }

        private void tab_Class_picked_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            nonTabChange = false;
        }

    }
}
