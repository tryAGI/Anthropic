#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Processing result for this request.<br/>
    /// Contains a Message output if processing was successful, an error response if processing failed, or the reason why processing was not attempted, such as cancellation or expiration.
    /// </summary>
    public readonly partial struct Result : global::System.IEquatable<Result>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaMessageBatchIndividualResponseResultDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaSucceededResult? Succeeded { get; init; }
#else
        public global::Anthropic.BetaSucceededResult? Succeeded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Succeeded))]
#endif
        public bool IsSucceeded => Succeeded != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Result(global::Anthropic.BetaSucceededResult value) => new Result(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaSucceededResult?(Result @this) => @this.Succeeded;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::Anthropic.BetaSucceededResult? value)
        {
            Succeeded = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaErroredResult? Errored { get; init; }
#else
        public global::Anthropic.BetaErroredResult? Errored { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Errored))]
#endif
        public bool IsErrored => Errored != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Result(global::Anthropic.BetaErroredResult value) => new Result(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaErroredResult?(Result @this) => @this.Errored;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::Anthropic.BetaErroredResult? value)
        {
            Errored = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCanceledResult? Canceled { get; init; }
#else
        public global::Anthropic.BetaCanceledResult? Canceled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Canceled))]
#endif
        public bool IsCanceled => Canceled != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Result(global::Anthropic.BetaCanceledResult value) => new Result(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaCanceledResult?(Result @this) => @this.Canceled;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::Anthropic.BetaCanceledResult? value)
        {
            Canceled = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaExpiredResult? Expired { get; init; }
#else
        public global::Anthropic.BetaExpiredResult? Expired { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Expired))]
#endif
        public bool IsExpired => Expired != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Result(global::Anthropic.BetaExpiredResult value) => new Result(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaExpiredResult?(Result @this) => @this.Expired;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::Anthropic.BetaExpiredResult? value)
        {
            Expired = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Result(
            global::Anthropic.BetaMessageBatchIndividualResponseResultDiscriminatorType? type,
            global::Anthropic.BetaSucceededResult? succeeded,
            global::Anthropic.BetaErroredResult? errored,
            global::Anthropic.BetaCanceledResult? canceled,
            global::Anthropic.BetaExpiredResult? expired
            )
        {
            Type = type;

            Succeeded = succeeded;
            Errored = errored;
            Canceled = canceled;
            Expired = expired;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Expired as object ??
            Canceled as object ??
            Errored as object ??
            Succeeded as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSucceeded && !IsErrored && !IsCanceled && !IsExpired || !IsSucceeded && IsErrored && !IsCanceled && !IsExpired || !IsSucceeded && !IsErrored && IsCanceled && !IsExpired || !IsSucceeded && !IsErrored && !IsCanceled && IsExpired;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaSucceededResult?, TResult>? succeeded = null,
            global::System.Func<global::Anthropic.BetaErroredResult?, TResult>? errored = null,
            global::System.Func<global::Anthropic.BetaCanceledResult?, TResult>? canceled = null,
            global::System.Func<global::Anthropic.BetaExpiredResult?, TResult>? expired = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSucceeded && succeeded != null)
            {
                return succeeded(Succeeded!);
            }
            else if (IsErrored && errored != null)
            {
                return errored(Errored!);
            }
            else if (IsCanceled && canceled != null)
            {
                return canceled(Canceled!);
            }
            else if (IsExpired && expired != null)
            {
                return expired(Expired!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaSucceededResult?>? succeeded = null,
            global::System.Action<global::Anthropic.BetaErroredResult?>? errored = null,
            global::System.Action<global::Anthropic.BetaCanceledResult?>? canceled = null,
            global::System.Action<global::Anthropic.BetaExpiredResult?>? expired = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSucceeded)
            {
                succeeded?.Invoke(Succeeded!);
            }
            else if (IsErrored)
            {
                errored?.Invoke(Errored!);
            }
            else if (IsCanceled)
            {
                canceled?.Invoke(Canceled!);
            }
            else if (IsExpired)
            {
                expired?.Invoke(Expired!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Succeeded,
                typeof(global::Anthropic.BetaSucceededResult),
                Errored,
                typeof(global::Anthropic.BetaErroredResult),
                Canceled,
                typeof(global::Anthropic.BetaCanceledResult),
                Expired,
                typeof(global::Anthropic.BetaExpiredResult),
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
        public bool Equals(Result other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaSucceededResult?>.Default.Equals(Succeeded, other.Succeeded) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaErroredResult?>.Default.Equals(Errored, other.Errored) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCanceledResult?>.Default.Equals(Canceled, other.Canceled) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaExpiredResult?>.Default.Equals(Expired, other.Expired) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Result obj1, Result obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Result>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Result obj1, Result obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Result o && Equals(o);
        }
    }
}
