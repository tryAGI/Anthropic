#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An event sent to a session immediately after it is created. Supports `user.message`, `user.define_outcome`, and `system.message`.
    /// </summary>
    public readonly partial struct BetaManagedAgentsDeploymentInitialEvent : global::System.IEquatable<BetaManagedAgentsDeploymentInitialEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventDiscriminatorType? Type { get; }

        /// <summary>
        /// A user message sent to the session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent? UserMessage { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent? UserMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserMessage))]
#endif
        public bool IsUserMessage => UserMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUserMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent? value)
        {
            value = UserMessage;
            return IsUserMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent PickUserMessage() => IsUserMessage
            ? UserMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserMessage' but the value was {ToString()}.");

        /// <summary>
        /// An outcome the agent should work toward. The agent begins work on receipt.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent? UserDefineOutcome { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent? UserDefineOutcome { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserDefineOutcome))]
#endif
        public bool IsUserDefineOutcome => UserDefineOutcome != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUserDefineOutcome(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent? value)
        {
            value = UserDefineOutcome;
            return IsUserDefineOutcome;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent PickUserDefineOutcome() => IsUserDefineOutcome
            ? UserDefineOutcome!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserDefineOutcome' but the value was {ToString()}.");

        /// <summary>
        /// Privileged context for the accompanying turn and all subsequent turns, appended to the session's system context as a `role: "system"` turn rather than replacing the top-level system prompt.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent? SystemMessage { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent? SystemMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SystemMessage))]
#endif
        public bool IsSystemMessage => SystemMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSystemMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent? value)
        {
            value = SystemMessage;
            return IsSystemMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent PickSystemMessage() => IsSystemMessage
            ? SystemMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SystemMessage' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentInitialEvent(global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent value) => new BetaManagedAgentsDeploymentInitialEvent((global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent?(BetaManagedAgentsDeploymentInitialEvent @this) => @this.UserMessage;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentInitialEvent(global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent? value)
        {
            UserMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentInitialEvent FromUserMessage(global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent? value) => new BetaManagedAgentsDeploymentInitialEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentInitialEvent(global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent value) => new BetaManagedAgentsDeploymentInitialEvent((global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent?(BetaManagedAgentsDeploymentInitialEvent @this) => @this.UserDefineOutcome;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentInitialEvent(global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent? value)
        {
            UserDefineOutcome = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentInitialEvent FromUserDefineOutcome(global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent? value) => new BetaManagedAgentsDeploymentInitialEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentInitialEvent(global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent value) => new BetaManagedAgentsDeploymentInitialEvent((global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent?(BetaManagedAgentsDeploymentInitialEvent @this) => @this.SystemMessage;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentInitialEvent(global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent? value)
        {
            SystemMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentInitialEvent FromSystemMessage(global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent? value) => new BetaManagedAgentsDeploymentInitialEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentInitialEvent(
            global::Anthropic.BetaManagedAgentsDeploymentInitialEventDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent? userMessage,
            global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent? userDefineOutcome,
            global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent? systemMessage
            )
        {
            Type = type;

            UserMessage = userMessage;
            UserDefineOutcome = userDefineOutcome;
            SystemMessage = systemMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SystemMessage as object ??
            UserDefineOutcome as object ??
            UserMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UserMessage?.ToString() ??
            UserDefineOutcome?.ToString() ??
            SystemMessage?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUserMessage && !IsUserDefineOutcome && !IsSystemMessage || !IsUserMessage && IsUserDefineOutcome && !IsSystemMessage || !IsUserMessage && !IsUserDefineOutcome && IsSystemMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent, TResult>? userMessage = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent, TResult>? userDefineOutcome = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent, TResult>? systemMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserMessage && userMessage != null)
            {
                return userMessage(UserMessage!);
            }
            else if (IsUserDefineOutcome && userDefineOutcome != null)
            {
                return userDefineOutcome(UserDefineOutcome!);
            }
            else if (IsSystemMessage && systemMessage != null)
            {
                return systemMessage(SystemMessage!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent>? userMessage = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent>? userDefineOutcome = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent>? systemMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserMessage)
            {
                userMessage?.Invoke(UserMessage!);
            }
            else if (IsUserDefineOutcome)
            {
                userDefineOutcome?.Invoke(UserDefineOutcome!);
            }
            else if (IsSystemMessage)
            {
                systemMessage?.Invoke(SystemMessage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent>? userMessage = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent>? userDefineOutcome = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent>? systemMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserMessage)
            {
                userMessage?.Invoke(UserMessage!);
            }
            else if (IsUserDefineOutcome)
            {
                userDefineOutcome?.Invoke(UserDefineOutcome!);
            }
            else if (IsSystemMessage)
            {
                systemMessage?.Invoke(SystemMessage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UserMessage,
                typeof(global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent),
                UserDefineOutcome,
                typeof(global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent),
                SystemMessage,
                typeof(global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent),
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
        public bool Equals(BetaManagedAgentsDeploymentInitialEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsDeploymentUserMessageEvent?>.Default.Equals(UserMessage, other.UserMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsDeploymentUserDefineOutcomeEvent?>.Default.Equals(UserDefineOutcome, other.UserDefineOutcome) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsDeploymentSystemMessageEvent?>.Default.Equals(SystemMessage, other.SystemMessage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsDeploymentInitialEvent obj1, BetaManagedAgentsDeploymentInitialEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsDeploymentInitialEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsDeploymentInitialEvent obj1, BetaManagedAgentsDeploymentInitialEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsDeploymentInitialEvent o && Equals(o);
        }
    }
}
