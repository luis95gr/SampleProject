using SampleProject.ViewModels;

namespace SampleProject.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel loginPageViewModel)
	{
		BindingContext = loginPageViewModel;
		InitializeComponent();
	}
}