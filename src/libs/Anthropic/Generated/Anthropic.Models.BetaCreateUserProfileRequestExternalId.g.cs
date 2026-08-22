
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Platform's own identifier for this user. Not enforced unique. Maximum 255 characters.
    /// </summary>
    public sealed partial class BetaCreateUserProfileRequestExternalId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}