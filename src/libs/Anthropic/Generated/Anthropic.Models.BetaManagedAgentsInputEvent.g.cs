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
        public BetaManagedAgentsInputEvent(
            global::Anthropic.BetaManagedAgentsInputEventDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsUserMessageEvent? userMessage,
            global::Anthropic.BetaManagedAgentsUserInterruptEvent? userInterrupt,
            global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent? userToolConfirmation,
            global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent? userCustomToolResult
            )
        {
            Type = type;

            UserMessage = userMessage;
            UserInterrupt = userInterrupt;
            UserToolConfirmation = userToolConfirmation;
            UserCustomToolResult = userCustomToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            UserCustomToolResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult || !IsUserMessage && IsUserInterrupt && !IsUserToolConfirmation && !IsUserCustomToolResult || !IsUserMessage && !IsUserInterrupt && IsUserToolConfirmation && !IsUserCustomToolResult || !IsUserMessage && !IsUserInterrupt && !IsUserToolConfirmation && IsUserCustomToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsUserMessageEvent?, TResult>? userMessage = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserInterruptEvent?, TResult>? userInterrupt = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent?, TResult>? userToolConfirmation = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent?, TResult>? userCustomToolResult = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsUserMessageEvent?>? userMessage = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUserInterruptEvent?>? userInterrupt = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUserToolConfirmationEvent?>? userToolConfirmation = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent?>? userCustomToolResult = null,
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserCustomToolResultEvent?>.Default.Equals(UserCustomToolResult, other.UserCustomToolResult) 
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
