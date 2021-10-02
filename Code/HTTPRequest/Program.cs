using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HTTPRequest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Program.GetPosts();
        }

        static private async Task GetPosts()
        {
            var client = new HttpClient();
            const string URL = "https://jsonplaceholder.typicode.com/posts";
            string response = await client.GetStringAsync(URL);
            
            List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(response);

            foreach (var post in posts)
            {
                Console.WriteLine(post.userId);
                Console.WriteLine(post.id);
                Console.WriteLine(post.title);
                Console.WriteLine(post.body);
            }
        }
    }

    class Post 
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}