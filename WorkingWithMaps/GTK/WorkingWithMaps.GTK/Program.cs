﻿using Xamarin.Forms;
using Xamarin.Forms.Maps.GTK;
using Xamarin.Forms.Platform.GTK;

namespace WorkingWithMaps.GTK
{
    class Program
    {
        static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();
            FormsMaps.Init(string.Empty);
            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("WorkingWithMaps");
            window.Show();
            Gtk.Application.Run();
        }
    }
}