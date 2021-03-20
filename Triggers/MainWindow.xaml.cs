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

namespace Triggers
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Styles.SimpleTriggers simpleTriggers = new Styles.SimpleTriggers();
            simpleTriggers.ShowDialog();
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            Styles.EventTriggers eventTriggers = new Styles.EventTriggers();
            eventTriggers.ShowDialog();
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            Sample.DataTriggers dataTriggers = new Sample.DataTriggers();
            dataTriggers.ShowDialog();
        }
    }
}
