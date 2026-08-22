
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Per-member configuration for ``browser_toolset_20260801``: one<br/>
    /// optional field per member tool, keyed by the member name — the same<br/>
    /// name the member's ``tool_use`` blocks carry. Every member is an<br/>
    /// accepted key, and a member's defaults apply wherever its key is<br/>
    /// absent. Unknown keys are rejected: the field set is this toolset<br/>
    /// version's complete member set.
    /// </summary>
    public sealed partial class BetaBrowserToolsetConfigs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("close_tab")]
        public global::Anthropic.BetaBrowserCloseTabConfig? CloseTab { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("double_click")]
        public global::Anthropic.BetaBrowserDoubleClickConfig? DoubleClick { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_upload")]
        public global::Anthropic.BetaBrowserFileUploadConfig? FileUpload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("find")]
        public global::Anthropic.BetaBrowserFindConfig? Find { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("form_input")]
        public global::Anthropic.BetaBrowserFormInputConfig? FormInput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("get_page_text")]
        public global::Anthropic.BetaBrowserGetPageTextConfig? GetPageText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hold_key")]
        public global::Anthropic.BetaBrowserHoldKeyConfig? HoldKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hover")]
        public global::Anthropic.BetaBrowserHoverConfig? Hover { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("javascript_exec")]
        public global::Anthropic.BetaBrowserJavascriptExecConfig? JavascriptExec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public global::Anthropic.BetaBrowserKeyConfig? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_click")]
        public global::Anthropic.BetaBrowserLeftClickConfig? LeftClick { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_click_drag")]
        public global::Anthropic.BetaBrowserLeftClickDragConfig? LeftClickDrag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_mouse_down")]
        public global::Anthropic.BetaBrowserLeftMouseDownConfig? LeftMouseDown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_mouse_up")]
        public global::Anthropic.BetaBrowserLeftMouseUpConfig? LeftMouseUp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("list_tabs")]
        public global::Anthropic.BetaBrowserListTabsConfig? ListTabs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("middle_click")]
        public global::Anthropic.BetaBrowserMiddleClickConfig? MiddleClick { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mouse_move")]
        public global::Anthropic.BetaBrowserMouseMoveConfig? MouseMove { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("navigate")]
        public global::Anthropic.BetaBrowserNavigateConfig? Navigate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_tab")]
        public global::Anthropic.BetaBrowserNewTabConfig? NewTab { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_console")]
        public global::Anthropic.BetaBrowserReadConsoleConfig? ReadConsole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_network")]
        public global::Anthropic.BetaBrowserReadNetworkConfig? ReadNetwork { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_page")]
        public global::Anthropic.BetaBrowserReadPageConfig? ReadPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right_click")]
        public global::Anthropic.BetaBrowserRightClickConfig? RightClick { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("screenshot")]
        public global::Anthropic.BetaBrowserScreenshotConfig? Screenshot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scroll")]
        public global::Anthropic.BetaBrowserScrollConfig? Scroll { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scroll_to")]
        public global::Anthropic.BetaBrowserScrollToConfig? ScrollTo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("switch_tab")]
        public global::Anthropic.BetaBrowserSwitchTabConfig? SwitchTab { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triple_click")]
        public global::Anthropic.BetaBrowserTripleClickConfig? TripleClick { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::Anthropic.BetaBrowserTypeConfig? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wait")]
        public global::Anthropic.BetaBrowserWaitConfig? Wait { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zoom")]
        public global::Anthropic.BetaBrowserZoomConfig? Zoom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBrowserToolsetConfigs" /> class.
        /// </summary>
        /// <param name="closeTab"></param>
        /// <param name="doubleClick"></param>
        /// <param name="fileUpload"></param>
        /// <param name="find"></param>
        /// <param name="formInput"></param>
        /// <param name="getPageText"></param>
        /// <param name="holdKey"></param>
        /// <param name="hover"></param>
        /// <param name="javascriptExec"></param>
        /// <param name="key"></param>
        /// <param name="leftClick"></param>
        /// <param name="leftClickDrag"></param>
        /// <param name="leftMouseDown"></param>
        /// <param name="leftMouseUp"></param>
        /// <param name="listTabs"></param>
        /// <param name="middleClick"></param>
        /// <param name="mouseMove"></param>
        /// <param name="navigate"></param>
        /// <param name="newTab"></param>
        /// <param name="readConsole"></param>
        /// <param name="readNetwork"></param>
        /// <param name="readPage"></param>
        /// <param name="rightClick"></param>
        /// <param name="screenshot"></param>
        /// <param name="scroll"></param>
        /// <param name="scrollTo"></param>
        /// <param name="switchTab"></param>
        /// <param name="tripleClick"></param>
        /// <param name="type"></param>
        /// <param name="wait"></param>
        /// <param name="zoom"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBrowserToolsetConfigs(
            global::Anthropic.BetaBrowserCloseTabConfig? closeTab,
            global::Anthropic.BetaBrowserDoubleClickConfig? doubleClick,
            global::Anthropic.BetaBrowserFileUploadConfig? fileUpload,
            global::Anthropic.BetaBrowserFindConfig? find,
            global::Anthropic.BetaBrowserFormInputConfig? formInput,
            global::Anthropic.BetaBrowserGetPageTextConfig? getPageText,
            global::Anthropic.BetaBrowserHoldKeyConfig? holdKey,
            global::Anthropic.BetaBrowserHoverConfig? hover,
            global::Anthropic.BetaBrowserJavascriptExecConfig? javascriptExec,
            global::Anthropic.BetaBrowserKeyConfig? key,
            global::Anthropic.BetaBrowserLeftClickConfig? leftClick,
            global::Anthropic.BetaBrowserLeftClickDragConfig? leftClickDrag,
            global::Anthropic.BetaBrowserLeftMouseDownConfig? leftMouseDown,
            global::Anthropic.BetaBrowserLeftMouseUpConfig? leftMouseUp,
            global::Anthropic.BetaBrowserListTabsConfig? listTabs,
            global::Anthropic.BetaBrowserMiddleClickConfig? middleClick,
            global::Anthropic.BetaBrowserMouseMoveConfig? mouseMove,
            global::Anthropic.BetaBrowserNavigateConfig? navigate,
            global::Anthropic.BetaBrowserNewTabConfig? newTab,
            global::Anthropic.BetaBrowserReadConsoleConfig? readConsole,
            global::Anthropic.BetaBrowserReadNetworkConfig? readNetwork,
            global::Anthropic.BetaBrowserReadPageConfig? readPage,
            global::Anthropic.BetaBrowserRightClickConfig? rightClick,
            global::Anthropic.BetaBrowserScreenshotConfig? screenshot,
            global::Anthropic.BetaBrowserScrollConfig? scroll,
            global::Anthropic.BetaBrowserScrollToConfig? scrollTo,
            global::Anthropic.BetaBrowserSwitchTabConfig? switchTab,
            global::Anthropic.BetaBrowserTripleClickConfig? tripleClick,
            global::Anthropic.BetaBrowserTypeConfig? type,
            global::Anthropic.BetaBrowserWaitConfig? wait,
            global::Anthropic.BetaBrowserZoomConfig? zoom)
        {
            this.CloseTab = closeTab;
            this.DoubleClick = doubleClick;
            this.FileUpload = fileUpload;
            this.Find = find;
            this.FormInput = formInput;
            this.GetPageText = getPageText;
            this.HoldKey = holdKey;
            this.Hover = hover;
            this.JavascriptExec = javascriptExec;
            this.Key = key;
            this.LeftClick = leftClick;
            this.LeftClickDrag = leftClickDrag;
            this.LeftMouseDown = leftMouseDown;
            this.LeftMouseUp = leftMouseUp;
            this.ListTabs = listTabs;
            this.MiddleClick = middleClick;
            this.MouseMove = mouseMove;
            this.Navigate = navigate;
            this.NewTab = newTab;
            this.ReadConsole = readConsole;
            this.ReadNetwork = readNetwork;
            this.ReadPage = readPage;
            this.RightClick = rightClick;
            this.Screenshot = screenshot;
            this.Scroll = scroll;
            this.ScrollTo = scrollTo;
            this.SwitchTab = switchTab;
            this.TripleClick = tripleClick;
            this.Type = type;
            this.Wait = wait;
            this.Zoom = zoom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBrowserToolsetConfigs" /> class.
        /// </summary>
        public BetaBrowserToolsetConfigs()
        {
        }

    }
}