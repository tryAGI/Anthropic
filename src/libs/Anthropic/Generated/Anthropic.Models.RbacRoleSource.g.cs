#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct RbacRoleSource : global::System.IEquatable<RbacRoleSource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRoleSourceDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RbacRoleSourceBuiltIn? BuiltIn { get; init; }
#else
        public global::Anthropic.RbacRoleSourceBuiltIn? BuiltIn { get; }
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
            out global::Anthropic.RbacRoleSourceBuiltIn? value)
        {
            value = BuiltIn;
            return IsBuiltIn;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRoleSourceBuiltIn PickBuiltIn() => BuiltIn is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BuiltIn' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RbacRoleSourceCustom? Custom { get; init; }
#else
        public global::Anthropic.RbacRoleSourceCustom? Custom { get; }
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
            out global::Anthropic.RbacRoleSourceCustom? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRoleSourceCustom PickCustom() => Custom is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RbacRoleSource(global::Anthropic.RbacRoleSourceBuiltIn value) => new RbacRoleSource((global::Anthropic.RbacRoleSourceBuiltIn?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.RbacRoleSourceBuiltIn?(RbacRoleSource @this) => @this.BuiltIn;

        /// <summary>
        ///
        /// </summary>
        public RbacRoleSource(global::Anthropic.RbacRoleSourceBuiltIn? value)
        {
            BuiltIn = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RbacRoleSource FromBuiltIn(global::Anthropic.RbacRoleSourceBuiltIn? value) => new RbacRoleSource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RbacRoleSource(global::Anthropic.RbacRoleSourceCustom value) => new RbacRoleSource((global::Anthropic.RbacRoleSourceCustom?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.RbacRoleSourceCustom?(RbacRoleSource @this) => @this.Custom;

        /// <summary>
        ///
        /// </summary>
        public RbacRoleSource(global::Anthropic.RbacRoleSourceCustom? value)
        {
            Custom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RbacRoleSource FromCustom(global::Anthropic.RbacRoleSourceCustom? value) => new RbacRoleSource(value);

        /// <summary>
        ///
        /// </summary>
        public RbacRoleSource(
            global::Anthropic.RbacRoleSourceDiscriminatorType? type,
            global::Anthropic.RbacRoleSourceBuiltIn? builtIn,
            global::Anthropic.RbacRoleSourceCustom? custom
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
            global::System.Func<global::Anthropic.RbacRoleSourceBuiltIn, TResult>? builtIn = null,
            global::System.Func<global::Anthropic.RbacRoleSourceCustom, TResult>? custom = null,
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
            global::System.Action<global::Anthropic.RbacRoleSourceBuiltIn>? builtIn = null,

            global::System.Action<global::Anthropic.RbacRoleSourceCustom>? custom = null,
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
            global::System.Action<global::Anthropic.RbacRoleSourceBuiltIn>? builtIn = null,
            global::System.Action<global::Anthropic.RbacRoleSourceCustom>? custom = null,
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
                typeof(global::Anthropic.RbacRoleSourceBuiltIn),
                Custom,
                typeof(global::Anthropic.RbacRoleSourceCustom),
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
        public bool Equals(RbacRoleSource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RbacRoleSourceBuiltIn?>.Default.Equals(BuiltIn, other.BuiltIn) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RbacRoleSourceCustom?>.Default.Equals(Custom, other.Custom)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RbacRoleSource obj1, RbacRoleSource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RbacRoleSource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RbacRoleSource obj1, RbacRoleSource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RbacRoleSource o && Equals(o);
        }
    }
}
