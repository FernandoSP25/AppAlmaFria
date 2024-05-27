using AppAlmaFria.Views;

namespace AppAlmaFria
{
	public partial class App : Application
	{
 		public App()
		{
			InitializeComponent();

			MainPage = new Login();
		}
	}
}
