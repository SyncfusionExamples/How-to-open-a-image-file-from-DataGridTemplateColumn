using Syncfusion.Maui.Data;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SfDataGridSample
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Employee> _employees;
        private Employee _selectedEmployee;

        public EmployeeViewModel()
        {
            // Initialize with some sample data if needed
            Employees = new ObservableCollection<Employee>
            {
                new Employee { EmployeeID = 1001, Name = "John Doe", Designation = "Software Engineer", URL = "https://image.slidesharecdn.com/companybrochurev22014-150518190531-lva1-app6891/75/Syncfusion-Company-Brochure_May2015-1-2048.jpg",MapUrl = "https://img.freepik.com/free-vector/hand-drawn-delivery-concept-with-smartphone_23-2149149267.jpg" },
                new Employee { EmployeeID = 1002, Name = "Jane", Designation = "Project Manager", URL = "https://cdn.syncfusion.com/content/images/demo/v1/maui-mobile-platform.png?v=27092023103124",MapUrl="https://img.freepik.com/free-vector/isometric-construction-infographic-scheme_1284-17244.jpg?size=626&ext=jpg" },
                new Employee { EmployeeID = 1003, Name = "Smith", Designation = "Designer", URL = "https://image.slidesharecdn.com/companybrochurev22014-150518190531-lva1-app6891/75/Syncfusion-Company-Brochure_May2015-1-2048.jpg",MapUrl = "https://img.freepik.com/free-vector/hand-drawn-delivery-concept-with-smartphone_23-2149149267.jpg" },
                new Employee { EmployeeID = 1004, Name = "Allison", Designation = "Stocker", URL = "https://cdn.syncfusion.com/content/images/demo/v1/maui-mobile-platform.png?v=27092023103124" , MapUrl = "https://img.freepik.com/free-vector/hand-drawn-delivery-concept-with-smartphone_23-2149149267.jpg"},
                new Employee { EmployeeID = 1005, Name = "Paul", Designation = "Assistant", URL = "https://cdn.syncfusion.com/content/images/demo/v1/maui-mobile-platform.png?v=27092023103124", MapUrl="https://img.freepik.com/free-vector/hand-drawn-delivery-concept-with-smartphone_23-2149149267.jpg" },
                new Employee { EmployeeID = 1006, Name = "Jacobson", Designation = "Recruiter", URL = "https://cdn.syncfusion.com/content/images/demo/v1/maui-mobile-platform.png?v=27092023103124" ,MapUrl="https://img.freepik.com/free-vector/hand-drawn-delivery-concept-with-smartphone_23-2149149267.jpg" },
                new Employee { EmployeeID = 1007, Name = "Anderson", Designation = "Manager", URL = "https://cdn.syncfusion.com/content/images/demo/v1/maui-mobile-platform.png?v=27092023103124" , MapUrl = "https://img.freepik.com/free-vector/hand-drawn-delivery-concept-with-smartphone_23-2149149267.jpg"},
                new Employee { EmployeeID = 1008, Name = "Jack", Designation = "Designer", URL = "https://cdn.syncfusion.com/content/images/demo/v1/maui-mobile-platform.png?v=27092023103124" , MapUrl = "https://img.freepik.com/free-vector/hand-drawn-delivery-concept-with-smartphone_23-2149149267.jpg"},
                new Employee { EmployeeID = 1009, Name = "David", Designation = "Project Manager", URL = "https://cdn.syncfusion.com/content/images/demo/v1/maui-mobile-platform.png?v=27092023103124" , MapUrl = "https://img.freepik.com/free-vector/hand-drawn-delivery-concept-with-smartphone_23-2149149267.jpg"},
                new Employee { EmployeeID = 1010, Name = "Carl", Designation = "Assistant", URL = "https://cdn.syncfusion.com/content/images/demo/v1/maui-mobile-platform.png?v=27092023103124" , MapUrl = "https://img.freepik.com/free-vector/hand-drawn-delivery-concept-with-smartphone_23-2149149267.jpg"}

            };
        }

        public ObservableCollection<Employee> Employees
        {
            get => _employees;
            set
            {
                _employees = value;
                OnPropertyChanged(nameof(Employees));
            }
        }

        public Employee SelectedEmployee
        {
            get => _selectedEmployee;
            set
            {
                _selectedEmployee = value;
                OnPropertyChanged(nameof(SelectedEmployee));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
