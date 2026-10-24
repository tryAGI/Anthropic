#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A limit Anthropic has placed on the entity this profile represents and not yet resolved, discriminated by `type`: `restriction` or `ban`. More types may be added; read a `type` you do not recognize as `restriction`.
    /// </summary>
    public readonly partial struct UserProfileEnforcementAction : global::System.IEquatable<UserProfileEnforcementAction>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionDiscriminatorType? Type { get; }

        /// <summary>
        /// Anthropic has limited how it serves the end user until the action is resolved. The end user may still be served in part.<br/>
        /// Example: {"type":"restriction","id":"enac_011CZkZCu8hGbp5mYRQgUmz9","reason":"fraud_or_abuse","action":"verify","opened_at":"2026-10-02T19:30:00Z","expires_at":null}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.UserProfileEnforcementActionRestriction? Restriction { get; init; }
#else
        public global::Anthropic.UserProfileEnforcementActionRestriction? Restriction { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Restriction))]
#endif
        public bool IsRestriction => Restriction != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRestriction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.UserProfileEnforcementActionRestriction? value)
        {
            value = Restriction;
            return IsRestriction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionRestriction PickRestriction() => Restriction is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Restriction' but the value was {ToString()}.");

        /// <summary>
        /// Anthropic has stopped serving the end user where the ban applies and does not plan to serve them there again.<br/>
        /// Example: {"type":"ban","id":"enac_011CZkZCu8hGbp5mYRQgUmz9","reason":"usage_policy_violation","action":null,"opened_at":"2026-10-02T19:30:00Z","expires_at":null}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.UserProfileEnforcementActionBan? Ban { get; init; }
#else
        public global::Anthropic.UserProfileEnforcementActionBan? Ban { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ban))]
#endif
        public bool IsBan => Ban != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBan(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.UserProfileEnforcementActionBan? value)
        {
            value = Ban;
            return IsBan;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserProfileEnforcementActionBan PickBan() => Ban is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Ban' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UserProfileEnforcementAction(global::Anthropic.UserProfileEnforcementActionRestriction value) => new UserProfileEnforcementAction((global::Anthropic.UserProfileEnforcementActionRestriction?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.UserProfileEnforcementActionRestriction?(UserProfileEnforcementAction @this) => @this.Restriction;

        /// <summary>
        ///
        /// </summary>
        public UserProfileEnforcementAction(global::Anthropic.UserProfileEnforcementActionRestriction? value)
        {
            Restriction = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UserProfileEnforcementAction FromRestriction(global::Anthropic.UserProfileEnforcementActionRestriction? value) => new UserProfileEnforcementAction(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UserProfileEnforcementAction(global::Anthropic.UserProfileEnforcementActionBan value) => new UserProfileEnforcementAction((global::Anthropic.UserProfileEnforcementActionBan?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.UserProfileEnforcementActionBan?(UserProfileEnforcementAction @this) => @this.Ban;

        /// <summary>
        ///
        /// </summary>
        public UserProfileEnforcementAction(global::Anthropic.UserProfileEnforcementActionBan? value)
        {
            Ban = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UserProfileEnforcementAction FromBan(global::Anthropic.UserProfileEnforcementActionBan? value) => new UserProfileEnforcementAction(value);

        /// <summary>
        ///
        /// </summary>
        public UserProfileEnforcementAction(
            global::Anthropic.UserProfileEnforcementActionDiscriminatorType? type,
            global::Anthropic.UserProfileEnforcementActionRestriction? restriction,
            global::Anthropic.UserProfileEnforcementActionBan? ban
            )
        {
            Type = type;

            Restriction = restriction;
            Ban = ban;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Ban as object ??
            Restriction as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Restriction?.ToString() ??
            Ban?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRestriction && !IsBan || !IsRestriction && IsBan;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.UserProfileEnforcementActionRestriction, TResult>? restriction = null,
            global::System.Func<global::Anthropic.UserProfileEnforcementActionBan, TResult>? ban = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Restriction is { } __value0 && restriction != null)
            {
                return restriction(__value0);
            }
            else if (Ban is { } __value1 && ban != null)
            {
                return ban(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.UserProfileEnforcementActionRestriction>? restriction = null,

            global::System.Action<global::Anthropic.UserProfileEnforcementActionBan>? ban = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Restriction is { } __value0)
            {
                restriction?.Invoke(__value0);
            }
            else if (Ban is { } __value1)
            {
                ban?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.UserProfileEnforcementActionRestriction>? restriction = null,
            global::System.Action<global::Anthropic.UserProfileEnforcementActionBan>? ban = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Restriction is { } __value0)
            {
                restriction?.Invoke(__value0);
            }
            else if (Ban is { } __value1)
            {
                ban?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Restriction,
                typeof(global::Anthropic.UserProfileEnforcementActionRestriction),
                Ban,
                typeof(global::Anthropic.UserProfileEnforcementActionBan),
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
        public bool Equals(UserProfileEnforcementAction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.UserProfileEnforcementActionRestriction?>.Default.Equals(Restriction, other.Restriction) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.UserProfileEnforcementActionBan?>.Default.Equals(Ban, other.Ban)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UserProfileEnforcementAction obj1, UserProfileEnforcementAction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UserProfileEnforcementAction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UserProfileEnforcementAction obj1, UserProfileEnforcementAction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UserProfileEnforcementAction o && Equals(o);
        }
    }
}
