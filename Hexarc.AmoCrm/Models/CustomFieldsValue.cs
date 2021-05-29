using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using Hexarc.AmoCrm.Utils;

namespace Hexarc.AmoCrm.Models
{
    public sealed class CustomFieldsValue
    {
        [JsonPropertyName("field_id")]
        public Int32 FieldId { get; init; }

        [JsonPropertyName("values")]
        public Object Values { get; init; } = default!;

        public Boolean TryGetStringValues([MaybeNullWhen(false)] out StringFieldsValueItem[] values) =>
            this.Values.TryConvert<StringFieldsValueItem[]>(out values);

        public Boolean TryGetIntValues([MaybeNullWhen(false)] out IntFieldsValueItem[] values) =>
            this.Values.TryConvert<IntFieldsValueItem[]>(out values);
    }

    public sealed class StringFieldsValueItem
    {
        [JsonPropertyName("value")]
        public String Value { get; init; } = default!;
    }

    public sealed class IntFieldsValueItem
    {
        [JsonPropertyName("value")]
        public Int32 Value { get; init; } = default!;
    }
}
