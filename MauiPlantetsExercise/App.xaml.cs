using MauiPlanetsExercise.Views;

namespace MauiPlantetsExercise;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new StartPage());
    }
}