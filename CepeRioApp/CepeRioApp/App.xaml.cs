using CepeRioApp.Views;

namespace CepeRioApp;

public partial class App : Application
{
    private readonly AppShell _appShell;

    public App(AppShell appShell)
    {
        InitializeComponent();
        _appShell = appShell;   

        //if(!Preferences.ContainsKey("HasSeenOnboarding"))
        //{
        //    MainPage = onBoardingView;
        //}
        //else
        //{
        //    MainPage = new AppShell();
        //}

        //MainPage = new AppShell(onBoardingView);
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    }
}
