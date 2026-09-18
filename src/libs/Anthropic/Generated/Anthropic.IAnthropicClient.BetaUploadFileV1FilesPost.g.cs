#nullable enable

namespace Anthropic
{
    public partial interface IAnthropicClient
    {
        /// <summary>
        /// Upload File
        /// </summary>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaFileMetadataSchema> BetaUploadFileV1FilesPostAsync(

            global::Anthropic.BetaUploadFileV1FilesPostRequest request,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicVersion = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File
        /// </summary>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaFileMetadataSchema>> BetaUploadFileV1FilesPostAsResponseAsync(

            global::Anthropic.BetaUploadFileV1FilesPostRequest request,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicVersion = default,
            string? anthropicWorkspaceId = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File
        /// </summary>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="file">
        /// The file to upload. Only the final path component of the part's `filename` is kept; an absent or empty `filename` is replaced with `unnamed` plus the extension for the file's stored `mime_type`, when known.
        /// </param>
        /// <param name="filename">
        /// The file to upload. Only the final path component of the part's `filename` is kept; an absent or empty `filename` is replaced with `unnamed` plus the extension for the file's stored `mime_type`, when known.
        /// </param>
        /// <param name="expiresInSeconds">
        /// Seconds from upload until the file expires and its bytes become permanently unavailable. Must be between 3600 (one hour) and 7776000 (ninety days).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaFileMetadataSchema> BetaUploadFileV1FilesPostAsync(
            byte[] file,
            string filename,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicVersion = default,
            string? anthropicWorkspaceId = default,
            int? expiresInSeconds = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload File
        /// </summary>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="file">
        /// The file to upload. Only the final path component of the part's `filename` is kept; an absent or empty `filename` is replaced with `unnamed` plus the extension for the file's stored `mime_type`, when known.
        /// </param>
        /// <param name="filename">
        /// The file to upload. Only the final path component of the part's `filename` is kept; an absent or empty `filename` is replaced with `unnamed` plus the extension for the file's stored `mime_type`, when known.
        /// </param>
        /// <param name="expiresInSeconds">
        /// Seconds from upload until the file expires and its bytes become permanently unavailable. Must be between 3600 (one hour) and 7776000 (ninety days).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.BetaFileMetadataSchema> BetaUploadFileV1FilesPostAsync(
            global::System.IO.Stream file,
            string filename,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicVersion = default,
            string? anthropicWorkspaceId = default,
            int? expiresInSeconds = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File
        /// </summary>
        /// <param name="anthropicBeta">
        /// Optional header to specify the beta version(s) you want to use.
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Claude API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://platform.claude.com/docs/en/api/versioning).
        /// </param>
        /// <param name="anthropicWorkspaceId"></param>
        /// <param name="file">
        /// The file to upload. Only the final path component of the part's `filename` is kept; an absent or empty `filename` is replaced with `unnamed` plus the extension for the file's stored `mime_type`, when known.
        /// </param>
        /// <param name="filename">
        /// The file to upload. Only the final path component of the part's `filename` is kept; an absent or empty `filename` is replaced with `unnamed` plus the extension for the file's stored `mime_type`, when known.
        /// </param>
        /// <param name="expiresInSeconds">
        /// Seconds from upload until the file expires and its bytes become permanently unavailable. Must be between 3600 (one hour) and 7776000 (ninety days).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Anthropic.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Anthropic.AutoSDKHttpResponse<global::Anthropic.BetaFileMetadataSchema>> BetaUploadFileV1FilesPostAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::System.Collections.Generic.IList<global::Anthropic.AnthropicBeta>? anthropicBeta = default,
            string? anthropicVersion = default,
            string? anthropicWorkspaceId = default,
            int? expiresInSeconds = default,
            global::Anthropic.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}