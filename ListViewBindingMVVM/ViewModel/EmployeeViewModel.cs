using System;

namespace ListViewBindingMVVM.ViewModel
{
    class EmployeeViewModel : BaseViewModel
    {
        private string _name;
        private string _surName;
        private string _patronymic;
        private DateTime _dayOfBirth;

        public int Id { get; set; }

        // так следует переопределить и остальные свойства
        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }
        public string SurName
        {
            get => _surName;
            set => Set(ref _surName, value);
        }
        public string Patronymic
        {
            get => _patronymic;
            set => Set(ref _patronymic, value);
        }
        public DateTime DayOfBirth
        {
            get => _dayOfBirth;
            // Нам нужно, чтобы при изменении даты рождения менялся возраст
            set { if(Set(ref _dayOfBirth, value))
                    OnPropertyChanged(nameof(Age)); }
        }

        public int Age => (int)Math.Floor((DateTime.Now - DayOfBirth).TotalDays / 365);

    }
}
