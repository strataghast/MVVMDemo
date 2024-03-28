using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.Models.ViewModels
{
    internal partial class EmployeeDetailViewModel2 : ObservableObject
    {
        // partial class allows the class to be split into multiple files (required to inherit from ObservableObject)

        [ObservableProperty]
        private Employee employee;
    }
}
