using FormulaCuadraticaMVVMQ32024.Views;
namespace FormulaCuadraticaMVVMQ32024
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new FormulaCuadraticaView());
        }
    }
}
