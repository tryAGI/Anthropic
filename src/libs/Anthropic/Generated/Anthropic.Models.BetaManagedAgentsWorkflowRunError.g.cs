#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Why a workflow run did not finish, or was not created. More types may be added. On `workflow_run.status_ended`, for a `type` you do not recognize, rely on the event's `result.type`.
    /// </summary>
    public readonly partial struct BetaManagedAgentsWorkflowRunError : global::System.IEquatable<BetaManagedAgentsWorkflowRunError>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWorkflowRunErrorDiscriminatorType? Type { get; }

        /// <summary>
        /// The run reached its time limit.<br/>
        /// Example: {"type":"timeout_error","message":"The workflow run reached its time limit."}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError? TimeoutError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError? TimeoutError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimeoutError))]
#endif
        public bool IsTimeoutError => TimeoutError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTimeoutError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError? value)
        {
            value = TimeoutError;
            return IsTimeoutError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError PickTimeoutError() => TimeoutError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TimeoutError' but the value was {ToString()}.");

        /// <summary>
        /// The plan, a program that the agent wrote, failed, or the server refused it.<br/>
        /// Example: {"type":"program_error","message":"The workflow run\u0027s plan failed."}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsProgramWorkflowRunError? ProgramError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsProgramWorkflowRunError? ProgramError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProgramError))]
#endif
        public bool IsProgramError => ProgramError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickProgramError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsProgramWorkflowRunError? value)
        {
            value = ProgramError;
            return IsProgramError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsProgramWorkflowRunError PickProgramError() => ProgramError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ProgramError' but the value was {ToString()}.");

        /// <summary>
        /// A failure that has no type of its own.<br/>
        /// Example: {"type":"unknown_error","message":"The workflow run failed."}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError? UnknownError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError? UnknownError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnknownError))]
#endif
        public bool IsUnknownError => UnknownError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnknownError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError? value)
        {
            value = UnknownError;
            return IsUnknownError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError PickUnknownError() => UnknownError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UnknownError' but the value was {ToString()}.");

        /// <summary>
        /// The run exceeded the limit on the number of threads that a run can create.<br/>
        /// Example: {"type":"thread_limit_error","message":"The workflow run exceeded its limit of threads."}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError? ThreadLimitError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError? ThreadLimitError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThreadLimitError))]
#endif
        public bool IsThreadLimitError => ThreadLimitError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickThreadLimitError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError? value)
        {
            value = ThreadLimitError;
            return IsThreadLimitError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError PickThreadLimitError() => ThreadLimitError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ThreadLimitError' but the value was {ToString()}.");

        /// <summary>
        /// No run was created, because the session was at its limit of open workflow runs, which are runs that have not ended. Only `workflow_run.error` carries this type.<br/>
        /// Example: {"type":"max_workflow_runs_error","message":"The session is at its limit of open workflow runs."}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError? MaxWorkflowRunsError { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError? MaxWorkflowRunsError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MaxWorkflowRunsError))]
#endif
        public bool IsMaxWorkflowRunsError => MaxWorkflowRunsError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMaxWorkflowRunsError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError? value)
        {
            value = MaxWorkflowRunsError;
            return IsMaxWorkflowRunsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError PickMaxWorkflowRunsError() => MaxWorkflowRunsError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MaxWorkflowRunsError' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsWorkflowRunError(global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError value) => new BetaManagedAgentsWorkflowRunError((global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError?(BetaManagedAgentsWorkflowRunError @this) => @this.TimeoutError;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWorkflowRunError(global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError? value)
        {
            TimeoutError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsWorkflowRunError FromTimeoutError(global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError? value) => new BetaManagedAgentsWorkflowRunError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsWorkflowRunError(global::Anthropic.BetaManagedAgentsProgramWorkflowRunError value) => new BetaManagedAgentsWorkflowRunError((global::Anthropic.BetaManagedAgentsProgramWorkflowRunError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsProgramWorkflowRunError?(BetaManagedAgentsWorkflowRunError @this) => @this.ProgramError;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWorkflowRunError(global::Anthropic.BetaManagedAgentsProgramWorkflowRunError? value)
        {
            ProgramError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsWorkflowRunError FromProgramError(global::Anthropic.BetaManagedAgentsProgramWorkflowRunError? value) => new BetaManagedAgentsWorkflowRunError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsWorkflowRunError(global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError value) => new BetaManagedAgentsWorkflowRunError((global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError?(BetaManagedAgentsWorkflowRunError @this) => @this.UnknownError;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWorkflowRunError(global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError? value)
        {
            UnknownError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsWorkflowRunError FromUnknownError(global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError? value) => new BetaManagedAgentsWorkflowRunError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsWorkflowRunError(global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError value) => new BetaManagedAgentsWorkflowRunError((global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError?(BetaManagedAgentsWorkflowRunError @this) => @this.ThreadLimitError;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWorkflowRunError(global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError? value)
        {
            ThreadLimitError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsWorkflowRunError FromThreadLimitError(global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError? value) => new BetaManagedAgentsWorkflowRunError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsWorkflowRunError(global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError value) => new BetaManagedAgentsWorkflowRunError((global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError?(BetaManagedAgentsWorkflowRunError @this) => @this.MaxWorkflowRunsError;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWorkflowRunError(global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError? value)
        {
            MaxWorkflowRunsError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsWorkflowRunError FromMaxWorkflowRunsError(global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError? value) => new BetaManagedAgentsWorkflowRunError(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWorkflowRunError(
            global::Anthropic.BetaManagedAgentsWorkflowRunErrorDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError? timeoutError,
            global::Anthropic.BetaManagedAgentsProgramWorkflowRunError? programError,
            global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError? unknownError,
            global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError? threadLimitError,
            global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError? maxWorkflowRunsError
            )
        {
            Type = type;

            TimeoutError = timeoutError;
            ProgramError = programError;
            UnknownError = unknownError;
            ThreadLimitError = threadLimitError;
            MaxWorkflowRunsError = maxWorkflowRunsError;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            MaxWorkflowRunsError as object ??
            ThreadLimitError as object ??
            UnknownError as object ??
            ProgramError as object ??
            TimeoutError as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TimeoutError?.ToString() ??
            ProgramError?.ToString() ??
            UnknownError?.ToString() ??
            ThreadLimitError?.ToString() ??
            MaxWorkflowRunsError?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTimeoutError && !IsProgramError && !IsUnknownError && !IsThreadLimitError && !IsMaxWorkflowRunsError || !IsTimeoutError && IsProgramError && !IsUnknownError && !IsThreadLimitError && !IsMaxWorkflowRunsError || !IsTimeoutError && !IsProgramError && IsUnknownError && !IsThreadLimitError && !IsMaxWorkflowRunsError || !IsTimeoutError && !IsProgramError && !IsUnknownError && IsThreadLimitError && !IsMaxWorkflowRunsError || !IsTimeoutError && !IsProgramError && !IsUnknownError && !IsThreadLimitError && IsMaxWorkflowRunsError;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError, TResult>? timeoutError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsProgramWorkflowRunError, TResult>? programError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError, TResult>? unknownError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError, TResult>? threadLimitError = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError, TResult>? maxWorkflowRunsError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TimeoutError is { } __value0 && timeoutError != null)
            {
                return timeoutError(__value0);
            }
            else if (ProgramError is { } __value1 && programError != null)
            {
                return programError(__value1);
            }
            else if (UnknownError is { } __value2 && unknownError != null)
            {
                return unknownError(__value2);
            }
            else if (ThreadLimitError is { } __value3 && threadLimitError != null)
            {
                return threadLimitError(__value3);
            }
            else if (MaxWorkflowRunsError is { } __value4 && maxWorkflowRunsError != null)
            {
                return maxWorkflowRunsError(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError>? timeoutError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsProgramWorkflowRunError>? programError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError>? unknownError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError>? threadLimitError = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError>? maxWorkflowRunsError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TimeoutError is { } __value0)
            {
                timeoutError?.Invoke(__value0);
            }
            else if (ProgramError is { } __value1)
            {
                programError?.Invoke(__value1);
            }
            else if (UnknownError is { } __value2)
            {
                unknownError?.Invoke(__value2);
            }
            else if (ThreadLimitError is { } __value3)
            {
                threadLimitError?.Invoke(__value3);
            }
            else if (MaxWorkflowRunsError is { } __value4)
            {
                maxWorkflowRunsError?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError>? timeoutError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsProgramWorkflowRunError>? programError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError>? unknownError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError>? threadLimitError = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError>? maxWorkflowRunsError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TimeoutError is { } __value0)
            {
                timeoutError?.Invoke(__value0);
            }
            else if (ProgramError is { } __value1)
            {
                programError?.Invoke(__value1);
            }
            else if (UnknownError is { } __value2)
            {
                unknownError?.Invoke(__value2);
            }
            else if (ThreadLimitError is { } __value3)
            {
                threadLimitError?.Invoke(__value3);
            }
            else if (MaxWorkflowRunsError is { } __value4)
            {
                maxWorkflowRunsError?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TimeoutError,
                typeof(global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError),
                ProgramError,
                typeof(global::Anthropic.BetaManagedAgentsProgramWorkflowRunError),
                UnknownError,
                typeof(global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError),
                ThreadLimitError,
                typeof(global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError),
                MaxWorkflowRunsError,
                typeof(global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError),
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
        public bool Equals(BetaManagedAgentsWorkflowRunError other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsTimeoutWorkflowRunError?>.Default.Equals(TimeoutError, other.TimeoutError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsProgramWorkflowRunError?>.Default.Equals(ProgramError, other.ProgramError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUnknownWorkflowRunError?>.Default.Equals(UnknownError, other.UnknownError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsThreadLimitWorkflowRunError?>.Default.Equals(ThreadLimitError, other.ThreadLimitError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMaxWorkflowRunsWorkflowRunError?>.Default.Equals(MaxWorkflowRunsError, other.MaxWorkflowRunsError)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsWorkflowRunError obj1, BetaManagedAgentsWorkflowRunError obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsWorkflowRunError>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsWorkflowRunError obj1, BetaManagedAgentsWorkflowRunError obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsWorkflowRunError o && Equals(o);
        }
    }
}
