#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The customer-owned storage control. Leave it out to keep the control as it is. Send `cmek`, `storage`, or both.
    /// </summary>
    public readonly partial struct Storage2 : global::System.IEquatable<Storage2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedProjectDataControlsUpdateParamsStorageDiscriminatorType? Type { get; }

        /// <summary>
        /// Turns the control off and removes every region's bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaStorageControlDisabledParams? Disabled { get; init; }
#else
        public global::Anthropic.BetaStorageControlDisabledParams? Disabled { get; }
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
            out global::Anthropic.BetaStorageControlDisabledParams? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageControlDisabledParams PickDisabled() => Disabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");

        /// <summary>
        /// Turns the control on, or changes its buckets while it is on.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaStorageControlEnabledParams? Enabled { get; init; }
#else
        public global::Anthropic.BetaStorageControlEnabledParams? Enabled { get; }
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
            out global::Anthropic.BetaStorageControlEnabledParams? value)
        {
            value = Enabled;
            return IsEnabled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageControlEnabledParams PickEnabled() => Enabled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enabled' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Storage2(global::Anthropic.BetaStorageControlDisabledParams value) => new Storage2((global::Anthropic.BetaStorageControlDisabledParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaStorageControlDisabledParams?(Storage2 @this) => @this.Disabled;

        /// <summary>
        ///
        /// </summary>
        public Storage2(global::Anthropic.BetaStorageControlDisabledParams? value)
        {
            Disabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Storage2 FromDisabled(global::Anthropic.BetaStorageControlDisabledParams? value) => new Storage2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Storage2(global::Anthropic.BetaStorageControlEnabledParams value) => new Storage2((global::Anthropic.BetaStorageControlEnabledParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaStorageControlEnabledParams?(Storage2 @this) => @this.Enabled;

        /// <summary>
        ///
        /// </summary>
        public Storage2(global::Anthropic.BetaStorageControlEnabledParams? value)
        {
            Enabled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Storage2 FromEnabled(global::Anthropic.BetaStorageControlEnabledParams? value) => new Storage2(value);

        /// <summary>
        ///
        /// </summary>
        public Storage2(
            global::Anthropic.BetaGoogleManagedProjectDataControlsUpdateParamsStorageDiscriminatorType? type,
            global::Anthropic.BetaStorageControlDisabledParams? disabled,
            global::Anthropic.BetaStorageControlEnabledParams? enabled
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
            global::System.Func<global::Anthropic.BetaStorageControlDisabledParams, TResult>? disabled = null,
            global::System.Func<global::Anthropic.BetaStorageControlEnabledParams, TResult>? enabled = null,
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
            global::System.Action<global::Anthropic.BetaStorageControlDisabledParams>? disabled = null,

            global::System.Action<global::Anthropic.BetaStorageControlEnabledParams>? enabled = null,
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
            global::System.Action<global::Anthropic.BetaStorageControlDisabledParams>? disabled = null,
            global::System.Action<global::Anthropic.BetaStorageControlEnabledParams>? enabled = null,
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
                typeof(global::Anthropic.BetaStorageControlDisabledParams),
                Enabled,
                typeof(global::Anthropic.BetaStorageControlEnabledParams),
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
        public bool Equals(Storage2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaStorageControlDisabledParams?>.Default.Equals(Disabled, other.Disabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaStorageControlEnabledParams?>.Default.Equals(Enabled, other.Enabled)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Storage2 obj1, Storage2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Storage2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Storage2 obj1, Storage2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Storage2 o && Equals(o);
        }
    }
}
