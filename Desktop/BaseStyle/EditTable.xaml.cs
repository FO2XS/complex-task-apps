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
		public Boolean IsActive { get; set; }

		public ListView ListView
		{
			get => list;
			set => list = value ?? list;
		}
		public Object SelectedItem
		{
			get => ((ICloneable)selectedItem)?.Clone();
			set => selectedItem = ((ICloneable)value)?.Clone();
		}
		public Tooltip Tooltip { get; }
		public String TableName { get; set; }
		public List<Func<object, bool>> GetFuncs { get; set; } = new List<Func<object, bool>>();


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

			UserControl_Loaded_1();
		}

		private void data_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
		{
            try
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
				catch (Exception ex)
				{
					Tooltip.Show("Не удалось найти выделенный элемент в коллекции Items", Library.TypeEvent.ProgramError, $"Ошибка в таблице {TableName}");
					return;
				}

				try
				{
					View.UpdateEditWindow(EditControls, SelectedItem);
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
			}
            finally
            {
				e.Cancel = true;
			}
		}

		private void BorderMenu_MouseLeave(object sender, MouseEventArgs e)
		{
			if (ListView.IsHitTestVisible == false)
				BorderMenu.IsHitTestVisible = false;
		}

		private async void UserControl_Loaded_1()
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

			UpdateTable(true);

			try
			{
				View.LoadEditWindow(ListView);
			}
			catch (Exception ex)
			{
				Tooltip.Show(ex.Message, Library.TypeEvent.ProgramError, $"Ошибка в таблице {TableName}");
				await Task.Delay(3000);
			}

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
					await Task.Delay(5000);
				}
				catch (Exception ex)
				{
					Tooltip.Show(ex.Message, Library.TypeEvent.ProgramError, $"Ошибка в таблице {TableName}");
					await Task.Delay(2000);
				}
                finally
                {
					UpdateTable(true);
					Tooltip.Show("Данные синхронизированы!");
				}
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

				Tooltip.Show("Данные обновлены и успешно синхронизированы!");

				ButtonIsEdit.Content = "Редактировать";

				ButtonSaveChange.IsEnabled = false;
				ListView.IsHitTestVisible = false;

				UpdateTable(true);
				await Task.Delay(300);

				IsActive = false;
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

		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (ButtonSaveChange.IsEnabled)
			{
				ListView.IsHitTestVisible = false;
				ButtonSaveChange.IsEnabled = false;

				ButtonIsEdit.Content = "Редактировать";

				View.UpdateEditWindow(EditControls, SelectedItem);

				IsActive = false;
			}
			else
            {
				ListView.IsHitTestVisible = true;
				ButtonSaveChange.IsEnabled = true;
				ButtonIsEdit.Content = "Отменить";

				IsActive = true;
			}
		}

        private void data_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
			if (ButtonSaveChange.IsEnabled)
			{
				foreach (Object item in data.ItemsSource)
					if (((IComparable)item).CompareTo(SelectedItem) == 0)
					{ data.SelectedItem = item; break; }

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

			IsActive = true;
		}

		private async void ButtonSaveChangeAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
				var ob = View.GetUpdateInEditWindow(EditControls, null);

				await Control.AddAsync(ob);

				SelectedItem = ob;

				Items.Add(ob);

				UpdateTable(true);

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
				Tooltip.Show(ex.Message, Library.TypeEvent.ProgramError, $"Ошибка в таблице {TableName}");
				return;
			}
            finally
            {
				IsActive = false;
			}
		}

        private async void ButtonCancle_Click(object sender, RoutedEventArgs e)
        {
			ButtonSaveChangeAdd.Visibility = Visibility.Collapsed;

			IsActive = false;

			await Task.Delay(300);

			BorderMenu.IsHitTestVisible = false;
			ListView.IsHitTestVisible = false;
		}

		public async void UpdateTable(Boolean isUpdateDate = false)
        {
			data.Columns.Clear();

			if (isUpdateDate)
				await Control.SearchAsync(Items, GetFuncs);

			data.ItemsSource = null;
			data.Columns.Clear();

			data.ItemsSource = Items;
			
			View.ViewTable(data);

			if (!(SelectedItem is null))
				foreach (Object item in data.ItemsSource)
					if(((IComparable)item).CompareTo(SelectedItem) == 0) 
					{ data.SelectedItem = item; break; }
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
