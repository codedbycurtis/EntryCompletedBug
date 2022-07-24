using Microsoft.Maui.Controls;

namespace EntryCompletedBug;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}

	private void Entry_Completed(object sender, System.EventArgs e)
	{
		lblTest.Text = "This will not appear!";
	}
}

