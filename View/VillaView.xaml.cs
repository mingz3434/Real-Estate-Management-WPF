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

namespace Modern_Real_Estate.View
{
    /// <summary>
    /// Interaction logic for VillaView.xaml
    /// </summary>
    public partial class VillaView : UserControl
    {
        public DataGrid dataGrid;
        public VillaView()
        {
            InitializeComponent();
            dataGrid = dataGrid1;
        }
    }
}
