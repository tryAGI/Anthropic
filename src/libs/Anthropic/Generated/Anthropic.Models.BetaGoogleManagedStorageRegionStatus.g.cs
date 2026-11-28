#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// One region's status for the `storage` control, discriminated by `type`.
    /// </summary>
    public readonly partial struct BetaGoogleManagedStorageRegionStatus : global::System.IEquatable<BetaGoogleManagedStorageRegionStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageRegionStatusDiscriminatorType? Type { get; }

        /// <summary>
        /// No bucket is set for this region.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured? NotConfigured { get; init; }
#else
        public global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured? NotConfigured { get; }
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
            out global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured? value)
        {
            value = NotConfigured;
            return IsNotConfigured;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured PickNotConfigured() => NotConfigured is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NotConfigured' but the value was {ToString()}.");

        /// <summary>
        /// The region is verifying the configured bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaGoogleManagedStorageRegionPending? Pending { get; init; }
#else
        public global::Anthropic.BetaGoogleManagedStorageRegionPending? Pending { get; }
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
            out global::Anthropic.BetaGoogleManagedStorageRegionPending? value)
        {
            value = Pending;
            return IsPending;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageRegionPending PickPending() => Pending is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Pending' but the value was {ToString()}.");

        /// <summary>
        /// The configured bucket passed verification, and the region applies it.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaGoogleManagedStorageRegionActive? Active { get; init; }
#else
        public global::Anthropic.BetaGoogleManagedStorageRegionActive? Active { get; }
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
            out global::Anthropic.BetaGoogleManagedStorageRegionActive? value)
        {
            value = Active;
            return IsActive;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageRegionActive PickActive() => Active is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Active' but the value was {ToString()}.");

        /// <summary>
        /// The region stopped retrying verification before the configured bucket passed. To restart verification, send the region a bucket again. It can be the same bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaGoogleManagedStorageRegionFailed? Failed { get; init; }
#else
        public global::Anthropic.BetaGoogleManagedStorageRegionFailed? Failed { get; }
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
            out global::Anthropic.BetaGoogleManagedStorageRegionFailed? value)
        {
            value = Failed;
            return IsFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageRegionFailed PickFailed() => Failed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Failed' but the value was {ToString()}.");

        /// <summary>
        /// Anthropic has withdrawn or paused its approval of customer-owned storage for this profile, so the region does not apply the control.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaGoogleManagedStorageRegionSuspended? Suspended { get; init; }
#else
        public global::Anthropic.BetaGoogleManagedStorageRegionSuspended? Suspended { get; }
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
            out global::Anthropic.BetaGoogleManagedStorageRegionSuspended? value)
        {
            value = Suspended;
            return IsSuspended;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaGoogleManagedStorageRegionSuspended PickSuspended() => Suspended is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Suspended' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaGoogleManagedStorageRegionStatus(global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured value) => new BetaGoogleManagedStorageRegionStatus((global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured?(BetaGoogleManagedStorageRegionStatus @this) => @this.NotConfigured;

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedStorageRegionStatus(global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured? value)
        {
            NotConfigured = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaGoogleManagedStorageRegionStatus FromNotConfigured(global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured? value) => new BetaGoogleManagedStorageRegionStatus(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaGoogleManagedStorageRegionStatus(global::Anthropic.BetaGoogleManagedStorageRegionPending value) => new BetaGoogleManagedStorageRegionStatus((global::Anthropic.BetaGoogleManagedStorageRegionPending?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaGoogleManagedStorageRegionPending?(BetaGoogleManagedStorageRegionStatus @this) => @this.Pending;

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedStorageRegionStatus(global::Anthropic.BetaGoogleManagedStorageRegionPending? value)
        {
            Pending = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaGoogleManagedStorageRegionStatus FromPending(global::Anthropic.BetaGoogleManagedStorageRegionPending? value) => new BetaGoogleManagedStorageRegionStatus(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaGoogleManagedStorageRegionStatus(global::Anthropic.BetaGoogleManagedStorageRegionActive value) => new BetaGoogleManagedStorageRegionStatus((global::Anthropic.BetaGoogleManagedStorageRegionActive?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaGoogleManagedStorageRegionActive?(BetaGoogleManagedStorageRegionStatus @this) => @this.Active;

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedStorageRegionStatus(global::Anthropic.BetaGoogleManagedStorageRegionActive? value)
        {
            Active = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaGoogleManagedStorageRegionStatus FromActive(global::Anthropic.BetaGoogleManagedStorageRegionActive? value) => new BetaGoogleManagedStorageRegionStatus(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaGoogleManagedStorageRegionStatus(global::Anthropic.BetaGoogleManagedStorageRegionFailed value) => new BetaGoogleManagedStorageRegionStatus((global::Anthropic.BetaGoogleManagedStorageRegionFailed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaGoogleManagedStorageRegionFailed?(BetaGoogleManagedStorageRegionStatus @this) => @this.Failed;

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedStorageRegionStatus(global::Anthropic.BetaGoogleManagedStorageRegionFailed? value)
        {
            Failed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaGoogleManagedStorageRegionStatus FromFailed(global::Anthropic.BetaGoogleManagedStorageRegionFailed? value) => new BetaGoogleManagedStorageRegionStatus(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaGoogleManagedStorageRegionStatus(global::Anthropic.BetaGoogleManagedStorageRegionSuspended value) => new BetaGoogleManagedStorageRegionStatus((global::Anthropic.BetaGoogleManagedStorageRegionSuspended?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaGoogleManagedStorageRegionSuspended?(BetaGoogleManagedStorageRegionStatus @this) => @this.Suspended;

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedStorageRegionStatus(global::Anthropic.BetaGoogleManagedStorageRegionSuspended? value)
        {
            Suspended = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaGoogleManagedStorageRegionStatus FromSuspended(global::Anthropic.BetaGoogleManagedStorageRegionSuspended? value) => new BetaGoogleManagedStorageRegionStatus(value);

        /// <summary>
        ///
        /// </summary>
        public BetaGoogleManagedStorageRegionStatus(
            global::Anthropic.BetaGoogleManagedStorageRegionStatusDiscriminatorType? type,
            global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured? notConfigured,
            global::Anthropic.BetaGoogleManagedStorageRegionPending? pending,
            global::Anthropic.BetaGoogleManagedStorageRegionActive? active,
            global::Anthropic.BetaGoogleManagedStorageRegionFailed? failed,
            global::Anthropic.BetaGoogleManagedStorageRegionSuspended? suspended
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
            global::System.Func<global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured, TResult>? notConfigured = null,
            global::System.Func<global::Anthropic.BetaGoogleManagedStorageRegionPending, TResult>? pending = null,
            global::System.Func<global::Anthropic.BetaGoogleManagedStorageRegionActive, TResult>? active = null,
            global::System.Func<global::Anthropic.BetaGoogleManagedStorageRegionFailed, TResult>? failed = null,
            global::System.Func<global::Anthropic.BetaGoogleManagedStorageRegionSuspended, TResult>? suspended = null,
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
            global::System.Action<global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured>? notConfigured = null,

            global::System.Action<global::Anthropic.BetaGoogleManagedStorageRegionPending>? pending = null,

            global::System.Action<global::Anthropic.BetaGoogleManagedStorageRegionActive>? active = null,

            global::System.Action<global::Anthropic.BetaGoogleManagedStorageRegionFailed>? failed = null,

            global::System.Action<global::Anthropic.BetaGoogleManagedStorageRegionSuspended>? suspended = null,
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
            global::System.Action<global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured>? notConfigured = null,
            global::System.Action<global::Anthropic.BetaGoogleManagedStorageRegionPending>? pending = null,
            global::System.Action<global::Anthropic.BetaGoogleManagedStorageRegionActive>? active = null,
            global::System.Action<global::Anthropic.BetaGoogleManagedStorageRegionFailed>? failed = null,
            global::System.Action<global::Anthropic.BetaGoogleManagedStorageRegionSuspended>? suspended = null,
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
                typeof(global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured),
                Pending,
                typeof(global::Anthropic.BetaGoogleManagedStorageRegionPending),
                Active,
                typeof(global::Anthropic.BetaGoogleManagedStorageRegionActive),
                Failed,
                typeof(global::Anthropic.BetaGoogleManagedStorageRegionFailed),
                Suspended,
                typeof(global::Anthropic.BetaGoogleManagedStorageRegionSuspended),
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
        public bool Equals(BetaGoogleManagedStorageRegionStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaGoogleManagedStorageRegionNotConfigured?>.Default.Equals(NotConfigured, other.NotConfigured) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaGoogleManagedStorageRegionPending?>.Default.Equals(Pending, other.Pending) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaGoogleManagedStorageRegionActive?>.Default.Equals(Active, other.Active) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaGoogleManagedStorageRegionFailed?>.Default.Equals(Failed, other.Failed) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaGoogleManagedStorageRegionSuspended?>.Default.Equals(Suspended, other.Suspended)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaGoogleManagedStorageRegionStatus obj1, BetaGoogleManagedStorageRegionStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaGoogleManagedStorageRegionStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaGoogleManagedStorageRegionStatus obj1, BetaGoogleManagedStorageRegionStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaGoogleManagedStorageRegionStatus o && Equals(o);
        }
    }
}
