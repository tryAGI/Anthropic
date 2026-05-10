#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Union type for event parameters that can be sent to a session.
    /// </summary>
    public readonly partial struct BetaManagedAgentsEventParams : global::System.IEquatable<BetaManagedAgentsEventParams>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEventParamsDiscriminatorType? Type { get; }

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
        /// Parameters for sending an interrupt to pause the agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUserInterruptEventParams? UserInterrupt { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUserInterruptEventParams? UserInterrupt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserInterrupt))]
#endif
        public bool IsUserInterrupt => UserInterrupt != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUserInterrupt(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsUserInterruptEventParams? value)
        {
            value = UserInterrupt;
            return IsUserInterrupt;
        }

        /// <summary>
        /// Parameters for confirming or denying a tool execution request.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParams? UserToolConfirmation { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParams? UserToolConfirmation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserToolConfirmation))]
#endif
        public bool IsUserToolConfirmation => UserToolConfirmation != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUserToolConfirmation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParams? value)
        {
            value = UserToolConfirmation;
            return IsUserToolConfirmation;
        }

        /// <summary>
        /// Parameters for providing the result of a custom tool execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParams? UserCustomToolResult { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParams? UserCustomToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserCustomToolResult))]
#endif
        public bool IsUserCustomToolResult => UserCustomToolResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUserCustomToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParams? value)
        {
            value = UserCustomToolResult;
            return IsUserCustomToolResult;
        }

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
        public static implicit operator BetaManagedAgentsEventParams(global::Anthropic.BetaManagedAgentsUserMessageEventParams value) => new BetaManagedAgentsEventParams((global::Anthropic.BetaManagedAgentsUserMessageEventParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserMessageEventParams?(BetaManagedAgentsEventParams @this) => @this.UserMessage;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsEventParams(global::Anthropic.BetaManagedAgentsUserMessageEventParams? value)
        {
            UserMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsEventParams FromUserMessage(global::Anthropic.BetaManagedAgentsUserMessageEventParams? value) => new BetaManagedAgentsEventParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsEventParams(global::Anthropic.BetaManagedAgentsUserInterruptEventParams value) => new BetaManagedAgentsEventParams((global::Anthropic.BetaManagedAgentsUserInterruptEventParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserInterruptEventParams?(BetaManagedAgentsEventParams @this) => @this.UserInterrupt;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsEventParams(global::Anthropic.BetaManagedAgentsUserInterruptEventParams? value)
        {
            UserInterrupt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsEventParams FromUserInterrupt(global::Anthropic.BetaManagedAgentsUserInterruptEventParams? value) => new BetaManagedAgentsEventParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsEventParams(global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParams value) => new BetaManagedAgentsEventParams((global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParams?(BetaManagedAgentsEventParams @this) => @this.UserToolConfirmation;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsEventParams(global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParams? value)
        {
            UserToolConfirmation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsEventParams FromUserToolConfirmation(global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParams? value) => new BetaManagedAgentsEventParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsEventParams(global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParams value) => new BetaManagedAgentsEventParams((global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParams?(BetaManagedAgentsEventParams @this) => @this.UserCustomToolResult;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsEventParams(global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParams? value)
        {
            UserCustomToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsEventParams FromUserCustomToolResult(global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParams? value) => new BetaManagedAgentsEventParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsEventParams(global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams value) => new BetaManagedAgentsEventParams((global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams?(BetaManagedAgentsEventParams @this) => @this.UserDefineOutcome;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsEventParams(global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams? value)
        {
            UserDefineOutcome = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsEventParams FromUserDefineOutcome(global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams? value) => new BetaManagedAgentsEventParams(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsEventParams(
            global::Anthropic.BetaManagedAgentsEventParamsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsUserMessageEventParams? userMessage,
            global::Anthropic.BetaManagedAgentsUserInterruptEventParams? userInterrupt,
            global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParams? userToolConfirmation,
            global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParams? userCustomToolResult,
            global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams? userDefineOutcome
            )
        {
            Type = type;

            UserMessage = userMessage;
            UserInterrupt = userInterrupt;
            UserToolConfirmation = userToolConfirmation;
            UserCustomToolResult = userCustomToolResult;
            UserDefineOutcome = userDefineOutcome;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UserDefineOutcome as object ??
            UserCustomToolResult as object ??
            UserToolConfirmation as object ??
            UserInterrupt as object ??
            UserMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UserMessage?.ToString() ??
            UserInterrupt?.ToString() ??
            UserToolConfirmation?.ToString() ??
            UserCustomToolResult?.ToString() ??
            UserDefineOutcome?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsUserDefineOutcome || !IsUserMessage && IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsUserDefineOutcome || !IsUserMessage && !IsUserInterrupt && IsUserToolConfirmation && !IsUserCustomToolResult && !IsUserDefineOutcome || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && IsUserCustomToolResult && !IsUserDefineOutcome || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && IsUserDefineOutcome;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsUserMessageEventParams, TResult>? userMessage = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserInterruptEventParams, TResult>? userInterrupt = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParams, TResult>? userToolConfirmation = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParams, TResult>? userCustomToolResult = null,
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
            else if (IsUserInterrupt && userInterrupt != null)
            {
                return userInterrupt(UserInterrupt!);
            }
            else if (IsUserToolConfirmation && userToolConfirmation != null)
            {
                return userToolConfirmation(UserToolConfirmation!);
            }
            else if (IsUserCustomToolResult && userCustomToolResult != null)
            {
                return userCustomToolResult(UserCustomToolResult!);
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

            global::System.Action<global::Anthropic.BetaManagedAgentsUserInterruptEventParams>? userInterrupt = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParams>? userToolConfirmation = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParams>? userCustomToolResult = null,

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
            else if (IsUserInterrupt)
            {
                userInterrupt?.Invoke(UserInterrupt!);
            }
            else if (IsUserToolConfirmation)
            {
                userToolConfirmation?.Invoke(UserToolConfirmation!);
            }
            else if (IsUserCustomToolResult)
            {
                userCustomToolResult?.Invoke(UserCustomToolResult!);
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
            global::System.Action<global::Anthropic.BetaManagedAgentsUserInterruptEventParams>? userInterrupt = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParams>? userToolConfirmation = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParams>? userCustomToolResult = null,
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
            else if (IsUserInterrupt)
            {
                userInterrupt?.Invoke(UserInterrupt!);
            }
            else if (IsUserToolConfirmation)
            {
                userToolConfirmation?.Invoke(UserToolConfirmation!);
            }
            else if (IsUserCustomToolResult)
            {
                userCustomToolResult?.Invoke(UserCustomToolResult!);
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
                UserInterrupt,
                typeof(global::Anthropic.BetaManagedAgentsUserInterruptEventParams),
                UserToolConfirmation,
                typeof(global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParams),
                UserCustomToolResult,
                typeof(global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParams),
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
        public bool Equals(BetaManagedAgentsEventParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserMessageEventParams?>.Default.Equals(UserMessage, other.UserMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserInterruptEventParams?>.Default.Equals(UserInterrupt, other.UserInterrupt) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserToolConfirmationEventParams?>.Default.Equals(UserToolConfirmation, other.UserToolConfirmation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserCustomToolResultEventParams?>.Default.Equals(UserCustomToolResult, other.UserCustomToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventParams?>.Default.Equals(UserDefineOutcome, other.UserDefineOutcome) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsEventParams obj1, BetaManagedAgentsEventParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsEventParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsEventParams obj1, BetaManagedAgentsEventParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsEventParams o && Equals(o);
        }
    }
}
