using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace Hexarc.AmoCrm.Utils
{
    internal static class JsonExtensions
    {
        public static T ToObject<T>(this JsonElement element, JsonSerializerOptions? options = null)
        {
            var bufferWriter = new ArrayBufferWriter<Byte>();
            using (var writer = new Utf8JsonWriter(bufferWriter)) element.WriteTo(writer);
            return JsonSerializer.Deserialize<T>(bufferWriter.WrittenSpan, options) ??
                   throw new NullReferenceException();
        }

        public static T ToObject<T>(this JsonDocument document, JsonSerializerOptions? options = null)
        {
            if (document == null) throw new ArgumentNullException(nameof(document));
            return document.RootElement.ToObject<T>(options);
        }

        public static T ToObject<T>(this Object @object, JsonSerializerOptions? options = null)
        {
            if (@object is JsonElement element) return element.ToObject<T>(options);
            else throw new InvalidCastException($"Could not cast to {nameof(T)}");
        }

        public static Boolean TryConvert<T>(
            this Object @object,
            [MaybeNullWhen(false)] out T result,
            JsonSerializerOptions? options = null)
        {
            if (@object is JsonElement element)
            {
                try
                {
                    result = element.ToObject<T>(options);
                    return true;
                }
                catch
                {
                    result = default;
                    return false;
                }
            }
            else
            {
                result = default;
                return false;
            }
        }
    }
}
