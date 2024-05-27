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
				"es una explosi�n de sabor que te transportar� a un campo de fresas en plena floraci�n." +
				" La dulzura natural de la fruta se mezcla con la cremosidad del helado," +
				" creando una experiencia sensorial �nica. ",
				image = "fresa_paleta.jpg"
			},
			new ProductosCLS
			{
				nombreProducto = "Paleta de chocolate",
				descripcion ="La textura suave y aterciopelada de la paleta se desliza por tu lengua, " +
				"liberando una explosi�n de sabor a chocolate que te transportar� a un para�so de placer. " +
				"Cada mordisco es una sinfon�a de sensaciones, " +
				"desde la dulzura inicial hasta el toque amargo del cacao que te dejar� con ganas de m�s. ",
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