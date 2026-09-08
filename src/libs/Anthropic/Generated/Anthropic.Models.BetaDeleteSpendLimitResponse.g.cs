
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaDeleteSpendLimitResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: spend_limit_deleted
        /// </summary>
        /// <default>"spend_limit_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "spend_limit_deleted";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeleteSpendLimitResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type">
        /// Default Value: spend_limit_deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDeleteSpendLimitResponse(
            string id,
            string type = "spend_limit_deleted")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeleteSpendLimitResponse" /> class.
        /// </summary>
        public BetaDeleteSpendLimitResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaDeleteSpendLimitResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaDeleteSpendLimitResponse FromId(string id)
        {
            return new BetaDeleteSpendLimitResponse
            {
                Id = id,
            };
        }

    }
}