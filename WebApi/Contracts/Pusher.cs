using Newtonsoft.Json;

namespace WebApi.Contracts
{
    public class Pusher
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}