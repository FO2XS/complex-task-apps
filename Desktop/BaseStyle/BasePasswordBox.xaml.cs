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

namespace BaseSyle
{
    /// <summary>
    /// Логика взаимодействия для BasePasswordBox.xaml
    /// </summary>
    public partial class BasePasswordBox 
        : UserControl
    {
        public BasePasswordBox()
        {
            InitializeComponent();
        }

        public String BackText { get; set; } = "...";
        public Style BorderStyle { get; set; } = null;
        public String Text { get => textBox.Password; set => textBox.Password = value; }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            bTextBlock.Text = BackText;

            border.Style = BorderStyle
                ?? border.Style;
        }
    }
}
