
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaMessageDelta
    {
        /// <summary>
        /// Information about the container used in the request (for the code execution tool)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaContainer Container { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaStopReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaStopReason StopReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? StopSequence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessageDelta" /> class.
        /// </summary>
        /// <param name="container">
        /// Information about the container used in the request (for the code execution tool)
        /// </param>
        /// <param name="stopReason"></param>
        /// <param name="stopSequence"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMessageDelta(
            global::Anthropic.BetaContainer container,
            global::Anthropic.BetaStopReason stopReason,
            string? stopSequence)
        {
            this.Container = container ?? throw new global::System.ArgumentNullException(nameof(container));
            this.StopReason = stopReason;
            this.StopSequence = stopSequence ?? throw new global::System.ArgumentNullException(nameof(stopSequence));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessageDelta" /> class.
        /// </summary>
        public BetaMessageDelta()
        {
        }
    }
}