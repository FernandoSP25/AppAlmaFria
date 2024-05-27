namespace AppAlmaFria.Views;

using AppAlmaFria.Clases;
using AppAlmaFria.Models;
using Microsoft.Maui.Controls;
public partial class CategoriaPage : ContentPage
{
	private List<CategoriaCLS> listaTotal;
	public CategoriaModel oCategoriaModel { get; set; }
	public string nombreCategoria { get; set; }
	public CategoriaCLS oCategoriaCLS { get; set; }
	public CategoriaPage()
	{
		InitializeComponent();

		oCategoriaModel = new CategoriaModel();
		oCategoriaModel.Lista = new List<CategoriaCLS>()
		{
			new CategoriaCLS{idCategoria = 1,nombreCategoria = "Paletas sin relleno"},
			new CategoriaCLS{idCategoria = 2,nombreCategoria = "Paletas con relleno"},
			new CategoriaCLS{idCategoria = 3,nombreCategoria = "Helados"},
			new CategoriaCLS{idCategoria = 4,nombreCategoria = "Bebidas"}
		};
		listaTotal = oCategoriaModel.Lista;
		BindingContext = this;
	}

	private void searchCategoria_TextChanged(object sender, TextChangedEventArgs e)
	{
		var filtro = listaTotal.Where(p => p.nombreCategoria.ToUpper().Contains(nombreCategoria.ToUpper())).ToList();
		oCategoriaModel.Lista = filtro;
		//DisplayAlert("Valor", nombreCategoria, "Cancelar");
	}

	private void lstProducts_ItemTapped(object sender, ItemTappedEventArgs e)
	{
		string nombreCategoria = oCategoriaCLS.nombreCategoria;
		int idCategoria = oCategoriaCLS.idCategoria;

		DisplayAlert("Valor", idCategoria + " -- " + nombreCategoria, "Cancelar");

		App.Current.MainPage = new ProductPage(nombreCategoria);
	}
}