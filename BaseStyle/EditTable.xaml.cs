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
			if (SaveChange.IsEnabled)
            {
				Tooltip.Show("Сохраните или отмените изменения!", Library.TypeEvent.ErrorUser);
				e.Cancel = true;

				return;
			}

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
			if (ListView.IsEnabled == false)
				BorderMenu.IsHitTestVisible = false;
		}

		private async void UserControl_Loaded_1(object sender, RoutedEventArgs e)
		{
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

			Tooltip.Show("Данные полностью загружены");
		}

		private void DeleteItem_Click(object sender, RoutedEventArgs e) { }

		private async void SaveChange_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				SelectedItem = View.GetUpdateInEditWindow(EditControls, SelectedItem);

				await Control.EditAsync(SelectedItem);

				Tooltip.Show("Данные добавлены и успешно синхронизированы!");

				SaveChange.IsEnabled = false;
				ListView.IsEnabled = false;
			}
			catch (ExceptionForUser ex)
			{
				Tooltip.Show(ex.Message, Library.TypeEvent.ErrorUser, ex.Title);
				return;
			}
			catch (Exception ex)
			{
				Tooltip.Show(ex.InnerException.Message, Library.TypeEvent.ProgramError, $"Ошибка в таблице {TableName}");
				return;
			}

			data.ItemsSource = null;
			data.Columns.Clear();

			data.ItemsSource = Items;

			View.ViewTable(data);

		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (SaveChange.IsEnabled)
			{
				ListView.IsEnabled = false;
				SaveChange.IsEnabled = false;

				IsEdit.Content = "Редактировать";

				View.UpdateEditWindow(EditControls, SelectedItem);
			}
			else
            {
				ListView.IsEnabled = true;
				SaveChange.IsEnabled = true;
				IsEdit.Content = "Отменить";
			}
		}
	}
}
