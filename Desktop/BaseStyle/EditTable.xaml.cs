using InterfaceView;
using InterfaceView.Control;
using InterfaceView.View;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;



namespace BaseSyle
{
	/// <summary>
	/// Логика взаимодействия для EditTable.xaml
	/// </summary>
	public partial class EditTable
		: UserControl
	{
		public ListView ListView
		{
			get => list;
			set => list = value ?? list;
		}
		public Object SelectedItem
		{
			get => selectedItem;
			set => selectedItem = value;
		}
		public Tooltip Tooltip { get; }
		public String TableName { get; set; }


		private object selectedItem;
		private IView View { get; }
		private IControl Control { get; }
		private List<IEditControl> EditControls { get; set; } = new List<IEditControl>();
		private List<Object> Items { get; set; }

		protected EditTable()
		{
			InitializeComponent();
		}

		public EditTable(IView view, IControl control, Tooltip tooltip)
			: this()
		{
			View = view;
			Control = control;
			Tooltip = tooltip;
		}

		private void data_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
		{
			if (ButtonSaveChange.IsEnabled || ButtonSaveChangeAdd.Visibility == Visibility.Visible)
            {
				Tooltip.Show("Сохраните или отмените изменения!", Library.TypeEvent.ErrorUser);

				e.Cancel = true;
				return;
			}

			ButtonDelete.Visibility = Visibility.Visible;
			ButtonIsEdit.Visibility = Visibility.Visible;
			ButtonSaveChange.Visibility = Visibility.Visible;

			ButtonSaveChangeAdd.Visibility = Visibility.Collapsed;
			ButtonCancle.Visibility = Visibility.Collapsed;

			BorderMenu.IsHitTestVisible = true;

			try
			{
				SelectedItem = Items.Find(x => x.Equals(data.SelectedItem));
			}
			catch (Exception)
			{
				Tooltip.Show("Не удалось найти выделенный элемент в коллекции Items", Library.TypeEvent.ProgramError, $"Ошибка в таблице {TableName}");
			}

			try
			{
				View.UpdateEditWindow(EditControls, SelectedItem);
			}
			catch (ExceptionForUser ex)
			{
				Tooltip.Show(ex.Message, Library.TypeEvent.ErrorUser, ex.Title);
			}
			catch (Exception ex)
			{
				Tooltip.Show(ex.Message, Library.TypeEvent.ProgramError, $"Ошибка в таблице {TableName}");
			}
			
			e.Cancel = true;
		}

		private void BorderMenu_MouseLeave(object sender, MouseEventArgs e)
		{
			if (ListView.IsHitTestVisible == false)
				BorderMenu.IsHitTestVisible = false;
		}

		private async void UserControl_Loaded_1(object sender, RoutedEventArgs e)
		{
			Visibility = Visibility.Collapsed;

			Items = new List<Object>();

			Tooltip.Show("Загрузка данных");

			try
			{
				await Control.GetDataAsync(Items);
			}
			catch (Exception ex)
			{
				Tooltip.Show(ex.Message, Library.TypeEvent.ProgramError, $"Ошибка в таблице {TableName}");
				await Task.Delay(3000);
			}

			data.ItemsSource = Items;

			try
			{
				await View.LoadEditWindow(ListView);
			}
			catch (Exception ex)
			{
				Tooltip.Show(ex.Message, Library.TypeEvent.ProgramError, $"Ошибка в таблице {TableName}");
				await Task.Delay(3000);
			}

			View.ViewTable(data);

			foreach (IEditControl item in ListView.Items)
				EditControls.Add(item);

			Visibility = Visibility.Visible;

			Tooltip.Show("Данные полностью загружены");
		}

		private async void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить?","Предупреждение!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {
					await Control.DeleteAsync(SelectedItem);

					Tooltip.Show("Строка успешна удалена!");
				}
				catch (ExceptionForUser ex)
				{
					Tooltip.Show(ex.Message, Library.TypeEvent.ErrorUser, ex.Title);
					return;
				}
				catch (Exception ex)
				{
					Tooltip.Show(ex.Message, Library.TypeEvent.ProgramError, $"Ошибка в таблице {TableName}");
					return;
				}

				UpdateTable();
			}
            else
            {
				Tooltip.Show("Строка НЕ удалена!");
			}
		}

		
		private async void SaveChange_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				SelectedItem = View.GetUpdateInEditWindow(EditControls, SelectedItem);

				await Control.EditAsync(SelectedItem);

				Tooltip.Show("Данные добавлены и успешно синхронизированы!");


				ButtonIsEdit.Content = "Редактировать";
				ButtonSaveChange.IsEnabled = false;


				UpdateTable();
				await Task.Delay(300);

				ButtonSaveChange.IsEnabled = false;

			}
			catch (ExceptionForUser ex)
			{
				Tooltip.Show(ex.Message, Library.TypeEvent.ErrorUser, ex.Title);
				return;
			}
			catch (Exception ex)
			{
				Tooltip.Show(ex.Message, Library.TypeEvent.ProgramError, $"Ошибка в таблице {TableName}");
				return;
			}
            finally
            {
				ButtonIsEdit.Content = "Редактировать";

				ButtonSaveChange.IsEnabled = false;
				ListView.IsEnabled = false;
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (ButtonSaveChange.IsEnabled)
			{
				ListView.IsHitTestVisible = false;
				ButtonSaveChange.IsEnabled = false;

				ButtonIsEdit.Content = "Редактировать";

				View.UpdateEditWindow(EditControls, SelectedItem);
			}
			else
            {
				ListView.IsHitTestVisible = true;
				ButtonSaveChange.IsEnabled = true;
				ButtonIsEdit.Content = "Отменить";
			}
		}

        private void data_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
			if (ButtonSaveChange.IsEnabled)
			{
				data.SelectedItem = SelectedItem;

				Tooltip.Show("Сохраните или отмените изменения!", Library.TypeEvent.ErrorUser);
			}
		}

        private void AddItem(object sender, RoutedEventArgs e)
        {
			BorderMenu.IsHitTestVisible = true;
			ListView.IsHitTestVisible = true;

			View.UpdateEditWindow(EditControls, null);

			ButtonDelete.Visibility = Visibility.Collapsed;
			ButtonIsEdit.Visibility = Visibility.Collapsed;
			ButtonSaveChange.Visibility = Visibility.Collapsed;

			ButtonSaveChangeAdd.Visibility = Visibility.Visible;
			ButtonCancle.Visibility = Visibility.Visible;
		}

        private async void ButtonSaveChangeAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
				var ob = View.GetUpdateInEditWindow(EditControls, null);

				await Control.AddAsync(ob);

				Items.Add(ob);

				UpdateTable();

				Tooltip.Show("Данные успешно добавлены!");

				ButtonCancle_Click(sender, null);
			}
			catch (ExceptionForUser ex)
			{
				Tooltip.Show(ex.Message, Library.TypeEvent.ErrorUser, ex.Title);
				return;
			}
			catch (Exception ex)
			{
				Tooltip.Show(ex.InnerException.InnerException.Message, Library.TypeEvent.ProgramError, $"Ошибка в таблице {TableName}");
				return;
			}
		}

        private async void ButtonCancle_Click(object sender, RoutedEventArgs e)
        {
			ButtonSaveChangeAdd.Visibility = Visibility.Collapsed;

			await Task.Delay(300);

			BorderMenu.IsHitTestVisible = false;
			ListView.IsHitTestVisible = false;
		}

		private void UpdateTable()
        {
			data.ItemsSource = null;
			data.Columns.Clear();

			data.ItemsSource = Items;

			View.ViewTable(data);
		}

        private void data_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{

			}
			finally
			{
				e.Handled = true;
			}
        }

        private void data_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            try
            {

            }
            finally
			{
				e.Cancel = true;
			}
        }

        private void data_PreviewKeyDown(object sender, KeyEventArgs e)
        {
			try
			{

			}
			finally
			{
				e.Handled = true;
			}
		}
    }
}
