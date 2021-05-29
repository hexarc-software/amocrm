using System;
using System.Text.Json.Serialization;

namespace Hexarc.AmoCrm.Models
{
    public sealed class Contact
    {
        [JsonPropertyName("id")]
        public Int32? Id { get; init; }

        [JsonPropertyName("responsible_user_id")]
        public Int32? ResponsibleUserId { get; init; }

        [JsonPropertyName("name")]
        public String? Name { get; init; }

        [JsonPropertyName("first_name")]
        public String? FirstName { get; init; }

        [JsonPropertyName("last_name")]
        public String? LastName { get; init; }

        [JsonPropertyName("custom_fields_values")]
        public CustomFieldsValue[]? CustomFieldsValues { get; init; }

        [JsonPropertyName("_links")]
        public _Links Links { get; init; } = default!;
    }
}
