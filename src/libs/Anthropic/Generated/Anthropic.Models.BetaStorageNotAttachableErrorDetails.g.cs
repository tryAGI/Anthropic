
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// This External Storage can't be attached to the setting named in `field`. The error's `message` says why.
    /// </summary>
    public sealed partial class BetaStorageNotAttachableErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"storage_not_attachable"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "storage_not_attachable";

        /// <summary>
        /// The request field at fault.
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
        /// Initializes a new instance of the <see cref="BetaStorageNotAttachableErrorDetails" /> class.
        /// </summary>
        /// <param name="field">
        /// The request field at fault.
        /// </param>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaStorageNotAttachableErrorDetails(
            string field,
            string errorCode = "storage_not_attachable")
        {
            this.ErrorCode = errorCode;
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageNotAttachableErrorDetails" /> class.
        /// </summary>
        public BetaStorageNotAttachableErrorDetails()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaStorageNotAttachableErrorDetails"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaStorageNotAttachableErrorDetails FromField(string field)
        {
            return new BetaStorageNotAttachableErrorDetails
            {
                Field = field,
            };
        }

    }
}