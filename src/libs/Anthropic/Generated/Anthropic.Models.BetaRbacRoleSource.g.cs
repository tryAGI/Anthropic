#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaRbacRoleSource : global::System.IEquatable<BetaRbacRoleSource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRoleSourceDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRbacRoleSourceBuiltIn? BuiltIn { get; init; }
#else
        public global::Anthropic.BetaRbacRoleSourceBuiltIn? BuiltIn { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BuiltIn))]
#endif
        public bool IsBuiltIn => BuiltIn != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBuiltIn(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRbacRoleSourceBuiltIn? value)
        {
            value = BuiltIn;
            return IsBuiltIn;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRoleSourceBuiltIn PickBuiltIn() => BuiltIn is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BuiltIn' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRbacRoleSourceCustom? Custom { get; init; }
#else
        public global::Anthropic.BetaRbacRoleSourceCustom? Custom { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustom(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRbacRoleSourceCustom? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRoleSourceCustom PickCustom() => Custom is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaRbacRoleSource(global::Anthropic.BetaRbacRoleSourceBuiltIn value) => new BetaRbacRoleSource((global::Anthropic.BetaRbacRoleSourceBuiltIn?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRbacRoleSourceBuiltIn?(BetaRbacRoleSource @this) => @this.BuiltIn;

        /// <summary>
        ///
        /// </summary>
        public BetaRbacRoleSource(global::Anthropic.BetaRbacRoleSourceBuiltIn? value)
        {
            BuiltIn = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaRbacRoleSource FromBuiltIn(global::Anthropic.BetaRbacRoleSourceBuiltIn? value) => new BetaRbacRoleSource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaRbacRoleSource(global::Anthropic.BetaRbacRoleSourceCustom value) => new BetaRbacRoleSource((global::Anthropic.BetaRbacRoleSourceCustom?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRbacRoleSourceCustom?(BetaRbacRoleSource @this) => @this.Custom;

        /// <summary>
        ///
        /// </summary>
        public BetaRbacRoleSource(global::Anthropic.BetaRbacRoleSourceCustom? value)
        {
            Custom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaRbacRoleSource FromCustom(global::Anthropic.BetaRbacRoleSourceCustom? value) => new BetaRbacRoleSource(value);

        /// <summary>
        ///
        /// </summary>
        public BetaRbacRoleSource(
            global::Anthropic.BetaRbacRoleSourceDiscriminatorType? type,
            global::Anthropic.BetaRbacRoleSourceBuiltIn? builtIn,
            global::Anthropic.BetaRbacRoleSourceCustom? custom
            )
        {
            Type = type;

            BuiltIn = builtIn;
            Custom = custom;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Custom as object ??
            BuiltIn as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BuiltIn?.ToString() ??
            Custom?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBuiltIn && !IsCustom || !IsBuiltIn && IsCustom;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaRbacRoleSourceBuiltIn, TResult>? builtIn = null,
            global::System.Func<global::Anthropic.BetaRbacRoleSourceCustom, TResult>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BuiltIn is { } __value0 && builtIn != null)
            {
                return builtIn(__value0);
            }
            else if (Custom is { } __value1 && custom != null)
            {
                return custom(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaRbacRoleSourceBuiltIn>? builtIn = null,

            global::System.Action<global::Anthropic.BetaRbacRoleSourceCustom>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BuiltIn is { } __value0)
            {
                builtIn?.Invoke(__value0);
            }
            else if (Custom is { } __value1)
            {
                custom?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaRbacRoleSourceBuiltIn>? builtIn = null,
            global::System.Action<global::Anthropic.BetaRbacRoleSourceCustom>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BuiltIn is { } __value0)
            {
                builtIn?.Invoke(__value0);
            }
            else if (Custom is { } __value1)
            {
                custom?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BuiltIn,
                typeof(global::Anthropic.BetaRbacRoleSourceBuiltIn),
                Custom,
                typeof(global::Anthropic.BetaRbacRoleSourceCustom),
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
        public bool Equals(BetaRbacRoleSource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRbacRoleSourceBuiltIn?>.Default.Equals(BuiltIn, other.BuiltIn) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRbacRoleSourceCustom?>.Default.Equals(Custom, other.Custom)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaRbacRoleSource obj1, BetaRbacRoleSource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaRbacRoleSource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaRbacRoleSource obj1, BetaRbacRoleSource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaRbacRoleSource o && Equals(o);
        }
    }
}
