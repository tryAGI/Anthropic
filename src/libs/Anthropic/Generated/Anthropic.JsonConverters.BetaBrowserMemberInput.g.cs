#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaBrowserMemberInputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaBrowserMemberInput>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaBrowserMemberInput Read(
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
            if (__jsonProps.Contains("tab_id")) __score0++;
            if (__jsonProps.Contains("url")) __score0++;
            var __score1 = 0;
            var __score2 = 0;
            var __score3 = 0;
            if (__jsonProps.Contains("tab_id")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("tab_id")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("depth")) __score5++;
            if (__jsonProps.Contains("filter")) __score5++;
            if (__jsonProps.Contains("ref")) __score5++;
            if (__jsonProps.Contains("tab_id")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("tab_id")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("tab_id")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("tab_id")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("query")) __score9++;
            if (__jsonProps.Contains("tab_id")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("tab_id")) __score10++;
            if (__jsonProps.Contains("target")) __score10++;
            if (__jsonProps.Contains("target.ref")) __score10++;
            if (__jsonProps.Contains("target.type")) __score10++;
            if (__jsonProps.Contains("value")) __score10++;
            var __score11 = 0;
            var __score12 = 0;
            if (__jsonProps.Contains("tab_id")) __score12++;
            if (__jsonProps.Contains("target")) __score12++;
            if (__jsonProps.Contains("target.ref")) __score12++;
            if (__jsonProps.Contains("target.type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("tab_id")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("region")) __score14++;
            if (__jsonProps.Contains("tab_id")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("modifiers")) __score15++;
            if (__jsonProps.Contains("tab_id")) __score15++;
            if (__jsonProps.Contains("target")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("modifiers")) __score16++;
            if (__jsonProps.Contains("tab_id")) __score16++;
            if (__jsonProps.Contains("target")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("modifiers")) __score17++;
            if (__jsonProps.Contains("tab_id")) __score17++;
            if (__jsonProps.Contains("target")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("modifiers")) __score18++;
            if (__jsonProps.Contains("tab_id")) __score18++;
            if (__jsonProps.Contains("target")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("modifiers")) __score19++;
            if (__jsonProps.Contains("tab_id")) __score19++;
            if (__jsonProps.Contains("target")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("tab_id")) __score20++;
            if (__jsonProps.Contains("target")) __score20++;
            var __score21 = 0;
            if (__jsonProps.Contains("from")) __score21++;
            if (__jsonProps.Contains("from.type")) __score21++;
            if (__jsonProps.Contains("from.x")) __score21++;
            if (__jsonProps.Contains("from.y")) __score21++;
            if (__jsonProps.Contains("tab_id")) __score21++;
            if (__jsonProps.Contains("target")) __score21++;
            if (__jsonProps.Contains("target.type")) __score21++;
            if (__jsonProps.Contains("target.x")) __score21++;
            if (__jsonProps.Contains("target.y")) __score21++;
            var __score22 = 0;
            if (__jsonProps.Contains("tab_id")) __score22++;
            if (__jsonProps.Contains("target")) __score22++;
            if (__jsonProps.Contains("target.type")) __score22++;
            if (__jsonProps.Contains("target.x")) __score22++;
            if (__jsonProps.Contains("target.y")) __score22++;
            var __score23 = 0;
            if (__jsonProps.Contains("tab_id")) __score23++;
            if (__jsonProps.Contains("target")) __score23++;
            if (__jsonProps.Contains("target.type")) __score23++;
            if (__jsonProps.Contains("target.x")) __score23++;
            if (__jsonProps.Contains("target.y")) __score23++;
            var __score24 = 0;
            if (__jsonProps.Contains("tab_id")) __score24++;
            if (__jsonProps.Contains("target")) __score24++;
            if (__jsonProps.Contains("target.type")) __score24++;
            if (__jsonProps.Contains("target.x")) __score24++;
            if (__jsonProps.Contains("target.y")) __score24++;
            var __score25 = 0;
            if (__jsonProps.Contains("scroll_amount")) __score25++;
            if (__jsonProps.Contains("scroll_direction")) __score25++;
            if (__jsonProps.Contains("tab_id")) __score25++;
            if (__jsonProps.Contains("target")) __score25++;
            if (__jsonProps.Contains("target.type")) __score25++;
            if (__jsonProps.Contains("target.x")) __score25++;
            if (__jsonProps.Contains("target.y")) __score25++;
            var __score26 = 0;
            if (__jsonProps.Contains("tab_id")) __score26++;
            if (__jsonProps.Contains("text")) __score26++;
            var __score27 = 0;
            if (__jsonProps.Contains("repeat")) __score27++;
            if (__jsonProps.Contains("tab_id")) __score27++;
            if (__jsonProps.Contains("text")) __score27++;
            var __score28 = 0;
            if (__jsonProps.Contains("duration")) __score28++;
            if (__jsonProps.Contains("tab_id")) __score28++;
            if (__jsonProps.Contains("text")) __score28++;
            var __score29 = 0;
            if (__jsonProps.Contains("duration")) __score29++;
            if (__jsonProps.Contains("tab_id")) __score29++;
            var __score30 = 0;
            if (__jsonProps.Contains("tab_id")) __score30++;
            if (__jsonProps.Contains("text")) __score30++;
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
            if (__score28 > __bestScore) { __bestScore = __score28; __bestIndex = 28; }
            if (__score29 > __bestScore) { __bestScore = __score29; __bestIndex = 29; }
            if (__score30 > __bestScore) { __bestScore = __score30; __bestIndex = 30; }

            global::Anthropic.BetaBrowserNavigateInput? browserNavigateInput = default;
            global::Anthropic.BetaBrowserListTabsInput? browserListTabsInput = default;
            global::Anthropic.BetaBrowserNewTabInput? browserNewTabInput = default;
            global::Anthropic.BetaBrowserSwitchTabInput? browserSwitchTabInput = default;
            global::Anthropic.BetaBrowserCloseTabInput? browserCloseTabInput = default;
            global::Anthropic.BetaBrowserReadPageInput? browserReadPageInput = default;
            global::Anthropic.BetaBrowserGetPageTextInput? browserGetPageTextInput = default;
            global::Anthropic.BetaBrowserReadConsoleInput? browserReadConsoleInput = default;
            global::Anthropic.BetaBrowserReadNetworkInput? browserReadNetworkInput = default;
            global::Anthropic.BetaBrowserFindInput? browserFindInput = default;
            global::Anthropic.BetaBrowserFormInputInput? browserFormInputInput = default;
            global::Anthropic.BetaBrowserFileUploadInput? fileUpload = default;
            global::Anthropic.BetaBrowserScrollToInput? browserScrollToInput = default;
            global::Anthropic.BetaBrowserScreenshotInput? browserScreenshotInput = default;
            global::Anthropic.BetaBrowserZoomInput? browserZoomInput = default;
            global::Anthropic.BetaBrowserLeftClickInput? browserLeftClickInput = default;
            global::Anthropic.BetaBrowserRightClickInput? browserRightClickInput = default;
            global::Anthropic.BetaBrowserMiddleClickInput? browserMiddleClickInput = default;
            global::Anthropic.BetaBrowserDoubleClickInput? browserDoubleClickInput = default;
            global::Anthropic.BetaBrowserTripleClickInput? browserTripleClickInput = default;
            global::Anthropic.BetaBrowserHoverInput? browserHoverInput = default;
            global::Anthropic.BetaBrowserLeftClickDragInput? browserLeftClickDragInput = default;
            global::Anthropic.BetaBrowserLeftMouseDownInput? browserLeftMouseDownInput = default;
            global::Anthropic.BetaBrowserLeftMouseUpInput? browserLeftMouseUpInput = default;
            global::Anthropic.BetaBrowserMouseMoveInput? browserMouseMoveInput = default;
            global::Anthropic.BetaBrowserScrollInput? browserScrollInput = default;
            global::Anthropic.BetaBrowserTypeInput? browserTypeInput = default;
            global::Anthropic.BetaBrowserKeyInput? browserKeyInput = default;
            global::Anthropic.BetaBrowserHoldKeyInput? browserHoldKeyInput = default;
            global::Anthropic.BetaBrowserWaitInput? browserWaitInput = default;
            global::Anthropic.BetaBrowserJavascriptExecInput? browserJavascriptExecInput = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserNavigateInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserNavigateInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserNavigateInput).Name}");
                        browserNavigateInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserListTabsInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserListTabsInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserListTabsInput).Name}");
                        browserListTabsInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserNewTabInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserNewTabInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserNewTabInput).Name}");
                        browserNewTabInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserSwitchTabInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserSwitchTabInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserSwitchTabInput).Name}");
                        browserSwitchTabInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserCloseTabInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserCloseTabInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserCloseTabInput).Name}");
                        browserCloseTabInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserReadPageInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserReadPageInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserReadPageInput).Name}");
                        browserReadPageInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserGetPageTextInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserGetPageTextInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserGetPageTextInput).Name}");
                        browserGetPageTextInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserReadConsoleInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserReadConsoleInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserReadConsoleInput).Name}");
                        browserReadConsoleInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserReadNetworkInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserReadNetworkInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserReadNetworkInput).Name}");
                        browserReadNetworkInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserFindInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserFindInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserFindInput).Name}");
                        browserFindInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserFormInputInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserFormInputInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserFormInputInput).Name}");
                        browserFormInputInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserFileUploadInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserFileUploadInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserFileUploadInput).Name}");
                        fileUpload = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserScrollToInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserScrollToInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserScrollToInput).Name}");
                        browserScrollToInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserScreenshotInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserScreenshotInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserScreenshotInput).Name}");
                        browserScreenshotInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserZoomInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserZoomInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserZoomInput).Name}");
                        browserZoomInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserLeftClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserLeftClickInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserLeftClickInput).Name}");
                        browserLeftClickInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserRightClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserRightClickInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserRightClickInput).Name}");
                        browserRightClickInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserMiddleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserMiddleClickInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserMiddleClickInput).Name}");
                        browserMiddleClickInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserDoubleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserDoubleClickInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserDoubleClickInput).Name}");
                        browserDoubleClickInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserTripleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserTripleClickInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserTripleClickInput).Name}");
                        browserTripleClickInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserHoverInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserHoverInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserHoverInput).Name}");
                        browserHoverInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserLeftClickDragInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserLeftClickDragInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserLeftClickDragInput).Name}");
                        browserLeftClickDragInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserLeftMouseDownInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserLeftMouseDownInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserLeftMouseDownInput).Name}");
                        browserLeftMouseDownInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserLeftMouseUpInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserLeftMouseUpInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserLeftMouseUpInput).Name}");
                        browserLeftMouseUpInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserMouseMoveInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserMouseMoveInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserMouseMoveInput).Name}");
                        browserMouseMoveInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserScrollInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserScrollInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserScrollInput).Name}");
                        browserScrollInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserTypeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserTypeInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserTypeInput).Name}");
                        browserTypeInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserKeyInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserKeyInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserKeyInput).Name}");
                        browserKeyInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 28)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserHoldKeyInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserHoldKeyInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserHoldKeyInput).Name}");
                        browserHoldKeyInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 29)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserWaitInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserWaitInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserWaitInput).Name}");
                        browserWaitInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 30)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserJavascriptExecInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserJavascriptExecInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserJavascriptExecInput).Name}");
                        browserJavascriptExecInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserNavigateInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserNavigateInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserNavigateInput).Name}");
                    browserNavigateInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserListTabsInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserListTabsInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserListTabsInput).Name}");
                    browserListTabsInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserNewTabInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserNewTabInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserNewTabInput).Name}");
                    browserNewTabInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserSwitchTabInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserSwitchTabInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserSwitchTabInput).Name}");
                    browserSwitchTabInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserCloseTabInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserCloseTabInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserCloseTabInput).Name}");
                    browserCloseTabInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserReadPageInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserReadPageInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserReadPageInput).Name}");
                    browserReadPageInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserGetPageTextInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserGetPageTextInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserGetPageTextInput).Name}");
                    browserGetPageTextInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserReadConsoleInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserReadConsoleInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserReadConsoleInput).Name}");
                    browserReadConsoleInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserReadNetworkInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserReadNetworkInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserReadNetworkInput).Name}");
                    browserReadNetworkInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserFindInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserFindInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserFindInput).Name}");
                    browserFindInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserFormInputInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserFormInputInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserFormInputInput).Name}");
                    browserFormInputInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserFileUploadInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserFileUploadInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserFileUploadInput).Name}");
                    fileUpload = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserScrollToInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserScrollToInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserScrollToInput).Name}");
                    browserScrollToInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserScreenshotInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserScreenshotInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserScreenshotInput).Name}");
                    browserScreenshotInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserZoomInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserZoomInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserZoomInput).Name}");
                    browserZoomInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserLeftClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserLeftClickInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserLeftClickInput).Name}");
                    browserLeftClickInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserRightClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserRightClickInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserRightClickInput).Name}");
                    browserRightClickInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserMiddleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserMiddleClickInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserMiddleClickInput).Name}");
                    browserMiddleClickInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserDoubleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserDoubleClickInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserDoubleClickInput).Name}");
                    browserDoubleClickInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserTripleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserTripleClickInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserTripleClickInput).Name}");
                    browserTripleClickInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserHoverInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserHoverInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserHoverInput).Name}");
                    browserHoverInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserLeftClickDragInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserLeftClickDragInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserLeftClickDragInput).Name}");
                    browserLeftClickDragInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserLeftMouseDownInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserLeftMouseDownInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserLeftMouseDownInput).Name}");
                    browserLeftMouseDownInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserLeftMouseUpInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserLeftMouseUpInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserLeftMouseUpInput).Name}");
                    browserLeftMouseUpInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserMouseMoveInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserMouseMoveInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserMouseMoveInput).Name}");
                    browserMouseMoveInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserScrollInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserScrollInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserScrollInput).Name}");
                    browserScrollInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserTypeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserTypeInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserTypeInput).Name}");
                    browserTypeInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserKeyInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserKeyInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserKeyInput).Name}");
                    browserKeyInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserHoldKeyInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserHoldKeyInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserHoldKeyInput).Name}");
                    browserHoldKeyInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserWaitInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserWaitInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserWaitInput).Name}");
                    browserWaitInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (browserNavigateInput == null && browserListTabsInput == null && browserNewTabInput == null && browserSwitchTabInput == null && browserCloseTabInput == null && browserReadPageInput == null && browserGetPageTextInput == null && browserReadConsoleInput == null && browserReadNetworkInput == null && browserFindInput == null && browserFormInputInput == null && fileUpload == null && browserScrollToInput == null && browserScreenshotInput == null && browserZoomInput == null && browserLeftClickInput == null && browserRightClickInput == null && browserMiddleClickInput == null && browserDoubleClickInput == null && browserTripleClickInput == null && browserHoverInput == null && browserLeftClickDragInput == null && browserLeftMouseDownInput == null && browserLeftMouseUpInput == null && browserMouseMoveInput == null && browserScrollInput == null && browserTypeInput == null && browserKeyInput == null && browserHoldKeyInput == null && browserWaitInput == null && browserJavascriptExecInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserJavascriptExecInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserJavascriptExecInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserJavascriptExecInput).Name}");
                    browserJavascriptExecInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Anthropic.BetaBrowserMemberInput(
                browserNavigateInput,

                browserListTabsInput,

                browserNewTabInput,

                browserSwitchTabInput,

                browserCloseTabInput,

                browserReadPageInput,

                browserGetPageTextInput,

                browserReadConsoleInput,

                browserReadNetworkInput,

                browserFindInput,

                browserFormInputInput,

                fileUpload,

                browserScrollToInput,

                browserScreenshotInput,

                browserZoomInput,

                browserLeftClickInput,

                browserRightClickInput,

                browserMiddleClickInput,

                browserDoubleClickInput,

                browserTripleClickInput,

                browserHoverInput,

                browserLeftClickDragInput,

                browserLeftMouseDownInput,

                browserLeftMouseUpInput,

                browserMouseMoveInput,

                browserScrollInput,

                browserTypeInput,

                browserKeyInput,

                browserHoldKeyInput,

                browserWaitInput,

                browserJavascriptExecInput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaBrowserMemberInput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBrowserNavigateInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserNavigateInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserNavigateInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserNavigateInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserNavigateInput(), typeInfo);
            }
            else if (value.IsBrowserListTabsInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserListTabsInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserListTabsInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserListTabsInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserListTabsInput(), typeInfo);
            }
            else if (value.IsBrowserNewTabInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserNewTabInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserNewTabInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserNewTabInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserNewTabInput(), typeInfo);
            }
            else if (value.IsBrowserSwitchTabInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserSwitchTabInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserSwitchTabInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserSwitchTabInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserSwitchTabInput(), typeInfo);
            }
            else if (value.IsBrowserCloseTabInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserCloseTabInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserCloseTabInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserCloseTabInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserCloseTabInput(), typeInfo);
            }
            else if (value.IsBrowserReadPageInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserReadPageInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserReadPageInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserReadPageInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserReadPageInput(), typeInfo);
            }
            else if (value.IsBrowserGetPageTextInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserGetPageTextInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserGetPageTextInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserGetPageTextInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserGetPageTextInput(), typeInfo);
            }
            else if (value.IsBrowserReadConsoleInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserReadConsoleInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserReadConsoleInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserReadConsoleInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserReadConsoleInput(), typeInfo);
            }
            else if (value.IsBrowserReadNetworkInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserReadNetworkInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserReadNetworkInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserReadNetworkInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserReadNetworkInput(), typeInfo);
            }
            else if (value.IsBrowserFindInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserFindInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserFindInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserFindInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserFindInput(), typeInfo);
            }
            else if (value.IsBrowserFormInputInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserFormInputInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserFormInputInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserFormInputInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserFormInputInput(), typeInfo);
            }
            else if (value.IsFileUpload)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserFileUploadInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserFileUploadInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserFileUploadInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFileUpload(), typeInfo);
            }
            else if (value.IsBrowserScrollToInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserScrollToInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserScrollToInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserScrollToInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserScrollToInput(), typeInfo);
            }
            else if (value.IsBrowserScreenshotInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserScreenshotInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserScreenshotInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserScreenshotInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserScreenshotInput(), typeInfo);
            }
            else if (value.IsBrowserZoomInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserZoomInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserZoomInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserZoomInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserZoomInput(), typeInfo);
            }
            else if (value.IsBrowserLeftClickInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserLeftClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserLeftClickInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserLeftClickInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserLeftClickInput(), typeInfo);
            }
            else if (value.IsBrowserRightClickInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserRightClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserRightClickInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserRightClickInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserRightClickInput(), typeInfo);
            }
            else if (value.IsBrowserMiddleClickInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserMiddleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserMiddleClickInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserMiddleClickInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserMiddleClickInput(), typeInfo);
            }
            else if (value.IsBrowserDoubleClickInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserDoubleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserDoubleClickInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserDoubleClickInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserDoubleClickInput(), typeInfo);
            }
            else if (value.IsBrowserTripleClickInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserTripleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserTripleClickInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserTripleClickInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserTripleClickInput(), typeInfo);
            }
            else if (value.IsBrowserHoverInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserHoverInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserHoverInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserHoverInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserHoverInput(), typeInfo);
            }
            else if (value.IsBrowserLeftClickDragInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserLeftClickDragInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserLeftClickDragInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserLeftClickDragInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserLeftClickDragInput(), typeInfo);
            }
            else if (value.IsBrowserLeftMouseDownInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserLeftMouseDownInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserLeftMouseDownInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserLeftMouseDownInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserLeftMouseDownInput(), typeInfo);
            }
            else if (value.IsBrowserLeftMouseUpInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserLeftMouseUpInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserLeftMouseUpInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserLeftMouseUpInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserLeftMouseUpInput(), typeInfo);
            }
            else if (value.IsBrowserMouseMoveInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserMouseMoveInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserMouseMoveInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserMouseMoveInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserMouseMoveInput(), typeInfo);
            }
            else if (value.IsBrowserScrollInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserScrollInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserScrollInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserScrollInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserScrollInput(), typeInfo);
            }
            else if (value.IsBrowserTypeInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserTypeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserTypeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserTypeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserTypeInput(), typeInfo);
            }
            else if (value.IsBrowserKeyInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserKeyInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserKeyInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserKeyInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserKeyInput(), typeInfo);
            }
            else if (value.IsBrowserHoldKeyInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserHoldKeyInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserHoldKeyInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserHoldKeyInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserHoldKeyInput(), typeInfo);
            }
            else if (value.IsBrowserWaitInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserWaitInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserWaitInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserWaitInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserWaitInput(), typeInfo);
            }
            else if (value.IsBrowserJavascriptExecInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaBrowserJavascriptExecInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaBrowserJavascriptExecInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaBrowserJavascriptExecInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserJavascriptExecInput(), typeInfo);
            }
        }
    }
}