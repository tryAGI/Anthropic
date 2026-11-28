#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Activate External Storage<br/>
        /// Verify pending External Storage and make it available. Storage that is<br/>
        /// already available, active or draining comes back unchanged, without any<br/>
        /// check.
        /// </summary>
        /// <param name="externalStorageId">
        /// The External Storage ID, which starts with `estrg_`. Through Claude Platform on AWS, storage whose `provider_config.type` is `aws` has its bucket ARN as its ID instead: `arn:&lt;partition&gt;:s3:::&lt;bucket_name&gt;`, where `&lt;partition&gt;` is the partition of the bucket's region.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `efs-2026-10-01` in this header.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaExternalStorage> BetaActivateExternalStorageV1OrganizationsExternalStorageExternalStorageIdActivatePostAsync(
            string externalStorageId,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Activate External Storage<br/>
        /// Verify pending External Storage and make it available. Storage that is<br/>
        /// already available, active or draining comes back unchanged, without any<br/>
        /// check.
        /// </summary>
        /// <param name="externalStorageId">
        /// The External Storage ID, which starts with `estrg_`. Through Claude Platform on AWS, storage whose `provider_config.type` is `aws` has its bucket ARN as its ID instead: `arn:&lt;partition&gt;:s3:::&lt;bucket_name&gt;`, where `&lt;partition&gt;` is the partition of the bucket's region.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// This endpoint is in beta: requests must send `efs-2026-10-01` in this header.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaExternalStorage>> BetaActivateExternalStorageV1OrganizationsExternalStorageExternalStorageIdActivatePostAsResponseAsync(
            string externalStorageId,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}