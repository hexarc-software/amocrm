using System.Text.Json.Serialization;

namespace Hexarc.AmoCrm.Models
{
    public sealed class _Embedded
    {
        [JsonPropertyName("contacts")]
        public Contact[]? Contacts { get; set; }

        [JsonPropertyName("leads")]
        public Lead[]? Leads { get; set; }

        [JsonPropertyName("links")]
        public Link[]? Links { get; set; }
    }
}
