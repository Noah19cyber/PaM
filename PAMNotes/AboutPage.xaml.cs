namespace PAMNotes;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

	private async void AboutPage_Button(object sender, EventArgs e)
	{
		await Launcher.Default.OpenAsync("https://github.com/Noah19cyber/PaM");
	}
}