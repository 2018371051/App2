using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App2.ViewModel
{
    class MainPageViewModel : ViewModelBase
    {
        private string _nombre;

        public MainPageViewModel()
        {
            _nombre = "Holi";   
        }

        public string Nombre 
        { 
            get => _nombre;
            set {
                if (string.Equals(_nombre, value)) return;
                var data = _nombre.CompareTo(value);
                _nombre = value;
                RaisedPropertyChanged(nameof(Nombre));
                RaisedPropertyChanged(nameof(SinUpdate));
            }
        }
        public string SinUpdate
        {
            get => _nombre;
        }
    }

}
