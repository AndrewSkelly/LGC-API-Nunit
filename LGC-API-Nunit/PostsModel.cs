using System.Text.Json.Serialization;

namespace LGC_API_Nunit
{
    internal class PostsModel
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        [JsonPropertyName("body")]
        public string? Body { get; set; }
    }
}