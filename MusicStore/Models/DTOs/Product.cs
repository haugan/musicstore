using Newtonsoft.Json;

namespace MusicStore.Models.DTOs
{
    public class Product
    {
        [JsonProperty("id")]
        public int ProductID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }
    }
}
