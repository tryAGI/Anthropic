#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The customer-owned storage control: your Cloud Storage bucket that is set for each region. It covers the project's requests that name no user profile, or a user profile that has no bucket of its own for the project.
    /// </summary>
    public readonly partial struct Storage : global::System.IEquatable<Storage>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedProjectDataControlsStorageDiscriminatorType? Type { get; }

        /// <summary>
        /// The control is off and has no buckets.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaStorageControlDisabled? Disabled { get; init; }
#else
        public global::Anthropic.BetaStorageControlDisabled? Disabled { get; }
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
            out global::Anthropic.BetaStorageControlDisabled? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageControlDisabled PickDisabled() => Disabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");

        /// <summary>
        /// The control is on and has a bucket for at least one region.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaStorageControlEnabled? Enabled { get; init; }
#else
        public global::Anthropic.BetaStorageControlEnabled? Enabled { get; }
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
            out global::Anthropic.BetaStorageControlEnabled? value)
        {
            value = Enabled;
            return IsEnabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageControlEnabled PickEnabled() => Enabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enabled' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Storage(global::Anthropic.BetaStorageControlDisabled value) => new Storage((global::Anthropic.BetaStorageControlDisabled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaStorageControlDisabled?(Storage @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public Storage(global::Anthropic.BetaStorageControlDisabled? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Storage FromDisabled(global::Anthropic.BetaStorageControlDisabled? value) => new Storage(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Storage(global::Anthropic.BetaStorageControlEnabled value) => new Storage((global::Anthropic.BetaStorageControlEnabled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaStorageControlEnabled?(Storage @this) => @this.Enabled;

        /// <summary>
        ///
        /// </summary>
        public Storage(global::Anthropic.BetaStorageControlEnabled? value)
        {
            Enabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Storage FromEnabled(global::Anthropic.BetaStorageControlEnabled? value) => new Storage(value);

        /// <summary>
        ///
        /// </summary>
        public Storage(
            global::Anthropic.BetaGoogleManagedProjectDataControlsStorageDiscriminatorType? type,
            global::Anthropic.BetaStorageControlDisabled? disabled,
            global::Anthropic.BetaStorageControlEnabled? enabled
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
            global::System.Func<global::Anthropic.BetaStorageControlDisabled, TResult>? disabled = null,
            global::System.Func<global::Anthropic.BetaStorageControlEnabled, TResult>? enabled = null,
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
            global::System.Action<global::Anthropic.BetaStorageControlDisabled>? disabled = null,

            global::System.Action<global::Anthropic.BetaStorageControlEnabled>? enabled = null,
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
            global::System.Action<global::Anthropic.BetaStorageControlDisabled>? disabled = null,
            global::System.Action<global::Anthropic.BetaStorageControlEnabled>? enabled = null,
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
                typeof(global::Anthropic.BetaStorageControlDisabled),
                Enabled,
                typeof(global::Anthropic.BetaStorageControlEnabled),
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
        public bool Equals(Storage other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaStorageControlDisabled?>.Default.Equals(Disabled, other.Disabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaStorageControlEnabled?>.Default.Equals(Enabled, other.Enabled)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Storage obj1, Storage obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Storage>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Storage obj1, Storage obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Storage o && Equals(o);
        }
    }
}
