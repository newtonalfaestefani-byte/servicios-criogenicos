using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Multiservicios_Criogenicos.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial string Usuario { get; set; } = "";
    [ObservableProperty]
    public partial string Contraseña { get; set; } = "";

    [ObservableProperty]
    public partial bool IsLoginVisible { get; set; } = true;

    [ObservableProperty]
    public partial bool IsRegistrationVisible { get; set; }

    public RegisterViewModel Registration { get; } = new();

    [RelayCommand]
    private void ShowRegistration()
    {
        IsLoginVisible = false;
        IsRegistrationVisible = true;
    }

    [RelayCommand]
    private void ShowLogin()
    {
        IsRegistrationVisible = false;
        IsLoginVisible = true;
    }
}
