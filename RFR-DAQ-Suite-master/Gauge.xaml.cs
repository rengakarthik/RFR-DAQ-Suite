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

namespace RFR_DAQ_Suite
{
    /// <summary>
    /// Interaction logic for Gauge.xaml
    /// </summary>
    
    public partial class Gauge : UserControl
    {
        public Gauge()
        {
            InitializeComponent();
        }
        public double value1;   //Stores the str value
        public double value2;

        public void ChangeValue() 
        {
            RotateTransform rotate1 = new RotateTransform(value1);  //str value is changed into rotation in degrees
            Arrow1.RenderTransform = rotate1; //arrow is rotated 

            RotateTransform rotate2 = new RotateTransform(value2);
            Arrow2.RenderTransform = rotate2;
        }
    }
}
