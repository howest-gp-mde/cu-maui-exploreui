using System.Text;

namespace Mde.ExploreUI.Pages.Forms;

public partial class PickersPage : ContentPage
{
	public PickersPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        //set date and time pickers
        datePicker.MinimumDate = DateTime.Today;
        timePicker.Time = DateTime.Now.TimeOfDay;

        //set course picker items
        var courses = GetCourses();
        coursePicker.ItemsSource = courses;
    }

    private async void btnSubmit_Clicked(object sender, EventArgs e)
    {
        var selectedCourse = coursePicker.SelectedItem as Course;

        var summary = new StringBuilder();
        summary.AppendLine($"Start date: {datePicker.Date:ddd dd MMM yyyy}");
        summary.AppendLine($"Start time: {timePicker.Time:hh\\:mm}"); 
        summary.AppendLine();

        if (selectedCourse != null)
        {
            summary.AppendLine($"Course: {selectedCourse.Name}\n({selectedCourse.Credits} credits, {selectedCourse.Duration.TotalDays:N0} days)");
        }

        await DisplayAlert(
            "Submitted!",
            summary.ToString(),
            "OK");
    }

    private List<Course> GetCourses()
    {
        return new List<Course>
        {
            new Course
            {
                Name = "Programming Basics",
                Credits = 6,
                Duration = new TimeSpan(20, 0, 0, 0)
            },
            new Course
            {
                Name = "Programming Advanced",
                Credits = 3,
                Duration = new TimeSpan(10, 0, 0, 0)
            },
            new Course
            {
                Name = "Programming Expert",
                Credits = 6,
                Duration = new TimeSpan(20, 0, 0, 0)
            },
            new Course
            {
                Name = "Mobile Development",
                Credits = 9,
                Duration = new TimeSpan(30, 0, 0, 0)
            },
        };
    }
}

public class Course
{
    public string Name { get; set; }
    public int Credits { get; set; }
    public TimeSpan Duration { get; set; }
}