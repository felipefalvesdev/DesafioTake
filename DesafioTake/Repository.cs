using System;
using System.Collections;
using Newtonsoft.Json;


namespace DesafioTake
{

    public class Repository
    {
        public partial class Details
        {

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("node_id")]
            public string NodeId { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("full_name")]
            public string FullName { get; set; }

            [JsonProperty("html_url")]
            public Uri HtmlUrl { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("created_at")]
            public DateTimeOffset CreatedAt { get; set; }

            [JsonProperty("updated_at")]
            public DateTimeOffset UpdatedAt { get; set; }

            [JsonProperty("pushed_at")]
            public DateTimeOffset PushedAt { get; set; }

            [JsonProperty("language")]
            public string Language { get; set; }

            [JsonProperty("owner")]
            public Owner Owner { get; set; }
        }

        public partial class Owner
        {
            [JsonProperty("login")]
            public string Login { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("avatar_url")]
            public Uri AvatarUrl { get; set; }

            [JsonProperty("url")]
            public Uri Url { get; set; }

        }
    }
}

