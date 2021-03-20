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
using System.Windows.Shapes;

namespace Commands
{
    // https://www.nuget.org/packages/Microsoft.Xaml.Behaviors.Wpf/#
    // https://github.com/microsoft/XamlBehaviorsWpf

    /// <summary>
    /// Логика взаимодействия для ExtCommand.xaml
    /// </summary>
    public partial class ExtCommand : Window
    {
        public ExtCommand()
        {
            InitializeComponent();
            DataContext = new ApplicationViewModel();
        }
    }
}
