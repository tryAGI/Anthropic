
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A vault referenced by the deployment no longer exists.
    /// </summary>
    public sealed partial class BetaManagedAgentsVaultNotFoundRunError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsVaultNotFoundRunErrorTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsVaultNotFoundRunErrorType Type { get; set; }

        /// <summary>
        /// Human-readable error description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsVaultNotFoundRunError" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable error description.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsVaultNotFoundRunError(
            string message,
            global::Anthropic.BetaManagedAgentsVaultNotFoundRunErrorType type)
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsVaultNotFoundRunError" /> class.
        /// </summary>
        public BetaManagedAgentsVaultNotFoundRunError()
        {
        }

    }
}