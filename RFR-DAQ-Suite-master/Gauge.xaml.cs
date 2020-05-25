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
            RotateTransform rotateStr1Spoke1 = new RotateTransform(value1);  //str value is changed into rotation in degrees
            Spoke1.RenderTransform = rotateStr1Spoke1; //arrow is rotated
            RotateTransform rotateStr1Spoke2 = new RotateTransform(value1 + 120);  //str value is changed into rotation in degrees
            Spoke2.RenderTransform = rotateStr1Spoke2;
            RotateTransform rotateStr1Spoke3 = new RotateTransform(value1 + 240);  //str value is changed into rotation in degrees
            Spoke3.RenderTransform = rotateStr1Spoke3;
        }
    }
}
