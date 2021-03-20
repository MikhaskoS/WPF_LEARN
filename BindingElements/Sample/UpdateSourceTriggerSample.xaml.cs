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

namespace BindingElements.Sample
{
    /// <summary>
    /// Логика взаимодействия для UpdateSourceTriggerSample.xaml
    /// </summary>
    public partial class UpdateSourceTriggerSample : Window
    {
        public UpdateSourceTriggerSample()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        private void BtnUpdateSource_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression binding =
            txtWindowTitle.GetBindingExpression(TextBox.TextProperty);
            binding.UpdateSource();
        }
    }
}
