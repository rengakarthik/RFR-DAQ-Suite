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

namespace iss_bar_ho_jaega
{
    /// <summary>
    /// Interaction logic for bps1.xaml
    /// </summary>
    public partial class bps1 : UserControl
    {
        public bps1()
        {
            InitializeComponent();
        }
        public double value;

        public void changeValue()
        {
            RotateTransform rotatePointer = new RotateTransform(value);  //str value is changed into rotation in degrees
            Pointer.RenderTransform = rotatePointer; //pointer is rotated
        }
    }
}
