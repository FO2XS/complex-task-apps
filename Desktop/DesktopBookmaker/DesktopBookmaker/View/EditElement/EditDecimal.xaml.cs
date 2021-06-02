using InterfaceView.View;
using System;
using System.Windows.Controls;
using System.Windows;

namespace DesktopBookmaker.View.EditElement
{
	/// <summary>
	/// Логика взаимодействия для EditDecimal.xaml
	/// </summary>
	public partial class EditDecimal 
		: UserControl, IEditControl
	{
		private bool isNullable;

		public EditDecimal()
		{
			InitializeComponent();
		}

		public string Hint
		{
			get => hint.Text;
			set
			{
				title.BackText = value;
				hint.Text = value;
			}
		}
		public object Title 
		{
			get => check.IsChecked == true ? null : (Object)title.Value;
			set
			{
				if ((value is null) && check.Visibility == Visibility.Visible)
					check.IsChecked = false;
				else
					title.Value = Decimal.Parse((value).ToString());
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
		
		public Func<Decimal, Boolean> Func
        {
			get => title.Func;
			set => title.Func = value;
        }
	}
}