#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Whether the agent can spawn session threads.
    /// </summary>
    public readonly partial struct BetaManagedAgentsMultiagentSubagentsParams : global::System.IEquatable<BetaManagedAgentsMultiagentSubagentsParams>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsParamsDiscriminatorType? Type { get; }

        /// <summary>
        /// The agent can spawn session threads. Each thread runs a predefined agent, which is a saved agent in `predefined_agents`, or an inline agent, which the agent defines when it spawns the thread and which is not saved. If `inline_agents` is disabled, `predefined_agents` must name at least one agent.<br/>
        /// Example: {"type":"enabled","inline_agents":{"type":"disabled"},"predefined_agents":["agent_011CZkYqphY8vELVzwCUpqiQ",{"type":"self"}]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabledParams? Enabled { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabledParams? Enabled { get; }
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
            out global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabledParams? value)
        {
            value = Enabled;
            return IsEnabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabledParams PickEnabled() => Enabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enabled' but the value was {ToString()}.");

        /// <summary>
        /// The agent cannot spawn session threads.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabledParams? Disabled { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabledParams? Disabled { get; }
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
            out global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabledParams? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabledParams PickDisabled() => Disabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsMultiagentSubagentsParams(global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabledParams value) => new BetaManagedAgentsMultiagentSubagentsParams((global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabledParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabledParams?(BetaManagedAgentsMultiagentSubagentsParams @this) => @this.Enabled;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentSubagentsParams(global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabledParams? value)
        {
            Enabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsMultiagentSubagentsParams FromEnabled(global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabledParams? value) => new BetaManagedAgentsMultiagentSubagentsParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsMultiagentSubagentsParams(global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabledParams value) => new BetaManagedAgentsMultiagentSubagentsParams((global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabledParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabledParams?(BetaManagedAgentsMultiagentSubagentsParams @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentSubagentsParams(global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabledParams? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsMultiagentSubagentsParams FromDisabled(global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabledParams? value) => new BetaManagedAgentsMultiagentSubagentsParams(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentSubagentsParams(
            global::Anthropic.BetaManagedAgentsMultiagentSubagentsParamsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabledParams? enabled,
            global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabledParams? disabled
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
            global::System.Func<global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabledParams, TResult>? enabled = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabledParams, TResult>? disabled = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabledParams>? enabled = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabledParams>? disabled = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabledParams>? enabled = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabledParams>? disabled = null,
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
                typeof(global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabledParams),
                Disabled,
                typeof(global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabledParams),
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
        public bool Equals(BetaManagedAgentsMultiagentSubagentsParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMultiagentSubagentsEnabledParams?>.Default.Equals(Enabled, other.Enabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabledParams?>.Default.Equals(Disabled, other.Disabled)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsMultiagentSubagentsParams obj1, BetaManagedAgentsMultiagentSubagentsParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsMultiagentSubagentsParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsMultiagentSubagentsParams obj1, BetaManagedAgentsMultiagentSubagentsParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsMultiagentSubagentsParams o && Equals(o);
        }
    }
}
