#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The rate-limit group this entry's limits apply to. Its `type` equals `group_type`.
    /// </summary>
    public readonly partial struct Group2 : global::System.IEquatable<Group2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWorkspaceRateLimitGroupDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRateLimitModelGroup? ModelGroup { get; init; }
#else
        public global::Anthropic.BetaRateLimitModelGroup? ModelGroup { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelGroup))]
#endif
        public bool IsModelGroup => ModelGroup != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelGroup(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRateLimitModelGroup? value)
        {
            value = ModelGroup;
            return IsModelGroup;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitModelGroup PickModelGroup() => IsModelGroup
            ? ModelGroup!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelGroup' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRateLimitBatchGroup? Batch { get; init; }
#else
        public global::Anthropic.BetaRateLimitBatchGroup? Batch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Batch))]
#endif
        public bool IsBatch => Batch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBatch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRateLimitBatchGroup? value)
        {
            value = Batch;
            return IsBatch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitBatchGroup PickBatch() => IsBatch
            ? Batch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Batch' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRateLimitTokenCountGroup? TokenCount { get; init; }
#else
        public global::Anthropic.BetaRateLimitTokenCountGroup? TokenCount { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TokenCount))]
#endif
        public bool IsTokenCount => TokenCount != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTokenCount(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRateLimitTokenCountGroup? value)
        {
            value = TokenCount;
            return IsTokenCount;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitTokenCountGroup PickTokenCount() => IsTokenCount
            ? TokenCount!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TokenCount' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRateLimitFilesGroup? Files { get; init; }
#else
        public global::Anthropic.BetaRateLimitFilesGroup? Files { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Files))]
#endif
        public bool IsFiles => Files != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFiles(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRateLimitFilesGroup? value)
        {
            value = Files;
            return IsFiles;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitFilesGroup PickFiles() => IsFiles
            ? Files!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Files' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRateLimitSkillsGroup? Skills { get; init; }
#else
        public global::Anthropic.BetaRateLimitSkillsGroup? Skills { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Skills))]
#endif
        public bool IsSkills => Skills != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSkills(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRateLimitSkillsGroup? value)
        {
            value = Skills;
            return IsSkills;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitSkillsGroup PickSkills() => IsSkills
            ? Skills!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Skills' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRateLimitWebSearchGroup? WebSearch { get; init; }
#else
        public global::Anthropic.BetaRateLimitWebSearchGroup? WebSearch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearch))]
#endif
        public bool IsWebSearch => WebSearch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaRateLimitWebSearchGroup? value)
        {
            value = WebSearch;
            return IsWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRateLimitWebSearchGroup PickWebSearch() => IsWebSearch
            ? WebSearch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearch' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Group2(global::Anthropic.BetaRateLimitModelGroup value) => new Group2((global::Anthropic.BetaRateLimitModelGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRateLimitModelGroup?(Group2 @this) => @this.ModelGroup;

        /// <summary>
        ///
        /// </summary>
        public Group2(global::Anthropic.BetaRateLimitModelGroup? value)
        {
            ModelGroup = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Group2 FromModelGroup(global::Anthropic.BetaRateLimitModelGroup? value) => new Group2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Group2(global::Anthropic.BetaRateLimitBatchGroup value) => new Group2((global::Anthropic.BetaRateLimitBatchGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRateLimitBatchGroup?(Group2 @this) => @this.Batch;

        /// <summary>
        ///
        /// </summary>
        public Group2(global::Anthropic.BetaRateLimitBatchGroup? value)
        {
            Batch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Group2 FromBatch(global::Anthropic.BetaRateLimitBatchGroup? value) => new Group2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Group2(global::Anthropic.BetaRateLimitTokenCountGroup value) => new Group2((global::Anthropic.BetaRateLimitTokenCountGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRateLimitTokenCountGroup?(Group2 @this) => @this.TokenCount;

        /// <summary>
        ///
        /// </summary>
        public Group2(global::Anthropic.BetaRateLimitTokenCountGroup? value)
        {
            TokenCount = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Group2 FromTokenCount(global::Anthropic.BetaRateLimitTokenCountGroup? value) => new Group2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Group2(global::Anthropic.BetaRateLimitFilesGroup value) => new Group2((global::Anthropic.BetaRateLimitFilesGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRateLimitFilesGroup?(Group2 @this) => @this.Files;

        /// <summary>
        ///
        /// </summary>
        public Group2(global::Anthropic.BetaRateLimitFilesGroup? value)
        {
            Files = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Group2 FromFiles(global::Anthropic.BetaRateLimitFilesGroup? value) => new Group2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Group2(global::Anthropic.BetaRateLimitSkillsGroup value) => new Group2((global::Anthropic.BetaRateLimitSkillsGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRateLimitSkillsGroup?(Group2 @this) => @this.Skills;

        /// <summary>
        ///
        /// </summary>
        public Group2(global::Anthropic.BetaRateLimitSkillsGroup? value)
        {
            Skills = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Group2 FromSkills(global::Anthropic.BetaRateLimitSkillsGroup? value) => new Group2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Group2(global::Anthropic.BetaRateLimitWebSearchGroup value) => new Group2((global::Anthropic.BetaRateLimitWebSearchGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRateLimitWebSearchGroup?(Group2 @this) => @this.WebSearch;

        /// <summary>
        ///
        /// </summary>
        public Group2(global::Anthropic.BetaRateLimitWebSearchGroup? value)
        {
            WebSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Group2 FromWebSearch(global::Anthropic.BetaRateLimitWebSearchGroup? value) => new Group2(value);

        /// <summary>
        ///
        /// </summary>
        public Group2(
            global::Anthropic.BetaWorkspaceRateLimitGroupDiscriminatorType? type,
            global::Anthropic.BetaRateLimitModelGroup? modelGroup,
            global::Anthropic.BetaRateLimitBatchGroup? batch,
            global::Anthropic.BetaRateLimitTokenCountGroup? tokenCount,
            global::Anthropic.BetaRateLimitFilesGroup? files,
            global::Anthropic.BetaRateLimitSkillsGroup? skills,
            global::Anthropic.BetaRateLimitWebSearchGroup? webSearch
            )
        {
            Type = type;

            ModelGroup = modelGroup;
            Batch = batch;
            TokenCount = tokenCount;
            Files = files;
            Skills = skills;
            WebSearch = webSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebSearch as object ??
            Skills as object ??
            Files as object ??
            TokenCount as object ??
            Batch as object ??
            ModelGroup as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ModelGroup?.ToString() ??
            Batch?.ToString() ??
            TokenCount?.ToString() ??
            Files?.ToString() ??
            Skills?.ToString() ??
            WebSearch?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsModelGroup && !IsBatch && !IsTokenCount && !IsFiles && !IsSkills && !IsWebSearch || !IsModelGroup && IsBatch && !IsTokenCount && !IsFiles && !IsSkills && !IsWebSearch || !IsModelGroup && !IsBatch && IsTokenCount && !IsFiles && !IsSkills && !IsWebSearch || !IsModelGroup && !IsBatch && !IsTokenCount && IsFiles && !IsSkills && !IsWebSearch || !IsModelGroup && !IsBatch && !IsTokenCount && !IsFiles && IsSkills && !IsWebSearch || !IsModelGroup && !IsBatch && !IsTokenCount && !IsFiles && !IsSkills && IsWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaRateLimitModelGroup, TResult>? modelGroup = null,
            global::System.Func<global::Anthropic.BetaRateLimitBatchGroup, TResult>? batch = null,
            global::System.Func<global::Anthropic.BetaRateLimitTokenCountGroup, TResult>? tokenCount = null,
            global::System.Func<global::Anthropic.BetaRateLimitFilesGroup, TResult>? files = null,
            global::System.Func<global::Anthropic.BetaRateLimitSkillsGroup, TResult>? skills = null,
            global::System.Func<global::Anthropic.BetaRateLimitWebSearchGroup, TResult>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelGroup && modelGroup != null)
            {
                return modelGroup(ModelGroup!);
            }
            else if (IsBatch && batch != null)
            {
                return batch(Batch!);
            }
            else if (IsTokenCount && tokenCount != null)
            {
                return tokenCount(TokenCount!);
            }
            else if (IsFiles && files != null)
            {
                return files(Files!);
            }
            else if (IsSkills && skills != null)
            {
                return skills(Skills!);
            }
            else if (IsWebSearch && webSearch != null)
            {
                return webSearch(WebSearch!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaRateLimitModelGroup>? modelGroup = null,

            global::System.Action<global::Anthropic.BetaRateLimitBatchGroup>? batch = null,

            global::System.Action<global::Anthropic.BetaRateLimitTokenCountGroup>? tokenCount = null,

            global::System.Action<global::Anthropic.BetaRateLimitFilesGroup>? files = null,

            global::System.Action<global::Anthropic.BetaRateLimitSkillsGroup>? skills = null,

            global::System.Action<global::Anthropic.BetaRateLimitWebSearchGroup>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelGroup)
            {
                modelGroup?.Invoke(ModelGroup!);
            }
            else if (IsBatch)
            {
                batch?.Invoke(Batch!);
            }
            else if (IsTokenCount)
            {
                tokenCount?.Invoke(TokenCount!);
            }
            else if (IsFiles)
            {
                files?.Invoke(Files!);
            }
            else if (IsSkills)
            {
                skills?.Invoke(Skills!);
            }
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaRateLimitModelGroup>? modelGroup = null,
            global::System.Action<global::Anthropic.BetaRateLimitBatchGroup>? batch = null,
            global::System.Action<global::Anthropic.BetaRateLimitTokenCountGroup>? tokenCount = null,
            global::System.Action<global::Anthropic.BetaRateLimitFilesGroup>? files = null,
            global::System.Action<global::Anthropic.BetaRateLimitSkillsGroup>? skills = null,
            global::System.Action<global::Anthropic.BetaRateLimitWebSearchGroup>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelGroup)
            {
                modelGroup?.Invoke(ModelGroup!);
            }
            else if (IsBatch)
            {
                batch?.Invoke(Batch!);
            }
            else if (IsTokenCount)
            {
                tokenCount?.Invoke(TokenCount!);
            }
            else if (IsFiles)
            {
                files?.Invoke(Files!);
            }
            else if (IsSkills)
            {
                skills?.Invoke(Skills!);
            }
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ModelGroup,
                typeof(global::Anthropic.BetaRateLimitModelGroup),
                Batch,
                typeof(global::Anthropic.BetaRateLimitBatchGroup),
                TokenCount,
                typeof(global::Anthropic.BetaRateLimitTokenCountGroup),
                Files,
                typeof(global::Anthropic.BetaRateLimitFilesGroup),
                Skills,
                typeof(global::Anthropic.BetaRateLimitSkillsGroup),
                WebSearch,
                typeof(global::Anthropic.BetaRateLimitWebSearchGroup),
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
        public bool Equals(Group2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRateLimitModelGroup?>.Default.Equals(ModelGroup, other.ModelGroup) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRateLimitBatchGroup?>.Default.Equals(Batch, other.Batch) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRateLimitTokenCountGroup?>.Default.Equals(TokenCount, other.TokenCount) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRateLimitFilesGroup?>.Default.Equals(Files, other.Files) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRateLimitSkillsGroup?>.Default.Equals(Skills, other.Skills) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRateLimitWebSearchGroup?>.Default.Equals(WebSearch, other.WebSearch)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Group2 obj1, Group2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Group2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Group2 obj1, Group2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Group2 o && Equals(o);
        }
    }
}
