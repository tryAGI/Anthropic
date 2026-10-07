
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResponseComputerToolUseBlockUnionDiscriminatorName
    {
        /// <summary>
        ///
        /// </summary>
        CursorPosition,
        /// <summary>
        ///
        /// </summary>
        DoubleClick,
        /// <summary>
        ///
        /// </summary>
        HoldKey,
        /// <summary>
        ///
        /// </summary>
        Key,
        /// <summary>
        ///
        /// </summary>
        LeftClick,
        /// <summary>
        ///
        /// </summary>
        LeftClickDrag,
        /// <summary>
        ///
        /// </summary>
        LeftMouseDown,
        /// <summary>
        ///
        /// </summary>
        LeftMouseUp,
        /// <summary>
        ///
        /// </summary>
        MiddleClick,
        /// <summary>
        ///
        /// </summary>
        MouseMove,
        /// <summary>
        ///
        /// </summary>
        RightClick,
        /// <summary>
        ///
        /// </summary>
        Screenshot,
        /// <summary>
        ///
        /// </summary>
        Scroll,
        /// <summary>
        ///
        /// </summary>
        TripleClick,
        /// <summary>
        ///
        /// </summary>
        Type,
        /// <summary>
        ///
        /// </summary>
        Wait,
        /// <summary>
        ///
        /// </summary>
        Zoom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseComputerToolUseBlockUnionDiscriminatorNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseComputerToolUseBlockUnionDiscriminatorName value)
        {
            return value switch
            {
                BetaResponseComputerToolUseBlockUnionDiscriminatorName.CursorPosition => "cursor_position",
                BetaResponseComputerToolUseBlockUnionDiscriminatorName.DoubleClick => "double_click",
                BetaResponseComputerToolUseBlockUnionDiscriminatorName.HoldKey => "hold_key",
                BetaResponseComputerToolUseBlockUnionDiscriminatorName.Key => "key",
                BetaResponseComputerToolUseBlockUnionDiscriminatorName.LeftClick => "left_click",
                BetaResponseComputerToolUseBlockUnionDiscriminatorName.LeftClickDrag => "left_click_drag",
                BetaResponseComputerToolUseBlockUnionDiscriminatorName.LeftMouseDown => "left_mouse_down",
                BetaResponseComputerToolUseBlockUnionDiscriminatorName.LeftMouseUp => "left_mouse_up",
                BetaResponseComputerToolUseBlockUnionDiscriminatorName.MiddleClick => "middle_click",
                BetaResponseComputerToolUseBlockUnionDiscriminatorName.MouseMove => "mouse_move",
                BetaResponseComputerToolUseBlockUnionDiscriminatorName.RightClick => "right_click",
                BetaResponseComputerToolUseBlockUnionDiscriminatorName.Screenshot => "screenshot",
                BetaResponseComputerToolUseBlockUnionDiscriminatorName.Scroll => "scroll",
                BetaResponseComputerToolUseBlockUnionDiscriminatorName.TripleClick => "triple_click",
                BetaResponseComputerToolUseBlockUnionDiscriminatorName.Type => "type",
                BetaResponseComputerToolUseBlockUnionDiscriminatorName.Wait => "wait",
                BetaResponseComputerToolUseBlockUnionDiscriminatorName.Zoom => "zoom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseComputerToolUseBlockUnionDiscriminatorName? ToEnum(string value)
        {
            return value switch
            {
                "cursor_position" => BetaResponseComputerToolUseBlockUnionDiscriminatorName.CursorPosition,
                "double_click" => BetaResponseComputerToolUseBlockUnionDiscriminatorName.DoubleClick,
                "hold_key" => BetaResponseComputerToolUseBlockUnionDiscriminatorName.HoldKey,
                "key" => BetaResponseComputerToolUseBlockUnionDiscriminatorName.Key,
                "left_click" => BetaResponseComputerToolUseBlockUnionDiscriminatorName.LeftClick,
                "left_click_drag" => BetaResponseComputerToolUseBlockUnionDiscriminatorName.LeftClickDrag,
                "left_mouse_down" => BetaResponseComputerToolUseBlockUnionDiscriminatorName.LeftMouseDown,
                "left_mouse_up" => BetaResponseComputerToolUseBlockUnionDiscriminatorName.LeftMouseUp,
                "middle_click" => BetaResponseComputerToolUseBlockUnionDiscriminatorName.MiddleClick,
                "mouse_move" => BetaResponseComputerToolUseBlockUnionDiscriminatorName.MouseMove,
                "right_click" => BetaResponseComputerToolUseBlockUnionDiscriminatorName.RightClick,
                "screenshot" => BetaResponseComputerToolUseBlockUnionDiscriminatorName.Screenshot,
                "scroll" => BetaResponseComputerToolUseBlockUnionDiscriminatorName.Scroll,
                "triple_click" => BetaResponseComputerToolUseBlockUnionDiscriminatorName.TripleClick,
                "type" => BetaResponseComputerToolUseBlockUnionDiscriminatorName.Type,
                "wait" => BetaResponseComputerToolUseBlockUnionDiscriminatorName.Wait,
                "zoom" => BetaResponseComputerToolUseBlockUnionDiscriminatorName.Zoom,
                _ => null,
            };
        }
    }
}