
using System;
using System.Text.Json.Serialization;

namespace Hexarc.AmoCrm.Models
{
    public sealed class Link
    {
        [JsonPropertyName("to_entity_id")]
        public Int32 ToEntityId { get; init; }

        [JsonPropertyName("to_entity_type")]
        public String ToEntityType { get; init; } = default!;
    }
}
