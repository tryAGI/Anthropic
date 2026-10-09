
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaGetSkillV1SkillsSkillIdGetResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaGetSkillV1SkillsSkillIdGetResponseError Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Default Value: error
        /// </summary>
        /// <default>"error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGetSkillV1SkillsSkillIdGetResponse" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="requestId"></param>
        /// <param name="type">
        /// Default Value: error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGetSkillV1SkillsSkillIdGetResponse(
            global::Anthropic.BetaGetSkillV1SkillsSkillIdGetResponseError error,
            string? requestId,
            string type = "error")
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.RequestId = requestId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGetSkillV1SkillsSkillIdGetResponse" /> class.
        /// </summary>
        public BetaGetSkillV1SkillsSkillIdGetResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaGetSkillV1SkillsSkillIdGetResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaGetSkillV1SkillsSkillIdGetResponse FromError(global::Anthropic.BetaGetSkillV1SkillsSkillIdGetResponseError error)
        {
            return new BetaGetSkillV1SkillsSkillIdGetResponse
            {
                Error = error,
            };
        }

    }
}