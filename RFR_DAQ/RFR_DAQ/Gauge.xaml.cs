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

namespace RFR_DAQ
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
        public double value;   //Stores the str value

        public void ChangeValue() 
        {
            RotateTransform rotateStr1Spoke1 = new RotateTransform(value + 180);  //str value is changed into rotation in degrees
            Spoke1.RenderTransform = rotateStr1Spoke1; //arrow is rotated
            RotateTransform rotateStr1Spoke2 = new RotateTransform(value + 270);  //str value is changed into rotation in degrees
            Spoke2.RenderTransform = rotateStr1Spoke2;
            RotateTransform rotateStr1Spoke3 = new RotateTransform(value + 90);  //str value is changed into rotation in degrees
            Spoke3.RenderTransform = rotateStr1Spoke3;
        }
    }
}
