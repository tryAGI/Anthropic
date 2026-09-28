#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An entry in a multiagent roster: an agent ID string, a versioned agent reference, or `self`.
    /// </summary>
    public readonly partial struct BetaManagedAgentsMultiagentRosterEntryParams : global::System.IEquatable<BetaManagedAgentsMultiagentRosterEntryParams>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaManagedAgentsMultiagentRosterEntryParamsVariant1 { get; init; }
#else
        public string? BetaManagedAgentsMultiagentRosterEntryParamsVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsMultiagentRosterEntryParamsVariant1))]
#endif
        public bool IsBetaManagedAgentsMultiagentRosterEntryParamsVariant1 => BetaManagedAgentsMultiagentRosterEntryParamsVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsMultiagentRosterEntryParamsVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaManagedAgentsMultiagentRosterEntryParamsVariant1;
            return IsBetaManagedAgentsMultiagentRosterEntryParamsVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaManagedAgentsMultiagentRosterEntryParamsVariant1() => BetaManagedAgentsMultiagentRosterEntryParamsVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsMultiagentRosterEntryParamsVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams, global::Anthropic.BetaManagedAgentsAdvisorParams>? BetaManagedAgentsMultiagentRosterEntryParamsVariant2 { get; init; }
#else
        public global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams, global::Anthropic.BetaManagedAgentsAdvisorParams>? BetaManagedAgentsMultiagentRosterEntryParamsVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaManagedAgentsMultiagentRosterEntryParamsVariant2))]
#endif
        public bool IsBetaManagedAgentsMultiagentRosterEntryParamsVariant2 => BetaManagedAgentsMultiagentRosterEntryParamsVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaManagedAgentsMultiagentRosterEntryParamsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams, global::Anthropic.BetaManagedAgentsAdvisorParams>? value)
        {
            value = BetaManagedAgentsMultiagentRosterEntryParamsVariant2;
            return IsBetaManagedAgentsMultiagentRosterEntryParamsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams, global::Anthropic.BetaManagedAgentsAdvisorParams> PickBetaManagedAgentsMultiagentRosterEntryParamsVariant2() => BetaManagedAgentsMultiagentRosterEntryParamsVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaManagedAgentsMultiagentRosterEntryParamsVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsMultiagentRosterEntryParams(string value) => new BetaManagedAgentsMultiagentRosterEntryParams((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(BetaManagedAgentsMultiagentRosterEntryParams @this) => @this.BetaManagedAgentsMultiagentRosterEntryParamsVariant1;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentRosterEntryParams(string? value)
        {
            BetaManagedAgentsMultiagentRosterEntryParamsVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsMultiagentRosterEntryParams FromBetaManagedAgentsMultiagentRosterEntryParamsVariant1(string? value) => new BetaManagedAgentsMultiagentRosterEntryParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsMultiagentRosterEntryParams(global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams, global::Anthropic.BetaManagedAgentsAdvisorParams> value) => new BetaManagedAgentsMultiagentRosterEntryParams((global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams, global::Anthropic.BetaManagedAgentsAdvisorParams>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams, global::Anthropic.BetaManagedAgentsAdvisorParams>?(BetaManagedAgentsMultiagentRosterEntryParams @this) => @this.BetaManagedAgentsMultiagentRosterEntryParamsVariant2;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentRosterEntryParams(global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams, global::Anthropic.BetaManagedAgentsAdvisorParams>? value)
        {
            BetaManagedAgentsMultiagentRosterEntryParamsVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsMultiagentRosterEntryParams FromBetaManagedAgentsMultiagentRosterEntryParamsVariant2(global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams, global::Anthropic.BetaManagedAgentsAdvisorParams>? value) => new BetaManagedAgentsMultiagentRosterEntryParams(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentRosterEntryParams(
            string? betaManagedAgentsMultiagentRosterEntryParamsVariant1,
            global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams, global::Anthropic.BetaManagedAgentsAdvisorParams>? betaManagedAgentsMultiagentRosterEntryParamsVariant2
            )
        {
            BetaManagedAgentsMultiagentRosterEntryParamsVariant1 = betaManagedAgentsMultiagentRosterEntryParamsVariant1;
            BetaManagedAgentsMultiagentRosterEntryParamsVariant2 = betaManagedAgentsMultiagentRosterEntryParamsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BetaManagedAgentsMultiagentRosterEntryParamsVariant2 as object ??
            BetaManagedAgentsMultiagentRosterEntryParamsVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BetaManagedAgentsMultiagentRosterEntryParamsVariant1?.ToString() ??
            BetaManagedAgentsMultiagentRosterEntryParamsVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBetaManagedAgentsMultiagentRosterEntryParamsVariant1 && !IsBetaManagedAgentsMultiagentRosterEntryParamsVariant2 || !IsBetaManagedAgentsMultiagentRosterEntryParamsVariant1 && IsBetaManagedAgentsMultiagentRosterEntryParamsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? betaManagedAgentsMultiagentRosterEntryParamsVariant1 = null,
            global::System.Func<global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams, global::Anthropic.BetaManagedAgentsAdvisorParams>?, TResult>? betaManagedAgentsMultiagentRosterEntryParamsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaManagedAgentsMultiagentRosterEntryParamsVariant1 is { } __value0 && betaManagedAgentsMultiagentRosterEntryParamsVariant1 != null)
            {
                return betaManagedAgentsMultiagentRosterEntryParamsVariant1(__value0);
            }
            else if (BetaManagedAgentsMultiagentRosterEntryParamsVariant2 is { } __value1 && betaManagedAgentsMultiagentRosterEntryParamsVariant2 != null)
            {
                return betaManagedAgentsMultiagentRosterEntryParamsVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? betaManagedAgentsMultiagentRosterEntryParamsVariant1 = null,

            global::System.Action<global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams, global::Anthropic.BetaManagedAgentsAdvisorParams>?>? betaManagedAgentsMultiagentRosterEntryParamsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaManagedAgentsMultiagentRosterEntryParamsVariant1 is { } __value0)
            {
                betaManagedAgentsMultiagentRosterEntryParamsVariant1?.Invoke(__value0);
            }
            else if (BetaManagedAgentsMultiagentRosterEntryParamsVariant2 is { } __value1)
            {
                betaManagedAgentsMultiagentRosterEntryParamsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? betaManagedAgentsMultiagentRosterEntryParamsVariant1 = null,
            global::System.Action<global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams, global::Anthropic.BetaManagedAgentsAdvisorParams>?>? betaManagedAgentsMultiagentRosterEntryParamsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaManagedAgentsMultiagentRosterEntryParamsVariant1 is { } __value0)
            {
                betaManagedAgentsMultiagentRosterEntryParamsVariant1?.Invoke(__value0);
            }
            else if (BetaManagedAgentsMultiagentRosterEntryParamsVariant2 is { } __value1)
            {
                betaManagedAgentsMultiagentRosterEntryParamsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BetaManagedAgentsMultiagentRosterEntryParamsVariant1,
                typeof(string),
                BetaManagedAgentsMultiagentRosterEntryParamsVariant2,
                typeof(global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams, global::Anthropic.BetaManagedAgentsAdvisorParams>),
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
        public bool Equals(BetaManagedAgentsMultiagentRosterEntryParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaManagedAgentsMultiagentRosterEntryParamsVariant1, other.BetaManagedAgentsMultiagentRosterEntryParamsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.OneOf<global::Anthropic.BetaManagedAgentsAgentParams, global::Anthropic.BetaManagedAgentsMultiagentSelfParams, global::Anthropic.BetaManagedAgentsAdvisorParams>?>.Default.Equals(BetaManagedAgentsMultiagentRosterEntryParamsVariant2, other.BetaManagedAgentsMultiagentRosterEntryParamsVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsMultiagentRosterEntryParams obj1, BetaManagedAgentsMultiagentRosterEntryParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsMultiagentRosterEntryParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsMultiagentRosterEntryParams obj1, BetaManagedAgentsMultiagentRosterEntryParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsMultiagentRosterEntryParams o && Equals(o);
        }
    }
}
