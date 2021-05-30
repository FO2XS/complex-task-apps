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
        private List<CheckBox> getActiveItems;

        protected ViewSortingData()
        {
            InitializeComponent();
        }

        public List<BaseSyle.CheckBox> GetActiveItems
        {
            get => getActiveItems;
            private set => getActiveItems = value;
        }

        public ViewSortingData(List<BaseSyle.CheckBox> boxes)
            : this()
        {
            comboBox.DisplayMemberPath = nameof(BaseSyle.CheckBox.Title);
            boxes.ForEach(x => { x.Margin = new Thickness(10, 0, 10, 0); comboBox.Items.Add(x); x.Routed += deleteItem; });
            GetActiveItems = new List<CheckBox>();
        }

        public void SelectAnItem(BaseSyle.CheckBox box)
        {
            comboBox.SelectedItem = box;
        }

        private void AddItem(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedItem is null)
                return;

            var ob = comboBox.SelectedItem;
            if (!(ob is BaseSyle.CheckBox))
                throw new InvalidCastException($"Не получилось привести тип {ob.GetType()} к типу {nameof(BaseSyle.CheckBox)}");

            var checkBox = (BaseSyle.CheckBox)ob;

            comboBox.Items.Remove(ob);
            panel.Children.Add(checkBox);
            GetActiveItems.Add(checkBox);
            if (comboBox.Items.Count < 1)
                comboBox.IsHitTestVisible = false;
        }

        private void deleteItem(object sender, EventArgs e)
        {
            if (!(sender is BaseSyle.CheckBox))
                throw new InvalidCastException($"Не получилось привести тип {sender.GetType()} к типу {nameof(BaseSyle.CheckBox)}");

            var ob = (BaseSyle.CheckBox)sender;

            panel.Children.Remove(ob);
            comboBox.Items.Add(ob);
            GetActiveItems.Remove(ob);
            comboBox.IsHitTestVisible = true;
        }
    }
}
