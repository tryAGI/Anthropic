
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Packages (and their versions) available in this environment.
    /// </summary>
    public sealed partial class BetaPackages
    {
        /// <summary>
        /// Ubuntu/Debian packages to install
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Apt { get; set; }

        /// <summary>
        /// Rust packages to install
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cargo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Cargo { get; set; }

        /// <summary>
        /// Ruby packages to install
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gem")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Gem { get; set; }

        /// <summary>
        /// Go packages to install
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("go")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Go { get; set; }

        /// <summary>
        /// Node.js packages to install
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("npm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Npm { get; set; }

        /// <summary>
        /// Python packages to install
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Pip { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaPackages" /> class.
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
        public BetaPackages(
            global::System.Collections.Generic.IList<string> apt,
            global::System.Collections.Generic.IList<string> cargo,
            global::System.Collections.Generic.IList<string> gem,
            global::System.Collections.Generic.IList<string> go,
            global::System.Collections.Generic.IList<string> npm,
            global::System.Collections.Generic.IList<string> pip,
            string? type)
        {
            this.Apt = apt ?? throw new global::System.ArgumentNullException(nameof(apt));
            this.Cargo = cargo ?? throw new global::System.ArgumentNullException(nameof(cargo));
            this.Gem = gem ?? throw new global::System.ArgumentNullException(nameof(gem));
            this.Go = go ?? throw new global::System.ArgumentNullException(nameof(go));
            this.Npm = npm ?? throw new global::System.ArgumentNullException(nameof(npm));
            this.Pip = pip ?? throw new global::System.ArgumentNullException(nameof(pip));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPackages" /> class.
        /// </summary>
        public BetaPackages()
        {
        }
    }
}