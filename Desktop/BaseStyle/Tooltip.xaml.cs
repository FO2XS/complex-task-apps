using BaseSyle.Library;
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
    /// Логика взаимодействия для Tooltip.xaml
    /// </summary>
    public partial class Tooltip
        : UserControl
    {
        private TypeEvent typeEvent;

        public TypeEvent TypeEvent 
        {
            get => typeEvent;
            set
            {
                typeEvent = value;
                TypeEventChange(value);

            }
        }

        public String Title
        {
            get => title.Text;
            set => title.Text = value;
        }

        public String Description
        {
            get => description.Text;
            set => description.Text = value;
        }

        private void TypeEventChange(TypeEvent value)
        {
            switch (value)
            {
                case TypeEvent.Notification:
                    Toltip.Background = new SolidColorBrush(Colors.YellowGreen); /// FromRgb(69, 90, 100)
                    Title = Title == "" ? "Сообщение!" : title.Text;
                    break;
                    
                case TypeEvent.ProgramError:
                    Toltip.Background = new SolidColorBrush(Colors.Red);
                    Title = Title == "" ? "Программная ошибка!" : title.Text;
                    break;

                case TypeEvent.ErrorUser:
                    Toltip.Background = new SolidColorBrush(Colors.Red);
                    Title = Title == "" ? "Ошибка!" : title.Text;
                    break;
                default:
                    break;
            }
        }

        public Tooltip()
        {
            InitializeComponent();
        }

        public async void Show(String description, TypeEvent type = TypeEvent.Notification, String title = "")
        {
            Description = description;
            Title = title;
            TypeEvent = type;


            IsHitTestVisible = false;

            await Task.Delay(200);
            progressBar.Value = 0;

            IsHitTestVisible = true;
        }

        private async void this_IsHitTestVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsHitTestVisible == false)
                return;

            while (progressBar.Value < progressBar.Maximum)
            {
                progressBar.Value++;
                await Task.Delay(10);
            }

            this.IsHitTestVisible = false;
        }
    }
}
