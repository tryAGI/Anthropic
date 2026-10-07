#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ResponseComputerToolUseBlockUnion : global::System.IEquatable<ResponseComputerToolUseBlockUnion>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName? Name { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseComputerKeyToolUseBlock? Key { get; init; }
#else
        public global::Anthropic.ResponseComputerKeyToolUseBlock? Key { get; }
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
            out global::Anthropic.ResponseComputerKeyToolUseBlock? value)
        {
            value = Key;
            return IsKey;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerKeyToolUseBlock PickKey() => Key is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Key' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseComputerHoldKeyToolUseBlock? HoldKey { get; init; }
#else
        public global::Anthropic.ResponseComputerHoldKeyToolUseBlock? HoldKey { get; }
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
            out global::Anthropic.ResponseComputerHoldKeyToolUseBlock? value)
        {
            value = HoldKey;
            return IsHoldKey;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerHoldKeyToolUseBlock PickHoldKey() => HoldKey is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HoldKey' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseComputerTypeToolUseBlock? Type { get; init; }
#else
        public global::Anthropic.ResponseComputerTypeToolUseBlock? Type { get; }
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
            out global::Anthropic.ResponseComputerTypeToolUseBlock? value)
        {
            value = Type;
            return IsType;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerTypeToolUseBlock PickType() => Type is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Type' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseComputerCursorPositionToolUseBlock? CursorPosition { get; init; }
#else
        public global::Anthropic.ResponseComputerCursorPositionToolUseBlock? CursorPosition { get; }
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
            out global::Anthropic.ResponseComputerCursorPositionToolUseBlock? value)
        {
            value = CursorPosition;
            return IsCursorPosition;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerCursorPositionToolUseBlock PickCursorPosition() => CursorPosition is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CursorPosition' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseComputerMouseMoveToolUseBlock? MouseMove { get; init; }
#else
        public global::Anthropic.ResponseComputerMouseMoveToolUseBlock? MouseMove { get; }
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
            out global::Anthropic.ResponseComputerMouseMoveToolUseBlock? value)
        {
            value = MouseMove;
            return IsMouseMove;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerMouseMoveToolUseBlock PickMouseMove() => MouseMove is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MouseMove' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock? LeftMouseDown { get; init; }
#else
        public global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock? LeftMouseDown { get; }
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
            out global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock? value)
        {
            value = LeftMouseDown;
            return IsLeftMouseDown;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock PickLeftMouseDown() => LeftMouseDown is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LeftMouseDown' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock? LeftMouseUp { get; init; }
#else
        public global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock? LeftMouseUp { get; }
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
            out global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock? value)
        {
            value = LeftMouseUp;
            return IsLeftMouseUp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock PickLeftMouseUp() => LeftMouseUp is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LeftMouseUp' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseComputerLeftClickToolUseBlock? LeftClick { get; init; }
#else
        public global::Anthropic.ResponseComputerLeftClickToolUseBlock? LeftClick { get; }
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
            out global::Anthropic.ResponseComputerLeftClickToolUseBlock? value)
        {
            value = LeftClick;
            return IsLeftClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftClickToolUseBlock PickLeftClick() => LeftClick is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LeftClick' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseComputerLeftClickDragToolUseBlock? LeftClickDrag { get; init; }
#else
        public global::Anthropic.ResponseComputerLeftClickDragToolUseBlock? LeftClickDrag { get; }
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
            out global::Anthropic.ResponseComputerLeftClickDragToolUseBlock? value)
        {
            value = LeftClickDrag;
            return IsLeftClickDrag;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerLeftClickDragToolUseBlock PickLeftClickDrag() => LeftClickDrag is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LeftClickDrag' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseComputerRightClickToolUseBlock? RightClick { get; init; }
#else
        public global::Anthropic.ResponseComputerRightClickToolUseBlock? RightClick { get; }
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
            out global::Anthropic.ResponseComputerRightClickToolUseBlock? value)
        {
            value = RightClick;
            return IsRightClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerRightClickToolUseBlock PickRightClick() => RightClick is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RightClick' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseComputerMiddleClickToolUseBlock? MiddleClick { get; init; }
#else
        public global::Anthropic.ResponseComputerMiddleClickToolUseBlock? MiddleClick { get; }
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
            out global::Anthropic.ResponseComputerMiddleClickToolUseBlock? value)
        {
            value = MiddleClick;
            return IsMiddleClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerMiddleClickToolUseBlock PickMiddleClick() => MiddleClick is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MiddleClick' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseComputerDoubleClickToolUseBlock? DoubleClick { get; init; }
#else
        public global::Anthropic.ResponseComputerDoubleClickToolUseBlock? DoubleClick { get; }
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
            out global::Anthropic.ResponseComputerDoubleClickToolUseBlock? value)
        {
            value = DoubleClick;
            return IsDoubleClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerDoubleClickToolUseBlock PickDoubleClick() => DoubleClick is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DoubleClick' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseComputerTripleClickToolUseBlock? TripleClick { get; init; }
#else
        public global::Anthropic.ResponseComputerTripleClickToolUseBlock? TripleClick { get; }
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
            out global::Anthropic.ResponseComputerTripleClickToolUseBlock? value)
        {
            value = TripleClick;
            return IsTripleClick;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerTripleClickToolUseBlock PickTripleClick() => TripleClick is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TripleClick' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseComputerScrollToolUseBlock? Scroll { get; init; }
#else
        public global::Anthropic.ResponseComputerScrollToolUseBlock? Scroll { get; }
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
            out global::Anthropic.ResponseComputerScrollToolUseBlock? value)
        {
            value = Scroll;
            return IsScroll;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerScrollToolUseBlock PickScroll() => Scroll is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Scroll' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseComputerWaitToolUseBlock? Wait { get; init; }
#else
        public global::Anthropic.ResponseComputerWaitToolUseBlock? Wait { get; }
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
            out global::Anthropic.ResponseComputerWaitToolUseBlock? value)
        {
            value = Wait;
            return IsWait;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerWaitToolUseBlock PickWait() => Wait is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Wait' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseComputerScreenshotToolUseBlock? Screenshot { get; init; }
#else
        public global::Anthropic.ResponseComputerScreenshotToolUseBlock? Screenshot { get; }
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
            out global::Anthropic.ResponseComputerScreenshotToolUseBlock? value)
        {
            value = Screenshot;
            return IsScreenshot;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerScreenshotToolUseBlock PickScreenshot() => Screenshot is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Screenshot' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseComputerZoomToolUseBlock? Zoom { get; init; }
#else
        public global::Anthropic.ResponseComputerZoomToolUseBlock? Zoom { get; }
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
            out global::Anthropic.ResponseComputerZoomToolUseBlock? value)
        {
            value = Zoom;
            return IsZoom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerZoomToolUseBlock PickZoom() => Zoom is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Zoom' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerKeyToolUseBlock value) => new ResponseComputerToolUseBlockUnion((global::Anthropic.ResponseComputerKeyToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseComputerKeyToolUseBlock?(ResponseComputerToolUseBlockUnion @this) => @this.Key;

        /// <summary>
        ///
        /// </summary>
        public ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerKeyToolUseBlock? value)
        {
            Key = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseComputerToolUseBlockUnion FromKey(global::Anthropic.ResponseComputerKeyToolUseBlock? value) => new ResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerHoldKeyToolUseBlock value) => new ResponseComputerToolUseBlockUnion((global::Anthropic.ResponseComputerHoldKeyToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseComputerHoldKeyToolUseBlock?(ResponseComputerToolUseBlockUnion @this) => @this.HoldKey;

        /// <summary>
        ///
        /// </summary>
        public ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerHoldKeyToolUseBlock? value)
        {
            HoldKey = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseComputerToolUseBlockUnion FromHoldKey(global::Anthropic.ResponseComputerHoldKeyToolUseBlock? value) => new ResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerTypeToolUseBlock value) => new ResponseComputerToolUseBlockUnion((global::Anthropic.ResponseComputerTypeToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseComputerTypeToolUseBlock?(ResponseComputerToolUseBlockUnion @this) => @this.Type;

        /// <summary>
        ///
        /// </summary>
        public ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerTypeToolUseBlock? value)
        {
            Type = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseComputerToolUseBlockUnion FromType(global::Anthropic.ResponseComputerTypeToolUseBlock? value) => new ResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerCursorPositionToolUseBlock value) => new ResponseComputerToolUseBlockUnion((global::Anthropic.ResponseComputerCursorPositionToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseComputerCursorPositionToolUseBlock?(ResponseComputerToolUseBlockUnion @this) => @this.CursorPosition;

        /// <summary>
        ///
        /// </summary>
        public ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerCursorPositionToolUseBlock? value)
        {
            CursorPosition = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseComputerToolUseBlockUnion FromCursorPosition(global::Anthropic.ResponseComputerCursorPositionToolUseBlock? value) => new ResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerMouseMoveToolUseBlock value) => new ResponseComputerToolUseBlockUnion((global::Anthropic.ResponseComputerMouseMoveToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseComputerMouseMoveToolUseBlock?(ResponseComputerToolUseBlockUnion @this) => @this.MouseMove;

        /// <summary>
        ///
        /// </summary>
        public ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerMouseMoveToolUseBlock? value)
        {
            MouseMove = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseComputerToolUseBlockUnion FromMouseMove(global::Anthropic.ResponseComputerMouseMoveToolUseBlock? value) => new ResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock value) => new ResponseComputerToolUseBlockUnion((global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock?(ResponseComputerToolUseBlockUnion @this) => @this.LeftMouseDown;

        /// <summary>
        ///
        /// </summary>
        public ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock? value)
        {
            LeftMouseDown = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseComputerToolUseBlockUnion FromLeftMouseDown(global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock? value) => new ResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock value) => new ResponseComputerToolUseBlockUnion((global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock?(ResponseComputerToolUseBlockUnion @this) => @this.LeftMouseUp;

        /// <summary>
        ///
        /// </summary>
        public ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock? value)
        {
            LeftMouseUp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseComputerToolUseBlockUnion FromLeftMouseUp(global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock? value) => new ResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerLeftClickToolUseBlock value) => new ResponseComputerToolUseBlockUnion((global::Anthropic.ResponseComputerLeftClickToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseComputerLeftClickToolUseBlock?(ResponseComputerToolUseBlockUnion @this) => @this.LeftClick;

        /// <summary>
        ///
        /// </summary>
        public ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerLeftClickToolUseBlock? value)
        {
            LeftClick = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseComputerToolUseBlockUnion FromLeftClick(global::Anthropic.ResponseComputerLeftClickToolUseBlock? value) => new ResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerLeftClickDragToolUseBlock value) => new ResponseComputerToolUseBlockUnion((global::Anthropic.ResponseComputerLeftClickDragToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseComputerLeftClickDragToolUseBlock?(ResponseComputerToolUseBlockUnion @this) => @this.LeftClickDrag;

        /// <summary>
        ///
        /// </summary>
        public ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerLeftClickDragToolUseBlock? value)
        {
            LeftClickDrag = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseComputerToolUseBlockUnion FromLeftClickDrag(global::Anthropic.ResponseComputerLeftClickDragToolUseBlock? value) => new ResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerRightClickToolUseBlock value) => new ResponseComputerToolUseBlockUnion((global::Anthropic.ResponseComputerRightClickToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseComputerRightClickToolUseBlock?(ResponseComputerToolUseBlockUnion @this) => @this.RightClick;

        /// <summary>
        ///
        /// </summary>
        public ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerRightClickToolUseBlock? value)
        {
            RightClick = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseComputerToolUseBlockUnion FromRightClick(global::Anthropic.ResponseComputerRightClickToolUseBlock? value) => new ResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerMiddleClickToolUseBlock value) => new ResponseComputerToolUseBlockUnion((global::Anthropic.ResponseComputerMiddleClickToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseComputerMiddleClickToolUseBlock?(ResponseComputerToolUseBlockUnion @this) => @this.MiddleClick;

        /// <summary>
        ///
        /// </summary>
        public ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerMiddleClickToolUseBlock? value)
        {
            MiddleClick = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseComputerToolUseBlockUnion FromMiddleClick(global::Anthropic.ResponseComputerMiddleClickToolUseBlock? value) => new ResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerDoubleClickToolUseBlock value) => new ResponseComputerToolUseBlockUnion((global::Anthropic.ResponseComputerDoubleClickToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseComputerDoubleClickToolUseBlock?(ResponseComputerToolUseBlockUnion @this) => @this.DoubleClick;

        /// <summary>
        ///
        /// </summary>
        public ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerDoubleClickToolUseBlock? value)
        {
            DoubleClick = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseComputerToolUseBlockUnion FromDoubleClick(global::Anthropic.ResponseComputerDoubleClickToolUseBlock? value) => new ResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerTripleClickToolUseBlock value) => new ResponseComputerToolUseBlockUnion((global::Anthropic.ResponseComputerTripleClickToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseComputerTripleClickToolUseBlock?(ResponseComputerToolUseBlockUnion @this) => @this.TripleClick;

        /// <summary>
        ///
        /// </summary>
        public ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerTripleClickToolUseBlock? value)
        {
            TripleClick = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseComputerToolUseBlockUnion FromTripleClick(global::Anthropic.ResponseComputerTripleClickToolUseBlock? value) => new ResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerScrollToolUseBlock value) => new ResponseComputerToolUseBlockUnion((global::Anthropic.ResponseComputerScrollToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseComputerScrollToolUseBlock?(ResponseComputerToolUseBlockUnion @this) => @this.Scroll;

        /// <summary>
        ///
        /// </summary>
        public ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerScrollToolUseBlock? value)
        {
            Scroll = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseComputerToolUseBlockUnion FromScroll(global::Anthropic.ResponseComputerScrollToolUseBlock? value) => new ResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerWaitToolUseBlock value) => new ResponseComputerToolUseBlockUnion((global::Anthropic.ResponseComputerWaitToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseComputerWaitToolUseBlock?(ResponseComputerToolUseBlockUnion @this) => @this.Wait;

        /// <summary>
        ///
        /// </summary>
        public ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerWaitToolUseBlock? value)
        {
            Wait = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseComputerToolUseBlockUnion FromWait(global::Anthropic.ResponseComputerWaitToolUseBlock? value) => new ResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerScreenshotToolUseBlock value) => new ResponseComputerToolUseBlockUnion((global::Anthropic.ResponseComputerScreenshotToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseComputerScreenshotToolUseBlock?(ResponseComputerToolUseBlockUnion @this) => @this.Screenshot;

        /// <summary>
        ///
        /// </summary>
        public ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerScreenshotToolUseBlock? value)
        {
            Screenshot = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseComputerToolUseBlockUnion FromScreenshot(global::Anthropic.ResponseComputerScreenshotToolUseBlock? value) => new ResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerZoomToolUseBlock value) => new ResponseComputerToolUseBlockUnion((global::Anthropic.ResponseComputerZoomToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseComputerZoomToolUseBlock?(ResponseComputerToolUseBlockUnion @this) => @this.Zoom;

        /// <summary>
        ///
        /// </summary>
        public ResponseComputerToolUseBlockUnion(global::Anthropic.ResponseComputerZoomToolUseBlock? value)
        {
            Zoom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseComputerToolUseBlockUnion FromZoom(global::Anthropic.ResponseComputerZoomToolUseBlock? value) => new ResponseComputerToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public ResponseComputerToolUseBlockUnion(
            global::Anthropic.ResponseComputerToolUseBlockUnionDiscriminatorName? name,
            global::Anthropic.ResponseComputerKeyToolUseBlock? key,
            global::Anthropic.ResponseComputerHoldKeyToolUseBlock? holdKey,
            global::Anthropic.ResponseComputerTypeToolUseBlock? type,
            global::Anthropic.ResponseComputerCursorPositionToolUseBlock? cursorPosition,
            global::Anthropic.ResponseComputerMouseMoveToolUseBlock? mouseMove,
            global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock? leftMouseDown,
            global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock? leftMouseUp,
            global::Anthropic.ResponseComputerLeftClickToolUseBlock? leftClick,
            global::Anthropic.ResponseComputerLeftClickDragToolUseBlock? leftClickDrag,
            global::Anthropic.ResponseComputerRightClickToolUseBlock? rightClick,
            global::Anthropic.ResponseComputerMiddleClickToolUseBlock? middleClick,
            global::Anthropic.ResponseComputerDoubleClickToolUseBlock? doubleClick,
            global::Anthropic.ResponseComputerTripleClickToolUseBlock? tripleClick,
            global::Anthropic.ResponseComputerScrollToolUseBlock? scroll,
            global::Anthropic.ResponseComputerWaitToolUseBlock? wait,
            global::Anthropic.ResponseComputerScreenshotToolUseBlock? screenshot,
            global::Anthropic.ResponseComputerZoomToolUseBlock? zoom
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
            global::System.Func<global::Anthropic.ResponseComputerKeyToolUseBlock, TResult>? key = null,
            global::System.Func<global::Anthropic.ResponseComputerHoldKeyToolUseBlock, TResult>? holdKey = null,
            global::System.Func<global::Anthropic.ResponseComputerTypeToolUseBlock, TResult>? type = null,
            global::System.Func<global::Anthropic.ResponseComputerCursorPositionToolUseBlock, TResult>? cursorPosition = null,
            global::System.Func<global::Anthropic.ResponseComputerMouseMoveToolUseBlock, TResult>? mouseMove = null,
            global::System.Func<global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock, TResult>? leftMouseDown = null,
            global::System.Func<global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock, TResult>? leftMouseUp = null,
            global::System.Func<global::Anthropic.ResponseComputerLeftClickToolUseBlock, TResult>? leftClick = null,
            global::System.Func<global::Anthropic.ResponseComputerLeftClickDragToolUseBlock, TResult>? leftClickDrag = null,
            global::System.Func<global::Anthropic.ResponseComputerRightClickToolUseBlock, TResult>? rightClick = null,
            global::System.Func<global::Anthropic.ResponseComputerMiddleClickToolUseBlock, TResult>? middleClick = null,
            global::System.Func<global::Anthropic.ResponseComputerDoubleClickToolUseBlock, TResult>? doubleClick = null,
            global::System.Func<global::Anthropic.ResponseComputerTripleClickToolUseBlock, TResult>? tripleClick = null,
            global::System.Func<global::Anthropic.ResponseComputerScrollToolUseBlock, TResult>? scroll = null,
            global::System.Func<global::Anthropic.ResponseComputerWaitToolUseBlock, TResult>? wait = null,
            global::System.Func<global::Anthropic.ResponseComputerScreenshotToolUseBlock, TResult>? screenshot = null,
            global::System.Func<global::Anthropic.ResponseComputerZoomToolUseBlock, TResult>? zoom = null,
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
            global::System.Action<global::Anthropic.ResponseComputerKeyToolUseBlock>? key = null,

            global::System.Action<global::Anthropic.ResponseComputerHoldKeyToolUseBlock>? holdKey = null,

            global::System.Action<global::Anthropic.ResponseComputerTypeToolUseBlock>? type = null,

            global::System.Action<global::Anthropic.ResponseComputerCursorPositionToolUseBlock>? cursorPosition = null,

            global::System.Action<global::Anthropic.ResponseComputerMouseMoveToolUseBlock>? mouseMove = null,

            global::System.Action<global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock>? leftMouseDown = null,

            global::System.Action<global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock>? leftMouseUp = null,

            global::System.Action<global::Anthropic.ResponseComputerLeftClickToolUseBlock>? leftClick = null,

            global::System.Action<global::Anthropic.ResponseComputerLeftClickDragToolUseBlock>? leftClickDrag = null,

            global::System.Action<global::Anthropic.ResponseComputerRightClickToolUseBlock>? rightClick = null,

            global::System.Action<global::Anthropic.ResponseComputerMiddleClickToolUseBlock>? middleClick = null,

            global::System.Action<global::Anthropic.ResponseComputerDoubleClickToolUseBlock>? doubleClick = null,

            global::System.Action<global::Anthropic.ResponseComputerTripleClickToolUseBlock>? tripleClick = null,

            global::System.Action<global::Anthropic.ResponseComputerScrollToolUseBlock>? scroll = null,

            global::System.Action<global::Anthropic.ResponseComputerWaitToolUseBlock>? wait = null,

            global::System.Action<global::Anthropic.ResponseComputerScreenshotToolUseBlock>? screenshot = null,

            global::System.Action<global::Anthropic.ResponseComputerZoomToolUseBlock>? zoom = null,
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
            global::System.Action<global::Anthropic.ResponseComputerKeyToolUseBlock>? key = null,
            global::System.Action<global::Anthropic.ResponseComputerHoldKeyToolUseBlock>? holdKey = null,
            global::System.Action<global::Anthropic.ResponseComputerTypeToolUseBlock>? type = null,
            global::System.Action<global::Anthropic.ResponseComputerCursorPositionToolUseBlock>? cursorPosition = null,
            global::System.Action<global::Anthropic.ResponseComputerMouseMoveToolUseBlock>? mouseMove = null,
            global::System.Action<global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock>? leftMouseDown = null,
            global::System.Action<global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock>? leftMouseUp = null,
            global::System.Action<global::Anthropic.ResponseComputerLeftClickToolUseBlock>? leftClick = null,
            global::System.Action<global::Anthropic.ResponseComputerLeftClickDragToolUseBlock>? leftClickDrag = null,
            global::System.Action<global::Anthropic.ResponseComputerRightClickToolUseBlock>? rightClick = null,
            global::System.Action<global::Anthropic.ResponseComputerMiddleClickToolUseBlock>? middleClick = null,
            global::System.Action<global::Anthropic.ResponseComputerDoubleClickToolUseBlock>? doubleClick = null,
            global::System.Action<global::Anthropic.ResponseComputerTripleClickToolUseBlock>? tripleClick = null,
            global::System.Action<global::Anthropic.ResponseComputerScrollToolUseBlock>? scroll = null,
            global::System.Action<global::Anthropic.ResponseComputerWaitToolUseBlock>? wait = null,
            global::System.Action<global::Anthropic.ResponseComputerScreenshotToolUseBlock>? screenshot = null,
            global::System.Action<global::Anthropic.ResponseComputerZoomToolUseBlock>? zoom = null,
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
                typeof(global::Anthropic.ResponseComputerKeyToolUseBlock),
                HoldKey,
                typeof(global::Anthropic.ResponseComputerHoldKeyToolUseBlock),
                Type,
                typeof(global::Anthropic.ResponseComputerTypeToolUseBlock),
                CursorPosition,
                typeof(global::Anthropic.ResponseComputerCursorPositionToolUseBlock),
                MouseMove,
                typeof(global::Anthropic.ResponseComputerMouseMoveToolUseBlock),
                LeftMouseDown,
                typeof(global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock),
                LeftMouseUp,
                typeof(global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock),
                LeftClick,
                typeof(global::Anthropic.ResponseComputerLeftClickToolUseBlock),
                LeftClickDrag,
                typeof(global::Anthropic.ResponseComputerLeftClickDragToolUseBlock),
                RightClick,
                typeof(global::Anthropic.ResponseComputerRightClickToolUseBlock),
                MiddleClick,
                typeof(global::Anthropic.ResponseComputerMiddleClickToolUseBlock),
                DoubleClick,
                typeof(global::Anthropic.ResponseComputerDoubleClickToolUseBlock),
                TripleClick,
                typeof(global::Anthropic.ResponseComputerTripleClickToolUseBlock),
                Scroll,
                typeof(global::Anthropic.ResponseComputerScrollToolUseBlock),
                Wait,
                typeof(global::Anthropic.ResponseComputerWaitToolUseBlock),
                Screenshot,
                typeof(global::Anthropic.ResponseComputerScreenshotToolUseBlock),
                Zoom,
                typeof(global::Anthropic.ResponseComputerZoomToolUseBlock),
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
        public bool Equals(ResponseComputerToolUseBlockUnion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseComputerKeyToolUseBlock?>.Default.Equals(Key, other.Key) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseComputerHoldKeyToolUseBlock?>.Default.Equals(HoldKey, other.HoldKey) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseComputerTypeToolUseBlock?>.Default.Equals(Type, other.Type) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseComputerCursorPositionToolUseBlock?>.Default.Equals(CursorPosition, other.CursorPosition) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseComputerMouseMoveToolUseBlock?>.Default.Equals(MouseMove, other.MouseMove) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseComputerLeftMouseDownToolUseBlock?>.Default.Equals(LeftMouseDown, other.LeftMouseDown) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseComputerLeftMouseUpToolUseBlock?>.Default.Equals(LeftMouseUp, other.LeftMouseUp) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseComputerLeftClickToolUseBlock?>.Default.Equals(LeftClick, other.LeftClick) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseComputerLeftClickDragToolUseBlock?>.Default.Equals(LeftClickDrag, other.LeftClickDrag) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseComputerRightClickToolUseBlock?>.Default.Equals(RightClick, other.RightClick) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseComputerMiddleClickToolUseBlock?>.Default.Equals(MiddleClick, other.MiddleClick) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseComputerDoubleClickToolUseBlock?>.Default.Equals(DoubleClick, other.DoubleClick) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseComputerTripleClickToolUseBlock?>.Default.Equals(TripleClick, other.TripleClick) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseComputerScrollToolUseBlock?>.Default.Equals(Scroll, other.Scroll) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseComputerWaitToolUseBlock?>.Default.Equals(Wait, other.Wait) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseComputerScreenshotToolUseBlock?>.Default.Equals(Screenshot, other.Screenshot) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseComputerZoomToolUseBlock?>.Default.Equals(Zoom, other.Zoom)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponseComputerToolUseBlockUnion obj1, ResponseComputerToolUseBlockUnion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseComputerToolUseBlockUnion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponseComputerToolUseBlockUnion obj1, ResponseComputerToolUseBlockUnion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseComputerToolUseBlockUnion o && Equals(o);
        }
    }
}
