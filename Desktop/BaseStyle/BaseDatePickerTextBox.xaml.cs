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
	/// Логика взаимодействия для BaseDatePickerTextBox.xaml
	/// </summary>
	public partial class BaseDatePickerTextBox 
		: UserControl
	{
		public String BackText
		{
			get => text.BackText;
			set => text.BackText = (value);
		}

		public DateTime DateTime
		{
			get => DateTime.Parse(text.Text);
			set => text.Text = (value).ToString("F");
		}

		public BaseDatePickerTextBox()
		{
			InitializeComponent();
		}

		private String content;

		private void text_LostFocus(object sender, RoutedEventArgs e)
		{
			if (DateTime.TryParse(text.Text, out DateTime date))
				DateTime = date;

			else
				text.Text = content;
		}

		private void text_GotFocus(object sender, RoutedEventArgs e)
			=> content = text.Text;
	}
}
