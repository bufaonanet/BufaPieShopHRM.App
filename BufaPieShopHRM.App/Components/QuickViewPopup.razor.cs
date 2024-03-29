using BufaPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BufaPieShopHRM.App.Components;

public partial class QuickViewPopup
{
    private Employee? _employee;

    [Parameter]
    public Employee? Employee { get; set; }

    protected override void OnParametersSet()
    {
        _employee = Employee;
    }

    public void Close()
    {
        _employee = null;   
    }
}