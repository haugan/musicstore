using System;
using Newtonsoft.Json;

namespace MusicStore.Models.DTOs
{
    public class Customer
    {
        [JsonProperty("id")]
        public int CustomerID { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("ip_address")]
        public string IPAddress { get; set; }
    }
}
