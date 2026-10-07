#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BrowserMemberInputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BrowserMemberInput>
    {
        /// <inheritdoc />
        public override global::Anthropic.BrowserMemberInput Read(
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

            global::Anthropic.BrowserNavigateInput? browserNavigateInput = default;
            global::Anthropic.BrowserListTabsInput? browserListTabsInput = default;
            global::Anthropic.BrowserNewTabInput? browserNewTabInput = default;
            global::Anthropic.BrowserSwitchTabInput? browserSwitchTabInput = default;
            global::Anthropic.BrowserCloseTabInput? browserCloseTabInput = default;
            global::Anthropic.BrowserReadPageInput? browserReadPageInput = default;
            global::Anthropic.BrowserGetPageTextInput? browserGetPageTextInput = default;
            global::Anthropic.BrowserReadConsoleInput? browserReadConsoleInput = default;
            global::Anthropic.BrowserReadNetworkInput? browserReadNetworkInput = default;
            global::Anthropic.BrowserFindInput? browserFindInput = default;
            global::Anthropic.BrowserFormInputInput? browserFormInputInput = default;
            global::Anthropic.BrowserFileUploadInput? fileUpload = default;
            global::Anthropic.BrowserScrollToInput? browserScrollToInput = default;
            global::Anthropic.BrowserScreenshotInput? browserScreenshotInput = default;
            global::Anthropic.BrowserZoomInput? browserZoomInput = default;
            global::Anthropic.BrowserLeftClickInput? browserLeftClickInput = default;
            global::Anthropic.BrowserRightClickInput? browserRightClickInput = default;
            global::Anthropic.BrowserMiddleClickInput? browserMiddleClickInput = default;
            global::Anthropic.BrowserDoubleClickInput? browserDoubleClickInput = default;
            global::Anthropic.BrowserTripleClickInput? browserTripleClickInput = default;
            global::Anthropic.BrowserHoverInput? browserHoverInput = default;
            global::Anthropic.BrowserLeftClickDragInput? browserLeftClickDragInput = default;
            global::Anthropic.BrowserLeftMouseDownInput? browserLeftMouseDownInput = default;
            global::Anthropic.BrowserLeftMouseUpInput? browserLeftMouseUpInput = default;
            global::Anthropic.BrowserMouseMoveInput? browserMouseMoveInput = default;
            global::Anthropic.BrowserScrollInput? browserScrollInput = default;
            global::Anthropic.BrowserTypeInput? browserTypeInput = default;
            global::Anthropic.BrowserKeyInput? browserKeyInput = default;
            global::Anthropic.BrowserHoldKeyInput? browserHoldKeyInput = default;
            global::Anthropic.BrowserWaitInput? browserWaitInput = default;
            global::Anthropic.BrowserJavascriptExecInput? browserJavascriptExecInput = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserNavigateInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserNavigateInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserNavigateInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserListTabsInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserListTabsInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserListTabsInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserNewTabInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserNewTabInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserNewTabInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserSwitchTabInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserSwitchTabInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserSwitchTabInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserCloseTabInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserCloseTabInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserCloseTabInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserReadPageInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserReadPageInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserReadPageInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserGetPageTextInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserGetPageTextInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserGetPageTextInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserReadConsoleInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserReadConsoleInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserReadConsoleInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserReadNetworkInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserReadNetworkInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserReadNetworkInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserFindInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserFindInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserFindInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserFormInputInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserFormInputInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserFormInputInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserFileUploadInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserFileUploadInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserFileUploadInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserScrollToInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserScrollToInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserScrollToInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserScreenshotInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserScreenshotInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserScreenshotInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserZoomInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserZoomInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserZoomInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserLeftClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserLeftClickInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserLeftClickInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserRightClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserRightClickInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserRightClickInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserMiddleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserMiddleClickInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserMiddleClickInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserDoubleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserDoubleClickInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserDoubleClickInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserTripleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserTripleClickInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserTripleClickInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserHoverInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserHoverInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserHoverInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserLeftClickDragInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserLeftClickDragInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserLeftClickDragInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserLeftMouseDownInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserLeftMouseDownInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserLeftMouseDownInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserLeftMouseUpInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserLeftMouseUpInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserLeftMouseUpInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserMouseMoveInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserMouseMoveInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserMouseMoveInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserScrollInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserScrollInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserScrollInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserTypeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserTypeInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserTypeInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserKeyInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserKeyInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserKeyInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserHoldKeyInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserHoldKeyInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserHoldKeyInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserWaitInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserWaitInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserWaitInput).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserJavascriptExecInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserJavascriptExecInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserJavascriptExecInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserNavigateInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserNavigateInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserNavigateInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserListTabsInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserListTabsInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserListTabsInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserNewTabInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserNewTabInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserNewTabInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserSwitchTabInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserSwitchTabInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserSwitchTabInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserCloseTabInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserCloseTabInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserCloseTabInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserReadPageInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserReadPageInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserReadPageInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserGetPageTextInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserGetPageTextInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserGetPageTextInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserReadConsoleInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserReadConsoleInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserReadConsoleInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserReadNetworkInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserReadNetworkInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserReadNetworkInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserFindInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserFindInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserFindInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserFormInputInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserFormInputInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserFormInputInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserFileUploadInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserFileUploadInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserFileUploadInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserScrollToInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserScrollToInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserScrollToInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserScreenshotInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserScreenshotInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserScreenshotInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserZoomInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserZoomInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserZoomInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserLeftClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserLeftClickInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserLeftClickInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserRightClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserRightClickInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserRightClickInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserMiddleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserMiddleClickInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserMiddleClickInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserDoubleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserDoubleClickInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserDoubleClickInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserTripleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserTripleClickInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserTripleClickInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserHoverInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserHoverInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserHoverInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserLeftClickDragInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserLeftClickDragInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserLeftClickDragInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserLeftMouseDownInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserLeftMouseDownInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserLeftMouseDownInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserLeftMouseUpInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserLeftMouseUpInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserLeftMouseUpInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserMouseMoveInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserMouseMoveInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserMouseMoveInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserScrollInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserScrollInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserScrollInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserTypeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserTypeInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserTypeInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserKeyInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserKeyInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserKeyInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserHoldKeyInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserHoldKeyInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserHoldKeyInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserWaitInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserWaitInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserWaitInput).Name}");
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

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserJavascriptExecInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserJavascriptExecInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserJavascriptExecInput).Name}");
                    browserJavascriptExecInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Anthropic.BrowserMemberInput(
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
            global::Anthropic.BrowserMemberInput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBrowserNavigateInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserNavigateInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserNavigateInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserNavigateInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserNavigateInput(), typeInfo);
            }
            else if (value.IsBrowserListTabsInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserListTabsInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserListTabsInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserListTabsInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserListTabsInput(), typeInfo);
            }
            else if (value.IsBrowserNewTabInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserNewTabInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserNewTabInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserNewTabInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserNewTabInput(), typeInfo);
            }
            else if (value.IsBrowserSwitchTabInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserSwitchTabInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserSwitchTabInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserSwitchTabInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserSwitchTabInput(), typeInfo);
            }
            else if (value.IsBrowserCloseTabInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserCloseTabInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserCloseTabInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserCloseTabInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserCloseTabInput(), typeInfo);
            }
            else if (value.IsBrowserReadPageInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserReadPageInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserReadPageInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserReadPageInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserReadPageInput(), typeInfo);
            }
            else if (value.IsBrowserGetPageTextInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserGetPageTextInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserGetPageTextInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserGetPageTextInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserGetPageTextInput(), typeInfo);
            }
            else if (value.IsBrowserReadConsoleInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserReadConsoleInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserReadConsoleInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserReadConsoleInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserReadConsoleInput(), typeInfo);
            }
            else if (value.IsBrowserReadNetworkInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserReadNetworkInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserReadNetworkInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserReadNetworkInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserReadNetworkInput(), typeInfo);
            }
            else if (value.IsBrowserFindInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserFindInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserFindInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserFindInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserFindInput(), typeInfo);
            }
            else if (value.IsBrowserFormInputInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserFormInputInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserFormInputInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserFormInputInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserFormInputInput(), typeInfo);
            }
            else if (value.IsFileUpload)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserFileUploadInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserFileUploadInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserFileUploadInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFileUpload(), typeInfo);
            }
            else if (value.IsBrowserScrollToInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserScrollToInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserScrollToInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserScrollToInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserScrollToInput(), typeInfo);
            }
            else if (value.IsBrowserScreenshotInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserScreenshotInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserScreenshotInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserScreenshotInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserScreenshotInput(), typeInfo);
            }
            else if (value.IsBrowserZoomInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserZoomInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserZoomInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserZoomInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserZoomInput(), typeInfo);
            }
            else if (value.IsBrowserLeftClickInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserLeftClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserLeftClickInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserLeftClickInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserLeftClickInput(), typeInfo);
            }
            else if (value.IsBrowserRightClickInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserRightClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserRightClickInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserRightClickInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserRightClickInput(), typeInfo);
            }
            else if (value.IsBrowserMiddleClickInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserMiddleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserMiddleClickInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserMiddleClickInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserMiddleClickInput(), typeInfo);
            }
            else if (value.IsBrowserDoubleClickInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserDoubleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserDoubleClickInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserDoubleClickInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserDoubleClickInput(), typeInfo);
            }
            else if (value.IsBrowserTripleClickInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserTripleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserTripleClickInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserTripleClickInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserTripleClickInput(), typeInfo);
            }
            else if (value.IsBrowserHoverInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserHoverInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserHoverInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserHoverInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserHoverInput(), typeInfo);
            }
            else if (value.IsBrowserLeftClickDragInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserLeftClickDragInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserLeftClickDragInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserLeftClickDragInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserLeftClickDragInput(), typeInfo);
            }
            else if (value.IsBrowserLeftMouseDownInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserLeftMouseDownInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserLeftMouseDownInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserLeftMouseDownInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserLeftMouseDownInput(), typeInfo);
            }
            else if (value.IsBrowserLeftMouseUpInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserLeftMouseUpInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserLeftMouseUpInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserLeftMouseUpInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserLeftMouseUpInput(), typeInfo);
            }
            else if (value.IsBrowserMouseMoveInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserMouseMoveInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserMouseMoveInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserMouseMoveInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserMouseMoveInput(), typeInfo);
            }
            else if (value.IsBrowserScrollInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserScrollInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserScrollInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserScrollInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserScrollInput(), typeInfo);
            }
            else if (value.IsBrowserTypeInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserTypeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserTypeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserTypeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserTypeInput(), typeInfo);
            }
            else if (value.IsBrowserKeyInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserKeyInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserKeyInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserKeyInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserKeyInput(), typeInfo);
            }
            else if (value.IsBrowserHoldKeyInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserHoldKeyInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserHoldKeyInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserHoldKeyInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserHoldKeyInput(), typeInfo);
            }
            else if (value.IsBrowserWaitInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserWaitInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserWaitInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserWaitInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserWaitInput(), typeInfo);
            }
            else if (value.IsBrowserJavascriptExecInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BrowserJavascriptExecInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BrowserJavascriptExecInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BrowserJavascriptExecInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserJavascriptExecInput(), typeInfo);
            }
        }
    }
}