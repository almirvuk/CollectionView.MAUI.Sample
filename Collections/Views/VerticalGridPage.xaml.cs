using Collections.ViewModels;

namespace Collections.Views;

public partial class VerticalGridPage : ContentPage
{
	public VerticalGridPage()
	{
		InitializeComponent();

		BindingContext = new PageViewModel();
	}
}
