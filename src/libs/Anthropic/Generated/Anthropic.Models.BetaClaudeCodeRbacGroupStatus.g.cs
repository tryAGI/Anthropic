#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaClaudeCodeRbacGroupStatus : global::System.IEquatable<BetaClaudeCodeRbacGroupStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupStatusDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeCodeRbacGroupStatusActive? Active { get; init; }
#else
        public global::Anthropic.BetaClaudeCodeRbacGroupStatusActive? Active { get; }
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
            out global::Anthropic.BetaClaudeCodeRbacGroupStatusActive? value)
        {
            value = Active;
            return IsActive;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupStatusActive PickActive() => Active is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Active' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted? Deleted { get; init; }
#else
        public global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted? Deleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Deleted))]
#endif
        public bool IsDeleted => Deleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted? value)
        {
            value = Deleted;
            return IsDeleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted PickDeleted() => Deleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Deleted' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown? Unknown { get; init; }
#else
        public global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown? Unknown { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Unknown))]
#endif
        public bool IsUnknown => Unknown != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnknown(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown? value)
        {
            value = Unknown;
            return IsUnknown;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown PickUnknown() => Unknown is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Unknown' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeCodeRbacGroupStatus(global::Anthropic.BetaClaudeCodeRbacGroupStatusActive value) => new BetaClaudeCodeRbacGroupStatus((global::Anthropic.BetaClaudeCodeRbacGroupStatusActive?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeCodeRbacGroupStatusActive?(BetaClaudeCodeRbacGroupStatus @this) => @this.Active;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeCodeRbacGroupStatus(global::Anthropic.BetaClaudeCodeRbacGroupStatusActive? value)
        {
            Active = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeCodeRbacGroupStatus FromActive(global::Anthropic.BetaClaudeCodeRbacGroupStatusActive? value) => new BetaClaudeCodeRbacGroupStatus(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeCodeRbacGroupStatus(global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted value) => new BetaClaudeCodeRbacGroupStatus((global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted?(BetaClaudeCodeRbacGroupStatus @this) => @this.Deleted;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeCodeRbacGroupStatus(global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted? value)
        {
            Deleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeCodeRbacGroupStatus FromDeleted(global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted? value) => new BetaClaudeCodeRbacGroupStatus(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeCodeRbacGroupStatus(global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown value) => new BetaClaudeCodeRbacGroupStatus((global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown?(BetaClaudeCodeRbacGroupStatus @this) => @this.Unknown;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeCodeRbacGroupStatus(global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown? value)
        {
            Unknown = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeCodeRbacGroupStatus FromUnknown(global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown? value) => new BetaClaudeCodeRbacGroupStatus(value);

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeCodeRbacGroupStatus(
            global::Anthropic.BetaClaudeCodeRbacGroupStatusDiscriminatorType? type,
            global::Anthropic.BetaClaudeCodeRbacGroupStatusActive? active,
            global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted? deleted,
            global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown? unknown
            )
        {
            Type = type;

            Active = active;
            Deleted = deleted;
            Unknown = unknown;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Unknown as object ??
            Deleted as object ??
            Active as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Active?.ToString() ??
            Deleted?.ToString() ??
            Unknown?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsActive && !IsDeleted && !IsUnknown || !IsActive && IsDeleted && !IsUnknown || !IsActive && !IsDeleted && IsUnknown;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaClaudeCodeRbacGroupStatusActive, TResult>? active = null,
            global::System.Func<global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted, TResult>? deleted = null,
            global::System.Func<global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown, TResult>? unknown = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Active is { } __value0 && active != null)
            {
                return active(__value0);
            }
            else if (Deleted is { } __value1 && deleted != null)
            {
                return deleted(__value1);
            }
            else if (Unknown is { } __value2 && unknown != null)
            {
                return unknown(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaClaudeCodeRbacGroupStatusActive>? active = null,

            global::System.Action<global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted>? deleted = null,

            global::System.Action<global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown>? unknown = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Active is { } __value0)
            {
                active?.Invoke(__value0);
            }
            else if (Deleted is { } __value1)
            {
                deleted?.Invoke(__value1);
            }
            else if (Unknown is { } __value2)
            {
                unknown?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaClaudeCodeRbacGroupStatusActive>? active = null,
            global::System.Action<global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted>? deleted = null,
            global::System.Action<global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown>? unknown = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Active is { } __value0)
            {
                active?.Invoke(__value0);
            }
            else if (Deleted is { } __value1)
            {
                deleted?.Invoke(__value1);
            }
            else if (Unknown is { } __value2)
            {
                unknown?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Active,
                typeof(global::Anthropic.BetaClaudeCodeRbacGroupStatusActive),
                Deleted,
                typeof(global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted),
                Unknown,
                typeof(global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown),
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
        public bool Equals(BetaClaudeCodeRbacGroupStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeCodeRbacGroupStatusActive?>.Default.Equals(Active, other.Active) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeCodeRbacGroupStatusDeleted?>.Default.Equals(Deleted, other.Deleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeCodeRbacGroupStatusUnknown?>.Default.Equals(Unknown, other.Unknown)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaClaudeCodeRbacGroupStatus obj1, BetaClaudeCodeRbacGroupStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaClaudeCodeRbacGroupStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaClaudeCodeRbacGroupStatus obj1, BetaClaudeCodeRbacGroupStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaClaudeCodeRbacGroupStatus o && Equals(o);
        }
    }
}
