namespace AppAlmaFria.Views;

using AppAlmaFria.Models;
using Microsoft.Maui.Controls;

public partial class Login : ContentPage
{
	public LoginModel oLoginModel { get; set; }
	//public string email { get; set; }

	//public string password { get; set; }
	public Login()
	{
		InitializeComponent();
		oLoginModel = new LoginModel();
		BindingContext = this;
	}



	private async void btnLogin_Clicked(object sender, EventArgs e)
	{
		if (oLoginModel.Email == "pintosupn@gmail.com" && oLoginModel.Password == "pintos123")
		{
			Application.Current.MainPage = new MenuPage();
		}   
		else
		{
			await DisplayAlert("Alert", "Usuario o contraseña incorrecto", "OK");
		}
	}


	private void btnCreateAccount_Clicked(object sender, EventArgs e)
	{
		Application.Current.MainPage = new CreateAccount();
		//await Navigation.PushAsync(new CreateAccount());
	}
}