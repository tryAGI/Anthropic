
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The Workspace has reached its limit of 100 different External Storage resources attached over its lifetime. Detached storage counts toward the limit until it is deleted.
    /// </summary>
    public sealed partial class BetaStorageAttachLimitReachedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"storage_attach_limit_reached"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "storage_attach_limit_reached";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageAttachLimitReachedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaStorageAttachLimitReachedErrorDetails(
            string errorCode = "storage_attach_limit_reached")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageAttachLimitReachedErrorDetails" /> class.
        /// </summary>
        public BetaStorageAttachLimitReachedErrorDetails()
        {
        }

    }
}