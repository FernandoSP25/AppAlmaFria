namespace AppAlmaFria.Views;

public partial class ProductPage : ContentPage
{
	public string titulo { get; set; }
	public ProductPage(string nombreCategoria)
	{
		titulo = nombreCategoria;
		InitializeComponent();

		BindingContext = this; 
	}
}