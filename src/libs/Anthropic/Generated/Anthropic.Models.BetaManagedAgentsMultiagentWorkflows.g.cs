#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Whether the agent can start workflow runs.
    /// </summary>
    public readonly partial struct BetaManagedAgentsMultiagentWorkflows : global::System.IEquatable<BetaManagedAgentsMultiagentWorkflows>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDiscriminatorType? Type { get; }

        /// <summary>
        /// The agent can start workflow runs.<br/>
        /// Example: {"type":"enabled","inline_agents":{"type":"disabled"},"predefined_agents":[{"type":"agent","id":"agent_011CZkYqphY8vELVzwCUpqiQ","version":1}]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabled? Enabled { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabled? Enabled { get; }
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
            out global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabled? value)
        {
            value = Enabled;
            return IsEnabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabled PickEnabled() => Enabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enabled' but the value was {ToString()}.");

        /// <summary>
        /// The agent cannot start workflow runs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabled? Disabled { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabled? Disabled { get; }
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
            out global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabled? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabled PickDisabled() => Disabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsMultiagentWorkflows(global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabled value) => new BetaManagedAgentsMultiagentWorkflows((global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabled?(BetaManagedAgentsMultiagentWorkflows @this) => @this.Enabled;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentWorkflows(global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabled? value)
        {
            Enabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsMultiagentWorkflows FromEnabled(global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabled? value) => new BetaManagedAgentsMultiagentWorkflows(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsMultiagentWorkflows(global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabled value) => new BetaManagedAgentsMultiagentWorkflows((global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabled?(BetaManagedAgentsMultiagentWorkflows @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentWorkflows(global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabled? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsMultiagentWorkflows FromDisabled(global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabled? value) => new BetaManagedAgentsMultiagentWorkflows(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsMultiagentWorkflows(
            global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabled? enabled,
            global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabled? disabled
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
            global::System.Func<global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabled, TResult>? enabled = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabled, TResult>? disabled = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabled>? enabled = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabled>? disabled = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabled>? enabled = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabled>? disabled = null,
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
                typeof(global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabled),
                Disabled,
                typeof(global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabled),
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
        public bool Equals(BetaManagedAgentsMultiagentWorkflows other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMultiagentWorkflowsEnabled?>.Default.Equals(Enabled, other.Enabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMultiagentWorkflowsDisabled?>.Default.Equals(Disabled, other.Disabled)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsMultiagentWorkflows obj1, BetaManagedAgentsMultiagentWorkflows obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsMultiagentWorkflows>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsMultiagentWorkflows obj1, BetaManagedAgentsMultiagentWorkflows obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsMultiagentWorkflows o && Equals(o);
        }
    }
}
