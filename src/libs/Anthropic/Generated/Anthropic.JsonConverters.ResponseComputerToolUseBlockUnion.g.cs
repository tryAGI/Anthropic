#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ResponseComputerToolUseBlockUnionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ResponseComputerToolUseBlockUnion>
    {
        /// <inheritdoc />
        public override global::Anthropic.ResponseComputerToolUseBlockUnion Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.ResponseComputerKeyToolUseBlock? key = default;
            if (discriminator?.Name == global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName.Key)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerKeyToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerKeyToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseComputerKeyToolUseBlock)}");
                key = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseComputerHoldKeyToolUseBlock? holdKey = default;
            if (discriminator?.Name == global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName.HoldKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerHoldKeyToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerHoldKeyToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseComputerHoldKeyToolUseBlock)}");
                holdKey = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseComputerTypeToolUseBlock? type = default;
            if (discriminator?.Name == global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName.Type)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerTypeToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerTypeToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseComputerTypeToolUseBlock)}");
                type = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseComputerCursorPositionToolUseBlock? cursorPosition = default;
            if (discriminator?.Name == global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName.CursorPosition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerCursorPositionToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerCursorPositionToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseComputerCursorPositionToolUseBlock)}");
                cursorPosition = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseComputerMouseMoveToolUseBlock? mouseMove = default;
            if (discriminator?.Name == global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName.MouseMove)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerMouseMoveToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerMouseMoveToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseComputerMouseMoveToolUseBlock)}");
                mouseMove = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock? leftMouseDown = default;
            if (discriminator?.Name == global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName.LeftMouseDown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock)}");
                leftMouseDown = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock? leftMouseUp = default;
            if (discriminator?.Name == global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName.LeftMouseUp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock)}");
                leftMouseUp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseComputerLeftClickToolUseBlock? leftClick = default;
            if (discriminator?.Name == global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName.LeftClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerLeftClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerLeftClickToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseComputerLeftClickToolUseBlock)}");
                leftClick = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseComputerLeftClickDragToolUseBlock? leftClickDrag = default;
            if (discriminator?.Name == global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName.LeftClickDrag)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerLeftClickDragToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerLeftClickDragToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseComputerLeftClickDragToolUseBlock)}");
                leftClickDrag = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseComputerRightClickToolUseBlock? rightClick = default;
            if (discriminator?.Name == global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName.RightClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerRightClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerRightClickToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseComputerRightClickToolUseBlock)}");
                rightClick = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseComputerMiddleClickToolUseBlock? middleClick = default;
            if (discriminator?.Name == global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName.MiddleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerMiddleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerMiddleClickToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseComputerMiddleClickToolUseBlock)}");
                middleClick = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseComputerDoubleClickToolUseBlock? doubleClick = default;
            if (discriminator?.Name == global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName.DoubleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerDoubleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerDoubleClickToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseComputerDoubleClickToolUseBlock)}");
                doubleClick = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseComputerTripleClickToolUseBlock? tripleClick = default;
            if (discriminator?.Name == global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName.TripleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerTripleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerTripleClickToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseComputerTripleClickToolUseBlock)}");
                tripleClick = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseComputerScrollToolUseBlock? scroll = default;
            if (discriminator?.Name == global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName.Scroll)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerScrollToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerScrollToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseComputerScrollToolUseBlock)}");
                scroll = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseComputerWaitToolUseBlock? wait = default;
            if (discriminator?.Name == global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName.Wait)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerWaitToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerWaitToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseComputerWaitToolUseBlock)}");
                wait = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseComputerScreenshotToolUseBlock? screenshot = default;
            if (discriminator?.Name == global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName.Screenshot)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerScreenshotToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerScreenshotToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseComputerScreenshotToolUseBlock)}");
                screenshot = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseComputerZoomToolUseBlock? zoom = default;
            if (discriminator?.Name == global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName.Zoom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerZoomToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerZoomToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseComputerZoomToolUseBlock)}");
                zoom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.ResponseComputerToolUseBlockUnion(
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
            global::Anthropic.ResponseComputerToolUseBlockUnion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerKeyToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerKeyToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseComputerKeyToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKey(), typeInfo);
            }
            else if (value.IsHoldKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerHoldKeyToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerHoldKeyToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseComputerHoldKeyToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickHoldKey(), typeInfo);
            }
            else if (value.IsType)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerTypeToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerTypeToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseComputerTypeToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickType(), typeInfo);
            }
            else if (value.IsCursorPosition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerCursorPositionToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerCursorPositionToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseComputerCursorPositionToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCursorPosition(), typeInfo);
            }
            else if (value.IsMouseMove)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerMouseMoveToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerMouseMoveToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseComputerMouseMoveToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMouseMove(), typeInfo);
            }
            else if (value.IsLeftMouseDown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLeftMouseDown(), typeInfo);
            }
            else if (value.IsLeftMouseUp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLeftMouseUp(), typeInfo);
            }
            else if (value.IsLeftClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerLeftClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerLeftClickToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseComputerLeftClickToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLeftClick(), typeInfo);
            }
            else if (value.IsLeftClickDrag)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerLeftClickDragToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerLeftClickDragToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseComputerLeftClickDragToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLeftClickDrag(), typeInfo);
            }
            else if (value.IsRightClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerRightClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerRightClickToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseComputerRightClickToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRightClick(), typeInfo);
            }
            else if (value.IsMiddleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerMiddleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerMiddleClickToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseComputerMiddleClickToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMiddleClick(), typeInfo);
            }
            else if (value.IsDoubleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerDoubleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerDoubleClickToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseComputerDoubleClickToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDoubleClick(), typeInfo);
            }
            else if (value.IsTripleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerTripleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerTripleClickToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseComputerTripleClickToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTripleClick(), typeInfo);
            }
            else if (value.IsScroll)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerScrollToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerScrollToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseComputerScrollToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickScroll(), typeInfo);
            }
            else if (value.IsWait)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerWaitToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerWaitToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseComputerWaitToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWait(), typeInfo);
            }
            else if (value.IsScreenshot)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerScreenshotToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerScreenshotToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseComputerScreenshotToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickScreenshot(), typeInfo);
            }
            else if (value.IsZoom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseComputerZoomToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseComputerZoomToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseComputerZoomToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickZoom(), typeInfo);
            }
        }
    }
}