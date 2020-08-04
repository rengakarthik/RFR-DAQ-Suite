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
    /// Interaction logic for Gauge1.xaml
    /// </summary>
    public partial class Gauge1 : UserControl
    {
        public Gauge1()
        {
            InitializeComponent();
        }

        public double value;

        public void ChangeValue()
        {
            RotateTransform rotateStr2Spoke1 = new RotateTransform(value);
            Spoke1.RenderTransform = rotateStr2Spoke1;
            RotateTransform rotateStr2Spoke2 = new RotateTransform(value + 240);
            Spoke2.RenderTransform = rotateStr2Spoke2;
            RotateTransform rotateStr2Spoke3 = new RotateTransform(value + 120);
            Spoke3.RenderTransform = rotateStr2Spoke3;
        } 
    }
}
