using AppAlmaFria.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAlmaFria.Models
{
	public class LoginModel:BaseBinding
	{
		private string _email;
		public string Email
		{
			get => _email;
			set
			{
				_email = value;
				OnPropertyChanged(nameof(Email));
			}
		}

		private string _password;
		public string Password
		{
			get => _password;
			set
			{
				_password = value;
				OnPropertyChanged(nameof(Password));
			}
		}
	}
}
