#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Desired state. Accepts the string shorthand "enabled" or "disabled" in place of the object form; the response always returns the canonical object form.
    /// </summary>
    public readonly partial struct State2 : global::System.IEquatable<State2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsUpdateParamsStateDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComplianceSettingsStateEnabledParams? Enabled { get; init; }
#else
        public global::Anthropic.BetaComplianceSettingsStateEnabledParams? Enabled { get; }
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
            out global::Anthropic.BetaComplianceSettingsStateEnabledParams? value)
        {
            value = Enabled;
            return IsEnabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateEnabledParams PickEnabled() => IsEnabled
            ? Enabled!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enabled' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComplianceSettingsStateDisabledParams? Disabled { get; init; }
#else
        public global::Anthropic.BetaComplianceSettingsStateDisabledParams? Disabled { get; }
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
            out global::Anthropic.BetaComplianceSettingsStateDisabledParams? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceSettingsStateDisabledParams PickDisabled() => IsDisabled
            ? Disabled!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator State2(global::Anthropic.BetaComplianceSettingsStateEnabledParams value) => new State2((global::Anthropic.BetaComplianceSettingsStateEnabledParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComplianceSettingsStateEnabledParams?(State2 @this) => @this.Enabled;

        /// <summary>
        ///
        /// </summary>
        public State2(global::Anthropic.BetaComplianceSettingsStateEnabledParams? value)
        {
            Enabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static State2 FromEnabled(global::Anthropic.BetaComplianceSettingsStateEnabledParams? value) => new State2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator State2(global::Anthropic.BetaComplianceSettingsStateDisabledParams value) => new State2((global::Anthropic.BetaComplianceSettingsStateDisabledParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComplianceSettingsStateDisabledParams?(State2 @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public State2(global::Anthropic.BetaComplianceSettingsStateDisabledParams? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static State2 FromDisabled(global::Anthropic.BetaComplianceSettingsStateDisabledParams? value) => new State2(value);

        /// <summary>
        ///
        /// </summary>
        public State2(
            global::Anthropic.BetaComplianceSettingsUpdateParamsStateDiscriminatorType? type,
            global::Anthropic.BetaComplianceSettingsStateEnabledParams? enabled,
            global::Anthropic.BetaComplianceSettingsStateDisabledParams? disabled
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
            global::System.Func<global::Anthropic.BetaComplianceSettingsStateEnabledParams, TResult>? enabled = null,
            global::System.Func<global::Anthropic.BetaComplianceSettingsStateDisabledParams, TResult>? disabled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnabled && enabled != null)
            {
                return enabled(Enabled!);
            }
            else if (IsDisabled && disabled != null)
            {
                return disabled(Disabled!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaComplianceSettingsStateEnabledParams>? enabled = null,

            global::System.Action<global::Anthropic.BetaComplianceSettingsStateDisabledParams>? disabled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnabled)
            {
                enabled?.Invoke(Enabled!);
            }
            else if (IsDisabled)
            {
                disabled?.Invoke(Disabled!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaComplianceSettingsStateEnabledParams>? enabled = null,
            global::System.Action<global::Anthropic.BetaComplianceSettingsStateDisabledParams>? disabled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnabled)
            {
                enabled?.Invoke(Enabled!);
            }
            else if (IsDisabled)
            {
                disabled?.Invoke(Disabled!);
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
                typeof(global::Anthropic.BetaComplianceSettingsStateEnabledParams),
                Disabled,
                typeof(global::Anthropic.BetaComplianceSettingsStateDisabledParams),
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
        public bool Equals(State2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComplianceSettingsStateEnabledParams?>.Default.Equals(Enabled, other.Enabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComplianceSettingsStateDisabledParams?>.Default.Equals(Disabled, other.Disabled)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(State2 obj1, State2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<State2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(State2 obj1, State2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is State2 o && Equals(o);
        }
    }
}
