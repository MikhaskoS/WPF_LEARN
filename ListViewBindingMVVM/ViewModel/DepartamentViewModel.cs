using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListViewBindingMVVM.ViewModel
{
    class DepartamentViewModel : BaseViewModel
    {
        private string _name;

        public string Name { get => _name; set => Set(ref _name, value); }
    }
}
