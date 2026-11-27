using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Multiservicios_Criogenicos.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private async void AbrirCrearCuenta_Click(object? sender, RoutedEventArgs e)
    {
        CrearCuenta crearCuenta = new CrearCuenta();
        await crearCuenta.ShowDialog(this);
    }

}