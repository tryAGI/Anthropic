#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaResponseComputerToolUseBlockUnion : global::System.IEquatable<BetaResponseComputerToolUseBlockUnion>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName? Name { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseComputerKeyToolUseBlock? Key { get; init; }
#else
        public global::Anthropic.BetaResponseComputerKeyToolUseBlock? Key { get; }
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
            out global::Anthropic.BetaResponseComputerKeyToolUseBlock? value)
        {
            value = Key;
            return IsKey;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerKeyToolUseBlock PickKey() => Key is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Key' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock? HoldKey { get; init; }
#else
        public global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock? HoldKey { get; }
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
            out global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock? value)
        {
            value = HoldKey;
            return IsHoldKey;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock PickHoldKey() => HoldKey is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HoldKey' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseComputerTypeToolUseBlock? Type { get; init; }
#else
        public global::Anthropic.BetaResponseComputerTypeToolUseBlock? Type { get; }
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
            out global::Anthropic.BetaResponseComputerTypeToolUseBlock? value)
        {
            value = Type;
            return IsType;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerTypeToolUseBlock PickType() => Type is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Type' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock? CursorPosition { get; init; }
#else
        public global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock? CursorPosition { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CursorPosition))]
#endif
        public bool IsCursorPosition => CursorPosition != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCursorPosition(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock? value)
        {
            value = CursorPosition;
            return IsCursorPosition;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock PickCursorPosition() => CursorPosition is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CursorPosition' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock? MouseMove { get; init; }
#else
        public global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock? MouseMove { get; }
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
            out global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock? value)
        {
            value = MouseMove;
            return IsMouseMove;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock PickMouseMove() => MouseMove is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MouseMove' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock? LeftMouseDown { get; init; }
#else
        public global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock? LeftMouseDown { get; }
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
            out global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock? value)
        {
            value = LeftMouseDown;
            return IsLeftMouseDown;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock PickLeftMouseDown() => LeftMouseDown is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LeftMouseDown' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock? LeftMouseUp { get; init; }
#else
        public global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock? LeftMouseUp { get; }
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
            out global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock? value)
        {
            value = LeftMouseUp;
            return IsLeftMouseUp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock PickLeftMouseUp() => LeftMouseUp is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LeftMouseUp' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseComputerLeftClickToolUseBlock? LeftClick { get; init; }
#else
        public global::Anthropic.BetaResponseComputerLeftClickToolUseBlock? LeftClick { get; }
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
            out global::Anthropic.BetaResponseComputerLeftClickToolUseBlock? value)
        {
            value = LeftClick;
            return IsLeftClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerLeftClickToolUseBlock PickLeftClick() => LeftClick is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LeftClick' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock? LeftClickDrag { get; init; }
#else
        public global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock? LeftClickDrag { get; }
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
            out global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock? value)
        {
            value = LeftClickDrag;
            return IsLeftClickDrag;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock PickLeftClickDrag() => LeftClickDrag is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LeftClickDrag' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseComputerRightClickToolUseBlock? RightClick { get; init; }
#else
        public global::Anthropic.BetaResponseComputerRightClickToolUseBlock? RightClick { get; }
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
            out global::Anthropic.BetaResponseComputerRightClickToolUseBlock? value)
        {
            value = RightClick;
            return IsRightClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerRightClickToolUseBlock PickRightClick() => RightClick is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RightClick' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock? MiddleClick { get; init; }
#else
        public global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock? MiddleClick { get; }
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
            out global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock? value)
        {
            value = MiddleClick;
            return IsMiddleClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock PickMiddleClick() => MiddleClick is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MiddleClick' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock? DoubleClick { get; init; }
#else
        public global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock? DoubleClick { get; }
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
            out global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock? value)
        {
            value = DoubleClick;
            return IsDoubleClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock PickDoubleClick() => DoubleClick is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DoubleClick' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseComputerTripleClickToolUseBlock? TripleClick { get; init; }
#else
        public global::Anthropic.BetaResponseComputerTripleClickToolUseBlock? TripleClick { get; }
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
            out global::Anthropic.BetaResponseComputerTripleClickToolUseBlock? value)
        {
            value = TripleClick;
            return IsTripleClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerTripleClickToolUseBlock PickTripleClick() => TripleClick is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TripleClick' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseComputerScrollToolUseBlock? Scroll { get; init; }
#else
        public global::Anthropic.BetaResponseComputerScrollToolUseBlock? Scroll { get; }
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
            out global::Anthropic.BetaResponseComputerScrollToolUseBlock? value)
        {
            value = Scroll;
            return IsScroll;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerScrollToolUseBlock PickScroll() => Scroll is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Scroll' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseComputerWaitToolUseBlock? Wait { get; init; }
#else
        public global::Anthropic.BetaResponseComputerWaitToolUseBlock? Wait { get; }
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
            out global::Anthropic.BetaResponseComputerWaitToolUseBlock? value)
        {
            value = Wait;
            return IsWait;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerWaitToolUseBlock PickWait() => Wait is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Wait' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseComputerScreenshotToolUseBlock? Screenshot { get; init; }
#else
        public global::Anthropic.BetaResponseComputerScreenshotToolUseBlock? Screenshot { get; }
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
            out global::Anthropic.BetaResponseComputerScreenshotToolUseBlock? value)
        {
            value = Screenshot;
            return IsScreenshot;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerScreenshotToolUseBlock PickScreenshot() => Screenshot is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Screenshot' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseComputerZoomToolUseBlock? Zoom { get; init; }
#else
        public global::Anthropic.BetaResponseComputerZoomToolUseBlock? Zoom { get; }
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
            out global::Anthropic.BetaResponseComputerZoomToolUseBlock? value)
        {
            value = Zoom;
            return IsZoom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerZoomToolUseBlock PickZoom() => Zoom is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Zoom' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerKeyToolUseBlock value) => new BetaResponseComputerToolUseBlockUnion((global::Anthropic.BetaResponseComputerKeyToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseComputerKeyToolUseBlock?(BetaResponseComputerToolUseBlockUnion @this) => @this.Key;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerKeyToolUseBlock? value)
        {
            Key = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseComputerToolUseBlockUnion FromKey(global::Anthropic.BetaResponseComputerKeyToolUseBlock? value) => new BetaResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock value) => new BetaResponseComputerToolUseBlockUnion((global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock?(BetaResponseComputerToolUseBlockUnion @this) => @this.HoldKey;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock? value)
        {
            HoldKey = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseComputerToolUseBlockUnion FromHoldKey(global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock? value) => new BetaResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerTypeToolUseBlock value) => new BetaResponseComputerToolUseBlockUnion((global::Anthropic.BetaResponseComputerTypeToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseComputerTypeToolUseBlock?(BetaResponseComputerToolUseBlockUnion @this) => @this.Type;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerTypeToolUseBlock? value)
        {
            Type = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseComputerToolUseBlockUnion FromType(global::Anthropic.BetaResponseComputerTypeToolUseBlock? value) => new BetaResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock value) => new BetaResponseComputerToolUseBlockUnion((global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock?(BetaResponseComputerToolUseBlockUnion @this) => @this.CursorPosition;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock? value)
        {
            CursorPosition = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseComputerToolUseBlockUnion FromCursorPosition(global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock? value) => new BetaResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock value) => new BetaResponseComputerToolUseBlockUnion((global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock?(BetaResponseComputerToolUseBlockUnion @this) => @this.MouseMove;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock? value)
        {
            MouseMove = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseComputerToolUseBlockUnion FromMouseMove(global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock? value) => new BetaResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock value) => new BetaResponseComputerToolUseBlockUnion((global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock?(BetaResponseComputerToolUseBlockUnion @this) => @this.LeftMouseDown;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock? value)
        {
            LeftMouseDown = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseComputerToolUseBlockUnion FromLeftMouseDown(global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock? value) => new BetaResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock value) => new BetaResponseComputerToolUseBlockUnion((global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock?(BetaResponseComputerToolUseBlockUnion @this) => @this.LeftMouseUp;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock? value)
        {
            LeftMouseUp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseComputerToolUseBlockUnion FromLeftMouseUp(global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock? value) => new BetaResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerLeftClickToolUseBlock value) => new BetaResponseComputerToolUseBlockUnion((global::Anthropic.BetaResponseComputerLeftClickToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseComputerLeftClickToolUseBlock?(BetaResponseComputerToolUseBlockUnion @this) => @this.LeftClick;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerLeftClickToolUseBlock? value)
        {
            LeftClick = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseComputerToolUseBlockUnion FromLeftClick(global::Anthropic.BetaResponseComputerLeftClickToolUseBlock? value) => new BetaResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock value) => new BetaResponseComputerToolUseBlockUnion((global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock?(BetaResponseComputerToolUseBlockUnion @this) => @this.LeftClickDrag;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock? value)
        {
            LeftClickDrag = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseComputerToolUseBlockUnion FromLeftClickDrag(global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock? value) => new BetaResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerRightClickToolUseBlock value) => new BetaResponseComputerToolUseBlockUnion((global::Anthropic.BetaResponseComputerRightClickToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseComputerRightClickToolUseBlock?(BetaResponseComputerToolUseBlockUnion @this) => @this.RightClick;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerRightClickToolUseBlock? value)
        {
            RightClick = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseComputerToolUseBlockUnion FromRightClick(global::Anthropic.BetaResponseComputerRightClickToolUseBlock? value) => new BetaResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock value) => new BetaResponseComputerToolUseBlockUnion((global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock?(BetaResponseComputerToolUseBlockUnion @this) => @this.MiddleClick;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock? value)
        {
            MiddleClick = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseComputerToolUseBlockUnion FromMiddleClick(global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock? value) => new BetaResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock value) => new BetaResponseComputerToolUseBlockUnion((global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock?(BetaResponseComputerToolUseBlockUnion @this) => @this.DoubleClick;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock? value)
        {
            DoubleClick = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseComputerToolUseBlockUnion FromDoubleClick(global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock? value) => new BetaResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerTripleClickToolUseBlock value) => new BetaResponseComputerToolUseBlockUnion((global::Anthropic.BetaResponseComputerTripleClickToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseComputerTripleClickToolUseBlock?(BetaResponseComputerToolUseBlockUnion @this) => @this.TripleClick;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerTripleClickToolUseBlock? value)
        {
            TripleClick = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseComputerToolUseBlockUnion FromTripleClick(global::Anthropic.BetaResponseComputerTripleClickToolUseBlock? value) => new BetaResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerScrollToolUseBlock value) => new BetaResponseComputerToolUseBlockUnion((global::Anthropic.BetaResponseComputerScrollToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseComputerScrollToolUseBlock?(BetaResponseComputerToolUseBlockUnion @this) => @this.Scroll;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerScrollToolUseBlock? value)
        {
            Scroll = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseComputerToolUseBlockUnion FromScroll(global::Anthropic.BetaResponseComputerScrollToolUseBlock? value) => new BetaResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerWaitToolUseBlock value) => new BetaResponseComputerToolUseBlockUnion((global::Anthropic.BetaResponseComputerWaitToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseComputerWaitToolUseBlock?(BetaResponseComputerToolUseBlockUnion @this) => @this.Wait;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerWaitToolUseBlock? value)
        {
            Wait = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseComputerToolUseBlockUnion FromWait(global::Anthropic.BetaResponseComputerWaitToolUseBlock? value) => new BetaResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerScreenshotToolUseBlock value) => new BetaResponseComputerToolUseBlockUnion((global::Anthropic.BetaResponseComputerScreenshotToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseComputerScreenshotToolUseBlock?(BetaResponseComputerToolUseBlockUnion @this) => @this.Screenshot;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerScreenshotToolUseBlock? value)
        {
            Screenshot = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseComputerToolUseBlockUnion FromScreenshot(global::Anthropic.BetaResponseComputerScreenshotToolUseBlock? value) => new BetaResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerZoomToolUseBlock value) => new BetaResponseComputerToolUseBlockUnion((global::Anthropic.BetaResponseComputerZoomToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseComputerZoomToolUseBlock?(BetaResponseComputerToolUseBlockUnion @this) => @this.Zoom;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseComputerToolUseBlockUnion(global::Anthropic.BetaResponseComputerZoomToolUseBlock? value)
        {
            Zoom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseComputerToolUseBlockUnion FromZoom(global::Anthropic.BetaResponseComputerZoomToolUseBlock? value) => new BetaResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public BetaResponseComputerToolUseBlockUnion(
            global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName? name,
            global::Anthropic.BetaResponseComputerKeyToolUseBlock? key,
            global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock? holdKey,
            global::Anthropic.BetaResponseComputerTypeToolUseBlock? type,
            global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock? cursorPosition,
            global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock? mouseMove,
            global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock? leftMouseDown,
            global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock? leftMouseUp,
            global::Anthropic.BetaResponseComputerLeftClickToolUseBlock? leftClick,
            global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock? leftClickDrag,
            global::Anthropic.BetaResponseComputerRightClickToolUseBlock? rightClick,
            global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock? middleClick,
            global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock? doubleClick,
            global::Anthropic.BetaResponseComputerTripleClickToolUseBlock? tripleClick,
            global::Anthropic.BetaResponseComputerScrollToolUseBlock? scroll,
            global::Anthropic.BetaResponseComputerWaitToolUseBlock? wait,
            global::Anthropic.BetaResponseComputerScreenshotToolUseBlock? screenshot,
            global::Anthropic.BetaResponseComputerZoomToolUseBlock? zoom
            )
        {
            Name = name;

            Key = key;
            HoldKey = holdKey;
            Type = type;
            CursorPosition = cursorPosition;
            MouseMove = mouseMove;
            LeftMouseDown = leftMouseDown;
            LeftMouseUp = leftMouseUp;
            LeftClick = leftClick;
            LeftClickDrag = leftClickDrag;
            RightClick = rightClick;
            MiddleClick = middleClick;
            DoubleClick = doubleClick;
            TripleClick = tripleClick;
            Scroll = scroll;
            Wait = wait;
            Screenshot = screenshot;
            Zoom = zoom;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Zoom as object ??
            Screenshot as object ??
            Wait as object ??
            Scroll as object ??
            TripleClick as object ??
            DoubleClick as object ??
            MiddleClick as object ??
            RightClick as object ??
            LeftClickDrag as object ??
            LeftClick as object ??
            LeftMouseUp as object ??
            LeftMouseDown as object ??
            MouseMove as object ??
            CursorPosition as object ??
            Type as object ??
            HoldKey as object ??
            Key as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Key?.ToString() ??
            HoldKey?.ToString() ??
            Type?.ToString() ??
            CursorPosition?.ToString() ??
            MouseMove?.ToString() ??
            LeftMouseDown?.ToString() ??
            LeftMouseUp?.ToString() ??
            LeftClick?.ToString() ??
            LeftClickDrag?.ToString() ??
            RightClick?.ToString() ??
            MiddleClick?.ToString() ??
            DoubleClick?.ToString() ??
            TripleClick?.ToString() ??
            Scroll?.ToString() ??
            Wait?.ToString() ??
            Screenshot?.ToString() ??
            Zoom?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsKey && !IsHoldKey && !IsType && !IsCursorPosition && !IsMouseMove && !IsLeftMouseDown && !IsLeftMouseUp && !IsLeftClick && !IsLeftClickDrag && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsScroll && !IsWait && !IsScreenshot && !IsZoom || !IsKey && IsHoldKey && !IsType && !IsCursorPosition && !IsMouseMove && !IsLeftMouseDown && !IsLeftMouseUp && !IsLeftClick && !IsLeftClickDrag && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsScroll && !IsWait && !IsScreenshot && !IsZoom || !IsKey && !IsHoldKey && IsType && !IsCursorPosition && !IsMouseMove && !IsLeftMouseDown && !IsLeftMouseUp && !IsLeftClick && !IsLeftClickDrag && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsScroll && !IsWait && !IsScreenshot && !IsZoom || !IsKey && !IsHoldKey && !IsType && IsCursorPosition && !IsMouseMove && !IsLeftMouseDown && !IsLeftMouseUp && !IsLeftClick && !IsLeftClickDrag && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsScroll && !IsWait && !IsScreenshot && !IsZoom || !IsKey && !IsHoldKey && !IsType && !IsCursorPosition && IsMouseMove && !IsLeftMouseDown && !IsLeftMouseUp && !IsLeftClick && !IsLeftClickDrag && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsScroll && !IsWait && !IsScreenshot && !IsZoom || !IsKey && !IsHoldKey && !IsType && !IsCursorPosition && !IsMouseMove && IsLeftMouseDown && !IsLeftMouseUp && !IsLeftClick && !IsLeftClickDrag && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsScroll && !IsWait && !IsScreenshot && !IsZoom || !IsKey && !IsHoldKey && !IsType && !IsCursorPosition && !IsMouseMove && !IsLeftMouseDown && IsLeftMouseUp && !IsLeftClick && !IsLeftClickDrag && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsScroll && !IsWait && !IsScreenshot && !IsZoom || !IsKey && !IsHoldKey && !IsType && !IsCursorPosition && !IsMouseMove && !IsLeftMouseDown && !IsLeftMouseUp && IsLeftClick && !IsLeftClickDrag && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsScroll && !IsWait && !IsScreenshot && !IsZoom || !IsKey && !IsHoldKey && !IsType && !IsCursorPosition && !IsMouseMove && !IsLeftMouseDown && !IsLeftMouseUp && !IsLeftClick && IsLeftClickDrag && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsScroll && !IsWait && !IsScreenshot && !IsZoom || !IsKey && !IsHoldKey && !IsType && !IsCursorPosition && !IsMouseMove && !IsLeftMouseDown && !IsLeftMouseUp && !IsLeftClick && !IsLeftClickDrag && IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsScroll && !IsWait && !IsScreenshot && !IsZoom || !IsKey && !IsHoldKey && !IsType && !IsCursorPosition && !IsMouseMove && !IsLeftMouseDown && !IsLeftMouseUp && !IsLeftClick && !IsLeftClickDrag && !IsRightClick && IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsScroll && !IsWait && !IsScreenshot && !IsZoom || !IsKey && !IsHoldKey && !IsType && !IsCursorPosition && !IsMouseMove && !IsLeftMouseDown && !IsLeftMouseUp && !IsLeftClick && !IsLeftClickDrag && !IsRightClick && !IsMiddleClick && IsDoubleClick && !IsTripleClick && !IsScroll && !IsWait && !IsScreenshot && !IsZoom || !IsKey && !IsHoldKey && !IsType && !IsCursorPosition && !IsMouseMove && !IsLeftMouseDown && !IsLeftMouseUp && !IsLeftClick && !IsLeftClickDrag && !IsRightClick && !IsMiddleClick && !IsDoubleClick && IsTripleClick && !IsScroll && !IsWait && !IsScreenshot && !IsZoom || !IsKey && !IsHoldKey && !IsType && !IsCursorPosition && !IsMouseMove && !IsLeftMouseDown && !IsLeftMouseUp && !IsLeftClick && !IsLeftClickDrag && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && IsScroll && !IsWait && !IsScreenshot && !IsZoom || !IsKey && !IsHoldKey && !IsType && !IsCursorPosition && !IsMouseMove && !IsLeftMouseDown && !IsLeftMouseUp && !IsLeftClick && !IsLeftClickDrag && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsScroll && IsWait && !IsScreenshot && !IsZoom || !IsKey && !IsHoldKey && !IsType && !IsCursorPosition && !IsMouseMove && !IsLeftMouseDown && !IsLeftMouseUp && !IsLeftClick && !IsLeftClickDrag && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsScroll && !IsWait && IsScreenshot && !IsZoom || !IsKey && !IsHoldKey && !IsType && !IsCursorPosition && !IsMouseMove && !IsLeftMouseDown && !IsLeftMouseUp && !IsLeftClick && !IsLeftClickDrag && !IsRightClick && !IsMiddleClick && !IsDoubleClick && !IsTripleClick && !IsScroll && !IsWait && !IsScreenshot && IsZoom;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaResponseComputerKeyToolUseBlock, TResult>? key = null,
            global::System.Func<global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock, TResult>? holdKey = null,
            global::System.Func<global::Anthropic.BetaResponseComputerTypeToolUseBlock, TResult>? type = null,
            global::System.Func<global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock, TResult>? cursorPosition = null,
            global::System.Func<global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock, TResult>? mouseMove = null,
            global::System.Func<global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock, TResult>? leftMouseDown = null,
            global::System.Func<global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock, TResult>? leftMouseUp = null,
            global::System.Func<global::Anthropic.BetaResponseComputerLeftClickToolUseBlock, TResult>? leftClick = null,
            global::System.Func<global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock, TResult>? leftClickDrag = null,
            global::System.Func<global::Anthropic.BetaResponseComputerRightClickToolUseBlock, TResult>? rightClick = null,
            global::System.Func<global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock, TResult>? middleClick = null,
            global::System.Func<global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock, TResult>? doubleClick = null,
            global::System.Func<global::Anthropic.BetaResponseComputerTripleClickToolUseBlock, TResult>? tripleClick = null,
            global::System.Func<global::Anthropic.BetaResponseComputerScrollToolUseBlock, TResult>? scroll = null,
            global::System.Func<global::Anthropic.BetaResponseComputerWaitToolUseBlock, TResult>? wait = null,
            global::System.Func<global::Anthropic.BetaResponseComputerScreenshotToolUseBlock, TResult>? screenshot = null,
            global::System.Func<global::Anthropic.BetaResponseComputerZoomToolUseBlock, TResult>? zoom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Key is { } __value0 && key != null)
            {
                return key(__value0);
            }
            else if (HoldKey is { } __value1 && holdKey != null)
            {
                return holdKey(__value1);
            }
            else if (Type is { } __value2 && type != null)
            {
                return type(__value2);
            }
            else if (CursorPosition is { } __value3 && cursorPosition != null)
            {
                return cursorPosition(__value3);
            }
            else if (MouseMove is { } __value4 && mouseMove != null)
            {
                return mouseMove(__value4);
            }
            else if (LeftMouseDown is { } __value5 && leftMouseDown != null)
            {
                return leftMouseDown(__value5);
            }
            else if (LeftMouseUp is { } __value6 && leftMouseUp != null)
            {
                return leftMouseUp(__value6);
            }
            else if (LeftClick is { } __value7 && leftClick != null)
            {
                return leftClick(__value7);
            }
            else if (LeftClickDrag is { } __value8 && leftClickDrag != null)
            {
                return leftClickDrag(__value8);
            }
            else if (RightClick is { } __value9 && rightClick != null)
            {
                return rightClick(__value9);
            }
            else if (MiddleClick is { } __value10 && middleClick != null)
            {
                return middleClick(__value10);
            }
            else if (DoubleClick is { } __value11 && doubleClick != null)
            {
                return doubleClick(__value11);
            }
            else if (TripleClick is { } __value12 && tripleClick != null)
            {
                return tripleClick(__value12);
            }
            else if (Scroll is { } __value13 && scroll != null)
            {
                return scroll(__value13);
            }
            else if (Wait is { } __value14 && wait != null)
            {
                return wait(__value14);
            }
            else if (Screenshot is { } __value15 && screenshot != null)
            {
                return screenshot(__value15);
            }
            else if (Zoom is { } __value16 && zoom != null)
            {
                return zoom(__value16);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaResponseComputerKeyToolUseBlock>? key = null,

            global::System.Action<global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock>? holdKey = null,

            global::System.Action<global::Anthropic.BetaResponseComputerTypeToolUseBlock>? type = null,

            global::System.Action<global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock>? cursorPosition = null,

            global::System.Action<global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock>? mouseMove = null,

            global::System.Action<global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock>? leftMouseDown = null,

            global::System.Action<global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock>? leftMouseUp = null,

            global::System.Action<global::Anthropic.BetaResponseComputerLeftClickToolUseBlock>? leftClick = null,

            global::System.Action<global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock>? leftClickDrag = null,

            global::System.Action<global::Anthropic.BetaResponseComputerRightClickToolUseBlock>? rightClick = null,

            global::System.Action<global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock>? middleClick = null,

            global::System.Action<global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock>? doubleClick = null,

            global::System.Action<global::Anthropic.BetaResponseComputerTripleClickToolUseBlock>? tripleClick = null,

            global::System.Action<global::Anthropic.BetaResponseComputerScrollToolUseBlock>? scroll = null,

            global::System.Action<global::Anthropic.BetaResponseComputerWaitToolUseBlock>? wait = null,

            global::System.Action<global::Anthropic.BetaResponseComputerScreenshotToolUseBlock>? screenshot = null,

            global::System.Action<global::Anthropic.BetaResponseComputerZoomToolUseBlock>? zoom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Key is { } __value0)
            {
                key?.Invoke(__value0);
            }
            else if (HoldKey is { } __value1)
            {
                holdKey?.Invoke(__value1);
            }
            else if (Type is { } __value2)
            {
                type?.Invoke(__value2);
            }
            else if (CursorPosition is { } __value3)
            {
                cursorPosition?.Invoke(__value3);
            }
            else if (MouseMove is { } __value4)
            {
                mouseMove?.Invoke(__value4);
            }
            else if (LeftMouseDown is { } __value5)
            {
                leftMouseDown?.Invoke(__value5);
            }
            else if (LeftMouseUp is { } __value6)
            {
                leftMouseUp?.Invoke(__value6);
            }
            else if (LeftClick is { } __value7)
            {
                leftClick?.Invoke(__value7);
            }
            else if (LeftClickDrag is { } __value8)
            {
                leftClickDrag?.Invoke(__value8);
            }
            else if (RightClick is { } __value9)
            {
                rightClick?.Invoke(__value9);
            }
            else if (MiddleClick is { } __value10)
            {
                middleClick?.Invoke(__value10);
            }
            else if (DoubleClick is { } __value11)
            {
                doubleClick?.Invoke(__value11);
            }
            else if (TripleClick is { } __value12)
            {
                tripleClick?.Invoke(__value12);
            }
            else if (Scroll is { } __value13)
            {
                scroll?.Invoke(__value13);
            }
            else if (Wait is { } __value14)
            {
                wait?.Invoke(__value14);
            }
            else if (Screenshot is { } __value15)
            {
                screenshot?.Invoke(__value15);
            }
            else if (Zoom is { } __value16)
            {
                zoom?.Invoke(__value16);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaResponseComputerKeyToolUseBlock>? key = null,
            global::System.Action<global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock>? holdKey = null,
            global::System.Action<global::Anthropic.BetaResponseComputerTypeToolUseBlock>? type = null,
            global::System.Action<global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock>? cursorPosition = null,
            global::System.Action<global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock>? mouseMove = null,
            global::System.Action<global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock>? leftMouseDown = null,
            global::System.Action<global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock>? leftMouseUp = null,
            global::System.Action<global::Anthropic.BetaResponseComputerLeftClickToolUseBlock>? leftClick = null,
            global::System.Action<global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock>? leftClickDrag = null,
            global::System.Action<global::Anthropic.BetaResponseComputerRightClickToolUseBlock>? rightClick = null,
            global::System.Action<global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock>? middleClick = null,
            global::System.Action<global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock>? doubleClick = null,
            global::System.Action<global::Anthropic.BetaResponseComputerTripleClickToolUseBlock>? tripleClick = null,
            global::System.Action<global::Anthropic.BetaResponseComputerScrollToolUseBlock>? scroll = null,
            global::System.Action<global::Anthropic.BetaResponseComputerWaitToolUseBlock>? wait = null,
            global::System.Action<global::Anthropic.BetaResponseComputerScreenshotToolUseBlock>? screenshot = null,
            global::System.Action<global::Anthropic.BetaResponseComputerZoomToolUseBlock>? zoom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Key is { } __value0)
            {
                key?.Invoke(__value0);
            }
            else if (HoldKey is { } __value1)
            {
                holdKey?.Invoke(__value1);
            }
            else if (Type is { } __value2)
            {
                type?.Invoke(__value2);
            }
            else if (CursorPosition is { } __value3)
            {
                cursorPosition?.Invoke(__value3);
            }
            else if (MouseMove is { } __value4)
            {
                mouseMove?.Invoke(__value4);
            }
            else if (LeftMouseDown is { } __value5)
            {
                leftMouseDown?.Invoke(__value5);
            }
            else if (LeftMouseUp is { } __value6)
            {
                leftMouseUp?.Invoke(__value6);
            }
            else if (LeftClick is { } __value7)
            {
                leftClick?.Invoke(__value7);
            }
            else if (LeftClickDrag is { } __value8)
            {
                leftClickDrag?.Invoke(__value8);
            }
            else if (RightClick is { } __value9)
            {
                rightClick?.Invoke(__value9);
            }
            else if (MiddleClick is { } __value10)
            {
                middleClick?.Invoke(__value10);
            }
            else if (DoubleClick is { } __value11)
            {
                doubleClick?.Invoke(__value11);
            }
            else if (TripleClick is { } __value12)
            {
                tripleClick?.Invoke(__value12);
            }
            else if (Scroll is { } __value13)
            {
                scroll?.Invoke(__value13);
            }
            else if (Wait is { } __value14)
            {
                wait?.Invoke(__value14);
            }
            else if (Screenshot is { } __value15)
            {
                screenshot?.Invoke(__value15);
            }
            else if (Zoom is { } __value16)
            {
                zoom?.Invoke(__value16);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Key,
                typeof(global::Anthropic.BetaResponseComputerKeyToolUseBlock),
                HoldKey,
                typeof(global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock),
                Type,
                typeof(global::Anthropic.BetaResponseComputerTypeToolUseBlock),
                CursorPosition,
                typeof(global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock),
                MouseMove,
                typeof(global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock),
                LeftMouseDown,
                typeof(global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock),
                LeftMouseUp,
                typeof(global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock),
                LeftClick,
                typeof(global::Anthropic.BetaResponseComputerLeftClickToolUseBlock),
                LeftClickDrag,
                typeof(global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock),
                RightClick,
                typeof(global::Anthropic.BetaResponseComputerRightClickToolUseBlock),
                MiddleClick,
                typeof(global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock),
                DoubleClick,
                typeof(global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock),
                TripleClick,
                typeof(global::Anthropic.BetaResponseComputerTripleClickToolUseBlock),
                Scroll,
                typeof(global::Anthropic.BetaResponseComputerScrollToolUseBlock),
                Wait,
                typeof(global::Anthropic.BetaResponseComputerWaitToolUseBlock),
                Screenshot,
                typeof(global::Anthropic.BetaResponseComputerScreenshotToolUseBlock),
                Zoom,
                typeof(global::Anthropic.BetaResponseComputerZoomToolUseBlock),
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
        public bool Equals(BetaResponseComputerToolUseBlockUnion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseComputerKeyToolUseBlock?>.Default.Equals(Key, other.Key) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseComputerHoldKeyToolUseBlock?>.Default.Equals(HoldKey, other.HoldKey) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseComputerTypeToolUseBlock?>.Default.Equals(Type, other.Type) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseComputerCursorPositionToolUseBlock?>.Default.Equals(CursorPosition, other.CursorPosition) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseComputerMouseMoveToolUseBlock?>.Default.Equals(MouseMove, other.MouseMove) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseComputerLeftMouseDownToolUseBlock?>.Default.Equals(LeftMouseDown, other.LeftMouseDown) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseComputerLeftMouseUpToolUseBlock?>.Default.Equals(LeftMouseUp, other.LeftMouseUp) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseComputerLeftClickToolUseBlock?>.Default.Equals(LeftClick, other.LeftClick) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseComputerLeftClickDragToolUseBlock?>.Default.Equals(LeftClickDrag, other.LeftClickDrag) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseComputerRightClickToolUseBlock?>.Default.Equals(RightClick, other.RightClick) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseComputerMiddleClickToolUseBlock?>.Default.Equals(MiddleClick, other.MiddleClick) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseComputerDoubleClickToolUseBlock?>.Default.Equals(DoubleClick, other.DoubleClick) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseComputerTripleClickToolUseBlock?>.Default.Equals(TripleClick, other.TripleClick) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseComputerScrollToolUseBlock?>.Default.Equals(Scroll, other.Scroll) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseComputerWaitToolUseBlock?>.Default.Equals(Wait, other.Wait) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseComputerScreenshotToolUseBlock?>.Default.Equals(Screenshot, other.Screenshot) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseComputerZoomToolUseBlock?>.Default.Equals(Zoom, other.Zoom)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaResponseComputerToolUseBlockUnion obj1, BetaResponseComputerToolUseBlockUnion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaResponseComputerToolUseBlockUnion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaResponseComputerToolUseBlockUnion obj1, BetaResponseComputerToolUseBlockUnion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaResponseComputerToolUseBlockUnion o && Equals(o);
        }
    }
}
