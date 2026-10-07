#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ResponseBrowserToolUseBlockUnion : global::System.IEquatable<ResponseBrowserToolUseBlockUnion>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName? Name { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserNavigateToolUseBlock? Navigate { get; init; }
#else
        public global::Anthropic.ResponseBrowserNavigateToolUseBlock? Navigate { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Navigate))]
#endif
        public bool IsNavigate => Navigate != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNavigate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserNavigateToolUseBlock? value)
        {
            value = Navigate;
            return IsNavigate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserNavigateToolUseBlock PickNavigate() => Navigate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Navigate' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserListTabsToolUseBlock? ListTabs { get; init; }
#else
        public global::Anthropic.ResponseBrowserListTabsToolUseBlock? ListTabs { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListTabs))]
#endif
        public bool IsListTabs => ListTabs != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickListTabs(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserListTabsToolUseBlock? value)
        {
            value = ListTabs;
            return IsListTabs;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserListTabsToolUseBlock PickListTabs() => ListTabs is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListTabs' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserNewTabToolUseBlock? NewTab { get; init; }
#else
        public global::Anthropic.ResponseBrowserNewTabToolUseBlock? NewTab { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NewTab))]
#endif
        public bool IsNewTab => NewTab != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNewTab(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserNewTabToolUseBlock? value)
        {
            value = NewTab;
            return IsNewTab;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserNewTabToolUseBlock PickNewTab() => NewTab is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NewTab' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserSwitchTabToolUseBlock? SwitchTab { get; init; }
#else
        public global::Anthropic.ResponseBrowserSwitchTabToolUseBlock? SwitchTab { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SwitchTab))]
#endif
        public bool IsSwitchTab => SwitchTab != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSwitchTab(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserSwitchTabToolUseBlock? value)
        {
            value = SwitchTab;
            return IsSwitchTab;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserSwitchTabToolUseBlock PickSwitchTab() => SwitchTab is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SwitchTab' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserCloseTabToolUseBlock? CloseTab { get; init; }
#else
        public global::Anthropic.ResponseBrowserCloseTabToolUseBlock? CloseTab { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CloseTab))]
#endif
        public bool IsCloseTab => CloseTab != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCloseTab(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserCloseTabToolUseBlock? value)
        {
            value = CloseTab;
            return IsCloseTab;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserCloseTabToolUseBlock PickCloseTab() => CloseTab is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CloseTab' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserReadPageToolUseBlock? ReadPage { get; init; }
#else
        public global::Anthropic.ResponseBrowserReadPageToolUseBlock? ReadPage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReadPage))]
#endif
        public bool IsReadPage => ReadPage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReadPage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserReadPageToolUseBlock? value)
        {
            value = ReadPage;
            return IsReadPage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserReadPageToolUseBlock PickReadPage() => ReadPage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReadPage' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserGetPageTextToolUseBlock? GetPageText { get; init; }
#else
        public global::Anthropic.ResponseBrowserGetPageTextToolUseBlock? GetPageText { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetPageText))]
#endif
        public bool IsGetPageText => GetPageText != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGetPageText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserGetPageTextToolUseBlock? value)
        {
            value = GetPageText;
            return IsGetPageText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserGetPageTextToolUseBlock PickGetPageText() => GetPageText is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GetPageText' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserReadConsoleToolUseBlock? ReadConsole { get; init; }
#else
        public global::Anthropic.ResponseBrowserReadConsoleToolUseBlock? ReadConsole { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReadConsole))]
#endif
        public bool IsReadConsole => ReadConsole != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReadConsole(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserReadConsoleToolUseBlock? value)
        {
            value = ReadConsole;
            return IsReadConsole;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserReadConsoleToolUseBlock PickReadConsole() => ReadConsole is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReadConsole' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserReadNetworkToolUseBlock? ReadNetwork { get; init; }
#else
        public global::Anthropic.ResponseBrowserReadNetworkToolUseBlock? ReadNetwork { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReadNetwork))]
#endif
        public bool IsReadNetwork => ReadNetwork != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReadNetwork(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserReadNetworkToolUseBlock? value)
        {
            value = ReadNetwork;
            return IsReadNetwork;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserReadNetworkToolUseBlock PickReadNetwork() => ReadNetwork is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReadNetwork' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserFindToolUseBlock? Find { get; init; }
#else
        public global::Anthropic.ResponseBrowserFindToolUseBlock? Find { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Find))]
#endif
        public bool IsFind => Find != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFind(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserFindToolUseBlock? value)
        {
            value = Find;
            return IsFind;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserFindToolUseBlock PickFind() => Find is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Find' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserFormInputToolUseBlock? FormInput { get; init; }
#else
        public global::Anthropic.ResponseBrowserFormInputToolUseBlock? FormInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FormInput))]
#endif
        public bool IsFormInput => FormInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFormInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserFormInputToolUseBlock? value)
        {
            value = FormInput;
            return IsFormInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserFormInputToolUseBlock PickFormInput() => FormInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FormInput' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserFileUploadToolUseBlock? FileUpload { get; init; }
#else
        public global::Anthropic.ResponseBrowserFileUploadToolUseBlock? FileUpload { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileUpload))]
#endif
        public bool IsFileUpload => FileUpload != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFileUpload(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserFileUploadToolUseBlock? value)
        {
            value = FileUpload;
            return IsFileUpload;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserFileUploadToolUseBlock PickFileUpload() => FileUpload is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileUpload' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserScrollToToolUseBlock? ScrollTo { get; init; }
#else
        public global::Anthropic.ResponseBrowserScrollToToolUseBlock? ScrollTo { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScrollTo))]
#endif
        public bool IsScrollTo => ScrollTo != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScrollTo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserScrollToToolUseBlock? value)
        {
            value = ScrollTo;
            return IsScrollTo;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserScrollToToolUseBlock PickScrollTo() => ScrollTo is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScrollTo' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserScreenshotToolUseBlock? Screenshot { get; init; }
#else
        public global::Anthropic.ResponseBrowserScreenshotToolUseBlock? Screenshot { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Screenshot))]
#endif
        public bool IsScreenshot => Screenshot != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScreenshot(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserScreenshotToolUseBlock? value)
        {
            value = Screenshot;
            return IsScreenshot;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserScreenshotToolUseBlock PickScreenshot() => Screenshot is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Screenshot' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserZoomToolUseBlock? Zoom { get; init; }
#else
        public global::Anthropic.ResponseBrowserZoomToolUseBlock? Zoom { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Zoom))]
#endif
        public bool IsZoom => Zoom != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickZoom(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserZoomToolUseBlock? value)
        {
            value = Zoom;
            return IsZoom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserZoomToolUseBlock PickZoom() => Zoom is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Zoom' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserLeftClickToolUseBlock? LeftClick { get; init; }
#else
        public global::Anthropic.ResponseBrowserLeftClickToolUseBlock? LeftClick { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LeftClick))]
#endif
        public bool IsLeftClick => LeftClick != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLeftClick(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserLeftClickToolUseBlock? value)
        {
            value = LeftClick;
            return IsLeftClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftClickToolUseBlock PickLeftClick() => LeftClick is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LeftClick' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserRightClickToolUseBlock? RightClick { get; init; }
#else
        public global::Anthropic.ResponseBrowserRightClickToolUseBlock? RightClick { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RightClick))]
#endif
        public bool IsRightClick => RightClick != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRightClick(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserRightClickToolUseBlock? value)
        {
            value = RightClick;
            return IsRightClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserRightClickToolUseBlock PickRightClick() => RightClick is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RightClick' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserMiddleClickToolUseBlock? MiddleClick { get; init; }
#else
        public global::Anthropic.ResponseBrowserMiddleClickToolUseBlock? MiddleClick { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MiddleClick))]
#endif
        public bool IsMiddleClick => MiddleClick != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMiddleClick(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserMiddleClickToolUseBlock? value)
        {
            value = MiddleClick;
            return IsMiddleClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserMiddleClickToolUseBlock PickMiddleClick() => MiddleClick is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MiddleClick' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserDoubleClickToolUseBlock? DoubleClick { get; init; }
#else
        public global::Anthropic.ResponseBrowserDoubleClickToolUseBlock? DoubleClick { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DoubleClick))]
#endif
        public bool IsDoubleClick => DoubleClick != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDoubleClick(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserDoubleClickToolUseBlock? value)
        {
            value = DoubleClick;
            return IsDoubleClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserDoubleClickToolUseBlock PickDoubleClick() => DoubleClick is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DoubleClick' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserTripleClickToolUseBlock? TripleClick { get; init; }
#else
        public global::Anthropic.ResponseBrowserTripleClickToolUseBlock? TripleClick { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TripleClick))]
#endif
        public bool IsTripleClick => TripleClick != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTripleClick(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserTripleClickToolUseBlock? value)
        {
            value = TripleClick;
            return IsTripleClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserTripleClickToolUseBlock PickTripleClick() => TripleClick is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TripleClick' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserHoverToolUseBlock? Hover { get; init; }
#else
        public global::Anthropic.ResponseBrowserHoverToolUseBlock? Hover { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Hover))]
#endif
        public bool IsHover => Hover != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHover(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserHoverToolUseBlock? value)
        {
            value = Hover;
            return IsHover;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserHoverToolUseBlock PickHover() => Hover is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Hover' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock? LeftClickDrag { get; init; }
#else
        public global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock? LeftClickDrag { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LeftClickDrag))]
#endif
        public bool IsLeftClickDrag => LeftClickDrag != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLeftClickDrag(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock? value)
        {
            value = LeftClickDrag;
            return IsLeftClickDrag;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock PickLeftClickDrag() => LeftClickDrag is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LeftClickDrag' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock? LeftMouseDown { get; init; }
#else
        public global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock? LeftMouseDown { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LeftMouseDown))]
#endif
        public bool IsLeftMouseDown => LeftMouseDown != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLeftMouseDown(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock? value)
        {
            value = LeftMouseDown;
            return IsLeftMouseDown;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock PickLeftMouseDown() => LeftMouseDown is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LeftMouseDown' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock? LeftMouseUp { get; init; }
#else
        public global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock? LeftMouseUp { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LeftMouseUp))]
#endif
        public bool IsLeftMouseUp => LeftMouseUp != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLeftMouseUp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock? value)
        {
            value = LeftMouseUp;
            return IsLeftMouseUp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock PickLeftMouseUp() => LeftMouseUp is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LeftMouseUp' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserMouseMoveToolUseBlock? MouseMove { get; init; }
#else
        public global::Anthropic.ResponseBrowserMouseMoveToolUseBlock? MouseMove { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MouseMove))]
#endif
        public bool IsMouseMove => MouseMove != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMouseMove(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserMouseMoveToolUseBlock? value)
        {
            value = MouseMove;
            return IsMouseMove;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserMouseMoveToolUseBlock PickMouseMove() => MouseMove is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MouseMove' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserScrollToolUseBlock? Scroll { get; init; }
#else
        public global::Anthropic.ResponseBrowserScrollToolUseBlock? Scroll { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Scroll))]
#endif
        public bool IsScroll => Scroll != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScroll(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserScrollToolUseBlock? value)
        {
            value = Scroll;
            return IsScroll;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserScrollToolUseBlock PickScroll() => Scroll is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Scroll' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserTypeToolUseBlock? Type { get; init; }
#else
        public global::Anthropic.ResponseBrowserTypeToolUseBlock? Type { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Type))]
#endif
        public bool IsType => Type != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickType(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserTypeToolUseBlock? value)
        {
            value = Type;
            return IsType;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserTypeToolUseBlock PickType() => Type is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Type' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserKeyToolUseBlock? Key { get; init; }
#else
        public global::Anthropic.ResponseBrowserKeyToolUseBlock? Key { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Key))]
#endif
        public bool IsKey => Key != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKey(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserKeyToolUseBlock? value)
        {
            value = Key;
            return IsKey;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserKeyToolUseBlock PickKey() => Key is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Key' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserHoldKeyToolUseBlock? HoldKey { get; init; }
#else
        public global::Anthropic.ResponseBrowserHoldKeyToolUseBlock? HoldKey { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HoldKey))]
#endif
        public bool IsHoldKey => HoldKey != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHoldKey(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserHoldKeyToolUseBlock? value)
        {
            value = HoldKey;
            return IsHoldKey;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserHoldKeyToolUseBlock PickHoldKey() => HoldKey is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HoldKey' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserWaitToolUseBlock? Wait { get; init; }
#else
        public global::Anthropic.ResponseBrowserWaitToolUseBlock? Wait { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Wait))]
#endif
        public bool IsWait => Wait != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWait(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserWaitToolUseBlock? value)
        {
            value = Wait;
            return IsWait;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserWaitToolUseBlock PickWait() => Wait is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Wait' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock? JavascriptExec { get; init; }
#else
        public global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock? JavascriptExec { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JavascriptExec))]
#endif
        public bool IsJavascriptExec => JavascriptExec != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJavascriptExec(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock? value)
        {
            value = JavascriptExec;
            return IsJavascriptExec;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock PickJavascriptExec() => JavascriptExec is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JavascriptExec' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserNavigateToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserNavigateToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserNavigateToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.Navigate;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserNavigateToolUseBlock? value)
        {
            Navigate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromNavigate(global::Anthropic.ResponseBrowserNavigateToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserListTabsToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserListTabsToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserListTabsToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.ListTabs;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserListTabsToolUseBlock? value)
        {
            ListTabs = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromListTabs(global::Anthropic.ResponseBrowserListTabsToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserNewTabToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserNewTabToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserNewTabToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.NewTab;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserNewTabToolUseBlock? value)
        {
            NewTab = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromNewTab(global::Anthropic.ResponseBrowserNewTabToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserSwitchTabToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserSwitchTabToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserSwitchTabToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.SwitchTab;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserSwitchTabToolUseBlock? value)
        {
            SwitchTab = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromSwitchTab(global::Anthropic.ResponseBrowserSwitchTabToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserCloseTabToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserCloseTabToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserCloseTabToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.CloseTab;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserCloseTabToolUseBlock? value)
        {
            CloseTab = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromCloseTab(global::Anthropic.ResponseBrowserCloseTabToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserReadPageToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserReadPageToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserReadPageToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.ReadPage;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserReadPageToolUseBlock? value)
        {
            ReadPage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromReadPage(global::Anthropic.ResponseBrowserReadPageToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserGetPageTextToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserGetPageTextToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserGetPageTextToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.GetPageText;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserGetPageTextToolUseBlock? value)
        {
            GetPageText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromGetPageText(global::Anthropic.ResponseBrowserGetPageTextToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserReadConsoleToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserReadConsoleToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserReadConsoleToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.ReadConsole;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserReadConsoleToolUseBlock? value)
        {
            ReadConsole = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromReadConsole(global::Anthropic.ResponseBrowserReadConsoleToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserReadNetworkToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserReadNetworkToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserReadNetworkToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.ReadNetwork;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserReadNetworkToolUseBlock? value)
        {
            ReadNetwork = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromReadNetwork(global::Anthropic.ResponseBrowserReadNetworkToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserFindToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserFindToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserFindToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.Find;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserFindToolUseBlock? value)
        {
            Find = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromFind(global::Anthropic.ResponseBrowserFindToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserFormInputToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserFormInputToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserFormInputToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.FormInput;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserFormInputToolUseBlock? value)
        {
            FormInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromFormInput(global::Anthropic.ResponseBrowserFormInputToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserFileUploadToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserFileUploadToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserFileUploadToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.FileUpload;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserFileUploadToolUseBlock? value)
        {
            FileUpload = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromFileUpload(global::Anthropic.ResponseBrowserFileUploadToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserScrollToToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserScrollToToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserScrollToToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.ScrollTo;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserScrollToToolUseBlock? value)
        {
            ScrollTo = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromScrollTo(global::Anthropic.ResponseBrowserScrollToToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserScreenshotToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserScreenshotToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserScreenshotToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.Screenshot;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserScreenshotToolUseBlock? value)
        {
            Screenshot = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromScreenshot(global::Anthropic.ResponseBrowserScreenshotToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserZoomToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserZoomToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserZoomToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.Zoom;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserZoomToolUseBlock? value)
        {
            Zoom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromZoom(global::Anthropic.ResponseBrowserZoomToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserLeftClickToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserLeftClickToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserLeftClickToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.LeftClick;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserLeftClickToolUseBlock? value)
        {
            LeftClick = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromLeftClick(global::Anthropic.ResponseBrowserLeftClickToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserRightClickToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserRightClickToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserRightClickToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.RightClick;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserRightClickToolUseBlock? value)
        {
            RightClick = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromRightClick(global::Anthropic.ResponseBrowserRightClickToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserMiddleClickToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserMiddleClickToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserMiddleClickToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.MiddleClick;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserMiddleClickToolUseBlock? value)
        {
            MiddleClick = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromMiddleClick(global::Anthropic.ResponseBrowserMiddleClickToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserDoubleClickToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserDoubleClickToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserDoubleClickToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.DoubleClick;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserDoubleClickToolUseBlock? value)
        {
            DoubleClick = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromDoubleClick(global::Anthropic.ResponseBrowserDoubleClickToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserTripleClickToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserTripleClickToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserTripleClickToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.TripleClick;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserTripleClickToolUseBlock? value)
        {
            TripleClick = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromTripleClick(global::Anthropic.ResponseBrowserTripleClickToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserHoverToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserHoverToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserHoverToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.Hover;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserHoverToolUseBlock? value)
        {
            Hover = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromHover(global::Anthropic.ResponseBrowserHoverToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.LeftClickDrag;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock? value)
        {
            LeftClickDrag = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromLeftClickDrag(global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.LeftMouseDown;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock? value)
        {
            LeftMouseDown = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromLeftMouseDown(global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.LeftMouseUp;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock? value)
        {
            LeftMouseUp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromLeftMouseUp(global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserMouseMoveToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserMouseMoveToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserMouseMoveToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.MouseMove;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserMouseMoveToolUseBlock? value)
        {
            MouseMove = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromMouseMove(global::Anthropic.ResponseBrowserMouseMoveToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserScrollToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserScrollToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserScrollToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.Scroll;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserScrollToolUseBlock? value)
        {
            Scroll = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromScroll(global::Anthropic.ResponseBrowserScrollToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserTypeToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserTypeToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserTypeToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.Type;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserTypeToolUseBlock? value)
        {
            Type = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromType(global::Anthropic.ResponseBrowserTypeToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserKeyToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserKeyToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserKeyToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.Key;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserKeyToolUseBlock? value)
        {
            Key = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromKey(global::Anthropic.ResponseBrowserKeyToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserHoldKeyToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserHoldKeyToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserHoldKeyToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.HoldKey;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserHoldKeyToolUseBlock? value)
        {
            HoldKey = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromHoldKey(global::Anthropic.ResponseBrowserHoldKeyToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserWaitToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserWaitToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserWaitToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.Wait;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserWaitToolUseBlock? value)
        {
            Wait = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromWait(global::Anthropic.ResponseBrowserWaitToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock value) => new ResponseBrowserToolUseBlockUnion((global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock?(ResponseBrowserToolUseBlockUnion @this) => @this.JavascriptExec;

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock? value)
        {
            JavascriptExec = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseBrowserToolUseBlockUnion FromJavascriptExec(global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock? value) => new ResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public ResponseBrowserToolUseBlockUnion(
            global::Anthropic.ResponseBrowserToolUseBlockUnionDiscriminatorName? name,
            global::Anthropic.ResponseBrowserNavigateToolUseBlock? navigate,
            global::Anthropic.ResponseBrowserListTabsToolUseBlock? listTabs,
            global::Anthropic.ResponseBrowserNewTabToolUseBlock? newTab,
            global::Anthropic.ResponseBrowserSwitchTabToolUseBlock? switchTab,
            global::Anthropic.ResponseBrowserCloseTabToolUseBlock? closeTab,
            global::Anthropic.ResponseBrowserReadPageToolUseBlock? readPage,
            global::Anthropic.ResponseBrowserGetPageTextToolUseBlock? getPageText,
            global::Anthropic.ResponseBrowserReadConsoleToolUseBlock? readConsole,
            global::Anthropic.ResponseBrowserReadNetworkToolUseBlock? readNetwork,
            global::Anthropic.ResponseBrowserFindToolUseBlock? find,
            global::Anthropic.ResponseBrowserFormInputToolUseBlock? formInput,
            global::Anthropic.ResponseBrowserFileUploadToolUseBlock? fileUpload,
            global::Anthropic.ResponseBrowserScrollToToolUseBlock? scrollTo,
            global::Anthropic.ResponseBrowserScreenshotToolUseBlock? screenshot,
            global::Anthropic.ResponseBrowserZoomToolUseBlock? zoom,
            global::Anthropic.ResponseBrowserLeftClickToolUseBlock? leftClick,
            global::Anthropic.ResponseBrowserRightClickToolUseBlock? rightClick,
            global::Anthropic.ResponseBrowserMiddleClickToolUseBlock? middleClick,
            global::Anthropic.ResponseBrowserDoubleClickToolUseBlock? doubleClick,
            global::Anthropic.ResponseBrowserTripleClickToolUseBlock? tripleClick,
            global::Anthropic.ResponseBrowserHoverToolUseBlock? hover,
            global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock? leftClickDrag,
            global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock? leftMouseDown,
            global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock? leftMouseUp,
            global::Anthropic.ResponseBrowserMouseMoveToolUseBlock? mouseMove,
            global::Anthropic.ResponseBrowserScrollToolUseBlock? scroll,
            global::Anthropic.ResponseBrowserTypeToolUseBlock? type,
            global::Anthropic.ResponseBrowserKeyToolUseBlock? key,
            global::Anthropic.ResponseBrowserHoldKeyToolUseBlock? holdKey,
            global::Anthropic.ResponseBrowserWaitToolUseBlock? wait,
            global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock? javascriptExec
            )
        {
            Name = name;

            Navigate = navigate;
            ListTabs = listTabs;
            NewTab = newTab;
            SwitchTab = switchTab;
            CloseTab = closeTab;
            ReadPage = readPage;
            GetPageText = getPageText;
            ReadConsole = readConsole;
            ReadNetwork = readNetwork;
            Find = find;
            FormInput = formInput;
            FileUpload = fileUpload;
            ScrollTo = scrollTo;
            Screenshot = screenshot;
            Zoom = zoom;
            LeftClick = leftClick;
            RightClick = rightClick;
            MiddleClick = middleClick;
            DoubleClick = doubleClick;
            TripleClick = tripleClick;
            Hover = hover;
            LeftClickDrag = leftClickDrag;
            LeftMouseDown = leftMouseDown;
            LeftMouseUp = leftMouseUp;
            MouseMove = mouseMove;
            Scroll = scroll;
            Type = type;
            Key = key;
            HoldKey = holdKey;
            Wait = wait;
            JavascriptExec = javascriptExec;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            JavascriptExec as object ??
            Wait as object ??
            HoldKey as object ??
            Key as object ??
            Type as object ??
            Scroll as object ??
            MouseMove as object ??
            LeftMouseUp as object ??
            LeftMouseDown as object ??
            LeftClickDrag as object ??
            Hover as object ??
            TripleClick as object ??
            DoubleClick as object ??
            MiddleClick as object ??
            RightClick as object ??
            LeftClick as object ??
            Zoom as object ??
            Screenshot as object ??
            ScrollTo as object ??
            FileUpload as object ??
            FormInput as object ??
            Find as object ??
            ReadNetwork as object ??
            ReadConsole as object ??
            GetPageText as object ??
            ReadPage as object ??
            CloseTab as object ??
            SwitchTab as object ??
            NewTab as object ??
            ListTabs as object ??
            Navigate as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Navigate?.ToString() ??
            ListTabs?.ToString() ??
            NewTab?.ToString() ??
            SwitchTab?.ToString() ??
            CloseTab?.ToString() ??
            ReadPage?.ToString() ??
            GetPageText?.ToString() ??
            ReadConsole?.ToString() ??
            ReadNetwork?.ToString() ??
            Find?.ToString() ??
            FormInput?.ToString() ??
            FileUpload?.ToString() ??
            ScrollTo?.ToString() ??
            Screenshot?.ToString() ??
            Zoom?.ToString() ??
            LeftClick?.ToString() ??
            RightClick?.ToString() ??
            MiddleClick?.ToString() ??
            DoubleClick?.ToString() ??
            TripleClick?.ToString() ??
            Hover?.ToString() ??
            LeftClickDrag?.ToString() ??
            LeftMouseDown?.ToString() ??
            LeftMouseUp?.ToString() ??
            MouseMove?.ToString() ??
            Scroll?.ToString() ??
            Type?.ToString() ??
            Key?.ToString() ??
            HoldKey?.ToString() ??
            Wait?.ToString() ??
            JavascriptExec?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && IsType && !IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && IsKey && !IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && IsHoldKey && !IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && IsWait && !IsJavascriptExec || !IsNavigate && !IsListTabs && !IsNewTab && !IsSwitchTab && !IsCloseTab && !IsReadPage && !IsGetPageText && !IsReadConsole && !IsReadNetwork && !IsFind && !IsFormInput && !IsFileUpload && !IsScrollTo && !IsScreenshot && !IsZoom && !IsLeftClick && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsHover && !IsLeftClickDrag && !IsLeftMouseDown && !IsLeftMouseUp && !IsMouseMove && !IsScroll && !IsType && !IsKey && !IsHoldKey && !IsWait && IsJavascriptExec;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.ResponseBrowserNavigateToolUseBlock, TResult>? navigate = null,
            global::System.Func<global::Anthropic.ResponseBrowserListTabsToolUseBlock, TResult>? listTabs = null,
            global::System.Func<global::Anthropic.ResponseBrowserNewTabToolUseBlock, TResult>? newTab = null,
            global::System.Func<global::Anthropic.ResponseBrowserSwitchTabToolUseBlock, TResult>? switchTab = null,
            global::System.Func<global::Anthropic.ResponseBrowserCloseTabToolUseBlock, TResult>? closeTab = null,
            global::System.Func<global::Anthropic.ResponseBrowserReadPageToolUseBlock, TResult>? readPage = null,
            global::System.Func<global::Anthropic.ResponseBrowserGetPageTextToolUseBlock, TResult>? getPageText = null,
            global::System.Func<global::Anthropic.ResponseBrowserReadConsoleToolUseBlock, TResult>? readConsole = null,
            global::System.Func<global::Anthropic.ResponseBrowserReadNetworkToolUseBlock, TResult>? readNetwork = null,
            global::System.Func<global::Anthropic.ResponseBrowserFindToolUseBlock, TResult>? find = null,
            global::System.Func<global::Anthropic.ResponseBrowserFormInputToolUseBlock, TResult>? formInput = null,
            global::System.Func<global::Anthropic.ResponseBrowserFileUploadToolUseBlock, TResult>? fileUpload = null,
            global::System.Func<global::Anthropic.ResponseBrowserScrollToToolUseBlock, TResult>? scrollTo = null,
            global::System.Func<global::Anthropic.ResponseBrowserScreenshotToolUseBlock, TResult>? screenshot = null,
            global::System.Func<global::Anthropic.ResponseBrowserZoomToolUseBlock, TResult>? zoom = null,
            global::System.Func<global::Anthropic.ResponseBrowserLeftClickToolUseBlock, TResult>? leftClick = null,
            global::System.Func<global::Anthropic.ResponseBrowserRightClickToolUseBlock, TResult>? rightClick = null,
            global::System.Func<global::Anthropic.ResponseBrowserMiddleClickToolUseBlock, TResult>? middleClick = null,
            global::System.Func<global::Anthropic.ResponseBrowserDoubleClickToolUseBlock, TResult>? doubleClick = null,
            global::System.Func<global::Anthropic.ResponseBrowserTripleClickToolUseBlock, TResult>? tripleClick = null,
            global::System.Func<global::Anthropic.ResponseBrowserHoverToolUseBlock, TResult>? hover = null,
            global::System.Func<global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock, TResult>? leftClickDrag = null,
            global::System.Func<global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock, TResult>? leftMouseDown = null,
            global::System.Func<global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock, TResult>? leftMouseUp = null,
            global::System.Func<global::Anthropic.ResponseBrowserMouseMoveToolUseBlock, TResult>? mouseMove = null,
            global::System.Func<global::Anthropic.ResponseBrowserScrollToolUseBlock, TResult>? scroll = null,
            global::System.Func<global::Anthropic.ResponseBrowserTypeToolUseBlock, TResult>? type = null,
            global::System.Func<global::Anthropic.ResponseBrowserKeyToolUseBlock, TResult>? key = null,
            global::System.Func<global::Anthropic.ResponseBrowserHoldKeyToolUseBlock, TResult>? holdKey = null,
            global::System.Func<global::Anthropic.ResponseBrowserWaitToolUseBlock, TResult>? wait = null,
            global::System.Func<global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock, TResult>? javascriptExec = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Navigate is { } __value0 && navigate != null)
            {
                return navigate(__value0);
            }
            else if (ListTabs is { } __value1 && listTabs != null)
            {
                return listTabs(__value1);
            }
            else if (NewTab is { } __value2 && newTab != null)
            {
                return newTab(__value2);
            }
            else if (SwitchTab is { } __value3 && switchTab != null)
            {
                return switchTab(__value3);
            }
            else if (CloseTab is { } __value4 && closeTab != null)
            {
                return closeTab(__value4);
            }
            else if (ReadPage is { } __value5 && readPage != null)
            {
                return readPage(__value5);
            }
            else if (GetPageText is { } __value6 && getPageText != null)
            {
                return getPageText(__value6);
            }
            else if (ReadConsole is { } __value7 && readConsole != null)
            {
                return readConsole(__value7);
            }
            else if (ReadNetwork is { } __value8 && readNetwork != null)
            {
                return readNetwork(__value8);
            }
            else if (Find is { } __value9 && find != null)
            {
                return find(__value9);
            }
            else if (FormInput is { } __value10 && formInput != null)
            {
                return formInput(__value10);
            }
            else if (FileUpload is { } __value11 && fileUpload != null)
            {
                return fileUpload(__value11);
            }
            else if (ScrollTo is { } __value12 && scrollTo != null)
            {
                return scrollTo(__value12);
            }
            else if (Screenshot is { } __value13 && screenshot != null)
            {
                return screenshot(__value13);
            }
            else if (Zoom is { } __value14 && zoom != null)
            {
                return zoom(__value14);
            }
            else if (LeftClick is { } __value15 && leftClick != null)
            {
                return leftClick(__value15);
            }
            else if (RightClick is { } __value16 && rightClick != null)
            {
                return rightClick(__value16);
            }
            else if (MiddleClick is { } __value17 && middleClick != null)
            {
                return middleClick(__value17);
            }
            else if (DoubleClick is { } __value18 && doubleClick != null)
            {
                return doubleClick(__value18);
            }
            else if (TripleClick is { } __value19 && tripleClick != null)
            {
                return tripleClick(__value19);
            }
            else if (Hover is { } __value20 && hover != null)
            {
                return hover(__value20);
            }
            else if (LeftClickDrag is { } __value21 && leftClickDrag != null)
            {
                return leftClickDrag(__value21);
            }
            else if (LeftMouseDown is { } __value22 && leftMouseDown != null)
            {
                return leftMouseDown(__value22);
            }
            else if (LeftMouseUp is { } __value23 && leftMouseUp != null)
            {
                return leftMouseUp(__value23);
            }
            else if (MouseMove is { } __value24 && mouseMove != null)
            {
                return mouseMove(__value24);
            }
            else if (Scroll is { } __value25 && scroll != null)
            {
                return scroll(__value25);
            }
            else if (Type is { } __value26 && type != null)
            {
                return type(__value26);
            }
            else if (Key is { } __value27 && key != null)
            {
                return key(__value27);
            }
            else if (HoldKey is { } __value28 && holdKey != null)
            {
                return holdKey(__value28);
            }
            else if (Wait is { } __value29 && wait != null)
            {
                return wait(__value29);
            }
            else if (JavascriptExec is { } __value30 && javascriptExec != null)
            {
                return javascriptExec(__value30);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.ResponseBrowserNavigateToolUseBlock>? navigate = null,

            global::System.Action<global::Anthropic.ResponseBrowserListTabsToolUseBlock>? listTabs = null,

            global::System.Action<global::Anthropic.ResponseBrowserNewTabToolUseBlock>? newTab = null,

            global::System.Action<global::Anthropic.ResponseBrowserSwitchTabToolUseBlock>? switchTab = null,

            global::System.Action<global::Anthropic.ResponseBrowserCloseTabToolUseBlock>? closeTab = null,

            global::System.Action<global::Anthropic.ResponseBrowserReadPageToolUseBlock>? readPage = null,

            global::System.Action<global::Anthropic.ResponseBrowserGetPageTextToolUseBlock>? getPageText = null,

            global::System.Action<global::Anthropic.ResponseBrowserReadConsoleToolUseBlock>? readConsole = null,

            global::System.Action<global::Anthropic.ResponseBrowserReadNetworkToolUseBlock>? readNetwork = null,

            global::System.Action<global::Anthropic.ResponseBrowserFindToolUseBlock>? find = null,

            global::System.Action<global::Anthropic.ResponseBrowserFormInputToolUseBlock>? formInput = null,

            global::System.Action<global::Anthropic.ResponseBrowserFileUploadToolUseBlock>? fileUpload = null,

            global::System.Action<global::Anthropic.ResponseBrowserScrollToToolUseBlock>? scrollTo = null,

            global::System.Action<global::Anthropic.ResponseBrowserScreenshotToolUseBlock>? screenshot = null,

            global::System.Action<global::Anthropic.ResponseBrowserZoomToolUseBlock>? zoom = null,

            global::System.Action<global::Anthropic.ResponseBrowserLeftClickToolUseBlock>? leftClick = null,

            global::System.Action<global::Anthropic.ResponseBrowserRightClickToolUseBlock>? rightClick = null,

            global::System.Action<global::Anthropic.ResponseBrowserMiddleClickToolUseBlock>? middleClick = null,

            global::System.Action<global::Anthropic.ResponseBrowserDoubleClickToolUseBlock>? doubleClick = null,

            global::System.Action<global::Anthropic.ResponseBrowserTripleClickToolUseBlock>? tripleClick = null,

            global::System.Action<global::Anthropic.ResponseBrowserHoverToolUseBlock>? hover = null,

            global::System.Action<global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock>? leftClickDrag = null,

            global::System.Action<global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock>? leftMouseDown = null,

            global::System.Action<global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock>? leftMouseUp = null,

            global::System.Action<global::Anthropic.ResponseBrowserMouseMoveToolUseBlock>? mouseMove = null,

            global::System.Action<global::Anthropic.ResponseBrowserScrollToolUseBlock>? scroll = null,

            global::System.Action<global::Anthropic.ResponseBrowserTypeToolUseBlock>? type = null,

            global::System.Action<global::Anthropic.ResponseBrowserKeyToolUseBlock>? key = null,

            global::System.Action<global::Anthropic.ResponseBrowserHoldKeyToolUseBlock>? holdKey = null,

            global::System.Action<global::Anthropic.ResponseBrowserWaitToolUseBlock>? wait = null,

            global::System.Action<global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock>? javascriptExec = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Navigate is { } __value0)
            {
                navigate?.Invoke(__value0);
            }
            else if (ListTabs is { } __value1)
            {
                listTabs?.Invoke(__value1);
            }
            else if (NewTab is { } __value2)
            {
                newTab?.Invoke(__value2);
            }
            else if (SwitchTab is { } __value3)
            {
                switchTab?.Invoke(__value3);
            }
            else if (CloseTab is { } __value4)
            {
                closeTab?.Invoke(__value4);
            }
            else if (ReadPage is { } __value5)
            {
                readPage?.Invoke(__value5);
            }
            else if (GetPageText is { } __value6)
            {
                getPageText?.Invoke(__value6);
            }
            else if (ReadConsole is { } __value7)
            {
                readConsole?.Invoke(__value7);
            }
            else if (ReadNetwork is { } __value8)
            {
                readNetwork?.Invoke(__value8);
            }
            else if (Find is { } __value9)
            {
                find?.Invoke(__value9);
            }
            else if (FormInput is { } __value10)
            {
                formInput?.Invoke(__value10);
            }
            else if (FileUpload is { } __value11)
            {
                fileUpload?.Invoke(__value11);
            }
            else if (ScrollTo is { } __value12)
            {
                scrollTo?.Invoke(__value12);
            }
            else if (Screenshot is { } __value13)
            {
                screenshot?.Invoke(__value13);
            }
            else if (Zoom is { } __value14)
            {
                zoom?.Invoke(__value14);
            }
            else if (LeftClick is { } __value15)
            {
                leftClick?.Invoke(__value15);
            }
            else if (RightClick is { } __value16)
            {
                rightClick?.Invoke(__value16);
            }
            else if (MiddleClick is { } __value17)
            {
                middleClick?.Invoke(__value17);
            }
            else if (DoubleClick is { } __value18)
            {
                doubleClick?.Invoke(__value18);
            }
            else if (TripleClick is { } __value19)
            {
                tripleClick?.Invoke(__value19);
            }
            else if (Hover is { } __value20)
            {
                hover?.Invoke(__value20);
            }
            else if (LeftClickDrag is { } __value21)
            {
                leftClickDrag?.Invoke(__value21);
            }
            else if (LeftMouseDown is { } __value22)
            {
                leftMouseDown?.Invoke(__value22);
            }
            else if (LeftMouseUp is { } __value23)
            {
                leftMouseUp?.Invoke(__value23);
            }
            else if (MouseMove is { } __value24)
            {
                mouseMove?.Invoke(__value24);
            }
            else if (Scroll is { } __value25)
            {
                scroll?.Invoke(__value25);
            }
            else if (Type is { } __value26)
            {
                type?.Invoke(__value26);
            }
            else if (Key is { } __value27)
            {
                key?.Invoke(__value27);
            }
            else if (HoldKey is { } __value28)
            {
                holdKey?.Invoke(__value28);
            }
            else if (Wait is { } __value29)
            {
                wait?.Invoke(__value29);
            }
            else if (JavascriptExec is { } __value30)
            {
                javascriptExec?.Invoke(__value30);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.ResponseBrowserNavigateToolUseBlock>? navigate = null,
            global::System.Action<global::Anthropic.ResponseBrowserListTabsToolUseBlock>? listTabs = null,
            global::System.Action<global::Anthropic.ResponseBrowserNewTabToolUseBlock>? newTab = null,
            global::System.Action<global::Anthropic.ResponseBrowserSwitchTabToolUseBlock>? switchTab = null,
            global::System.Action<global::Anthropic.ResponseBrowserCloseTabToolUseBlock>? closeTab = null,
            global::System.Action<global::Anthropic.ResponseBrowserReadPageToolUseBlock>? readPage = null,
            global::System.Action<global::Anthropic.ResponseBrowserGetPageTextToolUseBlock>? getPageText = null,
            global::System.Action<global::Anthropic.ResponseBrowserReadConsoleToolUseBlock>? readConsole = null,
            global::System.Action<global::Anthropic.ResponseBrowserReadNetworkToolUseBlock>? readNetwork = null,
            global::System.Action<global::Anthropic.ResponseBrowserFindToolUseBlock>? find = null,
            global::System.Action<global::Anthropic.ResponseBrowserFormInputToolUseBlock>? formInput = null,
            global::System.Action<global::Anthropic.ResponseBrowserFileUploadToolUseBlock>? fileUpload = null,
            global::System.Action<global::Anthropic.ResponseBrowserScrollToToolUseBlock>? scrollTo = null,
            global::System.Action<global::Anthropic.ResponseBrowserScreenshotToolUseBlock>? screenshot = null,
            global::System.Action<global::Anthropic.ResponseBrowserZoomToolUseBlock>? zoom = null,
            global::System.Action<global::Anthropic.ResponseBrowserLeftClickToolUseBlock>? leftClick = null,
            global::System.Action<global::Anthropic.ResponseBrowserRightClickToolUseBlock>? rightClick = null,
            global::System.Action<global::Anthropic.ResponseBrowserMiddleClickToolUseBlock>? middleClick = null,
            global::System.Action<global::Anthropic.ResponseBrowserDoubleClickToolUseBlock>? doubleClick = null,
            global::System.Action<global::Anthropic.ResponseBrowserTripleClickToolUseBlock>? tripleClick = null,
            global::System.Action<global::Anthropic.ResponseBrowserHoverToolUseBlock>? hover = null,
            global::System.Action<global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock>? leftClickDrag = null,
            global::System.Action<global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock>? leftMouseDown = null,
            global::System.Action<global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock>? leftMouseUp = null,
            global::System.Action<global::Anthropic.ResponseBrowserMouseMoveToolUseBlock>? mouseMove = null,
            global::System.Action<global::Anthropic.ResponseBrowserScrollToolUseBlock>? scroll = null,
            global::System.Action<global::Anthropic.ResponseBrowserTypeToolUseBlock>? type = null,
            global::System.Action<global::Anthropic.ResponseBrowserKeyToolUseBlock>? key = null,
            global::System.Action<global::Anthropic.ResponseBrowserHoldKeyToolUseBlock>? holdKey = null,
            global::System.Action<global::Anthropic.ResponseBrowserWaitToolUseBlock>? wait = null,
            global::System.Action<global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock>? javascriptExec = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Navigate is { } __value0)
            {
                navigate?.Invoke(__value0);
            }
            else if (ListTabs is { } __value1)
            {
                listTabs?.Invoke(__value1);
            }
            else if (NewTab is { } __value2)
            {
                newTab?.Invoke(__value2);
            }
            else if (SwitchTab is { } __value3)
            {
                switchTab?.Invoke(__value3);
            }
            else if (CloseTab is { } __value4)
            {
                closeTab?.Invoke(__value4);
            }
            else if (ReadPage is { } __value5)
            {
                readPage?.Invoke(__value5);
            }
            else if (GetPageText is { } __value6)
            {
                getPageText?.Invoke(__value6);
            }
            else if (ReadConsole is { } __value7)
            {
                readConsole?.Invoke(__value7);
            }
            else if (ReadNetwork is { } __value8)
            {
                readNetwork?.Invoke(__value8);
            }
            else if (Find is { } __value9)
            {
                find?.Invoke(__value9);
            }
            else if (FormInput is { } __value10)
            {
                formInput?.Invoke(__value10);
            }
            else if (FileUpload is { } __value11)
            {
                fileUpload?.Invoke(__value11);
            }
            else if (ScrollTo is { } __value12)
            {
                scrollTo?.Invoke(__value12);
            }
            else if (Screenshot is { } __value13)
            {
                screenshot?.Invoke(__value13);
            }
            else if (Zoom is { } __value14)
            {
                zoom?.Invoke(__value14);
            }
            else if (LeftClick is { } __value15)
            {
                leftClick?.Invoke(__value15);
            }
            else if (RightClick is { } __value16)
            {
                rightClick?.Invoke(__value16);
            }
            else if (MiddleClick is { } __value17)
            {
                middleClick?.Invoke(__value17);
            }
            else if (DoubleClick is { } __value18)
            {
                doubleClick?.Invoke(__value18);
            }
            else if (TripleClick is { } __value19)
            {
                tripleClick?.Invoke(__value19);
            }
            else if (Hover is { } __value20)
            {
                hover?.Invoke(__value20);
            }
            else if (LeftClickDrag is { } __value21)
            {
                leftClickDrag?.Invoke(__value21);
            }
            else if (LeftMouseDown is { } __value22)
            {
                leftMouseDown?.Invoke(__value22);
            }
            else if (LeftMouseUp is { } __value23)
            {
                leftMouseUp?.Invoke(__value23);
            }
            else if (MouseMove is { } __value24)
            {
                mouseMove?.Invoke(__value24);
            }
            else if (Scroll is { } __value25)
            {
                scroll?.Invoke(__value25);
            }
            else if (Type is { } __value26)
            {
                type?.Invoke(__value26);
            }
            else if (Key is { } __value27)
            {
                key?.Invoke(__value27);
            }
            else if (HoldKey is { } __value28)
            {
                holdKey?.Invoke(__value28);
            }
            else if (Wait is { } __value29)
            {
                wait?.Invoke(__value29);
            }
            else if (JavascriptExec is { } __value30)
            {
                javascriptExec?.Invoke(__value30);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Navigate,
                typeof(global::Anthropic.ResponseBrowserNavigateToolUseBlock),
                ListTabs,
                typeof(global::Anthropic.ResponseBrowserListTabsToolUseBlock),
                NewTab,
                typeof(global::Anthropic.ResponseBrowserNewTabToolUseBlock),
                SwitchTab,
                typeof(global::Anthropic.ResponseBrowserSwitchTabToolUseBlock),
                CloseTab,
                typeof(global::Anthropic.ResponseBrowserCloseTabToolUseBlock),
                ReadPage,
                typeof(global::Anthropic.ResponseBrowserReadPageToolUseBlock),
                GetPageText,
                typeof(global::Anthropic.ResponseBrowserGetPageTextToolUseBlock),
                ReadConsole,
                typeof(global::Anthropic.ResponseBrowserReadConsoleToolUseBlock),
                ReadNetwork,
                typeof(global::Anthropic.ResponseBrowserReadNetworkToolUseBlock),
                Find,
                typeof(global::Anthropic.ResponseBrowserFindToolUseBlock),
                FormInput,
                typeof(global::Anthropic.ResponseBrowserFormInputToolUseBlock),
                FileUpload,
                typeof(global::Anthropic.ResponseBrowserFileUploadToolUseBlock),
                ScrollTo,
                typeof(global::Anthropic.ResponseBrowserScrollToToolUseBlock),
                Screenshot,
                typeof(global::Anthropic.ResponseBrowserScreenshotToolUseBlock),
                Zoom,
                typeof(global::Anthropic.ResponseBrowserZoomToolUseBlock),
                LeftClick,
                typeof(global::Anthropic.ResponseBrowserLeftClickToolUseBlock),
                RightClick,
                typeof(global::Anthropic.ResponseBrowserRightClickToolUseBlock),
                MiddleClick,
                typeof(global::Anthropic.ResponseBrowserMiddleClickToolUseBlock),
                DoubleClick,
                typeof(global::Anthropic.ResponseBrowserDoubleClickToolUseBlock),
                TripleClick,
                typeof(global::Anthropic.ResponseBrowserTripleClickToolUseBlock),
                Hover,
                typeof(global::Anthropic.ResponseBrowserHoverToolUseBlock),
                LeftClickDrag,
                typeof(global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock),
                LeftMouseDown,
                typeof(global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock),
                LeftMouseUp,
                typeof(global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock),
                MouseMove,
                typeof(global::Anthropic.ResponseBrowserMouseMoveToolUseBlock),
                Scroll,
                typeof(global::Anthropic.ResponseBrowserScrollToolUseBlock),
                Type,
                typeof(global::Anthropic.ResponseBrowserTypeToolUseBlock),
                Key,
                typeof(global::Anthropic.ResponseBrowserKeyToolUseBlock),
                HoldKey,
                typeof(global::Anthropic.ResponseBrowserHoldKeyToolUseBlock),
                Wait,
                typeof(global::Anthropic.ResponseBrowserWaitToolUseBlock),
                JavascriptExec,
                typeof(global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ResponseBrowserToolUseBlockUnion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserNavigateToolUseBlock?>.Default.Equals(Navigate, other.Navigate) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserListTabsToolUseBlock?>.Default.Equals(ListTabs, other.ListTabs) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserNewTabToolUseBlock?>.Default.Equals(NewTab, other.NewTab) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserSwitchTabToolUseBlock?>.Default.Equals(SwitchTab, other.SwitchTab) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserCloseTabToolUseBlock?>.Default.Equals(CloseTab, other.CloseTab) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserReadPageToolUseBlock?>.Default.Equals(ReadPage, other.ReadPage) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserGetPageTextToolUseBlock?>.Default.Equals(GetPageText, other.GetPageText) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserReadConsoleToolUseBlock?>.Default.Equals(ReadConsole, other.ReadConsole) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserReadNetworkToolUseBlock?>.Default.Equals(ReadNetwork, other.ReadNetwork) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserFindToolUseBlock?>.Default.Equals(Find, other.Find) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserFormInputToolUseBlock?>.Default.Equals(FormInput, other.FormInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserFileUploadToolUseBlock?>.Default.Equals(FileUpload, other.FileUpload) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserScrollToToolUseBlock?>.Default.Equals(ScrollTo, other.ScrollTo) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserScreenshotToolUseBlock?>.Default.Equals(Screenshot, other.Screenshot) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserZoomToolUseBlock?>.Default.Equals(Zoom, other.Zoom) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserLeftClickToolUseBlock?>.Default.Equals(LeftClick, other.LeftClick) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserRightClickToolUseBlock?>.Default.Equals(RightClick, other.RightClick) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserMiddleClickToolUseBlock?>.Default.Equals(MiddleClick, other.MiddleClick) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserDoubleClickToolUseBlock?>.Default.Equals(DoubleClick, other.DoubleClick) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserTripleClickToolUseBlock?>.Default.Equals(TripleClick, other.TripleClick) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserHoverToolUseBlock?>.Default.Equals(Hover, other.Hover) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserLeftClickDragToolUseBlock?>.Default.Equals(LeftClickDrag, other.LeftClickDrag) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserLeftMouseDownToolUseBlock?>.Default.Equals(LeftMouseDown, other.LeftMouseDown) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserLeftMouseUpToolUseBlock?>.Default.Equals(LeftMouseUp, other.LeftMouseUp) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserMouseMoveToolUseBlock?>.Default.Equals(MouseMove, other.MouseMove) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserScrollToolUseBlock?>.Default.Equals(Scroll, other.Scroll) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserTypeToolUseBlock?>.Default.Equals(Type, other.Type) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserKeyToolUseBlock?>.Default.Equals(Key, other.Key) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserHoldKeyToolUseBlock?>.Default.Equals(HoldKey, other.HoldKey) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserWaitToolUseBlock?>.Default.Equals(Wait, other.Wait) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserJavascriptExecToolUseBlock?>.Default.Equals(JavascriptExec, other.JavascriptExec)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponseBrowserToolUseBlockUnion obj1, ResponseBrowserToolUseBlockUnion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseBrowserToolUseBlockUnion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponseBrowserToolUseBlockUnion obj1, ResponseBrowserToolUseBlockUnion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseBrowserToolUseBlockUnion o && Equals(o);
        }
    }
}
