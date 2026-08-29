
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Response after deleting an environment.<br/>
    /// Example: {"type":"environment_deleted","id":"env_011CZkZ9X2dpNyB7HsEFoRfW"}
    /// </summary>
    public sealed partial class BetaEnvironmentDeleteResponse
    {
        /// <summary>
        /// Environment identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of response<br/>
        /// Default Value: environment_deleted
        /// </summary>
        /// <default>global::Anthropic.BetaEnvironmentDeleteResponseType.EnvironmentDeleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaEnvironmentDeleteResponseTypeJsonConverter))]
        public global::Anthropic.BetaEnvironmentDeleteResponseType Type { get; set; } = global::Anthropic.BetaEnvironmentDeleteResponseType.EnvironmentDeleted;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaEnvironmentDeleteResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Environment identifier
        /// </param>
        /// <param name="type">
        /// The type of response<br/>
        /// Default Value: environment_deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaEnvironmentDeleteResponse(
            string id,
            global::Anthropic.BetaEnvironmentDeleteResponseType type = global::Anthropic.BetaEnvironmentDeleteResponseType.EnvironmentDeleted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaEnvironmentDeleteResponse" /> class.
        /// </summary>
        public BetaEnvironmentDeleteResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaEnvironmentDeleteResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaEnvironmentDeleteResponse FromId(string id)
        {
            return new BetaEnvironmentDeleteResponse
            {
                Id = id,
            };
        }

    }
}