
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Per-member configuration for ``computer_toolset_20260801``: one<br/>
    /// optional field per member tool, keyed by the member name — the same<br/>
    /// name the member's ``tool_use`` blocks carry. Every member is an<br/>
    /// accepted key, and a member's defaults apply wherever its key is<br/>
    /// absent. Unknown keys are rejected: the field set is this toolset<br/>
    /// version's complete member set.
    /// </summary>
    public sealed partial class ComputerToolsetConfigs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor_position")]
        public global::Anthropic.ComputerCursorPositionConfig? CursorPosition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("double_click")]
        public global::Anthropic.ComputerDoubleClickConfig? DoubleClick { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hold_key")]
        public global::Anthropic.ComputerHoldKeyConfig? HoldKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public global::Anthropic.ComputerKeyConfig? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_click")]
        public global::Anthropic.ComputerLeftClickConfig? LeftClick { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_click_drag")]
        public global::Anthropic.ComputerLeftClickDragConfig? LeftClickDrag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_mouse_down")]
        public global::Anthropic.ComputerLeftMouseDownConfig? LeftMouseDown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_mouse_up")]
        public global::Anthropic.ComputerLeftMouseUpConfig? LeftMouseUp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("middle_click")]
        public global::Anthropic.ComputerMiddleClickConfig? MiddleClick { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mouse_move")]
        public global::Anthropic.ComputerMouseMoveConfig? MouseMove { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right_click")]
        public global::Anthropic.ComputerRightClickConfig? RightClick { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("screenshot")]
        public global::Anthropic.ComputerScreenshotConfig? Screenshot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scroll")]
        public global::Anthropic.ComputerScrollConfig? Scroll { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triple_click")]
        public global::Anthropic.ComputerTripleClickConfig? TripleClick { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::Anthropic.ComputerTypeConfig? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wait")]
        public global::Anthropic.ComputerWaitConfig? Wait { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zoom")]
        public global::Anthropic.ComputerZoomConfig? Zoom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerToolsetConfigs" /> class.
        /// </summary>
        /// <param name="cursorPosition"></param>
        /// <param name="doubleClick"></param>
        /// <param name="holdKey"></param>
        /// <param name="key"></param>
        /// <param name="leftClick"></param>
        /// <param name="leftClickDrag"></param>
        /// <param name="leftMouseDown"></param>
        /// <param name="leftMouseUp"></param>
        /// <param name="middleClick"></param>
        /// <param name="mouseMove"></param>
        /// <param name="rightClick"></param>
        /// <param name="screenshot"></param>
        /// <param name="scroll"></param>
        /// <param name="tripleClick"></param>
        /// <param name="type"></param>
        /// <param name="wait"></param>
        /// <param name="zoom"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerToolsetConfigs(
            global::Anthropic.ComputerCursorPositionConfig? cursorPosition,
            global::Anthropic.ComputerDoubleClickConfig? doubleClick,
            global::Anthropic.ComputerHoldKeyConfig? holdKey,
            global::Anthropic.ComputerKeyConfig? key,
            global::Anthropic.ComputerLeftClickConfig? leftClick,
            global::Anthropic.ComputerLeftClickDragConfig? leftClickDrag,
            global::Anthropic.ComputerLeftMouseDownConfig? leftMouseDown,
            global::Anthropic.ComputerLeftMouseUpConfig? leftMouseUp,
            global::Anthropic.ComputerMiddleClickConfig? middleClick,
            global::Anthropic.ComputerMouseMoveConfig? mouseMove,
            global::Anthropic.ComputerRightClickConfig? rightClick,
            global::Anthropic.ComputerScreenshotConfig? screenshot,
            global::Anthropic.ComputerScrollConfig? scroll,
            global::Anthropic.ComputerTripleClickConfig? tripleClick,
            global::Anthropic.ComputerTypeConfig? type,
            global::Anthropic.ComputerWaitConfig? wait,
            global::Anthropic.ComputerZoomConfig? zoom)
        {
            this.CursorPosition = cursorPosition;
            this.DoubleClick = doubleClick;
            this.HoldKey = holdKey;
            this.Key = key;
            this.LeftClick = leftClick;
            this.LeftClickDrag = leftClickDrag;
            this.LeftMouseDown = leftMouseDown;
            this.LeftMouseUp = leftMouseUp;
            this.MiddleClick = middleClick;
            this.MouseMove = mouseMove;
            this.RightClick = rightClick;
            this.Screenshot = screenshot;
            this.Scroll = scroll;
            this.TripleClick = tripleClick;
            this.Type = type;
            this.Wait = wait;
            this.Zoom = zoom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerToolsetConfigs" /> class.
        /// </summary>
        public ComputerToolsetConfigs()
        {
        }

    }
}