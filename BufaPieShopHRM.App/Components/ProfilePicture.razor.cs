using Microsoft.AspNetCore.Components;

namespace BufaPieShopHRM.App.Components;

public partial class ProfilePicture
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}