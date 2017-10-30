using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HW_WPF_DataBinding
{
    public class Employee : INotifyPropertyChanged
    {
        private long id;
        private string name;
        private string surname;
        
        private Division division;

        public long Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; OnPropertyChanged("Surname"); }
        }
       
        public Division DivisionName
        {
            get { return division; }
            set { division = value; OnPropertyChanged("DivisionName"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
