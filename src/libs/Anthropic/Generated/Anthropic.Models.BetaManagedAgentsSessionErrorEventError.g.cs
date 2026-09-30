#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaManagedAgentsSessionErrorEventError : global::System.IEquatable<BetaManagedAgentsSessionErrorEventError>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType? Type { get; }

        /// <summary>
        /// An unknown or unexpected error occurred during session execution. A fallback variant; clients that don't recognize a new error code can match on `retry_status` and `message` alone.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUnknownError? UnknownError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUnknownError? UnknownError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnknownError))]
#endif
        public bool IsUnknownError => UnknownError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnknownError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsUnknownError? value)
        {
            value = UnknownError;
            return IsUnknownError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownError PickUnknownError() => UnknownError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnknownError' but the value was {ToString()}.");

        /// <summary>
        /// The model is currently overloaded. Emitted after automatic retries are exhausted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsModelOverloadedError? ModelOverloadedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsModelOverloadedError? ModelOverloadedError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelOverloadedError))]
#endif
        public bool IsModelOverloadedError => ModelOverloadedError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelOverloadedError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsModelOverloadedError? value)
        {
            value = ModelOverloadedError;
            return IsModelOverloadedError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelOverloadedError PickModelOverloadedError() => ModelOverloadedError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelOverloadedError' but the value was {ToString()}.");

        /// <summary>
        /// The model request was rate-limited.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsModelRateLimitedError? ModelRateLimitedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsModelRateLimitedError? ModelRateLimitedError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelRateLimitedError))]
#endif
        public bool IsModelRateLimitedError => ModelRateLimitedError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelRateLimitedError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsModelRateLimitedError? value)
        {
            value = ModelRateLimitedError;
            return IsModelRateLimitedError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelRateLimitedError PickModelRateLimitedError() => ModelRateLimitedError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelRateLimitedError' but the value was {ToString()}.");

        /// <summary>
        /// A model request failed for a reason other than overload or rate-limiting.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsModelRequestFailedError? ModelRequestFailedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsModelRequestFailedError? ModelRequestFailedError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelRequestFailedError))]
#endif
        public bool IsModelRequestFailedError => ModelRequestFailedError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelRequestFailedError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsModelRequestFailedError? value)
        {
            value = ModelRequestFailedError;
            return IsModelRequestFailedError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsModelRequestFailedError PickModelRequestFailedError() => ModelRequestFailedError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelRequestFailedError' but the value was {ToString()}.");

        /// <summary>
        /// Failed to connect to an MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMcpConnectionFailedError? McpConnectionFailedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMcpConnectionFailedError? McpConnectionFailedError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpConnectionFailedError))]
#endif
        public bool IsMcpConnectionFailedError => McpConnectionFailedError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMcpConnectionFailedError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsMcpConnectionFailedError? value)
        {
            value = McpConnectionFailedError;
            return IsMcpConnectionFailedError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpConnectionFailedError PickMcpConnectionFailedError() => McpConnectionFailedError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpConnectionFailedError' but the value was {ToString()}.");

        /// <summary>
        /// Authentication to an MCP server failed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError? McpAuthenticationFailedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError? McpAuthenticationFailedError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpAuthenticationFailedError))]
#endif
        public bool IsMcpAuthenticationFailedError => McpAuthenticationFailedError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMcpAuthenticationFailedError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError? value)
        {
            value = McpAuthenticationFailedError;
            return IsMcpAuthenticationFailedError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError PickMcpAuthenticationFailedError() => McpAuthenticationFailedError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpAuthenticationFailedError' but the value was {ToString()}.");

        /// <summary>
        /// The caller's organization or workspace cannot make model requests — out of credits or spend limit reached. Retrying with the same credentials will not succeed; the caller must resolve the billing state.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsBillingError? BillingError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsBillingError? BillingError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BillingError))]
#endif
        public bool IsBillingError => BillingError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBillingError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsBillingError? value)
        {
            value = BillingError;
            return IsBillingError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBillingError PickBillingError() => BillingError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BillingError' but the value was {ToString()}.");

        /// <summary>
        /// An `environment_variable` credential's `auth.networking.allowed_hosts` includes a host the environment's network policy does not permit.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError? CredentialHostUnreachableError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError? CredentialHostUnreachableError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CredentialHostUnreachableError))]
#endif
        public bool IsCredentialHostUnreachableError => CredentialHostUnreachableError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCredentialHostUnreachableError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError? value)
        {
            value = CredentialHostUnreachableError;
            return IsCredentialHostUnreachableError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError PickCredentialHostUnreachableError() => CredentialHostUnreachableError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CredentialHostUnreachableError' but the value was {ToString()}.");

        /// <summary>
        /// The repository host rejected the credentials, or required credentials and received none.<br/>
        /// Example: {"type":"repository_authentication_error","message":"The repository host rejected the credentials for the repository, or required credentials and received none.","retry_status":{"type":"retrying"},"repository_url":"https://github.com/example-org/example-repo"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError? RepositoryAuthenticationError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError? RepositoryAuthenticationError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryAuthenticationError))]
#endif
        public bool IsRepositoryAuthenticationError => RepositoryAuthenticationError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryAuthenticationError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError? value)
        {
            value = RepositoryAuthenticationError;
            return IsRepositoryAuthenticationError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError PickRepositoryAuthenticationError() => RepositoryAuthenticationError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryAuthenticationError' but the value was {ToString()}.");

        /// <summary>
        /// The repository host refused access to the repository.<br/>
        /// Example: {"type":"repository_forbidden_error","message":"The repository host refused access to the repository.","retry_status":{"type":"retrying"},"repository_url":"https://github.com/example-org/example-repo"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsRepositoryForbiddenError? RepositoryForbiddenError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsRepositoryForbiddenError? RepositoryForbiddenError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryForbiddenError))]
#endif
        public bool IsRepositoryForbiddenError => RepositoryForbiddenError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryForbiddenError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsRepositoryForbiddenError? value)
        {
            value = RepositoryForbiddenError;
            return IsRepositoryForbiddenError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryForbiddenError PickRepositoryForbiddenError() => RepositoryForbiddenError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryForbiddenError' but the value was {ToString()}.");

        /// <summary>
        /// The repository host reported the repository as not found.<br/>
        /// Example: {"type":"repository_not_found_error","message":"The repository host reported the repository as not found.","retry_status":{"type":"retrying"},"repository_url":"https://github.com/example-org/example-repo"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsRepositoryNotFoundError? RepositoryNotFoundError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsRepositoryNotFoundError? RepositoryNotFoundError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryNotFoundError))]
#endif
        public bool IsRepositoryNotFoundError => RepositoryNotFoundError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryNotFoundError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsRepositoryNotFoundError? value)
        {
            value = RepositoryNotFoundError;
            return IsRepositoryNotFoundError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryNotFoundError PickRepositoryNotFoundError() => RepositoryNotFoundError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryNotFoundError' but the value was {ToString()}.");

        /// <summary>
        /// The requested branch or commit does not exist in the repository.<br/>
        /// Example: {"type":"repository_checkout_error","message":"The requested branch or commit does not exist in the repository.","retry_status":{"type":"retrying"},"repository_url":"https://github.com/example-org/example-repo"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsRepositoryCheckoutError? RepositoryCheckoutError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsRepositoryCheckoutError? RepositoryCheckoutError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryCheckoutError))]
#endif
        public bool IsRepositoryCheckoutError => RepositoryCheckoutError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryCheckoutError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsRepositoryCheckoutError? value)
        {
            value = RepositoryCheckoutError;
            return IsRepositoryCheckoutError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCheckoutError PickRepositoryCheckoutError() => RepositoryCheckoutError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryCheckoutError' but the value was {ToString()}.");

        /// <summary>
        /// The repository could not be cloned.<br/>
        /// Example: {"type":"repository_clone_error","message":"The repository could not be cloned.","retry_status":{"type":"retrying"},"repository_url":"https://github.com/example-org/example-repo"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsRepositoryCloneError? RepositoryCloneError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsRepositoryCloneError? RepositoryCloneError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryCloneError))]
#endif
        public bool IsRepositoryCloneError => RepositoryCloneError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepositoryCloneError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsRepositoryCloneError? value)
        {
            value = RepositoryCloneError;
            return IsRepositoryCloneError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRepositoryCloneError PickRepositoryCloneError() => RepositoryCloneError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepositoryCloneError' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsUnknownError value) => new BetaManagedAgentsSessionErrorEventError((global::Anthropic.BetaManagedAgentsUnknownError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUnknownError?(BetaManagedAgentsSessionErrorEventError @this) => @this.UnknownError;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsUnknownError? value)
        {
            UnknownError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsSessionErrorEventError FromUnknownError(global::Anthropic.BetaManagedAgentsUnknownError? value) => new BetaManagedAgentsSessionErrorEventError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsModelOverloadedError value) => new BetaManagedAgentsSessionErrorEventError((global::Anthropic.BetaManagedAgentsModelOverloadedError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsModelOverloadedError?(BetaManagedAgentsSessionErrorEventError @this) => @this.ModelOverloadedError;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsModelOverloadedError? value)
        {
            ModelOverloadedError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsSessionErrorEventError FromModelOverloadedError(global::Anthropic.BetaManagedAgentsModelOverloadedError? value) => new BetaManagedAgentsSessionErrorEventError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsModelRateLimitedError value) => new BetaManagedAgentsSessionErrorEventError((global::Anthropic.BetaManagedAgentsModelRateLimitedError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsModelRateLimitedError?(BetaManagedAgentsSessionErrorEventError @this) => @this.ModelRateLimitedError;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsModelRateLimitedError? value)
        {
            ModelRateLimitedError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsSessionErrorEventError FromModelRateLimitedError(global::Anthropic.BetaManagedAgentsModelRateLimitedError? value) => new BetaManagedAgentsSessionErrorEventError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsModelRequestFailedError value) => new BetaManagedAgentsSessionErrorEventError((global::Anthropic.BetaManagedAgentsModelRequestFailedError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsModelRequestFailedError?(BetaManagedAgentsSessionErrorEventError @this) => @this.ModelRequestFailedError;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsModelRequestFailedError? value)
        {
            ModelRequestFailedError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsSessionErrorEventError FromModelRequestFailedError(global::Anthropic.BetaManagedAgentsModelRequestFailedError? value) => new BetaManagedAgentsSessionErrorEventError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsMcpConnectionFailedError value) => new BetaManagedAgentsSessionErrorEventError((global::Anthropic.BetaManagedAgentsMcpConnectionFailedError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMcpConnectionFailedError?(BetaManagedAgentsSessionErrorEventError @this) => @this.McpConnectionFailedError;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsMcpConnectionFailedError? value)
        {
            McpConnectionFailedError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsSessionErrorEventError FromMcpConnectionFailedError(global::Anthropic.BetaManagedAgentsMcpConnectionFailedError? value) => new BetaManagedAgentsSessionErrorEventError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError value) => new BetaManagedAgentsSessionErrorEventError((global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError?(BetaManagedAgentsSessionErrorEventError @this) => @this.McpAuthenticationFailedError;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError? value)
        {
            McpAuthenticationFailedError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsSessionErrorEventError FromMcpAuthenticationFailedError(global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError? value) => new BetaManagedAgentsSessionErrorEventError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsBillingError value) => new BetaManagedAgentsSessionErrorEventError((global::Anthropic.BetaManagedAgentsBillingError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsBillingError?(BetaManagedAgentsSessionErrorEventError @this) => @this.BillingError;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsBillingError? value)
        {
            BillingError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsSessionErrorEventError FromBillingError(global::Anthropic.BetaManagedAgentsBillingError? value) => new BetaManagedAgentsSessionErrorEventError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError value) => new BetaManagedAgentsSessionErrorEventError((global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError?(BetaManagedAgentsSessionErrorEventError @this) => @this.CredentialHostUnreachableError;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError? value)
        {
            CredentialHostUnreachableError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsSessionErrorEventError FromCredentialHostUnreachableError(global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError? value) => new BetaManagedAgentsSessionErrorEventError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError value) => new BetaManagedAgentsSessionErrorEventError((global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError?(BetaManagedAgentsSessionErrorEventError @this) => @this.RepositoryAuthenticationError;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError? value)
        {
            RepositoryAuthenticationError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsSessionErrorEventError FromRepositoryAuthenticationError(global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError? value) => new BetaManagedAgentsSessionErrorEventError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsRepositoryForbiddenError value) => new BetaManagedAgentsSessionErrorEventError((global::Anthropic.BetaManagedAgentsRepositoryForbiddenError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsRepositoryForbiddenError?(BetaManagedAgentsSessionErrorEventError @this) => @this.RepositoryForbiddenError;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsRepositoryForbiddenError? value)
        {
            RepositoryForbiddenError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsSessionErrorEventError FromRepositoryForbiddenError(global::Anthropic.BetaManagedAgentsRepositoryForbiddenError? value) => new BetaManagedAgentsSessionErrorEventError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsRepositoryNotFoundError value) => new BetaManagedAgentsSessionErrorEventError((global::Anthropic.BetaManagedAgentsRepositoryNotFoundError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsRepositoryNotFoundError?(BetaManagedAgentsSessionErrorEventError @this) => @this.RepositoryNotFoundError;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsRepositoryNotFoundError? value)
        {
            RepositoryNotFoundError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsSessionErrorEventError FromRepositoryNotFoundError(global::Anthropic.BetaManagedAgentsRepositoryNotFoundError? value) => new BetaManagedAgentsSessionErrorEventError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsRepositoryCheckoutError value) => new BetaManagedAgentsSessionErrorEventError((global::Anthropic.BetaManagedAgentsRepositoryCheckoutError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsRepositoryCheckoutError?(BetaManagedAgentsSessionErrorEventError @this) => @this.RepositoryCheckoutError;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsRepositoryCheckoutError? value)
        {
            RepositoryCheckoutError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsSessionErrorEventError FromRepositoryCheckoutError(global::Anthropic.BetaManagedAgentsRepositoryCheckoutError? value) => new BetaManagedAgentsSessionErrorEventError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsRepositoryCloneError value) => new BetaManagedAgentsSessionErrorEventError((global::Anthropic.BetaManagedAgentsRepositoryCloneError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsRepositoryCloneError?(BetaManagedAgentsSessionErrorEventError @this) => @this.RepositoryCloneError;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsSessionErrorEventError(global::Anthropic.BetaManagedAgentsRepositoryCloneError? value)
        {
            RepositoryCloneError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsSessionErrorEventError FromRepositoryCloneError(global::Anthropic.BetaManagedAgentsRepositoryCloneError? value) => new BetaManagedAgentsSessionErrorEventError(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsSessionErrorEventError(
            global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsUnknownError? unknownError,
            global::Anthropic.BetaManagedAgentsModelOverloadedError? modelOverloadedError,
            global::Anthropic.BetaManagedAgentsModelRateLimitedError? modelRateLimitedError,
            global::Anthropic.BetaManagedAgentsModelRequestFailedError? modelRequestFailedError,
            global::Anthropic.BetaManagedAgentsMcpConnectionFailedError? mcpConnectionFailedError,
            global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError? mcpAuthenticationFailedError,
            global::Anthropic.BetaManagedAgentsBillingError? billingError,
            global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError? credentialHostUnreachableError,
            global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError? repositoryAuthenticationError,
            global::Anthropic.BetaManagedAgentsRepositoryForbiddenError? repositoryForbiddenError,
            global::Anthropic.BetaManagedAgentsRepositoryNotFoundError? repositoryNotFoundError,
            global::Anthropic.BetaManagedAgentsRepositoryCheckoutError? repositoryCheckoutError,
            global::Anthropic.BetaManagedAgentsRepositoryCloneError? repositoryCloneError
            )
        {
            Type = type;

            UnknownError = unknownError;
            ModelOverloadedError = modelOverloadedError;
            ModelRateLimitedError = modelRateLimitedError;
            ModelRequestFailedError = modelRequestFailedError;
            McpConnectionFailedError = mcpConnectionFailedError;
            McpAuthenticationFailedError = mcpAuthenticationFailedError;
            BillingError = billingError;
            CredentialHostUnreachableError = credentialHostUnreachableError;
            RepositoryAuthenticationError = repositoryAuthenticationError;
            RepositoryForbiddenError = repositoryForbiddenError;
            RepositoryNotFoundError = repositoryNotFoundError;
            RepositoryCheckoutError = repositoryCheckoutError;
            RepositoryCloneError = repositoryCloneError;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RepositoryCloneError as object ??
            RepositoryCheckoutError as object ??
            RepositoryNotFoundError as object ??
            RepositoryForbiddenError as object ??
            RepositoryAuthenticationError as object ??
            CredentialHostUnreachableError as object ??
            BillingError as object ??
            McpAuthenticationFailedError as object ??
            McpConnectionFailedError as object ??
            ModelRequestFailedError as object ??
            ModelRateLimitedError as object ??
            ModelOverloadedError as object ??
            UnknownError as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UnknownError?.ToString() ??
            ModelOverloadedError?.ToString() ??
            ModelRateLimitedError?.ToString() ??
            ModelRequestFailedError?.ToString() ??
            McpConnectionFailedError?.ToString() ??
            McpAuthenticationFailedError?.ToString() ??
            BillingError?.ToString() ??
            CredentialHostUnreachableError?.ToString() ??
            RepositoryAuthenticationError?.ToString() ??
            RepositoryForbiddenError?.ToString() ??
            RepositoryNotFoundError?.ToString() ??
            RepositoryCheckoutError?.ToString() ??
            RepositoryCloneError?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUnknownError && !IsModelOverloadedError && !IsModelRateLimitedError && !IsModelRequestFailedError && !IsMcpConnectionFailedError && !IsMcpAuthenticationFailedError && !IsBillingError && !IsCredentialHostUnreachableError && !IsRepositoryAuthenticationError && !IsRepositoryForbiddenError && !IsRepositoryNotFoundError && !IsRepositoryCheckoutError && !IsRepositoryCloneError || !IsUnknownError && IsModelOverloadedError && !IsModelRateLimitedError && !IsModelRequestFailedError && !IsMcpConnectionFailedError && !IsMcpAuthenticationFailedError && !IsBillingError && !IsCredentialHostUnreachableError && !IsRepositoryAuthenticationError && !IsRepositoryForbiddenError && !IsRepositoryNotFoundError && !IsRepositoryCheckoutError && !IsRepositoryCloneError || !IsUnknownError && !IsModelOverloadedError && IsModelRateLimitedError && !IsModelRequestFailedError && !IsMcpConnectionFailedError && !IsMcpAuthenticationFailedError && !IsBillingError && !IsCredentialHostUnreachableError && !IsRepositoryAuthenticationError && !IsRepositoryForbiddenError && !IsRepositoryNotFoundError && !IsRepositoryCheckoutError && !IsRepositoryCloneError || !IsUnknownError && !IsModelOverloadedError && !IsModelRateLimitedError && IsModelRequestFailedError && !IsMcpConnectionFailedError && !IsMcpAuthenticationFailedError && !IsBillingError && !IsCredentialHostUnreachableError && !IsRepositoryAuthenticationError && !IsRepositoryForbiddenError && !IsRepositoryNotFoundError && !IsRepositoryCheckoutError && !IsRepositoryCloneError || !IsUnknownError && !IsModelOverloadedError && !IsModelRateLimitedError && !IsModelRequestFailedError && IsMcpConnectionFailedError && !IsMcpAuthenticationFailedError && !IsBillingError && !IsCredentialHostUnreachableError && !IsRepositoryAuthenticationError && !IsRepositoryForbiddenError && !IsRepositoryNotFoundError && !IsRepositoryCheckoutError && !IsRepositoryCloneError || !IsUnknownError && !IsModelOverloadedError && !IsModelRateLimitedError && !IsModelRequestFailedError && !IsMcpConnectionFailedError && IsMcpAuthenticationFailedError && !IsBillingError && !IsCredentialHostUnreachableError && !IsRepositoryAuthenticationError && !IsRepositoryForbiddenError && !IsRepositoryNotFoundError && !IsRepositoryCheckoutError && !IsRepositoryCloneError || !IsUnknownError && !IsModelOverloadedError && !IsModelRateLimitedError && !IsModelRequestFailedError && !IsMcpConnectionFailedError && !IsMcpAuthenticationFailedError && IsBillingError && !IsCredentialHostUnreachableError && !IsRepositoryAuthenticationError && !IsRepositoryForbiddenError && !IsRepositoryNotFoundError && !IsRepositoryCheckoutError && !IsRepositoryCloneError || !IsUnknownError && !IsModelOverloadedError && !IsModelRateLimitedError && !IsModelRequestFailedError && !IsMcpConnectionFailedError && !IsMcpAuthenticationFailedError && !IsBillingError && IsCredentialHostUnreachableError && !IsRepositoryAuthenticationError && !IsRepositoryForbiddenError && !IsRepositoryNotFoundError && !IsRepositoryCheckoutError && !IsRepositoryCloneError || !IsUnknownError && !IsModelOverloadedError && !IsModelRateLimitedError && !IsModelRequestFailedError && !IsMcpConnectionFailedError && !IsMcpAuthenticationFailedError && !IsBillingError && !IsCredentialHostUnreachableError && IsRepositoryAuthenticationError && !IsRepositoryForbiddenError && !IsRepositoryNotFoundError && !IsRepositoryCheckoutError && !IsRepositoryCloneError || !IsUnknownError && !IsModelOverloadedError && !IsModelRateLimitedError && !IsModelRequestFailedError && !IsMcpConnectionFailedError && !IsMcpAuthenticationFailedError && !IsBillingError && !IsCredentialHostUnreachableError && !IsRepositoryAuthenticationError && IsRepositoryForbiddenError && !IsRepositoryNotFoundError && !IsRepositoryCheckoutError && !IsRepositoryCloneError || !IsUnknownError && !IsModelOverloadedError && !IsModelRateLimitedError && !IsModelRequestFailedError && !IsMcpConnectionFailedError && !IsMcpAuthenticationFailedError && !IsBillingError && !IsCredentialHostUnreachableError && !IsRepositoryAuthenticationError && !IsRepositoryForbiddenError && IsRepositoryNotFoundError && !IsRepositoryCheckoutError && !IsRepositoryCloneError || !IsUnknownError && !IsModelOverloadedError && !IsModelRateLimitedError && !IsModelRequestFailedError && !IsMcpConnectionFailedError && !IsMcpAuthenticationFailedError && !IsBillingError && !IsCredentialHostUnreachableError && !IsRepositoryAuthenticationError && !IsRepositoryForbiddenError && !IsRepositoryNotFoundError && IsRepositoryCheckoutError && !IsRepositoryCloneError || !IsUnknownError && !IsModelOverloadedError && !IsModelRateLimitedError && !IsModelRequestFailedError && !IsMcpConnectionFailedError && !IsMcpAuthenticationFailedError && !IsBillingError && !IsCredentialHostUnreachableError && !IsRepositoryAuthenticationError && !IsRepositoryForbiddenError && !IsRepositoryNotFoundError && !IsRepositoryCheckoutError && IsRepositoryCloneError;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsUnknownError, TResult>? unknownError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsModelOverloadedError, TResult>? modelOverloadedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsModelRateLimitedError, TResult>? modelRateLimitedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsModelRequestFailedError, TResult>? modelRequestFailedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMcpConnectionFailedError, TResult>? mcpConnectionFailedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError, TResult>? mcpAuthenticationFailedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsBillingError, TResult>? billingError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError, TResult>? credentialHostUnreachableError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError, TResult>? repositoryAuthenticationError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsRepositoryForbiddenError, TResult>? repositoryForbiddenError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsRepositoryNotFoundError, TResult>? repositoryNotFoundError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsRepositoryCheckoutError, TResult>? repositoryCheckoutError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsRepositoryCloneError, TResult>? repositoryCloneError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (UnknownError is { } __value0 && unknownError != null)
            {
                return unknownError(__value0);
            }
            else if (ModelOverloadedError is { } __value1 && modelOverloadedError != null)
            {
                return modelOverloadedError(__value1);
            }
            else if (ModelRateLimitedError is { } __value2 && modelRateLimitedError != null)
            {
                return modelRateLimitedError(__value2);
            }
            else if (ModelRequestFailedError is { } __value3 && modelRequestFailedError != null)
            {
                return modelRequestFailedError(__value3);
            }
            else if (McpConnectionFailedError is { } __value4 && mcpConnectionFailedError != null)
            {
                return mcpConnectionFailedError(__value4);
            }
            else if (McpAuthenticationFailedError is { } __value5 && mcpAuthenticationFailedError != null)
            {
                return mcpAuthenticationFailedError(__value5);
            }
            else if (BillingError is { } __value6 && billingError != null)
            {
                return billingError(__value6);
            }
            else if (CredentialHostUnreachableError is { } __value7 && credentialHostUnreachableError != null)
            {
                return credentialHostUnreachableError(__value7);
            }
            else if (RepositoryAuthenticationError is { } __value8 && repositoryAuthenticationError != null)
            {
                return repositoryAuthenticationError(__value8);
            }
            else if (RepositoryForbiddenError is { } __value9 && repositoryForbiddenError != null)
            {
                return repositoryForbiddenError(__value9);
            }
            else if (RepositoryNotFoundError is { } __value10 && repositoryNotFoundError != null)
            {
                return repositoryNotFoundError(__value10);
            }
            else if (RepositoryCheckoutError is { } __value11 && repositoryCheckoutError != null)
            {
                return repositoryCheckoutError(__value11);
            }
            else if (RepositoryCloneError is { } __value12 && repositoryCloneError != null)
            {
                return repositoryCloneError(__value12);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsUnknownError>? unknownError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsModelOverloadedError>? modelOverloadedError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsModelRateLimitedError>? modelRateLimitedError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsModelRequestFailedError>? modelRequestFailedError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsMcpConnectionFailedError>? mcpConnectionFailedError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError>? mcpAuthenticationFailedError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsBillingError>? billingError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError>? credentialHostUnreachableError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError>? repositoryAuthenticationError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsRepositoryForbiddenError>? repositoryForbiddenError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsRepositoryNotFoundError>? repositoryNotFoundError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsRepositoryCheckoutError>? repositoryCheckoutError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsRepositoryCloneError>? repositoryCloneError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (UnknownError is { } __value0)
            {
                unknownError?.Invoke(__value0);
            }
            else if (ModelOverloadedError is { } __value1)
            {
                modelOverloadedError?.Invoke(__value1);
            }
            else if (ModelRateLimitedError is { } __value2)
            {
                modelRateLimitedError?.Invoke(__value2);
            }
            else if (ModelRequestFailedError is { } __value3)
            {
                modelRequestFailedError?.Invoke(__value3);
            }
            else if (McpConnectionFailedError is { } __value4)
            {
                mcpConnectionFailedError?.Invoke(__value4);
            }
            else if (McpAuthenticationFailedError is { } __value5)
            {
                mcpAuthenticationFailedError?.Invoke(__value5);
            }
            else if (BillingError is { } __value6)
            {
                billingError?.Invoke(__value6);
            }
            else if (CredentialHostUnreachableError is { } __value7)
            {
                credentialHostUnreachableError?.Invoke(__value7);
            }
            else if (RepositoryAuthenticationError is { } __value8)
            {
                repositoryAuthenticationError?.Invoke(__value8);
            }
            else if (RepositoryForbiddenError is { } __value9)
            {
                repositoryForbiddenError?.Invoke(__value9);
            }
            else if (RepositoryNotFoundError is { } __value10)
            {
                repositoryNotFoundError?.Invoke(__value10);
            }
            else if (RepositoryCheckoutError is { } __value11)
            {
                repositoryCheckoutError?.Invoke(__value11);
            }
            else if (RepositoryCloneError is { } __value12)
            {
                repositoryCloneError?.Invoke(__value12);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsUnknownError>? unknownError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsModelOverloadedError>? modelOverloadedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsModelRateLimitedError>? modelRateLimitedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsModelRequestFailedError>? modelRequestFailedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMcpConnectionFailedError>? mcpConnectionFailedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError>? mcpAuthenticationFailedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsBillingError>? billingError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError>? credentialHostUnreachableError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError>? repositoryAuthenticationError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsRepositoryForbiddenError>? repositoryForbiddenError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsRepositoryNotFoundError>? repositoryNotFoundError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsRepositoryCheckoutError>? repositoryCheckoutError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsRepositoryCloneError>? repositoryCloneError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (UnknownError is { } __value0)
            {
                unknownError?.Invoke(__value0);
            }
            else if (ModelOverloadedError is { } __value1)
            {
                modelOverloadedError?.Invoke(__value1);
            }
            else if (ModelRateLimitedError is { } __value2)
            {
                modelRateLimitedError?.Invoke(__value2);
            }
            else if (ModelRequestFailedError is { } __value3)
            {
                modelRequestFailedError?.Invoke(__value3);
            }
            else if (McpConnectionFailedError is { } __value4)
            {
                mcpConnectionFailedError?.Invoke(__value4);
            }
            else if (McpAuthenticationFailedError is { } __value5)
            {
                mcpAuthenticationFailedError?.Invoke(__value5);
            }
            else if (BillingError is { } __value6)
            {
                billingError?.Invoke(__value6);
            }
            else if (CredentialHostUnreachableError is { } __value7)
            {
                credentialHostUnreachableError?.Invoke(__value7);
            }
            else if (RepositoryAuthenticationError is { } __value8)
            {
                repositoryAuthenticationError?.Invoke(__value8);
            }
            else if (RepositoryForbiddenError is { } __value9)
            {
                repositoryForbiddenError?.Invoke(__value9);
            }
            else if (RepositoryNotFoundError is { } __value10)
            {
                repositoryNotFoundError?.Invoke(__value10);
            }
            else if (RepositoryCheckoutError is { } __value11)
            {
                repositoryCheckoutError?.Invoke(__value11);
            }
            else if (RepositoryCloneError is { } __value12)
            {
                repositoryCloneError?.Invoke(__value12);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UnknownError,
                typeof(global::Anthropic.BetaManagedAgentsUnknownError),
                ModelOverloadedError,
                typeof(global::Anthropic.BetaManagedAgentsModelOverloadedError),
                ModelRateLimitedError,
                typeof(global::Anthropic.BetaManagedAgentsModelRateLimitedError),
                ModelRequestFailedError,
                typeof(global::Anthropic.BetaManagedAgentsModelRequestFailedError),
                McpConnectionFailedError,
                typeof(global::Anthropic.BetaManagedAgentsMcpConnectionFailedError),
                McpAuthenticationFailedError,
                typeof(global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError),
                BillingError,
                typeof(global::Anthropic.BetaManagedAgentsBillingError),
                CredentialHostUnreachableError,
                typeof(global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError),
                RepositoryAuthenticationError,
                typeof(global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError),
                RepositoryForbiddenError,
                typeof(global::Anthropic.BetaManagedAgentsRepositoryForbiddenError),
                RepositoryNotFoundError,
                typeof(global::Anthropic.BetaManagedAgentsRepositoryNotFoundError),
                RepositoryCheckoutError,
                typeof(global::Anthropic.BetaManagedAgentsRepositoryCheckoutError),
                RepositoryCloneError,
                typeof(global::Anthropic.BetaManagedAgentsRepositoryCloneError),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(BetaManagedAgentsSessionErrorEventError other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUnknownError?>.Default.Equals(UnknownError, other.UnknownError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsModelOverloadedError?>.Default.Equals(ModelOverloadedError, other.ModelOverloadedError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsModelRateLimitedError?>.Default.Equals(ModelRateLimitedError, other.ModelRateLimitedError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsModelRequestFailedError?>.Default.Equals(ModelRequestFailedError, other.ModelRequestFailedError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMcpConnectionFailedError?>.Default.Equals(McpConnectionFailedError, other.McpConnectionFailedError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError?>.Default.Equals(McpAuthenticationFailedError, other.McpAuthenticationFailedError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsBillingError?>.Default.Equals(BillingError, other.BillingError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsCredentialHostUnreachableError?>.Default.Equals(CredentialHostUnreachableError, other.CredentialHostUnreachableError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsRepositoryAuthenticationError?>.Default.Equals(RepositoryAuthenticationError, other.RepositoryAuthenticationError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsRepositoryForbiddenError?>.Default.Equals(RepositoryForbiddenError, other.RepositoryForbiddenError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsRepositoryNotFoundError?>.Default.Equals(RepositoryNotFoundError, other.RepositoryNotFoundError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsRepositoryCheckoutError?>.Default.Equals(RepositoryCheckoutError, other.RepositoryCheckoutError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsRepositoryCloneError?>.Default.Equals(RepositoryCloneError, other.RepositoryCloneError)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsSessionErrorEventError obj1, BetaManagedAgentsSessionErrorEventError obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsSessionErrorEventError>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsSessionErrorEventError obj1, BetaManagedAgentsSessionErrorEventError obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsSessionErrorEventError o && Equals(o);
        }
    }
}
