using System.Text.Json.Serialization;

namespace APICons.ConsoleApp.Models
{
    public class PostModel
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("title")]
        public string title { get; set; }
    }
}
