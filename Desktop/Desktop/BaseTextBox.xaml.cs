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

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для BaseTextBox.xaml
    /// </summary>
    public partial class BaseTextBox
        : UserControl
    {
        public BaseTextBox()
        {
            InitializeComponent();
        }

        public String BackText { get; set; } = "вфцв";
        public Style BorderStyle { get; set; } = null;
        public String Text { get => textBox.Text; set => textBox.Text = value; }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            bTextBlock.Text = BackText;

            border.Style = BorderStyle
                ?? border.Style;
        }
    }
}
