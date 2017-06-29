using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace WorkingWithDevice.GTK
{
    class Program
    {
        static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();

            var app = new WorkingWithPlatformSpecifics.App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("WorkingWithDevice");
            window.Show();
            Gtk.Application.Run();
        }
    }
}