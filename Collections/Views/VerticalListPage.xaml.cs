using Collections.ViewModels;

namespace Collections.Views;

public partial class VerticalListPage : ContentPage
{
	public VerticalListPage()
	{
		InitializeComponent();

		BindingContext = new PageViewModel();
	}
}
