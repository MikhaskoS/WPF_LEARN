using MVVM;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

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

        #region Commands

        public ICommand CreateEmployeeCommand { get; }
        private void OnCreateEmployeeCommand(object param)
        {
            var new_employe = new EmployeeViewModel
            {
                Name  = "NewEmployeeName"
            };
            _employees.Insert(0, new_employe);
            SelectedEmploye = new_employe;
        }
        private bool CanCreateEmployeeCommand(object param)
        { return true; }
        public ICommand RemoveEmployeeCommand { get; }
        private void OnRemoveEmployeeCommand(object param)
        {
            if (!(param is EmployeeViewModel employee)) return;
            _employees.Remove(employee);
            if (ReferenceEquals(_selectedEmploye, employee))
                SelectedEmploye = null;
        }
        private bool CanRemoveEmployeeCommand(object param)
        { 
            return (param is EmployeeViewModel); 
        }

        #endregion

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


            CreateEmployeeCommand = new RelayCommand(OnCreateEmployeeCommand, CanCreateEmployeeCommand);
            RemoveEmployeeCommand = new RelayCommand(OnRemoveEmployeeCommand, CanRemoveEmployeeCommand);
        }
    }
}
