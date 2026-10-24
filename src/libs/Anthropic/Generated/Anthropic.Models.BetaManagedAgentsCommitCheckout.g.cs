
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaManagedAgentsCommitCheckout
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"commit"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "commit";

        /// <summary>
        /// Full commit SHA to check out.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCommitCheckout" /> class.
        /// </summary>
        /// <param name="sha">
        /// Full commit SHA to check out.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsCommitCheckout(
            string sha,
            string type = "commit")
        {
            this.Type = type;
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCommitCheckout" /> class.
        /// </summary>
        public BetaManagedAgentsCommitCheckout()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsCommitCheckout"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsCommitCheckout FromSha(string sha)
        {
            return new BetaManagedAgentsCommitCheckout
            {
                Sha = sha,
            };
        }

    }
}