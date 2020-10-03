using System;
using System.Text.Json.Serialization;

namespace Hexarc.AmoCrm.Models
{
    public sealed class Lead
    {
        [JsonPropertyName("id")]
        public Int32? Id { get; set; }

        [JsonPropertyName("name")]
        public String? Name { get; set; } = default!;

        [JsonPropertyName("price")]
        public Int32? Price { get; set; }

        [JsonPropertyName("pipeline_id")]
        public Int32? PipelineId { get; set; }

        [JsonPropertyName("status_id")]
        public Int32? StatusId { get; set; }

        [JsonPropertyName("closed_at")]
        public Int32? ClosedAt { get; set; }
    }
}
