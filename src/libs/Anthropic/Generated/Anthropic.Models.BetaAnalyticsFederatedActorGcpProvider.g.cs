
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAnalyticsFederatedActorGcpProvider
    {
        /// <summary>
        /// The Google Cloud project the organization is bound to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"gcp"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "gcp";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsFederatedActorGcpProvider" /> class.
        /// </summary>
        /// <param name="projectNumber">
        /// The Google Cloud project the organization is bound to.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsFederatedActorGcpProvider(
            string projectNumber,
            string type = "gcp")
        {
            this.ProjectNumber = projectNumber ?? throw new global::System.ArgumentNullException(nameof(projectNumber));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsFederatedActorGcpProvider" /> class.
        /// </summary>
        public BetaAnalyticsFederatedActorGcpProvider()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaAnalyticsFederatedActorGcpProvider"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaAnalyticsFederatedActorGcpProvider FromProjectNumber(string projectNumber)
        {
            return new BetaAnalyticsFederatedActorGcpProvider
            {
                ProjectNumber = projectNumber,
            };
        }

    }
}