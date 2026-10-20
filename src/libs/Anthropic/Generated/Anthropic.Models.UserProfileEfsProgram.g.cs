
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A user profile's standing in Enterprise Frontier Safeguards, a program under which Anthropic approves the entity the profile represents and may approve any of the program's features.<br/>
    /// Example: {"status":"active","features":{"data_retention_exemption":{"status":"inactive"},"cmek":{"status":"active"},"storage":{"status":"inactive"}}}
    /// </summary>
    public sealed partial class UserProfileEfsProgram
    {
        /// <summary>
        /// Anthropic's decision on the entity the profile represents: `pending` while it is awaited, `active` once Anthropic has approved the entity for the program, or `rejected` once Anthropic has declined or has removed the entity from the program. `active` does not mean that any one feature is approved: read the feature you need in `features`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.UserProfileProgramStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.UserProfileProgramStatus Status { get; set; }

        /// <summary>
        /// The program's features, keyed by feature: `data_retention_exemption` (use of models that normally require data retention, without the data being retained), `cmek` (customer-managed encryption keys) and `storage` (customer-owned storage). Every feature that the caller's organization may read has a key, whether or not it is approved; a missing key does not mean that the feature is inactive. Anthropic may add features; ignore a key you do not recognize.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Anthropic.UserProfileEfsFeature> Features { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileEfsProgram" /> class.
        /// </summary>
        /// <param name="status">
        /// Anthropic's decision on the entity the profile represents: `pending` while it is awaited, `active` once Anthropic has approved the entity for the program, or `rejected` once Anthropic has declined or has removed the entity from the program. `active` does not mean that any one feature is approved: read the feature you need in `features`.
        /// </param>
        /// <param name="features">
        /// The program's features, keyed by feature: `data_retention_exemption` (use of models that normally require data retention, without the data being retained), `cmek` (customer-managed encryption keys) and `storage` (customer-owned storage). Every feature that the caller's organization may read has a key, whether or not it is approved; a missing key does not mean that the feature is inactive. Anthropic may add features; ignore a key you do not recognize.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserProfileEfsProgram(
            global::Anthropic.UserProfileProgramStatus status,
            global::System.Collections.Generic.Dictionary<string, global::Anthropic.UserProfileEfsFeature> features)
        {
            this.Status = status;
            this.Features = features ?? throw new global::System.ArgumentNullException(nameof(features));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileEfsProgram" /> class.
        /// </summary>
        public UserProfileEfsProgram()
        {
        }

    }
}