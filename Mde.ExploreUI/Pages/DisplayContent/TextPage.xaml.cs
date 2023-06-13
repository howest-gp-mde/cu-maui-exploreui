namespace Mde.ExploreUI.Pages.DisplayContent;

public partial class TextPage : ContentPage
{
	public TextPage()
	{
		InitializeComponent();
    }
    private void TxtChat_Completed(object sender, EventArgs e)
    {
        string text = txtChat.Text ?? "";
        txtReverseChat.Text = new string(text.ToCharArray().Reverse().ToArray());
    }

    private void TxtChat_TextChanged(object sender, TextChangedEventArgs e)
    {
        string text = e.NewTextValue ?? "";
        lblNumberChars.Text = $"{text.Length} chars";
    }
}