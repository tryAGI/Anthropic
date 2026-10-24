#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct InputMessageUnion : global::System.IEquatable<InputMessageUnion>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.InputMessageUnionDiscriminatorRole? Role { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.UserInputMessage? User { get; init; }
#else
        public global::Anthropic.UserInputMessage? User { get; }
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
            out global::Anthropic.UserInputMessage? value)
        {
            value = User;
            return IsUser;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UserInputMessage PickUser() => User is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'User' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.AssistantInputMessage? Assistant { get; init; }
#else
        public global::Anthropic.AssistantInputMessage? Assistant { get; }
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
            out global::Anthropic.AssistantInputMessage? value)
        {
            value = Assistant;
            return IsAssistant;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AssistantInputMessage PickAssistant() => Assistant is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Assistant' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.SystemInputMessage? System { get; init; }
#else
        public global::Anthropic.SystemInputMessage? System { get; }
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
            out global::Anthropic.SystemInputMessage? value)
        {
            value = System;
            return IsSystem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.SystemInputMessage PickSystem() => System is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'System' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputMessageUnion(global::Anthropic.UserInputMessage value) => new InputMessageUnion((global::Anthropic.UserInputMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.UserInputMessage?(InputMessageUnion @this) => @this.User;

        /// <summary>
        ///
        /// </summary>
        public InputMessageUnion(global::Anthropic.UserInputMessage? value)
        {
            User = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputMessageUnion FromUser(global::Anthropic.UserInputMessage? value) => new InputMessageUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputMessageUnion(global::Anthropic.AssistantInputMessage value) => new InputMessageUnion((global::Anthropic.AssistantInputMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.AssistantInputMessage?(InputMessageUnion @this) => @this.Assistant;

        /// <summary>
        ///
        /// </summary>
        public InputMessageUnion(global::Anthropic.AssistantInputMessage? value)
        {
            Assistant = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputMessageUnion FromAssistant(global::Anthropic.AssistantInputMessage? value) => new InputMessageUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputMessageUnion(global::Anthropic.SystemInputMessage value) => new InputMessageUnion((global::Anthropic.SystemInputMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.SystemInputMessage?(InputMessageUnion @this) => @this.System;

        /// <summary>
        ///
        /// </summary>
        public InputMessageUnion(global::Anthropic.SystemInputMessage? value)
        {
            System = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputMessageUnion FromSystem(global::Anthropic.SystemInputMessage? value) => new InputMessageUnion(value);

        /// <summary>
        ///
        /// </summary>
        public InputMessageUnion(
            global::Anthropic.InputMessageUnionDiscriminatorRole? role,
            global::Anthropic.UserInputMessage? user,
            global::Anthropic.AssistantInputMessage? assistant,
            global::Anthropic.SystemInputMessage? system
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
            global::System.Func<global::Anthropic.UserInputMessage, TResult>? user = null,
            global::System.Func<global::Anthropic.AssistantInputMessage, TResult>? assistant = null,
            global::System.Func<global::Anthropic.SystemInputMessage, TResult>? system = null,
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
            global::System.Action<global::Anthropic.UserInputMessage>? user = null,

            global::System.Action<global::Anthropic.AssistantInputMessage>? assistant = null,

            global::System.Action<global::Anthropic.SystemInputMessage>? system = null,
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
            global::System.Action<global::Anthropic.UserInputMessage>? user = null,
            global::System.Action<global::Anthropic.AssistantInputMessage>? assistant = null,
            global::System.Action<global::Anthropic.SystemInputMessage>? system = null,
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
                typeof(global::Anthropic.UserInputMessage),
                Assistant,
                typeof(global::Anthropic.AssistantInputMessage),
                System,
                typeof(global::Anthropic.SystemInputMessage),
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
        public bool Equals(InputMessageUnion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.UserInputMessage?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.AssistantInputMessage?>.Default.Equals(Assistant, other.Assistant) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.SystemInputMessage?>.Default.Equals(System, other.System)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(InputMessageUnion obj1, InputMessageUnion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputMessageUnion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InputMessageUnion obj1, InputMessageUnion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputMessageUnion o && Equals(o);
        }
    }
}
