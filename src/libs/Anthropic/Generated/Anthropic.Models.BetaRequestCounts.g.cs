
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRequestCounts
    {
        /// <summary>
        /// Number of requests in the Message Batch that have been canceled.<br/>
        /// This is zero until processing of the entire Message Batch has ended.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Canceled { get; set; } = default!;

        /// <summary>
        /// Number of requests in the Message Batch that encountered an error.<br/>
        /// This is zero until processing of the entire Message Batch has ended.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errored")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Errored { get; set; } = default!;

        /// <summary>
        /// Number of requests in the Message Batch that have expired.<br/>
        /// This is zero until processing of the entire Message Batch has ended.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Expired { get; set; } = default!;

        /// <summary>
        /// Number of requests in the Message Batch that are processing.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Processing { get; set; } = default!;

        /// <summary>
        /// Number of requests in the Message Batch that have completed successfully.<br/>
        /// This is zero until processing of the entire Message Batch has ended.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeeded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Succeeded { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestCounts" /> class.
        /// </summary>
        /// <param name="canceled">
        /// Number of requests in the Message Batch that have been canceled.<br/>
        /// This is zero until processing of the entire Message Batch has ended.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="errored">
        /// Number of requests in the Message Batch that encountered an error.<br/>
        /// This is zero until processing of the entire Message Batch has ended.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="expired">
        /// Number of requests in the Message Batch that have expired.<br/>
        /// This is zero until processing of the entire Message Batch has ended.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="processing">
        /// Number of requests in the Message Batch that are processing.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="succeeded">
        /// Number of requests in the Message Batch that have completed successfully.<br/>
        /// This is zero until processing of the entire Message Batch has ended.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestCounts(
            int canceled,
            int errored,
            int expired,
            int processing,
            int succeeded)
        {
            this.Canceled = canceled;
            this.Errored = errored;
            this.Expired = expired;
            this.Processing = processing;
            this.Succeeded = succeeded;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestCounts" /> class.
        /// </summary>
        public BetaRequestCounts()
        {
        }
    }
}