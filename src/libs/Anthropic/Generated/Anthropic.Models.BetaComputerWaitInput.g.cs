
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Wait for a specified duration.
    /// </summary>
    public sealed partial class BetaComputerWaitInput
    {
        /// <summary>
        /// Duration to wait, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerWaitInput" /> class.
        /// </summary>
        /// <param name="duration">
        /// Duration to wait, in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComputerWaitInput(
            int duration)
        {
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerWaitInput" /> class.
        /// </summary>
        public BetaComputerWaitInput()
        {
        }

    }
}