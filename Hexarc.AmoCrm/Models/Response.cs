using System;
using System.Text.Json.Serialization;

namespace Hexarc.AmoCrm.Models
{
    public sealed class Response
    {
        [JsonPropertyName("_page")]
        public Int32? Page { get; init; }

        [JsonPropertyName("_total_items")]
        public Int32? TotalItems { get; init; }

        [JsonPropertyName("_links")]
        public _Links Links { get; init; } = default!;

        [JsonPropertyName("_embedded")]
        public _Embedded Embedded { get; init; } = default!;
    }
}
