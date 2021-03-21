using System;
using System.Timers;


namespace MVVM.ViewModel
{
    class OtherWindowViewModel : BaseViewModel
    {
        private Timer _timer;
        private string _title = "Заголовок окна";
        private DateTime _currentTime;

        public string Title { get => _title; set => _title = value; }
        public DateTime CurrentTime
        {
            get => _currentTime;
            //set
            //{
            //    if (Equals(_currentTime, value)) return;
            //    _currentTime = value;
            //    OnPropertyChanged();
            //}
            // упрощаем
            set => Set(ref _currentTime, value);
        }

        public OtherWindowViewModel()
        {
            _timer = new Timer(100) { AutoReset = true};
            _timer.Elapsed += OnTimerTick;
            _timer.Start();
        }

        private void OnTimerTick(object sender, ElapsedEventArgs e)
        {
            CurrentTime = DateTime.Now;
        }
    }
}
