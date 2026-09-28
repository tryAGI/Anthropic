#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaManagedAgentsCreateSessionAgentUnionParams : global::System.IEquatable<BetaManagedAgentsCreateSessionAgentUnionParams>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaManagedAgentsCreateSessionAgentUnionParamsVariant1 { get; init; }
#else
        public string? BetaManagedAgentsCreateSessionAgentUnionParamsVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsCreateSessionAgentUnionParamsVariant1))]
#endif
        public bool IsBetaManagedAgentsCreateSessionAgentUnionParamsVariant1 => BetaManagedAgentsCreateSessionAgentUnionParamsVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsCreateSessionAgentUnionParamsVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaManagedAgentsCreateSessionAgentUnionParamsVariant1;
            return IsBetaManagedAgentsCreateSessionAgentUnionParamsVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaManagedAgentsCreateSessionAgentUnionParamsVariant1() => BetaManagedAgentsCreateSessionAgentUnionParamsVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsCreateSessionAgentUnionParamsVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsAgentWithOverridesParams>? BetaManagedAgentsCreateSessionAgentUnionParamsVariant2 { get; init; }
#else
        public global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsAgentWithOverridesParams>? BetaManagedAgentsCreateSessionAgentUnionParamsVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsCreateSessionAgentUnionParamsVariant2))]
#endif
        public bool IsBetaManagedAgentsCreateSessionAgentUnionParamsVariant2 => BetaManagedAgentsCreateSessionAgentUnionParamsVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsCreateSessionAgentUnionParamsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsAgentWithOverridesParams>? value)
        {
            value = BetaManagedAgentsCreateSessionAgentUnionParamsVariant2;
            return IsBetaManagedAgentsCreateSessionAgentUnionParamsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsAgentWithOverridesParams> PickBetaManagedAgentsCreateSessionAgentUnionParamsVariant2() => BetaManagedAgentsCreateSessionAgentUnionParamsVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsCreateSessionAgentUnionParamsVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsCreateSessionAgentUnionParams(string value) => new BetaManagedAgentsCreateSessionAgentUnionParams((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(BetaManagedAgentsCreateSessionAgentUnionParams @this) => @this.BetaManagedAgentsCreateSessionAgentUnionParamsVariant1;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsCreateSessionAgentUnionParams(string? value)
        {
            BetaManagedAgentsCreateSessionAgentUnionParamsVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsCreateSessionAgentUnionParams FromBetaManagedAgentsCreateSessionAgentUnionParamsVariant1(string? value) => new BetaManagedAgentsCreateSessionAgentUnionParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsCreateSessionAgentUnionParams(global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsAgentWithOverridesParams> value) => new BetaManagedAgentsCreateSessionAgentUnionParams((global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsAgentWithOverridesParams>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsAgentWithOverridesParams>?(BetaManagedAgentsCreateSessionAgentUnionParams @this) => @this.BetaManagedAgentsCreateSessionAgentUnionParamsVariant2;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsCreateSessionAgentUnionParams(global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsAgentWithOverridesParams>? value)
        {
            BetaManagedAgentsCreateSessionAgentUnionParamsVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsCreateSessionAgentUnionParams FromBetaManagedAgentsCreateSessionAgentUnionParamsVariant2(global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsAgentWithOverridesParams>? value) => new BetaManagedAgentsCreateSessionAgentUnionParams(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsCreateSessionAgentUnionParams(
            string? betaManagedAgentsCreateSessionAgentUnionParamsVariant1,
            global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsAgentWithOverridesParams>? betaManagedAgentsCreateSessionAgentUnionParamsVariant2
            )
        {
            BetaManagedAgentsCreateSessionAgentUnionParamsVariant1 = betaManagedAgentsCreateSessionAgentUnionParamsVariant1;
            BetaManagedAgentsCreateSessionAgentUnionParamsVariant2 = betaManagedAgentsCreateSessionAgentUnionParamsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BetaManagedAgentsCreateSessionAgentUnionParamsVariant2 as object ??
            BetaManagedAgentsCreateSessionAgentUnionParamsVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BetaManagedAgentsCreateSessionAgentUnionParamsVariant1?.ToString() ??
            BetaManagedAgentsCreateSessionAgentUnionParamsVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBetaManagedAgentsCreateSessionAgentUnionParamsVariant1 && !IsBetaManagedAgentsCreateSessionAgentUnionParamsVariant2 || !IsBetaManagedAgentsCreateSessionAgentUnionParamsVariant1 && IsBetaManagedAgentsCreateSessionAgentUnionParamsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? betaManagedAgentsCreateSessionAgentUnionParamsVariant1 = null,
            global::System.Func<global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsAgentWithOverridesParams>?, TResult>? betaManagedAgentsCreateSessionAgentUnionParamsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaManagedAgentsCreateSessionAgentUnionParamsVariant1 is { } __value0 && betaManagedAgentsCreateSessionAgentUnionParamsVariant1 != null)
            {
                return betaManagedAgentsCreateSessionAgentUnionParamsVariant1(__value0);
            }
            else if (BetaManagedAgentsCreateSessionAgentUnionParamsVariant2 is { } __value1 && betaManagedAgentsCreateSessionAgentUnionParamsVariant2 != null)
            {
                return betaManagedAgentsCreateSessionAgentUnionParamsVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? betaManagedAgentsCreateSessionAgentUnionParamsVariant1 = null,

            global::System.Action<global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsAgentWithOverridesParams>?>? betaManagedAgentsCreateSessionAgentUnionParamsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaManagedAgentsCreateSessionAgentUnionParamsVariant1 is { } __value0)
            {
                betaManagedAgentsCreateSessionAgentUnionParamsVariant1?.Invoke(__value0);
            }
            else if (BetaManagedAgentsCreateSessionAgentUnionParamsVariant2 is { } __value1)
            {
                betaManagedAgentsCreateSessionAgentUnionParamsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? betaManagedAgentsCreateSessionAgentUnionParamsVariant1 = null,
            global::System.Action<global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsAgentWithOverridesParams>?>? betaManagedAgentsCreateSessionAgentUnionParamsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaManagedAgentsCreateSessionAgentUnionParamsVariant1 is { } __value0)
            {
                betaManagedAgentsCreateSessionAgentUnionParamsVariant1?.Invoke(__value0);
            }
            else if (BetaManagedAgentsCreateSessionAgentUnionParamsVariant2 is { } __value1)
            {
                betaManagedAgentsCreateSessionAgentUnionParamsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BetaManagedAgentsCreateSessionAgentUnionParamsVariant1,
                typeof(string),
                BetaManagedAgentsCreateSessionAgentUnionParamsVariant2,
                typeof(global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsAgentWithOverridesParams>),
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
        public bool Equals(BetaManagedAgentsCreateSessionAgentUnionParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsCreateSessionAgentUnionParamsVariant1, other.BetaManagedAgentsCreateSessionAgentUnionParamsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsAgentWithOverridesParams>?>.Default.Equals(BetaManagedAgentsCreateSessionAgentUnionParamsVariant2, other.BetaManagedAgentsCreateSessionAgentUnionParamsVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsCreateSessionAgentUnionParams obj1, BetaManagedAgentsCreateSessionAgentUnionParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsCreateSessionAgentUnionParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsCreateSessionAgentUnionParams obj1, BetaManagedAgentsCreateSessionAgentUnionParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsCreateSessionAgentUnionParams o && Equals(o);
        }
    }
}
