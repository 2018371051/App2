using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App2.ViewModel
{
    class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisedPropertyChanged(string nombrePropiedad)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nombrePropiedad));
        }
    }
}
