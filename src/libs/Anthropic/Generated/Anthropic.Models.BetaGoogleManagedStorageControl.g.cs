#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The customer-owned storage control, discriminated by `type`.
    /// </summary>
    public readonly partial struct BetaGoogleManagedStorageControl : global::System.IEquatable<BetaGoogleManagedStorageControl>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageControlDiscriminatorType? Type { get; }

        /// <summary>
        /// The control is off and has no buckets.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaGoogleManagedStorageDisabled? Disabled { get; init; }
#else
        public global::Anthropic.BetaGoogleManagedStorageDisabled? Disabled { get; }
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
            out global::Anthropic.BetaGoogleManagedStorageDisabled? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageDisabled PickDisabled() => Disabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");

        /// <summary>
        /// The control is on and has a bucket for at least one region.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaGoogleManagedStorageEnabled? Enabled { get; init; }
#else
        public global::Anthropic.BetaGoogleManagedStorageEnabled? Enabled { get; }
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
            out global::Anthropic.BetaGoogleManagedStorageEnabled? value)
        {
            value = Enabled;
            return IsEnabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageEnabled PickEnabled() => Enabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enabled' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaGoogleManagedStorageControl(global::Anthropic.BetaGoogleManagedStorageDisabled value) => new BetaGoogleManagedStorageControl((global::Anthropic.BetaGoogleManagedStorageDisabled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaGoogleManagedStorageDisabled?(BetaGoogleManagedStorageControl @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedStorageControl(global::Anthropic.BetaGoogleManagedStorageDisabled? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaGoogleManagedStorageControl FromDisabled(global::Anthropic.BetaGoogleManagedStorageDisabled? value) => new BetaGoogleManagedStorageControl(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaGoogleManagedStorageControl(global::Anthropic.BetaGoogleManagedStorageEnabled value) => new BetaGoogleManagedStorageControl((global::Anthropic.BetaGoogleManagedStorageEnabled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaGoogleManagedStorageEnabled?(BetaGoogleManagedStorageControl @this) => @this.Enabled;

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedStorageControl(global::Anthropic.BetaGoogleManagedStorageEnabled? value)
        {
            Enabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaGoogleManagedStorageControl FromEnabled(global::Anthropic.BetaGoogleManagedStorageEnabled? value) => new BetaGoogleManagedStorageControl(value);

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedStorageControl(
            global::Anthropic.BetaGoogleManagedStorageControlDiscriminatorType? type,
            global::Anthropic.BetaGoogleManagedStorageDisabled? disabled,
            global::Anthropic.BetaGoogleManagedStorageEnabled? enabled
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
            global::System.Func<global::Anthropic.BetaGoogleManagedStorageDisabled, TResult>? disabled = null,
            global::System.Func<global::Anthropic.BetaGoogleManagedStorageEnabled, TResult>? enabled = null,
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
            global::System.Action<global::Anthropic.BetaGoogleManagedStorageDisabled>? disabled = null,

            global::System.Action<global::Anthropic.BetaGoogleManagedStorageEnabled>? enabled = null,
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
            global::System.Action<global::Anthropic.BetaGoogleManagedStorageDisabled>? disabled = null,
            global::System.Action<global::Anthropic.BetaGoogleManagedStorageEnabled>? enabled = null,
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
                typeof(global::Anthropic.BetaGoogleManagedStorageDisabled),
                Enabled,
                typeof(global::Anthropic.BetaGoogleManagedStorageEnabled),
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
        public bool Equals(BetaGoogleManagedStorageControl other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaGoogleManagedStorageDisabled?>.Default.Equals(Disabled, other.Disabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaGoogleManagedStorageEnabled?>.Default.Equals(Enabled, other.Enabled)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaGoogleManagedStorageControl obj1, BetaGoogleManagedStorageControl obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaGoogleManagedStorageControl>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaGoogleManagedStorageControl obj1, BetaGoogleManagedStorageControl obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaGoogleManagedStorageControl o && Equals(o);
        }
    }
}
