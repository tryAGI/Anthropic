
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResponseBrowserToolUseBlockUnionDiscriminatorName
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
    public static class BetaResponseBrowserToolUseBlockUnionDiscriminatorNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseBrowserToolUseBlockUnionDiscriminatorName value)
        {
            return value switch
            {
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.CloseTab => "close_tab",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.DoubleClick => "double_click",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.FileUpload => "file_upload",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Find => "find",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.FormInput => "form_input",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.GetPageText => "get_page_text",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.HoldKey => "hold_key",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Hover => "hover",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.JavascriptExec => "javascript_exec",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Key => "key",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.LeftClick => "left_click",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.LeftClickDrag => "left_click_drag",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.LeftMouseDown => "left_mouse_down",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.LeftMouseUp => "left_mouse_up",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.ListTabs => "list_tabs",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.MiddleClick => "middle_click",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.MouseMove => "mouse_move",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Navigate => "navigate",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.NewTab => "new_tab",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.ReadConsole => "read_console",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.ReadNetwork => "read_network",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.ReadPage => "read_page",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.RightClick => "right_click",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Screenshot => "screenshot",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Scroll => "scroll",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.ScrollTo => "scroll_to",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.SwitchTab => "switch_tab",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.TripleClick => "triple_click",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Type => "type",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Wait => "wait",
                BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Zoom => "zoom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseBrowserToolUseBlockUnionDiscriminatorName? ToEnum(string value)
        {
            return value switch
            {
                "close_tab" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.CloseTab,
                "double_click" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.DoubleClick,
                "file_upload" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.FileUpload,
                "find" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Find,
                "form_input" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.FormInput,
                "get_page_text" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.GetPageText,
                "hold_key" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.HoldKey,
                "hover" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Hover,
                "javascript_exec" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.JavascriptExec,
                "key" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Key,
                "left_click" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.LeftClick,
                "left_click_drag" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.LeftClickDrag,
                "left_mouse_down" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.LeftMouseDown,
                "left_mouse_up" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.LeftMouseUp,
                "list_tabs" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.ListTabs,
                "middle_click" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.MiddleClick,
                "mouse_move" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.MouseMove,
                "navigate" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Navigate,
                "new_tab" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.NewTab,
                "read_console" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.ReadConsole,
                "read_network" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.ReadNetwork,
                "read_page" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.ReadPage,
                "right_click" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.RightClick,
                "screenshot" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Screenshot,
                "scroll" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Scroll,
                "scroll_to" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.ScrollTo,
                "switch_tab" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.SwitchTab,
                "triple_click" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.TripleClick,
                "type" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Type,
                "wait" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Wait,
                "zoom" => BetaResponseBrowserToolUseBlockUnionDiscriminatorName.Zoom,
                _ => null,
            };
        }
    }
}