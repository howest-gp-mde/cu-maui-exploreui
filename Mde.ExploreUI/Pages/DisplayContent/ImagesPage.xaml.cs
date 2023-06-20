namespace Mde.ExploreUI.Pages.DisplayContent;

public partial class ImagesPage : ContentPage
{
	public ImagesPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

    }

    private void AnimatedGif_Loaded(object sender, EventArgs e)
    {
        //fixes bug in Hot Reload where animations would be paused
        imgAlert.IsAnimationPlaying = false;
        imgFolder.IsAnimationPlaying = false;
        imgFingerprint.IsAnimationPlaying = false;
        imgAlert.IsAnimationPlaying = true;
        imgFolder.IsAnimationPlaying = true;
        imgFingerprint.IsAnimationPlaying = true;
    }
}