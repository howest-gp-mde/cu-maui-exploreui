namespace Mde.ExploreUI.Pages.Forms;

public partial class ButtonsPage : ContentPage
{
	public ButtonsPage()
	{
		InitializeComponent();
	}

    private async void btnImageButton_Clicked(object sender, EventArgs e)
    {
        //UI logic: animate image button
		await btnImageButton.ScaleTo(0.675, 100, Easing.SpringIn);
        _ = btnImageButton.ScaleTo(1, 350, Easing.SpringOut);
    }

    private async void btnSubmitFavorite_Clicked(object sender, EventArgs e)
    {
        var favoriteTransportation = (string) radioButtonContainer.GetValue(RadioButtonGroup.SelectedValueProperty);
        await DisplayAlert("Favorite Transportation", $"Your favorite transportation is {favoriteTransportation}", "Meh");
    }
}