#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Status2 : global::System.IEquatable<Status2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekControlEnabledStatusDiscriminatorType? Type { get; }

        /// <summary>
        /// No key is set for this region.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCmekRegionNotConfigured? NotConfigured { get; init; }
#else
        public global::Anthropic.BetaCmekRegionNotConfigured? NotConfigured { get; }
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
            out global::Anthropic.BetaCmekRegionNotConfigured? value)
        {
            value = NotConfigured;
            return IsNotConfigured;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekRegionNotConfigured PickNotConfigured() => NotConfigured is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NotConfigured' but the value was {ToString()}.");

        /// <summary>
        /// The region is validating the configured key, or the key has passed validation and the region has not started to apply it.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCmekRegionPending? Pending { get; init; }
#else
        public global::Anthropic.BetaCmekRegionPending? Pending { get; }
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
            out global::Anthropic.BetaCmekRegionPending? value)
        {
            value = Pending;
            return IsPending;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekRegionPending PickPending() => Pending is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Pending' but the value was {ToString()}.");

        /// <summary>
        /// The configured key passed validation, and the region applies it.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCmekRegionActive? Active { get; init; }
#else
        public global::Anthropic.BetaCmekRegionActive? Active { get; }
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
            out global::Anthropic.BetaCmekRegionActive? value)
        {
            value = Active;
            return IsActive;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekRegionActive PickActive() => Active is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Active' but the value was {ToString()}.");

        /// <summary>
        /// The region stopped retrying validation before the configured key passed. To restart validation, send the region a key again. It can be the same key.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCmekRegionFailed? Failed { get; init; }
#else
        public global::Anthropic.BetaCmekRegionFailed? Failed { get; }
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
            out global::Anthropic.BetaCmekRegionFailed? value)
        {
            value = Failed;
            return IsFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekRegionFailed PickFailed() => Failed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Failed' but the value was {ToString()}.");

        /// <summary>
        /// Anthropic has withdrawn or paused its approval of customer-managed keys for this project, so the region does not apply the control.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCmekRegionSuspended? Suspended { get; init; }
#else
        public global::Anthropic.BetaCmekRegionSuspended? Suspended { get; }
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
            out global::Anthropic.BetaCmekRegionSuspended? value)
        {
            value = Suspended;
            return IsSuspended;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCmekRegionSuspended PickSuspended() => Suspended is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Suspended' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Status2(global::Anthropic.BetaCmekRegionNotConfigured value) => new Status2((global::Anthropic.BetaCmekRegionNotConfigured?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaCmekRegionNotConfigured?(Status2 @this) => @this.NotConfigured;

        /// <summary>
        ///
        /// </summary>
        public Status2(global::Anthropic.BetaCmekRegionNotConfigured? value)
        {
            NotConfigured = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Status2 FromNotConfigured(global::Anthropic.BetaCmekRegionNotConfigured? value) => new Status2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Status2(global::Anthropic.BetaCmekRegionPending value) => new Status2((global::Anthropic.BetaCmekRegionPending?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaCmekRegionPending?(Status2 @this) => @this.Pending;

        /// <summary>
        ///
        /// </summary>
        public Status2(global::Anthropic.BetaCmekRegionPending? value)
        {
            Pending = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Status2 FromPending(global::Anthropic.BetaCmekRegionPending? value) => new Status2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Status2(global::Anthropic.BetaCmekRegionActive value) => new Status2((global::Anthropic.BetaCmekRegionActive?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaCmekRegionActive?(Status2 @this) => @this.Active;

        /// <summary>
        ///
        /// </summary>
        public Status2(global::Anthropic.BetaCmekRegionActive? value)
        {
            Active = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Status2 FromActive(global::Anthropic.BetaCmekRegionActive? value) => new Status2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Status2(global::Anthropic.BetaCmekRegionFailed value) => new Status2((global::Anthropic.BetaCmekRegionFailed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaCmekRegionFailed?(Status2 @this) => @this.Failed;

        /// <summary>
        ///
        /// </summary>
        public Status2(global::Anthropic.BetaCmekRegionFailed? value)
        {
            Failed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Status2 FromFailed(global::Anthropic.BetaCmekRegionFailed? value) => new Status2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Status2(global::Anthropic.BetaCmekRegionSuspended value) => new Status2((global::Anthropic.BetaCmekRegionSuspended?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaCmekRegionSuspended?(Status2 @this) => @this.Suspended;

        /// <summary>
        ///
        /// </summary>
        public Status2(global::Anthropic.BetaCmekRegionSuspended? value)
        {
            Suspended = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Status2 FromSuspended(global::Anthropic.BetaCmekRegionSuspended? value) => new Status2(value);

        /// <summary>
        ///
        /// </summary>
        public Status2(
            global::Anthropic.BetaCmekControlEnabledStatusDiscriminatorType? type,
            global::Anthropic.BetaCmekRegionNotConfigured? notConfigured,
            global::Anthropic.BetaCmekRegionPending? pending,
            global::Anthropic.BetaCmekRegionActive? active,
            global::Anthropic.BetaCmekRegionFailed? failed,
            global::Anthropic.BetaCmekRegionSuspended? suspended
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
            global::System.Func<global::Anthropic.BetaCmekRegionNotConfigured, TResult>? notConfigured = null,
            global::System.Func<global::Anthropic.BetaCmekRegionPending, TResult>? pending = null,
            global::System.Func<global::Anthropic.BetaCmekRegionActive, TResult>? active = null,
            global::System.Func<global::Anthropic.BetaCmekRegionFailed, TResult>? failed = null,
            global::System.Func<global::Anthropic.BetaCmekRegionSuspended, TResult>? suspended = null,
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
            global::System.Action<global::Anthropic.BetaCmekRegionNotConfigured>? notConfigured = null,

            global::System.Action<global::Anthropic.BetaCmekRegionPending>? pending = null,

            global::System.Action<global::Anthropic.BetaCmekRegionActive>? active = null,

            global::System.Action<global::Anthropic.BetaCmekRegionFailed>? failed = null,

            global::System.Action<global::Anthropic.BetaCmekRegionSuspended>? suspended = null,
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
            global::System.Action<global::Anthropic.BetaCmekRegionNotConfigured>? notConfigured = null,
            global::System.Action<global::Anthropic.BetaCmekRegionPending>? pending = null,
            global::System.Action<global::Anthropic.BetaCmekRegionActive>? active = null,
            global::System.Action<global::Anthropic.BetaCmekRegionFailed>? failed = null,
            global::System.Action<global::Anthropic.BetaCmekRegionSuspended>? suspended = null,
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
                typeof(global::Anthropic.BetaCmekRegionNotConfigured),
                Pending,
                typeof(global::Anthropic.BetaCmekRegionPending),
                Active,
                typeof(global::Anthropic.BetaCmekRegionActive),
                Failed,
                typeof(global::Anthropic.BetaCmekRegionFailed),
                Suspended,
                typeof(global::Anthropic.BetaCmekRegionSuspended),
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
        public bool Equals(Status2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCmekRegionNotConfigured?>.Default.Equals(NotConfigured, other.NotConfigured) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCmekRegionPending?>.Default.Equals(Pending, other.Pending) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCmekRegionActive?>.Default.Equals(Active, other.Active) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCmekRegionFailed?>.Default.Equals(Failed, other.Failed) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCmekRegionSuspended?>.Default.Equals(Suspended, other.Suspended)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Status2 obj1, Status2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Status2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Status2 obj1, Status2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Status2 o && Equals(o);
        }
    }
}
