
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Names one tool in an only or except list.
    /// </summary>
    public sealed partial class BetaManagedAgentsWebFetchUrlSourceToolReference
    {
        /// <summary>
        /// Must be "tool_reference".
        /// </summary>
        /// <default>"tool_reference"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tool_reference";

        /// <summary>
        /// Name of the tool. Compared exactly, so upper and lower case letters are different.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWebFetchUrlSourceToolReference" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the tool. Compared exactly, so upper and lower case letters are different.
        /// </param>
        /// <param name="type">
        /// Must be "tool_reference".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsWebFetchUrlSourceToolReference(
            string name,
            string type = "tool_reference")
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWebFetchUrlSourceToolReference" /> class.
        /// </summary>
        public BetaManagedAgentsWebFetchUrlSourceToolReference()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsWebFetchUrlSourceToolReference"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsWebFetchUrlSourceToolReference FromName(string name)
        {
            return new BetaManagedAgentsWebFetchUrlSourceToolReference
            {
                Name = name,
            };
        }

    }
}