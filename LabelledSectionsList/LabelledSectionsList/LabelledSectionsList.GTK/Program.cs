using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;


namespace LabelledSectionsList.GTK
{
    class Program
    {
        static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();

            var app = new LabelledSections.App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("LabelledSectionsList");
            window.Show();
            Gtk.Application.Run();
        }
    }
}