using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace ListViewBindingMVVM.ViewModel
{
    class MainWindowViewModel : BaseViewModel
    {
        private string _title = "Заголовок окна";
        private ObservableCollection<EmployeeViewModel> _employees =
            new ObservableCollection<EmployeeViewModel>();
        private ObservableCollection<DepartamentViewModel> _department;
        private EmployeeViewModel _selectedEmploye;

        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }
        public ObservableCollection<EmployeeViewModel> Employees
        {
            get => _employees;
            set => Set(ref _employees, value);
        }
        public ObservableCollection<DepartamentViewModel> Departaments
        {
            get => _department;
            set => Set(ref _department, value);
        }
        public EmployeeViewModel SelectedEmploye
        {
            get => _selectedEmploye;
            set => Set(ref _selectedEmploye, value);
        }

        public MainWindowViewModel()
        {
            foreach (var employee in Enumerable.Range(1, 100).Select(i => new EmployeeViewModel
            {
                Id = i,
                Name = $"Имя {i}",
                SurName = $"Фамилия {i}",
                Patronymic = $"Отчество {i}",
                DayOfBirth = DateTime.Now.Subtract(TimeSpan.FromDays(365 / 6 * (i + 18)))
            }))
                _employees.Add(employee);

            _department = new ObservableCollection<DepartamentViewModel>(
                Enumerable.Range(1,10).Select(i => new DepartamentViewModel { Name =$"Отдел{i}"}));
        }
    }
}
