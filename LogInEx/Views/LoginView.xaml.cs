using LogInEx.ViewModels;

namespace LogInEx.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
		this.BindingContext = new LoginViewModel();

    }
}