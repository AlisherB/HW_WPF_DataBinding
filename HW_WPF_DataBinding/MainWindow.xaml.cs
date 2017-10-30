using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace HW_WPF_DataBinding
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Employee> employees;

        public MainWindow()
        {
            InitializeComponent();

            Division d1 = new Division
            {
                Id = 1,
                DivisionName = "Director"
            };
            Division d2 = new Division
            {
                Id = 2,
                DivisionName = "Worker"
            };


            employees = new ObservableCollection<Employee>
            (
                new List<Employee>
                {
                    new Employee
                    {
                        Id = 1, Name = "Vasya", Surname = "Pupkin", DivisionName = d1
                    },
                    new Employee
                    {
                        Id = 2, Name = "Ivan", Surname = "Petrovich", DivisionName = d2
                    },
                    new Employee
                    {
                        Id = 3, Name = "Petr", Surname = "Ivanov", DivisionName = d2
                    },
                }
            );
            employeesGrid.ItemsSource = employees;
        }
    }
}
