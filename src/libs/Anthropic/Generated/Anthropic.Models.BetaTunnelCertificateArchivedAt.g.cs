
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// RFC 3339 datetime string indicating when the certificate was archived. Null if it is still in the trusted set.
    /// </summary>
    public sealed partial class BetaTunnelCertificateArchivedAt
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}