using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfXml
{
    public class ObjectChangedNotification : INotifyPropertyChanged
    {
        protected virtual void OnPropertyChange([CallerMemberName]string name =null)
        {
            PropertyChangedEventHandler propertyChangedEventArgs = PropertyChanged;
            if(propertyChangedEventArgs!=null)
            {
                propertyChangedEventArgs.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
