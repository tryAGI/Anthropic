#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ResponseToolUseBlockUnionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ResponseToolUseBlockUnion>
    {
        /// <inheritdoc />
        public override global::Anthropic.ResponseToolUseBlockUnion Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            var __score1 = 0;
            var __score2 = 0;
            if (__jsonProps.Contains("caller")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("input")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("toolset_name")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Anthropic.ResponseBrowserToolUseBlock? responseBrowserToolUseBlock = default;
            global::Anthropic.ResponseComputerToolUseBlock? responseComputerToolUseBlock = default;
            global::Anthropic.ResponseToolUseBlock? responseToolUseBlock = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserToolUseBlock> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserToolUseBlock).Name}");
                        responseBrowserToolUseBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerToolUseBlock> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseComputerToolUseBlock).Name}");
                        responseComputerToolUseBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseToolUseBlock> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseToolUseBlock).Name}");
                        responseToolUseBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (responseBrowserToolUseBlock == null && responseComputerToolUseBlock == null && responseToolUseBlock == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserToolUseBlock> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserToolUseBlock).Name}");
                    responseBrowserToolUseBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseBrowserToolUseBlock == null && responseComputerToolUseBlock == null && responseToolUseBlock == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerToolUseBlock> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseComputerToolUseBlock).Name}");
                    responseComputerToolUseBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (responseBrowserToolUseBlock == null && responseComputerToolUseBlock == null && responseToolUseBlock == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseToolUseBlock> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseToolUseBlock).Name}");
                    responseToolUseBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Anthropic.ResponseToolUseBlockUnion(
                responseBrowserToolUseBlock,

                responseComputerToolUseBlock,

                responseToolUseBlock
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ResponseToolUseBlockUnion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResponseBrowserToolUseBlock)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseBrowserToolUseBlock(), typeInfo);
            }
            else if (value.IsResponseComputerToolUseBlock)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseComputerToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseComputerToolUseBlock(), typeInfo);
            }
            else if (value.IsResponseToolUseBlock)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseToolUseBlock(), typeInfo);
            }
        }
    }
}