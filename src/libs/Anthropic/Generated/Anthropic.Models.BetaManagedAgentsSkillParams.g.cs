#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Skill to load in the session container.
    /// </summary>
    public readonly partial struct BetaManagedAgentsSkillParams : global::System.IEquatable<BetaManagedAgentsSkillParams>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSkillParamsDiscriminatorType? Type { get; }

        /// <summary>
        /// An Anthropic-managed skill.<br/>
        /// Example: {"type":"anthropic","skill_id":"xlsx","version":"1"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAnthropicSkillParams? Anthropic { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAnthropicSkillParams? Anthropic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Anthropic))]
#endif
        public bool IsAnthropic => Anthropic != null;

        /// <summary>
        /// A user-created custom skill.<br/>
        /// Example: {"type":"custom","skill_id":"skill_011CZkZFNu9hAbo3jZPRgTlx","version":"2"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsCustomSkillParams? Custom { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsCustomSkillParams? Custom { get; }
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
        public static implicit operator BetaManagedAgentsSkillParams(global::Anthropic.BetaManagedAgentsAnthropicSkillParams value) => new BetaManagedAgentsSkillParams((global::Anthropic.BetaManagedAgentsAnthropicSkillParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAnthropicSkillParams?(BetaManagedAgentsSkillParams @this) => @this.Anthropic;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSkillParams(global::Anthropic.BetaManagedAgentsAnthropicSkillParams? value)
        {
            Anthropic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSkillParams(global::Anthropic.BetaManagedAgentsCustomSkillParams value) => new BetaManagedAgentsSkillParams((global::Anthropic.BetaManagedAgentsCustomSkillParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsCustomSkillParams?(BetaManagedAgentsSkillParams @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSkillParams(global::Anthropic.BetaManagedAgentsCustomSkillParams? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSkillParams(
            global::Anthropic.BetaManagedAgentsSkillParamsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsAnthropicSkillParams? anthropic,
            global::Anthropic.BetaManagedAgentsCustomSkillParams? custom
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
            global::System.Func<global::Anthropic.BetaManagedAgentsAnthropicSkillParams?, TResult>? anthropic = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsCustomSkillParams?, TResult>? custom = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsAnthropicSkillParams?>? anthropic = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsCustomSkillParams?>? custom = null,
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
                typeof(global::Anthropic.BetaManagedAgentsAnthropicSkillParams),
                Custom,
                typeof(global::Anthropic.BetaManagedAgentsCustomSkillParams),
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
        public bool Equals(BetaManagedAgentsSkillParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAnthropicSkillParams?>.Default.Equals(Anthropic, other.Anthropic) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsCustomSkillParams?>.Default.Equals(Custom, other.Custom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsSkillParams obj1, BetaManagedAgentsSkillParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsSkillParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsSkillParams obj1, BetaManagedAgentsSkillParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsSkillParams o && Equals(o);
        }
    }
}
