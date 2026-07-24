#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Union type for events that can be sent to a session.
    /// </summary>
    public readonly partial struct BetaManagedAgentsInputEvent : global::System.IEquatable<BetaManagedAgentsInputEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsInputEventDiscriminatorType? Type { get; }

        /// <summary>
        /// A user message event in the session conversation.<br/>
        /// Example: {"type":"user.message","id":"sevt_011CZkZGOp0iBcp4kaQSihUmy","content":[{"type":"text","text":"Where is my order #1234?"}],"processed_at":"2026-03-15T10:00:00Z"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUserMessageEvent? UserMessage { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUserMessageEvent? UserMessage { get; }
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
            out global::Anthropic.BetaManagedAgentsUserMessageEvent? value)
        {
            value = UserMessage;
            return IsUserMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserMessageEvent PickUserMessage() => IsUserMessage
            ? UserMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserMessage' but the value was {ToString()}.");

        /// <summary>
        /// An interrupt event that pauses agent execution and returns control to the user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUserInterruptEvent? UserInterrupt { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUserInterruptEvent? UserInterrupt { get; }
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
            out global::Anthropic.BetaManagedAgentsUserInterruptEvent? value)
        {
            value = UserInterrupt;
            return IsUserInterrupt;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserInterruptEvent PickUserInterrupt() => IsUserInterrupt
            ? UserInterrupt!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserInterrupt' but the value was {ToString()}.");

        /// <summary>
        /// A tool confirmation event that approves or denies a pending tool execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent? UserToolConfirmation { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent? UserToolConfirmation { get; }
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
            out global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent? value)
        {
            value = UserToolConfirmation;
            return IsUserToolConfirmation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent PickUserToolConfirmation() => IsUserToolConfirmation
            ? UserToolConfirmation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserToolConfirmation' but the value was {ToString()}.");

        /// <summary>
        /// Event sent by the client providing the result of a custom tool execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent? UserCustomToolResult { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent? UserCustomToolResult { get; }
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
            out global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent? value)
        {
            value = UserCustomToolResult;
            return IsUserCustomToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent PickUserCustomToolResult() => IsUserCustomToolResult
            ? UserCustomToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserCustomToolResult' but the value was {ToString()}.");

        /// <summary>
        /// Echo of a `user.define_outcome` input event. Carries the server-generated `outcome_id` that subsequent `span.outcome_evaluation_*` events reference.<br/>
        /// Example: {"type":"user.define_outcome","id":"sevt_011CZkZSTx3lFgt7odUWmkyq","processed_at":"2026-03-15T10:02:14Z","outcome_id":"outc_011CZkZRSw2kEfs6ncTVljxP","description":"Produce a 2-page summary as summary.md","max_iterations":3,"rubric":{"type":"text","content":"Must cover all five sections; cite sources inline."}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent? UserDefineOutcome { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent? UserDefineOutcome { get; }
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
            out global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent? value)
        {
            value = UserDefineOutcome;
            return IsUserDefineOutcome;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent PickUserDefineOutcome() => IsUserDefineOutcome
            ? UserDefineOutcome!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserDefineOutcome' but the value was {ToString()}.");

        /// <summary>
        /// Event sent by the client providing the result of an agent-toolset tool execution. Only valid on `self_hosted` environments, where sandbox-routed tools are executed by the client rather than the server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUserToolResultEvent? UserToolResult { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUserToolResultEvent? UserToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserToolResult))]
#endif
        public bool IsUserToolResult => UserToolResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUserToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsUserToolResultEvent? value)
        {
            value = UserToolResult;
            return IsUserToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUserToolResultEvent PickUserToolResult() => IsUserToolResult
            ? UserToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserToolResult' but the value was {ToString()}.");

        /// <summary>
        /// A mid-conversation system message event. Carries system-role content that is appended to the session as a `role: "system"` turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSystemMessageEvent? SystemMessage { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSystemMessageEvent? SystemMessage { get; }
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
            out global::Anthropic.BetaManagedAgentsSystemMessageEvent? value)
        {
            value = SystemMessage;
            return IsSystemMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSystemMessageEvent PickSystemMessage() => IsSystemMessage
            ? SystemMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SystemMessage' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsInputEvent(global::Anthropic.BetaManagedAgentsUserMessageEvent value) => new BetaManagedAgentsInputEvent((global::Anthropic.BetaManagedAgentsUserMessageEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserMessageEvent?(BetaManagedAgentsInputEvent @this) => @this.UserMessage;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsInputEvent(global::Anthropic.BetaManagedAgentsUserMessageEvent? value)
        {
            UserMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsInputEvent FromUserMessage(global::Anthropic.BetaManagedAgentsUserMessageEvent? value) => new BetaManagedAgentsInputEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsInputEvent(global::Anthropic.BetaManagedAgentsUserInterruptEvent value) => new BetaManagedAgentsInputEvent((global::Anthropic.BetaManagedAgentsUserInterruptEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserInterruptEvent?(BetaManagedAgentsInputEvent @this) => @this.UserInterrupt;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsInputEvent(global::Anthropic.BetaManagedAgentsUserInterruptEvent? value)
        {
            UserInterrupt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsInputEvent FromUserInterrupt(global::Anthropic.BetaManagedAgentsUserInterruptEvent? value) => new BetaManagedAgentsInputEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsInputEvent(global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent value) => new BetaManagedAgentsInputEvent((global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent?(BetaManagedAgentsInputEvent @this) => @this.UserToolConfirmation;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsInputEvent(global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent? value)
        {
            UserToolConfirmation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsInputEvent FromUserToolConfirmation(global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent? value) => new BetaManagedAgentsInputEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsInputEvent(global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent value) => new BetaManagedAgentsInputEvent((global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent?(BetaManagedAgentsInputEvent @this) => @this.UserCustomToolResult;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsInputEvent(global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent? value)
        {
            UserCustomToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsInputEvent FromUserCustomToolResult(global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent? value) => new BetaManagedAgentsInputEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsInputEvent(global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent value) => new BetaManagedAgentsInputEvent((global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent?(BetaManagedAgentsInputEvent @this) => @this.UserDefineOutcome;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsInputEvent(global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent? value)
        {
            UserDefineOutcome = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsInputEvent FromUserDefineOutcome(global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent? value) => new BetaManagedAgentsInputEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsInputEvent(global::Anthropic.BetaManagedAgentsUserToolResultEvent value) => new BetaManagedAgentsInputEvent((global::Anthropic.BetaManagedAgentsUserToolResultEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserToolResultEvent?(BetaManagedAgentsInputEvent @this) => @this.UserToolResult;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsInputEvent(global::Anthropic.BetaManagedAgentsUserToolResultEvent? value)
        {
            UserToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsInputEvent FromUserToolResult(global::Anthropic.BetaManagedAgentsUserToolResultEvent? value) => new BetaManagedAgentsInputEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsInputEvent(global::Anthropic.BetaManagedAgentsSystemMessageEvent value) => new BetaManagedAgentsInputEvent((global::Anthropic.BetaManagedAgentsSystemMessageEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSystemMessageEvent?(BetaManagedAgentsInputEvent @this) => @this.SystemMessage;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsInputEvent(global::Anthropic.BetaManagedAgentsSystemMessageEvent? value)
        {
            SystemMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsInputEvent FromSystemMessage(global::Anthropic.BetaManagedAgentsSystemMessageEvent? value) => new BetaManagedAgentsInputEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsInputEvent(
            global::Anthropic.BetaManagedAgentsInputEventDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsUserMessageEvent? userMessage,
            global::Anthropic.BetaManagedAgentsUserInterruptEvent? userInterrupt,
            global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent? userToolConfirmation,
            global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent? userCustomToolResult,
            global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent? userDefineOutcome,
            global::Anthropic.BetaManagedAgentsUserToolResultEvent? userToolResult,
            global::Anthropic.BetaManagedAgentsSystemMessageEvent? systemMessage
            )
        {
            Type = type;

            UserMessage = userMessage;
            UserInterrupt = userInterrupt;
            UserToolConfirmation = userToolConfirmation;
            UserCustomToolResult = userCustomToolResult;
            UserDefineOutcome = userDefineOutcome;
            UserToolResult = userToolResult;
            SystemMessage = systemMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SystemMessage as object ??
            UserToolResult as object ??
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
            UserDefineOutcome?.ToString() ??
            UserToolResult?.ToString() ??
            SystemMessage?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsUserDefineOutcome && !IsUserToolResult && !IsSystemMessage || !IsUserMessage && IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsUserDefineOutcome && !IsUserToolResult && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && IsUserToolConfirmation && !IsUserCustomToolResult && !IsUserDefineOutcome && !IsUserToolResult && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && IsUserCustomToolResult && !IsUserDefineOutcome && !IsUserToolResult && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && IsUserDefineOutcome && !IsUserToolResult && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsUserDefineOutcome && IsUserToolResult && !IsSystemMessage || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult && !IsUserDefineOutcome && !IsUserToolResult && IsSystemMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsUserMessageEvent, TResult>? userMessage = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserInterruptEvent, TResult>? userInterrupt = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent, TResult>? userToolConfirmation = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent, TResult>? userCustomToolResult = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent, TResult>? userDefineOutcome = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserToolResultEvent, TResult>? userToolResult = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsSystemMessageEvent, TResult>? systemMessage = null,
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
            else if (IsUserToolResult && userToolResult != null)
            {
                return userToolResult(UserToolResult!);
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
            global::System.Action<global::Anthropic.BetaManagedAgentsUserMessageEvent>? userMessage = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsUserInterruptEvent>? userInterrupt = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent>? userToolConfirmation = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent>? userCustomToolResult = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent>? userDefineOutcome = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsUserToolResultEvent>? userToolResult = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsSystemMessageEvent>? systemMessage = null,
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
            else if (IsUserToolResult)
            {
                userToolResult?.Invoke(UserToolResult!);
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
            global::System.Action<global::Anthropic.BetaManagedAgentsUserMessageEvent>? userMessage = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUserInterruptEvent>? userInterrupt = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent>? userToolConfirmation = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent>? userCustomToolResult = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent>? userDefineOutcome = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUserToolResultEvent>? userToolResult = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsSystemMessageEvent>? systemMessage = null,
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
            else if (IsUserToolResult)
            {
                userToolResult?.Invoke(UserToolResult!);
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
                typeof(global::Anthropic.BetaManagedAgentsUserMessageEvent),
                UserInterrupt,
                typeof(global::Anthropic.BetaManagedAgentsUserInterruptEvent),
                UserToolConfirmation,
                typeof(global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent),
                UserCustomToolResult,
                typeof(global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent),
                UserDefineOutcome,
                typeof(global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent),
                UserToolResult,
                typeof(global::Anthropic.BetaManagedAgentsUserToolResultEvent),
                SystemMessage,
                typeof(global::Anthropic.BetaManagedAgentsSystemMessageEvent),
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
        public bool Equals(BetaManagedAgentsInputEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserMessageEvent?>.Default.Equals(UserMessage, other.UserMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserInterruptEvent?>.Default.Equals(UserInterrupt, other.UserInterrupt) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent?>.Default.Equals(UserToolConfirmation, other.UserToolConfirmation) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent?>.Default.Equals(UserCustomToolResult, other.UserCustomToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserDefineOutcomeEvent?>.Default.Equals(UserDefineOutcome, other.UserDefineOutcome) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserToolResultEvent?>.Default.Equals(UserToolResult, other.UserToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSystemMessageEvent?>.Default.Equals(SystemMessage, other.SystemMessage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsInputEvent obj1, BetaManagedAgentsInputEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsInputEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsInputEvent obj1, BetaManagedAgentsInputEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsInputEvent o && Equals(o);
        }
    }
}
