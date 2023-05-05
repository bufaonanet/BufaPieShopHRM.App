using Microsoft.AspNetCore.Components;

namespace BufaPieShopHRM.App.Components.Widget;

public partial class InboxWidget
{
    [Inject]
    public ApplicationState ApplicationState { get; set; }

    public int MessageCount { get; set; } = 0;

    protected override void OnInitialized()
    {
        MessageCount = ApplicationState.NumberOfMessages;
    }
}