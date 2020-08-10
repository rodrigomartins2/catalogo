using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApi.Models
{
    public class Specifications
    {
        [JsonPropertyName("Originally published")]
        public string Originallypublished { get; set; }
        [JsonPropertyName("Author")]
        public string Author { get; set; }
        [JsonPropertyName("Page count")]
        public int Pagecount { get; set; }
        [JsonPropertyName("Illustrator")]
        public object Illustrator { get; set; }        
        [JsonPropertyName("Genres")]
        public object Genres { get; set; }
    }
}