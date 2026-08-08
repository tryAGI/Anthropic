#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaManagedAgentsCredentialNetworkingResponse : global::System.IEquatable<BetaManagedAgentsCredentialNetworkingResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialNetworkingResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// The secret is substituted on any host the session's Environment network policy permits egress to.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse? Unrestricted { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse? Unrestricted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Unrestricted))]
#endif
        public bool IsUnrestricted => Unrestricted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUnrestricted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse? value)
        {
            value = Unrestricted;
            return IsUnrestricted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse PickUnrestricted() => IsUnrestricted
            ? Unrestricted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Unrestricted' but the value was {ToString()}.");

        /// <summary>
        /// The secret is substituted only on requests to the listed hosts.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse? Limited { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse? Limited { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Limited))]
#endif
        public bool IsLimited => Limited != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLimited(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse? value)
        {
            value = Limited;
            return IsLimited;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse PickLimited() => IsLimited
            ? Limited!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Limited' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsCredentialNetworkingResponse(global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse value) => new BetaManagedAgentsCredentialNetworkingResponse((global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse?(BetaManagedAgentsCredentialNetworkingResponse @this) => @this.Unrestricted;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCredentialNetworkingResponse(global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse? value)
        {
            Unrestricted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsCredentialNetworkingResponse FromUnrestricted(global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse? value) => new BetaManagedAgentsCredentialNetworkingResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsCredentialNetworkingResponse(global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse value) => new BetaManagedAgentsCredentialNetworkingResponse((global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse?(BetaManagedAgentsCredentialNetworkingResponse @this) => @this.Limited;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCredentialNetworkingResponse(global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse? value)
        {
            Limited = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsCredentialNetworkingResponse FromLimited(global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse? value) => new BetaManagedAgentsCredentialNetworkingResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCredentialNetworkingResponse(
            global::Anthropic.BetaManagedAgentsCredentialNetworkingResponseDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse? unrestricted,
            global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse? limited
            )
        {
            Type = type;

            Unrestricted = unrestricted;
            Limited = limited;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Limited as object ??
            Unrestricted as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Unrestricted?.ToString() ??
            Limited?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUnrestricted && !IsLimited || !IsUnrestricted && IsLimited;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse, TResult>? unrestricted = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse, TResult>? limited = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnrestricted && unrestricted != null)
            {
                return unrestricted(Unrestricted!);
            }
            else if (IsLimited && limited != null)
            {
                return limited(Limited!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse>? unrestricted = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse>? limited = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnrestricted)
            {
                unrestricted?.Invoke(Unrestricted!);
            }
            else if (IsLimited)
            {
                limited?.Invoke(Limited!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse>? unrestricted = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse>? limited = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUnrestricted)
            {
                unrestricted?.Invoke(Unrestricted!);
            }
            else if (IsLimited)
            {
                limited?.Invoke(Limited!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Unrestricted,
                typeof(global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse),
                Limited,
                typeof(global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse),
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
        public bool Equals(BetaManagedAgentsCredentialNetworkingResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUnrestrictedCredentialNetworkingResponse?>.Default.Equals(Unrestricted, other.Unrestricted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponse?>.Default.Equals(Limited, other.Limited) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsCredentialNetworkingResponse obj1, BetaManagedAgentsCredentialNetworkingResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsCredentialNetworkingResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsCredentialNetworkingResponse obj1, BetaManagedAgentsCredentialNetworkingResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsCredentialNetworkingResponse o && Equals(o);
        }
    }
}
