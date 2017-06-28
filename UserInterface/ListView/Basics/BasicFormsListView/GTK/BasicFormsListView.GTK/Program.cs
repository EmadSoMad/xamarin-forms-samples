using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace BasicFormsListView.GTK
{
    class Program
    {
        static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();

            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("BasicFormsListView");
            window.Show();
            Gtk.Application.Run();
        }
    }
}