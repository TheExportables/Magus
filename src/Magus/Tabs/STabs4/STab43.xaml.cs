using Magus.Data;
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

namespace Magus.Tabs.STabs4
{
    /// <summary>
    /// Interaction logic for STab43.xaml
    /// </summary>
    public partial class STab43 : UserControl
    {
        public STab43()
        {
            InitializeComponent();
            this.DataContext = DataManager.Instance;
        }
    }
}
