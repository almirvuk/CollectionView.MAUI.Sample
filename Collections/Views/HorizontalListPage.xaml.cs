using Collections.ViewModels;

namespace Collections.Views;

public partial class HorizontalListPage : ContentPage
{
	public HorizontalListPage()
	{
		InitializeComponent();

        BindingContext = new PageViewModel();
    }
}
