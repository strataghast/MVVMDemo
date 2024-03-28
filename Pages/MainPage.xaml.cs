using MVVMDemo.Models.ViewModels;

namespace MVVMDemo.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void employeeButton1_Clicked(object sender, EventArgs e)
    {
        //var employeeDetailViewModel = new EmployeeDetailViewModel2
        //{
        //    EmployeeId = 1,
        //    EmployeeName = "John Doe",
        //    Email = "johndoe@gmail.com",
        //    IsPartTime = true
        //};
        //var employeeDetailPage = new EmployeeDetailPage();
        //employeeDetailPage.BindingContext = employeeDetailViewModel;
        //Navigation.PushAsync(employeeDetailPage);
    }

    private void employeeButton2_Clicked(object sender, EventArgs e)
    {
        //var employeeDetailViewModel = new EmployeeDetailViewModel2
        //{
        //    EmployeeId = 2,
        //    EmployeeName = "Jane Smith",
        //    Email = "janesmith@gmail.com",
        //    IsPartTime = false
        //};
        //var employeeDetailPage = new EmployeeDetailPage();
        //employeeDetailPage.BindingContext = employeeDetailViewModel;
        //Navigation.PushAsync(employeeDetailPage);
    }

    private void employeeButton3_Clicked(object sender, EventArgs e)
    {
        //var employeeDetailViewModel = new EmployeeDetailViewModel2
        //{
        //    EmployeeId = 1,
        //    EmployeeName = "Codey McCodeface",
        //    Email = "code@gmail.com",
        //    IsPartTime = true
        //};
        //var employeeDetailPage = new EmployeeDetailPage();
        //employeeDetailPage.BindingContext = employeeDetailViewModel;
        //Navigation.PushAsync(employeeDetailPage);
    }
}