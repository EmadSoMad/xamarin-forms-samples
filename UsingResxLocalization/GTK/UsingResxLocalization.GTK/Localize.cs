using System;
using System.Globalization;
using System.Threading;
using Xamarin.Forms;

[assembly: Dependency(typeof(UsingResxLocalization.GTK.Localize))]
namespace UsingResxLocalization.GTK
{
    public class Localize : ILocalize
    {
        public void SetLocale(CultureInfo ci)
        {
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            Console.WriteLine("CurrentCulture set: " + ci.Name);
        }

        public CultureInfo GetCurrentCultureInfo()
        {
            var netLanguage = "en";
            var gtkLocale = Thread.CurrentThread.CurrentUICulture;
            netLanguage = gtkLocale.ToString();

            CultureInfo ci = new CultureInfo(netLanguage);
            
            return ci;
        }
    }
}