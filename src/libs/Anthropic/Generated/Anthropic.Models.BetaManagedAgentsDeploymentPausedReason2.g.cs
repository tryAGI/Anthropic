#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Why a deployment is paused. Non-null exactly when `status` is `paused`.
    /// </summary>
    public readonly partial struct BetaManagedAgentsDeploymentPausedReason2 : global::System.IEquatable<BetaManagedAgentsDeploymentPausedReason2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsDeploymentPausedReasonDiscriminatorType? Type { get; }

        /// <summary>
        /// The caller invoked the pause endpoint on the deployment.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsManualDeploymentPausedReason? Manual { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsManualDeploymentPausedReason? Manual { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Manual))]
#endif
        public bool IsManual => Manual != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickManual(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsManualDeploymentPausedReason? value)
        {
            value = Manual;
            return IsManual;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsManualDeploymentPausedReason PickManual() => IsManual
            ? Manual!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Manual' but the value was {ToString()}.");

        /// <summary>
        /// A scheduled fire recorded a failed run whose error auto-pauses the deployment.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsErrorDeploymentPausedReason? Error { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsErrorDeploymentPausedReason? Error { get; }
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
            out global::Anthropic.BetaManagedAgentsErrorDeploymentPausedReason? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsErrorDeploymentPausedReason PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentPausedReason2(global::Anthropic.BetaManagedAgentsManualDeploymentPausedReason value) => new BetaManagedAgentsDeploymentPausedReason2((global::Anthropic.BetaManagedAgentsManualDeploymentPausedReason?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsManualDeploymentPausedReason?(BetaManagedAgentsDeploymentPausedReason2 @this) => @this.Manual;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentPausedReason2(global::Anthropic.BetaManagedAgentsManualDeploymentPausedReason? value)
        {
            Manual = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentPausedReason2 FromManual(global::Anthropic.BetaManagedAgentsManualDeploymentPausedReason? value) => new BetaManagedAgentsDeploymentPausedReason2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsDeploymentPausedReason2(global::Anthropic.BetaManagedAgentsErrorDeploymentPausedReason value) => new BetaManagedAgentsDeploymentPausedReason2((global::Anthropic.BetaManagedAgentsErrorDeploymentPausedReason?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsErrorDeploymentPausedReason?(BetaManagedAgentsDeploymentPausedReason2 @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentPausedReason2(global::Anthropic.BetaManagedAgentsErrorDeploymentPausedReason? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsDeploymentPausedReason2 FromError(global::Anthropic.BetaManagedAgentsErrorDeploymentPausedReason? value) => new BetaManagedAgentsDeploymentPausedReason2(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsDeploymentPausedReason2(
            global::Anthropic.BetaManagedAgentsDeploymentPausedReasonDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsManualDeploymentPausedReason? manual,
            global::Anthropic.BetaManagedAgentsErrorDeploymentPausedReason? error
            )
        {
            Type = type;

            Manual = manual;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            Manual as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Manual?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsManual && !IsError || !IsManual && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsManualDeploymentPausedReason, TResult>? manual = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsErrorDeploymentPausedReason, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsManual && manual != null)
            {
                return manual(Manual!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsManualDeploymentPausedReason>? manual = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsErrorDeploymentPausedReason>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsManual)
            {
                manual?.Invoke(Manual!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsManualDeploymentPausedReason>? manual = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsErrorDeploymentPausedReason>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsManual)
            {
                manual?.Invoke(Manual!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Manual,
                typeof(global::Anthropic.BetaManagedAgentsManualDeploymentPausedReason),
                Error,
                typeof(global::Anthropic.BetaManagedAgentsErrorDeploymentPausedReason),
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
        public bool Equals(BetaManagedAgentsDeploymentPausedReason2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsManualDeploymentPausedReason?>.Default.Equals(Manual, other.Manual) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsErrorDeploymentPausedReason?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsDeploymentPausedReason2 obj1, BetaManagedAgentsDeploymentPausedReason2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsDeploymentPausedReason2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsDeploymentPausedReason2 obj1, BetaManagedAgentsDeploymentPausedReason2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsDeploymentPausedReason2 o && Equals(o);
        }
    }
}
