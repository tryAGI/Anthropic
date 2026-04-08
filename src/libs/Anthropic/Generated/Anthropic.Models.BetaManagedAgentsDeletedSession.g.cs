
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Confirmation that a `session` has been permanently deleted.<br/>
    /// Example: {"type":"session_deleted","id":"sesn_011CZkZAtmR3yMPDzynEDxu7"}
    /// </summary>
    public sealed partial class BetaManagedAgentsDeletedSession
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeletedSessionTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsDeletedSessionType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDeletedSession" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsDeletedSession(
            string id,
            global::Anthropic.BetaManagedAgentsDeletedSessionType type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDeletedSession" /> class.
        /// </summary>
        public BetaManagedAgentsDeletedSession()
        {
        }
    }
}