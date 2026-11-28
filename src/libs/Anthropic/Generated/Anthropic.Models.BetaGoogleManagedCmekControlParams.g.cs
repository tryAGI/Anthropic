#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// How to set the `cmek` control, discriminated by `type`.
    /// </summary>
    public readonly partial struct BetaGoogleManagedCmekControlParams : global::System.IEquatable<BetaGoogleManagedCmekControlParams>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekControlParamsDiscriminatorType? Type { get; }

        /// <summary>
        /// Turns the control off and removes every region's key.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaGoogleManagedCmekDisabledParams? Disabled { get; init; }
#else
        public global::Anthropic.BetaGoogleManagedCmekDisabledParams? Disabled { get; }
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
            out global::Anthropic.BetaGoogleManagedCmekDisabledParams? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekDisabledParams PickDisabled() => Disabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");

        /// <summary>
        /// Turns the control on, or changes its keys while it is on.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaGoogleManagedCmekEnabledParams? Enabled { get; init; }
#else
        public global::Anthropic.BetaGoogleManagedCmekEnabledParams? Enabled { get; }
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
            out global::Anthropic.BetaGoogleManagedCmekEnabledParams? value)
        {
            value = Enabled;
            return IsEnabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekEnabledParams PickEnabled() => Enabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enabled' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaGoogleManagedCmekControlParams(global::Anthropic.BetaGoogleManagedCmekDisabledParams value) => new BetaGoogleManagedCmekControlParams((global::Anthropic.BetaGoogleManagedCmekDisabledParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaGoogleManagedCmekDisabledParams?(BetaGoogleManagedCmekControlParams @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedCmekControlParams(global::Anthropic.BetaGoogleManagedCmekDisabledParams? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaGoogleManagedCmekControlParams FromDisabled(global::Anthropic.BetaGoogleManagedCmekDisabledParams? value) => new BetaGoogleManagedCmekControlParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaGoogleManagedCmekControlParams(global::Anthropic.BetaGoogleManagedCmekEnabledParams value) => new BetaGoogleManagedCmekControlParams((global::Anthropic.BetaGoogleManagedCmekEnabledParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaGoogleManagedCmekEnabledParams?(BetaGoogleManagedCmekControlParams @this) => @this.Enabled;

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedCmekControlParams(global::Anthropic.BetaGoogleManagedCmekEnabledParams? value)
        {
            Enabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaGoogleManagedCmekControlParams FromEnabled(global::Anthropic.BetaGoogleManagedCmekEnabledParams? value) => new BetaGoogleManagedCmekControlParams(value);

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedCmekControlParams(
            global::Anthropic.BetaGoogleManagedCmekControlParamsDiscriminatorType? type,
            global::Anthropic.BetaGoogleManagedCmekDisabledParams? disabled,
            global::Anthropic.BetaGoogleManagedCmekEnabledParams? enabled
            )
        {
            Type = type;

            Disabled = disabled;
            Enabled = enabled;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Enabled as object ??
            Disabled as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Disabled?.ToString() ??
            Enabled?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDisabled && !IsEnabled || !IsDisabled && IsEnabled;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaGoogleManagedCmekDisabledParams, TResult>? disabled = null,
            global::System.Func<global::Anthropic.BetaGoogleManagedCmekEnabledParams, TResult>? enabled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Disabled is { } __value0 && disabled != null)
            {
                return disabled(__value0);
            }
            else if (Enabled is { } __value1 && enabled != null)
            {
                return enabled(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaGoogleManagedCmekDisabledParams>? disabled = null,

            global::System.Action<global::Anthropic.BetaGoogleManagedCmekEnabledParams>? enabled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Disabled is { } __value0)
            {
                disabled?.Invoke(__value0);
            }
            else if (Enabled is { } __value1)
            {
                enabled?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaGoogleManagedCmekDisabledParams>? disabled = null,
            global::System.Action<global::Anthropic.BetaGoogleManagedCmekEnabledParams>? enabled = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Disabled is { } __value0)
            {
                disabled?.Invoke(__value0);
            }
            else if (Enabled is { } __value1)
            {
                enabled?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Disabled,
                typeof(global::Anthropic.BetaGoogleManagedCmekDisabledParams),
                Enabled,
                typeof(global::Anthropic.BetaGoogleManagedCmekEnabledParams),
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
        public bool Equals(BetaGoogleManagedCmekControlParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaGoogleManagedCmekDisabledParams?>.Default.Equals(Disabled, other.Disabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaGoogleManagedCmekEnabledParams?>.Default.Equals(Enabled, other.Enabled)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaGoogleManagedCmekControlParams obj1, BetaGoogleManagedCmekControlParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaGoogleManagedCmekControlParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaGoogleManagedCmekControlParams obj1, BetaGoogleManagedCmekControlParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaGoogleManagedCmekControlParams o && Equals(o);
        }
    }
}
