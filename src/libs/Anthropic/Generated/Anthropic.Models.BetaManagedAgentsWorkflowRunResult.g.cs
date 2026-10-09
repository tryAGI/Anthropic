#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// How a workflow run ended.
    /// </summary>
    public readonly partial struct BetaManagedAgentsWorkflowRunResult : global::System.IEquatable<BetaManagedAgentsWorkflowRunResult>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultDiscriminatorType? Type { get; }

        /// <summary>
        /// The run's plan, a program that the agent wrote, finished. This does not say whether the work succeeded.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultCompleted? Completed { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultCompleted? Completed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Completed))]
#endif
        public bool IsCompleted => Completed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWorkflowRunResultCompleted? value)
        {
            value = Completed;
            return IsCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultCompleted PickCompleted() => Completed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Completed' but the value was {ToString()}.");

        /// <summary>
        /// The run failed or reached its time limit.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultError? Error { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultError? Error { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWorkflowRunResultError? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultError PickError() => Error is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");

        /// <summary>
        /// The agent stopped the run.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultStopped? Stopped { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultStopped? Stopped { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Stopped))]
#endif
        public bool IsStopped => Stopped != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStopped(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWorkflowRunResultStopped? value)
        {
            value = Stopped;
            return IsStopped;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunResultStopped PickStopped() => Stopped is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Stopped' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsWorkflowRunResult(global::Anthropic.BetaManagedAgentsWorkflowRunResultCompleted value) => new BetaManagedAgentsWorkflowRunResult((global::Anthropic.BetaManagedAgentsWorkflowRunResultCompleted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWorkflowRunResultCompleted?(BetaManagedAgentsWorkflowRunResult @this) => @this.Completed;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWorkflowRunResult(global::Anthropic.BetaManagedAgentsWorkflowRunResultCompleted? value)
        {
            Completed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsWorkflowRunResult FromCompleted(global::Anthropic.BetaManagedAgentsWorkflowRunResultCompleted? value) => new BetaManagedAgentsWorkflowRunResult(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsWorkflowRunResult(global::Anthropic.BetaManagedAgentsWorkflowRunResultError value) => new BetaManagedAgentsWorkflowRunResult((global::Anthropic.BetaManagedAgentsWorkflowRunResultError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWorkflowRunResultError?(BetaManagedAgentsWorkflowRunResult @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWorkflowRunResult(global::Anthropic.BetaManagedAgentsWorkflowRunResultError? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsWorkflowRunResult FromError(global::Anthropic.BetaManagedAgentsWorkflowRunResultError? value) => new BetaManagedAgentsWorkflowRunResult(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsWorkflowRunResult(global::Anthropic.BetaManagedAgentsWorkflowRunResultStopped value) => new BetaManagedAgentsWorkflowRunResult((global::Anthropic.BetaManagedAgentsWorkflowRunResultStopped?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWorkflowRunResultStopped?(BetaManagedAgentsWorkflowRunResult @this) => @this.Stopped;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWorkflowRunResult(global::Anthropic.BetaManagedAgentsWorkflowRunResultStopped? value)
        {
            Stopped = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsWorkflowRunResult FromStopped(global::Anthropic.BetaManagedAgentsWorkflowRunResultStopped? value) => new BetaManagedAgentsWorkflowRunResult(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWorkflowRunResult(
            global::Anthropic.BetaManagedAgentsWorkflowRunResultDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsWorkflowRunResultCompleted? completed,
            global::Anthropic.BetaManagedAgentsWorkflowRunResultError? error,
            global::Anthropic.BetaManagedAgentsWorkflowRunResultStopped? stopped
            )
        {
            Type = type;

            Completed = completed;
            Error = error;
            Stopped = stopped;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Stopped as object ??
            Error as object ??
            Completed as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Completed?.ToString() ??
            Error?.ToString() ??
            Stopped?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCompleted && !IsError && !IsStopped || !IsCompleted && IsError && !IsStopped || !IsCompleted && !IsError && IsStopped;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsWorkflowRunResultCompleted, TResult>? completed = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWorkflowRunResultError, TResult>? error = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWorkflowRunResultStopped, TResult>? stopped = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Completed is { } __value0 && completed != null)
            {
                return completed(__value0);
            }
            else if (Error is { } __value1 && error != null)
            {
                return error(__value1);
            }
            else if (Stopped is { } __value2 && stopped != null)
            {
                return stopped(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsWorkflowRunResultCompleted>? completed = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWorkflowRunResultError>? error = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWorkflowRunResultStopped>? stopped = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Completed is { } __value0)
            {
                completed?.Invoke(__value0);
            }
            else if (Error is { } __value1)
            {
                error?.Invoke(__value1);
            }
            else if (Stopped is { } __value2)
            {
                stopped?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsWorkflowRunResultCompleted>? completed = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWorkflowRunResultError>? error = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWorkflowRunResultStopped>? stopped = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Completed is { } __value0)
            {
                completed?.Invoke(__value0);
            }
            else if (Error is { } __value1)
            {
                error?.Invoke(__value1);
            }
            else if (Stopped is { } __value2)
            {
                stopped?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Completed,
                typeof(global::Anthropic.BetaManagedAgentsWorkflowRunResultCompleted),
                Error,
                typeof(global::Anthropic.BetaManagedAgentsWorkflowRunResultError),
                Stopped,
                typeof(global::Anthropic.BetaManagedAgentsWorkflowRunResultStopped),
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
        public bool Equals(BetaManagedAgentsWorkflowRunResult other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWorkflowRunResultCompleted?>.Default.Equals(Completed, other.Completed) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWorkflowRunResultError?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWorkflowRunResultStopped?>.Default.Equals(Stopped, other.Stopped)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsWorkflowRunResult obj1, BetaManagedAgentsWorkflowRunResult obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsWorkflowRunResult>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsWorkflowRunResult obj1, BetaManagedAgentsWorkflowRunResult obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsWorkflowRunResult o && Equals(o);
        }
    }
}
