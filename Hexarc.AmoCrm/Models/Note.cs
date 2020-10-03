using System;
using System.Text.Json.Serialization;
using Hexarc.AmoCrm.Utils;

namespace Hexarc.AmoCrm.Models
{
    public sealed class Note
    {
        [JsonPropertyName("entity_id")]
        public Int32 EntityId { get; set; }

        [JsonPropertyName("note_type")]
        public String NoteType { get; set; } = default!;

        [JsonPropertyName("params")]
        public Object Params { get; set; } = default!;

        public Boolean TryGetCommonParams(out CommonParams commonParams)
        {
            return this.Params.TryConvert<CommonParams>(out commonParams);
        }
    }

    public sealed class CommonParams
    {
        [JsonPropertyName("text")]
        public String Text { get; set; } = default!;
    }
}
