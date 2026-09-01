#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaDreamingError : global::System.IEquatable<BetaDreamingError>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDreamingErrorDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaInvalidRequestError? InvalidRequestError { get; init; }
#else
        public global::Anthropic.BetaInvalidRequestError? InvalidRequestError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InvalidRequestError))]
#endif
        public bool IsInvalidRequestError => InvalidRequestError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInvalidRequestError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaInvalidRequestError? value)
        {
            value = InvalidRequestError;
            return IsInvalidRequestError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInvalidRequestError PickInvalidRequestError() => IsInvalidRequestError
            ? InvalidRequestError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InvalidRequestError' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaAuthenticationError? AuthenticationError { get; init; }
#else
        public global::Anthropic.BetaAuthenticationError? AuthenticationError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AuthenticationError))]
#endif
        public bool IsAuthenticationError => AuthenticationError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAuthenticationError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaAuthenticationError? value)
        {
            value = AuthenticationError;
            return IsAuthenticationError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAuthenticationError PickAuthenticationError() => IsAuthenticationError
            ? AuthenticationError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AuthenticationError' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBillingError? BillingError { get; init; }
#else
        public global::Anthropic.BetaBillingError? BillingError { get; }
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
            out global::Anthropic.BetaBillingError? value)
        {
            value = BillingError;
            return IsBillingError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBillingError PickBillingError() => IsBillingError
            ? BillingError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BillingError' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaPermissionError? PermissionError { get; init; }
#else
        public global::Anthropic.BetaPermissionError? PermissionError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PermissionError))]
#endif
        public bool IsPermissionError => PermissionError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPermissionError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaPermissionError? value)
        {
            value = PermissionError;
            return IsPermissionError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPermissionError PickPermissionError() => IsPermissionError
            ? PermissionError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PermissionError' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaNotFoundError? NotFoundError { get; init; }
#else
        public global::Anthropic.BetaNotFoundError? NotFoundError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NotFoundError))]
#endif
        public bool IsNotFoundError => NotFoundError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNotFoundError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaNotFoundError? value)
        {
            value = NotFoundError;
            return IsNotFoundError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaNotFoundError PickNotFoundError() => IsNotFoundError
            ? NotFoundError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'NotFoundError' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRateLimitError? RateLimitError { get; init; }
#else
        public global::Anthropic.BetaRateLimitError? RateLimitError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RateLimitError))]
#endif
        public bool IsRateLimitError => RateLimitError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRateLimitError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRateLimitError? value)
        {
            value = RateLimitError;
            return IsRateLimitError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitError PickRateLimitError() => IsRateLimitError
            ? RateLimitError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RateLimitError' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaGatewayTimeoutError? TimeoutError { get; init; }
#else
        public global::Anthropic.BetaGatewayTimeoutError? TimeoutError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimeoutError))]
#endif
        public bool IsTimeoutError => TimeoutError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTimeoutError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaGatewayTimeoutError? value)
        {
            value = TimeoutError;
            return IsTimeoutError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGatewayTimeoutError PickTimeoutError() => IsTimeoutError
            ? TimeoutError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TimeoutError' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaAPIError? ApiError { get; init; }
#else
        public global::Anthropic.BetaAPIError? ApiError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiError))]
#endif
        public bool IsApiError => ApiError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickApiError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaAPIError? value)
        {
            value = ApiError;
            return IsApiError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAPIError PickApiError() => IsApiError
            ? ApiError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApiError' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaOverloadedError? OverloadedError { get; init; }
#else
        public global::Anthropic.BetaOverloadedError? OverloadedError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OverloadedError))]
#endif
        public bool IsOverloadedError => OverloadedError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOverloadedError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaOverloadedError? value)
        {
            value = OverloadedError;
            return IsOverloadedError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOverloadedError PickOverloadedError() => IsOverloadedError
            ? OverloadedError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OverloadedError' but the value was {ToString()}.");

        /// <summary>
        /// The `output_behavior.memory_store_id` target is still held by a prior `{type: "update_existing"}` dream — one that is `pending` or `running`, or was canceled with its final writes still landing. Rarely the named dream has just finished (`completed`/`failed`) and its execution is still closing; an immediate retry then almost always succeeds. The message names the holding dream when the server can identify it (rarely omitted); poll it to a terminal state or cancel it, then retry. Carried with `x-should-retry: false`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTargetStoreHeldError? ConflictError { get; init; }
#else
        public global::Anthropic.BetaTargetStoreHeldError? ConflictError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConflictError))]
#endif
        public bool IsConflictError => ConflictError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConflictError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaTargetStoreHeldError? value)
        {
            value = ConflictError;
            return IsConflictError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTargetStoreHeldError PickConflictError() => IsConflictError
            ? ConflictError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConflictError' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaDreamingError(global::Anthropic.BetaInvalidRequestError value) => new BetaDreamingError((global::Anthropic.BetaInvalidRequestError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaInvalidRequestError?(BetaDreamingError @this) => @this.InvalidRequestError;

        /// <summary>
        ///
        /// </summary>
        public BetaDreamingError(global::Anthropic.BetaInvalidRequestError? value)
        {
            InvalidRequestError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaDreamingError FromInvalidRequestError(global::Anthropic.BetaInvalidRequestError? value) => new BetaDreamingError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaDreamingError(global::Anthropic.BetaAuthenticationError value) => new BetaDreamingError((global::Anthropic.BetaAuthenticationError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaAuthenticationError?(BetaDreamingError @this) => @this.AuthenticationError;

        /// <summary>
        ///
        /// </summary>
        public BetaDreamingError(global::Anthropic.BetaAuthenticationError? value)
        {
            AuthenticationError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaDreamingError FromAuthenticationError(global::Anthropic.BetaAuthenticationError? value) => new BetaDreamingError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaDreamingError(global::Anthropic.BetaBillingError value) => new BetaDreamingError((global::Anthropic.BetaBillingError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBillingError?(BetaDreamingError @this) => @this.BillingError;

        /// <summary>
        ///
        /// </summary>
        public BetaDreamingError(global::Anthropic.BetaBillingError? value)
        {
            BillingError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaDreamingError FromBillingError(global::Anthropic.BetaBillingError? value) => new BetaDreamingError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaDreamingError(global::Anthropic.BetaPermissionError value) => new BetaDreamingError((global::Anthropic.BetaPermissionError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaPermissionError?(BetaDreamingError @this) => @this.PermissionError;

        /// <summary>
        ///
        /// </summary>
        public BetaDreamingError(global::Anthropic.BetaPermissionError? value)
        {
            PermissionError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaDreamingError FromPermissionError(global::Anthropic.BetaPermissionError? value) => new BetaDreamingError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaDreamingError(global::Anthropic.BetaNotFoundError value) => new BetaDreamingError((global::Anthropic.BetaNotFoundError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaNotFoundError?(BetaDreamingError @this) => @this.NotFoundError;

        /// <summary>
        ///
        /// </summary>
        public BetaDreamingError(global::Anthropic.BetaNotFoundError? value)
        {
            NotFoundError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaDreamingError FromNotFoundError(global::Anthropic.BetaNotFoundError? value) => new BetaDreamingError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaDreamingError(global::Anthropic.BetaRateLimitError value) => new BetaDreamingError((global::Anthropic.BetaRateLimitError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRateLimitError?(BetaDreamingError @this) => @this.RateLimitError;

        /// <summary>
        ///
        /// </summary>
        public BetaDreamingError(global::Anthropic.BetaRateLimitError? value)
        {
            RateLimitError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaDreamingError FromRateLimitError(global::Anthropic.BetaRateLimitError? value) => new BetaDreamingError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaDreamingError(global::Anthropic.BetaGatewayTimeoutError value) => new BetaDreamingError((global::Anthropic.BetaGatewayTimeoutError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaGatewayTimeoutError?(BetaDreamingError @this) => @this.TimeoutError;

        /// <summary>
        ///
        /// </summary>
        public BetaDreamingError(global::Anthropic.BetaGatewayTimeoutError? value)
        {
            TimeoutError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaDreamingError FromTimeoutError(global::Anthropic.BetaGatewayTimeoutError? value) => new BetaDreamingError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaDreamingError(global::Anthropic.BetaAPIError value) => new BetaDreamingError((global::Anthropic.BetaAPIError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaAPIError?(BetaDreamingError @this) => @this.ApiError;

        /// <summary>
        ///
        /// </summary>
        public BetaDreamingError(global::Anthropic.BetaAPIError? value)
        {
            ApiError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaDreamingError FromApiError(global::Anthropic.BetaAPIError? value) => new BetaDreamingError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaDreamingError(global::Anthropic.BetaOverloadedError value) => new BetaDreamingError((global::Anthropic.BetaOverloadedError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaOverloadedError?(BetaDreamingError @this) => @this.OverloadedError;

        /// <summary>
        ///
        /// </summary>
        public BetaDreamingError(global::Anthropic.BetaOverloadedError? value)
        {
            OverloadedError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaDreamingError FromOverloadedError(global::Anthropic.BetaOverloadedError? value) => new BetaDreamingError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaDreamingError(global::Anthropic.BetaTargetStoreHeldError value) => new BetaDreamingError((global::Anthropic.BetaTargetStoreHeldError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTargetStoreHeldError?(BetaDreamingError @this) => @this.ConflictError;

        /// <summary>
        ///
        /// </summary>
        public BetaDreamingError(global::Anthropic.BetaTargetStoreHeldError? value)
        {
            ConflictError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaDreamingError FromConflictError(global::Anthropic.BetaTargetStoreHeldError? value) => new BetaDreamingError(value);

        /// <summary>
        ///
        /// </summary>
        public BetaDreamingError(
            global::Anthropic.BetaDreamingErrorDiscriminatorType? type,
            global::Anthropic.BetaInvalidRequestError? invalidRequestError,
            global::Anthropic.BetaAuthenticationError? authenticationError,
            global::Anthropic.BetaBillingError? billingError,
            global::Anthropic.BetaPermissionError? permissionError,
            global::Anthropic.BetaNotFoundError? notFoundError,
            global::Anthropic.BetaRateLimitError? rateLimitError,
            global::Anthropic.BetaGatewayTimeoutError? timeoutError,
            global::Anthropic.BetaAPIError? apiError,
            global::Anthropic.BetaOverloadedError? overloadedError,
            global::Anthropic.BetaTargetStoreHeldError? conflictError
            )
        {
            Type = type;

            InvalidRequestError = invalidRequestError;
            AuthenticationError = authenticationError;
            BillingError = billingError;
            PermissionError = permissionError;
            NotFoundError = notFoundError;
            RateLimitError = rateLimitError;
            TimeoutError = timeoutError;
            ApiError = apiError;
            OverloadedError = overloadedError;
            ConflictError = conflictError;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ConflictError as object ??
            OverloadedError as object ??
            ApiError as object ??
            TimeoutError as object ??
            RateLimitError as object ??
            NotFoundError as object ??
            PermissionError as object ??
            BillingError as object ??
            AuthenticationError as object ??
            InvalidRequestError as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InvalidRequestError?.ToString() ??
            AuthenticationError?.ToString() ??
            BillingError?.ToString() ??
            PermissionError?.ToString() ??
            NotFoundError?.ToString() ??
            RateLimitError?.ToString() ??
            TimeoutError?.ToString() ??
            ApiError?.ToString() ??
            OverloadedError?.ToString() ??
            ConflictError?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError && !IsConflictError || !IsInvalidRequestError && IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError && !IsConflictError || !IsInvalidRequestError && !IsAuthenticationError && IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError && !IsConflictError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError && !IsConflictError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError && !IsConflictError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError && !IsConflictError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && IsTimeoutError && !IsApiError && !IsOverloadedError && !IsConflictError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && IsApiError && !IsOverloadedError && !IsConflictError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && IsOverloadedError && !IsConflictError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError && IsConflictError;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaInvalidRequestError, TResult>? invalidRequestError = null,
            global::System.Func<global::Anthropic.BetaAuthenticationError, TResult>? authenticationError = null,
            global::System.Func<global::Anthropic.BetaBillingError, TResult>? billingError = null,
            global::System.Func<global::Anthropic.BetaPermissionError, TResult>? permissionError = null,
            global::System.Func<global::Anthropic.BetaNotFoundError, TResult>? notFoundError = null,
            global::System.Func<global::Anthropic.BetaRateLimitError, TResult>? rateLimitError = null,
            global::System.Func<global::Anthropic.BetaGatewayTimeoutError, TResult>? timeoutError = null,
            global::System.Func<global::Anthropic.BetaAPIError, TResult>? apiError = null,
            global::System.Func<global::Anthropic.BetaOverloadedError, TResult>? overloadedError = null,
            global::System.Func<global::Anthropic.BetaTargetStoreHeldError, TResult>? conflictError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInvalidRequestError && invalidRequestError != null)
            {
                return invalidRequestError(InvalidRequestError!);
            }
            else if (IsAuthenticationError && authenticationError != null)
            {
                return authenticationError(AuthenticationError!);
            }
            else if (IsBillingError && billingError != null)
            {
                return billingError(BillingError!);
            }
            else if (IsPermissionError && permissionError != null)
            {
                return permissionError(PermissionError!);
            }
            else if (IsNotFoundError && notFoundError != null)
            {
                return notFoundError(NotFoundError!);
            }
            else if (IsRateLimitError && rateLimitError != null)
            {
                return rateLimitError(RateLimitError!);
            }
            else if (IsTimeoutError && timeoutError != null)
            {
                return timeoutError(TimeoutError!);
            }
            else if (IsApiError && apiError != null)
            {
                return apiError(ApiError!);
            }
            else if (IsOverloadedError && overloadedError != null)
            {
                return overloadedError(OverloadedError!);
            }
            else if (IsConflictError && conflictError != null)
            {
                return conflictError(ConflictError!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaInvalidRequestError>? invalidRequestError = null,

            global::System.Action<global::Anthropic.BetaAuthenticationError>? authenticationError = null,

            global::System.Action<global::Anthropic.BetaBillingError>? billingError = null,

            global::System.Action<global::Anthropic.BetaPermissionError>? permissionError = null,

            global::System.Action<global::Anthropic.BetaNotFoundError>? notFoundError = null,

            global::System.Action<global::Anthropic.BetaRateLimitError>? rateLimitError = null,

            global::System.Action<global::Anthropic.BetaGatewayTimeoutError>? timeoutError = null,

            global::System.Action<global::Anthropic.BetaAPIError>? apiError = null,

            global::System.Action<global::Anthropic.BetaOverloadedError>? overloadedError = null,

            global::System.Action<global::Anthropic.BetaTargetStoreHeldError>? conflictError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInvalidRequestError)
            {
                invalidRequestError?.Invoke(InvalidRequestError!);
            }
            else if (IsAuthenticationError)
            {
                authenticationError?.Invoke(AuthenticationError!);
            }
            else if (IsBillingError)
            {
                billingError?.Invoke(BillingError!);
            }
            else if (IsPermissionError)
            {
                permissionError?.Invoke(PermissionError!);
            }
            else if (IsNotFoundError)
            {
                notFoundError?.Invoke(NotFoundError!);
            }
            else if (IsRateLimitError)
            {
                rateLimitError?.Invoke(RateLimitError!);
            }
            else if (IsTimeoutError)
            {
                timeoutError?.Invoke(TimeoutError!);
            }
            else if (IsApiError)
            {
                apiError?.Invoke(ApiError!);
            }
            else if (IsOverloadedError)
            {
                overloadedError?.Invoke(OverloadedError!);
            }
            else if (IsConflictError)
            {
                conflictError?.Invoke(ConflictError!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaInvalidRequestError>? invalidRequestError = null,
            global::System.Action<global::Anthropic.BetaAuthenticationError>? authenticationError = null,
            global::System.Action<global::Anthropic.BetaBillingError>? billingError = null,
            global::System.Action<global::Anthropic.BetaPermissionError>? permissionError = null,
            global::System.Action<global::Anthropic.BetaNotFoundError>? notFoundError = null,
            global::System.Action<global::Anthropic.BetaRateLimitError>? rateLimitError = null,
            global::System.Action<global::Anthropic.BetaGatewayTimeoutError>? timeoutError = null,
            global::System.Action<global::Anthropic.BetaAPIError>? apiError = null,
            global::System.Action<global::Anthropic.BetaOverloadedError>? overloadedError = null,
            global::System.Action<global::Anthropic.BetaTargetStoreHeldError>? conflictError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInvalidRequestError)
            {
                invalidRequestError?.Invoke(InvalidRequestError!);
            }
            else if (IsAuthenticationError)
            {
                authenticationError?.Invoke(AuthenticationError!);
            }
            else if (IsBillingError)
            {
                billingError?.Invoke(BillingError!);
            }
            else if (IsPermissionError)
            {
                permissionError?.Invoke(PermissionError!);
            }
            else if (IsNotFoundError)
            {
                notFoundError?.Invoke(NotFoundError!);
            }
            else if (IsRateLimitError)
            {
                rateLimitError?.Invoke(RateLimitError!);
            }
            else if (IsTimeoutError)
            {
                timeoutError?.Invoke(TimeoutError!);
            }
            else if (IsApiError)
            {
                apiError?.Invoke(ApiError!);
            }
            else if (IsOverloadedError)
            {
                overloadedError?.Invoke(OverloadedError!);
            }
            else if (IsConflictError)
            {
                conflictError?.Invoke(ConflictError!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InvalidRequestError,
                typeof(global::Anthropic.BetaInvalidRequestError),
                AuthenticationError,
                typeof(global::Anthropic.BetaAuthenticationError),
                BillingError,
                typeof(global::Anthropic.BetaBillingError),
                PermissionError,
                typeof(global::Anthropic.BetaPermissionError),
                NotFoundError,
                typeof(global::Anthropic.BetaNotFoundError),
                RateLimitError,
                typeof(global::Anthropic.BetaRateLimitError),
                TimeoutError,
                typeof(global::Anthropic.BetaGatewayTimeoutError),
                ApiError,
                typeof(global::Anthropic.BetaAPIError),
                OverloadedError,
                typeof(global::Anthropic.BetaOverloadedError),
                ConflictError,
                typeof(global::Anthropic.BetaTargetStoreHeldError),
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
        public bool Equals(BetaDreamingError other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaInvalidRequestError?>.Default.Equals(InvalidRequestError, other.InvalidRequestError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaAuthenticationError?>.Default.Equals(AuthenticationError, other.AuthenticationError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBillingError?>.Default.Equals(BillingError, other.BillingError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaPermissionError?>.Default.Equals(PermissionError, other.PermissionError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaNotFoundError?>.Default.Equals(NotFoundError, other.NotFoundError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRateLimitError?>.Default.Equals(RateLimitError, other.RateLimitError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaGatewayTimeoutError?>.Default.Equals(TimeoutError, other.TimeoutError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaAPIError?>.Default.Equals(ApiError, other.ApiError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaOverloadedError?>.Default.Equals(OverloadedError, other.OverloadedError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTargetStoreHeldError?>.Default.Equals(ConflictError, other.ConflictError)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaDreamingError obj1, BetaDreamingError obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaDreamingError>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaDreamingError obj1, BetaDreamingError obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaDreamingError o && Equals(o);
        }
    }
}
