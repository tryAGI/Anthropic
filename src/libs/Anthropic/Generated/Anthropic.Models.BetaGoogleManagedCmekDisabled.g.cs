
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The control is off and has no keys.
    /// </summary>
    public sealed partial class BetaGoogleManagedCmekDisabled
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"disabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "disabled";

        /// <summary>
        /// Keys that a region has retired, earliest `expires_at` first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retired_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaGoogleManagedRetiredKey> RetiredKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedCmekDisabled" /> class.
        /// </summary>
        /// <param name="retiredKeys">
        /// Keys that a region has retired, earliest `expires_at` first.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGoogleManagedCmekDisabled(
            global::System.Collections.Generic.IList<global::Anthropic.BetaGoogleManagedRetiredKey> retiredKeys,
            string type = "disabled")
        {
            this.Type = type;
            this.RetiredKeys = retiredKeys ?? throw new global::System.ArgumentNullException(nameof(retiredKeys));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedCmekDisabled" /> class.
        /// </summary>
        public BetaGoogleManagedCmekDisabled()
        {
        }

    }
}