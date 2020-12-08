using System;
using System.Text.Json.Serialization;

namespace Hexarc.AmoCrm.Models
{
    public sealed class Task
    {
        [JsonPropertyName("id")]
        public Int32? Id { get; set; }

        [JsonPropertyName("responsible_user_id")]
        public Int32? ResponsibleUserId { get; set; }

        [JsonPropertyName("entity_id")]
        public Int32? EntityId { get; set; }

        [JsonPropertyName("entity_type")]
        public String EntityType { get; set; } = default!;

        [JsonPropertyName("is_completed")]
        public Boolean? IsCompleted { get; set; }

        [JsonPropertyName("task_type_id")]
        public Int32? TaskTypeId { get; set; }

        [JsonPropertyName("text")]
        public String Text { get; set; } = default!;

        [JsonPropertyName("duration")]
        public Int32? Duration { get; set; }

        [JsonPropertyName("complete_till")]
        public Int32 CompleteTill { get; set; }

        [JsonPropertyName("result")]
        public dynamic Result { get; set; } = default!;

        [JsonPropertyName("created_by")]
        public Int32? CreatedBy { get; set; }

        [JsonPropertyName("updated_by")]
        public Int32? UpdatedBy { get; set; }

        [JsonPropertyName("created_by")]
        public Int32? CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public Int32? UpdatedAt { get; set; }

        [JsonPropertyName("request_id")]
        public String? RequestId { get; set; }
    }
}