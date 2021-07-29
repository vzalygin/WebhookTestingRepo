using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Lib.Models
{
    public class PushNotify
    {
        [JsonProperty("ref")]
        public string Ref { get; set; }

        [JsonProperty("before")]
        public string Before { get; set; }

        [JsonProperty("after")]
        public string After { get; set; }

        [JsonProperty("created")]
        public bool Created { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("forced")]
        public bool Forced { get; set; }

        [JsonProperty("base_ref")]
        public object BaseRef { get; set; }

        [JsonProperty("compare")]
        public string Compare { get; set; }

        [JsonProperty("commits")]
        public List<object> Commits { get; set; }

        [JsonProperty("head_commit")]
        public object HeadCommit { get; set; }

        [JsonProperty("repository")]
        public RepositoryInfo Repository { get; set; }

        [JsonProperty("pusher")]
        public Pusher Pusher { get; set; }

        [JsonProperty("sender")]
        public Sender Sender { get; set; }
    }
}