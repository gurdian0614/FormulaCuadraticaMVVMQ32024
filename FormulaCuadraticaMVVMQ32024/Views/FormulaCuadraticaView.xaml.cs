using FormulaCuadraticaMVVMQ32024.ViewModels;

namespace FormulaCuadraticaMVVMQ32024.Views;

public partial class FormulaCuadraticaView : ContentPage
{
	private FormulaCuadraticaViewModel ViewModel;
	public FormulaCuadraticaView()
	{
		InitializeComponent();
		ViewModel = new FormulaCuadraticaViewModel();
		BindingContext = ViewModel;
	}
}