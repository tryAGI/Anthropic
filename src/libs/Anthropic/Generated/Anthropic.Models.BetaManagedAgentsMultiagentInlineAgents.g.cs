#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Whether the agent can define inline agents. The agent defines an inline agent itself, in a workflow run's plan or when it spawns a session thread, and the inline agent is not saved.
    /// </summary>
    public readonly partial struct BetaManagedAgentsMultiagentInlineAgents : global::System.IEquatable<BetaManagedAgentsMultiagentInlineAgents>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDiscriminatorType? Type { get; }

        /// <summary>
        /// The agent can define inline agents.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled? Enabled { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled? Enabled { get; }
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
            out global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled? value)
        {
            value = Enabled;
            return IsEnabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled PickEnabled() => Enabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enabled' but the value was {ToString()}.");

        /// <summary>
        /// The agent cannot define inline agents.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled? Disabled { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled? Disabled { get; }
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
            out global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled PickDisabled() => Disabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsMultiagentInlineAgents(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled value) => new BetaManagedAgentsMultiagentInlineAgents((global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled?(BetaManagedAgentsMultiagentInlineAgents @this) => @this.Enabled;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentInlineAgents(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled? value)
        {
            Enabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsMultiagentInlineAgents FromEnabled(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled? value) => new BetaManagedAgentsMultiagentInlineAgents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsMultiagentInlineAgents(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled value) => new BetaManagedAgentsMultiagentInlineAgents((global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled?(BetaManagedAgentsMultiagentInlineAgents @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentInlineAgents(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsMultiagentInlineAgents FromDisabled(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled? value) => new BetaManagedAgentsMultiagentInlineAgents(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentInlineAgents(
            global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled? enabled,
            global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled? disabled
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
            global::System.Func<global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled, TResult>? enabled = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled, TResult>? disabled = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled>? enabled = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled>? disabled = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled>? enabled = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled>? disabled = null,
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
                typeof(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled),
                Disabled,
                typeof(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled),
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
        public bool Equals(BetaManagedAgentsMultiagentInlineAgents other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabled?>.Default.Equals(Enabled, other.Enabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabled?>.Default.Equals(Disabled, other.Disabled)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsMultiagentInlineAgents obj1, BetaManagedAgentsMultiagentInlineAgents obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsMultiagentInlineAgents>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsMultiagentInlineAgents obj1, BetaManagedAgentsMultiagentInlineAgents obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsMultiagentInlineAgents o && Equals(o);
        }
    }
}
