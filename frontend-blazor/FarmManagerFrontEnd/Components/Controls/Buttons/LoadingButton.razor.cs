using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace FarmManagerFrontEnd.Components.Controls.Buttons;

public sealed partial class LoadingButton : ComponentBase
{
    [Parameter] public EventCallback<MouseEventArgs> OnClick { get; set; }
    
    [Parameter] public string Text { get; set; }
}