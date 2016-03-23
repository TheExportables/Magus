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
using System.Windows.Shapes;

namespace Magus.Controls
{
    /// <summary>
    /// Interaction logic for ColorDialog.xaml
    /// </summary>
    public partial class ColorDialog : Window {

        public ColorDialog() : this(Colors.Black){ }

        public ColorDialog(Color initialColor){
            InitializeComponent();
            colorPicker.InitialColor = initialColor;
        }

        public Color SelectedColor
        {
            get { return colorPicker.SelectedColor; }
            set { colorPicker.InitialColor = value; }
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

    }
}
