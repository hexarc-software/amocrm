using System;
using System.Text.Json.Serialization;

namespace Hexarc.AmoCrm.Models
{
    public sealed class Task
    {
        [JsonPropertyName("id")]
        public Int32? Id { get; init; }

        [JsonPropertyName("responsible_user_id")]
        public Int32? ResponsibleUserId { get; init; }

        [JsonPropertyName("entity_id")]
        public Int32? EntityId { get; init; }

        [JsonPropertyName("entity_type")]
        public String EntityType { get; init; } = default!;

        [JsonPropertyName("is_completed")]
        public Boolean? IsCompleted { get; init; }

        [JsonPropertyName("task_type_id")]
        public Int32? TaskTypeId { get; init; }

        [JsonPropertyName("text")]
        public String Text { get; init; } = default!;

        [JsonPropertyName("duration")]
        public Int32? Duration { get; init; }

        [JsonPropertyName("complete_till")]
        public Int32 CompleteTill { get; init; }

        [JsonPropertyName("result")]
        public dynamic Result { get; init; } = default!;

        [JsonPropertyName("created_by")]
        public Int32? CreatedBy { get; init; }

        [JsonPropertyName("updated_by")]
        public Int32? UpdatedBy { get; init; }

        [JsonPropertyName("created_at")]
        public Int32? CreatedAt { get; init; }

        [JsonPropertyName("updated_at")]
        public Int32? UpdatedAt { get; init; }

        [JsonPropertyName("request_id")]
        public String? RequestId { get; init; }
    }
}
