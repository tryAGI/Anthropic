#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaClaudeTagErrorResponseError : global::System.IEquatable<BetaClaudeTagErrorResponseError>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagErrorResponseErrorDiscriminatorType? Type { get; }

        /// <summary>
        /// Returned with status 403. `details.error_code` names the cause.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeTagCodedPermissionError? PermissionError { get; init; }
#else
        public global::Anthropic.BetaClaudeTagCodedPermissionError? PermissionError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PermissionError))]
#endif
        public bool IsPermissionError => PermissionError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPermissionError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaClaudeTagCodedPermissionError? value)
        {
            value = PermissionError;
            return IsPermissionError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagCodedPermissionError PickPermissionError() => PermissionError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PermissionError' but the value was {ToString()}.");

        /// <summary>
        /// Returned with status 400 when the request set the channel up and `settings` was then refused. The channel stays set up with every setting unset.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeTagSetUpSettingsRefusedError? InvalidRequestError { get; init; }
#else
        public global::Anthropic.BetaClaudeTagSetUpSettingsRefusedError? InvalidRequestError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InvalidRequestError))]
#endif
        public bool IsInvalidRequestError => InvalidRequestError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInvalidRequestError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaClaudeTagSetUpSettingsRefusedError? value)
        {
            value = InvalidRequestError;
            return IsInvalidRequestError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSetUpSettingsRefusedError PickInvalidRequestError() => InvalidRequestError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InvalidRequestError' but the value was {ToString()}.");

        /// <summary>
        /// Returned with status 404 when `settings.environment_id` names no Environment within the organization's reach. It says nothing about the `id` in the path.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeTagEnvironmentNotFoundError? NotFoundError { get; init; }
#else
        public global::Anthropic.BetaClaudeTagEnvironmentNotFoundError? NotFoundError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NotFoundError))]
#endif
        public bool IsNotFoundError => NotFoundError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNotFoundError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaClaudeTagEnvironmentNotFoundError? value)
        {
            value = NotFoundError;
            return IsNotFoundError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagEnvironmentNotFoundError PickNotFoundError() => NotFoundError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NotFoundError' but the value was {ToString()}.");

        /// <summary>
        /// Returned with status 409 when something else changed the resource while this request ran, or it was removed. Nothing of this request's settings was stored. Read the resource again, then send the change again if it is still needed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeTagSettingsConflictError? ConflictError { get; init; }
#else
        public global::Anthropic.BetaClaudeTagSettingsConflictError? ConflictError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConflictError))]
#endif
        public bool IsConflictError => ConflictError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConflictError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaClaudeTagSettingsConflictError? value)
        {
            value = ConflictError;
            return IsConflictError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeTagSettingsConflictError PickConflictError() => ConflictError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConflictError' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeTagErrorResponseError(global::Anthropic.BetaClaudeTagCodedPermissionError value) => new BetaClaudeTagErrorResponseError((global::Anthropic.BetaClaudeTagCodedPermissionError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeTagCodedPermissionError?(BetaClaudeTagErrorResponseError @this) => @this.PermissionError;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagErrorResponseError(global::Anthropic.BetaClaudeTagCodedPermissionError? value)
        {
            PermissionError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeTagErrorResponseError FromPermissionError(global::Anthropic.BetaClaudeTagCodedPermissionError? value) => new BetaClaudeTagErrorResponseError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeTagErrorResponseError(global::Anthropic.BetaClaudeTagSetUpSettingsRefusedError value) => new BetaClaudeTagErrorResponseError((global::Anthropic.BetaClaudeTagSetUpSettingsRefusedError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeTagSetUpSettingsRefusedError?(BetaClaudeTagErrorResponseError @this) => @this.InvalidRequestError;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagErrorResponseError(global::Anthropic.BetaClaudeTagSetUpSettingsRefusedError? value)
        {
            InvalidRequestError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeTagErrorResponseError FromInvalidRequestError(global::Anthropic.BetaClaudeTagSetUpSettingsRefusedError? value) => new BetaClaudeTagErrorResponseError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeTagErrorResponseError(global::Anthropic.BetaClaudeTagEnvironmentNotFoundError value) => new BetaClaudeTagErrorResponseError((global::Anthropic.BetaClaudeTagEnvironmentNotFoundError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeTagEnvironmentNotFoundError?(BetaClaudeTagErrorResponseError @this) => @this.NotFoundError;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagErrorResponseError(global::Anthropic.BetaClaudeTagEnvironmentNotFoundError? value)
        {
            NotFoundError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeTagErrorResponseError FromNotFoundError(global::Anthropic.BetaClaudeTagEnvironmentNotFoundError? value) => new BetaClaudeTagErrorResponseError(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClaudeTagErrorResponseError(global::Anthropic.BetaClaudeTagSettingsConflictError value) => new BetaClaudeTagErrorResponseError((global::Anthropic.BetaClaudeTagSettingsConflictError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeTagSettingsConflictError?(BetaClaudeTagErrorResponseError @this) => @this.ConflictError;

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagErrorResponseError(global::Anthropic.BetaClaudeTagSettingsConflictError? value)
        {
            ConflictError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClaudeTagErrorResponseError FromConflictError(global::Anthropic.BetaClaudeTagSettingsConflictError? value) => new BetaClaudeTagErrorResponseError(value);

        /// <summary>
        ///
        /// </summary>
        public BetaClaudeTagErrorResponseError(
            global::Anthropic.BetaClaudeTagErrorResponseErrorDiscriminatorType? type,
            global::Anthropic.BetaClaudeTagCodedPermissionError? permissionError,
            global::Anthropic.BetaClaudeTagSetUpSettingsRefusedError? invalidRequestError,
            global::Anthropic.BetaClaudeTagEnvironmentNotFoundError? notFoundError,
            global::Anthropic.BetaClaudeTagSettingsConflictError? conflictError
            )
        {
            Type = type;

            PermissionError = permissionError;
            InvalidRequestError = invalidRequestError;
            NotFoundError = notFoundError;
            ConflictError = conflictError;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ConflictError as object ??
            NotFoundError as object ??
            InvalidRequestError as object ??
            PermissionError as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PermissionError?.ToString() ??
            InvalidRequestError?.ToString() ??
            NotFoundError?.ToString() ??
            ConflictError?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPermissionError && !IsInvalidRequestError && !IsNotFoundError && !IsConflictError || !IsPermissionError && IsInvalidRequestError && !IsNotFoundError && !IsConflictError || !IsPermissionError && !IsInvalidRequestError && IsNotFoundError && !IsConflictError || !IsPermissionError && !IsInvalidRequestError && !IsNotFoundError && IsConflictError;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaClaudeTagCodedPermissionError, TResult>? permissionError = null,
            global::System.Func<global::Anthropic.BetaClaudeTagSetUpSettingsRefusedError, TResult>? invalidRequestError = null,
            global::System.Func<global::Anthropic.BetaClaudeTagEnvironmentNotFoundError, TResult>? notFoundError = null,
            global::System.Func<global::Anthropic.BetaClaudeTagSettingsConflictError, TResult>? conflictError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PermissionError is { } __value0 && permissionError != null)
            {
                return permissionError(__value0);
            }
            else if (InvalidRequestError is { } __value1 && invalidRequestError != null)
            {
                return invalidRequestError(__value1);
            }
            else if (NotFoundError is { } __value2 && notFoundError != null)
            {
                return notFoundError(__value2);
            }
            else if (ConflictError is { } __value3 && conflictError != null)
            {
                return conflictError(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaClaudeTagCodedPermissionError>? permissionError = null,

            global::System.Action<global::Anthropic.BetaClaudeTagSetUpSettingsRefusedError>? invalidRequestError = null,

            global::System.Action<global::Anthropic.BetaClaudeTagEnvironmentNotFoundError>? notFoundError = null,

            global::System.Action<global::Anthropic.BetaClaudeTagSettingsConflictError>? conflictError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PermissionError is { } __value0)
            {
                permissionError?.Invoke(__value0);
            }
            else if (InvalidRequestError is { } __value1)
            {
                invalidRequestError?.Invoke(__value1);
            }
            else if (NotFoundError is { } __value2)
            {
                notFoundError?.Invoke(__value2);
            }
            else if (ConflictError is { } __value3)
            {
                conflictError?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaClaudeTagCodedPermissionError>? permissionError = null,
            global::System.Action<global::Anthropic.BetaClaudeTagSetUpSettingsRefusedError>? invalidRequestError = null,
            global::System.Action<global::Anthropic.BetaClaudeTagEnvironmentNotFoundError>? notFoundError = null,
            global::System.Action<global::Anthropic.BetaClaudeTagSettingsConflictError>? conflictError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PermissionError is { } __value0)
            {
                permissionError?.Invoke(__value0);
            }
            else if (InvalidRequestError is { } __value1)
            {
                invalidRequestError?.Invoke(__value1);
            }
            else if (NotFoundError is { } __value2)
            {
                notFoundError?.Invoke(__value2);
            }
            else if (ConflictError is { } __value3)
            {
                conflictError?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PermissionError,
                typeof(global::Anthropic.BetaClaudeTagCodedPermissionError),
                InvalidRequestError,
                typeof(global::Anthropic.BetaClaudeTagSetUpSettingsRefusedError),
                NotFoundError,
                typeof(global::Anthropic.BetaClaudeTagEnvironmentNotFoundError),
                ConflictError,
                typeof(global::Anthropic.BetaClaudeTagSettingsConflictError),
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
        public bool Equals(BetaClaudeTagErrorResponseError other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeTagCodedPermissionError?>.Default.Equals(PermissionError, other.PermissionError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeTagSetUpSettingsRefusedError?>.Default.Equals(InvalidRequestError, other.InvalidRequestError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeTagEnvironmentNotFoundError?>.Default.Equals(NotFoundError, other.NotFoundError) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeTagSettingsConflictError?>.Default.Equals(ConflictError, other.ConflictError)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaClaudeTagErrorResponseError obj1, BetaClaudeTagErrorResponseError obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaClaudeTagErrorResponseError>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaClaudeTagErrorResponseError obj1, BetaClaudeTagErrorResponseError obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaClaudeTagErrorResponseError o && Equals(o);
        }
    }
}
