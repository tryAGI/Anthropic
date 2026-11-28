#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The customer-managed encryption key control, discriminated by `type`.
    /// </summary>
    public readonly partial struct BetaGoogleManagedCmekControl : global::System.IEquatable<BetaGoogleManagedCmekControl>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekControlDiscriminatorType? Type { get; }

        /// <summary>
        /// The control is off and has no keys.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaGoogleManagedCmekDisabled? Disabled { get; init; }
#else
        public global::Anthropic.BetaGoogleManagedCmekDisabled? Disabled { get; }
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
            out global::Anthropic.BetaGoogleManagedCmekDisabled? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekDisabled PickDisabled() => Disabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");

        /// <summary>
        /// The control is on and has a key for at least one region.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaGoogleManagedCmekEnabled? Enabled { get; init; }
#else
        public global::Anthropic.BetaGoogleManagedCmekEnabled? Enabled { get; }
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
            out global::Anthropic.BetaGoogleManagedCmekEnabled? value)
        {
            value = Enabled;
            return IsEnabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekEnabled PickEnabled() => Enabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enabled' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaGoogleManagedCmekControl(global::Anthropic.BetaGoogleManagedCmekDisabled value) => new BetaGoogleManagedCmekControl((global::Anthropic.BetaGoogleManagedCmekDisabled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaGoogleManagedCmekDisabled?(BetaGoogleManagedCmekControl @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedCmekControl(global::Anthropic.BetaGoogleManagedCmekDisabled? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaGoogleManagedCmekControl FromDisabled(global::Anthropic.BetaGoogleManagedCmekDisabled? value) => new BetaGoogleManagedCmekControl(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaGoogleManagedCmekControl(global::Anthropic.BetaGoogleManagedCmekEnabled value) => new BetaGoogleManagedCmekControl((global::Anthropic.BetaGoogleManagedCmekEnabled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaGoogleManagedCmekEnabled?(BetaGoogleManagedCmekControl @this) => @this.Enabled;

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedCmekControl(global::Anthropic.BetaGoogleManagedCmekEnabled? value)
        {
            Enabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaGoogleManagedCmekControl FromEnabled(global::Anthropic.BetaGoogleManagedCmekEnabled? value) => new BetaGoogleManagedCmekControl(value);

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedCmekControl(
            global::Anthropic.BetaGoogleManagedCmekControlDiscriminatorType? type,
            global::Anthropic.BetaGoogleManagedCmekDisabled? disabled,
            global::Anthropic.BetaGoogleManagedCmekEnabled? enabled
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
            global::System.Func<global::Anthropic.BetaGoogleManagedCmekDisabled, TResult>? disabled = null,
            global::System.Func<global::Anthropic.BetaGoogleManagedCmekEnabled, TResult>? enabled = null,
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
            global::System.Action<global::Anthropic.BetaGoogleManagedCmekDisabled>? disabled = null,

            global::System.Action<global::Anthropic.BetaGoogleManagedCmekEnabled>? enabled = null,
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
            global::System.Action<global::Anthropic.BetaGoogleManagedCmekDisabled>? disabled = null,
            global::System.Action<global::Anthropic.BetaGoogleManagedCmekEnabled>? enabled = null,
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
                typeof(global::Anthropic.BetaGoogleManagedCmekDisabled),
                Enabled,
                typeof(global::Anthropic.BetaGoogleManagedCmekEnabled),
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
        public bool Equals(BetaGoogleManagedCmekControl other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaGoogleManagedCmekDisabled?>.Default.Equals(Disabled, other.Disabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaGoogleManagedCmekEnabled?>.Default.Equals(Enabled, other.Enabled)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaGoogleManagedCmekControl obj1, BetaGoogleManagedCmekControl obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaGoogleManagedCmekControl>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaGoogleManagedCmekControl obj1, BetaGoogleManagedCmekControl obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaGoogleManagedCmekControl o && Equals(o);
        }
    }
}
