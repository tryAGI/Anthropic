
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
        /// <default>"session_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "session_deleted";

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
            string type = "session_deleted")
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

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsDeletedSession"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsDeletedSession FromId(string id)
        {
            return new BetaManagedAgentsDeletedSession
            {
                Id = id,
            };
        }

    }
}