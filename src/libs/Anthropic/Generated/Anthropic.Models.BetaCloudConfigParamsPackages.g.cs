
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Package manager configuration. Under `limited` networking, requires `networking.allow_package_managers` to be `true`. Omit on update to preserve the existing value.
    /// </summary>
    public sealed partial class BetaCloudConfigParamsPackages
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}