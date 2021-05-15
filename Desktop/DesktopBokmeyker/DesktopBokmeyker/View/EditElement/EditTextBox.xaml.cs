using InterfaceView.View;
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

namespace DesktopBokmeyker.View.EditElement
{
    /// <summary>
    /// Логика взаимодействия для EditTextBox.xaml
    /// </summary>
    public partial class EditTextBox
        : UserControl, IEditControl
    {
        private bool isNullable;

        public String Hint
        {
            get => hint.Text;
            set
            {
                hint.Text = (value);
                title.BackText = value;
            }
        }
        public Object Title
        {
            get => check.IsChecked == true ? null : title.Text;
            set
            {
                if ((value is null) && check.Visibility == Visibility.Visible)
                    check.IsChecked = false;
                else
                    title.Text = value.ToString();
            }
        }
        public String NameItem { get; set; }

        public bool IsNullable
        {
            get => isNullable;
            set
            {
                isNullable = value;

                if (isNullable)
                    check.Visibility = Visibility.Visible;
            }
        }


        public EditTextBox()
        {
            InitializeComponent();
        }

    }
}
