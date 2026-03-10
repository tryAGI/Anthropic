
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingError
    {
        /// <summary>
        /// Default Value: Billing error
        /// </summary>
        /// <default>"Billing error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; } = "Billing error";

        /// <summary>
        /// Default Value: billing_error
        /// </summary>
        /// <default>"billing_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "billing_error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingError" /> class.
        /// </summary>
        /// <param name="message">
        /// Default Value: Billing error
        /// </param>
        /// <param name="type">
        /// Default Value: billing_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingError(
            string message,
            string type = "billing_error")
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingError" /> class.
        /// </summary>
        public BillingError()
        {
        }
    }
}