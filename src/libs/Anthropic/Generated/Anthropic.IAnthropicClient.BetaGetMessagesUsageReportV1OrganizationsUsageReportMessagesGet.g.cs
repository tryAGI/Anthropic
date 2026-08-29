#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Get Messages Usage Report
        /// </summary>
        /// <param name="limit">
        /// Maximum number of time buckets to return in the response.<br/>
        /// The default and max limits depend on `bucket_width`:<br/>
        /// • `"1d"`: Default of 7 days, maximum of 31 days<br/>
        /// • `"1h"`: Default of 24 hours, maximum of 168 hours<br/>
        /// • `"1m"`: Default of 60 minutes, maximum of 1440 minutes
        /// </param>
        /// <param name="page">
        /// Optionally set to the `next_page` token from the previous response.
        /// </param>
        /// <param name="startingAt">
        /// Time buckets that start on or after this RFC 3339 timestamp will be returned.<br/>
        /// Each time bucket will be snapped to the start of the minute/hour/day in UTC.
        /// </param>
        /// <param name="endingAt">
        /// Time buckets that end before this RFC 3339 timestamp will be returned.
        /// </param>
        /// <param name="apiKeyIds">
        /// Restrict usage returned to the specified API key ID(s).
        /// </param>
        /// <param name="workspaceIds">
        /// Restrict usage returned to the specified workspace ID(s).
        /// </param>
        /// <param name="accountIds">
        /// Restrict usage returned to the specified user account ID(s).
        /// </param>
        /// <param name="serviceAccountIds">
        /// Restrict usage returned to the specified service account ID(s).
        /// </param>
        /// <param name="models">
        /// Restrict usage returned to the specified model(s).
        /// </param>
        /// <param name="serviceTiers">
        /// Restrict usage returned to the specified service tier(s).
        /// </param>
        /// <param name="contextWindow">
        /// Restrict usage returned to the specified context window(s).
        /// </param>
        /// <param name="inferenceGeos">
        /// Restrict usage returned to the specified inference geo(s). Use `not_available` for models that do not support specifying `inference_geo`.
        /// </param>
        /// <param name="speeds">
        /// Restrict usage returned to the specified speed(s) (Claude Code research preview).<br/>
        /// Requires the `fast-mode-2026-02-01` beta header.
        /// </param>
        /// <param name="groupBy">
        /// Group by any subset of the available options. Grouping by `speed` requires the `fast-mode-2026-02-01` beta header.
        /// </param>
        /// <param name="bucketWidth">
        /// Time granularity of the response data.<br/>
        /// Default Value: 1d
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="xApiKey">
        /// Your unique Admin API key for authentication. <br/>
        /// This key is required in the header of all Admin API requests, to authenticate your account and access Anthropic's services. Get your Admin API key through the [Console](https://console.anthropic.com/settings/admin-keys).
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaGetMessagesUsageReportResponse> BetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetAsync(
            global::System.DateTime startingAt,
            int? limit = default,
            string? page = default,
            global::System.DateTime? endingAt = default,
            global::System.Collections.Generic.IList<string>? apiKeyIds = default,
            global::System.Collections.Generic.IList<string>? workspaceIds = default,
            global::System.Collections.Generic.IList<string>? accountIds = default,
            global::System.Collections.Generic.IList<string>? serviceAccountIds = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaUsageReportServiceTier>? serviceTiers = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? contextWindow = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? inferenceGeos = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaSpeed>? speeds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportGroupBy>? groupBy = default,
            global::Anthropic.BetaMessagesUsageReportTimeBucketWidth? bucketWidth = default,
            string? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Messages Usage Report
        /// </summary>
        /// <param name="limit">
        /// Maximum number of time buckets to return in the response.<br/>
        /// The default and max limits depend on `bucket_width`:<br/>
        /// • `"1d"`: Default of 7 days, maximum of 31 days<br/>
        /// • `"1h"`: Default of 24 hours, maximum of 168 hours<br/>
        /// • `"1m"`: Default of 60 minutes, maximum of 1440 minutes
        /// </param>
        /// <param name="page">
        /// Optionally set to the `next_page` token from the previous response.
        /// </param>
        /// <param name="startingAt">
        /// Time buckets that start on or after this RFC 3339 timestamp will be returned.<br/>
        /// Each time bucket will be snapped to the start of the minute/hour/day in UTC.
        /// </param>
        /// <param name="endingAt">
        /// Time buckets that end before this RFC 3339 timestamp will be returned.
        /// </param>
        /// <param name="apiKeyIds">
        /// Restrict usage returned to the specified API key ID(s).
        /// </param>
        /// <param name="workspaceIds">
        /// Restrict usage returned to the specified workspace ID(s).
        /// </param>
        /// <param name="accountIds">
        /// Restrict usage returned to the specified user account ID(s).
        /// </param>
        /// <param name="serviceAccountIds">
        /// Restrict usage returned to the specified service account ID(s).
        /// </param>
        /// <param name="models">
        /// Restrict usage returned to the specified model(s).
        /// </param>
        /// <param name="serviceTiers">
        /// Restrict usage returned to the specified service tier(s).
        /// </param>
        /// <param name="contextWindow">
        /// Restrict usage returned to the specified context window(s).
        /// </param>
        /// <param name="inferenceGeos">
        /// Restrict usage returned to the specified inference geo(s). Use `not_available` for models that do not support specifying `inference_geo`.
        /// </param>
        /// <param name="speeds">
        /// Restrict usage returned to the specified speed(s) (Claude Code research preview).<br/>
        /// Requires the `fast-mode-2026-02-01` beta header.
        /// </param>
        /// <param name="groupBy">
        /// Group by any subset of the available options. Grouping by `speed` requires the `fast-mode-2026-02-01` beta header.
        /// </param>
        /// <param name="bucketWidth">
        /// Time granularity of the response data.<br/>
        /// Default Value: 1d
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="xApiKey">
        /// Your unique Admin API key for authentication. <br/>
        /// This key is required in the header of all Admin API requests, to authenticate your account and access Anthropic's services. Get your Admin API key through the [Console](https://console.anthropic.com/settings/admin-keys).
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaGetMessagesUsageReportResponse>> BetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetAsResponseAsync(
            global::System.DateTime startingAt,
            int? limit = default,
            string? page = default,
            global::System.DateTime? endingAt = default,
            global::System.Collections.Generic.IList<string>? apiKeyIds = default,
            global::System.Collections.Generic.IList<string>? workspaceIds = default,
            global::System.Collections.Generic.IList<string>? accountIds = default,
            global::System.Collections.Generic.IList<string>? serviceAccountIds = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaUsageReportServiceTier>? serviceTiers = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? contextWindow = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? inferenceGeos = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaSpeed>? speeds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportGroupBy>? groupBy = default,
            global::Anthropic.BetaMessagesUsageReportTimeBucketWidth? bucketWidth = default,
            string? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetAsync as an IAsyncEnumerable&lt;global::Anthropic.BetaMessagesUsageReportTimeBucket&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of time buckets to return in the response.<br/>
        /// The default and max limits depend on `bucket_width`:<br/>
        /// • `"1d"`: Default of 7 days, maximum of 31 days<br/>
        /// • `"1h"`: Default of 24 hours, maximum of 168 hours<br/>
        /// • `"1m"`: Default of 60 minutes, maximum of 1440 minutes
        /// </param>
        /// <param name="startingAt">
        /// Time buckets that start on or after this RFC 3339 timestamp will be returned.<br/>
        /// Each time bucket will be snapped to the start of the minute/hour/day in UTC.
        /// </param>
        /// <param name="endingAt">
        /// Time buckets that end before this RFC 3339 timestamp will be returned.
        /// </param>
        /// <param name="apiKeyIds">
        /// Restrict usage returned to the specified API key ID(s).
        /// </param>
        /// <param name="workspaceIds">
        /// Restrict usage returned to the specified workspace ID(s).
        /// </param>
        /// <param name="accountIds">
        /// Restrict usage returned to the specified user account ID(s).
        /// </param>
        /// <param name="serviceAccountIds">
        /// Restrict usage returned to the specified service account ID(s).
        /// </param>
        /// <param name="models">
        /// Restrict usage returned to the specified model(s).
        /// </param>
        /// <param name="serviceTiers">
        /// Restrict usage returned to the specified service tier(s).
        /// </param>
        /// <param name="contextWindow">
        /// Restrict usage returned to the specified context window(s).
        /// </param>
        /// <param name="inferenceGeos">
        /// Restrict usage returned to the specified inference geo(s). Use `not_available` for models that do not support specifying `inference_geo`.
        /// </param>
        /// <param name="speeds">
        /// Restrict usage returned to the specified speed(s) (Claude Code research preview).<br/>
        /// Requires the `fast-mode-2026-02-01` beta header.
        /// </param>
        /// <param name="groupBy">
        /// Group by any subset of the available options. Grouping by `speed` requires the `fast-mode-2026-02-01` beta header.
        /// </param>
        /// <param name="bucketWidth">
        /// Time granularity of the response data.<br/>
        /// Default Value: 1d
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.<br/>
        /// To use multiple betas, use a comma separated list like `beta1,beta2` or specify the header multiple times for each beta.
        /// </param>
        /// <param name="xApiKey">
        /// Your unique Admin API key for authentication. <br/>
        /// This key is required in the header of all Admin API requests, to authenticate your account and access Anthropic's services. Get your Admin API key through the [Console](https://console.anthropic.com/settings/admin-keys).
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="page">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Anthropic.BetaMessagesUsageReportTimeBucket> BetaGetMessagesUsageReportV1OrganizationsUsageReportMessagesGetAutoPagingAsync(
            global::System.DateTime startingAt,             int? limit = default,
            global::System.DateTime? endingAt = default,
            global::System.Collections.Generic.IList<string>? apiKeyIds = default,
            global::System.Collections.Generic.IList<string>? workspaceIds = default,
            global::System.Collections.Generic.IList<string>? accountIds = default,
            global::System.Collections.Generic.IList<string>? serviceAccountIds = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaUsageReportServiceTier>? serviceTiers = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportContextWindow>? contextWindow = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaInferenceGeoFilter>? inferenceGeos = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaSpeed>? speeds = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportGroupBy>? groupBy = default,
            global::Anthropic.BetaMessagesUsageReportTimeBucketWidth? bucketWidth = default,
            string? anthropicBeta = default,
            string? xApiKey = default,
            string? anthropicVersion = default,
            string? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}