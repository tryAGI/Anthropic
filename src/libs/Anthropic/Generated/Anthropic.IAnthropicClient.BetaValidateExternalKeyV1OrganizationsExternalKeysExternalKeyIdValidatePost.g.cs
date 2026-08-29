#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Validate External Key<br/>
        /// Validate an external key config against the customer's KMS.<br/>
        /// Anthropic performs an encrypt/decrypt roundtrip against the configured<br/>
        /// KMS key and waits up to 30 seconds for the result. The response status is<br/>
        /// `success` if the roundtrip succeeded, or `failure` with an error<br/>
        /// message if it failed or timed out.
        /// </summary>
        /// <param name="externalKeyId">
        /// ID of the External Key.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaValidateExternalKeyResponse> BetaValidateExternalKeyV1OrganizationsExternalKeysExternalKeyIdValidatePostAsync(
            string externalKeyId,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate External Key<br/>
        /// Validate an external key config against the customer's KMS.<br/>
        /// Anthropic performs an encrypt/decrypt roundtrip against the configured<br/>
        /// KMS key and waits up to 30 seconds for the result. The response status is<br/>
        /// `success` if the roundtrip succeeded, or `failure` with an error<br/>
        /// message if it failed or timed out.
        /// </summary>
        /// <param name="externalKeyId">
        /// ID of the External Key.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaValidateExternalKeyResponse>> BetaValidateExternalKeyV1OrganizationsExternalKeysExternalKeyIdValidatePostAsResponseAsync(
            string externalKeyId,
            string? anthropicVersion = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}