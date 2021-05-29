using System;
using System.Text.Json.Serialization;

namespace Hexarc.AmoCrm.Models
{
    public sealed class Lead
    {
        [JsonPropertyName("id")]
        public Int32? Id { get; init; }

        [JsonPropertyName("name")]
        public String? Name { get; init; } = default!;

        [JsonPropertyName("price")]
        public Int32? Price { get; init; }

        [JsonPropertyName("pipeline_id")]
        public Int32? PipelineId { get; init; }

        [JsonPropertyName("status_id")]
        public Int32? StatusId { get; init; }

        [JsonPropertyName("closed_at")]
        public Int32? ClosedAt { get; init; }
    }
}
