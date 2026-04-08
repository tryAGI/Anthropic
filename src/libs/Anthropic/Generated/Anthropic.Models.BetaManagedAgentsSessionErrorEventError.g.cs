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
        public BetaManagedAgentsSessionErrorEventError(
            global::Anthropic.BetaManagedAgentsSessionErrorEventErrorDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsUnknownError? unknownError,
            global::Anthropic.BetaManagedAgentsModelOverloadedError? modelOverloadedError,
            global::Anthropic.BetaManagedAgentsModelRateLimitedError? modelRateLimitedError,
            global::Anthropic.BetaManagedAgentsModelRequestFailedError? modelRequestFailedError,
            global::Anthropic.BetaManagedAgentsMcpConnectionFailedError? mcpConnectionFailedError,
            global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError? mcpAuthenticationFailedError,
            global::Anthropic.BetaManagedAgentsBillingError? billingError
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
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            BillingError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUnknownError && !IsModelOverloadedError && !IsModelRateLimitedError && !IsModelRequestFailedError && !IsMcpConnectionFailedError && !IsMcpAuthenticationFailedError && !IsBillingError || !IsUnknownError && IsModelOverloadedError && !IsModelRateLimitedError && !IsModelRequestFailedError && !IsMcpConnectionFailedError && !IsMcpAuthenticationFailedError && !IsBillingError || !IsUnknownError && !IsModelOverloadedError && IsModelRateLimitedError && !IsModelRequestFailedError && !IsMcpConnectionFailedError && !IsMcpAuthenticationFailedError && !IsBillingError || !IsUnknownError && !IsModelOverloadedError && !IsModelRateLimitedError && IsModelRequestFailedError && !IsMcpConnectionFailedError && !IsMcpAuthenticationFailedError && !IsBillingError || !IsUnknownError && !IsModelOverloadedError && !IsModelRateLimitedError && !IsModelRequestFailedError && IsMcpConnectionFailedError && !IsMcpAuthenticationFailedError && !IsBillingError || !IsUnknownError && !IsModelOverloadedError && !IsModelRateLimitedError && !IsModelRequestFailedError && !IsMcpConnectionFailedError && IsMcpAuthenticationFailedError && !IsBillingError || !IsUnknownError && !IsModelOverloadedError && !IsModelRateLimitedError && !IsModelRequestFailedError && !IsMcpConnectionFailedError && !IsMcpAuthenticationFailedError && IsBillingError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsUnknownError?, TResult>? unknownError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsModelOverloadedError?, TResult>? modelOverloadedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsModelRateLimitedError?, TResult>? modelRateLimitedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsModelRequestFailedError?, TResult>? modelRequestFailedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMcpConnectionFailedError?, TResult>? mcpConnectionFailedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError?, TResult>? mcpAuthenticationFailedError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsBillingError?, TResult>? billingError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnknownError && unknownError != null)
            {
                return unknownError(UnknownError!);
            }
            else if (IsModelOverloadedError && modelOverloadedError != null)
            {
                return modelOverloadedError(ModelOverloadedError!);
            }
            else if (IsModelRateLimitedError && modelRateLimitedError != null)
            {
                return modelRateLimitedError(ModelRateLimitedError!);
            }
            else if (IsModelRequestFailedError && modelRequestFailedError != null)
            {
                return modelRequestFailedError(ModelRequestFailedError!);
            }
            else if (IsMcpConnectionFailedError && mcpConnectionFailedError != null)
            {
                return mcpConnectionFailedError(McpConnectionFailedError!);
            }
            else if (IsMcpAuthenticationFailedError && mcpAuthenticationFailedError != null)
            {
                return mcpAuthenticationFailedError(McpAuthenticationFailedError!);
            }
            else if (IsBillingError && billingError != null)
            {
                return billingError(BillingError!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsUnknownError?>? unknownError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsModelOverloadedError?>? modelOverloadedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsModelRateLimitedError?>? modelRateLimitedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsModelRequestFailedError?>? modelRequestFailedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMcpConnectionFailedError?>? mcpConnectionFailedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMcpAuthenticationFailedError?>? mcpAuthenticationFailedError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsBillingError?>? billingError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnknownError)
            {
                unknownError?.Invoke(UnknownError!);
            }
            else if (IsModelOverloadedError)
            {
                modelOverloadedError?.Invoke(ModelOverloadedError!);
            }
            else if (IsModelRateLimitedError)
            {
                modelRateLimitedError?.Invoke(ModelRateLimitedError!);
            }
            else if (IsModelRequestFailedError)
            {
                modelRequestFailedError?.Invoke(ModelRequestFailedError!);
            }
            else if (IsMcpConnectionFailedError)
            {
                mcpConnectionFailedError?.Invoke(McpConnectionFailedError!);
            }
            else if (IsMcpAuthenticationFailedError)
            {
                mcpAuthenticationFailedError?.Invoke(McpAuthenticationFailedError!);
            }
            else if (IsBillingError)
            {
                billingError?.Invoke(BillingError!);
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsBillingError?>.Default.Equals(BillingError, other.BillingError) 
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
