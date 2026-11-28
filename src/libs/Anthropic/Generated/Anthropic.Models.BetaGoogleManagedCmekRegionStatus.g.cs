#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// One region's status for the `cmek` control, discriminated by `type`.
    /// </summary>
    public readonly partial struct BetaGoogleManagedCmekRegionStatus : global::System.IEquatable<BetaGoogleManagedCmekRegionStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekRegionStatusDiscriminatorType? Type { get; }

        /// <summary>
        /// No key is set for this region.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaGoogleManagedCmekRegionNotConfigured? NotConfigured { get; init; }
#else
        public global::Anthropic.BetaGoogleManagedCmekRegionNotConfigured? NotConfigured { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NotConfigured))]
#endif
        public bool IsNotConfigured => NotConfigured != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNotConfigured(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaGoogleManagedCmekRegionNotConfigured? value)
        {
            value = NotConfigured;
            return IsNotConfigured;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekRegionNotConfigured PickNotConfigured() => NotConfigured is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NotConfigured' but the value was {ToString()}.");

        /// <summary>
        /// The region is validating the configured key, or the key has passed validation and the region has not started to apply it.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaGoogleManagedCmekRegionPending? Pending { get; init; }
#else
        public global::Anthropic.BetaGoogleManagedCmekRegionPending? Pending { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pending))]
#endif
        public bool IsPending => Pending != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPending(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaGoogleManagedCmekRegionPending? value)
        {
            value = Pending;
            return IsPending;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekRegionPending PickPending() => Pending is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Pending' but the value was {ToString()}.");

        /// <summary>
        /// The configured key passed validation, and the region applies it.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaGoogleManagedCmekRegionActive? Active { get; init; }
#else
        public global::Anthropic.BetaGoogleManagedCmekRegionActive? Active { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Active))]
#endif
        public bool IsActive => Active != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickActive(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaGoogleManagedCmekRegionActive? value)
        {
            value = Active;
            return IsActive;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekRegionActive PickActive() => Active is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Active' but the value was {ToString()}.");

        /// <summary>
        /// The region stopped retrying validation before the configured key passed. To restart validation, send the region a key again. It can be the same key.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaGoogleManagedCmekRegionFailed? Failed { get; init; }
#else
        public global::Anthropic.BetaGoogleManagedCmekRegionFailed? Failed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Failed))]
#endif
        public bool IsFailed => Failed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaGoogleManagedCmekRegionFailed? value)
        {
            value = Failed;
            return IsFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekRegionFailed PickFailed() => Failed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Failed' but the value was {ToString()}.");

        /// <summary>
        /// Anthropic has withdrawn or paused its approval of customer-managed keys for this profile, so the region does not apply the control.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaGoogleManagedCmekRegionSuspended? Suspended { get; init; }
#else
        public global::Anthropic.BetaGoogleManagedCmekRegionSuspended? Suspended { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Suspended))]
#endif
        public bool IsSuspended => Suspended != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSuspended(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaGoogleManagedCmekRegionSuspended? value)
        {
            value = Suspended;
            return IsSuspended;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedCmekRegionSuspended PickSuspended() => Suspended is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Suspended' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaGoogleManagedCmekRegionStatus(global::Anthropic.BetaGoogleManagedCmekRegionNotConfigured value) => new BetaGoogleManagedCmekRegionStatus((global::Anthropic.BetaGoogleManagedCmekRegionNotConfigured?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaGoogleManagedCmekRegionNotConfigured?(BetaGoogleManagedCmekRegionStatus @this) => @this.NotConfigured;

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedCmekRegionStatus(global::Anthropic.BetaGoogleManagedCmekRegionNotConfigured? value)
        {
            NotConfigured = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaGoogleManagedCmekRegionStatus FromNotConfigured(global::Anthropic.BetaGoogleManagedCmekRegionNotConfigured? value) => new BetaGoogleManagedCmekRegionStatus(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaGoogleManagedCmekRegionStatus(global::Anthropic.BetaGoogleManagedCmekRegionPending value) => new BetaGoogleManagedCmekRegionStatus((global::Anthropic.BetaGoogleManagedCmekRegionPending?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaGoogleManagedCmekRegionPending?(BetaGoogleManagedCmekRegionStatus @this) => @this.Pending;

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedCmekRegionStatus(global::Anthropic.BetaGoogleManagedCmekRegionPending? value)
        {
            Pending = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaGoogleManagedCmekRegionStatus FromPending(global::Anthropic.BetaGoogleManagedCmekRegionPending? value) => new BetaGoogleManagedCmekRegionStatus(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaGoogleManagedCmekRegionStatus(global::Anthropic.BetaGoogleManagedCmekRegionActive value) => new BetaGoogleManagedCmekRegionStatus((global::Anthropic.BetaGoogleManagedCmekRegionActive?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaGoogleManagedCmekRegionActive?(BetaGoogleManagedCmekRegionStatus @this) => @this.Active;

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedCmekRegionStatus(global::Anthropic.BetaGoogleManagedCmekRegionActive? value)
        {
            Active = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaGoogleManagedCmekRegionStatus FromActive(global::Anthropic.BetaGoogleManagedCmekRegionActive? value) => new BetaGoogleManagedCmekRegionStatus(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaGoogleManagedCmekRegionStatus(global::Anthropic.BetaGoogleManagedCmekRegionFailed value) => new BetaGoogleManagedCmekRegionStatus((global::Anthropic.BetaGoogleManagedCmekRegionFailed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaGoogleManagedCmekRegionFailed?(BetaGoogleManagedCmekRegionStatus @this) => @this.Failed;

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedCmekRegionStatus(global::Anthropic.BetaGoogleManagedCmekRegionFailed? value)
        {
            Failed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaGoogleManagedCmekRegionStatus FromFailed(global::Anthropic.BetaGoogleManagedCmekRegionFailed? value) => new BetaGoogleManagedCmekRegionStatus(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaGoogleManagedCmekRegionStatus(global::Anthropic.BetaGoogleManagedCmekRegionSuspended value) => new BetaGoogleManagedCmekRegionStatus((global::Anthropic.BetaGoogleManagedCmekRegionSuspended?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaGoogleManagedCmekRegionSuspended?(BetaGoogleManagedCmekRegionStatus @this) => @this.Suspended;

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedCmekRegionStatus(global::Anthropic.BetaGoogleManagedCmekRegionSuspended? value)
        {
            Suspended = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaGoogleManagedCmekRegionStatus FromSuspended(global::Anthropic.BetaGoogleManagedCmekRegionSuspended? value) => new BetaGoogleManagedCmekRegionStatus(value);

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedCmekRegionStatus(
            global::Anthropic.BetaGoogleManagedCmekRegionStatusDiscriminatorType? type,
            global::Anthropic.BetaGoogleManagedCmekRegionNotConfigured? notConfigured,
            global::Anthropic.BetaGoogleManagedCmekRegionPending? pending,
            global::Anthropic.BetaGoogleManagedCmekRegionActive? active,
            global::Anthropic.BetaGoogleManagedCmekRegionFailed? failed,
            global::Anthropic.BetaGoogleManagedCmekRegionSuspended? suspended
            )
        {
            Type = type;

            NotConfigured = notConfigured;
            Pending = pending;
            Active = active;
            Failed = failed;
            Suspended = suspended;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Suspended as object ??
            Failed as object ??
            Active as object ??
            Pending as object ??
            NotConfigured as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            NotConfigured?.ToString() ??
            Pending?.ToString() ??
            Active?.ToString() ??
            Failed?.ToString() ??
            Suspended?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsNotConfigured && !IsPending && !IsActive && !IsFailed && !IsSuspended || !IsNotConfigured && IsPending && !IsActive && !IsFailed && !IsSuspended || !IsNotConfigured && !IsPending && IsActive && !IsFailed && !IsSuspended || !IsNotConfigured && !IsPending && !IsActive && IsFailed && !IsSuspended || !IsNotConfigured && !IsPending && !IsActive && !IsFailed && IsSuspended;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaGoogleManagedCmekRegionNotConfigured, TResult>? notConfigured = null,
            global::System.Func<global::Anthropic.BetaGoogleManagedCmekRegionPending, TResult>? pending = null,
            global::System.Func<global::Anthropic.BetaGoogleManagedCmekRegionActive, TResult>? active = null,
            global::System.Func<global::Anthropic.BetaGoogleManagedCmekRegionFailed, TResult>? failed = null,
            global::System.Func<global::Anthropic.BetaGoogleManagedCmekRegionSuspended, TResult>? suspended = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (NotConfigured is { } __value0 && notConfigured != null)
            {
                return notConfigured(__value0);
            }
            else if (Pending is { } __value1 && pending != null)
            {
                return pending(__value1);
            }
            else if (Active is { } __value2 && active != null)
            {
                return active(__value2);
            }
            else if (Failed is { } __value3 && failed != null)
            {
                return failed(__value3);
            }
            else if (Suspended is { } __value4 && suspended != null)
            {
                return suspended(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaGoogleManagedCmekRegionNotConfigured>? notConfigured = null,

            global::System.Action<global::Anthropic.BetaGoogleManagedCmekRegionPending>? pending = null,

            global::System.Action<global::Anthropic.BetaGoogleManagedCmekRegionActive>? active = null,

            global::System.Action<global::Anthropic.BetaGoogleManagedCmekRegionFailed>? failed = null,

            global::System.Action<global::Anthropic.BetaGoogleManagedCmekRegionSuspended>? suspended = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (NotConfigured is { } __value0)
            {
                notConfigured?.Invoke(__value0);
            }
            else if (Pending is { } __value1)
            {
                pending?.Invoke(__value1);
            }
            else if (Active is { } __value2)
            {
                active?.Invoke(__value2);
            }
            else if (Failed is { } __value3)
            {
                failed?.Invoke(__value3);
            }
            else if (Suspended is { } __value4)
            {
                suspended?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaGoogleManagedCmekRegionNotConfigured>? notConfigured = null,
            global::System.Action<global::Anthropic.BetaGoogleManagedCmekRegionPending>? pending = null,
            global::System.Action<global::Anthropic.BetaGoogleManagedCmekRegionActive>? active = null,
            global::System.Action<global::Anthropic.BetaGoogleManagedCmekRegionFailed>? failed = null,
            global::System.Action<global::Anthropic.BetaGoogleManagedCmekRegionSuspended>? suspended = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (NotConfigured is { } __value0)
            {
                notConfigured?.Invoke(__value0);
            }
            else if (Pending is { } __value1)
            {
                pending?.Invoke(__value1);
            }
            else if (Active is { } __value2)
            {
                active?.Invoke(__value2);
            }
            else if (Failed is { } __value3)
            {
                failed?.Invoke(__value3);
            }
            else if (Suspended is { } __value4)
            {
                suspended?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                NotConfigured,
                typeof(global::Anthropic.BetaGoogleManagedCmekRegionNotConfigured),
                Pending,
                typeof(global::Anthropic.BetaGoogleManagedCmekRegionPending),
                Active,
                typeof(global::Anthropic.BetaGoogleManagedCmekRegionActive),
                Failed,
                typeof(global::Anthropic.BetaGoogleManagedCmekRegionFailed),
                Suspended,
                typeof(global::Anthropic.BetaGoogleManagedCmekRegionSuspended),
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
        public bool Equals(BetaGoogleManagedCmekRegionStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaGoogleManagedCmekRegionNotConfigured?>.Default.Equals(NotConfigured, other.NotConfigured) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaGoogleManagedCmekRegionPending?>.Default.Equals(Pending, other.Pending) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaGoogleManagedCmekRegionActive?>.Default.Equals(Active, other.Active) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaGoogleManagedCmekRegionFailed?>.Default.Equals(Failed, other.Failed) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaGoogleManagedCmekRegionSuspended?>.Default.Equals(Suspended, other.Suspended)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaGoogleManagedCmekRegionStatus obj1, BetaGoogleManagedCmekRegionStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaGoogleManagedCmekRegionStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaGoogleManagedCmekRegionStatus obj1, BetaGoogleManagedCmekRegionStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaGoogleManagedCmekRegionStatus o && Equals(o);
        }
    }
}
