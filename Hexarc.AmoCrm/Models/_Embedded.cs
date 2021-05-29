using System.Text.Json.Serialization;

namespace Hexarc.AmoCrm.Models
{
    public sealed class _Embedded
    {
        [JsonPropertyName("contacts")]
        public Contact[]? Contacts { get; init; }

        [JsonPropertyName("leads")]
        public Lead[]? Leads { get; init; }

        [JsonPropertyName("links")]
        public Link[]? Links { get; init; }

        [JsonPropertyName("tasks")]
        public Task[]? Tasks { get; init; }
    }
}
