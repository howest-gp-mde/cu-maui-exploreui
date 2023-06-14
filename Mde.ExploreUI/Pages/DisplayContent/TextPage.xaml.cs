namespace Mde.ExploreUI.Pages.DisplayContent;

public partial class TextPage : ContentPage
{
	public TextPage()
	{
		InitializeComponent();
    }
    public void TxtChat_Completed(object sender, EventArgs e)
    {
        string text = txtChat.Text ?? "";
        txtReverseChat.Text = new string(text.ToCharArray().Reverse().ToArray());
    }

    public void TxtChat_TextChanged(object sender, TextChangedEventArgs e)
    {
        string text = e.NewTextValue ?? "";
        lblNumberChars.Text = $"{text.Length} chars";
    }
}