using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace TodoAzure.GTK
{
    class Program
    {
        static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();
            //Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();

            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("TodoAzure");
            window.Show();
            Gtk.Application.Run();
        }
    }
}