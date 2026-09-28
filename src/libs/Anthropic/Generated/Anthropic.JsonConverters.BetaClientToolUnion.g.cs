#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaClientToolUnionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaClientToolUnion>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaClientToolUnion Read(
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
            if (__jsonProps.Contains("allowed_callers")) __score2++;
            if (__jsonProps.Contains("cache_control")) __score2++;
            if (__jsonProps.Contains("defer_loading")) __score2++;
            if (__jsonProps.Contains("input_examples")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("strict")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("cache_control")) __score3++;
            if (__jsonProps.Contains("configs")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score4++;
            if (__jsonProps.Contains("cache_control")) __score4++;
            if (__jsonProps.Contains("defer_loading")) __score4++;
            if (__jsonProps.Contains("display_height_px")) __score4++;
            if (__jsonProps.Contains("display_number")) __score4++;
            if (__jsonProps.Contains("display_width_px")) __score4++;
            if (__jsonProps.Contains("input_examples")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("strict")) __score4++;
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
            if (__jsonProps.Contains("display_height_px")) __score6++;
            if (__jsonProps.Contains("display_number")) __score6++;
            if (__jsonProps.Contains("display_width_px")) __score6++;
            if (__jsonProps.Contains("input_examples")) __score6++;
            if (__jsonProps.Contains("name")) __score6++;
            if (__jsonProps.Contains("strict")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score7++;
            if (__jsonProps.Contains("cache_control")) __score7++;
            if (__jsonProps.Contains("defer_loading")) __score7++;
            if (__jsonProps.Contains("input_examples")) __score7++;
            if (__jsonProps.Contains("name")) __score7++;
            if (__jsonProps.Contains("strict")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score8++;
            if (__jsonProps.Contains("cache_control")) __score8++;
            if (__jsonProps.Contains("defer_loading")) __score8++;
            if (__jsonProps.Contains("display_height_px")) __score8++;
            if (__jsonProps.Contains("display_number")) __score8++;
            if (__jsonProps.Contains("display_width_px")) __score8++;
            if (__jsonProps.Contains("enable_zoom")) __score8++;
            if (__jsonProps.Contains("input_examples")) __score8++;
            if (__jsonProps.Contains("name")) __score8++;
            if (__jsonProps.Contains("strict")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("cache_control")) __score9++;
            if (__jsonProps.Contains("configs")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score10++;
            if (__jsonProps.Contains("cache_control")) __score10++;
            if (__jsonProps.Contains("defer_loading")) __score10++;
            if (__jsonProps.Contains("input_examples")) __score10++;
            if (__jsonProps.Contains("name")) __score10++;
            if (__jsonProps.Contains("strict")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score11++;
            if (__jsonProps.Contains("cache_control")) __score11++;
            if (__jsonProps.Contains("defer_loading")) __score11++;
            if (__jsonProps.Contains("input_examples")) __score11++;
            if (__jsonProps.Contains("name")) __score11++;
            if (__jsonProps.Contains("strict")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score12++;
            if (__jsonProps.Contains("cache_control")) __score12++;
            if (__jsonProps.Contains("defer_loading")) __score12++;
            if (__jsonProps.Contains("input_examples")) __score12++;
            if (__jsonProps.Contains("max_characters")) __score12++;
            if (__jsonProps.Contains("name")) __score12++;
            if (__jsonProps.Contains("strict")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
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
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }

            global::Anthropic.BetaTool? tool = default;
            global::Anthropic.BetaBashTool20241022? bashTool20241022 = default;
            global::Anthropic.BetaBashTool20250124? bashTool20250124 = default;
            global::Anthropic.BetaBrowserToolset20260801? browserToolset20260801 = default;
            global::Anthropic.BetaComputerUseTool20241022? computerUseTool20241022 = default;
            global::Anthropic.BetaMemoryTool20250818? memoryTool20250818 = default;
            global::Anthropic.BetaComputerUseTool20250124? computerUseTool20250124 = default;
            global::Anthropic.BetaTextEditor20241022? textEditor20241022 = default;
            global::Anthropic.BetaComputerUseTool20251124? computerUseTool20251124 = default;
            global::Anthropic.BetaComputerToolset20260801? computerToolset20260801 = default;
            global::Anthropic.BetaTextEditor20250124? textEditor20250124 = default;
            global::Anthropic.BetaTextEditor20250429? textEditor20250429 = default;
            global::Anthropic.BetaTextEditor20250728? textEditor20250728 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTool).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBashTool20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBashTool20241022> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBashTool20241022).Name}");
                        bashTool20241022 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBashTool20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBashTool20250124> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBashTool20250124).Name}");
                        bashTool20250124 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserToolset20260801), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserToolset20260801> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserToolset20260801).Name}");
                        browserToolset20260801 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaComputerUseTool20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaComputerUseTool20241022> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaComputerUseTool20241022).Name}");
                        computerUseTool20241022 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaMemoryTool20250818), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaMemoryTool20250818> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaMemoryTool20250818).Name}");
                        memoryTool20250818 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaComputerUseTool20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaComputerUseTool20250124> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaComputerUseTool20250124).Name}");
                        computerUseTool20250124 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextEditor20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextEditor20241022> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTextEditor20241022).Name}");
                        textEditor20241022 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaComputerUseTool20251124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaComputerUseTool20251124> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaComputerUseTool20251124).Name}");
                        computerUseTool20251124 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaComputerToolset20260801), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaComputerToolset20260801> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaComputerToolset20260801).Name}");
                        computerToolset20260801 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextEditor20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextEditor20250124> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTextEditor20250124).Name}");
                        textEditor20250124 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextEditor20250429), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextEditor20250429> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTextEditor20250429).Name}");
                        textEditor20250429 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextEditor20250728), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextEditor20250728> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTextEditor20250728).Name}");
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

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTool).Name}");
                    tool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBashTool20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBashTool20241022> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBashTool20241022).Name}");
                    bashTool20241022 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBashTool20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBashTool20250124> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBashTool20250124).Name}");
                    bashTool20250124 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserToolset20260801), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserToolset20260801> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserToolset20260801).Name}");
                    browserToolset20260801 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaComputerUseTool20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaComputerUseTool20241022> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaComputerUseTool20241022).Name}");
                    computerUseTool20241022 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaMemoryTool20250818), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaMemoryTool20250818> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaMemoryTool20250818).Name}");
                    memoryTool20250818 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaComputerUseTool20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaComputerUseTool20250124> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaComputerUseTool20250124).Name}");
                    computerUseTool20250124 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextEditor20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextEditor20241022> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTextEditor20241022).Name}");
                    textEditor20241022 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaComputerUseTool20251124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaComputerUseTool20251124> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaComputerUseTool20251124).Name}");
                    computerUseTool20251124 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaComputerToolset20260801), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaComputerToolset20260801> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaComputerToolset20260801).Name}");
                    computerToolset20260801 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextEditor20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextEditor20250124> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTextEditor20250124).Name}");
                    textEditor20250124 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextEditor20250429), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextEditor20250429> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTextEditor20250429).Name}");
                    textEditor20250429 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextEditor20250728), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextEditor20250728> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTextEditor20250728).Name}");
                    textEditor20250728 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Anthropic.BetaClientToolUnion(
                tool,

                bashTool20241022,

                bashTool20250124,

                browserToolset20260801,

                computerUseTool20241022,

                memoryTool20250818,

                computerUseTool20250124,

                textEditor20241022,

                computerUseTool20251124,

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
            global::Anthropic.BetaClientToolUnion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTool(), typeInfo);
            }
            else if (value.IsBashTool20241022)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBashTool20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBashTool20241022?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBashTool20241022).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBashTool20241022(), typeInfo);
            }
            else if (value.IsBashTool20250124)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBashTool20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBashTool20250124?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBashTool20250124).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBashTool20250124(), typeInfo);
            }
            else if (value.IsBrowserToolset20260801)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserToolset20260801), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserToolset20260801?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserToolset20260801).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserToolset20260801(), typeInfo);
            }
            else if (value.IsComputerUseTool20241022)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaComputerUseTool20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaComputerUseTool20241022?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaComputerUseTool20241022).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerUseTool20241022(), typeInfo);
            }
            else if (value.IsMemoryTool20250818)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaMemoryTool20250818), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaMemoryTool20250818?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaMemoryTool20250818).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMemoryTool20250818(), typeInfo);
            }
            else if (value.IsComputerUseTool20250124)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaComputerUseTool20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaComputerUseTool20250124?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaComputerUseTool20250124).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerUseTool20250124(), typeInfo);
            }
            else if (value.IsTextEditor20241022)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextEditor20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextEditor20241022?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTextEditor20241022).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTextEditor20241022(), typeInfo);
            }
            else if (value.IsComputerUseTool20251124)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaComputerUseTool20251124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaComputerUseTool20251124?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaComputerUseTool20251124).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerUseTool20251124(), typeInfo);
            }
            else if (value.IsComputerToolset20260801)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaComputerToolset20260801), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaComputerToolset20260801?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaComputerToolset20260801).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerToolset20260801(), typeInfo);
            }
            else if (value.IsTextEditor20250124)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextEditor20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextEditor20250124?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTextEditor20250124).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTextEditor20250124(), typeInfo);
            }
            else if (value.IsTextEditor20250429)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextEditor20250429), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextEditor20250429?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTextEditor20250429).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTextEditor20250429(), typeInfo);
            }
            else if (value.IsTextEditor20250728)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextEditor20250728), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextEditor20250728?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTextEditor20250728).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTextEditor20250728(), typeInfo);
            }
        }
    }
}