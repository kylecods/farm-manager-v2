using Microsoft.AspNetCore.Components;

namespace FarmManagerFrontEnd.Models
{
    public abstract class FormBaseViewModel : BaseViewModel
    {
        protected abstract Task FormSubmitAsync(NavigationManager? navigationManager = null);
    }
}
