using MVVMDemo.Models;
using MVVMDemo.Models.ViewModels;

namespace MVVMDemo.Pages;

public partial class EmployeeListPage : ContentPage
{
	public EmployeeListPage()
	{
		InitializeComponent();

		BindingContext = new EmployeesViewModel();
	}

    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		var employee = (Employee)e.Item; // Get the tapped employee
		var employeeDetailViewModel2 = new EmployeeDetailViewModel2 { Employee = employee }; // Create a new EmployeeDetailViewModel2 object with the tapped employee
		var employeeDetailPage = new EmployeeDetailPage(); // Create a new EmployeeDetailPage object
		employeeDetailPage.BindingContext = employeeDetailViewModel2; // Set the BindingContext of the EmployeeDetailPage object to the EmployeeDetailViewModel2 object
		Navigation.PushAsync(employeeDetailPage); // Push the EmployeeDetailPage object onto the navigation stack
    }
}