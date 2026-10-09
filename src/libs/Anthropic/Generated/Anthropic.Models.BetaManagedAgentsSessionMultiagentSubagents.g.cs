#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Whether the agent can spawn session threads.
    /// </summary>
    public readonly partial struct BetaManagedAgentsSessionMultiagentSubagents : global::System.IEquatable<BetaManagedAgentsSessionMultiagentSubagents>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsDiscriminatorType? Type { get; }

        /// <summary>
        /// The agent can spawn session threads.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsEnabled? Enabled { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsEnabled? Enabled { get; }
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
            out global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsEnabled? value)
        {
            value = Enabled;
            return IsEnabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsEnabled PickEnabled() => Enabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enabled' but the value was {ToString()}.");

        /// <summary>
        /// The agent cannot spawn session threads.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabled? Disabled { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabled? Disabled { get; }
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
            out global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabled? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabled PickDisabled() => Disabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionMultiagentSubagents(global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsEnabled value) => new BetaManagedAgentsSessionMultiagentSubagents((global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsEnabled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsEnabled?(BetaManagedAgentsSessionMultiagentSubagents @this) => @this.Enabled;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsSessionMultiagentSubagents(global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsEnabled? value)
        {
            Enabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsSessionMultiagentSubagents FromEnabled(global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsEnabled? value) => new BetaManagedAgentsSessionMultiagentSubagents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionMultiagentSubagents(global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabled value) => new BetaManagedAgentsSessionMultiagentSubagents((global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabled?(BetaManagedAgentsSessionMultiagentSubagents @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsSessionMultiagentSubagents(global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabled? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsSessionMultiagentSubagents FromDisabled(global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabled? value) => new BetaManagedAgentsSessionMultiagentSubagents(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsSessionMultiagentSubagents(
            global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsEnabled? enabled,
            global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabled? disabled
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
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsEnabled, TResult>? enabled = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabled, TResult>? disabled = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsEnabled>? enabled = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabled>? disabled = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsEnabled>? enabled = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabled>? disabled = null,
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
                typeof(global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsEnabled),
                Disabled,
                typeof(global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabled),
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
        public bool Equals(BetaManagedAgentsSessionMultiagentSubagents other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionMultiagentSubagentsEnabled?>.Default.Equals(Enabled, other.Enabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMultiagentSubagentsDisabled?>.Default.Equals(Disabled, other.Disabled)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsSessionMultiagentSubagents obj1, BetaManagedAgentsSessionMultiagentSubagents obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsSessionMultiagentSubagents>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsSessionMultiagentSubagents obj1, BetaManagedAgentsSessionMultiagentSubagents obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsSessionMultiagentSubagents o && Equals(o);
        }
    }
}
