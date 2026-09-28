#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ClientToolUnionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ClientToolUnion>
    {
        /// <inheritdoc />
        public override global::Anthropic.ClientToolUnion Read(
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
            if (__jsonProps.Contains("allowed_callers")) __score0++;
            if (__jsonProps.Contains("cache_control")) __score0++;
            if (__jsonProps.Contains("defer_loading")) __score0++;
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("eager_input_streaming")) __score0++;
            if (__jsonProps.Contains("input_examples")) __score0++;
            if (__jsonProps.Contains("input_schema")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("strict")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score1++;
            if (__jsonProps.Contains("cache_control")) __score1++;
            if (__jsonProps.Contains("defer_loading")) __score1++;
            if (__jsonProps.Contains("input_examples")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("strict")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("cache_control")) __score2++;
            if (__jsonProps.Contains("configs")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score3++;
            if (__jsonProps.Contains("cache_control")) __score3++;
            if (__jsonProps.Contains("defer_loading")) __score3++;
            if (__jsonProps.Contains("input_examples")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("strict")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("cache_control")) __score4++;
            if (__jsonProps.Contains("configs")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score5++;
            if (__jsonProps.Contains("cache_control")) __score5++;
            if (__jsonProps.Contains("defer_loading")) __score5++;
            if (__jsonProps.Contains("input_examples")) __score5++;
            if (__jsonProps.Contains("name")) __score5++;
            if (__jsonProps.Contains("strict")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score6++;
            if (__jsonProps.Contains("cache_control")) __score6++;
            if (__jsonProps.Contains("defer_loading")) __score6++;
            if (__jsonProps.Contains("input_examples")) __score6++;
            if (__jsonProps.Contains("name")) __score6++;
            if (__jsonProps.Contains("strict")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score7++;
            if (__jsonProps.Contains("cache_control")) __score7++;
            if (__jsonProps.Contains("defer_loading")) __score7++;
            if (__jsonProps.Contains("input_examples")) __score7++;
            if (__jsonProps.Contains("max_characters")) __score7++;
            if (__jsonProps.Contains("name")) __score7++;
            if (__jsonProps.Contains("strict")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }

            global::Anthropic.Tool5? tool = default;
            global::Anthropic.BashTool20250124? bashTool20250124 = default;
            global::Anthropic.BrowserToolset20260801? browserToolset20260801 = default;
            global::Anthropic.MemoryTool20250818? memoryTool20250818 = default;
            global::Anthropic.ComputerToolset20260801? computerToolset20260801 = default;
            global::Anthropic.TextEditor20250124? textEditor20250124 = default;
            global::Anthropic.TextEditor20250429? textEditor20250429 = default;
            global::Anthropic.TextEditor20250728? textEditor20250728 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.Tool5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.Tool5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.Tool5).Name}");
                        tool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BashTool20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BashTool20250124> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BashTool20250124).Name}");
                        bashTool20250124 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserToolset20260801), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserToolset20260801> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserToolset20260801).Name}");
                        browserToolset20260801 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.MemoryTool20250818), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.MemoryTool20250818> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.MemoryTool20250818).Name}");
                        memoryTool20250818 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerToolset20260801), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerToolset20260801> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerToolset20260801).Name}");
                        computerToolset20260801 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.TextEditor20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.TextEditor20250124> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.TextEditor20250124).Name}");
                        textEditor20250124 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.TextEditor20250429), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.TextEditor20250429> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.TextEditor20250429).Name}");
                        textEditor20250429 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.TextEditor20250728), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.TextEditor20250728> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.TextEditor20250728).Name}");
                        textEditor20250728 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (tool == null && bashTool20250124 == null && browserToolset20260801 == null && memoryTool20250818 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.Tool5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.Tool5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.Tool5).Name}");
                    tool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20250124 == null && browserToolset20260801 == null && memoryTool20250818 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BashTool20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BashTool20250124> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BashTool20250124).Name}");
                    bashTool20250124 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20250124 == null && browserToolset20260801 == null && memoryTool20250818 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserToolset20260801), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserToolset20260801> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserToolset20260801).Name}");
                    browserToolset20260801 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20250124 == null && browserToolset20260801 == null && memoryTool20250818 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.MemoryTool20250818), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.MemoryTool20250818> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.MemoryTool20250818).Name}");
                    memoryTool20250818 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20250124 == null && browserToolset20260801 == null && memoryTool20250818 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerToolset20260801), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerToolset20260801> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerToolset20260801).Name}");
                    computerToolset20260801 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20250124 == null && browserToolset20260801 == null && memoryTool20250818 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.TextEditor20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.TextEditor20250124> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.TextEditor20250124).Name}");
                    textEditor20250124 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20250124 == null && browserToolset20260801 == null && memoryTool20250818 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.TextEditor20250429), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.TextEditor20250429> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.TextEditor20250429).Name}");
                    textEditor20250429 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20250124 == null && browserToolset20260801 == null && memoryTool20250818 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.TextEditor20250728), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.TextEditor20250728> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.TextEditor20250728).Name}");
                    textEditor20250728 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Anthropic.ClientToolUnion(
                tool,

                bashTool20250124,

                browserToolset20260801,

                memoryTool20250818,

                computerToolset20260801,

                textEditor20250124,

                textEditor20250429,

                textEditor20250728
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ClientToolUnion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.Tool5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.Tool5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.Tool5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTool(), typeInfo);
            }
            else if (value.IsBashTool20250124)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BashTool20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BashTool20250124?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BashTool20250124).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBashTool20250124(), typeInfo);
            }
            else if (value.IsBrowserToolset20260801)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserToolset20260801), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserToolset20260801?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserToolset20260801).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserToolset20260801(), typeInfo);
            }
            else if (value.IsMemoryTool20250818)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.MemoryTool20250818), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.MemoryTool20250818?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.MemoryTool20250818).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMemoryTool20250818(), typeInfo);
            }
            else if (value.IsComputerToolset20260801)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerToolset20260801), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerToolset20260801?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerToolset20260801).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerToolset20260801(), typeInfo);
            }
            else if (value.IsTextEditor20250124)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.TextEditor20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.TextEditor20250124?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.TextEditor20250124).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTextEditor20250124(), typeInfo);
            }
            else if (value.IsTextEditor20250429)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.TextEditor20250429), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.TextEditor20250429?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.TextEditor20250429).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTextEditor20250429(), typeInfo);
            }
            else if (value.IsTextEditor20250728)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.TextEditor20250728), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.TextEditor20250728?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.TextEditor20250728).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTextEditor20250728(), typeInfo);
            }
        }
    }
}