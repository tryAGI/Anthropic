#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaManagedAgentsAgentUnionParams : global::System.IEquatable<BetaManagedAgentsAgentUnionParams>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaManagedAgentsAgentUnionParamsVariant1 { get; init; }
#else
        public string? BetaManagedAgentsAgentUnionParamsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsAgentUnionParamsVariant1))]
#endif
        public bool IsBetaManagedAgentsAgentUnionParamsVariant1 => BetaManagedAgentsAgentUnionParamsVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2? BetaManagedAgentsAgentUnionParamsVariant2 { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2? BetaManagedAgentsAgentUnionParamsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsAgentUnionParamsVariant2))]
#endif
        public bool IsBetaManagedAgentsAgentUnionParamsVariant2 => BetaManagedAgentsAgentUnionParamsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentUnionParams(string value) => new BetaManagedAgentsAgentUnionParams((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(BetaManagedAgentsAgentUnionParams @this) => @this.BetaManagedAgentsAgentUnionParamsVariant1;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentUnionParams(string? value)
        {
            BetaManagedAgentsAgentUnionParamsVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentUnionParams(global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2 value) => new BetaManagedAgentsAgentUnionParams((global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2?(BetaManagedAgentsAgentUnionParams @this) => @this.BetaManagedAgentsAgentUnionParamsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentUnionParams(global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2? value)
        {
            BetaManagedAgentsAgentUnionParamsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentUnionParams(
            string? betaManagedAgentsAgentUnionParamsVariant1,
            global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2? betaManagedAgentsAgentUnionParamsVariant2
            )
        {
            BetaManagedAgentsAgentUnionParamsVariant1 = betaManagedAgentsAgentUnionParamsVariant1;
            BetaManagedAgentsAgentUnionParamsVariant2 = betaManagedAgentsAgentUnionParamsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BetaManagedAgentsAgentUnionParamsVariant2 as object ??
            BetaManagedAgentsAgentUnionParamsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BetaManagedAgentsAgentUnionParamsVariant1?.ToString() ??
            BetaManagedAgentsAgentUnionParamsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBetaManagedAgentsAgentUnionParamsVariant1 && !IsBetaManagedAgentsAgentUnionParamsVariant2 || !IsBetaManagedAgentsAgentUnionParamsVariant1 && IsBetaManagedAgentsAgentUnionParamsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? betaManagedAgentsAgentUnionParamsVariant1 = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2?, TResult>? betaManagedAgentsAgentUnionParamsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaManagedAgentsAgentUnionParamsVariant1 && betaManagedAgentsAgentUnionParamsVariant1 != null)
            {
                return betaManagedAgentsAgentUnionParamsVariant1(BetaManagedAgentsAgentUnionParamsVariant1!);
            }
            else if (IsBetaManagedAgentsAgentUnionParamsVariant2 && betaManagedAgentsAgentUnionParamsVariant2 != null)
            {
                return betaManagedAgentsAgentUnionParamsVariant2(BetaManagedAgentsAgentUnionParamsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? betaManagedAgentsAgentUnionParamsVariant1 = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2?>? betaManagedAgentsAgentUnionParamsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBetaManagedAgentsAgentUnionParamsVariant1)
            {
                betaManagedAgentsAgentUnionParamsVariant1?.Invoke(BetaManagedAgentsAgentUnionParamsVariant1!);
            }
            else if (IsBetaManagedAgentsAgentUnionParamsVariant2)
            {
                betaManagedAgentsAgentUnionParamsVariant2?.Invoke(BetaManagedAgentsAgentUnionParamsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BetaManagedAgentsAgentUnionParamsVariant1,
                typeof(string),
                BetaManagedAgentsAgentUnionParamsVariant2,
                typeof(global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2),
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
        public bool Equals(BetaManagedAgentsAgentUnionParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsAgentUnionParamsVariant1, other.BetaManagedAgentsAgentUnionParamsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAgentUnionParamsVariant2?>.Default.Equals(BetaManagedAgentsAgentUnionParamsVariant2, other.BetaManagedAgentsAgentUnionParamsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsAgentUnionParams obj1, BetaManagedAgentsAgentUnionParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsAgentUnionParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsAgentUnionParams obj1, BetaManagedAgentsAgentUnionParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsAgentUnionParams o && Equals(o);
        }
    }
}
