#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Status4 : global::System.IEquatable<Status4>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageControlEnabledStatusDiscriminatorType? Type { get; }

        /// <summary>
        /// No bucket is set for this region.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaStorageRegionNotConfigured? NotConfigured { get; init; }
#else
        public global::Anthropic.BetaStorageRegionNotConfigured? NotConfigured { get; }
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
            out global::Anthropic.BetaStorageRegionNotConfigured? value)
        {
            value = NotConfigured;
            return IsNotConfigured;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageRegionNotConfigured PickNotConfigured() => NotConfigured is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NotConfigured' but the value was {ToString()}.");

        /// <summary>
        /// The region is verifying the configured bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaStorageRegionPending? Pending { get; init; }
#else
        public global::Anthropic.BetaStorageRegionPending? Pending { get; }
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
            out global::Anthropic.BetaStorageRegionPending? value)
        {
            value = Pending;
            return IsPending;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageRegionPending PickPending() => Pending is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Pending' but the value was {ToString()}.");

        /// <summary>
        /// The configured bucket passed verification, and the region applies it.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaStorageRegionActive? Active { get; init; }
#else
        public global::Anthropic.BetaStorageRegionActive? Active { get; }
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
            out global::Anthropic.BetaStorageRegionActive? value)
        {
            value = Active;
            return IsActive;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageRegionActive PickActive() => Active is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Active' but the value was {ToString()}.");

        /// <summary>
        /// The region stopped retrying verification before the configured bucket passed. To restart verification, send the region a bucket again. It can be the same bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaStorageRegionFailed? Failed { get; init; }
#else
        public global::Anthropic.BetaStorageRegionFailed? Failed { get; }
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
            out global::Anthropic.BetaStorageRegionFailed? value)
        {
            value = Failed;
            return IsFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageRegionFailed PickFailed() => Failed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Failed' but the value was {ToString()}.");

        /// <summary>
        /// Anthropic has withdrawn or paused its approval of customer-owned storage for this project, so the region does not apply the control.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaStorageRegionSuspended? Suspended { get; init; }
#else
        public global::Anthropic.BetaStorageRegionSuspended? Suspended { get; }
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
            out global::Anthropic.BetaStorageRegionSuspended? value)
        {
            value = Suspended;
            return IsSuspended;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageRegionSuspended PickSuspended() => Suspended is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Suspended' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Status4(global::Anthropic.BetaStorageRegionNotConfigured value) => new Status4((global::Anthropic.BetaStorageRegionNotConfigured?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaStorageRegionNotConfigured?(Status4 @this) => @this.NotConfigured;

        /// <summary>
        ///
        /// </summary>
        public Status4(global::Anthropic.BetaStorageRegionNotConfigured? value)
        {
            NotConfigured = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Status4 FromNotConfigured(global::Anthropic.BetaStorageRegionNotConfigured? value) => new Status4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Status4(global::Anthropic.BetaStorageRegionPending value) => new Status4((global::Anthropic.BetaStorageRegionPending?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaStorageRegionPending?(Status4 @this) => @this.Pending;

        /// <summary>
        ///
        /// </summary>
        public Status4(global::Anthropic.BetaStorageRegionPending? value)
        {
            Pending = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Status4 FromPending(global::Anthropic.BetaStorageRegionPending? value) => new Status4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Status4(global::Anthropic.BetaStorageRegionActive value) => new Status4((global::Anthropic.BetaStorageRegionActive?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaStorageRegionActive?(Status4 @this) => @this.Active;

        /// <summary>
        ///
        /// </summary>
        public Status4(global::Anthropic.BetaStorageRegionActive? value)
        {
            Active = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Status4 FromActive(global::Anthropic.BetaStorageRegionActive? value) => new Status4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Status4(global::Anthropic.BetaStorageRegionFailed value) => new Status4((global::Anthropic.BetaStorageRegionFailed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaStorageRegionFailed?(Status4 @this) => @this.Failed;

        /// <summary>
        ///
        /// </summary>
        public Status4(global::Anthropic.BetaStorageRegionFailed? value)
        {
            Failed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Status4 FromFailed(global::Anthropic.BetaStorageRegionFailed? value) => new Status4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Status4(global::Anthropic.BetaStorageRegionSuspended value) => new Status4((global::Anthropic.BetaStorageRegionSuspended?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaStorageRegionSuspended?(Status4 @this) => @this.Suspended;

        /// <summary>
        ///
        /// </summary>
        public Status4(global::Anthropic.BetaStorageRegionSuspended? value)
        {
            Suspended = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Status4 FromSuspended(global::Anthropic.BetaStorageRegionSuspended? value) => new Status4(value);

        /// <summary>
        ///
        /// </summary>
        public Status4(
            global::Anthropic.BetaStorageControlEnabledStatusDiscriminatorType? type,
            global::Anthropic.BetaStorageRegionNotConfigured? notConfigured,
            global::Anthropic.BetaStorageRegionPending? pending,
            global::Anthropic.BetaStorageRegionActive? active,
            global::Anthropic.BetaStorageRegionFailed? failed,
            global::Anthropic.BetaStorageRegionSuspended? suspended
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
            global::System.Func<global::Anthropic.BetaStorageRegionNotConfigured, TResult>? notConfigured = null,
            global::System.Func<global::Anthropic.BetaStorageRegionPending, TResult>? pending = null,
            global::System.Func<global::Anthropic.BetaStorageRegionActive, TResult>? active = null,
            global::System.Func<global::Anthropic.BetaStorageRegionFailed, TResult>? failed = null,
            global::System.Func<global::Anthropic.BetaStorageRegionSuspended, TResult>? suspended = null,
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
            global::System.Action<global::Anthropic.BetaStorageRegionNotConfigured>? notConfigured = null,

            global::System.Action<global::Anthropic.BetaStorageRegionPending>? pending = null,

            global::System.Action<global::Anthropic.BetaStorageRegionActive>? active = null,

            global::System.Action<global::Anthropic.BetaStorageRegionFailed>? failed = null,

            global::System.Action<global::Anthropic.BetaStorageRegionSuspended>? suspended = null,
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
            global::System.Action<global::Anthropic.BetaStorageRegionNotConfigured>? notConfigured = null,
            global::System.Action<global::Anthropic.BetaStorageRegionPending>? pending = null,
            global::System.Action<global::Anthropic.BetaStorageRegionActive>? active = null,
            global::System.Action<global::Anthropic.BetaStorageRegionFailed>? failed = null,
            global::System.Action<global::Anthropic.BetaStorageRegionSuspended>? suspended = null,
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
                typeof(global::Anthropic.BetaStorageRegionNotConfigured),
                Pending,
                typeof(global::Anthropic.BetaStorageRegionPending),
                Active,
                typeof(global::Anthropic.BetaStorageRegionActive),
                Failed,
                typeof(global::Anthropic.BetaStorageRegionFailed),
                Suspended,
                typeof(global::Anthropic.BetaStorageRegionSuspended),
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
        public bool Equals(Status4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaStorageRegionNotConfigured?>.Default.Equals(NotConfigured, other.NotConfigured) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaStorageRegionPending?>.Default.Equals(Pending, other.Pending) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaStorageRegionActive?>.Default.Equals(Active, other.Active) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaStorageRegionFailed?>.Default.Equals(Failed, other.Failed) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaStorageRegionSuspended?>.Default.Equals(Suspended, other.Suspended)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Status4 obj1, Status4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Status4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Status4 obj1, Status4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Status4 o && Equals(o);
        }
    }
}
