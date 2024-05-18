using Microsoft.AspNetCore.Components;

namespace FarmManagerFrontEnd.Components.Controls.Buttons;

public sealed partial class BasicButton : ComponentBase
{
    [Parameter] public EventCallback OnClick { get; set; }
    
    [Parameter] public string Text { get; set; }
}