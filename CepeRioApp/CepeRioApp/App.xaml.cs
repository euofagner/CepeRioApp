using CepeRioApp.Views;

namespace CepeRioApp;

public partial class App : Application
{
    public App(OnBoardingView onBoardingView)
    {
        InitializeComponent();

        if(!Preferences.ContainsKey("HasSeenOnboarding"))
        {
            MainPage = onBoardingView;
        }
        else
        {
            MainPage = new AppShell();
        }
    }
}
