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
using System.Windows.Shapes;

namespace SeatedSensor
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            one.Fill = new SolidColorBrush(System.Windows.Media.Colors.Green);
            two.Fill = new SolidColorBrush(System.Windows.Media.Colors.Green);
            three.Fill = new SolidColorBrush(System.Windows.Media.Colors.Green);
            four.Fill = new SolidColorBrush(System.Windows.Media.Colors.Green);
            five.Fill = new SolidColorBrush(System.Windows.Media.Colors.Green);

        }

       
    }
}
