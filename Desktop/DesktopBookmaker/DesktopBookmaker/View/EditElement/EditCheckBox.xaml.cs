using InterfaceView.View;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace DesktopBokmeyker.View.EditElement
{
    /// <summary>
    /// Логика взаимодействия для EditCheckBox.xaml
    /// </summary>
    public partial class EditCheckBox 
        : UserControl, IEditControl
    {
        public String NameItem { get; set; }

        public Boolean? IsCheked
        {
            get => title.IsChecked;
            set
            {
                if (!IsNullable && value is null)
                    throw new ArgumentNullException(nameof(value));

                title.IsChecked = value;
            }
        }

        public Object Title
        {
            get => title.IsChecked;
            set => title.IsChecked = (Boolean?)value;
        }

        public Boolean IsNullable
        {
            get => title.IsThreeState;
            set => title.IsThreeState = value;
        }

        public String Hint
        {
            get => title.Content.ToString();
            set => title.Content = value?.ToString();
        }

        public EditCheckBox()
        {
            InitializeComponent();
        }
    }
}
