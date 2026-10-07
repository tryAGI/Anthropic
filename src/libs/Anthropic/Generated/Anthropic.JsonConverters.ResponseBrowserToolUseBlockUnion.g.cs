#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ResponseBrowserToolUseBlockUnionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.ResponseBrowserToolUseBlockUnion>
    {
        /// <inheritdoc />
        public override global::Anthropic.ResponseBrowserToolUseBlockUnion Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.ResponseBrowserNavigateToolUseBlock? navigate = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.Navigate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserNavigateToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserNavigateToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserNavigateToolUseBlock)}");
                navigate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserListTabsToolUseBlock? listTabs = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.ListTabs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserListTabsToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserListTabsToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserListTabsToolUseBlock)}");
                listTabs = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserNewTabToolUseBlock? newTab = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.NewTab)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserNewTabToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserNewTabToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserNewTabToolUseBlock)}");
                newTab = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserSwitchTabToolUseBlock? switchTab = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.SwitchTab)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserSwitchTabToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserSwitchTabToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserSwitchTabToolUseBlock)}");
                switchTab = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserCloseTabToolUseBlock? closeTab = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.CloseTab)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserCloseTabToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserCloseTabToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserCloseTabToolUseBlock)}");
                closeTab = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserReadPageToolUseBlock? readPage = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.ReadPage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserReadPageToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserReadPageToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserReadPageToolUseBlock)}");
                readPage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserGetPageTextToolUseBlock? getPageText = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.GetPageText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserGetPageTextToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserGetPageTextToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserGetPageTextToolUseBlock)}");
                getPageText = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserReadConsoleToolUseBlock? readConsole = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.ReadConsole)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserReadConsoleToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserReadConsoleToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserReadConsoleToolUseBlock)}");
                readConsole = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserReadNetworkToolUseBlock? readNetwork = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.ReadNetwork)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserReadNetworkToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserReadNetworkToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserReadNetworkToolUseBlock)}");
                readNetwork = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserFindToolUseBlock? find = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.Find)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserFindToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserFindToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserFindToolUseBlock)}");
                find = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserFormInputToolUseBlock? formInput = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.FormInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserFormInputToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserFormInputToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserFormInputToolUseBlock)}");
                formInput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserFileUploadToolUseBlock? fileUpload = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.FileUpload)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserFileUploadToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserFileUploadToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserFileUploadToolUseBlock)}");
                fileUpload = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserScrollToToolUseBlock? scrollTo = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.ScrollTo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserScrollToToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserScrollToToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserScrollToToolUseBlock)}");
                scrollTo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserScreenshotToolUseBlock? screenshot = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.Screenshot)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserScreenshotToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserScreenshotToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserScreenshotToolUseBlock)}");
                screenshot = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserZoomToolUseBlock? zoom = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.Zoom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserZoomToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserZoomToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserZoomToolUseBlock)}");
                zoom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserLeftClickToolUseBlock? leftClick = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.LeftClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserLeftClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserLeftClickToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserLeftClickToolUseBlock)}");
                leftClick = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserRightClickToolUseBlock? rightClick = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.RightClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserRightClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserRightClickToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserRightClickToolUseBlock)}");
                rightClick = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserMiddleClickToolUseBlock? middleClick = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.MiddleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserMiddleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserMiddleClickToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserMiddleClickToolUseBlock)}");
                middleClick = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserDoubleClickToolUseBlock? doubleClick = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.DoubleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserDoubleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserDoubleClickToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserDoubleClickToolUseBlock)}");
                doubleClick = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserTripleClickToolUseBlock? tripleClick = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.TripleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserTripleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserTripleClickToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserTripleClickToolUseBlock)}");
                tripleClick = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserHoverToolUseBlock? hover = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.Hover)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserHoverToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserHoverToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserHoverToolUseBlock)}");
                hover = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock? leftClickDrag = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.LeftClickDrag)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock)}");
                leftClickDrag = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock? leftMouseDown = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.LeftMouseDown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock)}");
                leftMouseDown = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock? leftMouseUp = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.LeftMouseUp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock)}");
                leftMouseUp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserMouseMoveToolUseBlock? mouseMove = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.MouseMove)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserMouseMoveToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserMouseMoveToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserMouseMoveToolUseBlock)}");
                mouseMove = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserScrollToolUseBlock? scroll = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.Scroll)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserScrollToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserScrollToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserScrollToolUseBlock)}");
                scroll = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserTypeToolUseBlock? type = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.Type)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserTypeToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserTypeToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserTypeToolUseBlock)}");
                type = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserKeyToolUseBlock? key = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.Key)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserKeyToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserKeyToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserKeyToolUseBlock)}");
                key = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserHoldKeyToolUseBlock? holdKey = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.HoldKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserHoldKeyToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserHoldKeyToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserHoldKeyToolUseBlock)}");
                holdKey = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserWaitToolUseBlock? wait = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.Wait)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserWaitToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserWaitToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserWaitToolUseBlock)}");
                wait = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock? javascriptExec = default;
            if (discriminator?.Name == global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName.JavascriptExec)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock)}");
                javascriptExec = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.ResponseBrowserToolUseBlockUnion(
                discriminator?.Name,
                navigate,

                listTabs,

                newTab,

                switchTab,

                closeTab,

                readPage,

                getPageText,

                readConsole,

                readNetwork,

                find,

                formInput,

                fileUpload,

                scrollTo,

                screenshot,

                zoom,

                leftClick,

                rightClick,

                middleClick,

                doubleClick,

                tripleClick,

                hover,

                leftClickDrag,

                leftMouseDown,

                leftMouseUp,

                mouseMove,

                scroll,

                type,

                key,

                holdKey,

                wait,

                javascriptExec
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.ResponseBrowserToolUseBlockUnion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNavigate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserNavigateToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserNavigateToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserNavigateToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNavigate(), typeInfo);
            }
            else if (value.IsListTabs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserListTabsToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserListTabsToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserListTabsToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickListTabs(), typeInfo);
            }
            else if (value.IsNewTab)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserNewTabToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserNewTabToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserNewTabToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNewTab(), typeInfo);
            }
            else if (value.IsSwitchTab)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserSwitchTabToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserSwitchTabToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserSwitchTabToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSwitchTab(), typeInfo);
            }
            else if (value.IsCloseTab)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserCloseTabToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserCloseTabToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserCloseTabToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCloseTab(), typeInfo);
            }
            else if (value.IsReadPage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserReadPageToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserReadPageToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserReadPageToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickReadPage(), typeInfo);
            }
            else if (value.IsGetPageText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserGetPageTextToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserGetPageTextToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserGetPageTextToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGetPageText(), typeInfo);
            }
            else if (value.IsReadConsole)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserReadConsoleToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserReadConsoleToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserReadConsoleToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickReadConsole(), typeInfo);
            }
            else if (value.IsReadNetwork)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserReadNetworkToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserReadNetworkToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserReadNetworkToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickReadNetwork(), typeInfo);
            }
            else if (value.IsFind)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserFindToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserFindToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserFindToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFind(), typeInfo);
            }
            else if (value.IsFormInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserFormInputToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserFormInputToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserFormInputToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFormInput(), typeInfo);
            }
            else if (value.IsFileUpload)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserFileUploadToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserFileUploadToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserFileUploadToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFileUpload(), typeInfo);
            }
            else if (value.IsScrollTo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserScrollToToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserScrollToToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserScrollToToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickScrollTo(), typeInfo);
            }
            else if (value.IsScreenshot)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserScreenshotToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserScreenshotToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserScreenshotToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickScreenshot(), typeInfo);
            }
            else if (value.IsZoom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserZoomToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserZoomToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserZoomToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickZoom(), typeInfo);
            }
            else if (value.IsLeftClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserLeftClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserLeftClickToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserLeftClickToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLeftClick(), typeInfo);
            }
            else if (value.IsRightClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserRightClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserRightClickToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserRightClickToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRightClick(), typeInfo);
            }
            else if (value.IsMiddleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserMiddleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserMiddleClickToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserMiddleClickToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMiddleClick(), typeInfo);
            }
            else if (value.IsDoubleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserDoubleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserDoubleClickToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserDoubleClickToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDoubleClick(), typeInfo);
            }
            else if (value.IsTripleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserTripleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserTripleClickToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserTripleClickToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTripleClick(), typeInfo);
            }
            else if (value.IsHover)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserHoverToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserHoverToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserHoverToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickHover(), typeInfo);
            }
            else if (value.IsLeftClickDrag)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLeftClickDrag(), typeInfo);
            }
            else if (value.IsLeftMouseDown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLeftMouseDown(), typeInfo);
            }
            else if (value.IsLeftMouseUp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLeftMouseUp(), typeInfo);
            }
            else if (value.IsMouseMove)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserMouseMoveToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserMouseMoveToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserMouseMoveToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMouseMove(), typeInfo);
            }
            else if (value.IsScroll)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserScrollToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserScrollToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserScrollToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickScroll(), typeInfo);
            }
            else if (value.IsType)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserTypeToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserTypeToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserTypeToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickType(), typeInfo);
            }
            else if (value.IsKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserKeyToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserKeyToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserKeyToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKey(), typeInfo);
            }
            else if (value.IsHoldKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserHoldKeyToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserHoldKeyToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserHoldKeyToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickHoldKey(), typeInfo);
            }
            else if (value.IsWait)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserWaitToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserWaitToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserWaitToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWait(), typeInfo);
            }
            else if (value.IsJavascriptExec)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickJavascriptExec(), typeInfo);
            }
        }
    }
}