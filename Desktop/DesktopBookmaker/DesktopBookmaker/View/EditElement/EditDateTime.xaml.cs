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

namespace DesktopBookmaker.View.EditElement
{
    /// <summary>
    /// Логика взаимодействия для EditDateTime.xaml
    /// </summary>
    public partial class EditDateTime
        : UserControl, IEditControl
    {
        private bool isNullable;

        public EditDateTime()
        {
            InitializeComponent();
        }

        public string Hint 
        {
            get => hint.Text;
            set => hint.Text = value;
        }
        public object Title 
        {
            get => check.IsChecked == true ? null : (Object)title.DateTime;
            set
            {
                if ((value is null) && check.Visibility == Visibility.Visible)
                    check.IsChecked = false;
                else
                    title.DateTime = DateTime.Parse((value).ToString());
            }
        }
        public string NameItem { get; set; }
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
    }
}
