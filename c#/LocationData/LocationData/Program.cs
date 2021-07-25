using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using LocationData.LocationModel;

namespace LocationData
{
    class Program
    {
        static HttpClient httpClient = new HttpClient();
        static Uri apiUrl = new Uri("http://viacep.com.br/ws/88330096/json");

        static void Main(string[] args)
        {            
            GetLocationData(apiUrl).Wait();
        }

        /// <summary>
        /// Get location data from API.
        /// </summary>
        /// <param name="uri">Uri to call.</param>
        /// <returns>Returns the location data response.</returns>

        static async Task<String> GetLocationData(Uri uri)
        {
            String locationString = null;

            HttpResponseMessage response = await httpClient.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                locationString = await response.Content.ReadAsStringAsync();
            }

            Console.WriteLine(locationString);

            return locationString;
        }
    }
}
