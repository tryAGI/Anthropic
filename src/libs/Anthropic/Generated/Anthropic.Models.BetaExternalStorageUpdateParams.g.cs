
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaExternalStorageUpdateParams
    {
        /// <summary>
        /// Human-friendly display name; null clears it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalStorageUpdateParams" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Human-friendly display name; null clears it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaExternalStorageUpdateParams(
            string? displayName)
        {
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalStorageUpdateParams" /> class.
        /// </summary>
        public BetaExternalStorageUpdateParams()
        {
        }

    }
}