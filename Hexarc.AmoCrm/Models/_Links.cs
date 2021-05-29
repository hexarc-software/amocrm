using System;
using System.Text.Json.Serialization;

namespace Hexarc.AmoCrm.Models
{
    public sealed class _Links
    {
        [JsonPropertyName("self")]
        public _Link Self { get; init; } = default!;

        [JsonPropertyName("next")]
        public _Link? Next { get; init; }

        [JsonPropertyName("prev")]
        public _Link? Prev { get; init; }

        [JsonPropertyName("first")]
        public _Link? First { get; init; }
    }

    public sealed class _Link
    {
        [JsonPropertyName("href")]
        public String Href { get; init; } = default!;
    }
}
