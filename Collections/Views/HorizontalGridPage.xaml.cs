using Collections.ViewModels;

namespace Collections.Views;

public partial class HorizontalGridPage : ContentPage
{
	public HorizontalGridPage()
	{
		InitializeComponent();

        BindingContext = new PageViewModel();
    }
}
