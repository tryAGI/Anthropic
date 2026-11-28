
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Another request changed this storage setting while this one was running, so this request left it as it is. Read the Workspace and send the request again if you still want the change.
    /// </summary>
    public sealed partial class BetaStorageChangedConcurrentlyErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"storage_changed_concurrently"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "storage_changed_concurrently";

        /// <summary>
        /// The storage setting that changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageChangedConcurrentlyErrorDetails" /> class.
        /// </summary>
        /// <param name="field">
        /// The storage setting that changed.
        /// </param>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaStorageChangedConcurrentlyErrorDetails(
            string field,
            string errorCode = "storage_changed_concurrently")
        {
            this.ErrorCode = errorCode;
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageChangedConcurrentlyErrorDetails" /> class.
        /// </summary>
        public BetaStorageChangedConcurrentlyErrorDetails()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaStorageChangedConcurrentlyErrorDetails"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaStorageChangedConcurrentlyErrorDetails FromField(string field)
        {
            return new BetaStorageChangedConcurrentlyErrorDetails
            {
                Field = field,
            };
        }

    }
}