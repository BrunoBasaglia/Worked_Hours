using System.Web;

namespace Clock.Presentation.Helpers
{
    public static class WebUtils
    {

        public static string EncodeUrl(string url)
        {



            return HttpUtility.HtmlEncode(url); ;
        }


    }
}
