using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Multiservicios_Criogenicos.ViewModels;

public partial class RegisterViewModel : ObservableObject
{
    [ObservableProperty]
private string _fullName = "";

[ObservableProperty]
private string _email = "";

[ObservableProperty]
private string _password = "";

[ObservableProperty]
private string _confirmPassword = "";

public ObservableCollection<string> Ranks { get; } = new()
{
    "Usuario",
    "Administrador",
};

[ObservableProperty]
private string _selectedRank = "Usuario";

[RelayCommand]
private void Register()
{
    // Aquí va la lógica de registro después
    //  ejemplo:
    System.Diagnostics.Debug.WriteLine($"Registrando: {FullName}, {Email}, Rango: {SelectedRank}");
}

}