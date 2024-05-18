using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;

namespace FarmManagerFrontEnd.Models;

public partial class LoginViewModel : BaseViewModel
{
    [Required] [EmailAddress] [ObservableProperty] private string _email;

    [Required] [ObservableProperty] private string _password;

    [ObservableProperty] private bool _rememberMe;

    [RelayCommand]
    public Task LoginSubmit(NavigationManager navigationManager)
    {
        return IsBusyFor(async () =>
        {
            await Task.Delay(3000);
            navigationManager.NavigateTo("register");
        });
    }
}