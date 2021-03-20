using ListViewBinding.Data;
using System.Windows;
using System.Windows.Controls;


namespace ListViewBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Добавление вручную
            //EmployeeList.Items.Add(new ListViewItem());
            
            //Данные отобразятся так, как будет переопределен ToString()
            //EmployeeList.ItemsSource = TestData.Employees;
        }
    }
}
