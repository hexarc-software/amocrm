using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Hexarc.AmoCrm.Utils;

namespace Hexarc.AmoCrm.Models
{
    public sealed class CustomFieldsValue
    {
        [JsonPropertyName("field_id")]
        public Int32 FieldId { get; set; }

        [JsonPropertyName("values")]
        public Object Values { get; set; } = default!;

        public Boolean TryGetStringValues(out StringFieldsValueItem[] values)
        {
            return this.Values.TryConvert<StringFieldsValueItem[]>(out values);
        }

        public Boolean TryGetIntValues(out IntFieldsValueItem[] values)
        {
            return this.Values.TryConvert<IntFieldsValueItem[]>(out values);
        }
    }

    public sealed class StringFieldsValueItem
    {
        [JsonPropertyName("value")]
        public String Value { get; set; } = default!;
    }

    public sealed class IntFieldsValueItem
    {
        [JsonPropertyName("value")]
        public Int32 Value { get; set; } = default!;
    }
}