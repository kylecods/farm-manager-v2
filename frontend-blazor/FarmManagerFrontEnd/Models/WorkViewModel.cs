using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace FarmManagerFrontEnd.Models;

public partial class WorkViewModel : BaseViewModel
{
    [ObservableProperty] private IQueryable<Worker> _workers;
    
    [RelayCommand]
    private async Task LoadItems()
    {
        var local = new HashSet<Worker>();
       await IsBusyFor(async () =>
        {
           await Task.Delay(2000);
           local.Add(new Worker
           {
               WorkerName = "Frank",
               WorkerPhoneNumber = "+254713452672"
           });
        });

        Workers = local.AsQueryable();
    }
    
}

public class Worker
{
    public string WorkerName { get; set; }

    public string WorkerPhoneNumber { get; set; }
}
