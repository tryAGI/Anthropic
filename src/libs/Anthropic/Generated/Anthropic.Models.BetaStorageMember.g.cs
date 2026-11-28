#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaStorageMember : global::System.IEquatable<BetaStorageMember>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageMemberDiscriminatorType? Type { get; }

        /// <summary>
        /// No External Storage for this purpose.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaInternalStorage? Internal { get; init; }
#else
        public global::Anthropic.BetaInternalStorage? Internal { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Internal))]
#endif
        public bool IsInternal => Internal != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInternal(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaInternalStorage? value)
        {
            value = Internal;
            return IsInternal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInternalStorage PickInternal() => Internal is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Internal' but the value was {ToString()}.");

        /// <summary>
        /// The organization's External Storage that `external_storage_id` names.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaExternalStorageMember? External { get; init; }
#else
        public global::Anthropic.BetaExternalStorageMember? External { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(External))]
#endif
        public bool IsExternal => External != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickExternal(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaExternalStorageMember? value)
        {
            value = External;
            return IsExternal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageMember PickExternal() => External is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'External' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaStorageMember(global::Anthropic.BetaInternalStorage value) => new BetaStorageMember((global::Anthropic.BetaInternalStorage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaInternalStorage?(BetaStorageMember @this) => @this.Internal;

        /// <summary>
        ///
        /// </summary>
        public BetaStorageMember(global::Anthropic.BetaInternalStorage? value)
        {
            Internal = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaStorageMember FromInternal(global::Anthropic.BetaInternalStorage? value) => new BetaStorageMember(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaStorageMember(global::Anthropic.BetaExternalStorageMember value) => new BetaStorageMember((global::Anthropic.BetaExternalStorageMember?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaExternalStorageMember?(BetaStorageMember @this) => @this.External;

        /// <summary>
        ///
        /// </summary>
        public BetaStorageMember(global::Anthropic.BetaExternalStorageMember? value)
        {
            External = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaStorageMember FromExternal(global::Anthropic.BetaExternalStorageMember? value) => new BetaStorageMember(value);

        /// <summary>
        ///
        /// </summary>
        public BetaStorageMember(
            global::Anthropic.BetaStorageMemberDiscriminatorType? type,
            global::Anthropic.BetaInternalStorage? @internal,
            global::Anthropic.BetaExternalStorageMember? external
            )
        {
            Type = type;

            Internal = @internal;
            External = external;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            External as object ??
            Internal as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Internal?.ToString() ??
            External?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInternal && !IsExternal || !IsInternal && IsExternal;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaInternalStorage, TResult>? @internal = null,
            global::System.Func<global::Anthropic.BetaExternalStorageMember, TResult>? external = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Internal is { } __value0 && @internal != null)
            {
                return @internal(__value0);
            }
            else if (External is { } __value1 && external != null)
            {
                return external(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaInternalStorage>? @internal = null,

            global::System.Action<global::Anthropic.BetaExternalStorageMember>? external = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Internal is { } __value0)
            {
                @internal?.Invoke(__value0);
            }
            else if (External is { } __value1)
            {
                external?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaInternalStorage>? @internal = null,
            global::System.Action<global::Anthropic.BetaExternalStorageMember>? external = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Internal is { } __value0)
            {
                @internal?.Invoke(__value0);
            }
            else if (External is { } __value1)
            {
                external?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Internal,
                typeof(global::Anthropic.BetaInternalStorage),
                External,
                typeof(global::Anthropic.BetaExternalStorageMember),
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
        public bool Equals(BetaStorageMember other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaInternalStorage?>.Default.Equals(Internal, other.Internal) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaExternalStorageMember?>.Default.Equals(External, other.External)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaStorageMember obj1, BetaStorageMember obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaStorageMember>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaStorageMember obj1, BetaStorageMember obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaStorageMember o && Equals(o);
        }
    }
}
