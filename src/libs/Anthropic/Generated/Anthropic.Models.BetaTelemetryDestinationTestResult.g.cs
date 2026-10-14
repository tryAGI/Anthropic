#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The outcome of a test: `success`, or `failure` with the reason.
    /// </summary>
    public readonly partial struct BetaTelemetryDestinationTestResult : global::System.IEquatable<BetaTelemetryDestinationTestResult>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestResultDiscriminatorType? Type { get; }

        /// <summary>
        /// The destination answered the test span with a 2xx status.<br/>
        /// Example: {"type":"success"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTelemetryDestinationTestSuccess? Success { get; init; }
#else
        public global::Anthropic.BetaTelemetryDestinationTestSuccess? Success { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Success))]
#endif
        public bool IsSuccess => Success != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaTelemetryDestinationTestSuccess? value)
        {
            value = Success;
            return IsSuccess;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestSuccess PickSuccess() => Success is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Success' but the value was {ToString()}.");

        /// <summary>
        /// The test span was not delivered.<br/>
        /// Example: {"type":"failure","error":"HTTP error (status 403)"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTelemetryDestinationTestFailure? Failure { get; init; }
#else
        public global::Anthropic.BetaTelemetryDestinationTestFailure? Failure { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Failure))]
#endif
        public bool IsFailure => Failure != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFailure(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaTelemetryDestinationTestFailure? value)
        {
            value = Failure;
            return IsFailure;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationTestFailure PickFailure() => Failure is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Failure' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaTelemetryDestinationTestResult(global::Anthropic.BetaTelemetryDestinationTestSuccess value) => new BetaTelemetryDestinationTestResult((global::Anthropic.BetaTelemetryDestinationTestSuccess?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTelemetryDestinationTestSuccess?(BetaTelemetryDestinationTestResult @this) => @this.Success;

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationTestResult(global::Anthropic.BetaTelemetryDestinationTestSuccess? value)
        {
            Success = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaTelemetryDestinationTestResult FromSuccess(global::Anthropic.BetaTelemetryDestinationTestSuccess? value) => new BetaTelemetryDestinationTestResult(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaTelemetryDestinationTestResult(global::Anthropic.BetaTelemetryDestinationTestFailure value) => new BetaTelemetryDestinationTestResult((global::Anthropic.BetaTelemetryDestinationTestFailure?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTelemetryDestinationTestFailure?(BetaTelemetryDestinationTestResult @this) => @this.Failure;

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationTestResult(global::Anthropic.BetaTelemetryDestinationTestFailure? value)
        {
            Failure = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaTelemetryDestinationTestResult FromFailure(global::Anthropic.BetaTelemetryDestinationTestFailure? value) => new BetaTelemetryDestinationTestResult(value);

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationTestResult(
            global::Anthropic.BetaTelemetryDestinationTestResultDiscriminatorType? type,
            global::Anthropic.BetaTelemetryDestinationTestSuccess? success,
            global::Anthropic.BetaTelemetryDestinationTestFailure? failure
            )
        {
            Type = type;

            Success = success;
            Failure = failure;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Failure as object ??
            Success as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Success?.ToString() ??
            Failure?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSuccess && !IsFailure || !IsSuccess && IsFailure;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaTelemetryDestinationTestSuccess, TResult>? success = null,
            global::System.Func<global::Anthropic.BetaTelemetryDestinationTestFailure, TResult>? failure = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Success is { } __value0 && success != null)
            {
                return success(__value0);
            }
            else if (Failure is { } __value1 && failure != null)
            {
                return failure(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaTelemetryDestinationTestSuccess>? success = null,

            global::System.Action<global::Anthropic.BetaTelemetryDestinationTestFailure>? failure = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Success is { } __value0)
            {
                success?.Invoke(__value0);
            }
            else if (Failure is { } __value1)
            {
                failure?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaTelemetryDestinationTestSuccess>? success = null,
            global::System.Action<global::Anthropic.BetaTelemetryDestinationTestFailure>? failure = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Success is { } __value0)
            {
                success?.Invoke(__value0);
            }
            else if (Failure is { } __value1)
            {
                failure?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Success,
                typeof(global::Anthropic.BetaTelemetryDestinationTestSuccess),
                Failure,
                typeof(global::Anthropic.BetaTelemetryDestinationTestFailure),
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
        public bool Equals(BetaTelemetryDestinationTestResult other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTelemetryDestinationTestSuccess?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTelemetryDestinationTestFailure?>.Default.Equals(Failure, other.Failure)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaTelemetryDestinationTestResult obj1, BetaTelemetryDestinationTestResult obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaTelemetryDestinationTestResult>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaTelemetryDestinationTestResult obj1, BetaTelemetryDestinationTestResult obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaTelemetryDestinationTestResult o && Equals(o);
        }
    }
}
