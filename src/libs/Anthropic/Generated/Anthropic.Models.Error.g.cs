#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Error : global::System.IEquatable<Error>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaErrorResponseErrorDiscriminatorType? Type { get; }

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
        public static implicit operator Error(global::Anthropic.BetaInvalidRequestError value) => new Error(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaInvalidRequestError?(Error @this) => @this.InvalidRequestError;

        /// <summary>
        /// 
        /// </summary>
        public Error(global::Anthropic.BetaInvalidRequestError? value)
        {
            InvalidRequestError = value;
        }

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
        public static implicit operator Error(global::Anthropic.BetaAuthenticationError value) => new Error(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaAuthenticationError?(Error @this) => @this.AuthenticationError;

        /// <summary>
        /// 
        /// </summary>
        public Error(global::Anthropic.BetaAuthenticationError? value)
        {
            AuthenticationError = value;
        }

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
        public static implicit operator Error(global::Anthropic.BetaBillingError value) => new Error(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaBillingError?(Error @this) => @this.BillingError;

        /// <summary>
        /// 
        /// </summary>
        public Error(global::Anthropic.BetaBillingError? value)
        {
            BillingError = value;
        }

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
        public static implicit operator Error(global::Anthropic.BetaPermissionError value) => new Error(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaPermissionError?(Error @this) => @this.PermissionError;

        /// <summary>
        /// 
        /// </summary>
        public Error(global::Anthropic.BetaPermissionError? value)
        {
            PermissionError = value;
        }

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
        public static implicit operator Error(global::Anthropic.BetaNotFoundError value) => new Error(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaNotFoundError?(Error @this) => @this.NotFoundError;

        /// <summary>
        /// 
        /// </summary>
        public Error(global::Anthropic.BetaNotFoundError? value)
        {
            NotFoundError = value;
        }

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
        public static implicit operator Error(global::Anthropic.BetaRateLimitError value) => new Error(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRateLimitError?(Error @this) => @this.RateLimitError;

        /// <summary>
        /// 
        /// </summary>
        public Error(global::Anthropic.BetaRateLimitError? value)
        {
            RateLimitError = value;
        }

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
        public static implicit operator Error(global::Anthropic.BetaGatewayTimeoutError value) => new Error(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaGatewayTimeoutError?(Error @this) => @this.TimeoutError;

        /// <summary>
        /// 
        /// </summary>
        public Error(global::Anthropic.BetaGatewayTimeoutError? value)
        {
            TimeoutError = value;
        }

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
        public static implicit operator Error(global::Anthropic.BetaAPIError value) => new Error(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaAPIError?(Error @this) => @this.ApiError;

        /// <summary>
        /// 
        /// </summary>
        public Error(global::Anthropic.BetaAPIError? value)
        {
            ApiError = value;
        }

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
        public static implicit operator Error(global::Anthropic.BetaOverloadedError value) => new Error(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaOverloadedError?(Error @this) => @this.OverloadedError;

        /// <summary>
        /// 
        /// </summary>
        public Error(global::Anthropic.BetaOverloadedError? value)
        {
            OverloadedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Error(
            global::Anthropic.BetaErrorResponseErrorDiscriminatorType? type,
            global::Anthropic.BetaInvalidRequestError? invalidRequestError,
            global::Anthropic.BetaAuthenticationError? authenticationError,
            global::Anthropic.BetaBillingError? billingError,
            global::Anthropic.BetaPermissionError? permissionError,
            global::Anthropic.BetaNotFoundError? notFoundError,
            global::Anthropic.BetaRateLimitError? rateLimitError,
            global::Anthropic.BetaGatewayTimeoutError? timeoutError,
            global::Anthropic.BetaAPIError? apiError,
            global::Anthropic.BetaOverloadedError? overloadedError
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
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
        public bool Validate()
        {
            return IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError || !IsInvalidRequestError && IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError || !IsInvalidRequestError && !IsAuthenticationError && IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && IsRateLimitError && !IsTimeoutError && !IsApiError && !IsOverloadedError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && IsTimeoutError && !IsApiError && !IsOverloadedError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && IsApiError && !IsOverloadedError || !IsInvalidRequestError && !IsAuthenticationError && !IsBillingError && !IsPermissionError && !IsNotFoundError && !IsRateLimitError && !IsTimeoutError && !IsApiError && IsOverloadedError;
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
        public bool Equals(Error other)
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaOverloadedError?>.Default.Equals(OverloadedError, other.OverloadedError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Error obj1, Error obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Error>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Error obj1, Error obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Error o && Equals(o);
        }
    }
}
