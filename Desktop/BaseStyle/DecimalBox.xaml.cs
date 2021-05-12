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
    /// Логика взаимодействия для DecimalBox.xaml
    /// </summary>
    public partial class DecimalBox 
        : UserControl
    {
        public String BackText
        {
            get => text.BackText;
            set => text.BackText = (value);
        }

        public Decimal Value
        {
            get => Decimal.Parse(text.Text);
            set => text.Text = (value).ToString("");
        }

        public DecimalBox()
        {
            InitializeComponent();
        }

        private String content;

        private void text_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Decimal.TryParse(text.Text, out Decimal value))
                Value = value;

            else
                text.Text = content;
        }

        private void text_GotFocus(object sender, RoutedEventArgs e)
            => content = text.Text;
    }
}
