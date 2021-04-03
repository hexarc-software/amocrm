using System;
using System.Buffers;
using System.Text.Json;

namespace Hexarc.AmoCrm.Utils
{
    internal static class JsonExtensions
    {
        public static T ToObject<T>(this JsonElement element, JsonSerializerOptions? options = null)
        {
            var bufferWriter = new ArrayBufferWriter<byte>();
            using (var writer = new Utf8JsonWriter(bufferWriter))
            {
                element.WriteTo(writer);
            }
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
            if (@object is JsonElement element) return element.ToObject<T>();
            else throw new InvalidCastException($"Could not cast to {nameof(T)}");
        }

        public static Boolean TryConvert<T>(this Object @object, out T result, JsonSerializerOptions? options = null)
        {
            if (@object is JsonElement element)
            {
                try
                {
                    result = element.ToObject<T>();
                    return true;
                }
                catch
                {
                    result = default(T)!;
                    return false;
                }
            }
            else
            {
                result = default(T)!;
                return false;
            }
        }
    }
}
