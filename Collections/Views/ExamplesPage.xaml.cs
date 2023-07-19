using Collections.ViewModels;

namespace Collections.Views;

public partial class ExamplesPage : ContentPage
{
	public ExamplesPage()
	{
		InitializeComponent();

		BindingContext = new ExamplesPageViewModel();
	}
}
