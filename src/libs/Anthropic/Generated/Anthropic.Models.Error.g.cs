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
        public global::Anthropic.BetaInvalidRequestError PickInvalidRequestError() => InvalidRequestError is { } value
            ? value
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
        public global::Anthropic.BetaAuthenticationError PickAuthenticationError() => AuthenticationError is { } value
            ? value
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
        public global::Anthropic.BetaBillingError PickBillingError() => BillingError is { } value
            ? value
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
        public global::Anthropic.BetaPermissionError PickPermissionError() => PermissionError is { } value
            ? value
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
        public global::Anthropic.BetaNotFoundError PickNotFoundError() => NotFoundError is { } value
            ? value
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
        public global::Anthropic.BetaRateLimitError PickRateLimitError() => RateLimitError is { } value
            ? value
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
        public global::Anthropic.BetaGatewayTimeoutError PickTimeoutError() => TimeoutError is { } value
            ? value
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
        public global::Anthropic.BetaAPIError PickApiError() => ApiError is { } value
            ? value
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
        public global::Anthropic.BetaOverloadedError PickOverloadedError() => OverloadedError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OverloadedError' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Error(global::Anthropic.BetaInvalidRequestError value) => new Error((global::Anthropic.BetaInvalidRequestError?)value);

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
        public static Error FromInvalidRequestError(global::Anthropic.BetaInvalidRequestError? value) => new Error(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Error(global::Anthropic.BetaAuthenticationError value) => new Error((global::Anthropic.BetaAuthenticationError?)value);

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
        public static Error FromAuthenticationError(global::Anthropic.BetaAuthenticationError? value) => new Error(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Error(global::Anthropic.BetaBillingError value) => new Error((global::Anthropic.BetaBillingError?)value);

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
        public static Error FromBillingError(global::Anthropic.BetaBillingError? value) => new Error(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Error(global::Anthropic.BetaPermissionError value) => new Error((global::Anthropic.BetaPermissionError?)value);

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
        public static Error FromPermissionError(global::Anthropic.BetaPermissionError? value) => new Error(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Error(global::Anthropic.BetaNotFoundError value) => new Error((global::Anthropic.BetaNotFoundError?)value);

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
        public static Error FromNotFoundError(global::Anthropic.BetaNotFoundError? value) => new Error(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Error(global::Anthropic.BetaRateLimitError value) => new Error((global::Anthropic.BetaRateLimitError?)value);

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
        public static Error FromRateLimitError(global::Anthropic.BetaRateLimitError? value) => new Error(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Error(global::Anthropic.BetaGatewayTimeoutError value) => new Error((global::Anthropic.BetaGatewayTimeoutError?)value);

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
        public static Error FromTimeoutError(global::Anthropic.BetaGatewayTimeoutError? value) => new Error(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Error(global::Anthropic.BetaAPIError value) => new Error((global::Anthropic.BetaAPIError?)value);

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
        public static Error FromApiError(global::Anthropic.BetaAPIError? value) => new Error(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Error(global::Anthropic.BetaOverloadedError value) => new Error((global::Anthropic.BetaOverloadedError?)value);

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
        public static Error FromOverloadedError(global::Anthropic.BetaOverloadedError? value) => new Error(value);

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
            global::System.Func<global::Anthropic.BetaInvalidRequestError, TResult>? invalidRequestError = null,
            global::System.Func<global::Anthropic.BetaAuthenticationError, TResult>? authenticationError = null,
            global::System.Func<global::Anthropic.BetaBillingError, TResult>? billingError = null,
            global::System.Func<global::Anthropic.BetaPermissionError, TResult>? permissionError = null,
            global::System.Func<global::Anthropic.BetaNotFoundError, TResult>? notFoundError = null,
            global::System.Func<global::Anthropic.BetaRateLimitError, TResult>? rateLimitError = null,
            global::System.Func<global::Anthropic.BetaGatewayTimeoutError, TResult>? timeoutError = null,
            global::System.Func<global::Anthropic.BetaAPIError, TResult>? apiError = null,
            global::System.Func<global::Anthropic.BetaOverloadedError, TResult>? overloadedError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InvalidRequestError is { } __value0 && invalidRequestError != null)
            {
                return invalidRequestError(__value0);
            }
            else if (AuthenticationError is { } __value1 && authenticationError != null)
            {
                return authenticationError(__value1);
            }
            else if (BillingError is { } __value2 && billingError != null)
            {
                return billingError(__value2);
            }
            else if (PermissionError is { } __value3 && permissionError != null)
            {
                return permissionError(__value3);
            }
            else if (NotFoundError is { } __value4 && notFoundError != null)
            {
                return notFoundError(__value4);
            }
            else if (RateLimitError is { } __value5 && rateLimitError != null)
            {
                return rateLimitError(__value5);
            }
            else if (TimeoutError is { } __value6 && timeoutError != null)
            {
                return timeoutError(__value6);
            }
            else if (ApiError is { } __value7 && apiError != null)
            {
                return apiError(__value7);
            }
            else if (OverloadedError is { } __value8 && overloadedError != null)
            {
                return overloadedError(__value8);
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
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InvalidRequestError is { } __value0)
            {
                invalidRequestError?.Invoke(__value0);
            }
            else if (AuthenticationError is { } __value1)
            {
                authenticationError?.Invoke(__value1);
            }
            else if (BillingError is { } __value2)
            {
                billingError?.Invoke(__value2);
            }
            else if (PermissionError is { } __value3)
            {
                permissionError?.Invoke(__value3);
            }
            else if (NotFoundError is { } __value4)
            {
                notFoundError?.Invoke(__value4);
            }
            else if (RateLimitError is { } __value5)
            {
                rateLimitError?.Invoke(__value5);
            }
            else if (TimeoutError is { } __value6)
            {
                timeoutError?.Invoke(__value6);
            }
            else if (ApiError is { } __value7)
            {
                apiError?.Invoke(__value7);
            }
            else if (OverloadedError is { } __value8)
            {
                overloadedError?.Invoke(__value8);
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
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InvalidRequestError is { } __value0)
            {
                invalidRequestError?.Invoke(__value0);
            }
            else if (AuthenticationError is { } __value1)
            {
                authenticationError?.Invoke(__value1);
            }
            else if (BillingError is { } __value2)
            {
                billingError?.Invoke(__value2);
            }
            else if (PermissionError is { } __value3)
            {
                permissionError?.Invoke(__value3);
            }
            else if (NotFoundError is { } __value4)
            {
                notFoundError?.Invoke(__value4);
            }
            else if (RateLimitError is { } __value5)
            {
                rateLimitError?.Invoke(__value5);
            }
            else if (TimeoutError is { } __value6)
            {
                timeoutError?.Invoke(__value6);
            }
            else if (ApiError is { } __value7)
            {
                apiError?.Invoke(__value7);
            }
            else if (OverloadedError is { } __value8)
            {
                overloadedError?.Invoke(__value8);
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
