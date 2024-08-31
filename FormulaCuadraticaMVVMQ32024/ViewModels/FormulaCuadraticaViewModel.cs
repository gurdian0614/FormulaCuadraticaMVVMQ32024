using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace FormulaCuadraticaMVVMQ32024.ViewModels
{
    public partial class FormulaCuadraticaViewModel : ObservableObject
    {
        [ObservableProperty]
        private double a;

        [ObservableProperty]
        private double b;

        [ObservableProperty]
        private double c;

        [ObservableProperty]
        private double x1;

        [ObservableProperty]
        private double x2;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void calcular()
        {
            try
            {
                double discriminante;

                if (A == 0)
                {
                    Alerta("ADVERTENCIA", "Valor de a no debe ser cero");
                }
                else
                {
                    discriminante = Math.Pow(B, 2) - (4 * A * C);

                    if (discriminante >= 0)
                    {
                        X1 = (-B + Math.Sqrt(discriminante)) / (2 * A);
                        X2 = (-B - Math.Sqrt(discriminante)) / (2 * A);
                    }
                    else
                    {
                        Alerta("ADVERTENCIA", "La raíz cuadrada no debe ser negativa");
                    }
                }
            }
            catch (Exception ex)
            {
                Alerta("ERROR", ex.Message);
            }
        }

        [RelayCommand]
        private void Limpiar()
        {
            A = 0;
            B = 0;
            C = 0;
            X1 = 0;
            X2 = 0;
        }
    }
}
