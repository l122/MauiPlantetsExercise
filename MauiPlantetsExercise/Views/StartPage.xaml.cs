namespace MauiPlanetsExercise.Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (this.AnimationIsRunning("TransitionAnimation"))
        {
            return;
        }

        // Planets' animation
        var parentAnimation = new Animation
        {
            { 0, 0.2, new Animation(p => imgMercury.Opacity = p, start: 0, end: 1, easing: Easing.CubicIn) },
            { 0.1, 0.3, new Animation(v => imgVenus.Opacity = v, 0, 1, Easing.CubicIn) },
            { 0.2, 0.4, new Animation(v => imgEarth.Opacity = v, 0, 1, Easing.CubicIn) },
            { 0.3, 0.5, new Animation(v => imgMars.Opacity = v, 0, 1, Easing.CubicIn) },
            { 0.4, 0.6, new Animation(v => imgJupiter.Opacity = v, 0, 1, Easing.CubicIn) },
            { 0.5, 0.7, new Animation(v => imgSaturn.Opacity = v, 0, 1, Easing.CubicIn) },
            { 0.6, 0.8, new Animation(v => imgNeptune.Opacity = v, 0, 1, Easing.CubicIn) },
            { 0.7, 0.9, new Animation(v => imgUranus.Opacity = v, 0, 1, Easing.CubicIn) },

            // Intro Box Animation
            { 0.7, 1, new Animation(v => frmIntro.Opacity = v, start: 0, end: 1, easing: Easing.CubicIn) },
        };

        // Commit the animation
        parentAnimation.Commit(this, "TransitionAnimation", 16, 3000, null, null);

        // 10 minute animation
        uint duration = 10 * 60 * 100000;
        await Task.WhenAll
        (
          imgVenus.RotateTo(-251 * 360, duration),
          imgEarth.RotateTo(199 * 360, duration),
          imgMars.RotateTo(-199 * 360, duration),
          imgJupiter.RotateTo(199 * 360, duration),
          imgNeptune.RotateTo(-199 * 360, duration),
          imgMercury.RotateTo(199 * 360, duration)
        );
    }

    async void ExploreNow_Clicked(System.Object sender, System.EventArgs e)
    {
        //Application.Current.MainPage = new NavigationPage(new PlanetsPage());
    }
}
