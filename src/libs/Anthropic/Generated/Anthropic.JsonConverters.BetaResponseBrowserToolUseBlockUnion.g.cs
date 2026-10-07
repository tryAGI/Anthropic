#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class BetaResponseBrowserToolUseBlockUnionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.BetaResponseBrowserToolUseBlockUnion>
    {
        /// <inheritdoc />
        public override global::Anthropic.BetaResponseBrowserToolUseBlockUnion Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaResponseBrowserNavigateToolUseBlock? navigate = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Navigate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserNavigateToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserNavigateToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserNavigateToolUseBlock)}");
                navigate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserListTabsToolUseBlock? listTabs = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.ListTabs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserListTabsToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserListTabsToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserListTabsToolUseBlock)}");
                listTabs = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserNewTabToolUseBlock? newTab = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.NewTab)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserNewTabToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserNewTabToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserNewTabToolUseBlock)}");
                newTab = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock? switchTab = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.SwitchTab)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock)}");
                switchTab = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock? closeTab = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.CloseTab)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock)}");
                closeTab = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserReadPageToolUseBlock? readPage = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.ReadPage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserReadPageToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserReadPageToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserReadPageToolUseBlock)}");
                readPage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock? getPageText = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.GetPageText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock)}");
                getPageText = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock? readConsole = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.ReadConsole)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock)}");
                readConsole = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock? readNetwork = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.ReadNetwork)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock)}");
                readNetwork = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserFindToolUseBlock? find = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Find)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserFindToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserFindToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserFindToolUseBlock)}");
                find = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserFormInputToolUseBlock? formInput = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.FormInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserFormInputToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserFormInputToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserFormInputToolUseBlock)}");
                formInput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock? fileUpload = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.FileUpload)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock)}");
                fileUpload = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserScrollToToolUseBlock? scrollTo = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.ScrollTo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserScrollToToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserScrollToToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserScrollToToolUseBlock)}");
                scrollTo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock? screenshot = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Screenshot)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock)}");
                screenshot = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserZoomToolUseBlock? zoom = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Zoom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserZoomToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserZoomToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserZoomToolUseBlock)}");
                zoom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock? leftClick = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.LeftClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock)}");
                leftClick = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserRightClickToolUseBlock? rightClick = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.RightClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserRightClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserRightClickToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserRightClickToolUseBlock)}");
                rightClick = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock? middleClick = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.MiddleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock)}");
                middleClick = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock? doubleClick = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.DoubleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock)}");
                doubleClick = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock? tripleClick = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.TripleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock)}");
                tripleClick = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserHoverToolUseBlock? hover = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Hover)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserHoverToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserHoverToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserHoverToolUseBlock)}");
                hover = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock? leftClickDrag = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.LeftClickDrag)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock)}");
                leftClickDrag = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock? leftMouseDown = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.LeftMouseDown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock)}");
                leftMouseDown = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock? leftMouseUp = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.LeftMouseUp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock)}");
                leftMouseUp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock? mouseMove = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.MouseMove)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock)}");
                mouseMove = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserScrollToolUseBlock? scroll = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Scroll)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserScrollToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserScrollToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserScrollToolUseBlock)}");
                scroll = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserTypeToolUseBlock? type = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Type)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserTypeToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserTypeToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserTypeToolUseBlock)}");
                type = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserKeyToolUseBlock? key = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Key)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserKeyToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserKeyToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserKeyToolUseBlock)}");
                key = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock? holdKey = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.HoldKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock)}");
                holdKey = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserWaitToolUseBlock? wait = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Wait)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserWaitToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserWaitToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserWaitToolUseBlock)}");
                wait = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock? javascriptExec = default;
            if (discriminator?.Name == global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName.JavascriptExec)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock)}");
                javascriptExec = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.BetaResponseBrowserToolUseBlockUnion(
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
            global::Anthropic.BetaResponseBrowserToolUseBlockUnion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNavigate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserNavigateToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserNavigateToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserNavigateToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNavigate(), typeInfo);
            }
            else if (value.IsListTabs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserListTabsToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserListTabsToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserListTabsToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickListTabs(), typeInfo);
            }
            else if (value.IsNewTab)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserNewTabToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserNewTabToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserNewTabToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNewTab(), typeInfo);
            }
            else if (value.IsSwitchTab)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSwitchTab(), typeInfo);
            }
            else if (value.IsCloseTab)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCloseTab(), typeInfo);
            }
            else if (value.IsReadPage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserReadPageToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserReadPageToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserReadPageToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickReadPage(), typeInfo);
            }
            else if (value.IsGetPageText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGetPageText(), typeInfo);
            }
            else if (value.IsReadConsole)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickReadConsole(), typeInfo);
            }
            else if (value.IsReadNetwork)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickReadNetwork(), typeInfo);
            }
            else if (value.IsFind)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserFindToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserFindToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserFindToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFind(), typeInfo);
            }
            else if (value.IsFormInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserFormInputToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserFormInputToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserFormInputToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFormInput(), typeInfo);
            }
            else if (value.IsFileUpload)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFileUpload(), typeInfo);
            }
            else if (value.IsScrollTo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserScrollToToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserScrollToToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserScrollToToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickScrollTo(), typeInfo);
            }
            else if (value.IsScreenshot)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickScreenshot(), typeInfo);
            }
            else if (value.IsZoom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserZoomToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserZoomToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserZoomToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickZoom(), typeInfo);
            }
            else if (value.IsLeftClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLeftClick(), typeInfo);
            }
            else if (value.IsRightClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserRightClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserRightClickToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserRightClickToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRightClick(), typeInfo);
            }
            else if (value.IsMiddleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMiddleClick(), typeInfo);
            }
            else if (value.IsDoubleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDoubleClick(), typeInfo);
            }
            else if (value.IsTripleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTripleClick(), typeInfo);
            }
            else if (value.IsHover)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserHoverToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserHoverToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserHoverToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickHover(), typeInfo);
            }
            else if (value.IsLeftClickDrag)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLeftClickDrag(), typeInfo);
            }
            else if (value.IsLeftMouseDown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLeftMouseDown(), typeInfo);
            }
            else if (value.IsLeftMouseUp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLeftMouseUp(), typeInfo);
            }
            else if (value.IsMouseMove)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMouseMove(), typeInfo);
            }
            else if (value.IsScroll)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserScrollToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserScrollToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserScrollToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickScroll(), typeInfo);
            }
            else if (value.IsType)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserTypeToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserTypeToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserTypeToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickType(), typeInfo);
            }
            else if (value.IsKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserKeyToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserKeyToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserKeyToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickKey(), typeInfo);
            }
            else if (value.IsHoldKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickHoldKey(), typeInfo);
            }
            else if (value.IsWait)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserWaitToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserWaitToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserWaitToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWait(), typeInfo);
            }
            else if (value.IsJavascriptExec)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickJavascriptExec(), typeInfo);
            }
        }
    }
}