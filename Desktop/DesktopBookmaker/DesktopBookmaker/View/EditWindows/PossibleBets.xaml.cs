using BaseSyle;
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

namespace DesktopBookmaker.View.EditWindows
{
    /// <summary>
    /// Логика взаимодействия для PossibleBets.xaml
    /// </summary>
    public partial class PossibleBets : UserControl
    {
        public Tooltip Tooltip { get; private set; }

        protected PossibleBets()
        {
            InitializeComponent();
        }

        public PossibleBets(Tooltip tooltip)
            : this()
        {
            Tooltip = tooltip;
        }


        private void SearchTextBox_SearchClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
