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
    /// Логика взаимодействия для ViewSortingData.xaml
    /// </summary>
    public partial class ViewSortingData
        : UserControl
    {
        protected ViewSortingData()
        {
            InitializeComponent();
        }

        public ViewSortingData(List<BaseSyle.CheckBox> boxes)
        {
            comboBox.DisplayMemberPath = nameof(BaseSyle.CheckBox.check.Content);
            boxes.ForEach(x => comboBox.Items.Add(x));
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
