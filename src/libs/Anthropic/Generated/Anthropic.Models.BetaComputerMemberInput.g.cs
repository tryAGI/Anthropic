#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The `input` of a computer toolset member `tool_use` block: the member's own parameters.
    /// </summary>
    public readonly partial struct BetaComputerMemberInput : global::System.IEquatable<BetaComputerMemberInput>
    {
        /// <summary>
        /// Press a key or key-combination on the keyboard. Use "+" to combine modifiers with<br/>
        /// a key (e.g. "ctrl+s", "alt+Tab", "ctrl+shift+Escape"). Key names are<br/>
        /// case-insensitive; common names like "Return", "Tab", "Escape", "Up", "Down",<br/>
        /// "Left", "Right", "Home", "End", "Page_Up", "Page_Down", "Delete", "BackSpace" are<br/>
        /// supported.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerKeyInput? ComputerKeyInput { get; init; }
#else
        public global::Anthropic.BetaComputerKeyInput? ComputerKeyInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerKeyInput))]
#endif
        public bool IsComputerKeyInput => ComputerKeyInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerKeyInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComputerKeyInput? value)
        {
            value = ComputerKeyInput;
            return IsComputerKeyInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerKeyInput PickComputerKeyInput() => ComputerKeyInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerKeyInput' but the value was {ToString()}.");

        /// <summary>
        /// Hold down a key or key-combination for a specified duration. Uses the same key<br/>
        /// syntax as `key`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerHoldKeyInput? ComputerHoldKeyInput { get; init; }
#else
        public global::Anthropic.BetaComputerHoldKeyInput? ComputerHoldKeyInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerHoldKeyInput))]
#endif
        public bool IsComputerHoldKeyInput => ComputerHoldKeyInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerHoldKeyInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComputerHoldKeyInput? value)
        {
            value = ComputerHoldKeyInput;
            return IsComputerHoldKeyInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerHoldKeyInput PickComputerHoldKeyInput() => ComputerHoldKeyInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerHoldKeyInput' but the value was {ToString()}.");

        /// <summary>
        /// Type a string of text on the keyboard.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerTypeInput? ComputerTypeInput { get; init; }
#else
        public global::Anthropic.BetaComputerTypeInput? ComputerTypeInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerTypeInput))]
#endif
        public bool IsComputerTypeInput => ComputerTypeInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerTypeInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComputerTypeInput? value)
        {
            value = ComputerTypeInput;
            return IsComputerTypeInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTypeInput PickComputerTypeInput() => ComputerTypeInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerTypeInput' but the value was {ToString()}.");

        /// <summary>
        /// Get the current (x, y) pixel coordinate of the cursor.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerCursorPositionInput? ComputerCursorPositionInput { get; init; }
#else
        public global::Anthropic.BetaComputerCursorPositionInput? ComputerCursorPositionInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerCursorPositionInput))]
#endif
        public bool IsComputerCursorPositionInput => ComputerCursorPositionInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerCursorPositionInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComputerCursorPositionInput? value)
        {
            value = ComputerCursorPositionInput;
            return IsComputerCursorPositionInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerCursorPositionInput PickComputerCursorPositionInput() => ComputerCursorPositionInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerCursorPositionInput' but the value was {ToString()}.");

        /// <summary>
        /// Move the cursor to a specified (x, y) pixel coordinate. Use this ONLY to hover<br/>
        /// without clicking; otherwise use a click action directly.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerMouseMoveInput? ComputerMouseMoveInput { get; init; }
#else
        public global::Anthropic.BetaComputerMouseMoveInput? ComputerMouseMoveInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerMouseMoveInput))]
#endif
        public bool IsComputerMouseMoveInput => ComputerMouseMoveInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerMouseMoveInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComputerMouseMoveInput? value)
        {
            value = ComputerMouseMoveInput;
            return IsComputerMouseMoveInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMouseMoveInput PickComputerMouseMoveInput() => ComputerMouseMoveInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerMouseMoveInput' but the value was {ToString()}.");

        /// <summary>
        /// Press and hold the left mouse button at the current cursor position.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerLeftMouseDownInput? ComputerLeftMouseDownInput { get; init; }
#else
        public global::Anthropic.BetaComputerLeftMouseDownInput? ComputerLeftMouseDownInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerLeftMouseDownInput))]
#endif
        public bool IsComputerLeftMouseDownInput => ComputerLeftMouseDownInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerLeftMouseDownInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComputerLeftMouseDownInput? value)
        {
            value = ComputerLeftMouseDownInput;
            return IsComputerLeftMouseDownInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseDownInput PickComputerLeftMouseDownInput() => ComputerLeftMouseDownInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerLeftMouseDownInput' but the value was {ToString()}.");

        /// <summary>
        /// Release the left mouse button.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerLeftMouseUpInput? ComputerLeftMouseUpInput { get; init; }
#else
        public global::Anthropic.BetaComputerLeftMouseUpInput? ComputerLeftMouseUpInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerLeftMouseUpInput))]
#endif
        public bool IsComputerLeftMouseUpInput => ComputerLeftMouseUpInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerLeftMouseUpInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComputerLeftMouseUpInput? value)
        {
            value = ComputerLeftMouseUpInput;
            return IsComputerLeftMouseUpInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftMouseUpInput PickComputerLeftMouseUpInput() => ComputerLeftMouseUpInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerLeftMouseUpInput' but the value was {ToString()}.");

        /// <summary>
        /// Click the left mouse button at the specified (x, y) pixel coordinate, or the<br/>
        /// current cursor position if `coordinate` is omitted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerLeftClickInput? ComputerLeftClickInput { get; init; }
#else
        public global::Anthropic.BetaComputerLeftClickInput? ComputerLeftClickInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerLeftClickInput))]
#endif
        public bool IsComputerLeftClickInput => ComputerLeftClickInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerLeftClickInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComputerLeftClickInput? value)
        {
            value = ComputerLeftClickInput;
            return IsComputerLeftClickInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickInput PickComputerLeftClickInput() => ComputerLeftClickInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerLeftClickInput' but the value was {ToString()}.");

        /// <summary>
        /// Click and drag the cursor from `start_coordinate` to `coordinate`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerLeftClickDragInput? ComputerLeftClickDragInput { get; init; }
#else
        public global::Anthropic.BetaComputerLeftClickDragInput? ComputerLeftClickDragInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerLeftClickDragInput))]
#endif
        public bool IsComputerLeftClickDragInput => ComputerLeftClickDragInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerLeftClickDragInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComputerLeftClickDragInput? value)
        {
            value = ComputerLeftClickDragInput;
            return IsComputerLeftClickDragInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerLeftClickDragInput PickComputerLeftClickDragInput() => ComputerLeftClickDragInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerLeftClickDragInput' but the value was {ToString()}.");

        /// <summary>
        /// Click the right mouse button at the specified (x, y) pixel coordinate, or the<br/>
        /// current cursor position if `coordinate` is omitted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerRightClickInput? ComputerRightClickInput { get; init; }
#else
        public global::Anthropic.BetaComputerRightClickInput? ComputerRightClickInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerRightClickInput))]
#endif
        public bool IsComputerRightClickInput => ComputerRightClickInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerRightClickInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComputerRightClickInput? value)
        {
            value = ComputerRightClickInput;
            return IsComputerRightClickInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerRightClickInput PickComputerRightClickInput() => ComputerRightClickInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerRightClickInput' but the value was {ToString()}.");

        /// <summary>
        /// Click the middle mouse button at the specified (x, y) pixel coordinate, or the<br/>
        /// current cursor position if `coordinate` is omitted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerMiddleClickInput? ComputerMiddleClickInput { get; init; }
#else
        public global::Anthropic.BetaComputerMiddleClickInput? ComputerMiddleClickInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerMiddleClickInput))]
#endif
        public bool IsComputerMiddleClickInput => ComputerMiddleClickInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerMiddleClickInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComputerMiddleClickInput? value)
        {
            value = ComputerMiddleClickInput;
            return IsComputerMiddleClickInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerMiddleClickInput PickComputerMiddleClickInput() => ComputerMiddleClickInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerMiddleClickInput' but the value was {ToString()}.");

        /// <summary>
        /// Double-click the left mouse button at the specified (x, y) pixel coordinate, or<br/>
        /// the current cursor position if `coordinate` is omitted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerDoubleClickInput? ComputerDoubleClickInput { get; init; }
#else
        public global::Anthropic.BetaComputerDoubleClickInput? ComputerDoubleClickInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerDoubleClickInput))]
#endif
        public bool IsComputerDoubleClickInput => ComputerDoubleClickInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerDoubleClickInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComputerDoubleClickInput? value)
        {
            value = ComputerDoubleClickInput;
            return IsComputerDoubleClickInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerDoubleClickInput PickComputerDoubleClickInput() => ComputerDoubleClickInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerDoubleClickInput' but the value was {ToString()}.");

        /// <summary>
        /// Triple-click the left mouse button at the specified (x, y) pixel coordinate, or<br/>
        /// the current cursor position if `coordinate` is omitted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerTripleClickInput? ComputerTripleClickInput { get; init; }
#else
        public global::Anthropic.BetaComputerTripleClickInput? ComputerTripleClickInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerTripleClickInput))]
#endif
        public bool IsComputerTripleClickInput => ComputerTripleClickInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerTripleClickInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComputerTripleClickInput? value)
        {
            value = ComputerTripleClickInput;
            return IsComputerTripleClickInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerTripleClickInput PickComputerTripleClickInput() => ComputerTripleClickInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerTripleClickInput' but the value was {ToString()}.");

        /// <summary>
        /// Scroll the screen at the specified (x, y) pixel coordinate, or the current cursor<br/>
        /// position if `coordinate` is omitted. Do NOT use PageUp/PageDown to scroll.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerScrollInput? ComputerScrollInput { get; init; }
#else
        public global::Anthropic.BetaComputerScrollInput? ComputerScrollInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerScrollInput))]
#endif
        public bool IsComputerScrollInput => ComputerScrollInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerScrollInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComputerScrollInput? value)
        {
            value = ComputerScrollInput;
            return IsComputerScrollInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScrollInput PickComputerScrollInput() => ComputerScrollInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerScrollInput' but the value was {ToString()}.");

        /// <summary>
        /// Wait for a specified duration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerWaitInput? ComputerWaitInput { get; init; }
#else
        public global::Anthropic.BetaComputerWaitInput? ComputerWaitInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerWaitInput))]
#endif
        public bool IsComputerWaitInput => ComputerWaitInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerWaitInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComputerWaitInput? value)
        {
            value = ComputerWaitInput;
            return IsComputerWaitInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerWaitInput PickComputerWaitInput() => ComputerWaitInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerWaitInput' but the value was {ToString()}.");

        /// <summary>
        /// Take a screenshot of the screen.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerScreenshotInput? ComputerScreenshotInput { get; init; }
#else
        public global::Anthropic.BetaComputerScreenshotInput? ComputerScreenshotInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerScreenshotInput))]
#endif
        public bool IsComputerScreenshotInput => ComputerScreenshotInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerScreenshotInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComputerScreenshotInput? value)
        {
            value = ComputerScreenshotInput;
            return IsComputerScreenshotInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerScreenshotInput PickComputerScreenshotInput() => ComputerScreenshotInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerScreenshotInput' but the value was {ToString()}.");

        /// <summary>
        /// Take a screenshot of a rectangular region. Region coordinates are in the<br/>
        /// full-screenshot space (not physical display pixels). The crop is scaled up to<br/>
        /// fill the image budget so fine details become legible.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerZoomInput? ComputerZoomInput { get; init; }
#else
        public global::Anthropic.BetaComputerZoomInput? ComputerZoomInput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerZoomInput))]
#endif
        public bool IsComputerZoomInput => ComputerZoomInput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerZoomInput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComputerZoomInput? value)
        {
            value = ComputerZoomInput;
            return IsComputerZoomInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerZoomInput PickComputerZoomInput() => ComputerZoomInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerZoomInput' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerMemberInput(global::Anthropic.BetaComputerKeyInput value) => new BetaComputerMemberInput((global::Anthropic.BetaComputerKeyInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerKeyInput?(BetaComputerMemberInput @this) => @this.ComputerKeyInput;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerMemberInput(global::Anthropic.BetaComputerKeyInput? value)
        {
            ComputerKeyInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerMemberInput FromComputerKeyInput(global::Anthropic.BetaComputerKeyInput? value) => new BetaComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerMemberInput(global::Anthropic.BetaComputerHoldKeyInput value) => new BetaComputerMemberInput((global::Anthropic.BetaComputerHoldKeyInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerHoldKeyInput?(BetaComputerMemberInput @this) => @this.ComputerHoldKeyInput;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerMemberInput(global::Anthropic.BetaComputerHoldKeyInput? value)
        {
            ComputerHoldKeyInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerMemberInput FromComputerHoldKeyInput(global::Anthropic.BetaComputerHoldKeyInput? value) => new BetaComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerMemberInput(global::Anthropic.BetaComputerTypeInput value) => new BetaComputerMemberInput((global::Anthropic.BetaComputerTypeInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerTypeInput?(BetaComputerMemberInput @this) => @this.ComputerTypeInput;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerMemberInput(global::Anthropic.BetaComputerTypeInput? value)
        {
            ComputerTypeInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerMemberInput FromComputerTypeInput(global::Anthropic.BetaComputerTypeInput? value) => new BetaComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerMemberInput(global::Anthropic.BetaComputerCursorPositionInput value) => new BetaComputerMemberInput((global::Anthropic.BetaComputerCursorPositionInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerCursorPositionInput?(BetaComputerMemberInput @this) => @this.ComputerCursorPositionInput;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerMemberInput(global::Anthropic.BetaComputerCursorPositionInput? value)
        {
            ComputerCursorPositionInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerMemberInput FromComputerCursorPositionInput(global::Anthropic.BetaComputerCursorPositionInput? value) => new BetaComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerMemberInput(global::Anthropic.BetaComputerMouseMoveInput value) => new BetaComputerMemberInput((global::Anthropic.BetaComputerMouseMoveInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerMouseMoveInput?(BetaComputerMemberInput @this) => @this.ComputerMouseMoveInput;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerMemberInput(global::Anthropic.BetaComputerMouseMoveInput? value)
        {
            ComputerMouseMoveInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerMemberInput FromComputerMouseMoveInput(global::Anthropic.BetaComputerMouseMoveInput? value) => new BetaComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerMemberInput(global::Anthropic.BetaComputerLeftMouseDownInput value) => new BetaComputerMemberInput((global::Anthropic.BetaComputerLeftMouseDownInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerLeftMouseDownInput?(BetaComputerMemberInput @this) => @this.ComputerLeftMouseDownInput;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerMemberInput(global::Anthropic.BetaComputerLeftMouseDownInput? value)
        {
            ComputerLeftMouseDownInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerMemberInput FromComputerLeftMouseDownInput(global::Anthropic.BetaComputerLeftMouseDownInput? value) => new BetaComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerMemberInput(global::Anthropic.BetaComputerLeftMouseUpInput value) => new BetaComputerMemberInput((global::Anthropic.BetaComputerLeftMouseUpInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerLeftMouseUpInput?(BetaComputerMemberInput @this) => @this.ComputerLeftMouseUpInput;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerMemberInput(global::Anthropic.BetaComputerLeftMouseUpInput? value)
        {
            ComputerLeftMouseUpInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerMemberInput FromComputerLeftMouseUpInput(global::Anthropic.BetaComputerLeftMouseUpInput? value) => new BetaComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerMemberInput(global::Anthropic.BetaComputerLeftClickInput value) => new BetaComputerMemberInput((global::Anthropic.BetaComputerLeftClickInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerLeftClickInput?(BetaComputerMemberInput @this) => @this.ComputerLeftClickInput;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerMemberInput(global::Anthropic.BetaComputerLeftClickInput? value)
        {
            ComputerLeftClickInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerMemberInput FromComputerLeftClickInput(global::Anthropic.BetaComputerLeftClickInput? value) => new BetaComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerMemberInput(global::Anthropic.BetaComputerLeftClickDragInput value) => new BetaComputerMemberInput((global::Anthropic.BetaComputerLeftClickDragInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerLeftClickDragInput?(BetaComputerMemberInput @this) => @this.ComputerLeftClickDragInput;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerMemberInput(global::Anthropic.BetaComputerLeftClickDragInput? value)
        {
            ComputerLeftClickDragInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerMemberInput FromComputerLeftClickDragInput(global::Anthropic.BetaComputerLeftClickDragInput? value) => new BetaComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerMemberInput(global::Anthropic.BetaComputerRightClickInput value) => new BetaComputerMemberInput((global::Anthropic.BetaComputerRightClickInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerRightClickInput?(BetaComputerMemberInput @this) => @this.ComputerRightClickInput;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerMemberInput(global::Anthropic.BetaComputerRightClickInput? value)
        {
            ComputerRightClickInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerMemberInput FromComputerRightClickInput(global::Anthropic.BetaComputerRightClickInput? value) => new BetaComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerMemberInput(global::Anthropic.BetaComputerMiddleClickInput value) => new BetaComputerMemberInput((global::Anthropic.BetaComputerMiddleClickInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerMiddleClickInput?(BetaComputerMemberInput @this) => @this.ComputerMiddleClickInput;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerMemberInput(global::Anthropic.BetaComputerMiddleClickInput? value)
        {
            ComputerMiddleClickInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerMemberInput FromComputerMiddleClickInput(global::Anthropic.BetaComputerMiddleClickInput? value) => new BetaComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerMemberInput(global::Anthropic.BetaComputerDoubleClickInput value) => new BetaComputerMemberInput((global::Anthropic.BetaComputerDoubleClickInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerDoubleClickInput?(BetaComputerMemberInput @this) => @this.ComputerDoubleClickInput;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerMemberInput(global::Anthropic.BetaComputerDoubleClickInput? value)
        {
            ComputerDoubleClickInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerMemberInput FromComputerDoubleClickInput(global::Anthropic.BetaComputerDoubleClickInput? value) => new BetaComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerMemberInput(global::Anthropic.BetaComputerTripleClickInput value) => new BetaComputerMemberInput((global::Anthropic.BetaComputerTripleClickInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerTripleClickInput?(BetaComputerMemberInput @this) => @this.ComputerTripleClickInput;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerMemberInput(global::Anthropic.BetaComputerTripleClickInput? value)
        {
            ComputerTripleClickInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerMemberInput FromComputerTripleClickInput(global::Anthropic.BetaComputerTripleClickInput? value) => new BetaComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerMemberInput(global::Anthropic.BetaComputerScrollInput value) => new BetaComputerMemberInput((global::Anthropic.BetaComputerScrollInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerScrollInput?(BetaComputerMemberInput @this) => @this.ComputerScrollInput;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerMemberInput(global::Anthropic.BetaComputerScrollInput? value)
        {
            ComputerScrollInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerMemberInput FromComputerScrollInput(global::Anthropic.BetaComputerScrollInput? value) => new BetaComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerMemberInput(global::Anthropic.BetaComputerWaitInput value) => new BetaComputerMemberInput((global::Anthropic.BetaComputerWaitInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerWaitInput?(BetaComputerMemberInput @this) => @this.ComputerWaitInput;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerMemberInput(global::Anthropic.BetaComputerWaitInput? value)
        {
            ComputerWaitInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerMemberInput FromComputerWaitInput(global::Anthropic.BetaComputerWaitInput? value) => new BetaComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerMemberInput(global::Anthropic.BetaComputerScreenshotInput value) => new BetaComputerMemberInput((global::Anthropic.BetaComputerScreenshotInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerScreenshotInput?(BetaComputerMemberInput @this) => @this.ComputerScreenshotInput;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerMemberInput(global::Anthropic.BetaComputerScreenshotInput? value)
        {
            ComputerScreenshotInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerMemberInput FromComputerScreenshotInput(global::Anthropic.BetaComputerScreenshotInput? value) => new BetaComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComputerMemberInput(global::Anthropic.BetaComputerZoomInput value) => new BetaComputerMemberInput((global::Anthropic.BetaComputerZoomInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerZoomInput?(BetaComputerMemberInput @this) => @this.ComputerZoomInput;

        /// <summary>
        ///
        /// </summary>
        public BetaComputerMemberInput(global::Anthropic.BetaComputerZoomInput? value)
        {
            ComputerZoomInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComputerMemberInput FromComputerZoomInput(global::Anthropic.BetaComputerZoomInput? value) => new BetaComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public BetaComputerMemberInput(
            global::Anthropic.BetaComputerKeyInput? computerKeyInput,
            global::Anthropic.BetaComputerHoldKeyInput? computerHoldKeyInput,
            global::Anthropic.BetaComputerTypeInput? computerTypeInput,
            global::Anthropic.BetaComputerCursorPositionInput? computerCursorPositionInput,
            global::Anthropic.BetaComputerMouseMoveInput? computerMouseMoveInput,
            global::Anthropic.BetaComputerLeftMouseDownInput? computerLeftMouseDownInput,
            global::Anthropic.BetaComputerLeftMouseUpInput? computerLeftMouseUpInput,
            global::Anthropic.BetaComputerLeftClickInput? computerLeftClickInput,
            global::Anthropic.BetaComputerLeftClickDragInput? computerLeftClickDragInput,
            global::Anthropic.BetaComputerRightClickInput? computerRightClickInput,
            global::Anthropic.BetaComputerMiddleClickInput? computerMiddleClickInput,
            global::Anthropic.BetaComputerDoubleClickInput? computerDoubleClickInput,
            global::Anthropic.BetaComputerTripleClickInput? computerTripleClickInput,
            global::Anthropic.BetaComputerScrollInput? computerScrollInput,
            global::Anthropic.BetaComputerWaitInput? computerWaitInput,
            global::Anthropic.BetaComputerScreenshotInput? computerScreenshotInput,
            global::Anthropic.BetaComputerZoomInput? computerZoomInput
            )
        {
            ComputerKeyInput = computerKeyInput;
            ComputerHoldKeyInput = computerHoldKeyInput;
            ComputerTypeInput = computerTypeInput;
            ComputerCursorPositionInput = computerCursorPositionInput;
            ComputerMouseMoveInput = computerMouseMoveInput;
            ComputerLeftMouseDownInput = computerLeftMouseDownInput;
            ComputerLeftMouseUpInput = computerLeftMouseUpInput;
            ComputerLeftClickInput = computerLeftClickInput;
            ComputerLeftClickDragInput = computerLeftClickDragInput;
            ComputerRightClickInput = computerRightClickInput;
            ComputerMiddleClickInput = computerMiddleClickInput;
            ComputerDoubleClickInput = computerDoubleClickInput;
            ComputerTripleClickInput = computerTripleClickInput;
            ComputerScrollInput = computerScrollInput;
            ComputerWaitInput = computerWaitInput;
            ComputerScreenshotInput = computerScreenshotInput;
            ComputerZoomInput = computerZoomInput;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ComputerZoomInput as object ??
            ComputerScreenshotInput as object ??
            ComputerWaitInput as object ??
            ComputerScrollInput as object ??
            ComputerTripleClickInput as object ??
            ComputerDoubleClickInput as object ??
            ComputerMiddleClickInput as object ??
            ComputerRightClickInput as object ??
            ComputerLeftClickDragInput as object ??
            ComputerLeftClickInput as object ??
            ComputerLeftMouseUpInput as object ??
            ComputerLeftMouseDownInput as object ??
            ComputerMouseMoveInput as object ??
            ComputerCursorPositionInput as object ??
            ComputerTypeInput as object ??
            ComputerHoldKeyInput as object ??
            ComputerKeyInput as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ComputerKeyInput?.ToString() ??
            ComputerHoldKeyInput?.ToString() ??
            ComputerTypeInput?.ToString() ??
            ComputerCursorPositionInput?.ToString() ??
            ComputerMouseMoveInput?.ToString() ??
            ComputerLeftMouseDownInput?.ToString() ??
            ComputerLeftMouseUpInput?.ToString() ??
            ComputerLeftClickInput?.ToString() ??
            ComputerLeftClickDragInput?.ToString() ??
            ComputerRightClickInput?.ToString() ??
            ComputerMiddleClickInput?.ToString() ??
            ComputerDoubleClickInput?.ToString() ??
            ComputerTripleClickInput?.ToString() ??
            ComputerScrollInput?.ToString() ??
            ComputerWaitInput?.ToString() ??
            ComputerScreenshotInput?.ToString() ??
            ComputerZoomInput?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsComputerKeyInput || IsComputerHoldKeyInput || IsComputerTypeInput || IsComputerCursorPositionInput || IsComputerMouseMoveInput || IsComputerLeftMouseDownInput || IsComputerLeftMouseUpInput || IsComputerLeftClickInput || IsComputerLeftClickDragInput || IsComputerRightClickInput || IsComputerMiddleClickInput || IsComputerDoubleClickInput || IsComputerTripleClickInput || IsComputerScrollInput || IsComputerWaitInput || IsComputerScreenshotInput || IsComputerZoomInput;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaComputerKeyInput, TResult>? computerKeyInput = null,
            global::System.Func<global::Anthropic.BetaComputerHoldKeyInput, TResult>? computerHoldKeyInput = null,
            global::System.Func<global::Anthropic.BetaComputerTypeInput, TResult>? computerTypeInput = null,
            global::System.Func<global::Anthropic.BetaComputerCursorPositionInput, TResult>? computerCursorPositionInput = null,
            global::System.Func<global::Anthropic.BetaComputerMouseMoveInput, TResult>? computerMouseMoveInput = null,
            global::System.Func<global::Anthropic.BetaComputerLeftMouseDownInput, TResult>? computerLeftMouseDownInput = null,
            global::System.Func<global::Anthropic.BetaComputerLeftMouseUpInput, TResult>? computerLeftMouseUpInput = null,
            global::System.Func<global::Anthropic.BetaComputerLeftClickInput, TResult>? computerLeftClickInput = null,
            global::System.Func<global::Anthropic.BetaComputerLeftClickDragInput, TResult>? computerLeftClickDragInput = null,
            global::System.Func<global::Anthropic.BetaComputerRightClickInput, TResult>? computerRightClickInput = null,
            global::System.Func<global::Anthropic.BetaComputerMiddleClickInput, TResult>? computerMiddleClickInput = null,
            global::System.Func<global::Anthropic.BetaComputerDoubleClickInput, TResult>? computerDoubleClickInput = null,
            global::System.Func<global::Anthropic.BetaComputerTripleClickInput, TResult>? computerTripleClickInput = null,
            global::System.Func<global::Anthropic.BetaComputerScrollInput, TResult>? computerScrollInput = null,
            global::System.Func<global::Anthropic.BetaComputerWaitInput, TResult>? computerWaitInput = null,
            global::System.Func<global::Anthropic.BetaComputerScreenshotInput, TResult>? computerScreenshotInput = null,
            global::System.Func<global::Anthropic.BetaComputerZoomInput, TResult>? computerZoomInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ComputerKeyInput is { } __value0 && computerKeyInput != null)
            {
                return computerKeyInput(__value0);
            }
            else if (ComputerHoldKeyInput is { } __value1 && computerHoldKeyInput != null)
            {
                return computerHoldKeyInput(__value1);
            }
            else if (ComputerTypeInput is { } __value2 && computerTypeInput != null)
            {
                return computerTypeInput(__value2);
            }
            else if (ComputerCursorPositionInput is { } __value3 && computerCursorPositionInput != null)
            {
                return computerCursorPositionInput(__value3);
            }
            else if (ComputerMouseMoveInput is { } __value4 && computerMouseMoveInput != null)
            {
                return computerMouseMoveInput(__value4);
            }
            else if (ComputerLeftMouseDownInput is { } __value5 && computerLeftMouseDownInput != null)
            {
                return computerLeftMouseDownInput(__value5);
            }
            else if (ComputerLeftMouseUpInput is { } __value6 && computerLeftMouseUpInput != null)
            {
                return computerLeftMouseUpInput(__value6);
            }
            else if (ComputerLeftClickInput is { } __value7 && computerLeftClickInput != null)
            {
                return computerLeftClickInput(__value7);
            }
            else if (ComputerLeftClickDragInput is { } __value8 && computerLeftClickDragInput != null)
            {
                return computerLeftClickDragInput(__value8);
            }
            else if (ComputerRightClickInput is { } __value9 && computerRightClickInput != null)
            {
                return computerRightClickInput(__value9);
            }
            else if (ComputerMiddleClickInput is { } __value10 && computerMiddleClickInput != null)
            {
                return computerMiddleClickInput(__value10);
            }
            else if (ComputerDoubleClickInput is { } __value11 && computerDoubleClickInput != null)
            {
                return computerDoubleClickInput(__value11);
            }
            else if (ComputerTripleClickInput is { } __value12 && computerTripleClickInput != null)
            {
                return computerTripleClickInput(__value12);
            }
            else if (ComputerScrollInput is { } __value13 && computerScrollInput != null)
            {
                return computerScrollInput(__value13);
            }
            else if (ComputerWaitInput is { } __value14 && computerWaitInput != null)
            {
                return computerWaitInput(__value14);
            }
            else if (ComputerScreenshotInput is { } __value15 && computerScreenshotInput != null)
            {
                return computerScreenshotInput(__value15);
            }
            else if (ComputerZoomInput is { } __value16 && computerZoomInput != null)
            {
                return computerZoomInput(__value16);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaComputerKeyInput>? computerKeyInput = null,

            global::System.Action<global::Anthropic.BetaComputerHoldKeyInput>? computerHoldKeyInput = null,

            global::System.Action<global::Anthropic.BetaComputerTypeInput>? computerTypeInput = null,

            global::System.Action<global::Anthropic.BetaComputerCursorPositionInput>? computerCursorPositionInput = null,

            global::System.Action<global::Anthropic.BetaComputerMouseMoveInput>? computerMouseMoveInput = null,

            global::System.Action<global::Anthropic.BetaComputerLeftMouseDownInput>? computerLeftMouseDownInput = null,

            global::System.Action<global::Anthropic.BetaComputerLeftMouseUpInput>? computerLeftMouseUpInput = null,

            global::System.Action<global::Anthropic.BetaComputerLeftClickInput>? computerLeftClickInput = null,

            global::System.Action<global::Anthropic.BetaComputerLeftClickDragInput>? computerLeftClickDragInput = null,

            global::System.Action<global::Anthropic.BetaComputerRightClickInput>? computerRightClickInput = null,

            global::System.Action<global::Anthropic.BetaComputerMiddleClickInput>? computerMiddleClickInput = null,

            global::System.Action<global::Anthropic.BetaComputerDoubleClickInput>? computerDoubleClickInput = null,

            global::System.Action<global::Anthropic.BetaComputerTripleClickInput>? computerTripleClickInput = null,

            global::System.Action<global::Anthropic.BetaComputerScrollInput>? computerScrollInput = null,

            global::System.Action<global::Anthropic.BetaComputerWaitInput>? computerWaitInput = null,

            global::System.Action<global::Anthropic.BetaComputerScreenshotInput>? computerScreenshotInput = null,

            global::System.Action<global::Anthropic.BetaComputerZoomInput>? computerZoomInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ComputerKeyInput is { } __value0)
            {
                computerKeyInput?.Invoke(__value0);
            }
            else if (ComputerHoldKeyInput is { } __value1)
            {
                computerHoldKeyInput?.Invoke(__value1);
            }
            else if (ComputerTypeInput is { } __value2)
            {
                computerTypeInput?.Invoke(__value2);
            }
            else if (ComputerCursorPositionInput is { } __value3)
            {
                computerCursorPositionInput?.Invoke(__value3);
            }
            else if (ComputerMouseMoveInput is { } __value4)
            {
                computerMouseMoveInput?.Invoke(__value4);
            }
            else if (ComputerLeftMouseDownInput is { } __value5)
            {
                computerLeftMouseDownInput?.Invoke(__value5);
            }
            else if (ComputerLeftMouseUpInput is { } __value6)
            {
                computerLeftMouseUpInput?.Invoke(__value6);
            }
            else if (ComputerLeftClickInput is { } __value7)
            {
                computerLeftClickInput?.Invoke(__value7);
            }
            else if (ComputerLeftClickDragInput is { } __value8)
            {
                computerLeftClickDragInput?.Invoke(__value8);
            }
            else if (ComputerRightClickInput is { } __value9)
            {
                computerRightClickInput?.Invoke(__value9);
            }
            else if (ComputerMiddleClickInput is { } __value10)
            {
                computerMiddleClickInput?.Invoke(__value10);
            }
            else if (ComputerDoubleClickInput is { } __value11)
            {
                computerDoubleClickInput?.Invoke(__value11);
            }
            else if (ComputerTripleClickInput is { } __value12)
            {
                computerTripleClickInput?.Invoke(__value12);
            }
            else if (ComputerScrollInput is { } __value13)
            {
                computerScrollInput?.Invoke(__value13);
            }
            else if (ComputerWaitInput is { } __value14)
            {
                computerWaitInput?.Invoke(__value14);
            }
            else if (ComputerScreenshotInput is { } __value15)
            {
                computerScreenshotInput?.Invoke(__value15);
            }
            else if (ComputerZoomInput is { } __value16)
            {
                computerZoomInput?.Invoke(__value16);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaComputerKeyInput>? computerKeyInput = null,
            global::System.Action<global::Anthropic.BetaComputerHoldKeyInput>? computerHoldKeyInput = null,
            global::System.Action<global::Anthropic.BetaComputerTypeInput>? computerTypeInput = null,
            global::System.Action<global::Anthropic.BetaComputerCursorPositionInput>? computerCursorPositionInput = null,
            global::System.Action<global::Anthropic.BetaComputerMouseMoveInput>? computerMouseMoveInput = null,
            global::System.Action<global::Anthropic.BetaComputerLeftMouseDownInput>? computerLeftMouseDownInput = null,
            global::System.Action<global::Anthropic.BetaComputerLeftMouseUpInput>? computerLeftMouseUpInput = null,
            global::System.Action<global::Anthropic.BetaComputerLeftClickInput>? computerLeftClickInput = null,
            global::System.Action<global::Anthropic.BetaComputerLeftClickDragInput>? computerLeftClickDragInput = null,
            global::System.Action<global::Anthropic.BetaComputerRightClickInput>? computerRightClickInput = null,
            global::System.Action<global::Anthropic.BetaComputerMiddleClickInput>? computerMiddleClickInput = null,
            global::System.Action<global::Anthropic.BetaComputerDoubleClickInput>? computerDoubleClickInput = null,
            global::System.Action<global::Anthropic.BetaComputerTripleClickInput>? computerTripleClickInput = null,
            global::System.Action<global::Anthropic.BetaComputerScrollInput>? computerScrollInput = null,
            global::System.Action<global::Anthropic.BetaComputerWaitInput>? computerWaitInput = null,
            global::System.Action<global::Anthropic.BetaComputerScreenshotInput>? computerScreenshotInput = null,
            global::System.Action<global::Anthropic.BetaComputerZoomInput>? computerZoomInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ComputerKeyInput is { } __value0)
            {
                computerKeyInput?.Invoke(__value0);
            }
            else if (ComputerHoldKeyInput is { } __value1)
            {
                computerHoldKeyInput?.Invoke(__value1);
            }
            else if (ComputerTypeInput is { } __value2)
            {
                computerTypeInput?.Invoke(__value2);
            }
            else if (ComputerCursorPositionInput is { } __value3)
            {
                computerCursorPositionInput?.Invoke(__value3);
            }
            else if (ComputerMouseMoveInput is { } __value4)
            {
                computerMouseMoveInput?.Invoke(__value4);
            }
            else if (ComputerLeftMouseDownInput is { } __value5)
            {
                computerLeftMouseDownInput?.Invoke(__value5);
            }
            else if (ComputerLeftMouseUpInput is { } __value6)
            {
                computerLeftMouseUpInput?.Invoke(__value6);
            }
            else if (ComputerLeftClickInput is { } __value7)
            {
                computerLeftClickInput?.Invoke(__value7);
            }
            else if (ComputerLeftClickDragInput is { } __value8)
            {
                computerLeftClickDragInput?.Invoke(__value8);
            }
            else if (ComputerRightClickInput is { } __value9)
            {
                computerRightClickInput?.Invoke(__value9);
            }
            else if (ComputerMiddleClickInput is { } __value10)
            {
                computerMiddleClickInput?.Invoke(__value10);
            }
            else if (ComputerDoubleClickInput is { } __value11)
            {
                computerDoubleClickInput?.Invoke(__value11);
            }
            else if (ComputerTripleClickInput is { } __value12)
            {
                computerTripleClickInput?.Invoke(__value12);
            }
            else if (ComputerScrollInput is { } __value13)
            {
                computerScrollInput?.Invoke(__value13);
            }
            else if (ComputerWaitInput is { } __value14)
            {
                computerWaitInput?.Invoke(__value14);
            }
            else if (ComputerScreenshotInput is { } __value15)
            {
                computerScreenshotInput?.Invoke(__value15);
            }
            else if (ComputerZoomInput is { } __value16)
            {
                computerZoomInput?.Invoke(__value16);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ComputerKeyInput,
                typeof(global::Anthropic.BetaComputerKeyInput),
                ComputerHoldKeyInput,
                typeof(global::Anthropic.BetaComputerHoldKeyInput),
                ComputerTypeInput,
                typeof(global::Anthropic.BetaComputerTypeInput),
                ComputerCursorPositionInput,
                typeof(global::Anthropic.BetaComputerCursorPositionInput),
                ComputerMouseMoveInput,
                typeof(global::Anthropic.BetaComputerMouseMoveInput),
                ComputerLeftMouseDownInput,
                typeof(global::Anthropic.BetaComputerLeftMouseDownInput),
                ComputerLeftMouseUpInput,
                typeof(global::Anthropic.BetaComputerLeftMouseUpInput),
                ComputerLeftClickInput,
                typeof(global::Anthropic.BetaComputerLeftClickInput),
                ComputerLeftClickDragInput,
                typeof(global::Anthropic.BetaComputerLeftClickDragInput),
                ComputerRightClickInput,
                typeof(global::Anthropic.BetaComputerRightClickInput),
                ComputerMiddleClickInput,
                typeof(global::Anthropic.BetaComputerMiddleClickInput),
                ComputerDoubleClickInput,
                typeof(global::Anthropic.BetaComputerDoubleClickInput),
                ComputerTripleClickInput,
                typeof(global::Anthropic.BetaComputerTripleClickInput),
                ComputerScrollInput,
                typeof(global::Anthropic.BetaComputerScrollInput),
                ComputerWaitInput,
                typeof(global::Anthropic.BetaComputerWaitInput),
                ComputerScreenshotInput,
                typeof(global::Anthropic.BetaComputerScreenshotInput),
                ComputerZoomInput,
                typeof(global::Anthropic.BetaComputerZoomInput),
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
        public bool Equals(BetaComputerMemberInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerKeyInput?>.Default.Equals(ComputerKeyInput, other.ComputerKeyInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerHoldKeyInput?>.Default.Equals(ComputerHoldKeyInput, other.ComputerHoldKeyInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerTypeInput?>.Default.Equals(ComputerTypeInput, other.ComputerTypeInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerCursorPositionInput?>.Default.Equals(ComputerCursorPositionInput, other.ComputerCursorPositionInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerMouseMoveInput?>.Default.Equals(ComputerMouseMoveInput, other.ComputerMouseMoveInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerLeftMouseDownInput?>.Default.Equals(ComputerLeftMouseDownInput, other.ComputerLeftMouseDownInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerLeftMouseUpInput?>.Default.Equals(ComputerLeftMouseUpInput, other.ComputerLeftMouseUpInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerLeftClickInput?>.Default.Equals(ComputerLeftClickInput, other.ComputerLeftClickInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerLeftClickDragInput?>.Default.Equals(ComputerLeftClickDragInput, other.ComputerLeftClickDragInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerRightClickInput?>.Default.Equals(ComputerRightClickInput, other.ComputerRightClickInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerMiddleClickInput?>.Default.Equals(ComputerMiddleClickInput, other.ComputerMiddleClickInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerDoubleClickInput?>.Default.Equals(ComputerDoubleClickInput, other.ComputerDoubleClickInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerTripleClickInput?>.Default.Equals(ComputerTripleClickInput, other.ComputerTripleClickInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerScrollInput?>.Default.Equals(ComputerScrollInput, other.ComputerScrollInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerWaitInput?>.Default.Equals(ComputerWaitInput, other.ComputerWaitInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerScreenshotInput?>.Default.Equals(ComputerScreenshotInput, other.ComputerScreenshotInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerZoomInput?>.Default.Equals(ComputerZoomInput, other.ComputerZoomInput)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaComputerMemberInput obj1, BetaComputerMemberInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaComputerMemberInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaComputerMemberInput obj1, BetaComputerMemberInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaComputerMemberInput o && Equals(o);
        }
    }
}
