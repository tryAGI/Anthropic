#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// One agent in a `predefined_agents` list. It is an agent ID string, an `agent` reference with an optional `version`, or `self` for the agent that owns this configuration.
    /// </summary>
    public readonly partial struct BetaManagedAgentsMultiagentPredefinedAgentParams : global::System.IEquatable<BetaManagedAgentsMultiagentPredefinedAgentParams>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaManagedAgentsMultiagentPredefinedAgentParamsVariant1 { get; init; }
#else
        public string? BetaManagedAgentsMultiagentPredefinedAgentParamsVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsMultiagentPredefinedAgentParamsVariant1))]
#endif
        public bool IsBetaManagedAgentsMultiagentPredefinedAgentParamsVariant1 => BetaManagedAgentsMultiagentPredefinedAgentParamsVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsMultiagentPredefinedAgentParamsVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaManagedAgentsMultiagentPredefinedAgentParamsVariant1;
            return IsBetaManagedAgentsMultiagentPredefinedAgentParamsVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaManagedAgentsMultiagentPredefinedAgentParamsVariant1() => BetaManagedAgentsMultiagentPredefinedAgentParamsVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsMultiagentPredefinedAgentParamsVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams>? BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2 { get; init; }
#else
        public global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams>? BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2))]
#endif
        public bool IsBetaManagedAgentsMultiagentPredefinedAgentParamsVariant2 => BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsMultiagentPredefinedAgentParamsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams>? value)
        {
            value = BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2;
            return IsBetaManagedAgentsMultiagentPredefinedAgentParamsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams> PickBetaManagedAgentsMultiagentPredefinedAgentParamsVariant2() => BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsMultiagentPredefinedAgentParams(string value) => new BetaManagedAgentsMultiagentPredefinedAgentParams((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(BetaManagedAgentsMultiagentPredefinedAgentParams @this) => @this.BetaManagedAgentsMultiagentPredefinedAgentParamsVariant1;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentPredefinedAgentParams(string? value)
        {
            BetaManagedAgentsMultiagentPredefinedAgentParamsVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsMultiagentPredefinedAgentParams FromBetaManagedAgentsMultiagentPredefinedAgentParamsVariant1(string? value) => new BetaManagedAgentsMultiagentPredefinedAgentParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsMultiagentPredefinedAgentParams(global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams> value) => new BetaManagedAgentsMultiagentPredefinedAgentParams((global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams>?(BetaManagedAgentsMultiagentPredefinedAgentParams @this) => @this.BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentPredefinedAgentParams(global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams>? value)
        {
            BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsMultiagentPredefinedAgentParams FromBetaManagedAgentsMultiagentPredefinedAgentParamsVariant2(global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams>? value) => new BetaManagedAgentsMultiagentPredefinedAgentParams(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentPredefinedAgentParams(
            string? betaManagedAgentsMultiagentPredefinedAgentParamsVariant1,
            global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams>? betaManagedAgentsMultiagentPredefinedAgentParamsVariant2
            )
        {
            BetaManagedAgentsMultiagentPredefinedAgentParamsVariant1 = betaManagedAgentsMultiagentPredefinedAgentParamsVariant1;
            BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2 = betaManagedAgentsMultiagentPredefinedAgentParamsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2 as object ??
            BetaManagedAgentsMultiagentPredefinedAgentParamsVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BetaManagedAgentsMultiagentPredefinedAgentParamsVariant1?.ToString() ??
            BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBetaManagedAgentsMultiagentPredefinedAgentParamsVariant1 && !IsBetaManagedAgentsMultiagentPredefinedAgentParamsVariant2 || !IsBetaManagedAgentsMultiagentPredefinedAgentParamsVariant1 && IsBetaManagedAgentsMultiagentPredefinedAgentParamsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? betaManagedAgentsMultiagentPredefinedAgentParamsVariant1 = null,
            global::System.Func<global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams>?, TResult>? betaManagedAgentsMultiagentPredefinedAgentParamsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaManagedAgentsMultiagentPredefinedAgentParamsVariant1 is { } __value0 && betaManagedAgentsMultiagentPredefinedAgentParamsVariant1 != null)
            {
                return betaManagedAgentsMultiagentPredefinedAgentParamsVariant1(__value0);
            }
            else if (BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2 is { } __value1 && betaManagedAgentsMultiagentPredefinedAgentParamsVariant2 != null)
            {
                return betaManagedAgentsMultiagentPredefinedAgentParamsVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? betaManagedAgentsMultiagentPredefinedAgentParamsVariant1 = null,

            global::System.Action<global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams>?>? betaManagedAgentsMultiagentPredefinedAgentParamsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaManagedAgentsMultiagentPredefinedAgentParamsVariant1 is { } __value0)
            {
                betaManagedAgentsMultiagentPredefinedAgentParamsVariant1?.Invoke(__value0);
            }
            else if (BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2 is { } __value1)
            {
                betaManagedAgentsMultiagentPredefinedAgentParamsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? betaManagedAgentsMultiagentPredefinedAgentParamsVariant1 = null,
            global::System.Action<global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams>?>? betaManagedAgentsMultiagentPredefinedAgentParamsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaManagedAgentsMultiagentPredefinedAgentParamsVariant1 is { } __value0)
            {
                betaManagedAgentsMultiagentPredefinedAgentParamsVariant1?.Invoke(__value0);
            }
            else if (BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2 is { } __value1)
            {
                betaManagedAgentsMultiagentPredefinedAgentParamsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BetaManagedAgentsMultiagentPredefinedAgentParamsVariant1,
                typeof(string),
                BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2,
                typeof(global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams>),
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
        public bool Equals(BetaManagedAgentsMultiagentPredefinedAgentParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsMultiagentPredefinedAgentParamsVariant1, other.BetaManagedAgentsMultiagentPredefinedAgentParamsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams>?>.Default.Equals(BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2, other.BetaManagedAgentsMultiagentPredefinedAgentParamsVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsMultiagentPredefinedAgentParams obj1, BetaManagedAgentsMultiagentPredefinedAgentParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsMultiagentPredefinedAgentParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsMultiagentPredefinedAgentParams obj1, BetaManagedAgentsMultiagentPredefinedAgentParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsMultiagentPredefinedAgentParams o && Equals(o);
        }
    }
}
