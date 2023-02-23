namespace Mde.ExploreUI.Pages.Layouts;

public partial class StackLayoutPage : ContentPage
{
	public StackLayoutPage()
	{
		InitializeComponent();
    }

    private void SliderA_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        txtSliderA.Text = sliderA.Value.ToString("N0");
    }

    private void TxtSliderA_Completed(object sender, EventArgs e)
    {
        if (int.TryParse(txtSliderA.Text, out int sliderVal))
            sliderA.Value = sliderVal;
        else
            txtSliderA.Text = sliderA.Value.ToString("N0");
    }
}