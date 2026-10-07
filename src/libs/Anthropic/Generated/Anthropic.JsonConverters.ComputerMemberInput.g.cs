#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ComputerMemberInputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ComputerMemberInput>
    {
        /// <inheritdoc />
        public override global::Anthropic.ComputerMemberInput Read(
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
            if (__jsonProps.Contains("repeat")) __score0++;
            if (__jsonProps.Contains("text")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("duration")) __score1++;
            if (__jsonProps.Contains("text")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("text")) __score2++;
            var __score3 = 0;
            var __score4 = 0;
            if (__jsonProps.Contains("coordinate")) __score4++;
            var __score5 = 0;
            var __score6 = 0;
            var __score7 = 0;
            if (__jsonProps.Contains("coordinate")) __score7++;
            if (__jsonProps.Contains("text")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("coordinate")) __score8++;
            if (__jsonProps.Contains("start_coordinate")) __score8++;
            if (__jsonProps.Contains("text")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("coordinate")) __score9++;
            if (__jsonProps.Contains("text")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("coordinate")) __score10++;
            if (__jsonProps.Contains("text")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("coordinate")) __score11++;
            if (__jsonProps.Contains("text")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("coordinate")) __score12++;
            if (__jsonProps.Contains("text")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("coordinate")) __score13++;
            if (__jsonProps.Contains("scroll_amount")) __score13++;
            if (__jsonProps.Contains("scroll_direction")) __score13++;
            if (__jsonProps.Contains("text")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("duration")) __score14++;
            var __score15 = 0;
            var __score16 = 0;
            if (__jsonProps.Contains("region")) __score16++;
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

            global::Anthropic.ComputerKeyInput? computerKeyInput = default;
            global::Anthropic.ComputerHoldKeyInput? computerHoldKeyInput = default;
            global::Anthropic.ComputerTypeInput? computerTypeInput = default;
            global::Anthropic.ComputerCursorPositionInput? computerCursorPositionInput = default;
            global::Anthropic.ComputerMouseMoveInput? computerMouseMoveInput = default;
            global::Anthropic.ComputerLeftMouseDownInput? computerLeftMouseDownInput = default;
            global::Anthropic.ComputerLeftMouseUpInput? computerLeftMouseUpInput = default;
            global::Anthropic.ComputerLeftClickInput? computerLeftClickInput = default;
            global::Anthropic.ComputerLeftClickDragInput? computerLeftClickDragInput = default;
            global::Anthropic.ComputerRightClickInput? computerRightClickInput = default;
            global::Anthropic.ComputerMiddleClickInput? computerMiddleClickInput = default;
            global::Anthropic.ComputerDoubleClickInput? computerDoubleClickInput = default;
            global::Anthropic.ComputerTripleClickInput? computerTripleClickInput = default;
            global::Anthropic.ComputerScrollInput? computerScrollInput = default;
            global::Anthropic.ComputerWaitInput? computerWaitInput = default;
            global::Anthropic.ComputerScreenshotInput? computerScreenshotInput = default;
            global::Anthropic.ComputerZoomInput? computerZoomInput = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerKeyInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerKeyInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerKeyInput).Name}");
                        computerKeyInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerHoldKeyInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerHoldKeyInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerHoldKeyInput).Name}");
                        computerHoldKeyInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerTypeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerTypeInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerTypeInput).Name}");
                        computerTypeInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerCursorPositionInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerCursorPositionInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerCursorPositionInput).Name}");
                        computerCursorPositionInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerMouseMoveInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerMouseMoveInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerMouseMoveInput).Name}");
                        computerMouseMoveInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerLeftMouseDownInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerLeftMouseDownInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerLeftMouseDownInput).Name}");
                        computerLeftMouseDownInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerLeftMouseUpInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerLeftMouseUpInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerLeftMouseUpInput).Name}");
                        computerLeftMouseUpInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerLeftClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerLeftClickInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerLeftClickInput).Name}");
                        computerLeftClickInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerLeftClickDragInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerLeftClickDragInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerLeftClickDragInput).Name}");
                        computerLeftClickDragInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerRightClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerRightClickInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerRightClickInput).Name}");
                        computerRightClickInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerMiddleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerMiddleClickInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerMiddleClickInput).Name}");
                        computerMiddleClickInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerDoubleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerDoubleClickInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerDoubleClickInput).Name}");
                        computerDoubleClickInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerTripleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerTripleClickInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerTripleClickInput).Name}");
                        computerTripleClickInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerScrollInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerScrollInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerScrollInput).Name}");
                        computerScrollInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerWaitInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerWaitInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerWaitInput).Name}");
                        computerWaitInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerScreenshotInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerScreenshotInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerScreenshotInput).Name}");
                        computerScreenshotInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerZoomInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerZoomInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerZoomInput).Name}");
                        computerZoomInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (computerKeyInput == null && computerHoldKeyInput == null && computerTypeInput == null && computerCursorPositionInput == null && computerMouseMoveInput == null && computerLeftMouseDownInput == null && computerLeftMouseUpInput == null && computerLeftClickInput == null && computerLeftClickDragInput == null && computerRightClickInput == null && computerMiddleClickInput == null && computerDoubleClickInput == null && computerTripleClickInput == null && computerScrollInput == null && computerWaitInput == null && computerScreenshotInput == null && computerZoomInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerKeyInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerKeyInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerKeyInput).Name}");
                    computerKeyInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (computerKeyInput == null && computerHoldKeyInput == null && computerTypeInput == null && computerCursorPositionInput == null && computerMouseMoveInput == null && computerLeftMouseDownInput == null && computerLeftMouseUpInput == null && computerLeftClickInput == null && computerLeftClickDragInput == null && computerRightClickInput == null && computerMiddleClickInput == null && computerDoubleClickInput == null && computerTripleClickInput == null && computerScrollInput == null && computerWaitInput == null && computerScreenshotInput == null && computerZoomInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerHoldKeyInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerHoldKeyInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerHoldKeyInput).Name}");
                    computerHoldKeyInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (computerKeyInput == null && computerHoldKeyInput == null && computerTypeInput == null && computerCursorPositionInput == null && computerMouseMoveInput == null && computerLeftMouseDownInput == null && computerLeftMouseUpInput == null && computerLeftClickInput == null && computerLeftClickDragInput == null && computerRightClickInput == null && computerMiddleClickInput == null && computerDoubleClickInput == null && computerTripleClickInput == null && computerScrollInput == null && computerWaitInput == null && computerScreenshotInput == null && computerZoomInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerTypeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerTypeInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerTypeInput).Name}");
                    computerTypeInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (computerKeyInput == null && computerHoldKeyInput == null && computerTypeInput == null && computerCursorPositionInput == null && computerMouseMoveInput == null && computerLeftMouseDownInput == null && computerLeftMouseUpInput == null && computerLeftClickInput == null && computerLeftClickDragInput == null && computerRightClickInput == null && computerMiddleClickInput == null && computerDoubleClickInput == null && computerTripleClickInput == null && computerScrollInput == null && computerWaitInput == null && computerScreenshotInput == null && computerZoomInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerCursorPositionInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerCursorPositionInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerCursorPositionInput).Name}");
                    computerCursorPositionInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (computerKeyInput == null && computerHoldKeyInput == null && computerTypeInput == null && computerCursorPositionInput == null && computerMouseMoveInput == null && computerLeftMouseDownInput == null && computerLeftMouseUpInput == null && computerLeftClickInput == null && computerLeftClickDragInput == null && computerRightClickInput == null && computerMiddleClickInput == null && computerDoubleClickInput == null && computerTripleClickInput == null && computerScrollInput == null && computerWaitInput == null && computerScreenshotInput == null && computerZoomInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerMouseMoveInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerMouseMoveInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerMouseMoveInput).Name}");
                    computerMouseMoveInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (computerKeyInput == null && computerHoldKeyInput == null && computerTypeInput == null && computerCursorPositionInput == null && computerMouseMoveInput == null && computerLeftMouseDownInput == null && computerLeftMouseUpInput == null && computerLeftClickInput == null && computerLeftClickDragInput == null && computerRightClickInput == null && computerMiddleClickInput == null && computerDoubleClickInput == null && computerTripleClickInput == null && computerScrollInput == null && computerWaitInput == null && computerScreenshotInput == null && computerZoomInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerLeftMouseDownInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerLeftMouseDownInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerLeftMouseDownInput).Name}");
                    computerLeftMouseDownInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (computerKeyInput == null && computerHoldKeyInput == null && computerTypeInput == null && computerCursorPositionInput == null && computerMouseMoveInput == null && computerLeftMouseDownInput == null && computerLeftMouseUpInput == null && computerLeftClickInput == null && computerLeftClickDragInput == null && computerRightClickInput == null && computerMiddleClickInput == null && computerDoubleClickInput == null && computerTripleClickInput == null && computerScrollInput == null && computerWaitInput == null && computerScreenshotInput == null && computerZoomInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerLeftMouseUpInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerLeftMouseUpInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerLeftMouseUpInput).Name}");
                    computerLeftMouseUpInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (computerKeyInput == null && computerHoldKeyInput == null && computerTypeInput == null && computerCursorPositionInput == null && computerMouseMoveInput == null && computerLeftMouseDownInput == null && computerLeftMouseUpInput == null && computerLeftClickInput == null && computerLeftClickDragInput == null && computerRightClickInput == null && computerMiddleClickInput == null && computerDoubleClickInput == null && computerTripleClickInput == null && computerScrollInput == null && computerWaitInput == null && computerScreenshotInput == null && computerZoomInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerLeftClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerLeftClickInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerLeftClickInput).Name}");
                    computerLeftClickInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (computerKeyInput == null && computerHoldKeyInput == null && computerTypeInput == null && computerCursorPositionInput == null && computerMouseMoveInput == null && computerLeftMouseDownInput == null && computerLeftMouseUpInput == null && computerLeftClickInput == null && computerLeftClickDragInput == null && computerRightClickInput == null && computerMiddleClickInput == null && computerDoubleClickInput == null && computerTripleClickInput == null && computerScrollInput == null && computerWaitInput == null && computerScreenshotInput == null && computerZoomInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerLeftClickDragInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerLeftClickDragInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerLeftClickDragInput).Name}");
                    computerLeftClickDragInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (computerKeyInput == null && computerHoldKeyInput == null && computerTypeInput == null && computerCursorPositionInput == null && computerMouseMoveInput == null && computerLeftMouseDownInput == null && computerLeftMouseUpInput == null && computerLeftClickInput == null && computerLeftClickDragInput == null && computerRightClickInput == null && computerMiddleClickInput == null && computerDoubleClickInput == null && computerTripleClickInput == null && computerScrollInput == null && computerWaitInput == null && computerScreenshotInput == null && computerZoomInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerRightClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerRightClickInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerRightClickInput).Name}");
                    computerRightClickInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (computerKeyInput == null && computerHoldKeyInput == null && computerTypeInput == null && computerCursorPositionInput == null && computerMouseMoveInput == null && computerLeftMouseDownInput == null && computerLeftMouseUpInput == null && computerLeftClickInput == null && computerLeftClickDragInput == null && computerRightClickInput == null && computerMiddleClickInput == null && computerDoubleClickInput == null && computerTripleClickInput == null && computerScrollInput == null && computerWaitInput == null && computerScreenshotInput == null && computerZoomInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerMiddleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerMiddleClickInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerMiddleClickInput).Name}");
                    computerMiddleClickInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (computerKeyInput == null && computerHoldKeyInput == null && computerTypeInput == null && computerCursorPositionInput == null && computerMouseMoveInput == null && computerLeftMouseDownInput == null && computerLeftMouseUpInput == null && computerLeftClickInput == null && computerLeftClickDragInput == null && computerRightClickInput == null && computerMiddleClickInput == null && computerDoubleClickInput == null && computerTripleClickInput == null && computerScrollInput == null && computerWaitInput == null && computerScreenshotInput == null && computerZoomInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerDoubleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerDoubleClickInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerDoubleClickInput).Name}");
                    computerDoubleClickInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (computerKeyInput == null && computerHoldKeyInput == null && computerTypeInput == null && computerCursorPositionInput == null && computerMouseMoveInput == null && computerLeftMouseDownInput == null && computerLeftMouseUpInput == null && computerLeftClickInput == null && computerLeftClickDragInput == null && computerRightClickInput == null && computerMiddleClickInput == null && computerDoubleClickInput == null && computerTripleClickInput == null && computerScrollInput == null && computerWaitInput == null && computerScreenshotInput == null && computerZoomInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerTripleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerTripleClickInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerTripleClickInput).Name}");
                    computerTripleClickInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (computerKeyInput == null && computerHoldKeyInput == null && computerTypeInput == null && computerCursorPositionInput == null && computerMouseMoveInput == null && computerLeftMouseDownInput == null && computerLeftMouseUpInput == null && computerLeftClickInput == null && computerLeftClickDragInput == null && computerRightClickInput == null && computerMiddleClickInput == null && computerDoubleClickInput == null && computerTripleClickInput == null && computerScrollInput == null && computerWaitInput == null && computerScreenshotInput == null && computerZoomInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerScrollInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerScrollInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerScrollInput).Name}");
                    computerScrollInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (computerKeyInput == null && computerHoldKeyInput == null && computerTypeInput == null && computerCursorPositionInput == null && computerMouseMoveInput == null && computerLeftMouseDownInput == null && computerLeftMouseUpInput == null && computerLeftClickInput == null && computerLeftClickDragInput == null && computerRightClickInput == null && computerMiddleClickInput == null && computerDoubleClickInput == null && computerTripleClickInput == null && computerScrollInput == null && computerWaitInput == null && computerScreenshotInput == null && computerZoomInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerWaitInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerWaitInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerWaitInput).Name}");
                    computerWaitInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (computerKeyInput == null && computerHoldKeyInput == null && computerTypeInput == null && computerCursorPositionInput == null && computerMouseMoveInput == null && computerLeftMouseDownInput == null && computerLeftMouseUpInput == null && computerLeftClickInput == null && computerLeftClickDragInput == null && computerRightClickInput == null && computerMiddleClickInput == null && computerDoubleClickInput == null && computerTripleClickInput == null && computerScrollInput == null && computerWaitInput == null && computerScreenshotInput == null && computerZoomInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerScreenshotInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerScreenshotInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerScreenshotInput).Name}");
                    computerScreenshotInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (computerKeyInput == null && computerHoldKeyInput == null && computerTypeInput == null && computerCursorPositionInput == null && computerMouseMoveInput == null && computerLeftMouseDownInput == null && computerLeftMouseUpInput == null && computerLeftClickInput == null && computerLeftClickDragInput == null && computerRightClickInput == null && computerMiddleClickInput == null && computerDoubleClickInput == null && computerTripleClickInput == null && computerScrollInput == null && computerWaitInput == null && computerScreenshotInput == null && computerZoomInput == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerZoomInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerZoomInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerZoomInput).Name}");
                    computerZoomInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Anthropic.ComputerMemberInput(
                computerKeyInput,

                computerHoldKeyInput,

                computerTypeInput,

                computerCursorPositionInput,

                computerMouseMoveInput,

                computerLeftMouseDownInput,

                computerLeftMouseUpInput,

                computerLeftClickInput,

                computerLeftClickDragInput,

                computerRightClickInput,

                computerMiddleClickInput,

                computerDoubleClickInput,

                computerTripleClickInput,

                computerScrollInput,

                computerWaitInput,

                computerScreenshotInput,

                computerZoomInput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ComputerMemberInput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsComputerKeyInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerKeyInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerKeyInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerKeyInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerKeyInput(), typeInfo);
            }
            else if (value.IsComputerHoldKeyInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerHoldKeyInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerHoldKeyInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerHoldKeyInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerHoldKeyInput(), typeInfo);
            }
            else if (value.IsComputerTypeInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerTypeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerTypeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerTypeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerTypeInput(), typeInfo);
            }
            else if (value.IsComputerCursorPositionInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerCursorPositionInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerCursorPositionInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerCursorPositionInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerCursorPositionInput(), typeInfo);
            }
            else if (value.IsComputerMouseMoveInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerMouseMoveInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerMouseMoveInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerMouseMoveInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerMouseMoveInput(), typeInfo);
            }
            else if (value.IsComputerLeftMouseDownInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerLeftMouseDownInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerLeftMouseDownInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerLeftMouseDownInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerLeftMouseDownInput(), typeInfo);
            }
            else if (value.IsComputerLeftMouseUpInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerLeftMouseUpInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerLeftMouseUpInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerLeftMouseUpInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerLeftMouseUpInput(), typeInfo);
            }
            else if (value.IsComputerLeftClickInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerLeftClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerLeftClickInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerLeftClickInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerLeftClickInput(), typeInfo);
            }
            else if (value.IsComputerLeftClickDragInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerLeftClickDragInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerLeftClickDragInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerLeftClickDragInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerLeftClickDragInput(), typeInfo);
            }
            else if (value.IsComputerRightClickInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerRightClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerRightClickInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerRightClickInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerRightClickInput(), typeInfo);
            }
            else if (value.IsComputerMiddleClickInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerMiddleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerMiddleClickInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerMiddleClickInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerMiddleClickInput(), typeInfo);
            }
            else if (value.IsComputerDoubleClickInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerDoubleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerDoubleClickInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerDoubleClickInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerDoubleClickInput(), typeInfo);
            }
            else if (value.IsComputerTripleClickInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerTripleClickInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerTripleClickInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerTripleClickInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerTripleClickInput(), typeInfo);
            }
            else if (value.IsComputerScrollInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerScrollInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerScrollInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerScrollInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerScrollInput(), typeInfo);
            }
            else if (value.IsComputerWaitInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerWaitInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerWaitInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerWaitInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerWaitInput(), typeInfo);
            }
            else if (value.IsComputerScreenshotInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerScreenshotInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerScreenshotInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerScreenshotInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerScreenshotInput(), typeInfo);
            }
            else if (value.IsComputerZoomInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ComputerZoomInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ComputerZoomInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ComputerZoomInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerZoomInput(), typeInfo);
            }
        }
    }
}