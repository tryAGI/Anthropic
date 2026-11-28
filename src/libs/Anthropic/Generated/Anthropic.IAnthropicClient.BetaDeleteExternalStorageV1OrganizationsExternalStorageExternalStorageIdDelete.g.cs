#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Delete External Storage<br/>
        /// Delete External Storage. Storage that is pending configuration, available, or active<br/>
        /// but never attached is deleted at once, unless an Enterprise Frontier Safeguards workspace<br/>
        /// policy lists it. Other storage gets a 400 that says what to do next. On `draining`<br/>
        /// storage that 400 can mean this delete started a removal that can't be undone. To check,<br/>
        /// get the storage: if `status.removal_started` is true, delete it again later to finish.
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
        global::System.Threading.Tasks.Task<global::Anthropic.BetaExternalStorageDeletedResponse> BetaDeleteExternalStorageV1OrganizationsExternalStorageExternalStorageIdDeleteAsync(
            string externalStorageId,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete External Storage<br/>
        /// Delete External Storage. Storage that is pending configuration, available, or active<br/>
        /// but never attached is deleted at once, unless an Enterprise Frontier Safeguards workspace<br/>
        /// policy lists it. Other storage gets a 400 that says what to do next. On `draining`<br/>
        /// storage that 400 can mean this delete started a removal that can't be undone. To check,<br/>
        /// get the storage: if `status.removal_started` is true, delete it again later to finish.
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
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaExternalStorageDeletedResponse>> BetaDeleteExternalStorageV1OrganizationsExternalStorageExternalStorageIdDeleteAsResponseAsync(
            string externalStorageId,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta> anthropicBeta,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}