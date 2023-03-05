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

namespace TabControl.Views
{
    /// <summary>
    /// Interaction logic for RefCountingControl.xaml
    /// </summary>
    public partial class RefCountingControl : UserControl
    {
        private static int _refCount;

        public RefCountingControl()
        {
            _refCount++;
            InitializeComponent();
            RefCount.Text = $"Instance Count {_refCount}";
        }
    }
}
