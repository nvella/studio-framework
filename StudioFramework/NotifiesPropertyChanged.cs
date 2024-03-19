using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudioFramework
{

    public class NotifiesPropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        protected void SetField<T>(out T field, T value, [CallerMemberName] string? propertyName = null)
        {
            field = value;
            if(propertyName is not null) OnPropertyChanged(propertyName);
        }
    }
}
