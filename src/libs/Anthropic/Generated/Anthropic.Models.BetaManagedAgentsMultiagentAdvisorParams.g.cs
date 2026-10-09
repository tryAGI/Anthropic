#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Whether the session's primary thread can consult an advisor model.
    /// </summary>
    public readonly partial struct BetaManagedAgentsMultiagentAdvisorParams : global::System.IEquatable<BetaManagedAgentsMultiagentAdvisorParams>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorParamsDiscriminatorType? Type { get; }

        /// <summary>
        /// The session's primary thread can consult `model` mid-turn.<br/>
        /// Example: {"type":"enabled","model":"claude-fable-5"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabledParams? Enabled { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabledParams? Enabled { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enabled))]
#endif
        public bool IsEnabled => Enabled != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEnabled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabledParams? value)
        {
            value = Enabled;
            return IsEnabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabledParams PickEnabled() => Enabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enabled' but the value was {ToString()}.");

        /// <summary>
        /// The agent has no advisor.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabledParams? Disabled { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabledParams? Disabled { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Disabled))]
#endif
        public bool IsDisabled => Disabled != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDisabled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabledParams? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabledParams PickDisabled() => Disabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsMultiagentAdvisorParams(global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabledParams value) => new BetaManagedAgentsMultiagentAdvisorParams((global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabledParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabledParams?(BetaManagedAgentsMultiagentAdvisorParams @this) => @this.Enabled;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentAdvisorParams(global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabledParams? value)
        {
            Enabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsMultiagentAdvisorParams FromEnabled(global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabledParams? value) => new BetaManagedAgentsMultiagentAdvisorParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsMultiagentAdvisorParams(global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabledParams value) => new BetaManagedAgentsMultiagentAdvisorParams((global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabledParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabledParams?(BetaManagedAgentsMultiagentAdvisorParams @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentAdvisorParams(global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabledParams? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsMultiagentAdvisorParams FromDisabled(global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabledParams? value) => new BetaManagedAgentsMultiagentAdvisorParams(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentAdvisorParams(
            global::Anthropic.BetaManagedAgentsMultiagentAdvisorParamsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabledParams? enabled,
            global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabledParams? disabled
            )
        {
            Type = type;

            Enabled = enabled;
            Disabled = disabled;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Disabled as object ??
            Enabled as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Enabled?.ToString() ??
            Disabled?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEnabled && !IsDisabled || !IsEnabled && IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabledParams, TResult>? enabled = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabledParams, TResult>? disabled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Enabled is { } __value0 && enabled != null)
            {
                return enabled(__value0);
            }
            else if (Disabled is { } __value1 && disabled != null)
            {
                return disabled(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabledParams>? enabled = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabledParams>? disabled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Enabled is { } __value0)
            {
                enabled?.Invoke(__value0);
            }
            else if (Disabled is { } __value1)
            {
                disabled?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabledParams>? enabled = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabledParams>? disabled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Enabled is { } __value0)
            {
                enabled?.Invoke(__value0);
            }
            else if (Disabled is { } __value1)
            {
                disabled?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Enabled,
                typeof(global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabledParams),
                Disabled,
                typeof(global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabledParams),
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
        public bool Equals(BetaManagedAgentsMultiagentAdvisorParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMultiagentAdvisorEnabledParams?>.Default.Equals(Enabled, other.Enabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMultiagentAdvisorDisabledParams?>.Default.Equals(Disabled, other.Disabled)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsMultiagentAdvisorParams obj1, BetaManagedAgentsMultiagentAdvisorParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsMultiagentAdvisorParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsMultiagentAdvisorParams obj1, BetaManagedAgentsMultiagentAdvisorParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsMultiagentAdvisorParams o && Equals(o);
        }
    }
}
