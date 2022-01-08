using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMDBSharp.Models.Responses
{
    public class BaseResponse
    {
        [JsonProperty("Response")]
        public string Response { get; set; }
    }
}
