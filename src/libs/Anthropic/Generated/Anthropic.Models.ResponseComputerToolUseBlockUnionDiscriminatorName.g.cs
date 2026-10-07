
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponseComputerToolUseBlockUnionDiscriminatorName
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
    public static class ResponseComputerToolUseBlockUnionDiscriminatorNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseComputerToolUseBlockUnionDiscriminatorName value)
        {
            return value switch
            {
                ResponseComputerToolUseBlockUnionDiscriminatorName.CursorPosition => "cursor_position",
                ResponseComputerToolUseBlockUnionDiscriminatorName.DoubleClick => "double_click",
                ResponseComputerToolUseBlockUnionDiscriminatorName.HoldKey => "hold_key",
                ResponseComputerToolUseBlockUnionDiscriminatorName.Key => "key",
                ResponseComputerToolUseBlockUnionDiscriminatorName.LeftClick => "left_click",
                ResponseComputerToolUseBlockUnionDiscriminatorName.LeftClickDrag => "left_click_drag",
                ResponseComputerToolUseBlockUnionDiscriminatorName.LeftMouseDown => "left_mouse_down",
                ResponseComputerToolUseBlockUnionDiscriminatorName.LeftMouseUp => "left_mouse_up",
                ResponseComputerToolUseBlockUnionDiscriminatorName.MiddleClick => "middle_click",
                ResponseComputerToolUseBlockUnionDiscriminatorName.MouseMove => "mouse_move",
                ResponseComputerToolUseBlockUnionDiscriminatorName.RightClick => "right_click",
                ResponseComputerToolUseBlockUnionDiscriminatorName.Screenshot => "screenshot",
                ResponseComputerToolUseBlockUnionDiscriminatorName.Scroll => "scroll",
                ResponseComputerToolUseBlockUnionDiscriminatorName.TripleClick => "triple_click",
                ResponseComputerToolUseBlockUnionDiscriminatorName.Type => "type",
                ResponseComputerToolUseBlockUnionDiscriminatorName.Wait => "wait",
                ResponseComputerToolUseBlockUnionDiscriminatorName.Zoom => "zoom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseComputerToolUseBlockUnionDiscriminatorName? ToEnum(string value)
        {
            return value switch
            {
                "cursor_position" => ResponseComputerToolUseBlockUnionDiscriminatorName.CursorPosition,
                "double_click" => ResponseComputerToolUseBlockUnionDiscriminatorName.DoubleClick,
                "hold_key" => ResponseComputerToolUseBlockUnionDiscriminatorName.HoldKey,
                "key" => ResponseComputerToolUseBlockUnionDiscriminatorName.Key,
                "left_click" => ResponseComputerToolUseBlockUnionDiscriminatorName.LeftClick,
                "left_click_drag" => ResponseComputerToolUseBlockUnionDiscriminatorName.LeftClickDrag,
                "left_mouse_down" => ResponseComputerToolUseBlockUnionDiscriminatorName.LeftMouseDown,
                "left_mouse_up" => ResponseComputerToolUseBlockUnionDiscriminatorName.LeftMouseUp,
                "middle_click" => ResponseComputerToolUseBlockUnionDiscriminatorName.MiddleClick,
                "mouse_move" => ResponseComputerToolUseBlockUnionDiscriminatorName.MouseMove,
                "right_click" => ResponseComputerToolUseBlockUnionDiscriminatorName.RightClick,
                "screenshot" => ResponseComputerToolUseBlockUnionDiscriminatorName.Screenshot,
                "scroll" => ResponseComputerToolUseBlockUnionDiscriminatorName.Scroll,
                "triple_click" => ResponseComputerToolUseBlockUnionDiscriminatorName.TripleClick,
                "type" => ResponseComputerToolUseBlockUnionDiscriminatorName.Type,
                "wait" => ResponseComputerToolUseBlockUnionDiscriminatorName.Wait,
                "zoom" => ResponseComputerToolUseBlockUnionDiscriminatorName.Zoom,
                _ => null,
            };
        }
    }
}