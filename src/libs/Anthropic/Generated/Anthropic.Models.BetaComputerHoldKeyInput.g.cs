
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Hold down a key or key-combination for a specified duration. Uses the same key<br/>
    /// syntax as `key`.
    /// </summary>
    public sealed partial class BetaComputerHoldKeyInput
    {
        /// <summary>
        /// Duration to hold the key, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Duration { get; set; }

        /// <summary>
        /// The key or key-combination to hold.
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
        /// Initializes a new instance of the <see cref="BetaComputerHoldKeyInput" /> class.
        /// </summary>
        /// <param name="duration">
        /// Duration to hold the key, in seconds.
        /// </param>
        /// <param name="text">
        /// The key or key-combination to hold.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComputerHoldKeyInput(
            int duration,
            string text)
        {
            this.Duration = duration;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerHoldKeyInput" /> class.
        /// </summary>
        public BetaComputerHoldKeyInput()
        {
        }

    }
}