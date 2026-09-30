
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostRequest
    {
        /// <summary>
        /// A .zip of the marketplace directory (its contents at the root, or wrapped in one folder as a Git host's download produces), sent as a file part with a filename; DEFLATE- or STORE-compressed, at most 32 MB. A part sent without a filename, a second archive part, or any other form field is a 400; a larger archive is a 413.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Archive { get; set; }

        /// <summary>
        /// A .zip of the marketplace directory (its contents at the root, or wrapped in one folder as a Git host's download produces), sent as a file part with a filename; DEFLATE- or STORE-compressed, at most 32 MB. A part sent without a filename, a second archive part, or any other form field is a 400; a larger archive is a 413.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archivename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Archivename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostRequest" /> class.
        /// </summary>
        /// <param name="archive">
        /// A .zip of the marketplace directory (its contents at the root, or wrapped in one folder as a Git host's download produces), sent as a file part with a filename; DEFLATE- or STORE-compressed, at most 32 MB. A part sent without a filename, a second archive part, or any other form field is a 400; a larger archive is a 413.
        /// </param>
        /// <param name="archivename">
        /// A .zip of the marketplace directory (its contents at the root, or wrapped in one folder as a Git host's download produces), sent as a file part with a filename; DEFLATE- or STORE-compressed, at most 32 MB. A part sent without a filename, a second archive part, or any other form field is a 400; a larger archive is a 413.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostRequest(
            byte[] archive,
            string archivename)
        {
            this.Archive = archive ?? throw new global::System.ArgumentNullException(nameof(archive));
            this.Archivename = archivename ?? throw new global::System.ArgumentNullException(nameof(archivename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostRequest" /> class.
        /// </summary>
        public BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostRequest()
        {
        }

    }
}