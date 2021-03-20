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

using BindingElements.Sample;
using DataBinding;

namespace BindingElements
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SimpleBinding wind = new SimpleBinding();
            wind.ShowDialog();
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            MultipleBindings multi = new MultipleBindings();
            multi.ShowDialog();
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            ConverterSample converter = new ConverterSample();
            converter.ShowDialog();
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            DataContextSample dataContext = new DataContextSample();
            dataContext.ShowDialog();
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            UpdateSourceTriggerSample updateSource = new UpdateSourceTriggerSample();
            updateSource.ShowDialog();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            ObservableINotify observableINotify = new ObservableINotify();
            observableINotify.ShowDialog();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            FontChooser fontChooser = new FontChooser();
            fontChooser.ShowDialog();
        }
    }
}
