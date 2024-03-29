namespace Mde.ExploreUI.Pages.Layouts;

public partial class AbsoluteLayoutPage : ContentPage
{
	public AbsoluteLayoutPage()
	{
		InitializeComponent();
	}

    private void BtnLeft_Click(object sender, EventArgs e)
    {
        boxPlayer.TranslationX -= 15;
    }

    private void BtnTop_Click(object sender, EventArgs e)
    {
        boxPlayer.TranslationY -= 15;
    }

    private void BtnRight_Click(object sender, EventArgs e)
    {
        boxPlayer.TranslationX += 15;
    }

    private void BtnBottom_Click(object sender, EventArgs e)
    {
        boxPlayer.TranslationY += 15;
    }
}