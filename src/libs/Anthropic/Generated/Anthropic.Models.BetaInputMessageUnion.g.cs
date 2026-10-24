#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaInputMessageUnion : global::System.IEquatable<BetaInputMessageUnion>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaInputMessageUnionDiscriminatorRole? Role { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaUserInputMessage? User { get; init; }
#else
        public global::Anthropic.BetaUserInputMessage? User { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(User))]
#endif
        public bool IsUser => User != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUser(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaUserInputMessage? value)
        {
            value = User;
            return IsUser;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserInputMessage PickUser() => User is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'User' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaAssistantInputMessage? Assistant { get; init; }
#else
        public global::Anthropic.BetaAssistantInputMessage? Assistant { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Assistant))]
#endif
        public bool IsAssistant => Assistant != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAssistant(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaAssistantInputMessage? value)
        {
            value = Assistant;
            return IsAssistant;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAssistantInputMessage PickAssistant() => Assistant is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Assistant' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaSystemInputMessage? System { get; init; }
#else
        public global::Anthropic.BetaSystemInputMessage? System { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(System))]
#endif
        public bool IsSystem => System != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSystem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaSystemInputMessage? value)
        {
            value = System;
            return IsSystem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSystemInputMessage PickSystem() => System is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'System' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaInputMessageUnion(global::Anthropic.BetaUserInputMessage value) => new BetaInputMessageUnion((global::Anthropic.BetaUserInputMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaUserInputMessage?(BetaInputMessageUnion @this) => @this.User;

        /// <summary>
        ///
        /// </summary>
        public BetaInputMessageUnion(global::Anthropic.BetaUserInputMessage? value)
        {
            User = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaInputMessageUnion FromUser(global::Anthropic.BetaUserInputMessage? value) => new BetaInputMessageUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaInputMessageUnion(global::Anthropic.BetaAssistantInputMessage value) => new BetaInputMessageUnion((global::Anthropic.BetaAssistantInputMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaAssistantInputMessage?(BetaInputMessageUnion @this) => @this.Assistant;

        /// <summary>
        ///
        /// </summary>
        public BetaInputMessageUnion(global::Anthropic.BetaAssistantInputMessage? value)
        {
            Assistant = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaInputMessageUnion FromAssistant(global::Anthropic.BetaAssistantInputMessage? value) => new BetaInputMessageUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaInputMessageUnion(global::Anthropic.BetaSystemInputMessage value) => new BetaInputMessageUnion((global::Anthropic.BetaSystemInputMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaSystemInputMessage?(BetaInputMessageUnion @this) => @this.System;

        /// <summary>
        ///
        /// </summary>
        public BetaInputMessageUnion(global::Anthropic.BetaSystemInputMessage? value)
        {
            System = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaInputMessageUnion FromSystem(global::Anthropic.BetaSystemInputMessage? value) => new BetaInputMessageUnion(value);

        /// <summary>
        ///
        /// </summary>
        public BetaInputMessageUnion(
            global::Anthropic.BetaInputMessageUnionDiscriminatorRole? role,
            global::Anthropic.BetaUserInputMessage? user,
            global::Anthropic.BetaAssistantInputMessage? assistant,
            global::Anthropic.BetaSystemInputMessage? system
            )
        {
            Role = role;

            User = user;
            Assistant = assistant;
            System = system;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            System as object ??
            Assistant as object ??
            User as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            User?.ToString() ??
            Assistant?.ToString() ??
            System?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUser && !IsAssistant && !IsSystem || !IsUser && IsAssistant && !IsSystem || !IsUser && !IsAssistant && IsSystem;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaUserInputMessage, TResult>? user = null,
            global::System.Func<global::Anthropic.BetaAssistantInputMessage, TResult>? assistant = null,
            global::System.Func<global::Anthropic.BetaSystemInputMessage, TResult>? system = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (User is { } __value0 && user != null)
            {
                return user(__value0);
            }
            else if (Assistant is { } __value1 && assistant != null)
            {
                return assistant(__value1);
            }
            else if (System is { } __value2 && system != null)
            {
                return system(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaUserInputMessage>? user = null,

            global::System.Action<global::Anthropic.BetaAssistantInputMessage>? assistant = null,

            global::System.Action<global::Anthropic.BetaSystemInputMessage>? system = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (User is { } __value0)
            {
                user?.Invoke(__value0);
            }
            else if (Assistant is { } __value1)
            {
                assistant?.Invoke(__value1);
            }
            else if (System is { } __value2)
            {
                system?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaUserInputMessage>? user = null,
            global::System.Action<global::Anthropic.BetaAssistantInputMessage>? assistant = null,
            global::System.Action<global::Anthropic.BetaSystemInputMessage>? system = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (User is { } __value0)
            {
                user?.Invoke(__value0);
            }
            else if (Assistant is { } __value1)
            {
                assistant?.Invoke(__value1);
            }
            else if (System is { } __value2)
            {
                system?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                User,
                typeof(global::Anthropic.BetaUserInputMessage),
                Assistant,
                typeof(global::Anthropic.BetaAssistantInputMessage),
                System,
                typeof(global::Anthropic.BetaSystemInputMessage),
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
        public bool Equals(BetaInputMessageUnion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaUserInputMessage?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaAssistantInputMessage?>.Default.Equals(Assistant, other.Assistant) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaSystemInputMessage?>.Default.Equals(System, other.System)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaInputMessageUnion obj1, BetaInputMessageUnion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaInputMessageUnion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaInputMessageUnion obj1, BetaInputMessageUnion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaInputMessageUnion o && Equals(o);
        }
    }
}
