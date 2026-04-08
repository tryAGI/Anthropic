#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct NetworkingVariant1 : global::System.IEquatable<NetworkingVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaCloudConfigParamsNetworkingVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// Unrestricted network access.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaUnrestrictedNetwork? Unrestricted { get; init; }
#else
        public global::Anthropic.BetaUnrestrictedNetwork? Unrestricted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Unrestricted))]
#endif
        public bool IsUnrestricted => Unrestricted != null;

        /// <summary>
        /// Limited network request params.<br/>
        /// Fields default to null; on update, omitted fields preserve the<br/>
        /// existing value.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaLimitedNetworkParams? Limited { get; init; }
#else
        public global::Anthropic.BetaLimitedNetworkParams? Limited { get; }
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
        public static implicit operator NetworkingVariant1(global::Anthropic.BetaUnrestrictedNetwork value) => new NetworkingVariant1((global::Anthropic.BetaUnrestrictedNetwork?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaUnrestrictedNetwork?(NetworkingVariant1 @this) => @this.Unrestricted;

        /// <summary>
        /// 
        /// </summary>
        public NetworkingVariant1(global::Anthropic.BetaUnrestrictedNetwork? value)
        {
            Unrestricted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NetworkingVariant1(global::Anthropic.BetaLimitedNetworkParams value) => new NetworkingVariant1((global::Anthropic.BetaLimitedNetworkParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaLimitedNetworkParams?(NetworkingVariant1 @this) => @this.Limited;

        /// <summary>
        /// 
        /// </summary>
        public NetworkingVariant1(global::Anthropic.BetaLimitedNetworkParams? value)
        {
            Limited = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public NetworkingVariant1(
            global::Anthropic.BetaCloudConfigParamsNetworkingVariant1DiscriminatorType? type,
            global::Anthropic.BetaUnrestrictedNetwork? unrestricted,
            global::Anthropic.BetaLimitedNetworkParams? limited
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
            global::System.Func<global::Anthropic.BetaUnrestrictedNetwork?, TResult>? unrestricted = null,
            global::System.Func<global::Anthropic.BetaLimitedNetworkParams?, TResult>? limited = null,
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
            global::System.Action<global::Anthropic.BetaUnrestrictedNetwork?>? unrestricted = null,
            global::System.Action<global::Anthropic.BetaLimitedNetworkParams?>? limited = null,
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
                typeof(global::Anthropic.BetaUnrestrictedNetwork),
                Limited,
                typeof(global::Anthropic.BetaLimitedNetworkParams),
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
        public bool Equals(NetworkingVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaUnrestrictedNetwork?>.Default.Equals(Unrestricted, other.Unrestricted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaLimitedNetworkParams?>.Default.Equals(Limited, other.Limited) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NetworkingVariant1 obj1, NetworkingVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NetworkingVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NetworkingVariant1 obj1, NetworkingVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NetworkingVariant1 o && Equals(o);
        }
    }
}
