
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponseBrowserToolUseBlockUnionDiscriminatorName
    {
        /// <summary>
        ///
        /// </summary>
        CloseTab,
        /// <summary>
        ///
        /// </summary>
        DoubleClick,
        /// <summary>
        ///
        /// </summary>
        FileUpload,
        /// <summary>
        ///
        /// </summary>
        Find,
        /// <summary>
        ///
        /// </summary>
        FormInput,
        /// <summary>
        ///
        /// </summary>
        GetPageText,
        /// <summary>
        ///
        /// </summary>
        HoldKey,
        /// <summary>
        ///
        /// </summary>
        Hover,
        /// <summary>
        ///
        /// </summary>
        JavascriptExec,
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
        ListTabs,
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
        Navigate,
        /// <summary>
        ///
        /// </summary>
        NewTab,
        /// <summary>
        ///
        /// </summary>
        ReadConsole,
        /// <summary>
        ///
        /// </summary>
        ReadNetwork,
        /// <summary>
        ///
        /// </summary>
        ReadPage,
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
        ScrollTo,
        /// <summary>
        ///
        /// </summary>
        SwitchTab,
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
    public static class ResponseBrowserToolUseBlockUnionDiscriminatorNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseBrowserToolUseBlockUnionDiscriminatorName value)
        {
            return value switch
            {
                ResponseBrowserToolUseBlockUnionDiscriminatorName.CloseTab => "close_tab",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.DoubleClick => "double_click",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.FileUpload => "file_upload",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.Find => "find",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.FormInput => "form_input",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.GetPageText => "get_page_text",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.HoldKey => "hold_key",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.Hover => "hover",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.JavascriptExec => "javascript_exec",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.Key => "key",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.LeftClick => "left_click",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.LeftClickDrag => "left_click_drag",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.LeftMouseDown => "left_mouse_down",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.LeftMouseUp => "left_mouse_up",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.ListTabs => "list_tabs",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.MiddleClick => "middle_click",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.MouseMove => "mouse_move",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.Navigate => "navigate",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.NewTab => "new_tab",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.ReadConsole => "read_console",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.ReadNetwork => "read_network",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.ReadPage => "read_page",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.RightClick => "right_click",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.Screenshot => "screenshot",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.Scroll => "scroll",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.ScrollTo => "scroll_to",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.SwitchTab => "switch_tab",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.TripleClick => "triple_click",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.Type => "type",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.Wait => "wait",
                ResponseBrowserToolUseBlockUnionDiscriminatorName.Zoom => "zoom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseBrowserToolUseBlockUnionDiscriminatorName? ToEnum(string value)
        {
            return value switch
            {
                "close_tab" => ResponseBrowserToolUseBlockUnionDiscriminatorName.CloseTab,
                "double_click" => ResponseBrowserToolUseBlockUnionDiscriminatorName.DoubleClick,
                "file_upload" => ResponseBrowserToolUseBlockUnionDiscriminatorName.FileUpload,
                "find" => ResponseBrowserToolUseBlockUnionDiscriminatorName.Find,
                "form_input" => ResponseBrowserToolUseBlockUnionDiscriminatorName.FormInput,
                "get_page_text" => ResponseBrowserToolUseBlockUnionDiscriminatorName.GetPageText,
                "hold_key" => ResponseBrowserToolUseBlockUnionDiscriminatorName.HoldKey,
                "hover" => ResponseBrowserToolUseBlockUnionDiscriminatorName.Hover,
                "javascript_exec" => ResponseBrowserToolUseBlockUnionDiscriminatorName.JavascriptExec,
                "key" => ResponseBrowserToolUseBlockUnionDiscriminatorName.Key,
                "left_click" => ResponseBrowserToolUseBlockUnionDiscriminatorName.LeftClick,
                "left_click_drag" => ResponseBrowserToolUseBlockUnionDiscriminatorName.LeftClickDrag,
                "left_mouse_down" => ResponseBrowserToolUseBlockUnionDiscriminatorName.LeftMouseDown,
                "left_mouse_up" => ResponseBrowserToolUseBlockUnionDiscriminatorName.LeftMouseUp,
                "list_tabs" => ResponseBrowserToolUseBlockUnionDiscriminatorName.ListTabs,
                "middle_click" => ResponseBrowserToolUseBlockUnionDiscriminatorName.MiddleClick,
                "mouse_move" => ResponseBrowserToolUseBlockUnionDiscriminatorName.MouseMove,
                "navigate" => ResponseBrowserToolUseBlockUnionDiscriminatorName.Navigate,
                "new_tab" => ResponseBrowserToolUseBlockUnionDiscriminatorName.NewTab,
                "read_console" => ResponseBrowserToolUseBlockUnionDiscriminatorName.ReadConsole,
                "read_network" => ResponseBrowserToolUseBlockUnionDiscriminatorName.ReadNetwork,
                "read_page" => ResponseBrowserToolUseBlockUnionDiscriminatorName.ReadPage,
                "right_click" => ResponseBrowserToolUseBlockUnionDiscriminatorName.RightClick,
                "screenshot" => ResponseBrowserToolUseBlockUnionDiscriminatorName.Screenshot,
                "scroll" => ResponseBrowserToolUseBlockUnionDiscriminatorName.Scroll,
                "scroll_to" => ResponseBrowserToolUseBlockUnionDiscriminatorName.ScrollTo,
                "switch_tab" => ResponseBrowserToolUseBlockUnionDiscriminatorName.SwitchTab,
                "triple_click" => ResponseBrowserToolUseBlockUnionDiscriminatorName.TripleClick,
                "type" => ResponseBrowserToolUseBlockUnionDiscriminatorName.Type,
                "wait" => ResponseBrowserToolUseBlockUnionDiscriminatorName.Wait,
                "zoom" => ResponseBrowserToolUseBlockUnionDiscriminatorName.Zoom,
                _ => null,
            };
        }
    }
}