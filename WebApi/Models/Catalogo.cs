using System.Text.Json.Serialization;

namespace WebApi.Models
{

    public class Catalogo
    {
        [JsonPropertyName("id")]
        public int id { get; set; }
        [JsonPropertyName("name")]
        public string name { get; set; }
        [JsonPropertyName("price")]
        public double price { get; set; }
        public double frete { get; set; }
        public Specifications specifications { get; set; }
    }
}