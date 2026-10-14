#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Whether a telemetry destination receives deliveries.<br/>
    /// A caller can set either state. The API also disables an enabled destination on its own in some cases. The `reason` of the disabled state says whether a caller or the API disabled the destination and, when the API did, why.<br/>
    /// See the [OpenTelemetry export guide](https://platform.claude.com/docs/en/manage-claude/opentelemetry#delivery-and-health) to learn when the API disables a destination.
    /// </summary>
    public readonly partial struct BetaTelemetryDestinationState : global::System.IEquatable<BetaTelemetryDestinationState>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDiscriminatorType? Type { get; }

        /// <summary>
        /// The telemetry destination receives the spans of the workspaces that it covers.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTelemetryDestinationStateEnabled? Enabled { get; init; }
#else
        public global::Anthropic.BetaTelemetryDestinationStateEnabled? Enabled { get; }
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
            out global::Anthropic.BetaTelemetryDestinationStateEnabled? value)
        {
            value = Enabled;
            return IsEnabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateEnabled PickEnabled() => Enabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enabled' but the value was {ToString()}.");

        /// <summary>
        /// The API doesn't deliver anything to the telemetry destination.<br/>
        /// Spans produced while it is disabled aren't delivered later.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTelemetryDestinationStateDisabled? Disabled { get; init; }
#else
        public global::Anthropic.BetaTelemetryDestinationStateDisabled? Disabled { get; }
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
            out global::Anthropic.BetaTelemetryDestinationStateDisabled? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDisabled PickDisabled() => Disabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaTelemetryDestinationState(global::Anthropic.BetaTelemetryDestinationStateEnabled value) => new BetaTelemetryDestinationState((global::Anthropic.BetaTelemetryDestinationStateEnabled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTelemetryDestinationStateEnabled?(BetaTelemetryDestinationState @this) => @this.Enabled;

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationState(global::Anthropic.BetaTelemetryDestinationStateEnabled? value)
        {
            Enabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaTelemetryDestinationState FromEnabled(global::Anthropic.BetaTelemetryDestinationStateEnabled? value) => new BetaTelemetryDestinationState(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaTelemetryDestinationState(global::Anthropic.BetaTelemetryDestinationStateDisabled value) => new BetaTelemetryDestinationState((global::Anthropic.BetaTelemetryDestinationStateDisabled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTelemetryDestinationStateDisabled?(BetaTelemetryDestinationState @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationState(global::Anthropic.BetaTelemetryDestinationStateDisabled? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaTelemetryDestinationState FromDisabled(global::Anthropic.BetaTelemetryDestinationStateDisabled? value) => new BetaTelemetryDestinationState(value);

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationState(
            global::Anthropic.BetaTelemetryDestinationStateDiscriminatorType? type,
            global::Anthropic.BetaTelemetryDestinationStateEnabled? enabled,
            global::Anthropic.BetaTelemetryDestinationStateDisabled? disabled
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
            global::System.Func<global::Anthropic.BetaTelemetryDestinationStateEnabled, TResult>? enabled = null,
            global::System.Func<global::Anthropic.BetaTelemetryDestinationStateDisabled, TResult>? disabled = null,
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
            global::System.Action<global::Anthropic.BetaTelemetryDestinationStateEnabled>? enabled = null,

            global::System.Action<global::Anthropic.BetaTelemetryDestinationStateDisabled>? disabled = null,
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
            global::System.Action<global::Anthropic.BetaTelemetryDestinationStateEnabled>? enabled = null,
            global::System.Action<global::Anthropic.BetaTelemetryDestinationStateDisabled>? disabled = null,
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
                typeof(global::Anthropic.BetaTelemetryDestinationStateEnabled),
                Disabled,
                typeof(global::Anthropic.BetaTelemetryDestinationStateDisabled),
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
        public bool Equals(BetaTelemetryDestinationState other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTelemetryDestinationStateEnabled?>.Default.Equals(Enabled, other.Enabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTelemetryDestinationStateDisabled?>.Default.Equals(Disabled, other.Disabled)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaTelemetryDestinationState obj1, BetaTelemetryDestinationState obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaTelemetryDestinationState>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaTelemetryDestinationState obj1, BetaTelemetryDestinationState obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaTelemetryDestinationState o && Equals(o);
        }
    }
}
