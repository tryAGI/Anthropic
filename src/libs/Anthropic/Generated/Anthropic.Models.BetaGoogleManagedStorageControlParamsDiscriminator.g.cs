
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaGoogleManagedStorageControlParamsDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaGoogleManagedStorageControlParamsDiscriminatorTypeJsonConverter))]
        public global::Anthropic.BetaGoogleManagedStorageControlParamsDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedStorageControlParamsDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGoogleManagedStorageControlParamsDiscriminator(
            global::Anthropic.BetaGoogleManagedStorageControlParamsDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedStorageControlParamsDiscriminator" /> class.
        /// </summary>
        public BetaGoogleManagedStorageControlParamsDiscriminator()
        {
        }

    }
}