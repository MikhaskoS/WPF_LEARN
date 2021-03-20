using System.Windows;

namespace Commands
{
    public class ApplicationViewModel
    {
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                 (addCommand = new RelayCommand(obj =>
                 {
                     MessageBox.Show("Привет!", "Пример");
                 }));
            }
        }
        
        private RelayCommand paramCommand;
        public RelayCommand ParamCommand
        {
            get
            {
                return paramCommand ??
                 (paramCommand = new RelayCommand(
                     obj =>
                     {
                         string s = obj as string;
                         MessageBox.Show(s, "Пример");
                     },
                     obj => obj != null));
            }
        }

        private RelayCommand dblCommand;
        public RelayCommand DblCommand
        {
            get
            {
                return dblCommand ??
                 (dblCommand = new RelayCommand(obj =>
                 {
                     MessageBox.Show("Двойное нажатие.", "Круто!");
                 }));
            }
        }
    }
}
