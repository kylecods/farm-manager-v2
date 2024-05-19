using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace FarmManagerFrontEnd.Models;

public partial class RegisterViewModel : FormBaseViewModel
{
    [Required]
    [EmailAddress]
    [ObservableProperty]
    private string _email;

    [Required]
    [ObservableProperty]
    public string _password;

    [Required]
    [ObservableProperty]
    private string _confirmPassword;

    [RelayCommand]
    public Task Register(NavigationManager navigationManager) => FormSubmitAsync(navigationManager);

    protected override Task FormSubmitAsync(NavigationManager? navigationManager = null)
    {
        navigationManager!.NavigateTo("/");

        return Task.CompletedTask;
    }
}