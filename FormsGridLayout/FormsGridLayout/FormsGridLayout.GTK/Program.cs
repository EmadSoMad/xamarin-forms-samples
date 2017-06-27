using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace GridLayoutDemo.GTK
{
    class Program
    {
        static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();

            var app = new GridLayoutDemo.App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("FormsGridLayout");
            window.Show();
            Gtk.Application.Run();
        }
    }
}