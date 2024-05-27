using AppAlmaFria.Clases;
using AppAlmaFria.Models;
using System.Collections.ObjectModel;

namespace AppAlmaFria.Views;

public partial class HomePage : ContentPage
{
	public CategoriaModel oCategoriaModel { get; set; }
	public ProductosModel oProductosModel { get; set; }

	public HomePage()
	{
		InitializeComponent();

		oCategoriaModel = new CategoriaModel();
		oCategoriaModel.Lista = new List<CategoriaCLS>()
		{
			new CategoriaCLS{idCategoria = 1,
				nombreCategoria = "Sin relleno",
				icon = "p_relleno.png"
			},
			new CategoriaCLS{idCategoria = 2,
				nombreCategoria = "Con relleno",
				icon = "paleta.png"
			},
			new CategoriaCLS{idCategoria = 3,
				nombreCategoria = "Helados",
				icon = "helado.png"
			},
			new CategoriaCLS{idCategoria = 4,
				nombreCategoria = "Bebidas",
				icon = "bebidas.png"
			},
				new CategoriaCLS{idCategoria = 5,
				nombreCategoria = "Ligth",
				icon = "helado.png"
			}
		};

		oProductosModel = new ProductosModel();

		oProductosModel.Listap = new List<ProductosCLS>()
		{
			new ProductosCLS
			{
				nombreProducto = "Paleta de fresas",
				descripcion ="Cada mordisco de esta paleta " +
				"es una explosión de sabor que te transportará a un campo de fresas en plena floración." +
				" La dulzura natural de la fruta se mezcla con la cremosidad del helado," +
				" creando una experiencia sensorial única. ",
				image = "fresa_paleta.jpg"
			},
			new ProductosCLS
			{
				nombreProducto = "Paleta de chocolate",
				descripcion ="La textura suave y aterciopelada de la paleta se desliza por tu lengua, " +
				"liberando una explosión de sabor a chocolate que te transportará a un paraíso de placer. " +
				"Cada mordisco es una sinfonía de sensaciones, " +
				"desde la dulzura inicial hasta el toque amargo del cacao que te dejará con ganas de más. ",
				image = "pcr_chocolate.jpg"
			},
			new ProductosCLS
			{
				nombreProducto = "Paleta",
				descripcion ="Sabrosa ",
				image = "menta_helado.jpg"
			},



		};



		BindingContext = this;
	}
}