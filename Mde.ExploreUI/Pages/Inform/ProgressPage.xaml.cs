using Microsoft.Maui.Animations;
using Microsoft.Maui.Layouts;

namespace Mde.ExploreUI.Pages.Inform;

public partial class ProgressPage : ContentPage
{
    public ProgressPage()
    {
        InitializeComponent(); 
    }


    private int currentColorIndex = 0;
    private int targetColorIndex = 1;

    private Color[] colors = new Color[]
    {
        Colors.Red,
        Colors.Blue,
        Colors.Green,
        Colors.Yellow,
    };

    protected override async void OnAppearing()
    {
        double targetColorProgress = 0;

        //animation loop
        while(this.IsVisible)
        {
            await Task.Delay(25);

            //animate progressbar
            progressBar.Progress += 0.005;
            if (progressBar.Progress >= 1)
            {
                await Task.Delay(2000);
                progressBar.Progress = 0;
            }

            //animate coloredBusyIndicator
            if (targetColorProgress >= 1)
            {
                targetColorProgress = 0;
                currentColorIndex = targetColorIndex;
                targetColorIndex++;

                if (targetColorIndex >= colors.Length)
                {
                    targetColorIndex = 0;
                }
            }
            else
            {
                targetColorProgress = Math.Min(1, targetColorProgress + 0.01);
            }

            coloredBusyIndicator.Color = colors[currentColorIndex].Lerp(colors[targetColorIndex], targetColorProgress);
        }
    }
}