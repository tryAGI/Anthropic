#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The `input` of a browser toolset member `tool_use` block: the member's own parameters.
    /// </summary>
    public readonly partial struct BrowserMemberInput : global::System.IEquatable<BrowserMemberInput>
    {
        /// <summary>
        /// Navigate to a URL, or go back/forward/reload in history. The protocol may be<br/>
        /// omitted (defaults to https://).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserNavigateInput? BrowserNavigateInput { get; init; }
#else
        public global::Anthropic.BrowserNavigateInput? BrowserNavigateInput { get; }
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
            out global::Anthropic.BrowserNavigateInput? value)
        {
            value = BrowserNavigateInput;
            return IsBrowserNavigateInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNavigateInput PickBrowserNavigateInput() => BrowserNavigateInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserNavigateInput' but the value was {ToString()}.");

        /// <summary>
        /// List all open tabs with each tab's tab_id, title, and URL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserListTabsInput? BrowserListTabsInput { get; init; }
#else
        public global::Anthropic.BrowserListTabsInput? BrowserListTabsInput { get; }
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
            out global::Anthropic.BrowserListTabsInput? value)
        {
            value = BrowserListTabsInput;
            return IsBrowserListTabsInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserListTabsInput PickBrowserListTabsInput() => BrowserListTabsInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserListTabsInput' but the value was {ToString()}.");

        /// <summary>
        /// Open a new empty tab and return its tab_id.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserNewTabInput? BrowserNewTabInput { get; init; }
#else
        public global::Anthropic.BrowserNewTabInput? BrowserNewTabInput { get; }
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
            out global::Anthropic.BrowserNewTabInput? value)
        {
            value = BrowserNewTabInput;
            return IsBrowserNewTabInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserNewTabInput PickBrowserNewTabInput() => BrowserNewTabInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserNewTabInput' but the value was {ToString()}.");

        /// <summary>
        /// Make the tab with the given tab_id the active tab — the tab that actions without<br/>
        /// a tab_id apply to.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserSwitchTabInput? BrowserSwitchTabInput { get; init; }
#else
        public global::Anthropic.BrowserSwitchTabInput? BrowserSwitchTabInput { get; }
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
            out global::Anthropic.BrowserSwitchTabInput? value)
        {
            value = BrowserSwitchTabInput;
            return IsBrowserSwitchTabInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserSwitchTabInput PickBrowserSwitchTabInput() => BrowserSwitchTabInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserSwitchTabInput' but the value was {ToString()}.");

        /// <summary>
        /// Close the tab with the given tab_id.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserCloseTabInput? BrowserCloseTabInput { get; init; }
#else
        public global::Anthropic.BrowserCloseTabInput? BrowserCloseTabInput { get; }
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
            out global::Anthropic.BrowserCloseTabInput? value)
        {
            value = BrowserCloseTabInput;
            return IsBrowserCloseTabInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserCloseTabInput PickBrowserCloseTabInput() => BrowserCloseTabInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserCloseTabInput' but the value was {ToString()}.");

        /// <summary>
        /// Return a structured accessibility tree of the page (or the subtree rooted at<br/>
        /// `ref`), with element references like [ref_7] that can be used as targets on later<br/>
        /// actions. Output is capped at 50,000 characters — narrow with `ref` or a smaller<br/>
        /// `depth` when exceeded.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserReadPageInput? BrowserReadPageInput { get; init; }
#else
        public global::Anthropic.BrowserReadPageInput? BrowserReadPageInput { get; }
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
            out global::Anthropic.BrowserReadPageInput? value)
        {
            value = BrowserReadPageInput;
            return IsBrowserReadPageInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadPageInput PickBrowserReadPageInput() => BrowserReadPageInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserReadPageInput' but the value was {ToString()}.");

        /// <summary>
        /// Return the page's visible text content as plain text, prioritizing article<br/>
        /// content. Suited to articles, documentation, and other text-heavy pages.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserGetPageTextInput? BrowserGetPageTextInput { get; init; }
#else
        public global::Anthropic.BrowserGetPageTextInput? BrowserGetPageTextInput { get; }
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
            out global::Anthropic.BrowserGetPageTextInput? value)
        {
            value = BrowserGetPageTextInput;
            return IsBrowserGetPageTextInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserGetPageTextInput PickBrowserGetPageTextInput() => BrowserGetPageTextInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserGetPageTextInput' but the value was {ToString()}.");

        /// <summary>
        /// Return console output (log entries, errors, warnings) accumulated since the<br/>
        /// driver attached to the tab and since the last read, one line per entry. An empty<br/>
        /// result does not mean no traffic for a tab that predates attach.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserReadConsoleInput? BrowserReadConsoleInput { get; init; }
#else
        public global::Anthropic.BrowserReadConsoleInput? BrowserReadConsoleInput { get; }
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
            out global::Anthropic.BrowserReadConsoleInput? value)
        {
            value = BrowserReadConsoleInput;
            return IsBrowserReadConsoleInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadConsoleInput PickBrowserReadConsoleInput() => BrowserReadConsoleInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserReadConsoleInput' but the value was {ToString()}.");

        /// <summary>
        /// Return the network requests (method, URL, status, MIME type, timing) recorded<br/>
        /// since the driver attached to the tab and since the last read, one line per entry.<br/>
        /// An empty result does not mean no traffic for a tab that predates attach.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserReadNetworkInput? BrowserReadNetworkInput { get; init; }
#else
        public global::Anthropic.BrowserReadNetworkInput? BrowserReadNetworkInput { get; }
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
            out global::Anthropic.BrowserReadNetworkInput? value)
        {
            value = BrowserReadNetworkInput;
            return IsBrowserReadNetworkInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserReadNetworkInput PickBrowserReadNetworkInput() => BrowserReadNetworkInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserReadNetworkInput' but the value was {ToString()}.");

        /// <summary>
        /// Find elements matching a natural-language description (e.g. "search bar", "add to<br/>
        /// cart button") and return up to 20 matches with element references.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserFindInput? BrowserFindInput { get; init; }
#else
        public global::Anthropic.BrowserFindInput? BrowserFindInput { get; }
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
            out global::Anthropic.BrowserFindInput? value)
        {
            value = BrowserFindInput;
            return IsBrowserFindInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFindInput PickBrowserFindInput() => BrowserFindInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserFindInput' but the value was {ToString()}.");

        /// <summary>
        /// Set the value of a form element (input, textarea, select, checkbox). Use a<br/>
        /// boolean for checkboxes, an option value or text for selects.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserFormInputInput? BrowserFormInputInput { get; init; }
#else
        public global::Anthropic.BrowserFormInputInput? BrowserFormInputInput { get; }
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
            out global::Anthropic.BrowserFormInputInput? value)
        {
            value = BrowserFormInputInput;
            return IsBrowserFormInputInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFormInputInput PickBrowserFormInputInput() => BrowserFormInputInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserFormInputInput' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserFileUploadInput? FileUpload { get; init; }
#else
        public global::Anthropic.BrowserFileUploadInput? FileUpload { get; }
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
            out global::Anthropic.BrowserFileUploadInput? value)
        {
            value = FileUpload;
            return IsFileUpload;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserFileUploadInput PickFileUpload() => FileUpload is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileUpload' but the value was {ToString()}.");

        /// <summary>
        /// Scroll an element into view.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserScrollToInput? BrowserScrollToInput { get; init; }
#else
        public global::Anthropic.BrowserScrollToInput? BrowserScrollToInput { get; }
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
            out global::Anthropic.BrowserScrollToInput? value)
        {
            value = BrowserScrollToInput;
            return IsBrowserScrollToInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollToInput PickBrowserScrollToInput() => BrowserScrollToInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserScrollToInput' but the value was {ToString()}.");

        /// <summary>
        /// Capture the current browser viewport.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserScreenshotInput? BrowserScreenshotInput { get; init; }
#else
        public global::Anthropic.BrowserScreenshotInput? BrowserScreenshotInput { get; }
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
            out global::Anthropic.BrowserScreenshotInput? value)
        {
            value = BrowserScreenshotInput;
            return IsBrowserScreenshotInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScreenshotInput PickBrowserScreenshotInput() => BrowserScreenshotInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserScreenshotInput' but the value was {ToString()}.");

        /// <summary>
        /// Return a cropped screenshot of the given viewport region, scaled up for closer<br/>
        /// inspection — useful for small icons, buttons, or text. Coordinates are in the<br/>
        /// same viewport-pixel space as a full screenshot.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserZoomInput? BrowserZoomInput { get; init; }
#else
        public global::Anthropic.BrowserZoomInput? BrowserZoomInput { get; }
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
            out global::Anthropic.BrowserZoomInput? value)
        {
            value = BrowserZoomInput;
            return IsBrowserZoomInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserZoomInput PickBrowserZoomInput() => BrowserZoomInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserZoomInput' but the value was {ToString()}.");

        /// <summary>
        /// Left-click at a viewport coordinate or on an element by reference.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserLeftClickInput? BrowserLeftClickInput { get; init; }
#else
        public global::Anthropic.BrowserLeftClickInput? BrowserLeftClickInput { get; }
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
            out global::Anthropic.BrowserLeftClickInput? value)
        {
            value = BrowserLeftClickInput;
            return IsBrowserLeftClickInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickInput PickBrowserLeftClickInput() => BrowserLeftClickInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserLeftClickInput' but the value was {ToString()}.");

        /// <summary>
        /// Right-click at a viewport coordinate or on an element by reference.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserRightClickInput? BrowserRightClickInput { get; init; }
#else
        public global::Anthropic.BrowserRightClickInput? BrowserRightClickInput { get; }
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
            out global::Anthropic.BrowserRightClickInput? value)
        {
            value = BrowserRightClickInput;
            return IsBrowserRightClickInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserRightClickInput PickBrowserRightClickInput() => BrowserRightClickInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserRightClickInput' but the value was {ToString()}.");

        /// <summary>
        /// Middle-click at a viewport coordinate or on an element by reference.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserMiddleClickInput? BrowserMiddleClickInput { get; init; }
#else
        public global::Anthropic.BrowserMiddleClickInput? BrowserMiddleClickInput { get; }
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
            out global::Anthropic.BrowserMiddleClickInput? value)
        {
            value = BrowserMiddleClickInput;
            return IsBrowserMiddleClickInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMiddleClickInput PickBrowserMiddleClickInput() => BrowserMiddleClickInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserMiddleClickInput' but the value was {ToString()}.");

        /// <summary>
        /// Double left-click at a viewport coordinate or on an element by reference.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserDoubleClickInput? BrowserDoubleClickInput { get; init; }
#else
        public global::Anthropic.BrowserDoubleClickInput? BrowserDoubleClickInput { get; }
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
            out global::Anthropic.BrowserDoubleClickInput? value)
        {
            value = BrowserDoubleClickInput;
            return IsBrowserDoubleClickInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserDoubleClickInput PickBrowserDoubleClickInput() => BrowserDoubleClickInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserDoubleClickInput' but the value was {ToString()}.");

        /// <summary>
        /// Triple left-click at a viewport coordinate or on an element by reference<br/>
        /// (typically selects a line or paragraph).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserTripleClickInput? BrowserTripleClickInput { get; init; }
#else
        public global::Anthropic.BrowserTripleClickInput? BrowserTripleClickInput { get; }
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
            out global::Anthropic.BrowserTripleClickInput? value)
        {
            value = BrowserTripleClickInput;
            return IsBrowserTripleClickInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTripleClickInput PickBrowserTripleClickInput() => BrowserTripleClickInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserTripleClickInput' but the value was {ToString()}.");

        /// <summary>
        /// Move the cursor to a coordinate or element without clicking.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserHoverInput? BrowserHoverInput { get; init; }
#else
        public global::Anthropic.BrowserHoverInput? BrowserHoverInput { get; }
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
            out global::Anthropic.BrowserHoverInput? value)
        {
            value = BrowserHoverInput;
            return IsBrowserHoverInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoverInput PickBrowserHoverInput() => BrowserHoverInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserHoverInput' but the value was {ToString()}.");

        /// <summary>
        /// Press at `from`, drag to `target`, release. Both must be coordinate targets.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserLeftClickDragInput? BrowserLeftClickDragInput { get; init; }
#else
        public global::Anthropic.BrowserLeftClickDragInput? BrowserLeftClickDragInput { get; }
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
            out global::Anthropic.BrowserLeftClickDragInput? value)
        {
            value = BrowserLeftClickDragInput;
            return IsBrowserLeftClickDragInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftClickDragInput PickBrowserLeftClickDragInput() => BrowserLeftClickDragInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserLeftClickDragInput' but the value was {ToString()}.");

        /// <summary>
        /// Press and hold the left mouse button at a viewport coordinate. Pair with<br/>
        /// left_mouse_up to perform a custom drag.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserLeftMouseDownInput? BrowserLeftMouseDownInput { get; init; }
#else
        public global::Anthropic.BrowserLeftMouseDownInput? BrowserLeftMouseDownInput { get; }
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
            out global::Anthropic.BrowserLeftMouseDownInput? value)
        {
            value = BrowserLeftMouseDownInput;
            return IsBrowserLeftMouseDownInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseDownInput PickBrowserLeftMouseDownInput() => BrowserLeftMouseDownInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserLeftMouseDownInput' but the value was {ToString()}.");

        /// <summary>
        /// Release the left mouse button at a viewport coordinate.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserLeftMouseUpInput? BrowserLeftMouseUpInput { get; init; }
#else
        public global::Anthropic.BrowserLeftMouseUpInput? BrowserLeftMouseUpInput { get; }
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
            out global::Anthropic.BrowserLeftMouseUpInput? value)
        {
            value = BrowserLeftMouseUpInput;
            return IsBrowserLeftMouseUpInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserLeftMouseUpInput PickBrowserLeftMouseUpInput() => BrowserLeftMouseUpInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserLeftMouseUpInput' but the value was {ToString()}.");

        /// <summary>
        /// Move the pointer to a viewport coordinate without clicking.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserMouseMoveInput? BrowserMouseMoveInput { get; init; }
#else
        public global::Anthropic.BrowserMouseMoveInput? BrowserMouseMoveInput { get; }
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
            out global::Anthropic.BrowserMouseMoveInput? value)
        {
            value = BrowserMouseMoveInput;
            return IsBrowserMouseMoveInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserMouseMoveInput PickBrowserMouseMoveInput() => BrowserMouseMoveInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserMouseMoveInput' but the value was {ToString()}.");

        /// <summary>
        /// Scroll at a viewport position. `target` must be a coordinate target.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserScrollInput? BrowserScrollInput { get; init; }
#else
        public global::Anthropic.BrowserScrollInput? BrowserScrollInput { get; }
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
            out global::Anthropic.BrowserScrollInput? value)
        {
            value = BrowserScrollInput;
            return IsBrowserScrollInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserScrollInput PickBrowserScrollInput() => BrowserScrollInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserScrollInput' but the value was {ToString()}.");

        /// <summary>
        /// Type a literal string at the current focus.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserTypeInput? BrowserTypeInput { get; init; }
#else
        public global::Anthropic.BrowserTypeInput? BrowserTypeInput { get; }
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
            out global::Anthropic.BrowserTypeInput? value)
        {
            value = BrowserTypeInput;
            return IsBrowserTypeInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserTypeInput PickBrowserTypeInput() => BrowserTypeInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserTypeInput' but the value was {ToString()}.");

        /// <summary>
        /// Press a key or key chord. Use "+" to combine modifiers with a key (e.g. "ctrl+a",<br/>
        /// "cmd+shift+p") and space to sequence presses (e.g. "Backspace Backspace Delete").<br/>
        /// Common names like "Return", "Tab", "Escape", "BackSpace" are supported.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserKeyInput? BrowserKeyInput { get; init; }
#else
        public global::Anthropic.BrowserKeyInput? BrowserKeyInput { get; }
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
            out global::Anthropic.BrowserKeyInput? value)
        {
            value = BrowserKeyInput;
            return IsBrowserKeyInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserKeyInput PickBrowserKeyInput() => BrowserKeyInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserKeyInput' but the value was {ToString()}.");

        /// <summary>
        /// Hold a key or key chord down for a duration, then release it. Uses the same key<br/>
        /// names and "+" chord syntax as the key action.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserHoldKeyInput? BrowserHoldKeyInput { get; init; }
#else
        public global::Anthropic.BrowserHoldKeyInput? BrowserHoldKeyInput { get; }
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
            out global::Anthropic.BrowserHoldKeyInput? value)
        {
            value = BrowserHoldKeyInput;
            return IsBrowserHoldKeyInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserHoldKeyInput PickBrowserHoldKeyInput() => BrowserHoldKeyInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserHoldKeyInput' but the value was {ToString()}.");

        /// <summary>
        /// Pause for the given duration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserWaitInput? BrowserWaitInput { get; init; }
#else
        public global::Anthropic.BrowserWaitInput? BrowserWaitInput { get; }
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
            out global::Anthropic.BrowserWaitInput? value)
        {
            value = BrowserWaitInput;
            return IsBrowserWaitInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserWaitInput PickBrowserWaitInput() => BrowserWaitInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserWaitInput' but the value was {ToString()}.");

        /// <summary>
        /// Execute JavaScript in the page context and return the value of the last<br/>
        /// expression. The code runs with access to the DOM, `window`, and page variables.<br/>
        /// Write the expression you want evaluated — do NOT use `return`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserJavascriptExecInput? BrowserJavascriptExecInput { get; init; }
#else
        public global::Anthropic.BrowserJavascriptExecInput? BrowserJavascriptExecInput { get; }
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
            out global::Anthropic.BrowserJavascriptExecInput? value)
        {
            value = BrowserJavascriptExecInput;
            return IsBrowserJavascriptExecInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserJavascriptExecInput PickBrowserJavascriptExecInput() => BrowserJavascriptExecInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserJavascriptExecInput' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserNavigateInput value) => new BrowserMemberInput((global::Anthropic.BrowserNavigateInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserNavigateInput?(BrowserMemberInput @this) => @this.BrowserNavigateInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserNavigateInput? value)
        {
            BrowserNavigateInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserNavigateInput(global::Anthropic.BrowserNavigateInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserListTabsInput value) => new BrowserMemberInput((global::Anthropic.BrowserListTabsInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserListTabsInput?(BrowserMemberInput @this) => @this.BrowserListTabsInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserListTabsInput? value)
        {
            BrowserListTabsInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserListTabsInput(global::Anthropic.BrowserListTabsInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserNewTabInput value) => new BrowserMemberInput((global::Anthropic.BrowserNewTabInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserNewTabInput?(BrowserMemberInput @this) => @this.BrowserNewTabInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserNewTabInput? value)
        {
            BrowserNewTabInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserNewTabInput(global::Anthropic.BrowserNewTabInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserSwitchTabInput value) => new BrowserMemberInput((global::Anthropic.BrowserSwitchTabInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserSwitchTabInput?(BrowserMemberInput @this) => @this.BrowserSwitchTabInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserSwitchTabInput? value)
        {
            BrowserSwitchTabInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserSwitchTabInput(global::Anthropic.BrowserSwitchTabInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserCloseTabInput value) => new BrowserMemberInput((global::Anthropic.BrowserCloseTabInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserCloseTabInput?(BrowserMemberInput @this) => @this.BrowserCloseTabInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserCloseTabInput? value)
        {
            BrowserCloseTabInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserCloseTabInput(global::Anthropic.BrowserCloseTabInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserReadPageInput value) => new BrowserMemberInput((global::Anthropic.BrowserReadPageInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserReadPageInput?(BrowserMemberInput @this) => @this.BrowserReadPageInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserReadPageInput? value)
        {
            BrowserReadPageInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserReadPageInput(global::Anthropic.BrowserReadPageInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserGetPageTextInput value) => new BrowserMemberInput((global::Anthropic.BrowserGetPageTextInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserGetPageTextInput?(BrowserMemberInput @this) => @this.BrowserGetPageTextInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserGetPageTextInput? value)
        {
            BrowserGetPageTextInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserGetPageTextInput(global::Anthropic.BrowserGetPageTextInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserReadConsoleInput value) => new BrowserMemberInput((global::Anthropic.BrowserReadConsoleInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserReadConsoleInput?(BrowserMemberInput @this) => @this.BrowserReadConsoleInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserReadConsoleInput? value)
        {
            BrowserReadConsoleInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserReadConsoleInput(global::Anthropic.BrowserReadConsoleInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserReadNetworkInput value) => new BrowserMemberInput((global::Anthropic.BrowserReadNetworkInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserReadNetworkInput?(BrowserMemberInput @this) => @this.BrowserReadNetworkInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserReadNetworkInput? value)
        {
            BrowserReadNetworkInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserReadNetworkInput(global::Anthropic.BrowserReadNetworkInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserFindInput value) => new BrowserMemberInput((global::Anthropic.BrowserFindInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserFindInput?(BrowserMemberInput @this) => @this.BrowserFindInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserFindInput? value)
        {
            BrowserFindInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserFindInput(global::Anthropic.BrowserFindInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserFormInputInput value) => new BrowserMemberInput((global::Anthropic.BrowserFormInputInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserFormInputInput?(BrowserMemberInput @this) => @this.BrowserFormInputInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserFormInputInput? value)
        {
            BrowserFormInputInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserFormInputInput(global::Anthropic.BrowserFormInputInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserFileUploadInput value) => new BrowserMemberInput((global::Anthropic.BrowserFileUploadInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserFileUploadInput?(BrowserMemberInput @this) => @this.FileUpload;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserFileUploadInput? value)
        {
            FileUpload = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromFileUpload(global::Anthropic.BrowserFileUploadInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserScrollToInput value) => new BrowserMemberInput((global::Anthropic.BrowserScrollToInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserScrollToInput?(BrowserMemberInput @this) => @this.BrowserScrollToInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserScrollToInput? value)
        {
            BrowserScrollToInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserScrollToInput(global::Anthropic.BrowserScrollToInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserScreenshotInput value) => new BrowserMemberInput((global::Anthropic.BrowserScreenshotInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserScreenshotInput?(BrowserMemberInput @this) => @this.BrowserScreenshotInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserScreenshotInput? value)
        {
            BrowserScreenshotInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserScreenshotInput(global::Anthropic.BrowserScreenshotInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserZoomInput value) => new BrowserMemberInput((global::Anthropic.BrowserZoomInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserZoomInput?(BrowserMemberInput @this) => @this.BrowserZoomInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserZoomInput? value)
        {
            BrowserZoomInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserZoomInput(global::Anthropic.BrowserZoomInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserLeftClickInput value) => new BrowserMemberInput((global::Anthropic.BrowserLeftClickInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserLeftClickInput?(BrowserMemberInput @this) => @this.BrowserLeftClickInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserLeftClickInput? value)
        {
            BrowserLeftClickInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserLeftClickInput(global::Anthropic.BrowserLeftClickInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserRightClickInput value) => new BrowserMemberInput((global::Anthropic.BrowserRightClickInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserRightClickInput?(BrowserMemberInput @this) => @this.BrowserRightClickInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserRightClickInput? value)
        {
            BrowserRightClickInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserRightClickInput(global::Anthropic.BrowserRightClickInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserMiddleClickInput value) => new BrowserMemberInput((global::Anthropic.BrowserMiddleClickInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserMiddleClickInput?(BrowserMemberInput @this) => @this.BrowserMiddleClickInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserMiddleClickInput? value)
        {
            BrowserMiddleClickInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserMiddleClickInput(global::Anthropic.BrowserMiddleClickInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserDoubleClickInput value) => new BrowserMemberInput((global::Anthropic.BrowserDoubleClickInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserDoubleClickInput?(BrowserMemberInput @this) => @this.BrowserDoubleClickInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserDoubleClickInput? value)
        {
            BrowserDoubleClickInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserDoubleClickInput(global::Anthropic.BrowserDoubleClickInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserTripleClickInput value) => new BrowserMemberInput((global::Anthropic.BrowserTripleClickInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserTripleClickInput?(BrowserMemberInput @this) => @this.BrowserTripleClickInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserTripleClickInput? value)
        {
            BrowserTripleClickInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserTripleClickInput(global::Anthropic.BrowserTripleClickInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserHoverInput value) => new BrowserMemberInput((global::Anthropic.BrowserHoverInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserHoverInput?(BrowserMemberInput @this) => @this.BrowserHoverInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserHoverInput? value)
        {
            BrowserHoverInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserHoverInput(global::Anthropic.BrowserHoverInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserLeftClickDragInput value) => new BrowserMemberInput((global::Anthropic.BrowserLeftClickDragInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserLeftClickDragInput?(BrowserMemberInput @this) => @this.BrowserLeftClickDragInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserLeftClickDragInput? value)
        {
            BrowserLeftClickDragInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserLeftClickDragInput(global::Anthropic.BrowserLeftClickDragInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserLeftMouseDownInput value) => new BrowserMemberInput((global::Anthropic.BrowserLeftMouseDownInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserLeftMouseDownInput?(BrowserMemberInput @this) => @this.BrowserLeftMouseDownInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserLeftMouseDownInput? value)
        {
            BrowserLeftMouseDownInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserLeftMouseDownInput(global::Anthropic.BrowserLeftMouseDownInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserLeftMouseUpInput value) => new BrowserMemberInput((global::Anthropic.BrowserLeftMouseUpInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserLeftMouseUpInput?(BrowserMemberInput @this) => @this.BrowserLeftMouseUpInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserLeftMouseUpInput? value)
        {
            BrowserLeftMouseUpInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserLeftMouseUpInput(global::Anthropic.BrowserLeftMouseUpInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserMouseMoveInput value) => new BrowserMemberInput((global::Anthropic.BrowserMouseMoveInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserMouseMoveInput?(BrowserMemberInput @this) => @this.BrowserMouseMoveInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserMouseMoveInput? value)
        {
            BrowserMouseMoveInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserMouseMoveInput(global::Anthropic.BrowserMouseMoveInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserScrollInput value) => new BrowserMemberInput((global::Anthropic.BrowserScrollInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserScrollInput?(BrowserMemberInput @this) => @this.BrowserScrollInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserScrollInput? value)
        {
            BrowserScrollInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserScrollInput(global::Anthropic.BrowserScrollInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserTypeInput value) => new BrowserMemberInput((global::Anthropic.BrowserTypeInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserTypeInput?(BrowserMemberInput @this) => @this.BrowserTypeInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserTypeInput? value)
        {
            BrowserTypeInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserTypeInput(global::Anthropic.BrowserTypeInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserKeyInput value) => new BrowserMemberInput((global::Anthropic.BrowserKeyInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserKeyInput?(BrowserMemberInput @this) => @this.BrowserKeyInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserKeyInput? value)
        {
            BrowserKeyInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserKeyInput(global::Anthropic.BrowserKeyInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserHoldKeyInput value) => new BrowserMemberInput((global::Anthropic.BrowserHoldKeyInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserHoldKeyInput?(BrowserMemberInput @this) => @this.BrowserHoldKeyInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserHoldKeyInput? value)
        {
            BrowserHoldKeyInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserHoldKeyInput(global::Anthropic.BrowserHoldKeyInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserWaitInput value) => new BrowserMemberInput((global::Anthropic.BrowserWaitInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserWaitInput?(BrowserMemberInput @this) => @this.BrowserWaitInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserWaitInput? value)
        {
            BrowserWaitInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserWaitInput(global::Anthropic.BrowserWaitInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserMemberInput(global::Anthropic.BrowserJavascriptExecInput value) => new BrowserMemberInput((global::Anthropic.BrowserJavascriptExecInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserJavascriptExecInput?(BrowserMemberInput @this) => @this.BrowserJavascriptExecInput;

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(global::Anthropic.BrowserJavascriptExecInput? value)
        {
            BrowserJavascriptExecInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserMemberInput FromBrowserJavascriptExecInput(global::Anthropic.BrowserJavascriptExecInput? value) => new BrowserMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public BrowserMemberInput(
            global::Anthropic.BrowserNavigateInput? browserNavigateInput,
            global::Anthropic.BrowserListTabsInput? browserListTabsInput,
            global::Anthropic.BrowserNewTabInput? browserNewTabInput,
            global::Anthropic.BrowserSwitchTabInput? browserSwitchTabInput,
            global::Anthropic.BrowserCloseTabInput? browserCloseTabInput,
            global::Anthropic.BrowserReadPageInput? browserReadPageInput,
            global::Anthropic.BrowserGetPageTextInput? browserGetPageTextInput,
            global::Anthropic.BrowserReadConsoleInput? browserReadConsoleInput,
            global::Anthropic.BrowserReadNetworkInput? browserReadNetworkInput,
            global::Anthropic.BrowserFindInput? browserFindInput,
            global::Anthropic.BrowserFormInputInput? browserFormInputInput,
            global::Anthropic.BrowserFileUploadInput? fileUpload,
            global::Anthropic.BrowserScrollToInput? browserScrollToInput,
            global::Anthropic.BrowserScreenshotInput? browserScreenshotInput,
            global::Anthropic.BrowserZoomInput? browserZoomInput,
            global::Anthropic.BrowserLeftClickInput? browserLeftClickInput,
            global::Anthropic.BrowserRightClickInput? browserRightClickInput,
            global::Anthropic.BrowserMiddleClickInput? browserMiddleClickInput,
            global::Anthropic.BrowserDoubleClickInput? browserDoubleClickInput,
            global::Anthropic.BrowserTripleClickInput? browserTripleClickInput,
            global::Anthropic.BrowserHoverInput? browserHoverInput,
            global::Anthropic.BrowserLeftClickDragInput? browserLeftClickDragInput,
            global::Anthropic.BrowserLeftMouseDownInput? browserLeftMouseDownInput,
            global::Anthropic.BrowserLeftMouseUpInput? browserLeftMouseUpInput,
            global::Anthropic.BrowserMouseMoveInput? browserMouseMoveInput,
            global::Anthropic.BrowserScrollInput? browserScrollInput,
            global::Anthropic.BrowserTypeInput? browserTypeInput,
            global::Anthropic.BrowserKeyInput? browserKeyInput,
            global::Anthropic.BrowserHoldKeyInput? browserHoldKeyInput,
            global::Anthropic.BrowserWaitInput? browserWaitInput,
            global::Anthropic.BrowserJavascriptExecInput? browserJavascriptExecInput
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
            global::System.Func<global::Anthropic.BrowserNavigateInput, TResult>? browserNavigateInput = null,
            global::System.Func<global::Anthropic.BrowserListTabsInput, TResult>? browserListTabsInput = null,
            global::System.Func<global::Anthropic.BrowserNewTabInput, TResult>? browserNewTabInput = null,
            global::System.Func<global::Anthropic.BrowserSwitchTabInput, TResult>? browserSwitchTabInput = null,
            global::System.Func<global::Anthropic.BrowserCloseTabInput, TResult>? browserCloseTabInput = null,
            global::System.Func<global::Anthropic.BrowserReadPageInput, TResult>? browserReadPageInput = null,
            global::System.Func<global::Anthropic.BrowserGetPageTextInput, TResult>? browserGetPageTextInput = null,
            global::System.Func<global::Anthropic.BrowserReadConsoleInput, TResult>? browserReadConsoleInput = null,
            global::System.Func<global::Anthropic.BrowserReadNetworkInput, TResult>? browserReadNetworkInput = null,
            global::System.Func<global::Anthropic.BrowserFindInput, TResult>? browserFindInput = null,
            global::System.Func<global::Anthropic.BrowserFormInputInput, TResult>? browserFormInputInput = null,
            global::System.Func<global::Anthropic.BrowserFileUploadInput?, TResult>? fileUpload = null,
            global::System.Func<global::Anthropic.BrowserScrollToInput, TResult>? browserScrollToInput = null,
            global::System.Func<global::Anthropic.BrowserScreenshotInput, TResult>? browserScreenshotInput = null,
            global::System.Func<global::Anthropic.BrowserZoomInput, TResult>? browserZoomInput = null,
            global::System.Func<global::Anthropic.BrowserLeftClickInput, TResult>? browserLeftClickInput = null,
            global::System.Func<global::Anthropic.BrowserRightClickInput, TResult>? browserRightClickInput = null,
            global::System.Func<global::Anthropic.BrowserMiddleClickInput, TResult>? browserMiddleClickInput = null,
            global::System.Func<global::Anthropic.BrowserDoubleClickInput, TResult>? browserDoubleClickInput = null,
            global::System.Func<global::Anthropic.BrowserTripleClickInput, TResult>? browserTripleClickInput = null,
            global::System.Func<global::Anthropic.BrowserHoverInput, TResult>? browserHoverInput = null,
            global::System.Func<global::Anthropic.BrowserLeftClickDragInput, TResult>? browserLeftClickDragInput = null,
            global::System.Func<global::Anthropic.BrowserLeftMouseDownInput, TResult>? browserLeftMouseDownInput = null,
            global::System.Func<global::Anthropic.BrowserLeftMouseUpInput, TResult>? browserLeftMouseUpInput = null,
            global::System.Func<global::Anthropic.BrowserMouseMoveInput, TResult>? browserMouseMoveInput = null,
            global::System.Func<global::Anthropic.BrowserScrollInput, TResult>? browserScrollInput = null,
            global::System.Func<global::Anthropic.BrowserTypeInput, TResult>? browserTypeInput = null,
            global::System.Func<global::Anthropic.BrowserKeyInput, TResult>? browserKeyInput = null,
            global::System.Func<global::Anthropic.BrowserHoldKeyInput, TResult>? browserHoldKeyInput = null,
            global::System.Func<global::Anthropic.BrowserWaitInput, TResult>? browserWaitInput = null,
            global::System.Func<global::Anthropic.BrowserJavascriptExecInput, TResult>? browserJavascriptExecInput = null,
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
            global::System.Action<global::Anthropic.BrowserNavigateInput>? browserNavigateInput = null,

            global::System.Action<global::Anthropic.BrowserListTabsInput>? browserListTabsInput = null,

            global::System.Action<global::Anthropic.BrowserNewTabInput>? browserNewTabInput = null,

            global::System.Action<global::Anthropic.BrowserSwitchTabInput>? browserSwitchTabInput = null,

            global::System.Action<global::Anthropic.BrowserCloseTabInput>? browserCloseTabInput = null,

            global::System.Action<global::Anthropic.BrowserReadPageInput>? browserReadPageInput = null,

            global::System.Action<global::Anthropic.BrowserGetPageTextInput>? browserGetPageTextInput = null,

            global::System.Action<global::Anthropic.BrowserReadConsoleInput>? browserReadConsoleInput = null,

            global::System.Action<global::Anthropic.BrowserReadNetworkInput>? browserReadNetworkInput = null,

            global::System.Action<global::Anthropic.BrowserFindInput>? browserFindInput = null,

            global::System.Action<global::Anthropic.BrowserFormInputInput>? browserFormInputInput = null,

            global::System.Action<global::Anthropic.BrowserFileUploadInput?>? fileUpload = null,

            global::System.Action<global::Anthropic.BrowserScrollToInput>? browserScrollToInput = null,

            global::System.Action<global::Anthropic.BrowserScreenshotInput>? browserScreenshotInput = null,

            global::System.Action<global::Anthropic.BrowserZoomInput>? browserZoomInput = null,

            global::System.Action<global::Anthropic.BrowserLeftClickInput>? browserLeftClickInput = null,

            global::System.Action<global::Anthropic.BrowserRightClickInput>? browserRightClickInput = null,

            global::System.Action<global::Anthropic.BrowserMiddleClickInput>? browserMiddleClickInput = null,

            global::System.Action<global::Anthropic.BrowserDoubleClickInput>? browserDoubleClickInput = null,

            global::System.Action<global::Anthropic.BrowserTripleClickInput>? browserTripleClickInput = null,

            global::System.Action<global::Anthropic.BrowserHoverInput>? browserHoverInput = null,

            global::System.Action<global::Anthropic.BrowserLeftClickDragInput>? browserLeftClickDragInput = null,

            global::System.Action<global::Anthropic.BrowserLeftMouseDownInput>? browserLeftMouseDownInput = null,

            global::System.Action<global::Anthropic.BrowserLeftMouseUpInput>? browserLeftMouseUpInput = null,

            global::System.Action<global::Anthropic.BrowserMouseMoveInput>? browserMouseMoveInput = null,

            global::System.Action<global::Anthropic.BrowserScrollInput>? browserScrollInput = null,

            global::System.Action<global::Anthropic.BrowserTypeInput>? browserTypeInput = null,

            global::System.Action<global::Anthropic.BrowserKeyInput>? browserKeyInput = null,

            global::System.Action<global::Anthropic.BrowserHoldKeyInput>? browserHoldKeyInput = null,

            global::System.Action<global::Anthropic.BrowserWaitInput>? browserWaitInput = null,

            global::System.Action<global::Anthropic.BrowserJavascriptExecInput>? browserJavascriptExecInput = null,
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
            global::System.Action<global::Anthropic.BrowserNavigateInput>? browserNavigateInput = null,
            global::System.Action<global::Anthropic.BrowserListTabsInput>? browserListTabsInput = null,
            global::System.Action<global::Anthropic.BrowserNewTabInput>? browserNewTabInput = null,
            global::System.Action<global::Anthropic.BrowserSwitchTabInput>? browserSwitchTabInput = null,
            global::System.Action<global::Anthropic.BrowserCloseTabInput>? browserCloseTabInput = null,
            global::System.Action<global::Anthropic.BrowserReadPageInput>? browserReadPageInput = null,
            global::System.Action<global::Anthropic.BrowserGetPageTextInput>? browserGetPageTextInput = null,
            global::System.Action<global::Anthropic.BrowserReadConsoleInput>? browserReadConsoleInput = null,
            global::System.Action<global::Anthropic.BrowserReadNetworkInput>? browserReadNetworkInput = null,
            global::System.Action<global::Anthropic.BrowserFindInput>? browserFindInput = null,
            global::System.Action<global::Anthropic.BrowserFormInputInput>? browserFormInputInput = null,
            global::System.Action<global::Anthropic.BrowserFileUploadInput?>? fileUpload = null,
            global::System.Action<global::Anthropic.BrowserScrollToInput>? browserScrollToInput = null,
            global::System.Action<global::Anthropic.BrowserScreenshotInput>? browserScreenshotInput = null,
            global::System.Action<global::Anthropic.BrowserZoomInput>? browserZoomInput = null,
            global::System.Action<global::Anthropic.BrowserLeftClickInput>? browserLeftClickInput = null,
            global::System.Action<global::Anthropic.BrowserRightClickInput>? browserRightClickInput = null,
            global::System.Action<global::Anthropic.BrowserMiddleClickInput>? browserMiddleClickInput = null,
            global::System.Action<global::Anthropic.BrowserDoubleClickInput>? browserDoubleClickInput = null,
            global::System.Action<global::Anthropic.BrowserTripleClickInput>? browserTripleClickInput = null,
            global::System.Action<global::Anthropic.BrowserHoverInput>? browserHoverInput = null,
            global::System.Action<global::Anthropic.BrowserLeftClickDragInput>? browserLeftClickDragInput = null,
            global::System.Action<global::Anthropic.BrowserLeftMouseDownInput>? browserLeftMouseDownInput = null,
            global::System.Action<global::Anthropic.BrowserLeftMouseUpInput>? browserLeftMouseUpInput = null,
            global::System.Action<global::Anthropic.BrowserMouseMoveInput>? browserMouseMoveInput = null,
            global::System.Action<global::Anthropic.BrowserScrollInput>? browserScrollInput = null,
            global::System.Action<global::Anthropic.BrowserTypeInput>? browserTypeInput = null,
            global::System.Action<global::Anthropic.BrowserKeyInput>? browserKeyInput = null,
            global::System.Action<global::Anthropic.BrowserHoldKeyInput>? browserHoldKeyInput = null,
            global::System.Action<global::Anthropic.BrowserWaitInput>? browserWaitInput = null,
            global::System.Action<global::Anthropic.BrowserJavascriptExecInput>? browserJavascriptExecInput = null,
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
                typeof(global::Anthropic.BrowserNavigateInput),
                BrowserListTabsInput,
                typeof(global::Anthropic.BrowserListTabsInput),
                BrowserNewTabInput,
                typeof(global::Anthropic.BrowserNewTabInput),
                BrowserSwitchTabInput,
                typeof(global::Anthropic.BrowserSwitchTabInput),
                BrowserCloseTabInput,
                typeof(global::Anthropic.BrowserCloseTabInput),
                BrowserReadPageInput,
                typeof(global::Anthropic.BrowserReadPageInput),
                BrowserGetPageTextInput,
                typeof(global::Anthropic.BrowserGetPageTextInput),
                BrowserReadConsoleInput,
                typeof(global::Anthropic.BrowserReadConsoleInput),
                BrowserReadNetworkInput,
                typeof(global::Anthropic.BrowserReadNetworkInput),
                BrowserFindInput,
                typeof(global::Anthropic.BrowserFindInput),
                BrowserFormInputInput,
                typeof(global::Anthropic.BrowserFormInputInput),
                FileUpload,
                typeof(global::Anthropic.BrowserFileUploadInput),
                BrowserScrollToInput,
                typeof(global::Anthropic.BrowserScrollToInput),
                BrowserScreenshotInput,
                typeof(global::Anthropic.BrowserScreenshotInput),
                BrowserZoomInput,
                typeof(global::Anthropic.BrowserZoomInput),
                BrowserLeftClickInput,
                typeof(global::Anthropic.BrowserLeftClickInput),
                BrowserRightClickInput,
                typeof(global::Anthropic.BrowserRightClickInput),
                BrowserMiddleClickInput,
                typeof(global::Anthropic.BrowserMiddleClickInput),
                BrowserDoubleClickInput,
                typeof(global::Anthropic.BrowserDoubleClickInput),
                BrowserTripleClickInput,
                typeof(global::Anthropic.BrowserTripleClickInput),
                BrowserHoverInput,
                typeof(global::Anthropic.BrowserHoverInput),
                BrowserLeftClickDragInput,
                typeof(global::Anthropic.BrowserLeftClickDragInput),
                BrowserLeftMouseDownInput,
                typeof(global::Anthropic.BrowserLeftMouseDownInput),
                BrowserLeftMouseUpInput,
                typeof(global::Anthropic.BrowserLeftMouseUpInput),
                BrowserMouseMoveInput,
                typeof(global::Anthropic.BrowserMouseMoveInput),
                BrowserScrollInput,
                typeof(global::Anthropic.BrowserScrollInput),
                BrowserTypeInput,
                typeof(global::Anthropic.BrowserTypeInput),
                BrowserKeyInput,
                typeof(global::Anthropic.BrowserKeyInput),
                BrowserHoldKeyInput,
                typeof(global::Anthropic.BrowserHoldKeyInput),
                BrowserWaitInput,
                typeof(global::Anthropic.BrowserWaitInput),
                BrowserJavascriptExecInput,
                typeof(global::Anthropic.BrowserJavascriptExecInput),
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
        public bool Equals(BrowserMemberInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserNavigateInput?>.Default.Equals(BrowserNavigateInput, other.BrowserNavigateInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserListTabsInput?>.Default.Equals(BrowserListTabsInput, other.BrowserListTabsInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserNewTabInput?>.Default.Equals(BrowserNewTabInput, other.BrowserNewTabInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserSwitchTabInput?>.Default.Equals(BrowserSwitchTabInput, other.BrowserSwitchTabInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserCloseTabInput?>.Default.Equals(BrowserCloseTabInput, other.BrowserCloseTabInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserReadPageInput?>.Default.Equals(BrowserReadPageInput, other.BrowserReadPageInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserGetPageTextInput?>.Default.Equals(BrowserGetPageTextInput, other.BrowserGetPageTextInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserReadConsoleInput?>.Default.Equals(BrowserReadConsoleInput, other.BrowserReadConsoleInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserReadNetworkInput?>.Default.Equals(BrowserReadNetworkInput, other.BrowserReadNetworkInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserFindInput?>.Default.Equals(BrowserFindInput, other.BrowserFindInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserFormInputInput?>.Default.Equals(BrowserFormInputInput, other.BrowserFormInputInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserFileUploadInput?>.Default.Equals(FileUpload, other.FileUpload) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserScrollToInput?>.Default.Equals(BrowserScrollToInput, other.BrowserScrollToInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserScreenshotInput?>.Default.Equals(BrowserScreenshotInput, other.BrowserScreenshotInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserZoomInput?>.Default.Equals(BrowserZoomInput, other.BrowserZoomInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserLeftClickInput?>.Default.Equals(BrowserLeftClickInput, other.BrowserLeftClickInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserRightClickInput?>.Default.Equals(BrowserRightClickInput, other.BrowserRightClickInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserMiddleClickInput?>.Default.Equals(BrowserMiddleClickInput, other.BrowserMiddleClickInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserDoubleClickInput?>.Default.Equals(BrowserDoubleClickInput, other.BrowserDoubleClickInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserTripleClickInput?>.Default.Equals(BrowserTripleClickInput, other.BrowserTripleClickInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserHoverInput?>.Default.Equals(BrowserHoverInput, other.BrowserHoverInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserLeftClickDragInput?>.Default.Equals(BrowserLeftClickDragInput, other.BrowserLeftClickDragInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserLeftMouseDownInput?>.Default.Equals(BrowserLeftMouseDownInput, other.BrowserLeftMouseDownInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserLeftMouseUpInput?>.Default.Equals(BrowserLeftMouseUpInput, other.BrowserLeftMouseUpInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserMouseMoveInput?>.Default.Equals(BrowserMouseMoveInput, other.BrowserMouseMoveInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserScrollInput?>.Default.Equals(BrowserScrollInput, other.BrowserScrollInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserTypeInput?>.Default.Equals(BrowserTypeInput, other.BrowserTypeInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserKeyInput?>.Default.Equals(BrowserKeyInput, other.BrowserKeyInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserHoldKeyInput?>.Default.Equals(BrowserHoldKeyInput, other.BrowserHoldKeyInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserWaitInput?>.Default.Equals(BrowserWaitInput, other.BrowserWaitInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserJavascriptExecInput?>.Default.Equals(BrowserJavascriptExecInput, other.BrowserJavascriptExecInput)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BrowserMemberInput obj1, BrowserMemberInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BrowserMemberInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BrowserMemberInput obj1, BrowserMemberInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BrowserMemberInput o && Equals(o);
        }
    }
}
