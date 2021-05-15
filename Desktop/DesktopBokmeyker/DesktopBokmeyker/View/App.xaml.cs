using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DesktopBokmeyker
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App 
        : Application
    {
        [System.Diagnostics.DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent1()
        {
/*#line 4 "..\..\App.xaml"
            this.StartupUri = new Uri("MainWindow.xaml", System.UriKind.Relative);
#line default
#line hidden*/
        }

        [System.STAThread()]
        [System.Diagnostics.DebuggerNonUserCode()]
        [System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        public static void Main()
        {
/*          DesktopBokmeyker.App app = new DesktopBokmeyker.App();
            app.InitializeComponent1();
            app.Run();*/
            DesktopBokmeyker.View.MainWindow mainWindow = new View.MainWindow();
            mainWindow.ShowDialog();
        }
    }
}
