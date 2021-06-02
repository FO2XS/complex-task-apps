using InterfaceView.View;
using System;
using System.Collections;
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

namespace DesktopBookmaker.View.EditElement
{
    /// <summary>
    /// Логика взаимодействия для EditComboBox.xaml
    /// </summary>
    public partial class EditComboBox
        : UserControl, IEditControl
    {
        private bool isNullable;

        public string Hint 
        {
            get => hint.Text;
            set => hint.Text = value;
        }

        public Object Title 
        {
            get => check.IsChecked == true ? null : title.SelectedValue;
            set
            {
                if ((value is null) && check.Visibility == Visibility.Visible)
                {
                    check.IsChecked = true;
                    title.SelectedItem = null; 
                    SelectedItemChanged?.Invoke(this, new RoutedEventArgs());
                }
                else
                {
                    title.SelectedValue = value;
                    check.IsChecked = false;
                }
            }
        }
        
        public Boolean? IsChecked
        {
            get => check.IsChecked;
            set => check.IsChecked = value;
        }

        public bool IsNullable
        {
            get => isNullable;
            set
            {
                isNullable = value;

                if (isNullable) 
                { 
                    check.Visibility = Visibility.Visible;
                    check.IsChecked = true;
                }
            }
        }

        public String NameItem { get; set; }

        public IEnumerable Items
        {
            get => title.ItemsSource;
            set => title.ItemsSource = value;
        }


        public EditComboBox()
        {
            InitializeComponent();
        }

        public event RoutedEventHandler SelectedItemChanged;
        
        private void title_Selected(object sender, RoutedEventArgs e)
            => SelectedItemChanged?.Invoke(sender, e);

        private void check_Checked(object sender, RoutedEventArgs e)
        {
            title.SelectedItem = null;
        }
    }
}
