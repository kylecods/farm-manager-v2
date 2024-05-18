using System.Diagnostics.CodeAnalysis;
using FarmManagerFrontEnd.Models;
using Microsoft.AspNetCore.Components;

namespace FarmManagerFrontEnd.Components.Shared;

public class MvvmComponentBase<TViewModel> : ComponentBase where TViewModel : BaseViewModel
{
    [Inject]
    [NotNull]
    protected TViewModel ViewModel { get; set; }

    protected override void OnInitialized()
    {
        ViewModel.PropertyChanged += (_, _) => StateHasChanged();
    }
}