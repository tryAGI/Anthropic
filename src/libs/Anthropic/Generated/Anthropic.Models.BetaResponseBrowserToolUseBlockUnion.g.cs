#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaResponseBrowserToolUseBlockUnion : global::System.IEquatable<BetaResponseBrowserToolUseBlockUnion>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName? Name { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserNavigateToolUseBlock? Navigate { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserNavigateToolUseBlock? Navigate { get; }
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
            out global::Anthropic.BetaResponseBrowserNavigateToolUseBlock? value)
        {
            value = Navigate;
            return IsNavigate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserNavigateToolUseBlock PickNavigate() => Navigate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Navigate' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserListTabsToolUseBlock? ListTabs { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserListTabsToolUseBlock? ListTabs { get; }
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
            out global::Anthropic.BetaResponseBrowserListTabsToolUseBlock? value)
        {
            value = ListTabs;
            return IsListTabs;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserListTabsToolUseBlock PickListTabs() => ListTabs is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListTabs' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserNewTabToolUseBlock? NewTab { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserNewTabToolUseBlock? NewTab { get; }
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
            out global::Anthropic.BetaResponseBrowserNewTabToolUseBlock? value)
        {
            value = NewTab;
            return IsNewTab;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserNewTabToolUseBlock PickNewTab() => NewTab is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NewTab' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock? SwitchTab { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock? SwitchTab { get; }
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
            out global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock? value)
        {
            value = SwitchTab;
            return IsSwitchTab;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock PickSwitchTab() => SwitchTab is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SwitchTab' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock? CloseTab { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock? CloseTab { get; }
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
            out global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock? value)
        {
            value = CloseTab;
            return IsCloseTab;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock PickCloseTab() => CloseTab is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CloseTab' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserReadPageToolUseBlock? ReadPage { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserReadPageToolUseBlock? ReadPage { get; }
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
            out global::Anthropic.BetaResponseBrowserReadPageToolUseBlock? value)
        {
            value = ReadPage;
            return IsReadPage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserReadPageToolUseBlock PickReadPage() => ReadPage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReadPage' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock? GetPageText { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock? GetPageText { get; }
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
            out global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock? value)
        {
            value = GetPageText;
            return IsGetPageText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock PickGetPageText() => GetPageText is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GetPageText' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock? ReadConsole { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock? ReadConsole { get; }
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
            out global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock? value)
        {
            value = ReadConsole;
            return IsReadConsole;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock PickReadConsole() => ReadConsole is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReadConsole' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock? ReadNetwork { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock? ReadNetwork { get; }
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
            out global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock? value)
        {
            value = ReadNetwork;
            return IsReadNetwork;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock PickReadNetwork() => ReadNetwork is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReadNetwork' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserFindToolUseBlock? Find { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserFindToolUseBlock? Find { get; }
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
            out global::Anthropic.BetaResponseBrowserFindToolUseBlock? value)
        {
            value = Find;
            return IsFind;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserFindToolUseBlock PickFind() => Find is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Find' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserFormInputToolUseBlock? FormInput { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserFormInputToolUseBlock? FormInput { get; }
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
            out global::Anthropic.BetaResponseBrowserFormInputToolUseBlock? value)
        {
            value = FormInput;
            return IsFormInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserFormInputToolUseBlock PickFormInput() => FormInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FormInput' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock? FileUpload { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock? FileUpload { get; }
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
            out global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock? value)
        {
            value = FileUpload;
            return IsFileUpload;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock PickFileUpload() => FileUpload is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileUpload' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserScrollToToolUseBlock? ScrollTo { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserScrollToToolUseBlock? ScrollTo { get; }
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
            out global::Anthropic.BetaResponseBrowserScrollToToolUseBlock? value)
        {
            value = ScrollTo;
            return IsScrollTo;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserScrollToToolUseBlock PickScrollTo() => ScrollTo is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScrollTo' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock? Screenshot { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock? Screenshot { get; }
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
            out global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock? value)
        {
            value = Screenshot;
            return IsScreenshot;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock PickScreenshot() => Screenshot is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Screenshot' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserZoomToolUseBlock? Zoom { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserZoomToolUseBlock? Zoom { get; }
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
            out global::Anthropic.BetaResponseBrowserZoomToolUseBlock? value)
        {
            value = Zoom;
            return IsZoom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserZoomToolUseBlock PickZoom() => Zoom is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Zoom' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock? LeftClick { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock? LeftClick { get; }
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
            out global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock? value)
        {
            value = LeftClick;
            return IsLeftClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock PickLeftClick() => LeftClick is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LeftClick' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserRightClickToolUseBlock? RightClick { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserRightClickToolUseBlock? RightClick { get; }
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
            out global::Anthropic.BetaResponseBrowserRightClickToolUseBlock? value)
        {
            value = RightClick;
            return IsRightClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserRightClickToolUseBlock PickRightClick() => RightClick is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RightClick' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock? MiddleClick { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock? MiddleClick { get; }
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
            out global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock? value)
        {
            value = MiddleClick;
            return IsMiddleClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock PickMiddleClick() => MiddleClick is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MiddleClick' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock? DoubleClick { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock? DoubleClick { get; }
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
            out global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock? value)
        {
            value = DoubleClick;
            return IsDoubleClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock PickDoubleClick() => DoubleClick is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DoubleClick' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock? TripleClick { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock? TripleClick { get; }
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
            out global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock? value)
        {
            value = TripleClick;
            return IsTripleClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock PickTripleClick() => TripleClick is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TripleClick' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserHoverToolUseBlock? Hover { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserHoverToolUseBlock? Hover { get; }
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
            out global::Anthropic.BetaResponseBrowserHoverToolUseBlock? value)
        {
            value = Hover;
            return IsHover;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserHoverToolUseBlock PickHover() => Hover is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Hover' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock? LeftClickDrag { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock? LeftClickDrag { get; }
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
            out global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock? value)
        {
            value = LeftClickDrag;
            return IsLeftClickDrag;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock PickLeftClickDrag() => LeftClickDrag is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LeftClickDrag' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock? LeftMouseDown { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock? LeftMouseDown { get; }
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
            out global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock? value)
        {
            value = LeftMouseDown;
            return IsLeftMouseDown;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock PickLeftMouseDown() => LeftMouseDown is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LeftMouseDown' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock? LeftMouseUp { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock? LeftMouseUp { get; }
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
            out global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock? value)
        {
            value = LeftMouseUp;
            return IsLeftMouseUp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock PickLeftMouseUp() => LeftMouseUp is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LeftMouseUp' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock? MouseMove { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock? MouseMove { get; }
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
            out global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock? value)
        {
            value = MouseMove;
            return IsMouseMove;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock PickMouseMove() => MouseMove is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MouseMove' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserScrollToolUseBlock? Scroll { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserScrollToolUseBlock? Scroll { get; }
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
            out global::Anthropic.BetaResponseBrowserScrollToolUseBlock? value)
        {
            value = Scroll;
            return IsScroll;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserScrollToolUseBlock PickScroll() => Scroll is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Scroll' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserTypeToolUseBlock? Type { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserTypeToolUseBlock? Type { get; }
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
            out global::Anthropic.BetaResponseBrowserTypeToolUseBlock? value)
        {
            value = Type;
            return IsType;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserTypeToolUseBlock PickType() => Type is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Type' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserKeyToolUseBlock? Key { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserKeyToolUseBlock? Key { get; }
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
            out global::Anthropic.BetaResponseBrowserKeyToolUseBlock? value)
        {
            value = Key;
            return IsKey;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserKeyToolUseBlock PickKey() => Key is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Key' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock? HoldKey { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock? HoldKey { get; }
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
            out global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock? value)
        {
            value = HoldKey;
            return IsHoldKey;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock PickHoldKey() => HoldKey is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HoldKey' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserWaitToolUseBlock? Wait { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserWaitToolUseBlock? Wait { get; }
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
            out global::Anthropic.BetaResponseBrowserWaitToolUseBlock? value)
        {
            value = Wait;
            return IsWait;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserWaitToolUseBlock PickWait() => Wait is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Wait' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock? JavascriptExec { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock? JavascriptExec { get; }
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
            out global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock? value)
        {
            value = JavascriptExec;
            return IsJavascriptExec;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock PickJavascriptExec() => JavascriptExec is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JavascriptExec' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserNavigateToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserNavigateToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserNavigateToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.Navigate;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserNavigateToolUseBlock? value)
        {
            Navigate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromNavigate(global::Anthropic.BetaResponseBrowserNavigateToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserListTabsToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserListTabsToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserListTabsToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.ListTabs;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserListTabsToolUseBlock? value)
        {
            ListTabs = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromListTabs(global::Anthropic.BetaResponseBrowserListTabsToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserNewTabToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserNewTabToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserNewTabToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.NewTab;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserNewTabToolUseBlock? value)
        {
            NewTab = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromNewTab(global::Anthropic.BetaResponseBrowserNewTabToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.SwitchTab;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock? value)
        {
            SwitchTab = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromSwitchTab(global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.CloseTab;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock? value)
        {
            CloseTab = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromCloseTab(global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserReadPageToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserReadPageToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserReadPageToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.ReadPage;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserReadPageToolUseBlock? value)
        {
            ReadPage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromReadPage(global::Anthropic.BetaResponseBrowserReadPageToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.GetPageText;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock? value)
        {
            GetPageText = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromGetPageText(global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.ReadConsole;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock? value)
        {
            ReadConsole = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromReadConsole(global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.ReadNetwork;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock? value)
        {
            ReadNetwork = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromReadNetwork(global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserFindToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserFindToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserFindToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.Find;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserFindToolUseBlock? value)
        {
            Find = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromFind(global::Anthropic.BetaResponseBrowserFindToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserFormInputToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserFormInputToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserFormInputToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.FormInput;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserFormInputToolUseBlock? value)
        {
            FormInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromFormInput(global::Anthropic.BetaResponseBrowserFormInputToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.FileUpload;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock? value)
        {
            FileUpload = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromFileUpload(global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserScrollToToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserScrollToToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserScrollToToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.ScrollTo;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserScrollToToolUseBlock? value)
        {
            ScrollTo = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromScrollTo(global::Anthropic.BetaResponseBrowserScrollToToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.Screenshot;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock? value)
        {
            Screenshot = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromScreenshot(global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserZoomToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserZoomToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserZoomToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.Zoom;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserZoomToolUseBlock? value)
        {
            Zoom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromZoom(global::Anthropic.BetaResponseBrowserZoomToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.LeftClick;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock? value)
        {
            LeftClick = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromLeftClick(global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserRightClickToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserRightClickToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserRightClickToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.RightClick;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserRightClickToolUseBlock? value)
        {
            RightClick = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromRightClick(global::Anthropic.BetaResponseBrowserRightClickToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.MiddleClick;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock? value)
        {
            MiddleClick = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromMiddleClick(global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.DoubleClick;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock? value)
        {
            DoubleClick = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromDoubleClick(global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.TripleClick;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock? value)
        {
            TripleClick = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromTripleClick(global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserHoverToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserHoverToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserHoverToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.Hover;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserHoverToolUseBlock? value)
        {
            Hover = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromHover(global::Anthropic.BetaResponseBrowserHoverToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.LeftClickDrag;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock? value)
        {
            LeftClickDrag = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromLeftClickDrag(global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.LeftMouseDown;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock? value)
        {
            LeftMouseDown = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromLeftMouseDown(global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.LeftMouseUp;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock? value)
        {
            LeftMouseUp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromLeftMouseUp(global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.MouseMove;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock? value)
        {
            MouseMove = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromMouseMove(global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserScrollToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserScrollToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserScrollToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.Scroll;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserScrollToolUseBlock? value)
        {
            Scroll = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromScroll(global::Anthropic.BetaResponseBrowserScrollToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserTypeToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserTypeToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserTypeToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.Type;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserTypeToolUseBlock? value)
        {
            Type = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromType(global::Anthropic.BetaResponseBrowserTypeToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserKeyToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserKeyToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserKeyToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.Key;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserKeyToolUseBlock? value)
        {
            Key = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromKey(global::Anthropic.BetaResponseBrowserKeyToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.HoldKey;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock? value)
        {
            HoldKey = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromHoldKey(global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserWaitToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserWaitToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserWaitToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.Wait;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserWaitToolUseBlock? value)
        {
            Wait = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromWait(global::Anthropic.BetaResponseBrowserWaitToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock value) => new BetaResponseBrowserToolUseBlockUnion((global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock?(BetaResponseBrowserToolUseBlockUnion @this) => @this.JavascriptExec;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock? value)
        {
            JavascriptExec = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnion FromJavascriptExec(global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock? value) => new BetaResponseBrowserToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnion(
            global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName? name,
            global::Anthropic.BetaResponseBrowserNavigateToolUseBlock? navigate,
            global::Anthropic.BetaResponseBrowserListTabsToolUseBlock? listTabs,
            global::Anthropic.BetaResponseBrowserNewTabToolUseBlock? newTab,
            global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock? switchTab,
            global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock? closeTab,
            global::Anthropic.BetaResponseBrowserReadPageToolUseBlock? readPage,
            global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock? getPageText,
            global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock? readConsole,
            global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock? readNetwork,
            global::Anthropic.BetaResponseBrowserFindToolUseBlock? find,
            global::Anthropic.BetaResponseBrowserFormInputToolUseBlock? formInput,
            global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock? fileUpload,
            global::Anthropic.BetaResponseBrowserScrollToToolUseBlock? scrollTo,
            global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock? screenshot,
            global::Anthropic.BetaResponseBrowserZoomToolUseBlock? zoom,
            global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock? leftClick,
            global::Anthropic.BetaResponseBrowserRightClickToolUseBlock? rightClick,
            global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock? middleClick,
            global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock? doubleClick,
            global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock? tripleClick,
            global::Anthropic.BetaResponseBrowserHoverToolUseBlock? hover,
            global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock? leftClickDrag,
            global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock? leftMouseDown,
            global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock? leftMouseUp,
            global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock? mouseMove,
            global::Anthropic.BetaResponseBrowserScrollToolUseBlock? scroll,
            global::Anthropic.BetaResponseBrowserTypeToolUseBlock? type,
            global::Anthropic.BetaResponseBrowserKeyToolUseBlock? key,
            global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock? holdKey,
            global::Anthropic.BetaResponseBrowserWaitToolUseBlock? wait,
            global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock? javascriptExec
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
            global::System.Func<global::Anthropic.BetaResponseBrowserNavigateToolUseBlock, TResult>? navigate = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserListTabsToolUseBlock, TResult>? listTabs = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserNewTabToolUseBlock, TResult>? newTab = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock, TResult>? switchTab = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock, TResult>? closeTab = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserReadPageToolUseBlock, TResult>? readPage = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock, TResult>? getPageText = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock, TResult>? readConsole = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock, TResult>? readNetwork = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserFindToolUseBlock, TResult>? find = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserFormInputToolUseBlock, TResult>? formInput = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock, TResult>? fileUpload = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserScrollToToolUseBlock, TResult>? scrollTo = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock, TResult>? screenshot = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserZoomToolUseBlock, TResult>? zoom = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock, TResult>? leftClick = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserRightClickToolUseBlock, TResult>? rightClick = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock, TResult>? middleClick = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock, TResult>? doubleClick = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock, TResult>? tripleClick = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserHoverToolUseBlock, TResult>? hover = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock, TResult>? leftClickDrag = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock, TResult>? leftMouseDown = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock, TResult>? leftMouseUp = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock, TResult>? mouseMove = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserScrollToolUseBlock, TResult>? scroll = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserTypeToolUseBlock, TResult>? type = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserKeyToolUseBlock, TResult>? key = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock, TResult>? holdKey = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserWaitToolUseBlock, TResult>? wait = null,
            global::System.Func<global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock, TResult>? javascriptExec = null,
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
            global::System.Action<global::Anthropic.BetaResponseBrowserNavigateToolUseBlock>? navigate = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserListTabsToolUseBlock>? listTabs = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserNewTabToolUseBlock>? newTab = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock>? switchTab = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock>? closeTab = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserReadPageToolUseBlock>? readPage = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock>? getPageText = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock>? readConsole = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock>? readNetwork = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserFindToolUseBlock>? find = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserFormInputToolUseBlock>? formInput = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock>? fileUpload = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserScrollToToolUseBlock>? scrollTo = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock>? screenshot = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserZoomToolUseBlock>? zoom = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock>? leftClick = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserRightClickToolUseBlock>? rightClick = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock>? middleClick = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock>? doubleClick = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock>? tripleClick = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserHoverToolUseBlock>? hover = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock>? leftClickDrag = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock>? leftMouseDown = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock>? leftMouseUp = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock>? mouseMove = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserScrollToolUseBlock>? scroll = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserTypeToolUseBlock>? type = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserKeyToolUseBlock>? key = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock>? holdKey = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserWaitToolUseBlock>? wait = null,

            global::System.Action<global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock>? javascriptExec = null,
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
            global::System.Action<global::Anthropic.BetaResponseBrowserNavigateToolUseBlock>? navigate = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserListTabsToolUseBlock>? listTabs = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserNewTabToolUseBlock>? newTab = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock>? switchTab = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock>? closeTab = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserReadPageToolUseBlock>? readPage = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock>? getPageText = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock>? readConsole = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock>? readNetwork = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserFindToolUseBlock>? find = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserFormInputToolUseBlock>? formInput = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock>? fileUpload = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserScrollToToolUseBlock>? scrollTo = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock>? screenshot = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserZoomToolUseBlock>? zoom = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock>? leftClick = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserRightClickToolUseBlock>? rightClick = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock>? middleClick = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock>? doubleClick = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock>? tripleClick = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserHoverToolUseBlock>? hover = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock>? leftClickDrag = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock>? leftMouseDown = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock>? leftMouseUp = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock>? mouseMove = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserScrollToolUseBlock>? scroll = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserTypeToolUseBlock>? type = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserKeyToolUseBlock>? key = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock>? holdKey = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserWaitToolUseBlock>? wait = null,
            global::System.Action<global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock>? javascriptExec = null,
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
                typeof(global::Anthropic.BetaResponseBrowserNavigateToolUseBlock),
                ListTabs,
                typeof(global::Anthropic.BetaResponseBrowserListTabsToolUseBlock),
                NewTab,
                typeof(global::Anthropic.BetaResponseBrowserNewTabToolUseBlock),
                SwitchTab,
                typeof(global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock),
                CloseTab,
                typeof(global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock),
                ReadPage,
                typeof(global::Anthropic.BetaResponseBrowserReadPageToolUseBlock),
                GetPageText,
                typeof(global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock),
                ReadConsole,
                typeof(global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock),
                ReadNetwork,
                typeof(global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock),
                Find,
                typeof(global::Anthropic.BetaResponseBrowserFindToolUseBlock),
                FormInput,
                typeof(global::Anthropic.BetaResponseBrowserFormInputToolUseBlock),
                FileUpload,
                typeof(global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock),
                ScrollTo,
                typeof(global::Anthropic.BetaResponseBrowserScrollToToolUseBlock),
                Screenshot,
                typeof(global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock),
                Zoom,
                typeof(global::Anthropic.BetaResponseBrowserZoomToolUseBlock),
                LeftClick,
                typeof(global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock),
                RightClick,
                typeof(global::Anthropic.BetaResponseBrowserRightClickToolUseBlock),
                MiddleClick,
                typeof(global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock),
                DoubleClick,
                typeof(global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock),
                TripleClick,
                typeof(global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock),
                Hover,
                typeof(global::Anthropic.BetaResponseBrowserHoverToolUseBlock),
                LeftClickDrag,
                typeof(global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock),
                LeftMouseDown,
                typeof(global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock),
                LeftMouseUp,
                typeof(global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock),
                MouseMove,
                typeof(global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock),
                Scroll,
                typeof(global::Anthropic.BetaResponseBrowserScrollToolUseBlock),
                Type,
                typeof(global::Anthropic.BetaResponseBrowserTypeToolUseBlock),
                Key,
                typeof(global::Anthropic.BetaResponseBrowserKeyToolUseBlock),
                HoldKey,
                typeof(global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock),
                Wait,
                typeof(global::Anthropic.BetaResponseBrowserWaitToolUseBlock),
                JavascriptExec,
                typeof(global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock),
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
        public bool Equals(BetaResponseBrowserToolUseBlockUnion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserNavigateToolUseBlock?>.Default.Equals(Navigate, other.Navigate) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserListTabsToolUseBlock?>.Default.Equals(ListTabs, other.ListTabs) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserNewTabToolUseBlock?>.Default.Equals(NewTab, other.NewTab) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserSwitchTabToolUseBlock?>.Default.Equals(SwitchTab, other.SwitchTab) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserCloseTabToolUseBlock?>.Default.Equals(CloseTab, other.CloseTab) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserReadPageToolUseBlock?>.Default.Equals(ReadPage, other.ReadPage) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserGetPageTextToolUseBlock?>.Default.Equals(GetPageText, other.GetPageText) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserReadConsoleToolUseBlock?>.Default.Equals(ReadConsole, other.ReadConsole) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserReadNetworkToolUseBlock?>.Default.Equals(ReadNetwork, other.ReadNetwork) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserFindToolUseBlock?>.Default.Equals(Find, other.Find) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserFormInputToolUseBlock?>.Default.Equals(FormInput, other.FormInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserFileUploadToolUseBlock?>.Default.Equals(FileUpload, other.FileUpload) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserScrollToToolUseBlock?>.Default.Equals(ScrollTo, other.ScrollTo) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserScreenshotToolUseBlock?>.Default.Equals(Screenshot, other.Screenshot) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserZoomToolUseBlock?>.Default.Equals(Zoom, other.Zoom) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserLeftClickToolUseBlock?>.Default.Equals(LeftClick, other.LeftClick) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserRightClickToolUseBlock?>.Default.Equals(RightClick, other.RightClick) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserMiddleClickToolUseBlock?>.Default.Equals(MiddleClick, other.MiddleClick) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserDoubleClickToolUseBlock?>.Default.Equals(DoubleClick, other.DoubleClick) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserTripleClickToolUseBlock?>.Default.Equals(TripleClick, other.TripleClick) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserHoverToolUseBlock?>.Default.Equals(Hover, other.Hover) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserLeftClickDragToolUseBlock?>.Default.Equals(LeftClickDrag, other.LeftClickDrag) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserLeftMouseDownToolUseBlock?>.Default.Equals(LeftMouseDown, other.LeftMouseDown) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserLeftMouseUpToolUseBlock?>.Default.Equals(LeftMouseUp, other.LeftMouseUp) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserMouseMoveToolUseBlock?>.Default.Equals(MouseMove, other.MouseMove) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserScrollToolUseBlock?>.Default.Equals(Scroll, other.Scroll) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserTypeToolUseBlock?>.Default.Equals(Type, other.Type) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserKeyToolUseBlock?>.Default.Equals(Key, other.Key) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserHoldKeyToolUseBlock?>.Default.Equals(HoldKey, other.HoldKey) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserWaitToolUseBlock?>.Default.Equals(Wait, other.Wait) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserJavascriptExecToolUseBlock?>.Default.Equals(JavascriptExec, other.JavascriptExec)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaResponseBrowserToolUseBlockUnion obj1, BetaResponseBrowserToolUseBlockUnion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaResponseBrowserToolUseBlockUnion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaResponseBrowserToolUseBlockUnion obj1, BetaResponseBrowserToolUseBlockUnion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaResponseBrowserToolUseBlockUnion o && Equals(o);
        }
    }
}
