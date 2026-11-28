#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaStorageMemberParams : global::System.IEquatable<BetaStorageMemberParams>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaStorageMemberParamsDiscriminatorType? Type { get; }

        /// <summary>
        /// No External Storage for this purpose.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaInternalStorageParams? Internal { get; init; }
#else
        public global::Anthropic.BetaInternalStorageParams? Internal { get; }
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
            out global::Anthropic.BetaInternalStorageParams? value)
        {
            value = Internal;
            return IsInternal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInternalStorageParams PickInternal() => Internal is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Internal' but the value was {ToString()}.");

        /// <summary>
        /// The organization's External Storage that `external_storage_id` names.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaExternalStorageMemberParams? External { get; init; }
#else
        public global::Anthropic.BetaExternalStorageMemberParams? External { get; }
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
            out global::Anthropic.BetaExternalStorageMemberParams? value)
        {
            value = External;
            return IsExternal;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageMemberParams PickExternal() => External is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'External' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaStorageMemberParams(global::Anthropic.BetaInternalStorageParams value) => new BetaStorageMemberParams((global::Anthropic.BetaInternalStorageParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaInternalStorageParams?(BetaStorageMemberParams @this) => @this.Internal;

        /// <summary>
        ///
        /// </summary>
        public BetaStorageMemberParams(global::Anthropic.BetaInternalStorageParams? value)
        {
            Internal = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaStorageMemberParams FromInternal(global::Anthropic.BetaInternalStorageParams? value) => new BetaStorageMemberParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaStorageMemberParams(global::Anthropic.BetaExternalStorageMemberParams value) => new BetaStorageMemberParams((global::Anthropic.BetaExternalStorageMemberParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaExternalStorageMemberParams?(BetaStorageMemberParams @this) => @this.External;

        /// <summary>
        ///
        /// </summary>
        public BetaStorageMemberParams(global::Anthropic.BetaExternalStorageMemberParams? value)
        {
            External = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaStorageMemberParams FromExternal(global::Anthropic.BetaExternalStorageMemberParams? value) => new BetaStorageMemberParams(value);

        /// <summary>
        ///
        /// </summary>
        public BetaStorageMemberParams(
            global::Anthropic.BetaStorageMemberParamsDiscriminatorType? type,
            global::Anthropic.BetaInternalStorageParams? @internal,
            global::Anthropic.BetaExternalStorageMemberParams? external
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
            global::System.Func<global::Anthropic.BetaInternalStorageParams, TResult>? @internal = null,
            global::System.Func<global::Anthropic.BetaExternalStorageMemberParams, TResult>? external = null,
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
            global::System.Action<global::Anthropic.BetaInternalStorageParams>? @internal = null,

            global::System.Action<global::Anthropic.BetaExternalStorageMemberParams>? external = null,
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
            global::System.Action<global::Anthropic.BetaInternalStorageParams>? @internal = null,
            global::System.Action<global::Anthropic.BetaExternalStorageMemberParams>? external = null,
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
                typeof(global::Anthropic.BetaInternalStorageParams),
                External,
                typeof(global::Anthropic.BetaExternalStorageMemberParams),
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
        public bool Equals(BetaStorageMemberParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaInternalStorageParams?>.Default.Equals(Internal, other.Internal) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaExternalStorageMemberParams?>.Default.Equals(External, other.External)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaStorageMemberParams obj1, BetaStorageMemberParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaStorageMemberParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaStorageMemberParams obj1, BetaStorageMemberParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaStorageMemberParams o && Equals(o);
        }
    }
}
