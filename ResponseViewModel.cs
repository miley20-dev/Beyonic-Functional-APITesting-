using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beyonic.Services.ResponseViewModels
{
    public class ResponseViewModel
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("next")]
        public Uri Next { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results")]
        public Result[] Results { get; set; }
    }
    public partial class Result
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }

        [JsonProperty("usd_rate")]
        public double? UsdRate { get; set; }
    }
    public partial class Country
    {
        [JsonProperty("iso")]
        public string Iso { get; set; }

        [JsonProperty("iso3")]
        public string Iso3 { get; set; }

        [JsonProperty("iso_numeric")]
        public long IsoNumeric { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("printable_name")]
        public string PrintableName { get; set; }

     
    }

}
