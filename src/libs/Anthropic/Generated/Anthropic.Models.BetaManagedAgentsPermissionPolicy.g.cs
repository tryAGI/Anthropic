#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Permission policy for tool execution.
    /// </summary>
    public readonly partial struct BetaManagedAgentsPermissionPolicy : global::System.IEquatable<BetaManagedAgentsPermissionPolicy>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsPermissionPolicyDiscriminatorType? Type { get; }

        /// <summary>
        /// Tool calls are automatically approved without user confirmation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy? AlwaysAllow { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy? AlwaysAllow { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AlwaysAllow))]
#endif
        public bool IsAlwaysAllow => AlwaysAllow != null;

        /// <summary>
        /// Tool calls require user confirmation before execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAlwaysAskPolicy? AlwaysAsk { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAlwaysAskPolicy? AlwaysAsk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AlwaysAsk))]
#endif
        public bool IsAlwaysAsk => AlwaysAsk != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsPermissionPolicy(global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy value) => new BetaManagedAgentsPermissionPolicy((global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy?(BetaManagedAgentsPermissionPolicy @this) => @this.AlwaysAllow;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsPermissionPolicy(global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy? value)
        {
            AlwaysAllow = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsPermissionPolicy(global::Anthropic.BetaManagedAgentsAlwaysAskPolicy value) => new BetaManagedAgentsPermissionPolicy((global::Anthropic.BetaManagedAgentsAlwaysAskPolicy?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAlwaysAskPolicy?(BetaManagedAgentsPermissionPolicy @this) => @this.AlwaysAsk;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsPermissionPolicy(global::Anthropic.BetaManagedAgentsAlwaysAskPolicy? value)
        {
            AlwaysAsk = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsPermissionPolicy(
            global::Anthropic.BetaManagedAgentsPermissionPolicyDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy? alwaysAllow,
            global::Anthropic.BetaManagedAgentsAlwaysAskPolicy? alwaysAsk
            )
        {
            Type = type;

            AlwaysAllow = alwaysAllow;
            AlwaysAsk = alwaysAsk;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AlwaysAsk as object ??
            AlwaysAllow as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AlwaysAllow?.ToString() ??
            AlwaysAsk?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAlwaysAllow && !IsAlwaysAsk || !IsAlwaysAllow && IsAlwaysAsk;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy?, TResult>? alwaysAllow = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAlwaysAskPolicy?, TResult>? alwaysAsk = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAlwaysAllow && alwaysAllow != null)
            {
                return alwaysAllow(AlwaysAllow!);
            }
            else if (IsAlwaysAsk && alwaysAsk != null)
            {
                return alwaysAsk(AlwaysAsk!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy?>? alwaysAllow = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAlwaysAskPolicy?>? alwaysAsk = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAlwaysAllow)
            {
                alwaysAllow?.Invoke(AlwaysAllow!);
            }
            else if (IsAlwaysAsk)
            {
                alwaysAsk?.Invoke(AlwaysAsk!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AlwaysAllow,
                typeof(global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy),
                AlwaysAsk,
                typeof(global::Anthropic.BetaManagedAgentsAlwaysAskPolicy),
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
        public bool Equals(BetaManagedAgentsPermissionPolicy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy?>.Default.Equals(AlwaysAllow, other.AlwaysAllow) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAlwaysAskPolicy?>.Default.Equals(AlwaysAsk, other.AlwaysAsk) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsPermissionPolicy obj1, BetaManagedAgentsPermissionPolicy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsPermissionPolicy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsPermissionPolicy obj1, BetaManagedAgentsPermissionPolicy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsPermissionPolicy o && Equals(o);
        }
    }
}
