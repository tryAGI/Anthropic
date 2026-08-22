#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaOutputBehavior : global::System.IEquatable<BetaOutputBehavior>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorDiscriminatorType? Type { get; }

        /// <summary>
        /// The default destination: the job creates a new output memory store as a clone of the memory_store input and writes the consolidated memories into it. The input store is never mutated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaOutputBehaviorCreateNew? CreateNew { get; init; }
#else
        public global::Anthropic.BetaOutputBehaviorCreateNew? CreateNew { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateNew))]
#endif
        public bool IsCreateNew => CreateNew != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCreateNew(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaOutputBehaviorCreateNew? value)
        {
            value = CreateNew;
            return IsCreateNew;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorCreateNew PickCreateNew() => IsCreateNew
            ? CreateNew!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateNew' but the value was {ToString()}.");

        /// <summary>
        /// The job writes the consolidated memories into this existing memory store instead of creating one. In EAP the store must be the job's own memory_store input, so the job consolidates the store in place.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaOutputBehaviorUpdateExisting? UpdateExisting { get; init; }
#else
        public global::Anthropic.BetaOutputBehaviorUpdateExisting? UpdateExisting { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateExisting))]
#endif
        public bool IsUpdateExisting => UpdateExisting != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUpdateExisting(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaOutputBehaviorUpdateExisting? value)
        {
            value = UpdateExisting;
            return IsUpdateExisting;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaOutputBehaviorUpdateExisting PickUpdateExisting() => IsUpdateExisting
            ? UpdateExisting!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpdateExisting' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaOutputBehavior(global::Anthropic.BetaOutputBehaviorCreateNew value) => new BetaOutputBehavior((global::Anthropic.BetaOutputBehaviorCreateNew?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaOutputBehaviorCreateNew?(BetaOutputBehavior @this) => @this.CreateNew;

        /// <summary>
        /// 
        /// </summary>
        public BetaOutputBehavior(global::Anthropic.BetaOutputBehaviorCreateNew? value)
        {
            CreateNew = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaOutputBehavior FromCreateNew(global::Anthropic.BetaOutputBehaviorCreateNew? value) => new BetaOutputBehavior(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaOutputBehavior(global::Anthropic.BetaOutputBehaviorUpdateExisting value) => new BetaOutputBehavior((global::Anthropic.BetaOutputBehaviorUpdateExisting?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaOutputBehaviorUpdateExisting?(BetaOutputBehavior @this) => @this.UpdateExisting;

        /// <summary>
        /// 
        /// </summary>
        public BetaOutputBehavior(global::Anthropic.BetaOutputBehaviorUpdateExisting? value)
        {
            UpdateExisting = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaOutputBehavior FromUpdateExisting(global::Anthropic.BetaOutputBehaviorUpdateExisting? value) => new BetaOutputBehavior(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaOutputBehavior(
            global::Anthropic.BetaOutputBehaviorDiscriminatorType? type,
            global::Anthropic.BetaOutputBehaviorCreateNew? createNew,
            global::Anthropic.BetaOutputBehaviorUpdateExisting? updateExisting
            )
        {
            Type = type;

            CreateNew = createNew;
            UpdateExisting = updateExisting;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UpdateExisting as object ??
            CreateNew as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreateNew?.ToString() ??
            UpdateExisting?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreateNew && !IsUpdateExisting || !IsCreateNew && IsUpdateExisting;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaOutputBehaviorCreateNew, TResult>? createNew = null,
            global::System.Func<global::Anthropic.BetaOutputBehaviorUpdateExisting, TResult>? updateExisting = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateNew && createNew != null)
            {
                return createNew(CreateNew!);
            }
            else if (IsUpdateExisting && updateExisting != null)
            {
                return updateExisting(UpdateExisting!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaOutputBehaviorCreateNew>? createNew = null,

            global::System.Action<global::Anthropic.BetaOutputBehaviorUpdateExisting>? updateExisting = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateNew)
            {
                createNew?.Invoke(CreateNew!);
            }
            else if (IsUpdateExisting)
            {
                updateExisting?.Invoke(UpdateExisting!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaOutputBehaviorCreateNew>? createNew = null,
            global::System.Action<global::Anthropic.BetaOutputBehaviorUpdateExisting>? updateExisting = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateNew)
            {
                createNew?.Invoke(CreateNew!);
            }
            else if (IsUpdateExisting)
            {
                updateExisting?.Invoke(UpdateExisting!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateNew,
                typeof(global::Anthropic.BetaOutputBehaviorCreateNew),
                UpdateExisting,
                typeof(global::Anthropic.BetaOutputBehaviorUpdateExisting),
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
        public bool Equals(BetaOutputBehavior other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaOutputBehaviorCreateNew?>.Default.Equals(CreateNew, other.CreateNew) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaOutputBehaviorUpdateExisting?>.Default.Equals(UpdateExisting, other.UpdateExisting) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaOutputBehavior obj1, BetaOutputBehavior obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaOutputBehavior>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaOutputBehavior obj1, BetaOutputBehavior obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaOutputBehavior o && Equals(o);
        }
    }
}
