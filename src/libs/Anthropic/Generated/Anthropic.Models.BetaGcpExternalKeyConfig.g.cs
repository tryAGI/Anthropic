
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaGcpExternalKeyConfig
    {
        /// <summary>
        /// Full resource name of the Cloud KMS key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyName { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaGcpExternalKeyConfig" /> class.
        /// </summary>
        /// <param name="keyName">
        /// Full resource name of the Cloud KMS key.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGcpExternalKeyConfig(
            string keyName,
            string type = "gcp")
        {
            this.KeyName = keyName ?? throw new global::System.ArgumentNullException(nameof(keyName));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGcpExternalKeyConfig" /> class.
        /// </summary>
        public BetaGcpExternalKeyConfig()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaGcpExternalKeyConfig"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaGcpExternalKeyConfig FromKeyName(string keyName)
        {
            return new BetaGcpExternalKeyConfig
            {
                KeyName = keyName,
            };
        }

    }
}