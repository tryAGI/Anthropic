
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
    public sealed partial class BetaComputerToolsetConfigs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor_position")]
        public global::Anthropic.BetaComputerCursorPositionConfig? CursorPosition { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("double_click")]
        public global::Anthropic.BetaComputerDoubleClickConfig? DoubleClick { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hold_key")]
        public global::Anthropic.BetaComputerHoldKeyConfig? HoldKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public global::Anthropic.BetaComputerKeyConfig? Key { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_click")]
        public global::Anthropic.BetaComputerLeftClickConfig? LeftClick { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_click_drag")]
        public global::Anthropic.BetaComputerLeftClickDragConfig? LeftClickDrag { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_mouse_down")]
        public global::Anthropic.BetaComputerLeftMouseDownConfig? LeftMouseDown { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_mouse_up")]
        public global::Anthropic.BetaComputerLeftMouseUpConfig? LeftMouseUp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("middle_click")]
        public global::Anthropic.BetaComputerMiddleClickConfig? MiddleClick { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mouse_move")]
        public global::Anthropic.BetaComputerMouseMoveConfig? MouseMove { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right_click")]
        public global::Anthropic.BetaComputerRightClickConfig? RightClick { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("screenshot")]
        public global::Anthropic.BetaComputerScreenshotConfig? Screenshot { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scroll")]
        public global::Anthropic.BetaComputerScrollConfig? Scroll { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triple_click")]
        public global::Anthropic.BetaComputerTripleClickConfig? TripleClick { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::Anthropic.BetaComputerTypeConfig? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wait")]
        public global::Anthropic.BetaComputerWaitConfig? Wait { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zoom")]
        public global::Anthropic.BetaComputerZoomConfig? Zoom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerToolsetConfigs" /> class.
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
        public BetaComputerToolsetConfigs(
            global::Anthropic.BetaComputerCursorPositionConfig? cursorPosition,
            global::Anthropic.BetaComputerDoubleClickConfig? doubleClick,
            global::Anthropic.BetaComputerHoldKeyConfig? holdKey,
            global::Anthropic.BetaComputerKeyConfig? key,
            global::Anthropic.BetaComputerLeftClickConfig? leftClick,
            global::Anthropic.BetaComputerLeftClickDragConfig? leftClickDrag,
            global::Anthropic.BetaComputerLeftMouseDownConfig? leftMouseDown,
            global::Anthropic.BetaComputerLeftMouseUpConfig? leftMouseUp,
            global::Anthropic.BetaComputerMiddleClickConfig? middleClick,
            global::Anthropic.BetaComputerMouseMoveConfig? mouseMove,
            global::Anthropic.BetaComputerRightClickConfig? rightClick,
            global::Anthropic.BetaComputerScreenshotConfig? screenshot,
            global::Anthropic.BetaComputerScrollConfig? scroll,
            global::Anthropic.BetaComputerTripleClickConfig? tripleClick,
            global::Anthropic.BetaComputerTypeConfig? type,
            global::Anthropic.BetaComputerWaitConfig? wait,
            global::Anthropic.BetaComputerZoomConfig? zoom)
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
        /// Initializes a new instance of the <see cref="BetaComputerToolsetConfigs" /> class.
        /// </summary>
        public BetaComputerToolsetConfigs()
        {
        }

    }
}