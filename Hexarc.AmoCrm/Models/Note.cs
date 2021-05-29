using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Hexarc.AmoCrm.Utils;

namespace Hexarc.AmoCrm.Models
{
    public sealed class Note
    {
        [JsonPropertyName("entity_id")]
        public Int32 EntityId { get; init; }

        [JsonPropertyName("note_type")]
        public String NoteType { get; init; } = default!;

        [JsonPropertyName("params")]
        public Object Params { get; init; } = default!;

        public Boolean TryGetCommonParams([MaybeNullWhen(false)] out CommonParams commonParams) =>
            this.Params.TryConvert<CommonParams>(out commonParams);
    }

    public sealed class CommonParams
    {
        [JsonPropertyName("text")]
        public String Text { get; init; } = default!;
    }
}
