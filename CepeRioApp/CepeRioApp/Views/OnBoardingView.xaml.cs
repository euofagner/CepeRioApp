using CepeRioApp.ViewModels;

namespace CepeRioApp.Views;

public partial class OnBoardingView : ContentPage
{
	public OnBoardingView(OnBoardingViewModel onBoardingViewModel)
	{
		InitializeComponent();
		BindingContext = onBoardingViewModel;
	}

	//private void myCarousel_PositionChanged(object sender, PositionChangedEventArgs e)
	//{
	//	if (e.CurrentPosition == (int)myCarousel.ItemsSource.Cast<Object>().Count() - 1)
	//	{
			
	//	}
	//}
}