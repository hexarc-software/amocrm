using System;
using System.Text.Json.Serialization;

namespace Hexarc.AmoCrm.Models
{
    public sealed class Contact
    {
        [JsonPropertyName("id")]
        public Int32? Id { get; set; }

        [JsonPropertyName("responsible_user_id")]
        public Int32? ResponsibleUserId { get; set; }

        [JsonPropertyName("name")]
        public String? Name { get; set; }

        [JsonPropertyName("first_name")]
        public String? FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public String? LastName { get; set; }

        [JsonPropertyName("custom_fields_values")]
        public CustomFieldsValue[]? CustomFieldsValues { get; set; }

        [JsonPropertyName("_links")]
        public _Links Links { get; set; } = default!;
    }
}
