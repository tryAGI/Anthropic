#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// How to set the `storage` control, discriminated by `type`.
    /// </summary>
    public readonly partial struct BetaGoogleManagedStorageControlParams : global::System.IEquatable<BetaGoogleManagedStorageControlParams>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageControlParamsDiscriminatorType? Type { get; }

        /// <summary>
        /// Turns the control off and removes every region's bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaGoogleManagedStorageDisabledParams? Disabled { get; init; }
#else
        public global::Anthropic.BetaGoogleManagedStorageDisabledParams? Disabled { get; }
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
            out global::Anthropic.BetaGoogleManagedStorageDisabledParams? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageDisabledParams PickDisabled() => Disabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");

        /// <summary>
        /// Turns the control on, or changes its buckets while it is on.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaGoogleManagedStorageEnabledParams? Enabled { get; init; }
#else
        public global::Anthropic.BetaGoogleManagedStorageEnabledParams? Enabled { get; }
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
            out global::Anthropic.BetaGoogleManagedStorageEnabledParams? value)
        {
            value = Enabled;
            return IsEnabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageEnabledParams PickEnabled() => Enabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enabled' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaGoogleManagedStorageControlParams(global::Anthropic.BetaGoogleManagedStorageDisabledParams value) => new BetaGoogleManagedStorageControlParams((global::Anthropic.BetaGoogleManagedStorageDisabledParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaGoogleManagedStorageDisabledParams?(BetaGoogleManagedStorageControlParams @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedStorageControlParams(global::Anthropic.BetaGoogleManagedStorageDisabledParams? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaGoogleManagedStorageControlParams FromDisabled(global::Anthropic.BetaGoogleManagedStorageDisabledParams? value) => new BetaGoogleManagedStorageControlParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaGoogleManagedStorageControlParams(global::Anthropic.BetaGoogleManagedStorageEnabledParams value) => new BetaGoogleManagedStorageControlParams((global::Anthropic.BetaGoogleManagedStorageEnabledParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaGoogleManagedStorageEnabledParams?(BetaGoogleManagedStorageControlParams @this) => @this.Enabled;

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedStorageControlParams(global::Anthropic.BetaGoogleManagedStorageEnabledParams? value)
        {
            Enabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaGoogleManagedStorageControlParams FromEnabled(global::Anthropic.BetaGoogleManagedStorageEnabledParams? value) => new BetaGoogleManagedStorageControlParams(value);

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedStorageControlParams(
            global::Anthropic.BetaGoogleManagedStorageControlParamsDiscriminatorType? type,
            global::Anthropic.BetaGoogleManagedStorageDisabledParams? disabled,
            global::Anthropic.BetaGoogleManagedStorageEnabledParams? enabled
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
            global::System.Func<global::Anthropic.BetaGoogleManagedStorageDisabledParams, TResult>? disabled = null,
            global::System.Func<global::Anthropic.BetaGoogleManagedStorageEnabledParams, TResult>? enabled = null,
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
            global::System.Action<global::Anthropic.BetaGoogleManagedStorageDisabledParams>? disabled = null,

            global::System.Action<global::Anthropic.BetaGoogleManagedStorageEnabledParams>? enabled = null,
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
            global::System.Action<global::Anthropic.BetaGoogleManagedStorageDisabledParams>? disabled = null,
            global::System.Action<global::Anthropic.BetaGoogleManagedStorageEnabledParams>? enabled = null,
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
                typeof(global::Anthropic.BetaGoogleManagedStorageDisabledParams),
                Enabled,
                typeof(global::Anthropic.BetaGoogleManagedStorageEnabledParams),
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
        public bool Equals(BetaGoogleManagedStorageControlParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaGoogleManagedStorageDisabledParams?>.Default.Equals(Disabled, other.Disabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaGoogleManagedStorageEnabledParams?>.Default.Equals(Enabled, other.Enabled)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaGoogleManagedStorageControlParams obj1, BetaGoogleManagedStorageControlParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaGoogleManagedStorageControlParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaGoogleManagedStorageControlParams obj1, BetaGoogleManagedStorageControlParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaGoogleManagedStorageControlParams o && Equals(o);
        }
    }
}
