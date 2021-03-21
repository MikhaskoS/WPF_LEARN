using System;
using System.ComponentModel;

namespace ListViewBinding.Models
{
    // INotifyPropertyChanged - позволяет сообщать приложению об изменении свойства
    // изменения автоматически отобразятся в соответствующих местах
    class Employee : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        public int Id { get; set; }

        // так следует переопределить и остальные свойства
        public string Name
        {
            get => _name; 
            set
            {
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }
        public string SurName { get; set; }
        public string Patronymic { get; set; }
        public DateTime DayOfBirth { get; set; }

        public int Age => (int)Math.Floor((DateTime.Now - DayOfBirth).TotalDays / 365);


        public override string ToString()
        {
            return $"Сотрудник[{Id}]:{SurName}";
        }
    }
}
