#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The state to set on a telemetry destination, by `type` alone.<br/>
    /// A caller can't set the `reason` of a disabled state. Only the API sets it.
    /// </summary>
    public readonly partial struct BetaTelemetryDestinationStateParams : global::System.IEquatable<BetaTelemetryDestinationStateParams>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateParamsDiscriminatorType? Type { get; }

        /// <summary>
        /// Start deliveries to the telemetry destination again.<br/>
        /// This doesn't reset `delivery_health`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTelemetryDestinationStateEnabledParams? Enabled { get; init; }
#else
        public global::Anthropic.BetaTelemetryDestinationStateEnabledParams? Enabled { get; }
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
            out global::Anthropic.BetaTelemetryDestinationStateEnabledParams? value)
        {
            value = Enabled;
            return IsEnabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateEnabledParams PickEnabled() => Enabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enabled' but the value was {ToString()}.");

        /// <summary>
        /// Stop deliveries to the telemetry destination.<br/>
        /// Spans produced while it is disabled aren't delivered later. A destination that is already disabled keeps its `reason`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTelemetryDestinationStateDisabledParams? Disabled { get; init; }
#else
        public global::Anthropic.BetaTelemetryDestinationStateDisabledParams? Disabled { get; }
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
            out global::Anthropic.BetaTelemetryDestinationStateDisabledParams? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationStateDisabledParams PickDisabled() => Disabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaTelemetryDestinationStateParams(global::Anthropic.BetaTelemetryDestinationStateEnabledParams value) => new BetaTelemetryDestinationStateParams((global::Anthropic.BetaTelemetryDestinationStateEnabledParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTelemetryDestinationStateEnabledParams?(BetaTelemetryDestinationStateParams @this) => @this.Enabled;

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationStateParams(global::Anthropic.BetaTelemetryDestinationStateEnabledParams? value)
        {
            Enabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaTelemetryDestinationStateParams FromEnabled(global::Anthropic.BetaTelemetryDestinationStateEnabledParams? value) => new BetaTelemetryDestinationStateParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaTelemetryDestinationStateParams(global::Anthropic.BetaTelemetryDestinationStateDisabledParams value) => new BetaTelemetryDestinationStateParams((global::Anthropic.BetaTelemetryDestinationStateDisabledParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTelemetryDestinationStateDisabledParams?(BetaTelemetryDestinationStateParams @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationStateParams(global::Anthropic.BetaTelemetryDestinationStateDisabledParams? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaTelemetryDestinationStateParams FromDisabled(global::Anthropic.BetaTelemetryDestinationStateDisabledParams? value) => new BetaTelemetryDestinationStateParams(value);

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationStateParams(
            global::Anthropic.BetaTelemetryDestinationStateParamsDiscriminatorType? type,
            global::Anthropic.BetaTelemetryDestinationStateEnabledParams? enabled,
            global::Anthropic.BetaTelemetryDestinationStateDisabledParams? disabled
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
            global::System.Func<global::Anthropic.BetaTelemetryDestinationStateEnabledParams, TResult>? enabled = null,
            global::System.Func<global::Anthropic.BetaTelemetryDestinationStateDisabledParams, TResult>? disabled = null,
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
            global::System.Action<global::Anthropic.BetaTelemetryDestinationStateEnabledParams>? enabled = null,

            global::System.Action<global::Anthropic.BetaTelemetryDestinationStateDisabledParams>? disabled = null,
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
            global::System.Action<global::Anthropic.BetaTelemetryDestinationStateEnabledParams>? enabled = null,
            global::System.Action<global::Anthropic.BetaTelemetryDestinationStateDisabledParams>? disabled = null,
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
                typeof(global::Anthropic.BetaTelemetryDestinationStateEnabledParams),
                Disabled,
                typeof(global::Anthropic.BetaTelemetryDestinationStateDisabledParams),
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
        public bool Equals(BetaTelemetryDestinationStateParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTelemetryDestinationStateEnabledParams?>.Default.Equals(Enabled, other.Enabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTelemetryDestinationStateDisabledParams?>.Default.Equals(Disabled, other.Disabled)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaTelemetryDestinationStateParams obj1, BetaTelemetryDestinationStateParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaTelemetryDestinationStateParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaTelemetryDestinationStateParams obj1, BetaTelemetryDestinationStateParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaTelemetryDestinationStateParams o && Equals(o);
        }
    }
}
