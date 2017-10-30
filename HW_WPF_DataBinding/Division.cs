using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HW_WPF_DataBinding
{
    public class Division : INotifyPropertyChanged
    {
        private long id;
        private string divisionName;

        public ObservableCollection<Employee> Employees { get; set; }

        public Division()
        {
            Employees = new ObservableCollection<Employee>();
        }
        
        public long Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }
        }
        
        public string DivisionName
        {
            get { return divisionName; }
            set { divisionName = value; OnPropertyChanged("DivisionName"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
