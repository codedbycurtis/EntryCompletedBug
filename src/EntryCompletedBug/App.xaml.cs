using Microsoft.Maui.Controls;

namespace EntryCompletedBug;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
