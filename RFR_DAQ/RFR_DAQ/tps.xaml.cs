﻿using System;
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
    /// Interaction logic for tps.xaml
    /// </summary>
    public partial class tps : UserControl
    {
        public tps()
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