using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Логика взаимодействия для ObservableINotify.xaml
    /// </summary>
    public partial class ObservableINotify : Window
    {
        // ObservableCollection - особая коллекция. Любые изменения в ней автоматически передаются
        // в интерфейс приложения
        private ObservableCollection<User> users = new ObservableCollection<User>();
        public ObservableINotify()
        {
            InitializeComponent();
            users.Add(new User() { Name = "Петя" });
            users.Add(new User() { Name = "Коля" });
            lbUsers.ItemsSource = users;

        }
        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User() { Name = "Вася" });
        }
        private void btnChangeUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
                (lbUsers.SelectedItem as User).Name = "Иван";
        }
        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
                users.Remove(lbUsers.SelectedItem as User);
        }
    }

    // INotifyPropertyChanged - позволяет автоматически вносить изменения во все
    // привязанные к свойству поля
    public class User : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    this.NotifyPropertyChanged("Name");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}


