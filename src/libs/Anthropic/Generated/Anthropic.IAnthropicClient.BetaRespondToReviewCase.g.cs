#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Respond to Review Case<br/>
        /// Send your conclusion on a review case. A response closes the case, and a closed case can't be reopened.<br/>
        /// Only the first response counts. A request is safe to send again: if the closed case has a response with the same field values, in any list order, the API returns 200 and changes nothing. If the closed case has a different response, or none, the API returns a 400 with `case_closed` in `error.details.error_code`.<br/>
        /// If your end customer reviews this case instead of you, the API returns a 403 with `case_reviewed_by_end_customer` in `error.details.error_code`.<br/>
        /// An Admin API key with the `write:compliance_review_cases` scope can call this endpoint.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="caseId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaComplianceReviewCase> BetaRespondToReviewCaseAsync(
            string caseId,

            global::Anthropic.BetaRespondToReviewCaseRequestBody request,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Respond to Review Case<br/>
        /// Send your conclusion on a review case. A response closes the case, and a closed case can't be reopened.<br/>
        /// Only the first response counts. A request is safe to send again: if the closed case has a response with the same field values, in any list order, the API returns 200 and changes nothing. If the closed case has a different response, or none, the API returns a 400 with `case_closed` in `error.details.error_code`.<br/>
        /// If your end customer reviews this case instead of you, the API returns a 403 with `case_reviewed_by_end_customer` in `error.details.error_code`.<br/>
        /// An Admin API key with the `write:compliance_review_cases` scope can call this endpoint.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="caseId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaComplianceReviewCase>> BetaRespondToReviewCaseAsResponseAsync(
            string caseId,

            global::Anthropic.BetaRespondToReviewCaseRequestBody request,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Respond to Review Case<br/>
        /// Send your conclusion on a review case. A response closes the case, and a closed case can't be reopened.<br/>
        /// Only the first response counts. A request is safe to send again: if the closed case has a response with the same field values, in any list order, the API returns 200 and changes nothing. If the closed case has a different response, or none, the API returns a 400 with `case_closed` in `error.details.error_code`.<br/>
        /// If your end customer reviews this case instead of you, the API returns a 403 with `case_reviewed_by_end_customer` in `error.details.error_code`.<br/>
        /// An Admin API key with the `write:compliance_review_cases` scope can call this endpoint.
        /// </summary>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="caseId"></param>
        /// <param name="determination">
        /// Your conclusion on the case as a whole. Anthropic doesn't check it against `verdicts`.
        /// </param>
        /// <param name="policyCategories">
        /// The policy categories that you found were violated. Send one to four with `violation`, and none with `no_violation`. They need not match the case's own. Each value is one of `cyber`, `bio`, `chem`, `radnuc` (radiological or nuclear weapons), `cgw` (conventional weapons), `mgw` (military-grade weapons systems), `io` (influence operations), `fraud`, `violent_extremism`, `surveillance`, `human_exploitation`, `self_harm`, `adult_content`, `reasoning_extraction`, `frontier_llm` (use of the model to accelerate frontier AI research and development in restricted ways), `compromised_key` or `other`, and can appear once.
        /// </param>
        /// <param name="verdicts">
        /// Your conclusions on individual messages of the case. They need not cover every message, and each `item_id` can appear once.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaComplianceReviewCase> BetaRespondToReviewCaseAsync(
            string caseId,
            global::Anthropic.BetaComplianceReviewDetermination determination,
            string? anthropicVersion = default,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaComplianceReviewViolatedPolicyCategory>? policyCategories = default,
            global::System.Collections.Generic.IList<global::Anthropic.BetaComplianceReviewVerdict>? verdicts = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}