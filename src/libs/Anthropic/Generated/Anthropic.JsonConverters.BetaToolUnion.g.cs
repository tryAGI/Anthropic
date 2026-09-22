#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaToolUnionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaToolUnion>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaToolUnion Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

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
            if (__jsonProps.Contains("allowed_callers")) __score3++;
            if (__jsonProps.Contains("cache_control")) __score3++;
            if (__jsonProps.Contains("defer_loading")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("strict")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score4++;
            if (__jsonProps.Contains("cache_control")) __score4++;
            if (__jsonProps.Contains("defer_loading")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("strict")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score5++;
            if (__jsonProps.Contains("cache_control")) __score5++;
            if (__jsonProps.Contains("defer_loading")) __score5++;
            if (__jsonProps.Contains("name")) __score5++;
            if (__jsonProps.Contains("strict")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score6++;
            if (__jsonProps.Contains("cache_control")) __score6++;
            if (__jsonProps.Contains("defer_loading")) __score6++;
            if (__jsonProps.Contains("name")) __score6++;
            if (__jsonProps.Contains("strict")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("cache_control")) __score7++;
            if (__jsonProps.Contains("configs")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score8++;
            if (__jsonProps.Contains("cache_control")) __score8++;
            if (__jsonProps.Contains("defer_loading")) __score8++;
            if (__jsonProps.Contains("display_height_px")) __score8++;
            if (__jsonProps.Contains("display_number")) __score8++;
            if (__jsonProps.Contains("display_width_px")) __score8++;
            if (__jsonProps.Contains("input_examples")) __score8++;
            if (__jsonProps.Contains("name")) __score8++;
            if (__jsonProps.Contains("strict")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score9++;
            if (__jsonProps.Contains("cache_control")) __score9++;
            if (__jsonProps.Contains("defer_loading")) __score9++;
            if (__jsonProps.Contains("input_examples")) __score9++;
            if (__jsonProps.Contains("name")) __score9++;
            if (__jsonProps.Contains("strict")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score10++;
            if (__jsonProps.Contains("cache_control")) __score10++;
            if (__jsonProps.Contains("defer_loading")) __score10++;
            if (__jsonProps.Contains("display_height_px")) __score10++;
            if (__jsonProps.Contains("display_number")) __score10++;
            if (__jsonProps.Contains("display_width_px")) __score10++;
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
            if (__jsonProps.Contains("display_height_px")) __score12++;
            if (__jsonProps.Contains("display_number")) __score12++;
            if (__jsonProps.Contains("display_width_px")) __score12++;
            if (__jsonProps.Contains("enable_zoom")) __score12++;
            if (__jsonProps.Contains("input_examples")) __score12++;
            if (__jsonProps.Contains("name")) __score12++;
            if (__jsonProps.Contains("strict")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("cache_control")) __score13++;
            if (__jsonProps.Contains("configs")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score14++;
            if (__jsonProps.Contains("cache_control")) __score14++;
            if (__jsonProps.Contains("defer_loading")) __score14++;
            if (__jsonProps.Contains("input_examples")) __score14++;
            if (__jsonProps.Contains("name")) __score14++;
            if (__jsonProps.Contains("strict")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score15++;
            if (__jsonProps.Contains("cache_control")) __score15++;
            if (__jsonProps.Contains("defer_loading")) __score15++;
            if (__jsonProps.Contains("input_examples")) __score15++;
            if (__jsonProps.Contains("name")) __score15++;
            if (__jsonProps.Contains("strict")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score16++;
            if (__jsonProps.Contains("cache_control")) __score16++;
            if (__jsonProps.Contains("defer_loading")) __score16++;
            if (__jsonProps.Contains("input_examples")) __score16++;
            if (__jsonProps.Contains("max_characters")) __score16++;
            if (__jsonProps.Contains("name")) __score16++;
            if (__jsonProps.Contains("strict")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score17++;
            if (__jsonProps.Contains("allowed_domains")) __score17++;
            if (__jsonProps.Contains("blocked_domains")) __score17++;
            if (__jsonProps.Contains("cache_control")) __score17++;
            if (__jsonProps.Contains("defer_loading")) __score17++;
            if (__jsonProps.Contains("max_uses")) __score17++;
            if (__jsonProps.Contains("name")) __score17++;
            if (__jsonProps.Contains("strict")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
            if (__jsonProps.Contains("user_location")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score18++;
            if (__jsonProps.Contains("allowed_domains")) __score18++;
            if (__jsonProps.Contains("blocked_domains")) __score18++;
            if (__jsonProps.Contains("cache_control")) __score18++;
            if (__jsonProps.Contains("citations")) __score18++;
            if (__jsonProps.Contains("defer_loading")) __score18++;
            if (__jsonProps.Contains("max_content_tokens")) __score18++;
            if (__jsonProps.Contains("max_uses")) __score18++;
            if (__jsonProps.Contains("name")) __score18++;
            if (__jsonProps.Contains("strict")) __score18++;
            if (__jsonProps.Contains("type")) __score18++;
            if (__jsonProps.Contains("url_sources")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score19++;
            if (__jsonProps.Contains("allowed_domains")) __score19++;
            if (__jsonProps.Contains("blocked_domains")) __score19++;
            if (__jsonProps.Contains("cache_control")) __score19++;
            if (__jsonProps.Contains("defer_loading")) __score19++;
            if (__jsonProps.Contains("max_uses")) __score19++;
            if (__jsonProps.Contains("name")) __score19++;
            if (__jsonProps.Contains("strict")) __score19++;
            if (__jsonProps.Contains("type")) __score19++;
            if (__jsonProps.Contains("user_location")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score20++;
            if (__jsonProps.Contains("allowed_domains")) __score20++;
            if (__jsonProps.Contains("blocked_domains")) __score20++;
            if (__jsonProps.Contains("cache_control")) __score20++;
            if (__jsonProps.Contains("citations")) __score20++;
            if (__jsonProps.Contains("defer_loading")) __score20++;
            if (__jsonProps.Contains("max_content_tokens")) __score20++;
            if (__jsonProps.Contains("max_uses")) __score20++;
            if (__jsonProps.Contains("name")) __score20++;
            if (__jsonProps.Contains("strict")) __score20++;
            if (__jsonProps.Contains("type")) __score20++;
            if (__jsonProps.Contains("url_sources")) __score20++;
            var __score21 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score21++;
            if (__jsonProps.Contains("allowed_domains")) __score21++;
            if (__jsonProps.Contains("blocked_domains")) __score21++;
            if (__jsonProps.Contains("cache_control")) __score21++;
            if (__jsonProps.Contains("citations")) __score21++;
            if (__jsonProps.Contains("defer_loading")) __score21++;
            if (__jsonProps.Contains("max_content_tokens")) __score21++;
            if (__jsonProps.Contains("max_uses")) __score21++;
            if (__jsonProps.Contains("name")) __score21++;
            if (__jsonProps.Contains("strict")) __score21++;
            if (__jsonProps.Contains("type")) __score21++;
            if (__jsonProps.Contains("url_sources")) __score21++;
            if (__jsonProps.Contains("use_cache")) __score21++;
            var __score22 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score22++;
            if (__jsonProps.Contains("allowed_domains")) __score22++;
            if (__jsonProps.Contains("blocked_domains")) __score22++;
            if (__jsonProps.Contains("cache_control")) __score22++;
            if (__jsonProps.Contains("defer_loading")) __score22++;
            if (__jsonProps.Contains("max_uses")) __score22++;
            if (__jsonProps.Contains("name")) __score22++;
            if (__jsonProps.Contains("response_inclusion")) __score22++;
            if (__jsonProps.Contains("strict")) __score22++;
            if (__jsonProps.Contains("type")) __score22++;
            if (__jsonProps.Contains("user_location")) __score22++;
            var __score23 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score23++;
            if (__jsonProps.Contains("allowed_domains")) __score23++;
            if (__jsonProps.Contains("blocked_domains")) __score23++;
            if (__jsonProps.Contains("cache_control")) __score23++;
            if (__jsonProps.Contains("citations")) __score23++;
            if (__jsonProps.Contains("defer_loading")) __score23++;
            if (__jsonProps.Contains("max_content_tokens")) __score23++;
            if (__jsonProps.Contains("max_uses")) __score23++;
            if (__jsonProps.Contains("name")) __score23++;
            if (__jsonProps.Contains("response_inclusion")) __score23++;
            if (__jsonProps.Contains("strict")) __score23++;
            if (__jsonProps.Contains("type")) __score23++;
            if (__jsonProps.Contains("url_sources")) __score23++;
            if (__jsonProps.Contains("use_cache")) __score23++;
            var __score24 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score24++;
            if (__jsonProps.Contains("cache_control")) __score24++;
            if (__jsonProps.Contains("caching")) __score24++;
            if (__jsonProps.Contains("defer_loading")) __score24++;
            if (__jsonProps.Contains("max_tokens")) __score24++;
            if (__jsonProps.Contains("max_uses")) __score24++;
            if (__jsonProps.Contains("model")) __score24++;
            if (__jsonProps.Contains("name")) __score24++;
            if (__jsonProps.Contains("strict")) __score24++;
            if (__jsonProps.Contains("type")) __score24++;
            var __score25 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score25++;
            if (__jsonProps.Contains("cache_control")) __score25++;
            if (__jsonProps.Contains("defer_loading")) __score25++;
            if (__jsonProps.Contains("name")) __score25++;
            if (__jsonProps.Contains("strict")) __score25++;
            if (__jsonProps.Contains("type")) __score25++;
            var __score26 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score26++;
            if (__jsonProps.Contains("cache_control")) __score26++;
            if (__jsonProps.Contains("defer_loading")) __score26++;
            if (__jsonProps.Contains("name")) __score26++;
            if (__jsonProps.Contains("strict")) __score26++;
            if (__jsonProps.Contains("type")) __score26++;
            var __score27 = 0;
            if (__jsonProps.Contains("cache_control")) __score27++;
            if (__jsonProps.Contains("configs")) __score27++;
            if (__jsonProps.Contains("default_config")) __score27++;
            if (__jsonProps.Contains("default_config.defer_loading")) __score27++;
            if (__jsonProps.Contains("default_config.enabled")) __score27++;
            if (__jsonProps.Contains("mcp_server_name")) __score27++;
            if (__jsonProps.Contains("tools")) __score27++;
            if (__jsonProps.Contains("type")) __score27++;
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
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }
            if (__score16 > __bestScore) { __bestScore = __score16; __bestIndex = 16; }
            if (__score17 > __bestScore) { __bestScore = __score17; __bestIndex = 17; }
            if (__score18 > __bestScore) { __bestScore = __score18; __bestIndex = 18; }
            if (__score19 > __bestScore) { __bestScore = __score19; __bestIndex = 19; }
            if (__score20 > __bestScore) { __bestScore = __score20; __bestIndex = 20; }
            if (__score21 > __bestScore) { __bestScore = __score21; __bestIndex = 21; }
            if (__score22 > __bestScore) { __bestScore = __score22; __bestIndex = 22; }
            if (__score23 > __bestScore) { __bestScore = __score23; __bestIndex = 23; }
            if (__score24 > __bestScore) { __bestScore = __score24; __bestIndex = 24; }
            if (__score25 > __bestScore) { __bestScore = __score25; __bestIndex = 25; }
            if (__score26 > __bestScore) { __bestScore = __score26; __bestIndex = 26; }
            if (__score27 > __bestScore) { __bestScore = __score27; __bestIndex = 27; }

            global::Anthropic.BetaTool? tool = default;
            global::Anthropic.BetaBashTool20241022? bashTool20241022 = default;
            global::Anthropic.BetaBashTool20250124? bashTool20250124 = default;
            global::Anthropic.BetaCodeExecutionTool20250522? codeExecutionTool20250522 = default;
            global::Anthropic.BetaCodeExecutionTool20250825? codeExecutionTool20250825 = default;
            global::Anthropic.BetaCodeExecutionTool20260120? codeExecutionTool20260120 = default;
            global::Anthropic.BetaCodeExecutionTool20260521? codeExecutionTool20260521 = default;
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
            global::Anthropic.BetaWebSearchTool20250305? webSearchTool20250305 = default;
            global::Anthropic.BetaWebFetchTool20250910? webFetchTool20250910 = default;
            global::Anthropic.BetaWebSearchTool20260209? webSearchTool20260209 = default;
            global::Anthropic.BetaWebFetchTool20260209? webFetchTool20260209 = default;
            global::Anthropic.BetaWebFetchTool20260309? webFetchTool20260309 = default;
            global::Anthropic.BetaWebSearchTool20260318? webSearchTool20260318 = default;
            global::Anthropic.BetaWebFetchTool20260318? webFetchTool20260318 = default;
            global::Anthropic.BetaAdvisorTool20260301? advisorTool20260301 = default;
            global::Anthropic.BetaToolSearchToolBM2520251119? toolSearchToolBM2520251119 = default;
            global::Anthropic.BetaToolSearchToolRegex20251119? toolSearchToolRegex20251119 = default;
            global::Anthropic.BetaMCPToolset? mCPToolset = default;
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCodeExecutionTool20250522), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCodeExecutionTool20250522> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaCodeExecutionTool20250522).Name}");
                        codeExecutionTool20250522 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCodeExecutionTool20250825), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCodeExecutionTool20250825> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaCodeExecutionTool20250825).Name}");
                        codeExecutionTool20250825 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCodeExecutionTool20260120), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCodeExecutionTool20260120> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaCodeExecutionTool20260120).Name}");
                        codeExecutionTool20260120 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCodeExecutionTool20260521), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCodeExecutionTool20260521> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaCodeExecutionTool20260521).Name}");
                        codeExecutionTool20260521 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                else if (__bestIndex == 8)
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
                else if (__bestIndex == 9)
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
                else if (__bestIndex == 10)
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
                else if (__bestIndex == 11)
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
                else if (__bestIndex == 12)
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
                else if (__bestIndex == 13)
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
                else if (__bestIndex == 14)
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
                else if (__bestIndex == 15)
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
                else if (__bestIndex == 16)
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
                else if (__bestIndex == 17)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebSearchTool20250305), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebSearchTool20250305> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebSearchTool20250305).Name}");
                        webSearchTool20250305 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 18)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebFetchTool20250910), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebFetchTool20250910> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebFetchTool20250910).Name}");
                        webFetchTool20250910 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 19)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebSearchTool20260209), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebSearchTool20260209> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebSearchTool20260209).Name}");
                        webSearchTool20260209 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 20)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebFetchTool20260209), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebFetchTool20260209> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebFetchTool20260209).Name}");
                        webFetchTool20260209 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 21)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebFetchTool20260309), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebFetchTool20260309> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebFetchTool20260309).Name}");
                        webFetchTool20260309 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 22)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebSearchTool20260318), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebSearchTool20260318> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebSearchTool20260318).Name}");
                        webSearchTool20260318 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 23)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebFetchTool20260318), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebFetchTool20260318> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebFetchTool20260318).Name}");
                        webFetchTool20260318 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 24)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAdvisorTool20260301), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAdvisorTool20260301> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaAdvisorTool20260301).Name}");
                        advisorTool20260301 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 25)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaToolSearchToolBM2520251119), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaToolSearchToolBM2520251119> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaToolSearchToolBM2520251119).Name}");
                        toolSearchToolBM2520251119 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 26)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaToolSearchToolRegex20251119), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaToolSearchToolRegex20251119> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaToolSearchToolRegex20251119).Name}");
                        toolSearchToolRegex20251119 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 27)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaMCPToolset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaMCPToolset> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaMCPToolset).Name}");
                        mCPToolset = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
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

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
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

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
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

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCodeExecutionTool20250522), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCodeExecutionTool20250522> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaCodeExecutionTool20250522).Name}");
                    codeExecutionTool20250522 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCodeExecutionTool20250825), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCodeExecutionTool20250825> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaCodeExecutionTool20250825).Name}");
                    codeExecutionTool20250825 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCodeExecutionTool20260120), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCodeExecutionTool20260120> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaCodeExecutionTool20260120).Name}");
                    codeExecutionTool20260120 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCodeExecutionTool20260521), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCodeExecutionTool20260521> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaCodeExecutionTool20260521).Name}");
                    codeExecutionTool20260521 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
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

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
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

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
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

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
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

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
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

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
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

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
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

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
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

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
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

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
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

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebSearchTool20250305), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebSearchTool20250305> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebSearchTool20250305).Name}");
                    webSearchTool20250305 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebFetchTool20250910), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebFetchTool20250910> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebFetchTool20250910).Name}");
                    webFetchTool20250910 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebSearchTool20260209), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebSearchTool20260209> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebSearchTool20260209).Name}");
                    webSearchTool20260209 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebFetchTool20260209), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebFetchTool20260209> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebFetchTool20260209).Name}");
                    webFetchTool20260209 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebFetchTool20260309), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebFetchTool20260309> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebFetchTool20260309).Name}");
                    webFetchTool20260309 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebSearchTool20260318), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebSearchTool20260318> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebSearchTool20260318).Name}");
                    webSearchTool20260318 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebFetchTool20260318), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebFetchTool20260318> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebFetchTool20260318).Name}");
                    webFetchTool20260318 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAdvisorTool20260301), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAdvisorTool20260301> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaAdvisorTool20260301).Name}");
                    advisorTool20260301 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaToolSearchToolBM2520251119), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaToolSearchToolBM2520251119> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaToolSearchToolBM2520251119).Name}");
                    toolSearchToolBM2520251119 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaToolSearchToolRegex20251119), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaToolSearchToolRegex20251119> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaToolSearchToolRegex20251119).Name}");
                    toolSearchToolRegex20251119 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (tool == null && bashTool20241022 == null && bashTool20250124 == null && codeExecutionTool20250522 == null && codeExecutionTool20250825 == null && codeExecutionTool20260120 == null && codeExecutionTool20260521 == null && browserToolset20260801 == null && computerUseTool20241022 == null && memoryTool20250818 == null && computerUseTool20250124 == null && textEditor20241022 == null && computerUseTool20251124 == null && computerToolset20260801 == null && textEditor20250124 == null && textEditor20250429 == null && textEditor20250728 == null && webSearchTool20250305 == null && webFetchTool20250910 == null && webSearchTool20260209 == null && webFetchTool20260209 == null && webFetchTool20260309 == null && webSearchTool20260318 == null && webFetchTool20260318 == null && advisorTool20260301 == null && toolSearchToolBM2520251119 == null && toolSearchToolRegex20251119 == null && mCPToolset == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaMCPToolset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaMCPToolset> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaMCPToolset).Name}");
                    mCPToolset = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Anthropic.BetaToolUnion(
                tool,

                bashTool20241022,

                bashTool20250124,

                codeExecutionTool20250522,

                codeExecutionTool20250825,

                codeExecutionTool20260120,

                codeExecutionTool20260521,

                browserToolset20260801,

                computerUseTool20241022,

                memoryTool20250818,

                computerUseTool20250124,

                textEditor20241022,

                computerUseTool20251124,

                computerToolset20260801,

                textEditor20250124,

                textEditor20250429,

                textEditor20250728,

                webSearchTool20250305,

                webFetchTool20250910,

                webSearchTool20260209,

                webFetchTool20260209,

                webFetchTool20260309,

                webSearchTool20260318,

                webFetchTool20260318,

                advisorTool20260301,

                toolSearchToolBM2520251119,

                toolSearchToolRegex20251119,

                mCPToolset
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaToolUnion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool!, typeInfo);
            }
            else if (value.IsBashTool20241022)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBashTool20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBashTool20241022?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBashTool20241022).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BashTool20241022!, typeInfo);
            }
            else if (value.IsBashTool20250124)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBashTool20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBashTool20250124?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBashTool20250124).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BashTool20250124!, typeInfo);
            }
            else if (value.IsCodeExecutionTool20250522)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCodeExecutionTool20250522), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCodeExecutionTool20250522?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaCodeExecutionTool20250522).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionTool20250522!, typeInfo);
            }
            else if (value.IsCodeExecutionTool20250825)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCodeExecutionTool20250825), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCodeExecutionTool20250825?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaCodeExecutionTool20250825).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionTool20250825!, typeInfo);
            }
            else if (value.IsCodeExecutionTool20260120)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCodeExecutionTool20260120), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCodeExecutionTool20260120?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaCodeExecutionTool20260120).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionTool20260120!, typeInfo);
            }
            else if (value.IsCodeExecutionTool20260521)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaCodeExecutionTool20260521), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaCodeExecutionTool20260521?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaCodeExecutionTool20260521).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionTool20260521!, typeInfo);
            }
            else if (value.IsBrowserToolset20260801)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserToolset20260801), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserToolset20260801?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserToolset20260801).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BrowserToolset20260801!, typeInfo);
            }
            else if (value.IsComputerUseTool20241022)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaComputerUseTool20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaComputerUseTool20241022?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaComputerUseTool20241022).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerUseTool20241022!, typeInfo);
            }
            else if (value.IsMemoryTool20250818)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaMemoryTool20250818), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaMemoryTool20250818?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaMemoryTool20250818).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MemoryTool20250818!, typeInfo);
            }
            else if (value.IsComputerUseTool20250124)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaComputerUseTool20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaComputerUseTool20250124?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaComputerUseTool20250124).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerUseTool20250124!, typeInfo);
            }
            else if (value.IsTextEditor20241022)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextEditor20241022), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextEditor20241022?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTextEditor20241022).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor20241022!, typeInfo);
            }
            else if (value.IsComputerUseTool20251124)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaComputerUseTool20251124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaComputerUseTool20251124?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaComputerUseTool20251124).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerUseTool20251124!, typeInfo);
            }
            else if (value.IsComputerToolset20260801)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaComputerToolset20260801), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaComputerToolset20260801?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaComputerToolset20260801).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerToolset20260801!, typeInfo);
            }
            else if (value.IsTextEditor20250124)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextEditor20250124), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextEditor20250124?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTextEditor20250124).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor20250124!, typeInfo);
            }
            else if (value.IsTextEditor20250429)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextEditor20250429), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextEditor20250429?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTextEditor20250429).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor20250429!, typeInfo);
            }
            else if (value.IsTextEditor20250728)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaTextEditor20250728), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaTextEditor20250728?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaTextEditor20250728).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor20250728!, typeInfo);
            }
            else if (value.IsWebSearchTool20250305)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebSearchTool20250305), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebSearchTool20250305?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebSearchTool20250305).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchTool20250305!, typeInfo);
            }
            else if (value.IsWebFetchTool20250910)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebFetchTool20250910), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebFetchTool20250910?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebFetchTool20250910).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebFetchTool20250910!, typeInfo);
            }
            else if (value.IsWebSearchTool20260209)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebSearchTool20260209), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebSearchTool20260209?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebSearchTool20260209).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchTool20260209!, typeInfo);
            }
            else if (value.IsWebFetchTool20260209)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebFetchTool20260209), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebFetchTool20260209?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebFetchTool20260209).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebFetchTool20260209!, typeInfo);
            }
            else if (value.IsWebFetchTool20260309)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebFetchTool20260309), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebFetchTool20260309?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebFetchTool20260309).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebFetchTool20260309!, typeInfo);
            }
            else if (value.IsWebSearchTool20260318)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebSearchTool20260318), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebSearchTool20260318?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebSearchTool20260318).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchTool20260318!, typeInfo);
            }
            else if (value.IsWebFetchTool20260318)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWebFetchTool20260318), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWebFetchTool20260318?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWebFetchTool20260318).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebFetchTool20260318!, typeInfo);
            }
            else if (value.IsAdvisorTool20260301)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAdvisorTool20260301), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAdvisorTool20260301?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaAdvisorTool20260301).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AdvisorTool20260301!, typeInfo);
            }
            else if (value.IsToolSearchToolBM2520251119)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaToolSearchToolBM2520251119), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaToolSearchToolBM2520251119?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaToolSearchToolBM2520251119).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolSearchToolBM2520251119!, typeInfo);
            }
            else if (value.IsToolSearchToolRegex20251119)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaToolSearchToolRegex20251119), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaToolSearchToolRegex20251119?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaToolSearchToolRegex20251119).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolSearchToolRegex20251119!, typeInfo);
            }
            else if (value.IsMCPToolset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaMCPToolset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaMCPToolset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaMCPToolset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MCPToolset!, typeInfo);
            }
        }
    }
}