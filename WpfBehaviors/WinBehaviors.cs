using Microsoft.Xaml.Behaviors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfBehaviors
{
    public class WinBehaviors : Behavior<MainWindow>, INotifyPropertyChanged
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.MouseMove += AssociatedObject_MouseMove;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.MouseMove -= AssociatedObject_MouseMove;
        }

        private void AssociatedObject_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var obj = AssociatedObject;
            var cur_pos = e.GetPosition(obj);
            PosX = cur_pos.X;
        }

        private double _posX = 10;
        public double PosX
        {
            get => _posX; 
            set
            {
                _posX = value;
                OnPropertyChanged("PosX");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    
    }
}
