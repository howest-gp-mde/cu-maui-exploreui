using System.Text;

namespace Mde.ExploreUI.Pages.Forms;

public partial class FormsEssentialsPage : ContentPage
{
	public FormsEssentialsPage()
	{
		InitializeComponent();
	}

    private async void btnSubmit_Clicked(object sender, EventArgs e)
    {
		var summary = new StringBuilder();
		summary.AppendLine($"Name: {txtName.Text}");
        summary.AppendLine($"Level: {stpLevel.Value}");
        summary.AppendLine($"Strength: {sldStrength.Value:N2}");
        summary.AppendLine($"Magic Skill: {sldMagic.Value:N2}");
        summary.AppendLine($"Is NPC: {chkIsNPC.IsChecked}");
        summary.AppendLine($"God mode On: {swGodMode.IsToggled}");

        await DisplayAlert("Character Summary", summary.ToString(), "OK");
    }
}