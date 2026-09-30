#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ComplianceSettingsStateParams : global::System.IEquatable<ComplianceSettingsStateParams>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateParamsDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ComplianceSettingsStateEnabledParams? Enabled { get; init; }
#else
        public global::Anthropic.ComplianceSettingsStateEnabledParams? Enabled { get; }
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
            out global::Anthropic.ComplianceSettingsStateEnabledParams? value)
        {
            value = Enabled;
            return IsEnabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateEnabledParams PickEnabled() => Enabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enabled' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ComplianceSettingsStateDisabledParams? Disabled { get; init; }
#else
        public global::Anthropic.ComplianceSettingsStateDisabledParams? Disabled { get; }
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
            out global::Anthropic.ComplianceSettingsStateDisabledParams? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDisabledParams PickDisabled() => Disabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComplianceSettingsStateParams(global::Anthropic.ComplianceSettingsStateEnabledParams value) => new ComplianceSettingsStateParams((global::Anthropic.ComplianceSettingsStateEnabledParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComplianceSettingsStateEnabledParams?(ComplianceSettingsStateParams @this) => @this.Enabled;

        /// <summary>
        ///
        /// </summary>
        public ComplianceSettingsStateParams(global::Anthropic.ComplianceSettingsStateEnabledParams? value)
        {
            Enabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComplianceSettingsStateParams FromEnabled(global::Anthropic.ComplianceSettingsStateEnabledParams? value) => new ComplianceSettingsStateParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComplianceSettingsStateParams(global::Anthropic.ComplianceSettingsStateDisabledParams value) => new ComplianceSettingsStateParams((global::Anthropic.ComplianceSettingsStateDisabledParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComplianceSettingsStateDisabledParams?(ComplianceSettingsStateParams @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public ComplianceSettingsStateParams(global::Anthropic.ComplianceSettingsStateDisabledParams? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComplianceSettingsStateParams FromDisabled(global::Anthropic.ComplianceSettingsStateDisabledParams? value) => new ComplianceSettingsStateParams(value);

        /// <summary>
        ///
        /// </summary>
        public ComplianceSettingsStateParams(
            global::Anthropic.ComplianceSettingsStateParamsDiscriminatorType? type,
            global::Anthropic.ComplianceSettingsStateEnabledParams? enabled,
            global::Anthropic.ComplianceSettingsStateDisabledParams? disabled
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
            global::System.Func<global::Anthropic.ComplianceSettingsStateEnabledParams, TResult>? enabled = null,
            global::System.Func<global::Anthropic.ComplianceSettingsStateDisabledParams, TResult>? disabled = null,
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
            global::System.Action<global::Anthropic.ComplianceSettingsStateEnabledParams>? enabled = null,

            global::System.Action<global::Anthropic.ComplianceSettingsStateDisabledParams>? disabled = null,
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
            global::System.Action<global::Anthropic.ComplianceSettingsStateEnabledParams>? enabled = null,
            global::System.Action<global::Anthropic.ComplianceSettingsStateDisabledParams>? disabled = null,
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
                typeof(global::Anthropic.ComplianceSettingsStateEnabledParams),
                Disabled,
                typeof(global::Anthropic.ComplianceSettingsStateDisabledParams),
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
        public bool Equals(ComplianceSettingsStateParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComplianceSettingsStateEnabledParams?>.Default.Equals(Enabled, other.Enabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComplianceSettingsStateDisabledParams?>.Default.Equals(Disabled, other.Disabled)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ComplianceSettingsStateParams obj1, ComplianceSettingsStateParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ComplianceSettingsStateParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ComplianceSettingsStateParams obj1, ComplianceSettingsStateParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ComplianceSettingsStateParams o && Equals(o);
        }
    }
}
