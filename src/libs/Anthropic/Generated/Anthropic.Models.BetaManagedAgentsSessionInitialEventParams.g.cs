#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An event sent to the `session` immediately after it is created. Supports `user.message` and `user.define_outcome`.
    /// </summary>
    public readonly partial struct BetaManagedAgentsSessionInitialEventParams : global::System.IEquatable<BetaManagedAgentsSessionInitialEventParams>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionInitialEventParamsDiscriminatorType? Type { get; }

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
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionInitialEventParams(global::Anthropic.BetaManagedAgentsUserMessageEventParams value) => new BetaManagedAgentsSessionInitialEventParams((global::Anthropic.BetaManagedAgentsUserMessageEventParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserMessageEventParams?(BetaManagedAgentsSessionInitialEventParams @this) => @this.UserMessage;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionInitialEventParams(global::Anthropic.BetaManagedAgentsUserMessageEventParams? value)
        {
            UserMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsSessionInitialEventParams FromUserMessage(global::Anthropic.BetaManagedAgentsUserMessageEventParams? value) => new BetaManagedAgentsSessionInitialEventParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionInitialEventParams(global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams value) => new BetaManagedAgentsSessionInitialEventParams((global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams?(BetaManagedAgentsSessionInitialEventParams @this) => @this.UserDefineOutcome;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionInitialEventParams(global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams? value)
        {
            UserDefineOutcome = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsSessionInitialEventParams FromUserDefineOutcome(global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams? value) => new BetaManagedAgentsSessionInitialEventParams(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionInitialEventParams(
            global::Anthropic.BetaManagedAgentsSessionInitialEventParamsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsUserMessageEventParams? userMessage,
            global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams? userDefineOutcome
            )
        {
            Type = type;

            UserMessage = userMessage;
            UserDefineOutcome = userDefineOutcome;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UserDefineOutcome as object ??
            UserMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UserMessage?.ToString() ??
            UserDefineOutcome?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUserMessage && !IsUserDefineOutcome || !IsUserMessage && IsUserDefineOutcome;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsUserMessageEventParams, TResult>? userMessage = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams, TResult>? userDefineOutcome = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsUserMessageEventParams>? userMessage = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams>? userDefineOutcome = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsUserMessageEventParams>? userMessage = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams>? userDefineOutcome = null,
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
        public bool Equals(BetaManagedAgentsSessionInitialEventParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserMessageEventParams?>.Default.Equals(UserMessage, other.UserMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams?>.Default.Equals(UserDefineOutcome, other.UserDefineOutcome) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsSessionInitialEventParams obj1, BetaManagedAgentsSessionInitialEventParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsSessionInitialEventParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsSessionInitialEventParams obj1, BetaManagedAgentsSessionInitialEventParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsSessionInitialEventParams o && Equals(o);
        }
    }
}
