
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An element on the page, identified by a reference from a prior `read_page` or<br/>
    /// `find` result. References are scoped to the tab that produced them and become<br/>
    /// stale after navigation or a major re-render.
    /// </summary>
    public sealed partial class BrowserRefTarget
    {
        /// <summary>
        /// An element reference (e.g. "ref_7") returned by a prior `read_page` or `find` result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"ref"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "ref";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserRefTarget" /> class.
        /// </summary>
        /// <param name="ref">
        /// An element reference (e.g. "ref_7") returned by a prior `read_page` or `find` result.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BrowserRefTarget(
            string @ref,
            string type = "ref")
        {
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserRefTarget" /> class.
        /// </summary>
        public BrowserRefTarget()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BrowserRefTarget"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BrowserRefTarget FromRef(string @ref)
        {
            return new BrowserRefTarget
            {
                Ref = @ref,
            };
        }

    }
}