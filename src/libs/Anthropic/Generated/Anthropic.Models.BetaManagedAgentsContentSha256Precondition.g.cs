
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaManagedAgentsContentSha256Precondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsContentSha256PreconditionTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsContentSha256PreconditionType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_sha256")]
        public string? ContentSha256 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsContentSha256Precondition" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="contentSha256"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsContentSha256Precondition(
            global::Anthropic.BetaManagedAgentsContentSha256PreconditionType type,
            string? contentSha256)
        {
            this.Type = type;
            this.ContentSha256 = contentSha256;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsContentSha256Precondition" /> class.
        /// </summary>
        public BetaManagedAgentsContentSha256Precondition()
        {
        }
    }
}