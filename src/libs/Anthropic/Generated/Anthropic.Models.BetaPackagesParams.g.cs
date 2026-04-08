
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Specify packages (and optionally their versions) available in this environment.<br/>
    /// When versioning, use the version semantics relevant for the package manager, e.g. for `pip` use `package==1.0.0`. You are responsible for validating the package and version exist. Unversioned installs the latest.
    /// </summary>
    public sealed partial class BetaPackagesParams
    {
        /// <summary>
        /// Ubuntu/Debian packages to install
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apt")]
        public global::System.Collections.Generic.IList<string>? Apt { get; set; }

        /// <summary>
        /// Rust packages to install
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cargo")]
        public global::System.Collections.Generic.IList<string>? Cargo { get; set; }

        /// <summary>
        /// Ruby packages to install
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gem")]
        public global::System.Collections.Generic.IList<string>? Gem { get; set; }

        /// <summary>
        /// Go packages to install
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("go")]
        public global::System.Collections.Generic.IList<string>? Go { get; set; }

        /// <summary>
        /// Node.js packages to install
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("npm")]
        public global::System.Collections.Generic.IList<string>? Npm { get; set; }

        /// <summary>
        /// Python packages to install
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pip")]
        public global::System.Collections.Generic.IList<string>? Pip { get; set; }

        /// <summary>
        /// Package configuration type<br/>
        /// Default Value: packages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPackagesParams" /> class.
        /// </summary>
        /// <param name="apt">
        /// Ubuntu/Debian packages to install
        /// </param>
        /// <param name="cargo">
        /// Rust packages to install
        /// </param>
        /// <param name="gem">
        /// Ruby packages to install
        /// </param>
        /// <param name="go">
        /// Go packages to install
        /// </param>
        /// <param name="npm">
        /// Node.js packages to install
        /// </param>
        /// <param name="pip">
        /// Python packages to install
        /// </param>
        /// <param name="type">
        /// Package configuration type<br/>
        /// Default Value: packages
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPackagesParams(
            global::System.Collections.Generic.IList<string>? apt,
            global::System.Collections.Generic.IList<string>? cargo,
            global::System.Collections.Generic.IList<string>? gem,
            global::System.Collections.Generic.IList<string>? go,
            global::System.Collections.Generic.IList<string>? npm,
            global::System.Collections.Generic.IList<string>? pip,
            string? type)
        {
            this.Apt = apt;
            this.Cargo = cargo;
            this.Gem = gem;
            this.Go = go;
            this.Npm = npm;
            this.Pip = pip;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPackagesParams" /> class.
        /// </summary>
        public BetaPackagesParams()
        {
        }
    }
}