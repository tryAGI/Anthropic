#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ComplianceSettingsState : global::System.IEquatable<ComplianceSettingsState>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ComplianceSettingsStateEnabled? Enabled { get; init; }
#else
        public global::Anthropic.ComplianceSettingsStateEnabled? Enabled { get; }
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
            out global::Anthropic.ComplianceSettingsStateEnabled? value)
        {
            value = Enabled;
            return IsEnabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateEnabled PickEnabled() => Enabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enabled' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ComplianceSettingsStateDisabled? Disabled { get; init; }
#else
        public global::Anthropic.ComplianceSettingsStateDisabled? Disabled { get; }
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
            out global::Anthropic.ComplianceSettingsStateDisabled? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComplianceSettingsStateDisabled PickDisabled() => Disabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComplianceSettingsState(global::Anthropic.ComplianceSettingsStateEnabled value) => new ComplianceSettingsState((global::Anthropic.ComplianceSettingsStateEnabled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComplianceSettingsStateEnabled?(ComplianceSettingsState @this) => @this.Enabled;

        /// <summary>
        ///
        /// </summary>
        public ComplianceSettingsState(global::Anthropic.ComplianceSettingsStateEnabled? value)
        {
            Enabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComplianceSettingsState FromEnabled(global::Anthropic.ComplianceSettingsStateEnabled? value) => new ComplianceSettingsState(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ComplianceSettingsState(global::Anthropic.ComplianceSettingsStateDisabled value) => new ComplianceSettingsState((global::Anthropic.ComplianceSettingsStateDisabled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComplianceSettingsStateDisabled?(ComplianceSettingsState @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public ComplianceSettingsState(global::Anthropic.ComplianceSettingsStateDisabled? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ComplianceSettingsState FromDisabled(global::Anthropic.ComplianceSettingsStateDisabled? value) => new ComplianceSettingsState(value);

        /// <summary>
        ///
        /// </summary>
        public ComplianceSettingsState(
            global::Anthropic.ComplianceSettingsStateDiscriminatorType? type,
            global::Anthropic.ComplianceSettingsStateEnabled? enabled,
            global::Anthropic.ComplianceSettingsStateDisabled? disabled
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
            global::System.Func<global::Anthropic.ComplianceSettingsStateEnabled, TResult>? enabled = null,
            global::System.Func<global::Anthropic.ComplianceSettingsStateDisabled, TResult>? disabled = null,
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
            global::System.Action<global::Anthropic.ComplianceSettingsStateEnabled>? enabled = null,

            global::System.Action<global::Anthropic.ComplianceSettingsStateDisabled>? disabled = null,
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
            global::System.Action<global::Anthropic.ComplianceSettingsStateEnabled>? enabled = null,
            global::System.Action<global::Anthropic.ComplianceSettingsStateDisabled>? disabled = null,
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
                typeof(global::Anthropic.ComplianceSettingsStateEnabled),
                Disabled,
                typeof(global::Anthropic.ComplianceSettingsStateDisabled),
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
        public bool Equals(ComplianceSettingsState other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComplianceSettingsStateEnabled?>.Default.Equals(Enabled, other.Enabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComplianceSettingsStateDisabled?>.Default.Equals(Disabled, other.Disabled)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ComplianceSettingsState obj1, ComplianceSettingsState obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ComplianceSettingsState>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ComplianceSettingsState obj1, ComplianceSettingsState obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ComplianceSettingsState o && Equals(o);
        }
    }
}
