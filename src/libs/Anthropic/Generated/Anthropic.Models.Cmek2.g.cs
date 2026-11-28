#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The customer-managed encryption key control. Leave it out to keep the control as it is. Send `cmek`, `storage`, or both.
    /// </summary>
    public readonly partial struct Cmek2 : global::System.IEquatable<Cmek2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedProjectDataControlsUpdateParamsCmekDiscriminatorType? Type { get; }

        /// <summary>
        /// Turns the control off and removes every region's key.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCmekControlDisabledParams? Disabled { get; init; }
#else
        public global::Anthropic.BetaCmekControlDisabledParams? Disabled { get; }
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
            out global::Anthropic.BetaCmekControlDisabledParams? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekControlDisabledParams PickDisabled() => Disabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");

        /// <summary>
        /// Turns the control on, or changes its keys while it is on.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCmekControlEnabledParams? Enabled { get; init; }
#else
        public global::Anthropic.BetaCmekControlEnabledParams? Enabled { get; }
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
            out global::Anthropic.BetaCmekControlEnabledParams? value)
        {
            value = Enabled;
            return IsEnabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekControlEnabledParams PickEnabled() => Enabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enabled' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Cmek2(global::Anthropic.BetaCmekControlDisabledParams value) => new Cmek2((global::Anthropic.BetaCmekControlDisabledParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaCmekControlDisabledParams?(Cmek2 @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public Cmek2(global::Anthropic.BetaCmekControlDisabledParams? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Cmek2 FromDisabled(global::Anthropic.BetaCmekControlDisabledParams? value) => new Cmek2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Cmek2(global::Anthropic.BetaCmekControlEnabledParams value) => new Cmek2((global::Anthropic.BetaCmekControlEnabledParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaCmekControlEnabledParams?(Cmek2 @this) => @this.Enabled;

        /// <summary>
        ///
        /// </summary>
        public Cmek2(global::Anthropic.BetaCmekControlEnabledParams? value)
        {
            Enabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Cmek2 FromEnabled(global::Anthropic.BetaCmekControlEnabledParams? value) => new Cmek2(value);

        /// <summary>
        ///
        /// </summary>
        public Cmek2(
            global::Anthropic.BetaGoogleManagedProjectDataControlsUpdateParamsCmekDiscriminatorType? type,
            global::Anthropic.BetaCmekControlDisabledParams? disabled,
            global::Anthropic.BetaCmekControlEnabledParams? enabled
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
            global::System.Func<global::Anthropic.BetaCmekControlDisabledParams, TResult>? disabled = null,
            global::System.Func<global::Anthropic.BetaCmekControlEnabledParams, TResult>? enabled = null,
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
            global::System.Action<global::Anthropic.BetaCmekControlDisabledParams>? disabled = null,

            global::System.Action<global::Anthropic.BetaCmekControlEnabledParams>? enabled = null,
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
            global::System.Action<global::Anthropic.BetaCmekControlDisabledParams>? disabled = null,
            global::System.Action<global::Anthropic.BetaCmekControlEnabledParams>? enabled = null,
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
                typeof(global::Anthropic.BetaCmekControlDisabledParams),
                Enabled,
                typeof(global::Anthropic.BetaCmekControlEnabledParams),
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
        public bool Equals(Cmek2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCmekControlDisabledParams?>.Default.Equals(Disabled, other.Disabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCmekControlEnabledParams?>.Default.Equals(Enabled, other.Enabled)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Cmek2 obj1, Cmek2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Cmek2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Cmek2 obj1, Cmek2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Cmek2 o && Equals(o);
        }
    }
}
