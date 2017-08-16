using Xamarin.Forms;

namespace FormsOpenGl.Shared
{
    public class App : Application
    {
        public App()
        {
            MainPage = new OpenGlView(); 
        }
    }
}