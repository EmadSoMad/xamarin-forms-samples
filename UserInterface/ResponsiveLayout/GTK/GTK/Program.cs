using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace GTK
{
    class Program
    {
        static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();

            var app = new ResponsiveLayout.App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("ResponsiveLayout");
            window.Show();
            Gtk.Application.Run();
        }
    }
}