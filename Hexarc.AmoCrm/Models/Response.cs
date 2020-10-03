using System;
using System.Text.Json.Serialization;

namespace Hexarc.AmoCrm.Models
{
    public sealed class Response
    {
        [JsonPropertyName("_page")]
        public Int32? Page { get; set; }

        [JsonPropertyName("_total_items")]
        public Int32? TotalItems { get; set; }

        [JsonPropertyName("_links")]
        public _Links Links { get; set; } = default!;

        [JsonPropertyName("_embedded")]
        public _Embedded Embedded { get; set; } = default!;
    }
}
