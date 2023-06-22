using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using Font = Microsoft.Maui.Font;

namespace Mde.ExploreUI.Pages.Inform;

public partial class AlertsPage : ContentPage
{
	public AlertsPage()
	{
		InitializeComponent();
	}

    private async void btnAlert_Clicked(object sender, EventArgs e)
    {
        string title = "Pop-up!";
        string message = "Did you know pop-ups can be very annoying to the user?\nTry to avoid building them into a normal interaction flow.";
        string confirmation = "Okay";

        //alerts must awaited for the user to click it away
        await DisplayAlert(title, message, confirmation);
    }

    private async void btnQuestion_Clicked(object sender, EventArgs e)
    {
        string title = "Question";
        string message = "Do you like to click on pop-ups?";
        string answerYes = "Yes";
        string answerNo = "No";

        //alert questions must awaited to know how the user answered
        bool userLikesPopups = await DisplayAlert(title, message, answerYes, answerNo);

        if(userLikesPopups)
        {
            btnQuestion_Clicked(this, e);
        }
        else
        {
            await DisplayAlert("You answered no" , "I'll stop bugging you with pop-ups for now. May be later...", "Stop it!!");
        }
    }

    private async void btnActionSheet_Clicked(object sender, EventArgs e)
    {
        string title = "What to do?";
        string cancel = "Cancel";
        string showTime = "Show me the time";
        string tellJoke = "Tell a joke";
        string waitTheeSeconds = "Wait 3 seconds";

        string userChoice = await DisplayActionSheet(title, cancel, null, showTime, tellJoke, waitTheeSeconds);

        if (userChoice.Equals(showTime))
        {
            await DisplayAlert("Time",
                    $"It's now {DateTime.Now.ToString("HH:mm")}, almost beer-o-clock!", "OK");
        }
        else if (userChoice.Equals(tellJoke))
        {
            await DisplayAlert("Joke",
                    $"Why is six afraid of seven?{Environment.NewLine}Because seven ate nine.",
                    "LOL", "I don't get it");
        }
        else if (userChoice.Equals(waitTheeSeconds))
        {
            await Task.Delay(3000);
            await DisplayAlert("Wait 3 seconds", "The wait is over.", "OK");
        }
    }

    private async void btnPrompt_Clicked(object sender, EventArgs e)
    {
        string title = "What's your GitHub handle?";
        string message = "A handle is your unique username on GitHub";
        string accept = "OK";

        string handle = await DisplayPromptAsync(title, message, accept, keyboard: Keyboard.Text);

        if(!string.IsNullOrWhiteSpace(handle))
        {
            await Browser.Default.OpenAsync($"https://github.com/{handle}");
        }
    }

    private async void btnToast_Clicked(object sender, EventArgs e)
    {
        string text = "This toast will show for about 2 seconds";
        ToastDuration duration = ToastDuration.Short;
        double fontSize = 14;

        var toast = Toast.Make(text, duration, fontSize);

        await toast.Show();
    }

    private async void btnSnackbar_Clicked(object sender, EventArgs e)
    {
        var snackbarOptions = new SnackbarOptions
        {
            BackgroundColor = Colors.PaleGoldenrod,
            TextColor = Colors.Black,
            CornerRadius = new CornerRadius(10),
            Font = Font.SystemFontOfSize(14),
            ActionButtonTextColor = Colors.Red,
            ActionButtonFont = Font.SystemFontOfSize(14),
        };

        string text = "This is a Snackbar.\nIt behaves like a toast, but you can customize the colors and fonts easily.\n\nA snackbar can also be anchored to any visual element.";
        TimeSpan duration = TimeSpan.FromSeconds(5);

        //the buttonAction holds a method which is run when the user clicks the snackbar button
        Action buttonAction = async () => await DisplayAlert("You clicked anyway!", "The button clearly said \"Don't click here\". Could we make it more clearer?", "I'm sorry");
        string buttonText = "Don't click here";

        var snackbar = Snackbar.Make(text, buttonAction, buttonText, duration, snackbarOptions);
        await snackbar.Show();
    }

}