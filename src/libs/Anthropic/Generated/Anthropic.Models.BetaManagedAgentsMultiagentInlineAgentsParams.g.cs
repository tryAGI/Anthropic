#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Whether the agent can define inline agents. The agent defines an inline agent itself, in a workflow run's plan or when it spawns a session thread, and the inline agent is not saved.
    /// </summary>
    public readonly partial struct BetaManagedAgentsMultiagentInlineAgentsParams : global::System.IEquatable<BetaManagedAgentsMultiagentInlineAgentsParams>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsParamsDiscriminatorType? Type { get; }

        /// <summary>
        /// The agent can define inline agents.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabledParams? Enabled { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabledParams? Enabled { get; }
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
            out global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabledParams? value)
        {
            value = Enabled;
            return IsEnabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabledParams PickEnabled() => Enabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enabled' but the value was {ToString()}.");

        /// <summary>
        /// The agent cannot define inline agents.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabledParams? Disabled { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabledParams? Disabled { get; }
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
            out global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabledParams? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabledParams PickDisabled() => Disabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsMultiagentInlineAgentsParams(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabledParams value) => new BetaManagedAgentsMultiagentInlineAgentsParams((global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabledParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabledParams?(BetaManagedAgentsMultiagentInlineAgentsParams @this) => @this.Enabled;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentInlineAgentsParams(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabledParams? value)
        {
            Enabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsMultiagentInlineAgentsParams FromEnabled(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabledParams? value) => new BetaManagedAgentsMultiagentInlineAgentsParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsMultiagentInlineAgentsParams(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabledParams value) => new BetaManagedAgentsMultiagentInlineAgentsParams((global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabledParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabledParams?(BetaManagedAgentsMultiagentInlineAgentsParams @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentInlineAgentsParams(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabledParams? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsMultiagentInlineAgentsParams FromDisabled(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabledParams? value) => new BetaManagedAgentsMultiagentInlineAgentsParams(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentInlineAgentsParams(
            global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsParamsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabledParams? enabled,
            global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabledParams? disabled
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
            global::System.Func<global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabledParams, TResult>? enabled = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabledParams, TResult>? disabled = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabledParams>? enabled = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabledParams>? disabled = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabledParams>? enabled = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabledParams>? disabled = null,
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
                typeof(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabledParams),
                Disabled,
                typeof(global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabledParams),
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
        public bool Equals(BetaManagedAgentsMultiagentInlineAgentsParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsEnabledParams?>.Default.Equals(Enabled, other.Enabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsDisabledParams?>.Default.Equals(Disabled, other.Disabled)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsMultiagentInlineAgentsParams obj1, BetaManagedAgentsMultiagentInlineAgentsParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsMultiagentInlineAgentsParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsMultiagentInlineAgentsParams obj1, BetaManagedAgentsMultiagentInlineAgentsParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsMultiagentInlineAgentsParams o && Equals(o);
        }
    }
}
