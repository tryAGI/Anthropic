
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Press a key or key-combination on the keyboard. Use "+" to combine modifiers with<br/>
    /// a key (e.g. "ctrl+s", "alt+Tab", "ctrl+shift+Escape"). Key names are<br/>
    /// case-insensitive; common names like "Return", "Tab", "Escape", "Up", "Down",<br/>
    /// "Left", "Right", "Home", "End", "Page_Up", "Page_Down", "Delete", "BackSpace" are<br/>
    /// supported.
    /// </summary>
    public sealed partial class ComputerKeyInput
    {
        /// <summary>
        /// Number of times to repeat the key press. Default is 1.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repeat")]
        public int? Repeat { get; set; }

        /// <summary>
        /// The key or key-combination to press.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerKeyInput" /> class.
        /// </summary>
        /// <param name="text">
        /// The key or key-combination to press.
        /// </param>
        /// <param name="repeat">
        /// Number of times to repeat the key press. Default is 1.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerKeyInput(
            string text,
            int? repeat)
        {
            this.Repeat = repeat;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerKeyInput" /> class.
        /// </summary>
        public ComputerKeyInput()
        {
        }

    }
}