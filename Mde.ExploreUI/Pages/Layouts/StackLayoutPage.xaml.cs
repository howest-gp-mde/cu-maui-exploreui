namespace Mde.ExploreUI.Pages.Layouts;

public partial class StackLayoutPage : ContentPage
{
	public StackLayoutPage()
	{
		InitializeComponent();
    }

    private void degreesSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        degreesText.Text = degreesSlider.Value.ToString("N0");
    }

    private void degreesText_Completed(object sender, EventArgs e)
    {
        if (int.TryParse(degreesText.Text, out int sliderVal))
            degreesSlider.Value = sliderVal;
        else
            degreesText.Text = degreesSlider.Value.ToString("N0");
    }
}