#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The `input` of a computer toolset member `tool_use` block: the member's own parameters.
    /// </summary>
    public readonly partial struct ComputerMemberInput : global::System.IEquatable<ComputerMemberInput>
    {
        /// <summary>
        /// Press a key or key-combination on the keyboard. Use "+" to combine modifiers with<br/>
        /// a key (e.g. "ctrl+s", "alt+Tab", "ctrl+shift+Escape"). Key names are<br/>
        /// case-insensitive; common names like "Return", "Tab", "Escape", "Up", "Down",<br/>
        /// "Left", "Right", "Home", "End", "Page_Up", "Page_Down", "Delete", "BackSpace" are<br/>
        /// supported.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ComputerKeyInput? ComputerKeyInput { get; init; }
#else
        public global::Anthropic.ComputerKeyInput? ComputerKeyInput { get; }
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
            out global::Anthropic.ComputerKeyInput? value)
        {
            value = ComputerKeyInput;
            return IsComputerKeyInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerKeyInput PickComputerKeyInput() => ComputerKeyInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerKeyInput' but the value was {ToString()}.");

        /// <summary>
        /// Hold down a key or key-combination for a specified duration. Uses the same key<br/>
        /// syntax as `key`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ComputerHoldKeyInput? ComputerHoldKeyInput { get; init; }
#else
        public global::Anthropic.ComputerHoldKeyInput? ComputerHoldKeyInput { get; }
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
            out global::Anthropic.ComputerHoldKeyInput? value)
        {
            value = ComputerHoldKeyInput;
            return IsComputerHoldKeyInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerHoldKeyInput PickComputerHoldKeyInput() => ComputerHoldKeyInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerHoldKeyInput' but the value was {ToString()}.");

        /// <summary>
        /// Type a string of text on the keyboard.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ComputerTypeInput? ComputerTypeInput { get; init; }
#else
        public global::Anthropic.ComputerTypeInput? ComputerTypeInput { get; }
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
            out global::Anthropic.ComputerTypeInput? value)
        {
            value = ComputerTypeInput;
            return IsComputerTypeInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTypeInput PickComputerTypeInput() => ComputerTypeInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerTypeInput' but the value was {ToString()}.");

        /// <summary>
        /// Get the current (x, y) pixel coordinate of the cursor.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ComputerCursorPositionInput? ComputerCursorPositionInput { get; init; }
#else
        public global::Anthropic.ComputerCursorPositionInput? ComputerCursorPositionInput { get; }
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
            out global::Anthropic.ComputerCursorPositionInput? value)
        {
            value = ComputerCursorPositionInput;
            return IsComputerCursorPositionInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerCursorPositionInput PickComputerCursorPositionInput() => ComputerCursorPositionInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerCursorPositionInput' but the value was {ToString()}.");

        /// <summary>
        /// Move the cursor to a specified (x, y) pixel coordinate. Use this ONLY to hover<br/>
        /// without clicking; otherwise use a click action directly.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ComputerMouseMoveInput? ComputerMouseMoveInput { get; init; }
#else
        public global::Anthropic.ComputerMouseMoveInput? ComputerMouseMoveInput { get; }
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
            out global::Anthropic.ComputerMouseMoveInput? value)
        {
            value = ComputerMouseMoveInput;
            return IsComputerMouseMoveInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMouseMoveInput PickComputerMouseMoveInput() => ComputerMouseMoveInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerMouseMoveInput' but the value was {ToString()}.");

        /// <summary>
        /// Press and hold the left mouse button at the current cursor position.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ComputerLeftMouseDownInput? ComputerLeftMouseDownInput { get; init; }
#else
        public global::Anthropic.ComputerLeftMouseDownInput? ComputerLeftMouseDownInput { get; }
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
            out global::Anthropic.ComputerLeftMouseDownInput? value)
        {
            value = ComputerLeftMouseDownInput;
            return IsComputerLeftMouseDownInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseDownInput PickComputerLeftMouseDownInput() => ComputerLeftMouseDownInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerLeftMouseDownInput' but the value was {ToString()}.");

        /// <summary>
        /// Release the left mouse button.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ComputerLeftMouseUpInput? ComputerLeftMouseUpInput { get; init; }
#else
        public global::Anthropic.ComputerLeftMouseUpInput? ComputerLeftMouseUpInput { get; }
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
            out global::Anthropic.ComputerLeftMouseUpInput? value)
        {
            value = ComputerLeftMouseUpInput;
            return IsComputerLeftMouseUpInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftMouseUpInput PickComputerLeftMouseUpInput() => ComputerLeftMouseUpInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerLeftMouseUpInput' but the value was {ToString()}.");

        /// <summary>
        /// Click the left mouse button at the specified (x, y) pixel coordinate, or the<br/>
        /// current cursor position if `coordinate` is omitted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ComputerLeftClickInput? ComputerLeftClickInput { get; init; }
#else
        public global::Anthropic.ComputerLeftClickInput? ComputerLeftClickInput { get; }
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
            out global::Anthropic.ComputerLeftClickInput? value)
        {
            value = ComputerLeftClickInput;
            return IsComputerLeftClickInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickInput PickComputerLeftClickInput() => ComputerLeftClickInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerLeftClickInput' but the value was {ToString()}.");

        /// <summary>
        /// Click and drag the cursor from `start_coordinate` to `coordinate`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ComputerLeftClickDragInput? ComputerLeftClickDragInput { get; init; }
#else
        public global::Anthropic.ComputerLeftClickDragInput? ComputerLeftClickDragInput { get; }
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
            out global::Anthropic.ComputerLeftClickDragInput? value)
        {
            value = ComputerLeftClickDragInput;
            return IsComputerLeftClickDragInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerLeftClickDragInput PickComputerLeftClickDragInput() => ComputerLeftClickDragInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerLeftClickDragInput' but the value was {ToString()}.");

        /// <summary>
        /// Click the right mouse button at the specified (x, y) pixel coordinate, or the<br/>
        /// current cursor position if `coordinate` is omitted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ComputerRightClickInput? ComputerRightClickInput { get; init; }
#else
        public global::Anthropic.ComputerRightClickInput? ComputerRightClickInput { get; }
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
            out global::Anthropic.ComputerRightClickInput? value)
        {
            value = ComputerRightClickInput;
            return IsComputerRightClickInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerRightClickInput PickComputerRightClickInput() => ComputerRightClickInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerRightClickInput' but the value was {ToString()}.");

        /// <summary>
        /// Click the middle mouse button at the specified (x, y) pixel coordinate, or the<br/>
        /// current cursor position if `coordinate` is omitted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ComputerMiddleClickInput? ComputerMiddleClickInput { get; init; }
#else
        public global::Anthropic.ComputerMiddleClickInput? ComputerMiddleClickInput { get; }
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
            out global::Anthropic.ComputerMiddleClickInput? value)
        {
            value = ComputerMiddleClickInput;
            return IsComputerMiddleClickInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerMiddleClickInput PickComputerMiddleClickInput() => ComputerMiddleClickInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerMiddleClickInput' but the value was {ToString()}.");

        /// <summary>
        /// Double-click the left mouse button at the specified (x, y) pixel coordinate, or<br/>
        /// the current cursor position if `coordinate` is omitted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ComputerDoubleClickInput? ComputerDoubleClickInput { get; init; }
#else
        public global::Anthropic.ComputerDoubleClickInput? ComputerDoubleClickInput { get; }
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
            out global::Anthropic.ComputerDoubleClickInput? value)
        {
            value = ComputerDoubleClickInput;
            return IsComputerDoubleClickInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerDoubleClickInput PickComputerDoubleClickInput() => ComputerDoubleClickInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerDoubleClickInput' but the value was {ToString()}.");

        /// <summary>
        /// Triple-click the left mouse button at the specified (x, y) pixel coordinate, or<br/>
        /// the current cursor position if `coordinate` is omitted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ComputerTripleClickInput? ComputerTripleClickInput { get; init; }
#else
        public global::Anthropic.ComputerTripleClickInput? ComputerTripleClickInput { get; }
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
            out global::Anthropic.ComputerTripleClickInput? value)
        {
            value = ComputerTripleClickInput;
            return IsComputerTripleClickInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerTripleClickInput PickComputerTripleClickInput() => ComputerTripleClickInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerTripleClickInput' but the value was {ToString()}.");

        /// <summary>
        /// Scroll the screen at the specified (x, y) pixel coordinate, or the current cursor<br/>
        /// position if `coordinate` is omitted. Do NOT use PageUp/PageDown to scroll.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ComputerScrollInput? ComputerScrollInput { get; init; }
#else
        public global::Anthropic.ComputerScrollInput? ComputerScrollInput { get; }
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
            out global::Anthropic.ComputerScrollInput? value)
        {
            value = ComputerScrollInput;
            return IsComputerScrollInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScrollInput PickComputerScrollInput() => ComputerScrollInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerScrollInput' but the value was {ToString()}.");

        /// <summary>
        /// Wait for a specified duration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ComputerWaitInput? ComputerWaitInput { get; init; }
#else
        public global::Anthropic.ComputerWaitInput? ComputerWaitInput { get; }
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
            out global::Anthropic.ComputerWaitInput? value)
        {
            value = ComputerWaitInput;
            return IsComputerWaitInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerWaitInput PickComputerWaitInput() => ComputerWaitInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerWaitInput' but the value was {ToString()}.");

        /// <summary>
        /// Take a screenshot of the screen.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ComputerScreenshotInput? ComputerScreenshotInput { get; init; }
#else
        public global::Anthropic.ComputerScreenshotInput? ComputerScreenshotInput { get; }
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
            out global::Anthropic.ComputerScreenshotInput? value)
        {
            value = ComputerScreenshotInput;
            return IsComputerScreenshotInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerScreenshotInput PickComputerScreenshotInput() => ComputerScreenshotInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerScreenshotInput' but the value was {ToString()}.");

        /// <summary>
        /// Take a screenshot of a rectangular region. Region coordinates are in the<br/>
        /// full-screenshot space (not physical display pixels). The crop is scaled up to<br/>
        /// fill the image budget so fine details become legible.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ComputerZoomInput? ComputerZoomInput { get; init; }
#else
        public global::Anthropic.ComputerZoomInput? ComputerZoomInput { get; }
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
            out global::Anthropic.ComputerZoomInput? value)
        {
            value = ComputerZoomInput;
            return IsComputerZoomInput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerZoomInput PickComputerZoomInput() => ComputerZoomInput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerZoomInput' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerMemberInput(global::Anthropic.ComputerKeyInput value) => new ComputerMemberInput((global::Anthropic.ComputerKeyInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComputerKeyInput?(ComputerMemberInput @this) => @this.ComputerKeyInput;

        /// <summary>
        ///
        /// </summary>
        public ComputerMemberInput(global::Anthropic.ComputerKeyInput? value)
        {
            ComputerKeyInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerMemberInput FromComputerKeyInput(global::Anthropic.ComputerKeyInput? value) => new ComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerMemberInput(global::Anthropic.ComputerHoldKeyInput value) => new ComputerMemberInput((global::Anthropic.ComputerHoldKeyInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComputerHoldKeyInput?(ComputerMemberInput @this) => @this.ComputerHoldKeyInput;

        /// <summary>
        ///
        /// </summary>
        public ComputerMemberInput(global::Anthropic.ComputerHoldKeyInput? value)
        {
            ComputerHoldKeyInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerMemberInput FromComputerHoldKeyInput(global::Anthropic.ComputerHoldKeyInput? value) => new ComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerMemberInput(global::Anthropic.ComputerTypeInput value) => new ComputerMemberInput((global::Anthropic.ComputerTypeInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComputerTypeInput?(ComputerMemberInput @this) => @this.ComputerTypeInput;

        /// <summary>
        ///
        /// </summary>
        public ComputerMemberInput(global::Anthropic.ComputerTypeInput? value)
        {
            ComputerTypeInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerMemberInput FromComputerTypeInput(global::Anthropic.ComputerTypeInput? value) => new ComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerMemberInput(global::Anthropic.ComputerCursorPositionInput value) => new ComputerMemberInput((global::Anthropic.ComputerCursorPositionInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComputerCursorPositionInput?(ComputerMemberInput @this) => @this.ComputerCursorPositionInput;

        /// <summary>
        ///
        /// </summary>
        public ComputerMemberInput(global::Anthropic.ComputerCursorPositionInput? value)
        {
            ComputerCursorPositionInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerMemberInput FromComputerCursorPositionInput(global::Anthropic.ComputerCursorPositionInput? value) => new ComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerMemberInput(global::Anthropic.ComputerMouseMoveInput value) => new ComputerMemberInput((global::Anthropic.ComputerMouseMoveInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComputerMouseMoveInput?(ComputerMemberInput @this) => @this.ComputerMouseMoveInput;

        /// <summary>
        ///
        /// </summary>
        public ComputerMemberInput(global::Anthropic.ComputerMouseMoveInput? value)
        {
            ComputerMouseMoveInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerMemberInput FromComputerMouseMoveInput(global::Anthropic.ComputerMouseMoveInput? value) => new ComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerMemberInput(global::Anthropic.ComputerLeftMouseDownInput value) => new ComputerMemberInput((global::Anthropic.ComputerLeftMouseDownInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComputerLeftMouseDownInput?(ComputerMemberInput @this) => @this.ComputerLeftMouseDownInput;

        /// <summary>
        ///
        /// </summary>
        public ComputerMemberInput(global::Anthropic.ComputerLeftMouseDownInput? value)
        {
            ComputerLeftMouseDownInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerMemberInput FromComputerLeftMouseDownInput(global::Anthropic.ComputerLeftMouseDownInput? value) => new ComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerMemberInput(global::Anthropic.ComputerLeftMouseUpInput value) => new ComputerMemberInput((global::Anthropic.ComputerLeftMouseUpInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComputerLeftMouseUpInput?(ComputerMemberInput @this) => @this.ComputerLeftMouseUpInput;

        /// <summary>
        ///
        /// </summary>
        public ComputerMemberInput(global::Anthropic.ComputerLeftMouseUpInput? value)
        {
            ComputerLeftMouseUpInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerMemberInput FromComputerLeftMouseUpInput(global::Anthropic.ComputerLeftMouseUpInput? value) => new ComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerMemberInput(global::Anthropic.ComputerLeftClickInput value) => new ComputerMemberInput((global::Anthropic.ComputerLeftClickInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComputerLeftClickInput?(ComputerMemberInput @this) => @this.ComputerLeftClickInput;

        /// <summary>
        ///
        /// </summary>
        public ComputerMemberInput(global::Anthropic.ComputerLeftClickInput? value)
        {
            ComputerLeftClickInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerMemberInput FromComputerLeftClickInput(global::Anthropic.ComputerLeftClickInput? value) => new ComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerMemberInput(global::Anthropic.ComputerLeftClickDragInput value) => new ComputerMemberInput((global::Anthropic.ComputerLeftClickDragInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComputerLeftClickDragInput?(ComputerMemberInput @this) => @this.ComputerLeftClickDragInput;

        /// <summary>
        ///
        /// </summary>
        public ComputerMemberInput(global::Anthropic.ComputerLeftClickDragInput? value)
        {
            ComputerLeftClickDragInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerMemberInput FromComputerLeftClickDragInput(global::Anthropic.ComputerLeftClickDragInput? value) => new ComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerMemberInput(global::Anthropic.ComputerRightClickInput value) => new ComputerMemberInput((global::Anthropic.ComputerRightClickInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComputerRightClickInput?(ComputerMemberInput @this) => @this.ComputerRightClickInput;

        /// <summary>
        ///
        /// </summary>
        public ComputerMemberInput(global::Anthropic.ComputerRightClickInput? value)
        {
            ComputerRightClickInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerMemberInput FromComputerRightClickInput(global::Anthropic.ComputerRightClickInput? value) => new ComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerMemberInput(global::Anthropic.ComputerMiddleClickInput value) => new ComputerMemberInput((global::Anthropic.ComputerMiddleClickInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComputerMiddleClickInput?(ComputerMemberInput @this) => @this.ComputerMiddleClickInput;

        /// <summary>
        ///
        /// </summary>
        public ComputerMemberInput(global::Anthropic.ComputerMiddleClickInput? value)
        {
            ComputerMiddleClickInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerMemberInput FromComputerMiddleClickInput(global::Anthropic.ComputerMiddleClickInput? value) => new ComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerMemberInput(global::Anthropic.ComputerDoubleClickInput value) => new ComputerMemberInput((global::Anthropic.ComputerDoubleClickInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComputerDoubleClickInput?(ComputerMemberInput @this) => @this.ComputerDoubleClickInput;

        /// <summary>
        ///
        /// </summary>
        public ComputerMemberInput(global::Anthropic.ComputerDoubleClickInput? value)
        {
            ComputerDoubleClickInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerMemberInput FromComputerDoubleClickInput(global::Anthropic.ComputerDoubleClickInput? value) => new ComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerMemberInput(global::Anthropic.ComputerTripleClickInput value) => new ComputerMemberInput((global::Anthropic.ComputerTripleClickInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComputerTripleClickInput?(ComputerMemberInput @this) => @this.ComputerTripleClickInput;

        /// <summary>
        ///
        /// </summary>
        public ComputerMemberInput(global::Anthropic.ComputerTripleClickInput? value)
        {
            ComputerTripleClickInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerMemberInput FromComputerTripleClickInput(global::Anthropic.ComputerTripleClickInput? value) => new ComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerMemberInput(global::Anthropic.ComputerScrollInput value) => new ComputerMemberInput((global::Anthropic.ComputerScrollInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComputerScrollInput?(ComputerMemberInput @this) => @this.ComputerScrollInput;

        /// <summary>
        ///
        /// </summary>
        public ComputerMemberInput(global::Anthropic.ComputerScrollInput? value)
        {
            ComputerScrollInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerMemberInput FromComputerScrollInput(global::Anthropic.ComputerScrollInput? value) => new ComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerMemberInput(global::Anthropic.ComputerWaitInput value) => new ComputerMemberInput((global::Anthropic.ComputerWaitInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComputerWaitInput?(ComputerMemberInput @this) => @this.ComputerWaitInput;

        /// <summary>
        ///
        /// </summary>
        public ComputerMemberInput(global::Anthropic.ComputerWaitInput? value)
        {
            ComputerWaitInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerMemberInput FromComputerWaitInput(global::Anthropic.ComputerWaitInput? value) => new ComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerMemberInput(global::Anthropic.ComputerScreenshotInput value) => new ComputerMemberInput((global::Anthropic.ComputerScreenshotInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComputerScreenshotInput?(ComputerMemberInput @this) => @this.ComputerScreenshotInput;

        /// <summary>
        ///
        /// </summary>
        public ComputerMemberInput(global::Anthropic.ComputerScreenshotInput? value)
        {
            ComputerScreenshotInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerMemberInput FromComputerScreenshotInput(global::Anthropic.ComputerScreenshotInput? value) => new ComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComputerMemberInput(global::Anthropic.ComputerZoomInput value) => new ComputerMemberInput((global::Anthropic.ComputerZoomInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComputerZoomInput?(ComputerMemberInput @this) => @this.ComputerZoomInput;

        /// <summary>
        ///
        /// </summary>
        public ComputerMemberInput(global::Anthropic.ComputerZoomInput? value)
        {
            ComputerZoomInput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComputerMemberInput FromComputerZoomInput(global::Anthropic.ComputerZoomInput? value) => new ComputerMemberInput(value);

        /// <summary>
        ///
        /// </summary>
        public ComputerMemberInput(
            global::Anthropic.ComputerKeyInput? computerKeyInput,
            global::Anthropic.ComputerHoldKeyInput? computerHoldKeyInput,
            global::Anthropic.ComputerTypeInput? computerTypeInput,
            global::Anthropic.ComputerCursorPositionInput? computerCursorPositionInput,
            global::Anthropic.ComputerMouseMoveInput? computerMouseMoveInput,
            global::Anthropic.ComputerLeftMouseDownInput? computerLeftMouseDownInput,
            global::Anthropic.ComputerLeftMouseUpInput? computerLeftMouseUpInput,
            global::Anthropic.ComputerLeftClickInput? computerLeftClickInput,
            global::Anthropic.ComputerLeftClickDragInput? computerLeftClickDragInput,
            global::Anthropic.ComputerRightClickInput? computerRightClickInput,
            global::Anthropic.ComputerMiddleClickInput? computerMiddleClickInput,
            global::Anthropic.ComputerDoubleClickInput? computerDoubleClickInput,
            global::Anthropic.ComputerTripleClickInput? computerTripleClickInput,
            global::Anthropic.ComputerScrollInput? computerScrollInput,
            global::Anthropic.ComputerWaitInput? computerWaitInput,
            global::Anthropic.ComputerScreenshotInput? computerScreenshotInput,
            global::Anthropic.ComputerZoomInput? computerZoomInput
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
            global::System.Func<global::Anthropic.ComputerKeyInput, TResult>? computerKeyInput = null,
            global::System.Func<global::Anthropic.ComputerHoldKeyInput, TResult>? computerHoldKeyInput = null,
            global::System.Func<global::Anthropic.ComputerTypeInput, TResult>? computerTypeInput = null,
            global::System.Func<global::Anthropic.ComputerCursorPositionInput, TResult>? computerCursorPositionInput = null,
            global::System.Func<global::Anthropic.ComputerMouseMoveInput, TResult>? computerMouseMoveInput = null,
            global::System.Func<global::Anthropic.ComputerLeftMouseDownInput, TResult>? computerLeftMouseDownInput = null,
            global::System.Func<global::Anthropic.ComputerLeftMouseUpInput, TResult>? computerLeftMouseUpInput = null,
            global::System.Func<global::Anthropic.ComputerLeftClickInput, TResult>? computerLeftClickInput = null,
            global::System.Func<global::Anthropic.ComputerLeftClickDragInput, TResult>? computerLeftClickDragInput = null,
            global::System.Func<global::Anthropic.ComputerRightClickInput, TResult>? computerRightClickInput = null,
            global::System.Func<global::Anthropic.ComputerMiddleClickInput, TResult>? computerMiddleClickInput = null,
            global::System.Func<global::Anthropic.ComputerDoubleClickInput, TResult>? computerDoubleClickInput = null,
            global::System.Func<global::Anthropic.ComputerTripleClickInput, TResult>? computerTripleClickInput = null,
            global::System.Func<global::Anthropic.ComputerScrollInput, TResult>? computerScrollInput = null,
            global::System.Func<global::Anthropic.ComputerWaitInput, TResult>? computerWaitInput = null,
            global::System.Func<global::Anthropic.ComputerScreenshotInput, TResult>? computerScreenshotInput = null,
            global::System.Func<global::Anthropic.ComputerZoomInput, TResult>? computerZoomInput = null,
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
            global::System.Action<global::Anthropic.ComputerKeyInput>? computerKeyInput = null,

            global::System.Action<global::Anthropic.ComputerHoldKeyInput>? computerHoldKeyInput = null,

            global::System.Action<global::Anthropic.ComputerTypeInput>? computerTypeInput = null,

            global::System.Action<global::Anthropic.ComputerCursorPositionInput>? computerCursorPositionInput = null,

            global::System.Action<global::Anthropic.ComputerMouseMoveInput>? computerMouseMoveInput = null,

            global::System.Action<global::Anthropic.ComputerLeftMouseDownInput>? computerLeftMouseDownInput = null,

            global::System.Action<global::Anthropic.ComputerLeftMouseUpInput>? computerLeftMouseUpInput = null,

            global::System.Action<global::Anthropic.ComputerLeftClickInput>? computerLeftClickInput = null,

            global::System.Action<global::Anthropic.ComputerLeftClickDragInput>? computerLeftClickDragInput = null,

            global::System.Action<global::Anthropic.ComputerRightClickInput>? computerRightClickInput = null,

            global::System.Action<global::Anthropic.ComputerMiddleClickInput>? computerMiddleClickInput = null,

            global::System.Action<global::Anthropic.ComputerDoubleClickInput>? computerDoubleClickInput = null,

            global::System.Action<global::Anthropic.ComputerTripleClickInput>? computerTripleClickInput = null,

            global::System.Action<global::Anthropic.ComputerScrollInput>? computerScrollInput = null,

            global::System.Action<global::Anthropic.ComputerWaitInput>? computerWaitInput = null,

            global::System.Action<global::Anthropic.ComputerScreenshotInput>? computerScreenshotInput = null,

            global::System.Action<global::Anthropic.ComputerZoomInput>? computerZoomInput = null,
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
            global::System.Action<global::Anthropic.ComputerKeyInput>? computerKeyInput = null,
            global::System.Action<global::Anthropic.ComputerHoldKeyInput>? computerHoldKeyInput = null,
            global::System.Action<global::Anthropic.ComputerTypeInput>? computerTypeInput = null,
            global::System.Action<global::Anthropic.ComputerCursorPositionInput>? computerCursorPositionInput = null,
            global::System.Action<global::Anthropic.ComputerMouseMoveInput>? computerMouseMoveInput = null,
            global::System.Action<global::Anthropic.ComputerLeftMouseDownInput>? computerLeftMouseDownInput = null,
            global::System.Action<global::Anthropic.ComputerLeftMouseUpInput>? computerLeftMouseUpInput = null,
            global::System.Action<global::Anthropic.ComputerLeftClickInput>? computerLeftClickInput = null,
            global::System.Action<global::Anthropic.ComputerLeftClickDragInput>? computerLeftClickDragInput = null,
            global::System.Action<global::Anthropic.ComputerRightClickInput>? computerRightClickInput = null,
            global::System.Action<global::Anthropic.ComputerMiddleClickInput>? computerMiddleClickInput = null,
            global::System.Action<global::Anthropic.ComputerDoubleClickInput>? computerDoubleClickInput = null,
            global::System.Action<global::Anthropic.ComputerTripleClickInput>? computerTripleClickInput = null,
            global::System.Action<global::Anthropic.ComputerScrollInput>? computerScrollInput = null,
            global::System.Action<global::Anthropic.ComputerWaitInput>? computerWaitInput = null,
            global::System.Action<global::Anthropic.ComputerScreenshotInput>? computerScreenshotInput = null,
            global::System.Action<global::Anthropic.ComputerZoomInput>? computerZoomInput = null,
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
                typeof(global::Anthropic.ComputerKeyInput),
                ComputerHoldKeyInput,
                typeof(global::Anthropic.ComputerHoldKeyInput),
                ComputerTypeInput,
                typeof(global::Anthropic.ComputerTypeInput),
                ComputerCursorPositionInput,
                typeof(global::Anthropic.ComputerCursorPositionInput),
                ComputerMouseMoveInput,
                typeof(global::Anthropic.ComputerMouseMoveInput),
                ComputerLeftMouseDownInput,
                typeof(global::Anthropic.ComputerLeftMouseDownInput),
                ComputerLeftMouseUpInput,
                typeof(global::Anthropic.ComputerLeftMouseUpInput),
                ComputerLeftClickInput,
                typeof(global::Anthropic.ComputerLeftClickInput),
                ComputerLeftClickDragInput,
                typeof(global::Anthropic.ComputerLeftClickDragInput),
                ComputerRightClickInput,
                typeof(global::Anthropic.ComputerRightClickInput),
                ComputerMiddleClickInput,
                typeof(global::Anthropic.ComputerMiddleClickInput),
                ComputerDoubleClickInput,
                typeof(global::Anthropic.ComputerDoubleClickInput),
                ComputerTripleClickInput,
                typeof(global::Anthropic.ComputerTripleClickInput),
                ComputerScrollInput,
                typeof(global::Anthropic.ComputerScrollInput),
                ComputerWaitInput,
                typeof(global::Anthropic.ComputerWaitInput),
                ComputerScreenshotInput,
                typeof(global::Anthropic.ComputerScreenshotInput),
                ComputerZoomInput,
                typeof(global::Anthropic.ComputerZoomInput),
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
        public bool Equals(ComputerMemberInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComputerKeyInput?>.Default.Equals(ComputerKeyInput, other.ComputerKeyInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComputerHoldKeyInput?>.Default.Equals(ComputerHoldKeyInput, other.ComputerHoldKeyInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComputerTypeInput?>.Default.Equals(ComputerTypeInput, other.ComputerTypeInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComputerCursorPositionInput?>.Default.Equals(ComputerCursorPositionInput, other.ComputerCursorPositionInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComputerMouseMoveInput?>.Default.Equals(ComputerMouseMoveInput, other.ComputerMouseMoveInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComputerLeftMouseDownInput?>.Default.Equals(ComputerLeftMouseDownInput, other.ComputerLeftMouseDownInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComputerLeftMouseUpInput?>.Default.Equals(ComputerLeftMouseUpInput, other.ComputerLeftMouseUpInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComputerLeftClickInput?>.Default.Equals(ComputerLeftClickInput, other.ComputerLeftClickInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComputerLeftClickDragInput?>.Default.Equals(ComputerLeftClickDragInput, other.ComputerLeftClickDragInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComputerRightClickInput?>.Default.Equals(ComputerRightClickInput, other.ComputerRightClickInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComputerMiddleClickInput?>.Default.Equals(ComputerMiddleClickInput, other.ComputerMiddleClickInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComputerDoubleClickInput?>.Default.Equals(ComputerDoubleClickInput, other.ComputerDoubleClickInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComputerTripleClickInput?>.Default.Equals(ComputerTripleClickInput, other.ComputerTripleClickInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComputerScrollInput?>.Default.Equals(ComputerScrollInput, other.ComputerScrollInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComputerWaitInput?>.Default.Equals(ComputerWaitInput, other.ComputerWaitInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComputerScreenshotInput?>.Default.Equals(ComputerScreenshotInput, other.ComputerScreenshotInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComputerZoomInput?>.Default.Equals(ComputerZoomInput, other.ComputerZoomInput)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ComputerMemberInput obj1, ComputerMemberInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ComputerMemberInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ComputerMemberInput obj1, ComputerMemberInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ComputerMemberInput o && Equals(o);
        }
    }
}
