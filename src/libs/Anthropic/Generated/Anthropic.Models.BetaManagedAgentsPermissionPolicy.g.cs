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
        ///
        /// </summary>
        public bool TryPickAlwaysAllow(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy? value)
        {
            value = AlwaysAllow;
            return IsAlwaysAllow;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy PickAlwaysAllow() => AlwaysAllow is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AlwaysAllow' but the value was {ToString()}.");

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
        public bool TryPickAlwaysAsk(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAlwaysAskPolicy? value)
        {
            value = AlwaysAsk;
            return IsAlwaysAsk;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAlwaysAskPolicy PickAlwaysAsk() => AlwaysAsk is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AlwaysAsk' but the value was {ToString()}.");

        /// <summary>
        /// The server decides each tool call individually: it judges, from the tool, its input, and the session content so far, whether the call is safe to execute or high-risk, and evaluates it to allow when judged safe and to deny when judged high-risk. A call the server cannot reach a judgement on evaluates to ask.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsAutoPolicy? Auto { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsAutoPolicy? Auto { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Auto))]
#endif
        public bool IsAuto => Auto != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAuto(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsAutoPolicy? value)
        {
            value = Auto;
            return IsAuto;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAutoPolicy PickAuto() => Auto is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Auto' but the value was {ToString()}.");
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
        public static BetaManagedAgentsPermissionPolicy FromAlwaysAllow(global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy? value) => new BetaManagedAgentsPermissionPolicy(value);

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
        public static BetaManagedAgentsPermissionPolicy FromAlwaysAsk(global::Anthropic.BetaManagedAgentsAlwaysAskPolicy? value) => new BetaManagedAgentsPermissionPolicy(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsPermissionPolicy(global::Anthropic.BetaManagedAgentsAutoPolicy value) => new BetaManagedAgentsPermissionPolicy((global::Anthropic.BetaManagedAgentsAutoPolicy?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsAutoPolicy?(BetaManagedAgentsPermissionPolicy @this) => @this.Auto;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsPermissionPolicy(global::Anthropic.BetaManagedAgentsAutoPolicy? value)
        {
            Auto = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsPermissionPolicy FromAuto(global::Anthropic.BetaManagedAgentsAutoPolicy? value) => new BetaManagedAgentsPermissionPolicy(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsPermissionPolicy(
            global::Anthropic.BetaManagedAgentsPermissionPolicyDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy? alwaysAllow,
            global::Anthropic.BetaManagedAgentsAlwaysAskPolicy? alwaysAsk,
            global::Anthropic.BetaManagedAgentsAutoPolicy? auto
            )
        {
            Type = type;

            AlwaysAllow = alwaysAllow;
            AlwaysAsk = alwaysAsk;
            Auto = auto;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Auto as object ??
            AlwaysAsk as object ??
            AlwaysAllow as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AlwaysAllow?.ToString() ??
            AlwaysAsk?.ToString() ??
            Auto?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAlwaysAllow && !IsAlwaysAsk && !IsAuto || !IsAlwaysAllow && IsAlwaysAsk && !IsAuto || !IsAlwaysAllow && !IsAlwaysAsk && IsAuto;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy, TResult>? alwaysAllow = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAlwaysAskPolicy, TResult>? alwaysAsk = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsAutoPolicy, TResult>? auto = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AlwaysAllow is { } __value0 && alwaysAllow != null)
            {
                return alwaysAllow(__value0);
            }
            else if (AlwaysAsk is { } __value1 && alwaysAsk != null)
            {
                return alwaysAsk(__value1);
            }
            else if (Auto is { } __value2 && auto != null)
            {
                return auto(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy>? alwaysAllow = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsAlwaysAskPolicy>? alwaysAsk = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsAutoPolicy>? auto = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AlwaysAllow is { } __value0)
            {
                alwaysAllow?.Invoke(__value0);
            }
            else if (AlwaysAsk is { } __value1)
            {
                alwaysAsk?.Invoke(__value1);
            }
            else if (Auto is { } __value2)
            {
                auto?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsAlwaysAllowPolicy>? alwaysAllow = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAlwaysAskPolicy>? alwaysAsk = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsAutoPolicy>? auto = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AlwaysAllow is { } __value0)
            {
                alwaysAllow?.Invoke(__value0);
            }
            else if (AlwaysAsk is { } __value1)
            {
                alwaysAsk?.Invoke(__value1);
            }
            else if (Auto is { } __value2)
            {
                auto?.Invoke(__value2);
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
                Auto,
                typeof(global::Anthropic.BetaManagedAgentsAutoPolicy),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAlwaysAskPolicy?>.Default.Equals(AlwaysAsk, other.AlwaysAsk) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsAutoPolicy?>.Default.Equals(Auto, other.Auto)
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
