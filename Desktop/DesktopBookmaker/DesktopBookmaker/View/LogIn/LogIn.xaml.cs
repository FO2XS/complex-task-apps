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

namespace DesktopBookmaker.View.LogIn
{
	/// <summary>
	/// Логика взаимодействия для LogIn.xaml
	/// </summary>
	public partial class LogIn 
		: UserControl
	{
		public Tooltip Tooltip { get; set; }

		public LogIn()
		{
			InitializeComponent();
		}

		public event RoutedEventHandler CloseEvent;
		public event RoutedEventHandler LogInEvent;

		private void CloseClick(object sender, RoutedEventArgs e)
			=> CloseEvent?.Invoke(sender, e);

		private void LogInClick(object sender, RoutedEventArgs e)
		{
			if (String.IsNullOrWhiteSpace(logIn.Text) || String.IsNullOrEmpty(pass.Text))
			{
				if (Tooltip is null)
					MessageBox.Show("tooltip is null забыл передать в logIn");
				else
					Tooltip.Show("Некорректные данные!", BaseSyle.Library.TypeEvent.ErrorUser);
				
				return;
			}

			LogInEvent?.Invoke(sender, e);
		}
	}
}
