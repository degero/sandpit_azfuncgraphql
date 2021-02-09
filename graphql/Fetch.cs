using System.Net.Http;
using System.Threading.Tasks;

namespace Function
{
    public class Fetch
    {
        private static string BaseUrl = "https://swapi.dev/api";
        public static async Task<string> ByUrl(string url)
        {
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync(string.Format("{0}/{1}", BaseUrl, url));

                return json;
            }
        }
    }
}