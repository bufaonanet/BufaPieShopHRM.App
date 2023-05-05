using BufaPieShopHRM.App.Models;

namespace BufaPieShopHRM.App.Components.Widget;

public partial class EmployeeCountWidget
{
    public int EmployeeCounter { get; set; }

    protected override void OnInitialized()
    {
        EmployeeCounter = MockDataService.Employees.Count;
    }
}