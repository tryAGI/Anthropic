#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CreatedByVariant1 : global::System.IEquatable<CreatedByVariant1>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginCreatedByVariant1DiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaPluginUserActor? UserActor { get; init; }
#else
        public global::Anthropic.BetaPluginUserActor? UserActor { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserActor))]
#endif
        public bool IsUserActor => UserActor != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUserActor(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaPluginUserActor? value)
        {
            value = UserActor;
            return IsUserActor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginUserActor PickUserActor() => UserActor is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserActor' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaPluginApiActor? ApiActor { get; init; }
#else
        public global::Anthropic.BetaPluginApiActor? ApiActor { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiActor))]
#endif
        public bool IsApiActor => ApiActor != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickApiActor(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaPluginApiActor? value)
        {
            value = ApiActor;
            return IsApiActor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPluginApiActor PickApiActor() => ApiActor is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApiActor' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreatedByVariant1(global::Anthropic.BetaPluginUserActor value) => new CreatedByVariant1((global::Anthropic.BetaPluginUserActor?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaPluginUserActor?(CreatedByVariant1 @this) => @this.UserActor;

        /// <summary>
        ///
        /// </summary>
        public CreatedByVariant1(global::Anthropic.BetaPluginUserActor? value)
        {
            UserActor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreatedByVariant1 FromUserActor(global::Anthropic.BetaPluginUserActor? value) => new CreatedByVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreatedByVariant1(global::Anthropic.BetaPluginApiActor value) => new CreatedByVariant1((global::Anthropic.BetaPluginApiActor?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaPluginApiActor?(CreatedByVariant1 @this) => @this.ApiActor;

        /// <summary>
        ///
        /// </summary>
        public CreatedByVariant1(global::Anthropic.BetaPluginApiActor? value)
        {
            ApiActor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreatedByVariant1 FromApiActor(global::Anthropic.BetaPluginApiActor? value) => new CreatedByVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public CreatedByVariant1(
            global::Anthropic.BetaPluginCreatedByVariant1DiscriminatorType? type,
            global::Anthropic.BetaPluginUserActor? userActor,
            global::Anthropic.BetaPluginApiActor? apiActor
            )
        {
            Type = type;

            UserActor = userActor;
            ApiActor = apiActor;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ApiActor as object ??
            UserActor as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UserActor?.ToString() ??
            ApiActor?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUserActor && !IsApiActor || !IsUserActor && IsApiActor;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaPluginUserActor, TResult>? userActor = null,
            global::System.Func<global::Anthropic.BetaPluginApiActor, TResult>? apiActor = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (UserActor is { } __value0 && userActor != null)
            {
                return userActor(__value0);
            }
            else if (ApiActor is { } __value1 && apiActor != null)
            {
                return apiActor(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaPluginUserActor>? userActor = null,

            global::System.Action<global::Anthropic.BetaPluginApiActor>? apiActor = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (UserActor is { } __value0)
            {
                userActor?.Invoke(__value0);
            }
            else if (ApiActor is { } __value1)
            {
                apiActor?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaPluginUserActor>? userActor = null,
            global::System.Action<global::Anthropic.BetaPluginApiActor>? apiActor = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (UserActor is { } __value0)
            {
                userActor?.Invoke(__value0);
            }
            else if (ApiActor is { } __value1)
            {
                apiActor?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UserActor,
                typeof(global::Anthropic.BetaPluginUserActor),
                ApiActor,
                typeof(global::Anthropic.BetaPluginApiActor),
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
        public bool Equals(CreatedByVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaPluginUserActor?>.Default.Equals(UserActor, other.UserActor) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaPluginApiActor?>.Default.Equals(ApiActor, other.ApiActor)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreatedByVariant1 obj1, CreatedByVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreatedByVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreatedByVariant1 obj1, CreatedByVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreatedByVariant1 o && Equals(o);
        }
    }
}
