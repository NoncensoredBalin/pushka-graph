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

namespace PushkaGraph.Gui
{
    // TODO: отрефакторить xaml
    /// <summary>
    /// Interaction logic for VertexControl.xaml
    /// </summary>
    public partial class VertexControl : UserControl
    {
        // TODO: сделать number свойством
        public VertexControl(int number)
        {
            InitializeComponent();
            VertexNumber.Content = number;
            MouseEnter += (sender, args) => EllipseControl.StrokeThickness = 4;
            MouseLeave += (sender, args) => EllipseControl.StrokeThickness = 2;
        }
    }
}
