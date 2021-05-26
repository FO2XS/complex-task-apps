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
using InterfaceView.View;

namespace BaseSyle
{
    /// <summary>
    /// Логика взаимодействия для CheckBox.xaml
    /// </summary>
    public partial class CheckBox 
        : UserControl
    {
        public String NameItem { get; set; }

        public Boolean? IsCheked 
        {
            get => check.IsChecked;
            set
            {
                if (!IsNullable && value is null)
                    throw new ArgumentNullException(nameof(value));

                check.IsChecked = value;
            }
        }

        public Object Title
        {
            get => check.Content.ToString();
            set => check.Content = value?.ToString();
        }

        public Boolean IsNullable
        {
            get => check.IsThreeState;
            set => check.IsThreeState = value;
        }

        public String Hint
        {
            get => check.Content?.ToString(); 
            set => check.Content = value?.ToString();
        }

        public CheckBox()
        {
            InitializeComponent();
        }

        public event RoutedEventHandler Routed;

        private void Button_Click(object sender, RoutedEventArgs e)
            => Routed?.Invoke(this, e);
    }
}
