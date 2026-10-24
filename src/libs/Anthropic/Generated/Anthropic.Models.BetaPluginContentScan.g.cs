
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaPluginContentScan
    {
        /// <summary>
        /// The scan's verdict; set only when `status` is `completed`. A `warn` can mean a `fail` that was allowed in claude.ai.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assessment")]
        public global::Anthropic.BetaPluginContentScanAssessment? Assessment { get; set; }

        /// <summary>
        /// The primary mechanism behind a `warn` or `fail`, such as `credential-exposure` or `guardrail-tampering`; a mechanism this API does not yet name reads as `other`. Null on a `pass`, whenever `assessment` is null, and when no mechanism is reported for the verdict.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// `processing` while a scan runs, `completed` when it ran to completion, `errored` when it could not run. Once a scan of the version has completed, `content_scan` describes the newest completed scan, even while a later scan runs. While the scan outcome cannot be read, `status` is `errored` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaPluginContentScanStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaPluginContentScanStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginContentScan" /> class.
        /// </summary>
        /// <param name="status">
        /// `processing` while a scan runs, `completed` when it ran to completion, `errored` when it could not run. Once a scan of the version has completed, `content_scan` describes the newest completed scan, even while a later scan runs. While the scan outcome cannot be read, `status` is `errored` instead.
        /// </param>
        /// <param name="assessment">
        /// The scan's verdict; set only when `status` is `completed`. A `warn` can mean a `fail` that was allowed in claude.ai.
        /// </param>
        /// <param name="reason">
        /// The primary mechanism behind a `warn` or `fail`, such as `credential-exposure` or `guardrail-tampering`; a mechanism this API does not yet name reads as `other`. Null on a `pass`, whenever `assessment` is null, and when no mechanism is reported for the verdict.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPluginContentScan(
            global::Anthropic.BetaPluginContentScanStatus status,
            global::Anthropic.BetaPluginContentScanAssessment? assessment,
            string? reason)
        {
            this.Assessment = assessment;
            this.Reason = reason;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginContentScan" /> class.
        /// </summary>
        public BetaPluginContentScan()
        {
        }

    }
}