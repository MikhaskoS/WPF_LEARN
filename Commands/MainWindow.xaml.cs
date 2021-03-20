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

namespace Commands
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            CustomCommand button1 = new CustomCommand();
            button1.ShowDialog();
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            CommandParameter commandParameter = new CommandParameter();
            commandParameter.ShowDialog();
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            ExtCommand extCommand = new ExtCommand();
            extCommand.ShowDialog();
        }
    }
}
