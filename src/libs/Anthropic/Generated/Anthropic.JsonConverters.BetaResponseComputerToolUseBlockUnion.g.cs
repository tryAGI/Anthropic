#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaResponseComputerToolUseBlockUnionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaResponseComputerToolUseBlockUnion>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaResponseComputerToolUseBlockUnion Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaResponseComputerKeyToolUseBlock? key = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName.Key)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerKeyToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerKeyToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseComputerKeyToolUseBlock)}");
                key = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock? holdKey = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName.HoldKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock)}");
                holdKey = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseComputerTypeToolUseBlock? type = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName.Type)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerTypeToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerTypeToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseComputerTypeToolUseBlock)}");
                type = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock? cursorPosition = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName.CursorPosition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock)}");
                cursorPosition = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock? mouseMove = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName.MouseMove)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock)}");
                mouseMove = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock? leftMouseDown = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName.LeftMouseDown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock)}");
                leftMouseDown = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock? leftMouseUp = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName.LeftMouseUp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock)}");
                leftMouseUp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseComputerLeftClickToolUseBlock? leftClick = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName.LeftClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerLeftClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerLeftClickToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseComputerLeftClickToolUseBlock)}");
                leftClick = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock? leftClickDrag = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName.LeftClickDrag)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock)}");
                leftClickDrag = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseComputerRightClickToolUseBlock? rightClick = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName.RightClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerRightClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerRightClickToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseComputerRightClickToolUseBlock)}");
                rightClick = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock? middleClick = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName.MiddleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock)}");
                middleClick = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock? doubleClick = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName.DoubleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock)}");
                doubleClick = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseComputerTripleClickToolUseBlock? tripleClick = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName.TripleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerTripleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerTripleClickToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseComputerTripleClickToolUseBlock)}");
                tripleClick = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseComputerScrollToolUseBlock? scroll = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName.Scroll)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerScrollToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerScrollToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseComputerScrollToolUseBlock)}");
                scroll = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseComputerWaitToolUseBlock? wait = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName.Wait)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerWaitToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerWaitToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseComputerWaitToolUseBlock)}");
                wait = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseComputerScreenshotToolUseBlock? screenshot = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName.Screenshot)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerScreenshotToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerScreenshotToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseComputerScreenshotToolUseBlock)}");
                screenshot = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseComputerZoomToolUseBlock? zoom = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName.Zoom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerZoomToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerZoomToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseComputerZoomToolUseBlock)}");
                zoom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaResponseComputerToolUseBlockUnion(
                discriminator?.Name,
                key,

                holdKey,

                type,

                cursorPosition,

                mouseMove,

                leftMouseDown,

                leftMouseUp,

                leftClick,

                leftClickDrag,

                rightClick,

                middleClick,

                doubleClick,

                tripleClick,

                scroll,

                wait,

                screenshot,

                zoom
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.BetaResponseComputerToolUseBlockUnion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerKeyToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerKeyToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseComputerKeyToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKey(), typeInfo);
            }
            else if (value.IsHoldKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickHoldKey(), typeInfo);
            }
            else if (value.IsType)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerTypeToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerTypeToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseComputerTypeToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickType(), typeInfo);
            }
            else if (value.IsCursorPosition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCursorPosition(), typeInfo);
            }
            else if (value.IsMouseMove)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMouseMove(), typeInfo);
            }
            else if (value.IsLeftMouseDown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLeftMouseDown(), typeInfo);
            }
            else if (value.IsLeftMouseUp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLeftMouseUp(), typeInfo);
            }
            else if (value.IsLeftClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerLeftClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerLeftClickToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseComputerLeftClickToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLeftClick(), typeInfo);
            }
            else if (value.IsLeftClickDrag)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLeftClickDrag(), typeInfo);
            }
            else if (value.IsRightClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerRightClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerRightClickToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseComputerRightClickToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRightClick(), typeInfo);
            }
            else if (value.IsMiddleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMiddleClick(), typeInfo);
            }
            else if (value.IsDoubleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDoubleClick(), typeInfo);
            }
            else if (value.IsTripleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerTripleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerTripleClickToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseComputerTripleClickToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTripleClick(), typeInfo);
            }
            else if (value.IsScroll)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerScrollToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerScrollToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseComputerScrollToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickScroll(), typeInfo);
            }
            else if (value.IsWait)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerWaitToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerWaitToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseComputerWaitToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWait(), typeInfo);
            }
            else if (value.IsScreenshot)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerScreenshotToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerScreenshotToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseComputerScreenshotToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickScreenshot(), typeInfo);
            }
            else if (value.IsZoom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseComputerZoomToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseComputerZoomToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseComputerZoomToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickZoom(), typeInfo);
            }
        }
    }
}