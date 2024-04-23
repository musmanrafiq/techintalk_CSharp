using APICons.ConsoleApp.Services;
using Refit;

namespace APICons.ConsoleApp
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var refitConfig = RestService.For<IPostService>("http://localhost:3000/");

            var getResponse = await refitConfig.GetAll();

            foreach (var post in getResponse.Content)
            {
                Console.WriteLine(post.title);
            }

            var createResponse = await refitConfig.Post(new Models.PostModel { title = "next post" });
            if (createResponse.IsSuccessStatusCode)
            {
                Console.WriteLine("Post created");
            }

            var updateResponse = await refitConfig.Put(3, new Models.PostModel { title = "third post" });
            if (updateResponse.IsSuccessStatusCode)
            {
                Console.WriteLine("Post update");
            }

            var deleteResponse = await refitConfig.Delete(4);
            if (deleteResponse.IsSuccessStatusCode)
            {
                Console.WriteLine("Post deleted");
            }
        }
    }
}
