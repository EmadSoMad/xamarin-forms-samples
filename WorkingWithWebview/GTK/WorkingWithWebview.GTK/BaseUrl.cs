using WorkingWithWebview.GTK;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl))]
namespace WorkingWithWebview.GTK
{
    public class BaseUrl : IBaseUrl
    {
        public string Get()
        {
            return string.Empty;
        }
    }
}