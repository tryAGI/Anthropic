#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Error2 : global::System.IEquatable<Error2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ErrorResponseErrorDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.InvalidRequestError? InvalidRequestError { get; init; }
#else
        public global::Anthropic.InvalidRequestError? InvalidRequestError { get; }
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
        public static implicit operator Error2(global::Anthropic.InvalidRequestError value) => new Error2((global::Anthropic.InvalidRequestError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.InvalidRequestError?(Error2 @this) => @this.InvalidRequestError;

        /// <summary>
        /// 
        /// </summary>
        public Error2(global::Anthropic.InvalidRequestError? value)
        {
            InvalidRequestError = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.AuthenticationError? AuthenticationError { get; init; }
#else
        public global::Anthropic.AuthenticationError? AuthenticationError { get; }
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
        public static implicit operator Error2(global::Anthropic.AuthenticationError value) => new Error2((global::Anthropic.AuthenticationError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.AuthenticationError?(Error2 @this) => @this.AuthenticationError;

        /// <summary>
        /// 
        /// </summary>
        public Error2(global::Anthropic.AuthenticationError? value)
        {
            AuthenticationError = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BillingError? BillingError { get; init; }
#else
        public global::Anthropic.BillingError? BillingError { get; }
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
        public static implicit operator Error2(global::Anthropic.BillingError value) => new Error2((global::Anthropic.BillingError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BillingError?(Error2 @this) => @this.BillingError;

        /// <summary>
        /// 
        /// </summary>
        public Error2(global::Anthropic.BillingError? value)
        {
            BillingError = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.PermissionError? PermissionError { get; init; }
#else
        public global::Anthropic.PermissionError? PermissionError { get; }
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
        public static implicit operator Error2(global::Anthropic.PermissionError value) => new Error2((global::Anthropic.PermissionError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.PermissionError?(Error2 @this) => @this.PermissionError;

        /// <summary>
        /// 
        /// </summary>
        public Error2(global::Anthropic.PermissionError? value)
        {
            PermissionError = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.NotFoundError? NotFoundError { get; init; }
#else
        public global::Anthropic.NotFoundError? NotFoundError { get; }
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
        public static implicit operator Error2(global::Anthropic.NotFoundError value) => new Error2((global::Anthropic.NotFoundError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.NotFoundError?(Error2 @this) => @this.NotFoundError;

        /// <summary>
        /// 
        /// </summary>
        public Error2(global::Anthropic.NotFoundError? value)
        {
            NotFoundError = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RateLimitError? RateLimitError { get; init; }
#else
        public global::Anthropic.RateLimitError? RateLimitError { get; }
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
        public static implicit operator Error2(global::Anthropic.RateLimitError value) => new Error2((global::Anthropic.RateLimitError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RateLimitError?(Error2 @this) => @this.RateLimitError;

        /// <summary>
        /// 
        /// </summary>
        public Error2(global::Anthropic.RateLimitError? value)
        {
            RateLimitError = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.GatewayTimeoutError? TimeoutError { get; init; }
#else
        public global::Anthropic.GatewayTimeoutError? TimeoutError { get; }
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
        public static implicit operator Error2(global::Anthropic.GatewayTimeoutError value) => new Error2((global::Anthropic.GatewayTimeoutError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.GatewayTimeoutError?(Error2 @this) => @this.TimeoutError;

        /// <summary>
        /// 
        /// </summary>
        public Error2(global::Anthropic.GatewayTimeoutError? value)
        {
            TimeoutError = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.APIError? ApiError { get; init; }
#else
        public global::Anthropic.APIError? ApiError { get; }
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
        public static implicit operator Error2(global::Anthropic.APIError value) => new Error2((global::Anthropic.APIError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.APIError?(Error2 @this) => @this.ApiError;

        /// <summary>
        /// 
        /// </summary>
        public Error2(global::Anthropic.APIError? value)
        {
            ApiError = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.OverloadedError? OverloadedError { get; init; }
#else
        public global::Anthropic.OverloadedError? OverloadedError { get; }
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
        public static implicit operator Error2(global::Anthropic.OverloadedError value) => new Error2((global::Anthropic.OverloadedError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.OverloadedError?(Error2 @this) => @this.OverloadedError;

        /// <summary>
        /// 
        /// </summary>
        public Error2(global::Anthropic.OverloadedError? value)
        {
            OverloadedError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Error2(
            global::Anthropic.ErrorResponseErrorDiscriminatorType? type,
            global::Anthropic.InvalidRequestError? invalidRequestError,
            global::Anthropic.AuthenticationError? authenticationError,
            global::Anthropic.BillingError? billingError,
            global::Anthropic.PermissionError? permissionError,
            global::Anthropic.NotFoundError? notFoundError,
            global::Anthropic.RateLimitError? rateLimitError,
            global::Anthropic.GatewayTimeoutError? timeoutError,
            global::Anthropic.APIError? apiError,
            global::Anthropic.OverloadedError? overloadedError
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
        public override string? ToString() =>
            InvalidRequestError?.ToString() ??
            AuthenticationError?.ToString() ??
            BillingError?.ToString() ??
            PermissionError?.ToString() ??
            NotFoundError?.ToString() ??
            RateLimitError?.ToString() ??
            TimeoutError?.ToString() ??
            ApiError?.ToString() ??
            OverloadedError?.ToString() 
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
            global::System.Func<global::Anthropic.InvalidRequestError?, TResult>? invalidRequestError = null,
            global::System.Func<global::Anthropic.AuthenticationError?, TResult>? authenticationError = null,
            global::System.Func<global::Anthropic.BillingError?, TResult>? billingError = null,
            global::System.Func<global::Anthropic.PermissionError?, TResult>? permissionError = null,
            global::System.Func<global::Anthropic.NotFoundError?, TResult>? notFoundError = null,
            global::System.Func<global::Anthropic.RateLimitError?, TResult>? rateLimitError = null,
            global::System.Func<global::Anthropic.GatewayTimeoutError?, TResult>? timeoutError = null,
            global::System.Func<global::Anthropic.APIError?, TResult>? apiError = null,
            global::System.Func<global::Anthropic.OverloadedError?, TResult>? overloadedError = null,
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
            global::System.Action<global::Anthropic.InvalidRequestError?>? invalidRequestError = null,
            global::System.Action<global::Anthropic.AuthenticationError?>? authenticationError = null,
            global::System.Action<global::Anthropic.BillingError?>? billingError = null,
            global::System.Action<global::Anthropic.PermissionError?>? permissionError = null,
            global::System.Action<global::Anthropic.NotFoundError?>? notFoundError = null,
            global::System.Action<global::Anthropic.RateLimitError?>? rateLimitError = null,
            global::System.Action<global::Anthropic.GatewayTimeoutError?>? timeoutError = null,
            global::System.Action<global::Anthropic.APIError?>? apiError = null,
            global::System.Action<global::Anthropic.OverloadedError?>? overloadedError = null,
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
                typeof(global::Anthropic.InvalidRequestError),
                AuthenticationError,
                typeof(global::Anthropic.AuthenticationError),
                BillingError,
                typeof(global::Anthropic.BillingError),
                PermissionError,
                typeof(global::Anthropic.PermissionError),
                NotFoundError,
                typeof(global::Anthropic.NotFoundError),
                RateLimitError,
                typeof(global::Anthropic.RateLimitError),
                TimeoutError,
                typeof(global::Anthropic.GatewayTimeoutError),
                ApiError,
                typeof(global::Anthropic.APIError),
                OverloadedError,
                typeof(global::Anthropic.OverloadedError),
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
        public bool Equals(Error2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.InvalidRequestError?>.Default.Equals(InvalidRequestError, other.InvalidRequestError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.AuthenticationError?>.Default.Equals(AuthenticationError, other.AuthenticationError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BillingError?>.Default.Equals(BillingError, other.BillingError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.PermissionError?>.Default.Equals(PermissionError, other.PermissionError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.NotFoundError?>.Default.Equals(NotFoundError, other.NotFoundError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RateLimitError?>.Default.Equals(RateLimitError, other.RateLimitError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.GatewayTimeoutError?>.Default.Equals(TimeoutError, other.TimeoutError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.APIError?>.Default.Equals(ApiError, other.ApiError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.OverloadedError?>.Default.Equals(OverloadedError, other.OverloadedError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Error2 obj1, Error2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Error2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Error2 obj1, Error2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Error2 o && Equals(o);
        }
    }
}
