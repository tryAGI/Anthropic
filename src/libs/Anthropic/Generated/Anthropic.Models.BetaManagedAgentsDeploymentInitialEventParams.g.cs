#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An event sent to a session immediately after it is created. Supports `user.message`, `user.define_outcome`, and `system.message`.
    /// </summary>
    public readonly partial struct BetaManagedAgentsDeploymentInitialEventParams : global::System.IEquatable<BetaManagedAgentsDeploymentInitialEventParams>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorType? Type { get; }

        /// <summary>
        /// Parameters for sending a user message to the session.<br/>
        /// Example: {"type":"user.message","content":[{"type":"text","text":"Where is my order #1234?"}]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUserMessageEventParams? UserMessage { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUserMessageEventParams? UserMessage { get; }
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
            out global::Anthropic.BetaManagedAgentsUserMessageEventParams? value)
        {
            value = UserMessage;
            return IsUserMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserMessageEventParams PickUserMessage() => IsUserMessage
            ? UserMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserMessage' but the value was {ToString()}.");

        /// <summary>
        /// Parameters for defining an outcome the agent should work toward. The agent begins work on receipt.<br/>
        /// Example: {"type":"user.define_outcome","description":"Produce a 2-page summary as summary.md","rubric":{"type":"text","content":"Must cover all five sections; cite sources inline."},"max_iterations":3}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams? UserDefineOutcome { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams? UserDefineOutcome { get; }
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
            out global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams? value)
        {
            value = UserDefineOutcome;
            return IsUserDefineOutcome;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams PickUserDefineOutcome() => IsUserDefineOutcome
            ? UserDefineOutcome!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserDefineOutcome' but the value was {ToString()}.");

        /// <summary>
        /// Privileged context for the accompanying turn and all subsequent turns, appended to the session's system context as a `role: "system"` turn rather than replacing the top-level system prompt. At most one per request: it must be the final event and immediately follow the `user.message`, `user.tool_result`, or `user.custom_tool_result` it accompanies. Only supported on models that accept mid-conversation system messages.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSystemMessageEventParams? SystemMessage { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSystemMessageEventParams? SystemMessage { get; }
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
            out global::Anthropic.BetaManagedAgentsSystemMessageEventParams? value)
        {
            value = SystemMessage;
            return IsSystemMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemMessageEventParams PickSystemMessage() => IsSystemMessage
            ? SystemMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SystemMessage' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentInitialEventParams(global::Anthropic.BetaManagedAgentsUserMessageEventParams value) => new BetaManagedAgentsDeploymentInitialEventParams((global::Anthropic.BetaManagedAgentsUserMessageEventParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserMessageEventParams?(BetaManagedAgentsDeploymentInitialEventParams @this) => @this.UserMessage;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentInitialEventParams(global::Anthropic.BetaManagedAgentsUserMessageEventParams? value)
        {
            UserMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentInitialEventParams FromUserMessage(global::Anthropic.BetaManagedAgentsUserMessageEventParams? value) => new BetaManagedAgentsDeploymentInitialEventParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentInitialEventParams(global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams value) => new BetaManagedAgentsDeploymentInitialEventParams((global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams?(BetaManagedAgentsDeploymentInitialEventParams @this) => @this.UserDefineOutcome;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentInitialEventParams(global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams? value)
        {
            UserDefineOutcome = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentInitialEventParams FromUserDefineOutcome(global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams? value) => new BetaManagedAgentsDeploymentInitialEventParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentInitialEventParams(global::Anthropic.BetaManagedAgentsSystemMessageEventParams value) => new BetaManagedAgentsDeploymentInitialEventParams((global::Anthropic.BetaManagedAgentsSystemMessageEventParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSystemMessageEventParams?(BetaManagedAgentsDeploymentInitialEventParams @this) => @this.SystemMessage;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentInitialEventParams(global::Anthropic.BetaManagedAgentsSystemMessageEventParams? value)
        {
            SystemMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentInitialEventParams FromSystemMessage(global::Anthropic.BetaManagedAgentsSystemMessageEventParams? value) => new BetaManagedAgentsDeploymentInitialEventParams(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentInitialEventParams(
            global::Anthropic.BetaManagedAgentsDeploymentInitialEventParamsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsUserMessageEventParams? userMessage,
            global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams? userDefineOutcome,
            global::Anthropic.BetaManagedAgentsSystemMessageEventParams? systemMessage
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
            global::System.Func<global::Anthropic.BetaManagedAgentsUserMessageEventParams, TResult>? userMessage = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams, TResult>? userDefineOutcome = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSystemMessageEventParams, TResult>? systemMessage = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsUserMessageEventParams>? userMessage = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams>? userDefineOutcome = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSystemMessageEventParams>? systemMessage = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsUserMessageEventParams>? userMessage = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams>? userDefineOutcome = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSystemMessageEventParams>? systemMessage = null,
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
                typeof(global::Anthropic.BetaManagedAgentsUserMessageEventParams),
                UserDefineOutcome,
                typeof(global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams),
                SystemMessage,
                typeof(global::Anthropic.BetaManagedAgentsSystemMessageEventParams),
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
        public bool Equals(BetaManagedAgentsDeploymentInitialEventParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserMessageEventParams?>.Default.Equals(UserMessage, other.UserMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams?>.Default.Equals(UserDefineOutcome, other.UserDefineOutcome) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSystemMessageEventParams?>.Default.Equals(SystemMessage, other.SystemMessage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsDeploymentInitialEventParams obj1, BetaManagedAgentsDeploymentInitialEventParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsDeploymentInitialEventParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsDeploymentInitialEventParams obj1, BetaManagedAgentsDeploymentInitialEventParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsDeploymentInitialEventParams o && Equals(o);
        }
    }
}
