
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The organization already has External Storage for this bucket that it has not deleted. List the organization's External Storage to find it.
    /// </summary>
    public sealed partial class BetaStorageAlreadyRegisteredErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"storage_already_registered"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "storage_already_registered";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageAlreadyRegisteredErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaStorageAlreadyRegisteredErrorDetails(
            string errorCode = "storage_already_registered")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageAlreadyRegisteredErrorDetails" /> class.
        /// </summary>
        public BetaStorageAlreadyRegisteredErrorDetails()
        {
        }

    }
}