
using System.ComponentModel;

namespace MVVMDemo.Models.ViewModels
{
    internal class EmployeeDetailViewModel : INotifyPropertyChanged
    {
        private string employeeName;
        public int EmployeeId { get; set; }
        public string EmployeeName
        {
            get { return employeeName; }

            set
            {
                employeeName = value;
                NotifyPropertyChanged(nameof(EmployeeName));
            }
        }
        public string Email { get; set; }
        public bool IsPartTime { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged; //required for INotifyPropertyChanged

        private void NotifyPropertyChanged(string propertyName)
        {
            // notifies UI when a property changes
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
