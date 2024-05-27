using AppAlmaFria.Clases;
using AppAlmaFria.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAlmaFria.Models
{
    public class ProductosModel:BaseBinding
	{
		private List<ProductosCLS> _listap;

		public List<ProductosCLS> Listap
		{
			get
			{
				return _listap;
			}
			set
			{
				SetValue(ref _listap, value);
			}
		}
	}
}
