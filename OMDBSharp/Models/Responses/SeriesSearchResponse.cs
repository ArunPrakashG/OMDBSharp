using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMDBSharp.Models.Responses
{
    public sealed class SeriesSearchResponse : BaseResponse
    {
        [JsonProperty("Search")]
        public SearchResult[] SearchResults { get; set; }

        [JsonProperty("totalResults")]
        public string TotalResults { get; set; }
    }
}
