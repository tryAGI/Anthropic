#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The customer-managed encryption key control: the key in your Google Cloud KMS that is set for each region. It covers the project's requests that name no user profile, or a user profile that has no key of its own for the project.
    /// </summary>
    public readonly partial struct Cmek : global::System.IEquatable<Cmek>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedProjectDataControlsCmekDiscriminatorType? Type { get; }

        /// <summary>
        /// The control is off and has no keys.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCmekControlDisabled? Disabled { get; init; }
#else
        public global::Anthropic.BetaCmekControlDisabled? Disabled { get; }
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
            out global::Anthropic.BetaCmekControlDisabled? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekControlDisabled PickDisabled() => Disabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");

        /// <summary>
        /// The control is on and has a key for at least one region.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCmekControlEnabled? Enabled { get; init; }
#else
        public global::Anthropic.BetaCmekControlEnabled? Enabled { get; }
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
            out global::Anthropic.BetaCmekControlEnabled? value)
        {
            value = Enabled;
            return IsEnabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekControlEnabled PickEnabled() => Enabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enabled' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Cmek(global::Anthropic.BetaCmekControlDisabled value) => new Cmek((global::Anthropic.BetaCmekControlDisabled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaCmekControlDisabled?(Cmek @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public Cmek(global::Anthropic.BetaCmekControlDisabled? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Cmek FromDisabled(global::Anthropic.BetaCmekControlDisabled? value) => new Cmek(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Cmek(global::Anthropic.BetaCmekControlEnabled value) => new Cmek((global::Anthropic.BetaCmekControlEnabled?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaCmekControlEnabled?(Cmek @this) => @this.Enabled;

        /// <summary>
        ///
        /// </summary>
        public Cmek(global::Anthropic.BetaCmekControlEnabled? value)
        {
            Enabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Cmek FromEnabled(global::Anthropic.BetaCmekControlEnabled? value) => new Cmek(value);

        /// <summary>
        ///
        /// </summary>
        public Cmek(
            global::Anthropic.BetaGoogleManagedProjectDataControlsCmekDiscriminatorType? type,
            global::Anthropic.BetaCmekControlDisabled? disabled,
            global::Anthropic.BetaCmekControlEnabled? enabled
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
            global::System.Func<global::Anthropic.BetaCmekControlDisabled, TResult>? disabled = null,
            global::System.Func<global::Anthropic.BetaCmekControlEnabled, TResult>? enabled = null,
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
            global::System.Action<global::Anthropic.BetaCmekControlDisabled>? disabled = null,

            global::System.Action<global::Anthropic.BetaCmekControlEnabled>? enabled = null,
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
            global::System.Action<global::Anthropic.BetaCmekControlDisabled>? disabled = null,
            global::System.Action<global::Anthropic.BetaCmekControlEnabled>? enabled = null,
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
                typeof(global::Anthropic.BetaCmekControlDisabled),
                Enabled,
                typeof(global::Anthropic.BetaCmekControlEnabled),
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
        public bool Equals(Cmek other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCmekControlDisabled?>.Default.Equals(Disabled, other.Disabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCmekControlEnabled?>.Default.Equals(Enabled, other.Enabled)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Cmek obj1, Cmek obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Cmek>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Cmek obj1, Cmek obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Cmek o && Equals(o);
        }
    }
}
