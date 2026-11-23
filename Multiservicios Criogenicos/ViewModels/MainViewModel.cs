using CommunityToolkit.Mvvm.ComponentModel;

namespace Multiservicios_Criogenicos.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial string Usuario { get; set; } = "";
    [ObservableProperty]
    public partial string Contraseña { get; set; } = "";
}
