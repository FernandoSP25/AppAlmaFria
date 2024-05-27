using AppAlmaFria.Clases;
using AppAlmaFria.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAlmaFria.Models
{
	public class CategoriaModel:BaseBinding
	{
		private List<CategoriaCLS> _lista;

		public List<CategoriaCLS> Lista
		{ 
			get { 
				return _lista;
			} 
			set {
				SetValue(ref _lista , value); 
			}
		}

	}
}
