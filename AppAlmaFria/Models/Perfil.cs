using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAlmaFria.Models
{
	public class Perfil
	{
		public required string ProfileImage { get; set; }
		public required string Name { get; set; }

		public int NPhotos { get; set; }
	}
}
