#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The rate-limit group this entry's limits apply to. Its `type` equals `group_type`.
    /// </summary>
    public readonly partial struct Group4 : global::System.IEquatable<Group4>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WorkspaceRateLimitGroupDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RateLimitModelGroup? ModelGroup { get; init; }
#else
        public global::Anthropic.RateLimitModelGroup? ModelGroup { get; }
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
            out global::Anthropic.RateLimitModelGroup? value)
        {
            value = ModelGroup;
            return IsModelGroup;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitModelGroup PickModelGroup() => ModelGroup is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelGroup' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RateLimitBatchGroup? Batch { get; init; }
#else
        public global::Anthropic.RateLimitBatchGroup? Batch { get; }
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
            out global::Anthropic.RateLimitBatchGroup? value)
        {
            value = Batch;
            return IsBatch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitBatchGroup PickBatch() => Batch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Batch' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RateLimitTokenCountGroup? TokenCount { get; init; }
#else
        public global::Anthropic.RateLimitTokenCountGroup? TokenCount { get; }
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
            out global::Anthropic.RateLimitTokenCountGroup? value)
        {
            value = TokenCount;
            return IsTokenCount;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitTokenCountGroup PickTokenCount() => TokenCount is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TokenCount' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RateLimitFilesGroup? Files { get; init; }
#else
        public global::Anthropic.RateLimitFilesGroup? Files { get; }
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
            out global::Anthropic.RateLimitFilesGroup? value)
        {
            value = Files;
            return IsFiles;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitFilesGroup PickFiles() => Files is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Files' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RateLimitSkillsGroup? Skills { get; init; }
#else
        public global::Anthropic.RateLimitSkillsGroup? Skills { get; }
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
            out global::Anthropic.RateLimitSkillsGroup? value)
        {
            value = Skills;
            return IsSkills;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitSkillsGroup PickSkills() => Skills is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Skills' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RateLimitWebSearchGroup? WebSearch { get; init; }
#else
        public global::Anthropic.RateLimitWebSearchGroup? WebSearch { get; }
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
            out global::Anthropic.RateLimitWebSearchGroup? value)
        {
            value = WebSearch;
            return IsWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RateLimitWebSearchGroup PickWebSearch() => WebSearch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearch' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Group4(global::Anthropic.RateLimitModelGroup value) => new Group4((global::Anthropic.RateLimitModelGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.RateLimitModelGroup?(Group4 @this) => @this.ModelGroup;

        /// <summary>
        ///
        /// </summary>
        public Group4(global::Anthropic.RateLimitModelGroup? value)
        {
            ModelGroup = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Group4 FromModelGroup(global::Anthropic.RateLimitModelGroup? value) => new Group4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Group4(global::Anthropic.RateLimitBatchGroup value) => new Group4((global::Anthropic.RateLimitBatchGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.RateLimitBatchGroup?(Group4 @this) => @this.Batch;

        /// <summary>
        ///
        /// </summary>
        public Group4(global::Anthropic.RateLimitBatchGroup? value)
        {
            Batch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Group4 FromBatch(global::Anthropic.RateLimitBatchGroup? value) => new Group4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Group4(global::Anthropic.RateLimitTokenCountGroup value) => new Group4((global::Anthropic.RateLimitTokenCountGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.RateLimitTokenCountGroup?(Group4 @this) => @this.TokenCount;

        /// <summary>
        ///
        /// </summary>
        public Group4(global::Anthropic.RateLimitTokenCountGroup? value)
        {
            TokenCount = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Group4 FromTokenCount(global::Anthropic.RateLimitTokenCountGroup? value) => new Group4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Group4(global::Anthropic.RateLimitFilesGroup value) => new Group4((global::Anthropic.RateLimitFilesGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.RateLimitFilesGroup?(Group4 @this) => @this.Files;

        /// <summary>
        ///
        /// </summary>
        public Group4(global::Anthropic.RateLimitFilesGroup? value)
        {
            Files = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Group4 FromFiles(global::Anthropic.RateLimitFilesGroup? value) => new Group4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Group4(global::Anthropic.RateLimitSkillsGroup value) => new Group4((global::Anthropic.RateLimitSkillsGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.RateLimitSkillsGroup?(Group4 @this) => @this.Skills;

        /// <summary>
        ///
        /// </summary>
        public Group4(global::Anthropic.RateLimitSkillsGroup? value)
        {
            Skills = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Group4 FromSkills(global::Anthropic.RateLimitSkillsGroup? value) => new Group4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Group4(global::Anthropic.RateLimitWebSearchGroup value) => new Group4((global::Anthropic.RateLimitWebSearchGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.RateLimitWebSearchGroup?(Group4 @this) => @this.WebSearch;

        /// <summary>
        ///
        /// </summary>
        public Group4(global::Anthropic.RateLimitWebSearchGroup? value)
        {
            WebSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Group4 FromWebSearch(global::Anthropic.RateLimitWebSearchGroup? value) => new Group4(value);

        /// <summary>
        ///
        /// </summary>
        public Group4(
            global::Anthropic.WorkspaceRateLimitGroupDiscriminatorType? type,
            global::Anthropic.RateLimitModelGroup? modelGroup,
            global::Anthropic.RateLimitBatchGroup? batch,
            global::Anthropic.RateLimitTokenCountGroup? tokenCount,
            global::Anthropic.RateLimitFilesGroup? files,
            global::Anthropic.RateLimitSkillsGroup? skills,
            global::Anthropic.RateLimitWebSearchGroup? webSearch
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
            global::System.Func<global::Anthropic.RateLimitModelGroup, TResult>? modelGroup = null,
            global::System.Func<global::Anthropic.RateLimitBatchGroup, TResult>? batch = null,
            global::System.Func<global::Anthropic.RateLimitTokenCountGroup, TResult>? tokenCount = null,
            global::System.Func<global::Anthropic.RateLimitFilesGroup, TResult>? files = null,
            global::System.Func<global::Anthropic.RateLimitSkillsGroup, TResult>? skills = null,
            global::System.Func<global::Anthropic.RateLimitWebSearchGroup, TResult>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ModelGroup is { } __value0 && modelGroup != null)
            {
                return modelGroup(__value0);
            }
            else if (Batch is { } __value1 && batch != null)
            {
                return batch(__value1);
            }
            else if (TokenCount is { } __value2 && tokenCount != null)
            {
                return tokenCount(__value2);
            }
            else if (Files is { } __value3 && files != null)
            {
                return files(__value3);
            }
            else if (Skills is { } __value4 && skills != null)
            {
                return skills(__value4);
            }
            else if (WebSearch is { } __value5 && webSearch != null)
            {
                return webSearch(__value5);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.RateLimitModelGroup>? modelGroup = null,

            global::System.Action<global::Anthropic.RateLimitBatchGroup>? batch = null,

            global::System.Action<global::Anthropic.RateLimitTokenCountGroup>? tokenCount = null,

            global::System.Action<global::Anthropic.RateLimitFilesGroup>? files = null,

            global::System.Action<global::Anthropic.RateLimitSkillsGroup>? skills = null,

            global::System.Action<global::Anthropic.RateLimitWebSearchGroup>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ModelGroup is { } __value0)
            {
                modelGroup?.Invoke(__value0);
            }
            else if (Batch is { } __value1)
            {
                batch?.Invoke(__value1);
            }
            else if (TokenCount is { } __value2)
            {
                tokenCount?.Invoke(__value2);
            }
            else if (Files is { } __value3)
            {
                files?.Invoke(__value3);
            }
            else if (Skills is { } __value4)
            {
                skills?.Invoke(__value4);
            }
            else if (WebSearch is { } __value5)
            {
                webSearch?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.RateLimitModelGroup>? modelGroup = null,
            global::System.Action<global::Anthropic.RateLimitBatchGroup>? batch = null,
            global::System.Action<global::Anthropic.RateLimitTokenCountGroup>? tokenCount = null,
            global::System.Action<global::Anthropic.RateLimitFilesGroup>? files = null,
            global::System.Action<global::Anthropic.RateLimitSkillsGroup>? skills = null,
            global::System.Action<global::Anthropic.RateLimitWebSearchGroup>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ModelGroup is { } __value0)
            {
                modelGroup?.Invoke(__value0);
            }
            else if (Batch is { } __value1)
            {
                batch?.Invoke(__value1);
            }
            else if (TokenCount is { } __value2)
            {
                tokenCount?.Invoke(__value2);
            }
            else if (Files is { } __value3)
            {
                files?.Invoke(__value3);
            }
            else if (Skills is { } __value4)
            {
                skills?.Invoke(__value4);
            }
            else if (WebSearch is { } __value5)
            {
                webSearch?.Invoke(__value5);
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
                typeof(global::Anthropic.RateLimitModelGroup),
                Batch,
                typeof(global::Anthropic.RateLimitBatchGroup),
                TokenCount,
                typeof(global::Anthropic.RateLimitTokenCountGroup),
                Files,
                typeof(global::Anthropic.RateLimitFilesGroup),
                Skills,
                typeof(global::Anthropic.RateLimitSkillsGroup),
                WebSearch,
                typeof(global::Anthropic.RateLimitWebSearchGroup),
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
        public bool Equals(Group4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RateLimitModelGroup?>.Default.Equals(ModelGroup, other.ModelGroup) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RateLimitBatchGroup?>.Default.Equals(Batch, other.Batch) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RateLimitTokenCountGroup?>.Default.Equals(TokenCount, other.TokenCount) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RateLimitFilesGroup?>.Default.Equals(Files, other.Files) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RateLimitSkillsGroup?>.Default.Equals(Skills, other.Skills) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RateLimitWebSearchGroup?>.Default.Equals(WebSearch, other.WebSearch)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Group4 obj1, Group4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Group4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Group4 obj1, Group4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Group4 o && Equals(o);
        }
    }
}
