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

namespace BaseSyle
{
    /// <summary>
    /// Логика взаимодействия для SearchTextBox.xaml
    /// </summary>
    public partial class SearchTextBox 
        : UserControl
    {
        public SearchTextBox()
            =>  InitializeComponent();

        public String BackText { get; set; } = "...";

        public Style BorderStyle { get; set; } = null;
        public Style ButtonStyle { get; set; } = null;

        public String Text { get => textBox.Text; set => textBox.Text = value; }

        public event RoutedEventHandler SearchClick;
        
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            bTextBlock.Text = BackText;

            border.Style = BorderStyle
                ?? border.Style;

            button.Style = ButtonStyle
                ?? button.Style;
        }

        private void Button_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
            => SearchClick?.Invoke(sender, e);
    }
}
