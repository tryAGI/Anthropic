#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Resolved skill as returned in API responses.
    /// </summary>
    public readonly partial struct BetaManagedAgentsSkill : global::System.IEquatable<BetaManagedAgentsSkill>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillDiscriminatorType? Type { get; }

        /// <summary>
        /// A resolved Anthropic-managed skill.<br/>
        /// Example: {"type":"anthropic","skill_id":"xlsx","version":"1"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAnthropicSkill? Anthropic { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAnthropicSkill? Anthropic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Anthropic))]
#endif
        public bool IsAnthropic => Anthropic != null;

        /// <summary>
        /// A resolved user-created custom skill.<br/>
        /// Example: {"type":"custom","skill_id":"skill_011CZkZFNu9hAbo3jZPRgTlx","version":"2"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsCustomSkill? Custom { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsCustomSkill? Custom { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSkill(global::Anthropic.BetaManagedAgentsAnthropicSkill value) => new BetaManagedAgentsSkill((global::Anthropic.BetaManagedAgentsAnthropicSkill?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAnthropicSkill?(BetaManagedAgentsSkill @this) => @this.Anthropic;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSkill(global::Anthropic.BetaManagedAgentsAnthropicSkill? value)
        {
            Anthropic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSkill(global::Anthropic.BetaManagedAgentsCustomSkill value) => new BetaManagedAgentsSkill((global::Anthropic.BetaManagedAgentsCustomSkill?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsCustomSkill?(BetaManagedAgentsSkill @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSkill(global::Anthropic.BetaManagedAgentsCustomSkill? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSkill(
            global::Anthropic.BetaManagedAgentsSkillDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsAnthropicSkill? anthropic,
            global::Anthropic.BetaManagedAgentsCustomSkill? custom
            )
        {
            Type = type;

            Anthropic = anthropic;
            Custom = custom;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Custom as object ??
            Anthropic as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Anthropic?.ToString() ??
            Custom?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropic && !IsCustom || !IsAnthropic && IsCustom;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsAnthropicSkill?, TResult>? anthropic = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsCustomSkill?, TResult>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropic && anthropic != null)
            {
                return anthropic(Anthropic!);
            }
            else if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsAnthropicSkill?>? anthropic = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsCustomSkill?>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropic)
            {
                anthropic?.Invoke(Anthropic!);
            }
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Anthropic,
                typeof(global::Anthropic.BetaManagedAgentsAnthropicSkill),
                Custom,
                typeof(global::Anthropic.BetaManagedAgentsCustomSkill),
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
        public bool Equals(BetaManagedAgentsSkill other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAnthropicSkill?>.Default.Equals(Anthropic, other.Anthropic) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsCustomSkill?>.Default.Equals(Custom, other.Custom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsSkill obj1, BetaManagedAgentsSkill obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsSkill>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsSkill obj1, BetaManagedAgentsSkill obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsSkill o && Equals(o);
        }
    }
}
