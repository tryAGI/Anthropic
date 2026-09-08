
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaDenySpendLimitIncreaseRequestParams
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suppress_notification")]
        public bool? SuppressNotification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDenySpendLimitIncreaseRequestParams" /> class.
        /// </summary>
        /// <param name="suppressNotification"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDenySpendLimitIncreaseRequestParams(
            bool? suppressNotification)
        {
            this.SuppressNotification = suppressNotification;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDenySpendLimitIncreaseRequestParams" /> class.
        /// </summary>
        public BetaDenySpendLimitIncreaseRequestParams()
        {
        }

    }
}