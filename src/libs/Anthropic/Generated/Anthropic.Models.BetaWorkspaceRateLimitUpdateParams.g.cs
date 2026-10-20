
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaWorkspaceRateLimitUpdateParams
    {
        /// <summary>
        /// Limits to set or clear. Unspecified limit types are unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceRateLimitUpdateValue> Limits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspaceRateLimitUpdateParams" /> class.
        /// </summary>
        /// <param name="limits">
        /// Limits to set or clear. Unspecified limit types are unchanged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWorkspaceRateLimitUpdateParams(
            global::System.Collections.Generic.IList<global::Anthropic.BetaWorkspaceRateLimitUpdateValue> limits)
        {
            this.Limits = limits ?? throw new global::System.ArgumentNullException(nameof(limits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspaceRateLimitUpdateParams" /> class.
        /// </summary>
        public BetaWorkspaceRateLimitUpdateParams()
        {
        }

    }
}