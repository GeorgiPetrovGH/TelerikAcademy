namespace ArtistsSystem.Client
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;

    public class Startup
    {
        public static void Main()
        {
            var connection = new Uri("http://localhost:19005/");

            PrintXmlCountries(connection, "api/Countries");
            PrintJsonSongs(connection, "api/Songs");
        }

        private static async void PrintXmlCountries(Uri connection, string requestPath)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = connection;
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));

                var response = await httpClient.GetAsync(requestPath);
                Console.WriteLine(Environment.NewLine + "Countries: " + await response.Content.ReadAsStringAsync());
            }
        }

        private static async void PrintJsonSongs(Uri connection, string requestPath)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = connection;

                var response = await httpClient.GetAsync(requestPath);
                Console.WriteLine(Environment.NewLine + "Songs: " + await response.Content.ReadAsStringAsync());
            }
        }
    }
}
