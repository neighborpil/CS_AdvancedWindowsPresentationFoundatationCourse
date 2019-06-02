using System.Collections.ObjectModel;

namespace DataContextExample2
{
    public class SampleData
    {
        public ObservableCollection<Employee> Employees = new ObservableCollection<Employee>();

        public SampleData()
        {
            Employees.Add(new Employee{ EmployeeName =  "Kim Kim1"});
            Employees.Add(new Employee{ EmployeeName =  "Kim Kim2"});
            Employees.Add(new Employee{ EmployeeName =  "Kim Kim3"});
            Employees.Add(new Employee{ EmployeeName =  "Kim Kim4"});
            Employees.Add(new Employee{ EmployeeName = "Kim Kim5" });
        }
    }
}