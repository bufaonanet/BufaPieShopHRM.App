using BufaPieShopHRM.App.Models;
using BufaPieShopHRM.App.Services;
using BufaPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BufaPieShopHRM.App.Pages;

public partial class EmployeeOverview
{
    [Inject]
    public IEmployeeDataService EmployeeDataService { get; set; }

    public List<Employee>? Employees { get; set; } = default!;

    private Employee? _selectedEmployee;

    private string Title = "Employee overview";

    //protected override void OnInitialized()
    //{
    //    Employees = MockDataService.Employees;
    //}

    protected override async Task OnInitializedAsync()
    {
        Employees = (await EmployeeDataService.GetAllEmployees(refreshRequired: false))
            .ToList();
    }

    public void ShowQuickViewPopup(Employee selectedEmployee)
    {
        _selectedEmployee = selectedEmployee;
    }
}