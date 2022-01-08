using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMDBSharp.Models.Responses
{
    public sealed class Rating
    {
        [JsonProperty("Source")]
        public string Source { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }
}
