using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace groupingSampleListView.GTK
{
    class Program
    {
        static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();

            var app = new GroupingSampleListView.App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("GroupingSampleListView");
            window.Show();
            Gtk.Application.Run();
        }
    }
}