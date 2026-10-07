#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The `input` of a browser toolset member `tool_use` block: the member's own parameters.
    /// </summary>
    public readonly partial struct BetaBrowserMemberInput : global::System.IEquatable<BetaBrowserMemberInput>
    {
        /// <summary>
        /// Navigate to a URL, or go back/forward/reload in history. The protocol may be<br/>
        /// omitted (defaults to https://).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserNavigateInput? BrowserNavigateInput { get; init; }
#else
        public global::Anthropic.BetaBrowserNavigateInput? BrowserNavigateInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserNavigateInput))]
#endif
        public bool IsBrowserNavigateInput => BrowserNavigateInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserNavigateInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserNavigateInput? value)
        {
            value = BrowserNavigateInput;
            return IsBrowserNavigateInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserNavigateInput PickBrowserNavigateInput() => BrowserNavigateInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserNavigateInput' but the value was {ToString()}.");

        /// <summary>
        /// List all open tabs with each tab's tab_id, title, and URL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserListTabsInput? BrowserListTabsInput { get; init; }
#else
        public global::Anthropic.BetaBrowserListTabsInput? BrowserListTabsInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserListTabsInput))]
#endif
        public bool IsBrowserListTabsInput => BrowserListTabsInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserListTabsInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserListTabsInput? value)
        {
            value = BrowserListTabsInput;
            return IsBrowserListTabsInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserListTabsInput PickBrowserListTabsInput() => BrowserListTabsInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserListTabsInput' but the value was {ToString()}.");

        /// <summary>
        /// Open a new empty tab and return its tab_id.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserNewTabInput? BrowserNewTabInput { get; init; }
#else
        public global::Anthropic.BetaBrowserNewTabInput? BrowserNewTabInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserNewTabInput))]
#endif
        public bool IsBrowserNewTabInput => BrowserNewTabInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserNewTabInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserNewTabInput? value)
        {
            value = BrowserNewTabInput;
            return IsBrowserNewTabInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserNewTabInput PickBrowserNewTabInput() => BrowserNewTabInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserNewTabInput' but the value was {ToString()}.");

        /// <summary>
        /// Make the tab with the given tab_id the active tab — the tab that actions without<br/>
        /// a tab_id apply to.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserSwitchTabInput? BrowserSwitchTabInput { get; init; }
#else
        public global::Anthropic.BetaBrowserSwitchTabInput? BrowserSwitchTabInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserSwitchTabInput))]
#endif
        public bool IsBrowserSwitchTabInput => BrowserSwitchTabInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserSwitchTabInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserSwitchTabInput? value)
        {
            value = BrowserSwitchTabInput;
            return IsBrowserSwitchTabInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserSwitchTabInput PickBrowserSwitchTabInput() => BrowserSwitchTabInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserSwitchTabInput' but the value was {ToString()}.");

        /// <summary>
        /// Close the tab with the given tab_id.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserCloseTabInput? BrowserCloseTabInput { get; init; }
#else
        public global::Anthropic.BetaBrowserCloseTabInput? BrowserCloseTabInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserCloseTabInput))]
#endif
        public bool IsBrowserCloseTabInput => BrowserCloseTabInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserCloseTabInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserCloseTabInput? value)
        {
            value = BrowserCloseTabInput;
            return IsBrowserCloseTabInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserCloseTabInput PickBrowserCloseTabInput() => BrowserCloseTabInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserCloseTabInput' but the value was {ToString()}.");

        /// <summary>
        /// Return a structured accessibility tree of the page (or the subtree rooted at<br/>
        /// `ref`), with element references like [ref_7] that can be used as targets on later<br/>
        /// actions. Output is capped at 50,000 characters — narrow with `ref` or a smaller<br/>
        /// `depth` when exceeded.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserReadPageInput? BrowserReadPageInput { get; init; }
#else
        public global::Anthropic.BetaBrowserReadPageInput? BrowserReadPageInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserReadPageInput))]
#endif
        public bool IsBrowserReadPageInput => BrowserReadPageInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserReadPageInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserReadPageInput? value)
        {
            value = BrowserReadPageInput;
            return IsBrowserReadPageInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadPageInput PickBrowserReadPageInput() => BrowserReadPageInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserReadPageInput' but the value was {ToString()}.");

        /// <summary>
        /// Return the page's visible text content as plain text, prioritizing article<br/>
        /// content. Suited to articles, documentation, and other text-heavy pages.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserGetPageTextInput? BrowserGetPageTextInput { get; init; }
#else
        public global::Anthropic.BetaBrowserGetPageTextInput? BrowserGetPageTextInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserGetPageTextInput))]
#endif
        public bool IsBrowserGetPageTextInput => BrowserGetPageTextInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserGetPageTextInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserGetPageTextInput? value)
        {
            value = BrowserGetPageTextInput;
            return IsBrowserGetPageTextInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserGetPageTextInput PickBrowserGetPageTextInput() => BrowserGetPageTextInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserGetPageTextInput' but the value was {ToString()}.");

        /// <summary>
        /// Return console output (log entries, errors, warnings) accumulated since the<br/>
        /// driver attached to the tab and since the last read, one line per entry. An empty<br/>
        /// result does not mean no traffic for a tab that predates attach.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserReadConsoleInput? BrowserReadConsoleInput { get; init; }
#else
        public global::Anthropic.BetaBrowserReadConsoleInput? BrowserReadConsoleInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserReadConsoleInput))]
#endif
        public bool IsBrowserReadConsoleInput => BrowserReadConsoleInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserReadConsoleInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserReadConsoleInput? value)
        {
            value = BrowserReadConsoleInput;
            return IsBrowserReadConsoleInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadConsoleInput PickBrowserReadConsoleInput() => BrowserReadConsoleInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserReadConsoleInput' but the value was {ToString()}.");

        /// <summary>
        /// Return the network requests (method, URL, status, MIME type, timing) recorded<br/>
        /// since the driver attached to the tab and since the last read, one line per entry.<br/>
        /// An empty result does not mean no traffic for a tab that predates attach.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserReadNetworkInput? BrowserReadNetworkInput { get; init; }
#else
        public global::Anthropic.BetaBrowserReadNetworkInput? BrowserReadNetworkInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserReadNetworkInput))]
#endif
        public bool IsBrowserReadNetworkInput => BrowserReadNetworkInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserReadNetworkInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserReadNetworkInput? value)
        {
            value = BrowserReadNetworkInput;
            return IsBrowserReadNetworkInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserReadNetworkInput PickBrowserReadNetworkInput() => BrowserReadNetworkInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserReadNetworkInput' but the value was {ToString()}.");

        /// <summary>
        /// Find elements matching a natural-language description (e.g. "search bar", "add to<br/>
        /// cart button") and return up to 20 matches with element references.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserFindInput? BrowserFindInput { get; init; }
#else
        public global::Anthropic.BetaBrowserFindInput? BrowserFindInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserFindInput))]
#endif
        public bool IsBrowserFindInput => BrowserFindInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserFindInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserFindInput? value)
        {
            value = BrowserFindInput;
            return IsBrowserFindInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFindInput PickBrowserFindInput() => BrowserFindInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserFindInput' but the value was {ToString()}.");

        /// <summary>
        /// Set the value of a form element (input, textarea, select, checkbox). Use a<br/>
        /// boolean for checkboxes, an option value or text for selects.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserFormInputInput? BrowserFormInputInput { get; init; }
#else
        public global::Anthropic.BetaBrowserFormInputInput? BrowserFormInputInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserFormInputInput))]
#endif
        public bool IsBrowserFormInputInput => BrowserFormInputInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserFormInputInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserFormInputInput? value)
        {
            value = BrowserFormInputInput;
            return IsBrowserFormInputInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFormInputInput PickBrowserFormInputInput() => BrowserFormInputInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserFormInputInput' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserFileUploadInput? FileUpload { get; init; }
#else
        public global::Anthropic.BetaBrowserFileUploadInput? FileUpload { get; }
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
            out global::Anthropic.BetaBrowserFileUploadInput? value)
        {
            value = FileUpload;
            return IsFileUpload;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserFileUploadInput PickFileUpload() => FileUpload is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileUpload' but the value was {ToString()}.");

        /// <summary>
        /// Scroll an element into view.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserScrollToInput? BrowserScrollToInput { get; init; }
#else
        public global::Anthropic.BetaBrowserScrollToInput? BrowserScrollToInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserScrollToInput))]
#endif
        public bool IsBrowserScrollToInput => BrowserScrollToInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserScrollToInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserScrollToInput? value)
        {
            value = BrowserScrollToInput;
            return IsBrowserScrollToInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollToInput PickBrowserScrollToInput() => BrowserScrollToInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserScrollToInput' but the value was {ToString()}.");

        /// <summary>
        /// Capture the current browser viewport.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserScreenshotInput? BrowserScreenshotInput { get; init; }
#else
        public global::Anthropic.BetaBrowserScreenshotInput? BrowserScreenshotInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserScreenshotInput))]
#endif
        public bool IsBrowserScreenshotInput => BrowserScreenshotInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserScreenshotInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserScreenshotInput? value)
        {
            value = BrowserScreenshotInput;
            return IsBrowserScreenshotInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScreenshotInput PickBrowserScreenshotInput() => BrowserScreenshotInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserScreenshotInput' but the value was {ToString()}.");

        /// <summary>
        /// Return a cropped screenshot of the given viewport region, scaled up for closer<br/>
        /// inspection — useful for small icons, buttons, or text. Coordinates are in the<br/>
        /// same viewport-pixel space as a full screenshot.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserZoomInput? BrowserZoomInput { get; init; }
#else
        public global::Anthropic.BetaBrowserZoomInput? BrowserZoomInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserZoomInput))]
#endif
        public bool IsBrowserZoomInput => BrowserZoomInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserZoomInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserZoomInput? value)
        {
            value = BrowserZoomInput;
            return IsBrowserZoomInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserZoomInput PickBrowserZoomInput() => BrowserZoomInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserZoomInput' but the value was {ToString()}.");

        /// <summary>
        /// Left-click at a viewport coordinate or on an element by reference.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserLeftClickInput? BrowserLeftClickInput { get; init; }
#else
        public global::Anthropic.BetaBrowserLeftClickInput? BrowserLeftClickInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserLeftClickInput))]
#endif
        public bool IsBrowserLeftClickInput => BrowserLeftClickInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserLeftClickInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserLeftClickInput? value)
        {
            value = BrowserLeftClickInput;
            return IsBrowserLeftClickInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftClickInput PickBrowserLeftClickInput() => BrowserLeftClickInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserLeftClickInput' but the value was {ToString()}.");

        /// <summary>
        /// Right-click at a viewport coordinate or on an element by reference.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserRightClickInput? BrowserRightClickInput { get; init; }
#else
        public global::Anthropic.BetaBrowserRightClickInput? BrowserRightClickInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserRightClickInput))]
#endif
        public bool IsBrowserRightClickInput => BrowserRightClickInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserRightClickInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserRightClickInput? value)
        {
            value = BrowserRightClickInput;
            return IsBrowserRightClickInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserRightClickInput PickBrowserRightClickInput() => BrowserRightClickInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserRightClickInput' but the value was {ToString()}.");

        /// <summary>
        /// Middle-click at a viewport coordinate or on an element by reference.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserMiddleClickInput? BrowserMiddleClickInput { get; init; }
#else
        public global::Anthropic.BetaBrowserMiddleClickInput? BrowserMiddleClickInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserMiddleClickInput))]
#endif
        public bool IsBrowserMiddleClickInput => BrowserMiddleClickInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserMiddleClickInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserMiddleClickInput? value)
        {
            value = BrowserMiddleClickInput;
            return IsBrowserMiddleClickInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMiddleClickInput PickBrowserMiddleClickInput() => BrowserMiddleClickInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserMiddleClickInput' but the value was {ToString()}.");

        /// <summary>
        /// Double left-click at a viewport coordinate or on an element by reference.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserDoubleClickInput? BrowserDoubleClickInput { get; init; }
#else
        public global::Anthropic.BetaBrowserDoubleClickInput? BrowserDoubleClickInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserDoubleClickInput))]
#endif
        public bool IsBrowserDoubleClickInput => BrowserDoubleClickInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserDoubleClickInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserDoubleClickInput? value)
        {
            value = BrowserDoubleClickInput;
            return IsBrowserDoubleClickInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserDoubleClickInput PickBrowserDoubleClickInput() => BrowserDoubleClickInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserDoubleClickInput' but the value was {ToString()}.");

        /// <summary>
        /// Triple left-click at a viewport coordinate or on an element by reference<br/>
        /// (typically selects a line or paragraph).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserTripleClickInput? BrowserTripleClickInput { get; init; }
#else
        public global::Anthropic.BetaBrowserTripleClickInput? BrowserTripleClickInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserTripleClickInput))]
#endif
        public bool IsBrowserTripleClickInput => BrowserTripleClickInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserTripleClickInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserTripleClickInput? value)
        {
            value = BrowserTripleClickInput;
            return IsBrowserTripleClickInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserTripleClickInput PickBrowserTripleClickInput() => BrowserTripleClickInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserTripleClickInput' but the value was {ToString()}.");

        /// <summary>
        /// Move the cursor to a coordinate or element without clicking.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserHoverInput? BrowserHoverInput { get; init; }
#else
        public global::Anthropic.BetaBrowserHoverInput? BrowserHoverInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserHoverInput))]
#endif
        public bool IsBrowserHoverInput => BrowserHoverInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserHoverInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserHoverInput? value)
        {
            value = BrowserHoverInput;
            return IsBrowserHoverInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserHoverInput PickBrowserHoverInput() => BrowserHoverInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserHoverInput' but the value was {ToString()}.");

        /// <summary>
        /// Press at `from`, drag to `target`, release. Both must be coordinate targets.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserLeftClickDragInput? BrowserLeftClickDragInput { get; init; }
#else
        public global::Anthropic.BetaBrowserLeftClickDragInput? BrowserLeftClickDragInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserLeftClickDragInput))]
#endif
        public bool IsBrowserLeftClickDragInput => BrowserLeftClickDragInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserLeftClickDragInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserLeftClickDragInput? value)
        {
            value = BrowserLeftClickDragInput;
            return IsBrowserLeftClickDragInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftClickDragInput PickBrowserLeftClickDragInput() => BrowserLeftClickDragInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserLeftClickDragInput' but the value was {ToString()}.");

        /// <summary>
        /// Press and hold the left mouse button at a viewport coordinate. Pair with<br/>
        /// left_mouse_up to perform a custom drag.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserLeftMouseDownInput? BrowserLeftMouseDownInput { get; init; }
#else
        public global::Anthropic.BetaBrowserLeftMouseDownInput? BrowserLeftMouseDownInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserLeftMouseDownInput))]
#endif
        public bool IsBrowserLeftMouseDownInput => BrowserLeftMouseDownInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserLeftMouseDownInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserLeftMouseDownInput? value)
        {
            value = BrowserLeftMouseDownInput;
            return IsBrowserLeftMouseDownInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftMouseDownInput PickBrowserLeftMouseDownInput() => BrowserLeftMouseDownInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserLeftMouseDownInput' but the value was {ToString()}.");

        /// <summary>
        /// Release the left mouse button at a viewport coordinate.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserLeftMouseUpInput? BrowserLeftMouseUpInput { get; init; }
#else
        public global::Anthropic.BetaBrowserLeftMouseUpInput? BrowserLeftMouseUpInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserLeftMouseUpInput))]
#endif
        public bool IsBrowserLeftMouseUpInput => BrowserLeftMouseUpInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserLeftMouseUpInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserLeftMouseUpInput? value)
        {
            value = BrowserLeftMouseUpInput;
            return IsBrowserLeftMouseUpInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserLeftMouseUpInput PickBrowserLeftMouseUpInput() => BrowserLeftMouseUpInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserLeftMouseUpInput' but the value was {ToString()}.");

        /// <summary>
        /// Move the pointer to a viewport coordinate without clicking.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserMouseMoveInput? BrowserMouseMoveInput { get; init; }
#else
        public global::Anthropic.BetaBrowserMouseMoveInput? BrowserMouseMoveInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserMouseMoveInput))]
#endif
        public bool IsBrowserMouseMoveInput => BrowserMouseMoveInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserMouseMoveInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserMouseMoveInput? value)
        {
            value = BrowserMouseMoveInput;
            return IsBrowserMouseMoveInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserMouseMoveInput PickBrowserMouseMoveInput() => BrowserMouseMoveInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserMouseMoveInput' but the value was {ToString()}.");

        /// <summary>
        /// Scroll at a viewport position. `target` must be a coordinate target.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserScrollInput? BrowserScrollInput { get; init; }
#else
        public global::Anthropic.BetaBrowserScrollInput? BrowserScrollInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserScrollInput))]
#endif
        public bool IsBrowserScrollInput => BrowserScrollInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserScrollInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserScrollInput? value)
        {
            value = BrowserScrollInput;
            return IsBrowserScrollInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserScrollInput PickBrowserScrollInput() => BrowserScrollInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserScrollInput' but the value was {ToString()}.");

        /// <summary>
        /// Type a literal string at the current focus.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserTypeInput? BrowserTypeInput { get; init; }
#else
        public global::Anthropic.BetaBrowserTypeInput? BrowserTypeInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserTypeInput))]
#endif
        public bool IsBrowserTypeInput => BrowserTypeInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserTypeInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserTypeInput? value)
        {
            value = BrowserTypeInput;
            return IsBrowserTypeInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserTypeInput PickBrowserTypeInput() => BrowserTypeInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserTypeInput' but the value was {ToString()}.");

        /// <summary>
        /// Press a key or key chord. Use "+" to combine modifiers with a key (e.g. "ctrl+a",<br/>
        /// "cmd+shift+p") and space to sequence presses (e.g. "Backspace Backspace Delete").<br/>
        /// Common names like "Return", "Tab", "Escape", "BackSpace" are supported.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserKeyInput? BrowserKeyInput { get; init; }
#else
        public global::Anthropic.BetaBrowserKeyInput? BrowserKeyInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserKeyInput))]
#endif
        public bool IsBrowserKeyInput => BrowserKeyInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserKeyInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserKeyInput? value)
        {
            value = BrowserKeyInput;
            return IsBrowserKeyInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserKeyInput PickBrowserKeyInput() => BrowserKeyInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserKeyInput' but the value was {ToString()}.");

        /// <summary>
        /// Hold a key or key chord down for a duration, then release it. Uses the same key<br/>
        /// names and "+" chord syntax as the key action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserHoldKeyInput? BrowserHoldKeyInput { get; init; }
#else
        public global::Anthropic.BetaBrowserHoldKeyInput? BrowserHoldKeyInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserHoldKeyInput))]
#endif
        public bool IsBrowserHoldKeyInput => BrowserHoldKeyInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserHoldKeyInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserHoldKeyInput? value)
        {
            value = BrowserHoldKeyInput;
            return IsBrowserHoldKeyInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserHoldKeyInput PickBrowserHoldKeyInput() => BrowserHoldKeyInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserHoldKeyInput' but the value was {ToString()}.");

        /// <summary>
        /// Pause for the given duration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserWaitInput? BrowserWaitInput { get; init; }
#else
        public global::Anthropic.BetaBrowserWaitInput? BrowserWaitInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserWaitInput))]
#endif
        public bool IsBrowserWaitInput => BrowserWaitInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserWaitInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserWaitInput? value)
        {
            value = BrowserWaitInput;
            return IsBrowserWaitInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserWaitInput PickBrowserWaitInput() => BrowserWaitInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserWaitInput' but the value was {ToString()}.");

        /// <summary>
        /// Execute JavaScript in the page context and return the value of the last<br/>
        /// expression. The code runs with access to the DOM, `window`, and page variables.<br/>
        /// Write the expression you want evaluated — do NOT use `return`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserJavascriptExecInput? BrowserJavascriptExecInput { get; init; }
#else
        public global::Anthropic.BetaBrowserJavascriptExecInput? BrowserJavascriptExecInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserJavascriptExecInput))]
#endif
        public bool IsBrowserJavascriptExecInput => BrowserJavascriptExecInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserJavascriptExecInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserJavascriptExecInput? value)
        {
            value = BrowserJavascriptExecInput;
            return IsBrowserJavascriptExecInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserJavascriptExecInput PickBrowserJavascriptExecInput() => BrowserJavascriptExecInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserJavascriptExecInput' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserNavigateInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserNavigateInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserNavigateInput?(BetaBrowserMemberInput @this) => @this.BrowserNavigateInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserNavigateInput? value)
        {
            BrowserNavigateInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserNavigateInput(global::Anthropic.BetaBrowserNavigateInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserListTabsInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserListTabsInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserListTabsInput?(BetaBrowserMemberInput @this) => @this.BrowserListTabsInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserListTabsInput? value)
        {
            BrowserListTabsInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserListTabsInput(global::Anthropic.BetaBrowserListTabsInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserNewTabInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserNewTabInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserNewTabInput?(BetaBrowserMemberInput @this) => @this.BrowserNewTabInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserNewTabInput? value)
        {
            BrowserNewTabInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserNewTabInput(global::Anthropic.BetaBrowserNewTabInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserSwitchTabInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserSwitchTabInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserSwitchTabInput?(BetaBrowserMemberInput @this) => @this.BrowserSwitchTabInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserSwitchTabInput? value)
        {
            BrowserSwitchTabInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserSwitchTabInput(global::Anthropic.BetaBrowserSwitchTabInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserCloseTabInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserCloseTabInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserCloseTabInput?(BetaBrowserMemberInput @this) => @this.BrowserCloseTabInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserCloseTabInput? value)
        {
            BrowserCloseTabInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserCloseTabInput(global::Anthropic.BetaBrowserCloseTabInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserReadPageInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserReadPageInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserReadPageInput?(BetaBrowserMemberInput @this) => @this.BrowserReadPageInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserReadPageInput? value)
        {
            BrowserReadPageInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserReadPageInput(global::Anthropic.BetaBrowserReadPageInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserGetPageTextInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserGetPageTextInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserGetPageTextInput?(BetaBrowserMemberInput @this) => @this.BrowserGetPageTextInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserGetPageTextInput? value)
        {
            BrowserGetPageTextInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserGetPageTextInput(global::Anthropic.BetaBrowserGetPageTextInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserReadConsoleInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserReadConsoleInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserReadConsoleInput?(BetaBrowserMemberInput @this) => @this.BrowserReadConsoleInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserReadConsoleInput? value)
        {
            BrowserReadConsoleInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserReadConsoleInput(global::Anthropic.BetaBrowserReadConsoleInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserReadNetworkInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserReadNetworkInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserReadNetworkInput?(BetaBrowserMemberInput @this) => @this.BrowserReadNetworkInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserReadNetworkInput? value)
        {
            BrowserReadNetworkInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserReadNetworkInput(global::Anthropic.BetaBrowserReadNetworkInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserFindInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserFindInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserFindInput?(BetaBrowserMemberInput @this) => @this.BrowserFindInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserFindInput? value)
        {
            BrowserFindInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserFindInput(global::Anthropic.BetaBrowserFindInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserFormInputInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserFormInputInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserFormInputInput?(BetaBrowserMemberInput @this) => @this.BrowserFormInputInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserFormInputInput? value)
        {
            BrowserFormInputInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserFormInputInput(global::Anthropic.BetaBrowserFormInputInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserFileUploadInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserFileUploadInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserFileUploadInput?(BetaBrowserMemberInput @this) => @this.FileUpload;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserFileUploadInput? value)
        {
            FileUpload = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromFileUpload(global::Anthropic.BetaBrowserFileUploadInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserScrollToInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserScrollToInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserScrollToInput?(BetaBrowserMemberInput @this) => @this.BrowserScrollToInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserScrollToInput? value)
        {
            BrowserScrollToInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserScrollToInput(global::Anthropic.BetaBrowserScrollToInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserScreenshotInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserScreenshotInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserScreenshotInput?(BetaBrowserMemberInput @this) => @this.BrowserScreenshotInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserScreenshotInput? value)
        {
            BrowserScreenshotInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserScreenshotInput(global::Anthropic.BetaBrowserScreenshotInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserZoomInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserZoomInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserZoomInput?(BetaBrowserMemberInput @this) => @this.BrowserZoomInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserZoomInput? value)
        {
            BrowserZoomInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserZoomInput(global::Anthropic.BetaBrowserZoomInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserLeftClickInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserLeftClickInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserLeftClickInput?(BetaBrowserMemberInput @this) => @this.BrowserLeftClickInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserLeftClickInput? value)
        {
            BrowserLeftClickInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserLeftClickInput(global::Anthropic.BetaBrowserLeftClickInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserRightClickInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserRightClickInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserRightClickInput?(BetaBrowserMemberInput @this) => @this.BrowserRightClickInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserRightClickInput? value)
        {
            BrowserRightClickInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserRightClickInput(global::Anthropic.BetaBrowserRightClickInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserMiddleClickInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserMiddleClickInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserMiddleClickInput?(BetaBrowserMemberInput @this) => @this.BrowserMiddleClickInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserMiddleClickInput? value)
        {
            BrowserMiddleClickInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserMiddleClickInput(global::Anthropic.BetaBrowserMiddleClickInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserDoubleClickInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserDoubleClickInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserDoubleClickInput?(BetaBrowserMemberInput @this) => @this.BrowserDoubleClickInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserDoubleClickInput? value)
        {
            BrowserDoubleClickInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserDoubleClickInput(global::Anthropic.BetaBrowserDoubleClickInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserTripleClickInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserTripleClickInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserTripleClickInput?(BetaBrowserMemberInput @this) => @this.BrowserTripleClickInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserTripleClickInput? value)
        {
            BrowserTripleClickInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserTripleClickInput(global::Anthropic.BetaBrowserTripleClickInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserHoverInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserHoverInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserHoverInput?(BetaBrowserMemberInput @this) => @this.BrowserHoverInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserHoverInput? value)
        {
            BrowserHoverInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserHoverInput(global::Anthropic.BetaBrowserHoverInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserLeftClickDragInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserLeftClickDragInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserLeftClickDragInput?(BetaBrowserMemberInput @this) => @this.BrowserLeftClickDragInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserLeftClickDragInput? value)
        {
            BrowserLeftClickDragInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserLeftClickDragInput(global::Anthropic.BetaBrowserLeftClickDragInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserLeftMouseDownInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserLeftMouseDownInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserLeftMouseDownInput?(BetaBrowserMemberInput @this) => @this.BrowserLeftMouseDownInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserLeftMouseDownInput? value)
        {
            BrowserLeftMouseDownInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserLeftMouseDownInput(global::Anthropic.BetaBrowserLeftMouseDownInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserLeftMouseUpInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserLeftMouseUpInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserLeftMouseUpInput?(BetaBrowserMemberInput @this) => @this.BrowserLeftMouseUpInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserLeftMouseUpInput? value)
        {
            BrowserLeftMouseUpInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserLeftMouseUpInput(global::Anthropic.BetaBrowserLeftMouseUpInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserMouseMoveInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserMouseMoveInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserMouseMoveInput?(BetaBrowserMemberInput @this) => @this.BrowserMouseMoveInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserMouseMoveInput? value)
        {
            BrowserMouseMoveInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserMouseMoveInput(global::Anthropic.BetaBrowserMouseMoveInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserScrollInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserScrollInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserScrollInput?(BetaBrowserMemberInput @this) => @this.BrowserScrollInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserScrollInput? value)
        {
            BrowserScrollInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserScrollInput(global::Anthropic.BetaBrowserScrollInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserTypeInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserTypeInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserTypeInput?(BetaBrowserMemberInput @this) => @this.BrowserTypeInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserTypeInput? value)
        {
            BrowserTypeInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserTypeInput(global::Anthropic.BetaBrowserTypeInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserKeyInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserKeyInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserKeyInput?(BetaBrowserMemberInput @this) => @this.BrowserKeyInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserKeyInput? value)
        {
            BrowserKeyInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserKeyInput(global::Anthropic.BetaBrowserKeyInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserHoldKeyInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserHoldKeyInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserHoldKeyInput?(BetaBrowserMemberInput @this) => @this.BrowserHoldKeyInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserHoldKeyInput? value)
        {
            BrowserHoldKeyInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserHoldKeyInput(global::Anthropic.BetaBrowserHoldKeyInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserWaitInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserWaitInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserWaitInput?(BetaBrowserMemberInput @this) => @this.BrowserWaitInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserWaitInput? value)
        {
            BrowserWaitInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserWaitInput(global::Anthropic.BetaBrowserWaitInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserMemberInput(global::Anthropic.BetaBrowserJavascriptExecInput value) => new BetaBrowserMemberInput((global::Anthropic.BetaBrowserJavascriptExecInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserJavascriptExecInput?(BetaBrowserMemberInput @this) => @this.BrowserJavascriptExecInput;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(global::Anthropic.BetaBrowserJavascriptExecInput? value)
        {
            BrowserJavascriptExecInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserMemberInput FromBrowserJavascriptExecInput(global::Anthropic.BetaBrowserJavascriptExecInput? value) => new BetaBrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserMemberInput(
            global::Anthropic.BetaBrowserNavigateInput? browserNavigateInput,
            global::Anthropic.BetaBrowserListTabsInput? browserListTabsInput,
            global::Anthropic.BetaBrowserNewTabInput? browserNewTabInput,
            global::Anthropic.BetaBrowserSwitchTabInput? browserSwitchTabInput,
            global::Anthropic.BetaBrowserCloseTabInput? browserCloseTabInput,
            global::Anthropic.BetaBrowserReadPageInput? browserReadPageInput,
            global::Anthropic.BetaBrowserGetPageTextInput? browserGetPageTextInput,
            global::Anthropic.BetaBrowserReadConsoleInput? browserReadConsoleInput,
            global::Anthropic.BetaBrowserReadNetworkInput? browserReadNetworkInput,
            global::Anthropic.BetaBrowserFindInput? browserFindInput,
            global::Anthropic.BetaBrowserFormInputInput? browserFormInputInput,
            global::Anthropic.BetaBrowserFileUploadInput? fileUpload,
            global::Anthropic.BetaBrowserScrollToInput? browserScrollToInput,
            global::Anthropic.BetaBrowserScreenshotInput? browserScreenshotInput,
            global::Anthropic.BetaBrowserZoomInput? browserZoomInput,
            global::Anthropic.BetaBrowserLeftClickInput? browserLeftClickInput,
            global::Anthropic.BetaBrowserRightClickInput? browserRightClickInput,
            global::Anthropic.BetaBrowserMiddleClickInput? browserMiddleClickInput,
            global::Anthropic.BetaBrowserDoubleClickInput? browserDoubleClickInput,
            global::Anthropic.BetaBrowserTripleClickInput? browserTripleClickInput,
            global::Anthropic.BetaBrowserHoverInput? browserHoverInput,
            global::Anthropic.BetaBrowserLeftClickDragInput? browserLeftClickDragInput,
            global::Anthropic.BetaBrowserLeftMouseDownInput? browserLeftMouseDownInput,
            global::Anthropic.BetaBrowserLeftMouseUpInput? browserLeftMouseUpInput,
            global::Anthropic.BetaBrowserMouseMoveInput? browserMouseMoveInput,
            global::Anthropic.BetaBrowserScrollInput? browserScrollInput,
            global::Anthropic.BetaBrowserTypeInput? browserTypeInput,
            global::Anthropic.BetaBrowserKeyInput? browserKeyInput,
            global::Anthropic.BetaBrowserHoldKeyInput? browserHoldKeyInput,
            global::Anthropic.BetaBrowserWaitInput? browserWaitInput,
            global::Anthropic.BetaBrowserJavascriptExecInput? browserJavascriptExecInput
            )
        {
            BrowserNavigateInput = browserNavigateInput;
            BrowserListTabsInput = browserListTabsInput;
            BrowserNewTabInput = browserNewTabInput;
            BrowserSwitchTabInput = browserSwitchTabInput;
            BrowserCloseTabInput = browserCloseTabInput;
            BrowserReadPageInput = browserReadPageInput;
            BrowserGetPageTextInput = browserGetPageTextInput;
            BrowserReadConsoleInput = browserReadConsoleInput;
            BrowserReadNetworkInput = browserReadNetworkInput;
            BrowserFindInput = browserFindInput;
            BrowserFormInputInput = browserFormInputInput;
            FileUpload = fileUpload;
            BrowserScrollToInput = browserScrollToInput;
            BrowserScreenshotInput = browserScreenshotInput;
            BrowserZoomInput = browserZoomInput;
            BrowserLeftClickInput = browserLeftClickInput;
            BrowserRightClickInput = browserRightClickInput;
            BrowserMiddleClickInput = browserMiddleClickInput;
            BrowserDoubleClickInput = browserDoubleClickInput;
            BrowserTripleClickInput = browserTripleClickInput;
            BrowserHoverInput = browserHoverInput;
            BrowserLeftClickDragInput = browserLeftClickDragInput;
            BrowserLeftMouseDownInput = browserLeftMouseDownInput;
            BrowserLeftMouseUpInput = browserLeftMouseUpInput;
            BrowserMouseMoveInput = browserMouseMoveInput;
            BrowserScrollInput = browserScrollInput;
            BrowserTypeInput = browserTypeInput;
            BrowserKeyInput = browserKeyInput;
            BrowserHoldKeyInput = browserHoldKeyInput;
            BrowserWaitInput = browserWaitInput;
            BrowserJavascriptExecInput = browserJavascriptExecInput;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BrowserJavascriptExecInput as object ??
            BrowserWaitInput as object ??
            BrowserHoldKeyInput as object ??
            BrowserKeyInput as object ??
            BrowserTypeInput as object ??
            BrowserScrollInput as object ??
            BrowserMouseMoveInput as object ??
            BrowserLeftMouseUpInput as object ??
            BrowserLeftMouseDownInput as object ??
            BrowserLeftClickDragInput as object ??
            BrowserHoverInput as object ??
            BrowserTripleClickInput as object ??
            BrowserDoubleClickInput as object ??
            BrowserMiddleClickInput as object ??
            BrowserRightClickInput as object ??
            BrowserLeftClickInput as object ??
            BrowserZoomInput as object ??
            BrowserScreenshotInput as object ??
            BrowserScrollToInput as object ??
            FileUpload as object ??
            BrowserFormInputInput as object ??
            BrowserFindInput as object ??
            BrowserReadNetworkInput as object ??
            BrowserReadConsoleInput as object ??
            BrowserGetPageTextInput as object ??
            BrowserReadPageInput as object ??
            BrowserCloseTabInput as object ??
            BrowserSwitchTabInput as object ??
            BrowserNewTabInput as object ??
            BrowserListTabsInput as object ??
            BrowserNavigateInput as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BrowserNavigateInput?.ToString() ??
            BrowserListTabsInput?.ToString() ??
            BrowserNewTabInput?.ToString() ??
            BrowserSwitchTabInput?.ToString() ??
            BrowserCloseTabInput?.ToString() ??
            BrowserReadPageInput?.ToString() ??
            BrowserGetPageTextInput?.ToString() ??
            BrowserReadConsoleInput?.ToString() ??
            BrowserReadNetworkInput?.ToString() ??
            BrowserFindInput?.ToString() ??
            BrowserFormInputInput?.ToString() ??
            FileUpload?.ToString() ??
            BrowserScrollToInput?.ToString() ??
            BrowserScreenshotInput?.ToString() ??
            BrowserZoomInput?.ToString() ??
            BrowserLeftClickInput?.ToString() ??
            BrowserRightClickInput?.ToString() ??
            BrowserMiddleClickInput?.ToString() ??
            BrowserDoubleClickInput?.ToString() ??
            BrowserTripleClickInput?.ToString() ??
            BrowserHoverInput?.ToString() ??
            BrowserLeftClickDragInput?.ToString() ??
            BrowserLeftMouseDownInput?.ToString() ??
            BrowserLeftMouseUpInput?.ToString() ??
            BrowserMouseMoveInput?.ToString() ??
            BrowserScrollInput?.ToString() ??
            BrowserTypeInput?.ToString() ??
            BrowserKeyInput?.ToString() ??
            BrowserHoldKeyInput?.ToString() ??
            BrowserWaitInput?.ToString() ??
            BrowserJavascriptExecInput?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBrowserNavigateInput || IsBrowserListTabsInput || IsBrowserNewTabInput || IsBrowserSwitchTabInput || IsBrowserCloseTabInput || IsBrowserReadPageInput || IsBrowserGetPageTextInput || IsBrowserReadConsoleInput || IsBrowserReadNetworkInput || IsBrowserFindInput || IsBrowserFormInputInput || IsFileUpload || IsBrowserScrollToInput || IsBrowserScreenshotInput || IsBrowserZoomInput || IsBrowserLeftClickInput || IsBrowserRightClickInput || IsBrowserMiddleClickInput || IsBrowserDoubleClickInput || IsBrowserTripleClickInput || IsBrowserHoverInput || IsBrowserLeftClickDragInput || IsBrowserLeftMouseDownInput || IsBrowserLeftMouseUpInput || IsBrowserMouseMoveInput || IsBrowserScrollInput || IsBrowserTypeInput || IsBrowserKeyInput || IsBrowserHoldKeyInput || IsBrowserWaitInput || IsBrowserJavascriptExecInput;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaBrowserNavigateInput, TResult>? browserNavigateInput = null,
            global::System.Func<global::Anthropic.BetaBrowserListTabsInput, TResult>? browserListTabsInput = null,
            global::System.Func<global::Anthropic.BetaBrowserNewTabInput, TResult>? browserNewTabInput = null,
            global::System.Func<global::Anthropic.BetaBrowserSwitchTabInput, TResult>? browserSwitchTabInput = null,
            global::System.Func<global::Anthropic.BetaBrowserCloseTabInput, TResult>? browserCloseTabInput = null,
            global::System.Func<global::Anthropic.BetaBrowserReadPageInput, TResult>? browserReadPageInput = null,
            global::System.Func<global::Anthropic.BetaBrowserGetPageTextInput, TResult>? browserGetPageTextInput = null,
            global::System.Func<global::Anthropic.BetaBrowserReadConsoleInput, TResult>? browserReadConsoleInput = null,
            global::System.Func<global::Anthropic.BetaBrowserReadNetworkInput, TResult>? browserReadNetworkInput = null,
            global::System.Func<global::Anthropic.BetaBrowserFindInput, TResult>? browserFindInput = null,
            global::System.Func<global::Anthropic.BetaBrowserFormInputInput, TResult>? browserFormInputInput = null,
            global::System.Func<global::Anthropic.BetaBrowserFileUploadInput?, TResult>? fileUpload = null,
            global::System.Func<global::Anthropic.BetaBrowserScrollToInput, TResult>? browserScrollToInput = null,
            global::System.Func<global::Anthropic.BetaBrowserScreenshotInput, TResult>? browserScreenshotInput = null,
            global::System.Func<global::Anthropic.BetaBrowserZoomInput, TResult>? browserZoomInput = null,
            global::System.Func<global::Anthropic.BetaBrowserLeftClickInput, TResult>? browserLeftClickInput = null,
            global::System.Func<global::Anthropic.BetaBrowserRightClickInput, TResult>? browserRightClickInput = null,
            global::System.Func<global::Anthropic.BetaBrowserMiddleClickInput, TResult>? browserMiddleClickInput = null,
            global::System.Func<global::Anthropic.BetaBrowserDoubleClickInput, TResult>? browserDoubleClickInput = null,
            global::System.Func<global::Anthropic.BetaBrowserTripleClickInput, TResult>? browserTripleClickInput = null,
            global::System.Func<global::Anthropic.BetaBrowserHoverInput, TResult>? browserHoverInput = null,
            global::System.Func<global::Anthropic.BetaBrowserLeftClickDragInput, TResult>? browserLeftClickDragInput = null,
            global::System.Func<global::Anthropic.BetaBrowserLeftMouseDownInput, TResult>? browserLeftMouseDownInput = null,
            global::System.Func<global::Anthropic.BetaBrowserLeftMouseUpInput, TResult>? browserLeftMouseUpInput = null,
            global::System.Func<global::Anthropic.BetaBrowserMouseMoveInput, TResult>? browserMouseMoveInput = null,
            global::System.Func<global::Anthropic.BetaBrowserScrollInput, TResult>? browserScrollInput = null,
            global::System.Func<global::Anthropic.BetaBrowserTypeInput, TResult>? browserTypeInput = null,
            global::System.Func<global::Anthropic.BetaBrowserKeyInput, TResult>? browserKeyInput = null,
            global::System.Func<global::Anthropic.BetaBrowserHoldKeyInput, TResult>? browserHoldKeyInput = null,
            global::System.Func<global::Anthropic.BetaBrowserWaitInput, TResult>? browserWaitInput = null,
            global::System.Func<global::Anthropic.BetaBrowserJavascriptExecInput, TResult>? browserJavascriptExecInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BrowserNavigateInput is { } __value0 && browserNavigateInput != null)
            {
                return browserNavigateInput(__value0);
            }
            else if (BrowserListTabsInput is { } __value1 && browserListTabsInput != null)
            {
                return browserListTabsInput(__value1);
            }
            else if (BrowserNewTabInput is { } __value2 && browserNewTabInput != null)
            {
                return browserNewTabInput(__value2);
            }
            else if (BrowserSwitchTabInput is { } __value3 && browserSwitchTabInput != null)
            {
                return browserSwitchTabInput(__value3);
            }
            else if (BrowserCloseTabInput is { } __value4 && browserCloseTabInput != null)
            {
                return browserCloseTabInput(__value4);
            }
            else if (BrowserReadPageInput is { } __value5 && browserReadPageInput != null)
            {
                return browserReadPageInput(__value5);
            }
            else if (BrowserGetPageTextInput is { } __value6 && browserGetPageTextInput != null)
            {
                return browserGetPageTextInput(__value6);
            }
            else if (BrowserReadConsoleInput is { } __value7 && browserReadConsoleInput != null)
            {
                return browserReadConsoleInput(__value7);
            }
            else if (BrowserReadNetworkInput is { } __value8 && browserReadNetworkInput != null)
            {
                return browserReadNetworkInput(__value8);
            }
            else if (BrowserFindInput is { } __value9 && browserFindInput != null)
            {
                return browserFindInput(__value9);
            }
            else if (BrowserFormInputInput is { } __value10 && browserFormInputInput != null)
            {
                return browserFormInputInput(__value10);
            }
            else if (FileUpload is { } __value11 && fileUpload != null)
            {
                return fileUpload(__value11);
            }
            else if (BrowserScrollToInput is { } __value12 && browserScrollToInput != null)
            {
                return browserScrollToInput(__value12);
            }
            else if (BrowserScreenshotInput is { } __value13 && browserScreenshotInput != null)
            {
                return browserScreenshotInput(__value13);
            }
            else if (BrowserZoomInput is { } __value14 && browserZoomInput != null)
            {
                return browserZoomInput(__value14);
            }
            else if (BrowserLeftClickInput is { } __value15 && browserLeftClickInput != null)
            {
                return browserLeftClickInput(__value15);
            }
            else if (BrowserRightClickInput is { } __value16 && browserRightClickInput != null)
            {
                return browserRightClickInput(__value16);
            }
            else if (BrowserMiddleClickInput is { } __value17 && browserMiddleClickInput != null)
            {
                return browserMiddleClickInput(__value17);
            }
            else if (BrowserDoubleClickInput is { } __value18 && browserDoubleClickInput != null)
            {
                return browserDoubleClickInput(__value18);
            }
            else if (BrowserTripleClickInput is { } __value19 && browserTripleClickInput != null)
            {
                return browserTripleClickInput(__value19);
            }
            else if (BrowserHoverInput is { } __value20 && browserHoverInput != null)
            {
                return browserHoverInput(__value20);
            }
            else if (BrowserLeftClickDragInput is { } __value21 && browserLeftClickDragInput != null)
            {
                return browserLeftClickDragInput(__value21);
            }
            else if (BrowserLeftMouseDownInput is { } __value22 && browserLeftMouseDownInput != null)
            {
                return browserLeftMouseDownInput(__value22);
            }
            else if (BrowserLeftMouseUpInput is { } __value23 && browserLeftMouseUpInput != null)
            {
                return browserLeftMouseUpInput(__value23);
            }
            else if (BrowserMouseMoveInput is { } __value24 && browserMouseMoveInput != null)
            {
                return browserMouseMoveInput(__value24);
            }
            else if (BrowserScrollInput is { } __value25 && browserScrollInput != null)
            {
                return browserScrollInput(__value25);
            }
            else if (BrowserTypeInput is { } __value26 && browserTypeInput != null)
            {
                return browserTypeInput(__value26);
            }
            else if (BrowserKeyInput is { } __value27 && browserKeyInput != null)
            {
                return browserKeyInput(__value27);
            }
            else if (BrowserHoldKeyInput is { } __value28 && browserHoldKeyInput != null)
            {
                return browserHoldKeyInput(__value28);
            }
            else if (BrowserWaitInput is { } __value29 && browserWaitInput != null)
            {
                return browserWaitInput(__value29);
            }
            else if (BrowserJavascriptExecInput is { } __value30 && browserJavascriptExecInput != null)
            {
                return browserJavascriptExecInput(__value30);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaBrowserNavigateInput>? browserNavigateInput = null,

            global::System.Action<global::Anthropic.BetaBrowserListTabsInput>? browserListTabsInput = null,

            global::System.Action<global::Anthropic.BetaBrowserNewTabInput>? browserNewTabInput = null,

            global::System.Action<global::Anthropic.BetaBrowserSwitchTabInput>? browserSwitchTabInput = null,

            global::System.Action<global::Anthropic.BetaBrowserCloseTabInput>? browserCloseTabInput = null,

            global::System.Action<global::Anthropic.BetaBrowserReadPageInput>? browserReadPageInput = null,

            global::System.Action<global::Anthropic.BetaBrowserGetPageTextInput>? browserGetPageTextInput = null,

            global::System.Action<global::Anthropic.BetaBrowserReadConsoleInput>? browserReadConsoleInput = null,

            global::System.Action<global::Anthropic.BetaBrowserReadNetworkInput>? browserReadNetworkInput = null,

            global::System.Action<global::Anthropic.BetaBrowserFindInput>? browserFindInput = null,

            global::System.Action<global::Anthropic.BetaBrowserFormInputInput>? browserFormInputInput = null,

            global::System.Action<global::Anthropic.BetaBrowserFileUploadInput?>? fileUpload = null,

            global::System.Action<global::Anthropic.BetaBrowserScrollToInput>? browserScrollToInput = null,

            global::System.Action<global::Anthropic.BetaBrowserScreenshotInput>? browserScreenshotInput = null,

            global::System.Action<global::Anthropic.BetaBrowserZoomInput>? browserZoomInput = null,

            global::System.Action<global::Anthropic.BetaBrowserLeftClickInput>? browserLeftClickInput = null,

            global::System.Action<global::Anthropic.BetaBrowserRightClickInput>? browserRightClickInput = null,

            global::System.Action<global::Anthropic.BetaBrowserMiddleClickInput>? browserMiddleClickInput = null,

            global::System.Action<global::Anthropic.BetaBrowserDoubleClickInput>? browserDoubleClickInput = null,

            global::System.Action<global::Anthropic.BetaBrowserTripleClickInput>? browserTripleClickInput = null,

            global::System.Action<global::Anthropic.BetaBrowserHoverInput>? browserHoverInput = null,

            global::System.Action<global::Anthropic.BetaBrowserLeftClickDragInput>? browserLeftClickDragInput = null,

            global::System.Action<global::Anthropic.BetaBrowserLeftMouseDownInput>? browserLeftMouseDownInput = null,

            global::System.Action<global::Anthropic.BetaBrowserLeftMouseUpInput>? browserLeftMouseUpInput = null,

            global::System.Action<global::Anthropic.BetaBrowserMouseMoveInput>? browserMouseMoveInput = null,

            global::System.Action<global::Anthropic.BetaBrowserScrollInput>? browserScrollInput = null,

            global::System.Action<global::Anthropic.BetaBrowserTypeInput>? browserTypeInput = null,

            global::System.Action<global::Anthropic.BetaBrowserKeyInput>? browserKeyInput = null,

            global::System.Action<global::Anthropic.BetaBrowserHoldKeyInput>? browserHoldKeyInput = null,

            global::System.Action<global::Anthropic.BetaBrowserWaitInput>? browserWaitInput = null,

            global::System.Action<global::Anthropic.BetaBrowserJavascriptExecInput>? browserJavascriptExecInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BrowserNavigateInput is { } __value0)
            {
                browserNavigateInput?.Invoke(__value0);
            }
            else if (BrowserListTabsInput is { } __value1)
            {
                browserListTabsInput?.Invoke(__value1);
            }
            else if (BrowserNewTabInput is { } __value2)
            {
                browserNewTabInput?.Invoke(__value2);
            }
            else if (BrowserSwitchTabInput is { } __value3)
            {
                browserSwitchTabInput?.Invoke(__value3);
            }
            else if (BrowserCloseTabInput is { } __value4)
            {
                browserCloseTabInput?.Invoke(__value4);
            }
            else if (BrowserReadPageInput is { } __value5)
            {
                browserReadPageInput?.Invoke(__value5);
            }
            else if (BrowserGetPageTextInput is { } __value6)
            {
                browserGetPageTextInput?.Invoke(__value6);
            }
            else if (BrowserReadConsoleInput is { } __value7)
            {
                browserReadConsoleInput?.Invoke(__value7);
            }
            else if (BrowserReadNetworkInput is { } __value8)
            {
                browserReadNetworkInput?.Invoke(__value8);
            }
            else if (BrowserFindInput is { } __value9)
            {
                browserFindInput?.Invoke(__value9);
            }
            else if (BrowserFormInputInput is { } __value10)
            {
                browserFormInputInput?.Invoke(__value10);
            }
            else if (FileUpload is { } __value11)
            {
                fileUpload?.Invoke(__value11);
            }
            else if (BrowserScrollToInput is { } __value12)
            {
                browserScrollToInput?.Invoke(__value12);
            }
            else if (BrowserScreenshotInput is { } __value13)
            {
                browserScreenshotInput?.Invoke(__value13);
            }
            else if (BrowserZoomInput is { } __value14)
            {
                browserZoomInput?.Invoke(__value14);
            }
            else if (BrowserLeftClickInput is { } __value15)
            {
                browserLeftClickInput?.Invoke(__value15);
            }
            else if (BrowserRightClickInput is { } __value16)
            {
                browserRightClickInput?.Invoke(__value16);
            }
            else if (BrowserMiddleClickInput is { } __value17)
            {
                browserMiddleClickInput?.Invoke(__value17);
            }
            else if (BrowserDoubleClickInput is { } __value18)
            {
                browserDoubleClickInput?.Invoke(__value18);
            }
            else if (BrowserTripleClickInput is { } __value19)
            {
                browserTripleClickInput?.Invoke(__value19);
            }
            else if (BrowserHoverInput is { } __value20)
            {
                browserHoverInput?.Invoke(__value20);
            }
            else if (BrowserLeftClickDragInput is { } __value21)
            {
                browserLeftClickDragInput?.Invoke(__value21);
            }
            else if (BrowserLeftMouseDownInput is { } __value22)
            {
                browserLeftMouseDownInput?.Invoke(__value22);
            }
            else if (BrowserLeftMouseUpInput is { } __value23)
            {
                browserLeftMouseUpInput?.Invoke(__value23);
            }
            else if (BrowserMouseMoveInput is { } __value24)
            {
                browserMouseMoveInput?.Invoke(__value24);
            }
            else if (BrowserScrollInput is { } __value25)
            {
                browserScrollInput?.Invoke(__value25);
            }
            else if (BrowserTypeInput is { } __value26)
            {
                browserTypeInput?.Invoke(__value26);
            }
            else if (BrowserKeyInput is { } __value27)
            {
                browserKeyInput?.Invoke(__value27);
            }
            else if (BrowserHoldKeyInput is { } __value28)
            {
                browserHoldKeyInput?.Invoke(__value28);
            }
            else if (BrowserWaitInput is { } __value29)
            {
                browserWaitInput?.Invoke(__value29);
            }
            else if (BrowserJavascriptExecInput is { } __value30)
            {
                browserJavascriptExecInput?.Invoke(__value30);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaBrowserNavigateInput>? browserNavigateInput = null,
            global::System.Action<global::Anthropic.BetaBrowserListTabsInput>? browserListTabsInput = null,
            global::System.Action<global::Anthropic.BetaBrowserNewTabInput>? browserNewTabInput = null,
            global::System.Action<global::Anthropic.BetaBrowserSwitchTabInput>? browserSwitchTabInput = null,
            global::System.Action<global::Anthropic.BetaBrowserCloseTabInput>? browserCloseTabInput = null,
            global::System.Action<global::Anthropic.BetaBrowserReadPageInput>? browserReadPageInput = null,
            global::System.Action<global::Anthropic.BetaBrowserGetPageTextInput>? browserGetPageTextInput = null,
            global::System.Action<global::Anthropic.BetaBrowserReadConsoleInput>? browserReadConsoleInput = null,
            global::System.Action<global::Anthropic.BetaBrowserReadNetworkInput>? browserReadNetworkInput = null,
            global::System.Action<global::Anthropic.BetaBrowserFindInput>? browserFindInput = null,
            global::System.Action<global::Anthropic.BetaBrowserFormInputInput>? browserFormInputInput = null,
            global::System.Action<global::Anthropic.BetaBrowserFileUploadInput?>? fileUpload = null,
            global::System.Action<global::Anthropic.BetaBrowserScrollToInput>? browserScrollToInput = null,
            global::System.Action<global::Anthropic.BetaBrowserScreenshotInput>? browserScreenshotInput = null,
            global::System.Action<global::Anthropic.BetaBrowserZoomInput>? browserZoomInput = null,
            global::System.Action<global::Anthropic.BetaBrowserLeftClickInput>? browserLeftClickInput = null,
            global::System.Action<global::Anthropic.BetaBrowserRightClickInput>? browserRightClickInput = null,
            global::System.Action<global::Anthropic.BetaBrowserMiddleClickInput>? browserMiddleClickInput = null,
            global::System.Action<global::Anthropic.BetaBrowserDoubleClickInput>? browserDoubleClickInput = null,
            global::System.Action<global::Anthropic.BetaBrowserTripleClickInput>? browserTripleClickInput = null,
            global::System.Action<global::Anthropic.BetaBrowserHoverInput>? browserHoverInput = null,
            global::System.Action<global::Anthropic.BetaBrowserLeftClickDragInput>? browserLeftClickDragInput = null,
            global::System.Action<global::Anthropic.BetaBrowserLeftMouseDownInput>? browserLeftMouseDownInput = null,
            global::System.Action<global::Anthropic.BetaBrowserLeftMouseUpInput>? browserLeftMouseUpInput = null,
            global::System.Action<global::Anthropic.BetaBrowserMouseMoveInput>? browserMouseMoveInput = null,
            global::System.Action<global::Anthropic.BetaBrowserScrollInput>? browserScrollInput = null,
            global::System.Action<global::Anthropic.BetaBrowserTypeInput>? browserTypeInput = null,
            global::System.Action<global::Anthropic.BetaBrowserKeyInput>? browserKeyInput = null,
            global::System.Action<global::Anthropic.BetaBrowserHoldKeyInput>? browserHoldKeyInput = null,
            global::System.Action<global::Anthropic.BetaBrowserWaitInput>? browserWaitInput = null,
            global::System.Action<global::Anthropic.BetaBrowserJavascriptExecInput>? browserJavascriptExecInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BrowserNavigateInput is { } __value0)
            {
                browserNavigateInput?.Invoke(__value0);
            }
            else if (BrowserListTabsInput is { } __value1)
            {
                browserListTabsInput?.Invoke(__value1);
            }
            else if (BrowserNewTabInput is { } __value2)
            {
                browserNewTabInput?.Invoke(__value2);
            }
            else if (BrowserSwitchTabInput is { } __value3)
            {
                browserSwitchTabInput?.Invoke(__value3);
            }
            else if (BrowserCloseTabInput is { } __value4)
            {
                browserCloseTabInput?.Invoke(__value4);
            }
            else if (BrowserReadPageInput is { } __value5)
            {
                browserReadPageInput?.Invoke(__value5);
            }
            else if (BrowserGetPageTextInput is { } __value6)
            {
                browserGetPageTextInput?.Invoke(__value6);
            }
            else if (BrowserReadConsoleInput is { } __value7)
            {
                browserReadConsoleInput?.Invoke(__value7);
            }
            else if (BrowserReadNetworkInput is { } __value8)
            {
                browserReadNetworkInput?.Invoke(__value8);
            }
            else if (BrowserFindInput is { } __value9)
            {
                browserFindInput?.Invoke(__value9);
            }
            else if (BrowserFormInputInput is { } __value10)
            {
                browserFormInputInput?.Invoke(__value10);
            }
            else if (FileUpload is { } __value11)
            {
                fileUpload?.Invoke(__value11);
            }
            else if (BrowserScrollToInput is { } __value12)
            {
                browserScrollToInput?.Invoke(__value12);
            }
            else if (BrowserScreenshotInput is { } __value13)
            {
                browserScreenshotInput?.Invoke(__value13);
            }
            else if (BrowserZoomInput is { } __value14)
            {
                browserZoomInput?.Invoke(__value14);
            }
            else if (BrowserLeftClickInput is { } __value15)
            {
                browserLeftClickInput?.Invoke(__value15);
            }
            else if (BrowserRightClickInput is { } __value16)
            {
                browserRightClickInput?.Invoke(__value16);
            }
            else if (BrowserMiddleClickInput is { } __value17)
            {
                browserMiddleClickInput?.Invoke(__value17);
            }
            else if (BrowserDoubleClickInput is { } __value18)
            {
                browserDoubleClickInput?.Invoke(__value18);
            }
            else if (BrowserTripleClickInput is { } __value19)
            {
                browserTripleClickInput?.Invoke(__value19);
            }
            else if (BrowserHoverInput is { } __value20)
            {
                browserHoverInput?.Invoke(__value20);
            }
            else if (BrowserLeftClickDragInput is { } __value21)
            {
                browserLeftClickDragInput?.Invoke(__value21);
            }
            else if (BrowserLeftMouseDownInput is { } __value22)
            {
                browserLeftMouseDownInput?.Invoke(__value22);
            }
            else if (BrowserLeftMouseUpInput is { } __value23)
            {
                browserLeftMouseUpInput?.Invoke(__value23);
            }
            else if (BrowserMouseMoveInput is { } __value24)
            {
                browserMouseMoveInput?.Invoke(__value24);
            }
            else if (BrowserScrollInput is { } __value25)
            {
                browserScrollInput?.Invoke(__value25);
            }
            else if (BrowserTypeInput is { } __value26)
            {
                browserTypeInput?.Invoke(__value26);
            }
            else if (BrowserKeyInput is { } __value27)
            {
                browserKeyInput?.Invoke(__value27);
            }
            else if (BrowserHoldKeyInput is { } __value28)
            {
                browserHoldKeyInput?.Invoke(__value28);
            }
            else if (BrowserWaitInput is { } __value29)
            {
                browserWaitInput?.Invoke(__value29);
            }
            else if (BrowserJavascriptExecInput is { } __value30)
            {
                browserJavascriptExecInput?.Invoke(__value30);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BrowserNavigateInput,
                typeof(global::Anthropic.BetaBrowserNavigateInput),
                BrowserListTabsInput,
                typeof(global::Anthropic.BetaBrowserListTabsInput),
                BrowserNewTabInput,
                typeof(global::Anthropic.BetaBrowserNewTabInput),
                BrowserSwitchTabInput,
                typeof(global::Anthropic.BetaBrowserSwitchTabInput),
                BrowserCloseTabInput,
                typeof(global::Anthropic.BetaBrowserCloseTabInput),
                BrowserReadPageInput,
                typeof(global::Anthropic.BetaBrowserReadPageInput),
                BrowserGetPageTextInput,
                typeof(global::Anthropic.BetaBrowserGetPageTextInput),
                BrowserReadConsoleInput,
                typeof(global::Anthropic.BetaBrowserReadConsoleInput),
                BrowserReadNetworkInput,
                typeof(global::Anthropic.BetaBrowserReadNetworkInput),
                BrowserFindInput,
                typeof(global::Anthropic.BetaBrowserFindInput),
                BrowserFormInputInput,
                typeof(global::Anthropic.BetaBrowserFormInputInput),
                FileUpload,
                typeof(global::Anthropic.BetaBrowserFileUploadInput),
                BrowserScrollToInput,
                typeof(global::Anthropic.BetaBrowserScrollToInput),
                BrowserScreenshotInput,
                typeof(global::Anthropic.BetaBrowserScreenshotInput),
                BrowserZoomInput,
                typeof(global::Anthropic.BetaBrowserZoomInput),
                BrowserLeftClickInput,
                typeof(global::Anthropic.BetaBrowserLeftClickInput),
                BrowserRightClickInput,
                typeof(global::Anthropic.BetaBrowserRightClickInput),
                BrowserMiddleClickInput,
                typeof(global::Anthropic.BetaBrowserMiddleClickInput),
                BrowserDoubleClickInput,
                typeof(global::Anthropic.BetaBrowserDoubleClickInput),
                BrowserTripleClickInput,
                typeof(global::Anthropic.BetaBrowserTripleClickInput),
                BrowserHoverInput,
                typeof(global::Anthropic.BetaBrowserHoverInput),
                BrowserLeftClickDragInput,
                typeof(global::Anthropic.BetaBrowserLeftClickDragInput),
                BrowserLeftMouseDownInput,
                typeof(global::Anthropic.BetaBrowserLeftMouseDownInput),
                BrowserLeftMouseUpInput,
                typeof(global::Anthropic.BetaBrowserLeftMouseUpInput),
                BrowserMouseMoveInput,
                typeof(global::Anthropic.BetaBrowserMouseMoveInput),
                BrowserScrollInput,
                typeof(global::Anthropic.BetaBrowserScrollInput),
                BrowserTypeInput,
                typeof(global::Anthropic.BetaBrowserTypeInput),
                BrowserKeyInput,
                typeof(global::Anthropic.BetaBrowserKeyInput),
                BrowserHoldKeyInput,
                typeof(global::Anthropic.BetaBrowserHoldKeyInput),
                BrowserWaitInput,
                typeof(global::Anthropic.BetaBrowserWaitInput),
                BrowserJavascriptExecInput,
                typeof(global::Anthropic.BetaBrowserJavascriptExecInput),
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
        public bool Equals(BetaBrowserMemberInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserNavigateInput?>.Default.Equals(BrowserNavigateInput, other.BrowserNavigateInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserListTabsInput?>.Default.Equals(BrowserListTabsInput, other.BrowserListTabsInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserNewTabInput?>.Default.Equals(BrowserNewTabInput, other.BrowserNewTabInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserSwitchTabInput?>.Default.Equals(BrowserSwitchTabInput, other.BrowserSwitchTabInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserCloseTabInput?>.Default.Equals(BrowserCloseTabInput, other.BrowserCloseTabInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserReadPageInput?>.Default.Equals(BrowserReadPageInput, other.BrowserReadPageInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserGetPageTextInput?>.Default.Equals(BrowserGetPageTextInput, other.BrowserGetPageTextInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserReadConsoleInput?>.Default.Equals(BrowserReadConsoleInput, other.BrowserReadConsoleInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserReadNetworkInput?>.Default.Equals(BrowserReadNetworkInput, other.BrowserReadNetworkInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserFindInput?>.Default.Equals(BrowserFindInput, other.BrowserFindInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserFormInputInput?>.Default.Equals(BrowserFormInputInput, other.BrowserFormInputInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserFileUploadInput?>.Default.Equals(FileUpload, other.FileUpload) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserScrollToInput?>.Default.Equals(BrowserScrollToInput, other.BrowserScrollToInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserScreenshotInput?>.Default.Equals(BrowserScreenshotInput, other.BrowserScreenshotInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserZoomInput?>.Default.Equals(BrowserZoomInput, other.BrowserZoomInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserLeftClickInput?>.Default.Equals(BrowserLeftClickInput, other.BrowserLeftClickInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserRightClickInput?>.Default.Equals(BrowserRightClickInput, other.BrowserRightClickInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserMiddleClickInput?>.Default.Equals(BrowserMiddleClickInput, other.BrowserMiddleClickInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserDoubleClickInput?>.Default.Equals(BrowserDoubleClickInput, other.BrowserDoubleClickInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserTripleClickInput?>.Default.Equals(BrowserTripleClickInput, other.BrowserTripleClickInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserHoverInput?>.Default.Equals(BrowserHoverInput, other.BrowserHoverInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserLeftClickDragInput?>.Default.Equals(BrowserLeftClickDragInput, other.BrowserLeftClickDragInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserLeftMouseDownInput?>.Default.Equals(BrowserLeftMouseDownInput, other.BrowserLeftMouseDownInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserLeftMouseUpInput?>.Default.Equals(BrowserLeftMouseUpInput, other.BrowserLeftMouseUpInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserMouseMoveInput?>.Default.Equals(BrowserMouseMoveInput, other.BrowserMouseMoveInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserScrollInput?>.Default.Equals(BrowserScrollInput, other.BrowserScrollInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserTypeInput?>.Default.Equals(BrowserTypeInput, other.BrowserTypeInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserKeyInput?>.Default.Equals(BrowserKeyInput, other.BrowserKeyInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserHoldKeyInput?>.Default.Equals(BrowserHoldKeyInput, other.BrowserHoldKeyInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserWaitInput?>.Default.Equals(BrowserWaitInput, other.BrowserWaitInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserJavascriptExecInput?>.Default.Equals(BrowserJavascriptExecInput, other.BrowserJavascriptExecInput)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaBrowserMemberInput obj1, BetaBrowserMemberInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaBrowserMemberInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaBrowserMemberInput obj1, BetaBrowserMemberInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaBrowserMemberInput o && Equals(o);
        }
    }
}
