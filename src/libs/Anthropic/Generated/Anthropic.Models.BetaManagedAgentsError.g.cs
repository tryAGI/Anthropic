#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaManagedAgentsError : global::System.IEquatable<BetaManagedAgentsError>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorDiscriminatorType? Type { get; }

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
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMemoryPreconditionFailedError? MemoryPreconditionFailedError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMemoryPreconditionFailedError? MemoryPreconditionFailedError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MemoryPreconditionFailedError))]
#endif
        public bool IsMemoryPreconditionFailedError => MemoryPreconditionFailedError != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMemoryPathConflictError? MemoryPathConflictError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMemoryPathConflictError? MemoryPathConflictError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MemoryPathConflictError))]
#endif
        public bool IsMemoryPathConflictError => MemoryPathConflictError != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsConflictError? ConflictError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsConflictError? ConflictError { get; }
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
        public static implicit operator BetaManagedAgentsError(global::Anthropic.BetaInvalidRequestError value) => new BetaManagedAgentsError((global::Anthropic.BetaInvalidRequestError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaInvalidRequestError?(BetaManagedAgentsError @this) => @this.InvalidRequestError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsError(global::Anthropic.BetaInvalidRequestError? value)
        {
            InvalidRequestError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsError(global::Anthropic.BetaAuthenticationError value) => new BetaManagedAgentsError((global::Anthropic.BetaAuthenticationError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaAuthenticationError?(BetaManagedAgentsError @this) => @this.AuthenticationError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsError(global::Anthropic.BetaAuthenticationError? value)
        {
            AuthenticationError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsError(global::Anthropic.BetaBillingError value) => new BetaManagedAgentsError((global::Anthropic.BetaBillingError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaBillingError?(BetaManagedAgentsError @this) => @this.BillingError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsError(global::Anthropic.BetaBillingError? value)
        {
            BillingError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsError(global::Anthropic.BetaPermissionError value) => new BetaManagedAgentsError((global::Anthropic.BetaPermissionError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaPermissionError?(BetaManagedAgentsError @this) => @this.PermissionError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsError(global::Anthropic.BetaPermissionError? value)
        {
            PermissionError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsError(global::Anthropic.BetaNotFoundError value) => new BetaManagedAgentsError((global::Anthropic.BetaNotFoundError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaNotFoundError?(BetaManagedAgentsError @this) => @this.NotFoundError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsError(global::Anthropic.BetaNotFoundError? value)
        {
            NotFoundError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsError(global::Anthropic.BetaRateLimitError value) => new BetaManagedAgentsError((global::Anthropic.BetaRateLimitError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRateLimitError?(BetaManagedAgentsError @this) => @this.RateLimitError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsError(global::Anthropic.BetaRateLimitError? value)
        {
            RateLimitError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsError(global::Anthropic.BetaGatewayTimeoutError value) => new BetaManagedAgentsError((global::Anthropic.BetaGatewayTimeoutError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaGatewayTimeoutError?(BetaManagedAgentsError @this) => @this.TimeoutError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsError(global::Anthropic.BetaGatewayTimeoutError? value)
        {
            TimeoutError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsError(global::Anthropic.BetaAPIError value) => new BetaManagedAgentsError((global::Anthropic.BetaAPIError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaAPIError?(BetaManagedAgentsError @this) => @this.ApiError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsError(global::Anthropic.BetaAPIError? value)
        {
            ApiError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsError(global::Anthropic.BetaOverloadedError value) => new BetaManagedAgentsError((global::Anthropic.BetaOverloadedError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaOverloadedError?(BetaManagedAgentsError @this) => @this.OverloadedError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsError(global::Anthropic.BetaOverloadedError? value)
        {
            OverloadedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsError(global::Anthropic.BetaManagedAgentsMemoryPreconditionFailedError value) => new BetaManagedAgentsError((global::Anthropic.BetaManagedAgentsMemoryPreconditionFailedError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMemoryPreconditionFailedError?(BetaManagedAgentsError @this) => @this.MemoryPreconditionFailedError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsError(global::Anthropic.BetaManagedAgentsMemoryPreconditionFailedError? value)
        {
            MemoryPreconditionFailedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsError(global::Anthropic.BetaManagedAgentsMemoryPathConflictError value) => new BetaManagedAgentsError((global::Anthropic.BetaManagedAgentsMemoryPathConflictError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMemoryPathConflictError?(BetaManagedAgentsError @this) => @this.MemoryPathConflictError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsError(global::Anthropic.BetaManagedAgentsMemoryPathConflictError? value)
        {
            MemoryPathConflictError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsError(global::Anthropic.BetaManagedAgentsConflictError value) => new BetaManagedAgentsError((global::Anthropic.BetaManagedAgentsConflictError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsConflictError?(BetaManagedAgentsError @this) => @this.ConflictError;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsError(global::Anthropic.BetaManagedAgentsConflictError? value)
        {
            ConflictError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsError(
            global::Anthropic.BetaManagedAgentsErrorDiscriminatorType? type,
            global::Anthropic.BetaInvalidRequestError? invalidRequestError,
            global::Anthropic.BetaAuthenticationError? authenticationError,
            global::Anthropic.BetaBillingError? billingError,
            global::Anthropic.BetaPermissionError? permissionError,
            global::Anthropic.BetaNotFoundError? notFoundError,
            global::Anthropic.BetaRateLimitError? rateLimitError,
            global::Anthropic.BetaGatewayTimeoutError? timeoutError,
            global::Anthropic.BetaAPIError? apiError,
            global::Anthropic.BetaOverloadedError? overloadedError,
            global::Anthropic.BetaManagedAgentsMemoryPreconditionFailedError? memoryPreconditionFailedError,
            global::Anthropic.BetaManagedAgentsMemoryPathConflictError? memoryPathConflictError,
            global::Anthropic.BetaManagedAgentsConflictError? conflictError
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
            MemoryPreconditionFailedError = memoryPreconditionFailedError;
            MemoryPathConflictError = memoryPathConflictError;
            ConflictError = conflictError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConflictError as object ??
            MemoryPathConflictError as object ??
            MemoryPreconditionFailedError as object ??
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
            MemoryPreconditionFailedError?.ToString() ??
            MemoryPathConflictError?.ToString() ??
            ConflictError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError && !IsMemoryPreconditionFailedError && !IsMemoryPathConflictError && !IsConflictError || !IsInvalidRequestError && IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError && !IsMemoryPreconditionFailedError && !IsMemoryPathConflictError && !IsConflictError || !IsInvalidRequestError && !IsAuthenticationError && IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError && !IsMemoryPreconditionFailedError && !IsMemoryPathConflictError && !IsConflictError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError && !IsMemoryPreconditionFailedError && !IsMemoryPathConflictError && !IsConflictError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError && !IsMemoryPreconditionFailedError && !IsMemoryPathConflictError && !IsConflictError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError && !IsMemoryPreconditionFailedError && !IsMemoryPathConflictError && !IsConflictError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && IsTimeoutError && !IsApiError && !IsOverloadedError && !IsMemoryPreconditionFailedError && !IsMemoryPathConflictError && !IsConflictError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && IsApiError && !IsOverloadedError && !IsMemoryPreconditionFailedError && !IsMemoryPathConflictError && !IsConflictError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && IsOverloadedError && !IsMemoryPreconditionFailedError && !IsMemoryPathConflictError && !IsConflictError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError && IsMemoryPreconditionFailedError && !IsMemoryPathConflictError && !IsConflictError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError && !IsMemoryPreconditionFailedError && IsMemoryPathConflictError && !IsConflictError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError && !IsMemoryPreconditionFailedError && !IsMemoryPathConflictError && IsConflictError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaInvalidRequestError?, TResult>? invalidRequestError = null,
            global::System.Func<global::Anthropic.BetaAuthenticationError?, TResult>? authenticationError = null,
            global::System.Func<global::Anthropic.BetaBillingError?, TResult>? billingError = null,
            global::System.Func<global::Anthropic.BetaPermissionError?, TResult>? permissionError = null,
            global::System.Func<global::Anthropic.BetaNotFoundError?, TResult>? notFoundError = null,
            global::System.Func<global::Anthropic.BetaRateLimitError?, TResult>? rateLimitError = null,
            global::System.Func<global::Anthropic.BetaGatewayTimeoutError?, TResult>? timeoutError = null,
            global::System.Func<global::Anthropic.BetaAPIError?, TResult>? apiError = null,
            global::System.Func<global::Anthropic.BetaOverloadedError?, TResult>? overloadedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMemoryPreconditionFailedError?, TResult>? memoryPreconditionFailedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMemoryPathConflictError?, TResult>? memoryPathConflictError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsConflictError?, TResult>? conflictError = null,
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
            else if (IsMemoryPreconditionFailedError && memoryPreconditionFailedError != null)
            {
                return memoryPreconditionFailedError(MemoryPreconditionFailedError!);
            }
            else if (IsMemoryPathConflictError && memoryPathConflictError != null)
            {
                return memoryPathConflictError(MemoryPathConflictError!);
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
            global::System.Action<global::Anthropic.BetaInvalidRequestError?>? invalidRequestError = null,
            global::System.Action<global::Anthropic.BetaAuthenticationError?>? authenticationError = null,
            global::System.Action<global::Anthropic.BetaBillingError?>? billingError = null,
            global::System.Action<global::Anthropic.BetaPermissionError?>? permissionError = null,
            global::System.Action<global::Anthropic.BetaNotFoundError?>? notFoundError = null,
            global::System.Action<global::Anthropic.BetaRateLimitError?>? rateLimitError = null,
            global::System.Action<global::Anthropic.BetaGatewayTimeoutError?>? timeoutError = null,
            global::System.Action<global::Anthropic.BetaAPIError?>? apiError = null,
            global::System.Action<global::Anthropic.BetaOverloadedError?>? overloadedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMemoryPreconditionFailedError?>? memoryPreconditionFailedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMemoryPathConflictError?>? memoryPathConflictError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsConflictError?>? conflictError = null,
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
            else if (IsMemoryPreconditionFailedError)
            {
                memoryPreconditionFailedError?.Invoke(MemoryPreconditionFailedError!);
            }
            else if (IsMemoryPathConflictError)
            {
                memoryPathConflictError?.Invoke(MemoryPathConflictError!);
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
                MemoryPreconditionFailedError,
                typeof(global::Anthropic.BetaManagedAgentsMemoryPreconditionFailedError),
                MemoryPathConflictError,
                typeof(global::Anthropic.BetaManagedAgentsMemoryPathConflictError),
                ConflictError,
                typeof(global::Anthropic.BetaManagedAgentsConflictError),
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
        public bool Equals(BetaManagedAgentsError other)
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMemoryPreconditionFailedError?>.Default.Equals(MemoryPreconditionFailedError, other.MemoryPreconditionFailedError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMemoryPathConflictError?>.Default.Equals(MemoryPathConflictError, other.MemoryPathConflictError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsConflictError?>.Default.Equals(ConflictError, other.ConflictError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsError obj1, BetaManagedAgentsError obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsError>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsError obj1, BetaManagedAgentsError obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsError o && Equals(o);
        }
    }
}
