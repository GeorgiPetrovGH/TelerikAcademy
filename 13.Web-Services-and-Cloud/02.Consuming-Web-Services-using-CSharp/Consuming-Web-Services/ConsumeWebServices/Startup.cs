namespace ConsumeWebServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;

    using Newtonsoft.Json;    

    public class Startup
    {
        public static void Main()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://jsonplaceholder.typicode.com");

            Console.Write("Enter query string: (default value is odio)");
            string queryString = Console.ReadLine();
            if (string.IsNullOrEmpty(queryString))
            {
                queryString = "odio";
            }

            Console.Write("Enter number of items: (default value is 10) ");
            int numberOfItems;
            bool validNumber = int.TryParse(Console.ReadLine(), out numberOfItems);
            if (!validNumber)
            {
                numberOfItems = 10;
            }

            PrintComments(httpClient, numberOfItems, queryString);
            Console.WriteLine(new string('-', 45));
            Console.WriteLine("Getting your result...");
            Console.WriteLine(new string('-', 45));
            Console.ReadLine();            
        }

        private static async void PrintComments(HttpClient httpClient, int numberOfItems, string query)
        {
            var response = await httpClient.GetAsync("comments");

            var text = response.Content.ReadAsStringAsync().Result;
            var jsons = JsonConvert.DeserializeObject<List<CommentsResponseModel>>(text);
            var filtered = jsons.Where(x => x.Name.Contains(query) || x.Body.Contains(query)).Take(numberOfItems);

            foreach (var comment in filtered)
            {
                Console.WriteLine("Name: {0}\nBody: {1}\nID: {2}", comment.Name, comment.Body, comment.Id);
                Console.WriteLine(new string('-', 45));
            }

            Console.WriteLine("To exit press ENTER:");
        }
    }
}
