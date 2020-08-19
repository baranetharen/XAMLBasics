using System.ComponentModel;


namespace WpfXml.Model
{
   
    public class Customer  : ObjectChangedNotification
    {
        private string _firstName;
        public string FirstName { get { return _firstName; } set { _firstName = value; OnPropertyChange(); } }
        public string _lastName;
        public string LastName { get { return _lastName; } set { _lastName = value; OnPropertyChange(); } }
        private bool _isDeveloper;
        public bool IsDeveloper { get { return _isDeveloper; } set { _isDeveloper = value; OnPropertyChange(); } }
    }
}
