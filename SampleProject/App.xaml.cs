using SampleProject.Views;

namespace SampleProject;

public partial class App : Application
{
	public App(LoginPage page)
	{
		InitializeComponent();
		MainPage = page;
	}
}
