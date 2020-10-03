using System;
using System.Text.Json.Serialization;

namespace Hexarc.AmoCrm.Models
{
    public sealed class _Links
    {
        [JsonPropertyName("self")]
        public _Link Self { get; set; } = default!;

        [JsonPropertyName("next")]
        public _Link? Next { get; set; }

        [JsonPropertyName("prev")]
        public _Link? Prev { get; set; }

        [JsonPropertyName("first")]
        public _Link? First { get; set; }
    }

    public sealed class _Link
    {
        [JsonPropertyName("href")]
        public String Href { get; set; } = default!;
    }
}
