
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Request headers that the API sends with every delivery, typically your collector's authentication header (for example `authorization`).<br/>
    /// The API stores the values encrypted and never returns them. Reads show only `header_names`.<br/>
    /// At most 20 headers. Names are at most 128 characters. Two names can't differ only in case. Values are printable ASCII, at most 4,096 characters, and can't begin or end with a space. Names and values together are at most 16,384 bytes.<br/>
    /// Reserved names are rejected, for example `host`, `cookie`, `user-agent`, and names that start with `content-`, `proxy-`, `x-forwarded-`, or `anthropic-`. For this check, `_` in a name counts as `-`.
    /// </summary>
    public sealed partial class BetaCreateTelemetryDestinationRequestHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}