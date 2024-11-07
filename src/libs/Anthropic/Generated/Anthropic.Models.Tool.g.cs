using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A tool the model may use.
    /// </summary>
    public readonly partial struct Tool : global::System.IEquatable<Tool>
    {
        /// <summary>
        /// A custom tool the model may use.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ToolCustom? Custom { get; init; }
#else
        public global::Anthropic.ToolCustom? Custom { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Anthropic.ToolCustom value) => new Tool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ToolCustom?(Tool @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Anthropic.ToolCustom? value)
        {
            Custom = value;
        }

        /// <summary>
        /// A tool that uses a mouse and keyboard to interact with a computer, and take screenshots.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ToolComputerUse? ComputerUse { get; init; }
#else
        public global::Anthropic.ToolComputerUse? ComputerUse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerUse))]
#endif
        public bool IsComputerUse => ComputerUse != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Anthropic.ToolComputerUse value) => new Tool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ToolComputerUse?(Tool @this) => @this.ComputerUse;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Anthropic.ToolComputerUse? value)
        {
            ComputerUse = value;
        }

        /// <summary>
        /// A tool for viewing, creating and editing files.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ToolTextEditor? TextEditor { get; init; }
#else
        public global::Anthropic.ToolTextEditor? TextEditor { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditor))]
#endif
        public bool IsTextEditor => TextEditor != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Anthropic.ToolTextEditor value) => new Tool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ToolTextEditor?(Tool @this) => @this.TextEditor;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Anthropic.ToolTextEditor? value)
        {
            TextEditor = value;
        }

        /// <summary>
        /// A tool for running commands in a bash shell.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ToolBash? Bash { get; init; }
#else
        public global::Anthropic.ToolBash? Bash { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bash))]
#endif
        public bool IsBash => Bash != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool(global::Anthropic.ToolBash value) => new Tool(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ToolBash?(Tool @this) => @this.Bash;

        /// <summary>
        /// 
        /// </summary>
        public Tool(global::Anthropic.ToolBash? value)
        {
            Bash = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Tool(
            global::Anthropic.ToolCustom? custom,
            global::Anthropic.ToolComputerUse? computerUse,
            global::Anthropic.ToolTextEditor? textEditor,
            global::Anthropic.ToolBash? bash
            )
        {
            Custom = custom;
            ComputerUse = computerUse;
            TextEditor = textEditor;
            Bash = bash;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Bash as object ??
            TextEditor as object ??
            ComputerUse as object ??
            Custom as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCustom && !IsComputerUse && !IsTextEditor && !IsBash || !IsCustom && IsComputerUse && !IsTextEditor && !IsBash || !IsCustom && !IsComputerUse && IsTextEditor && !IsBash || !IsCustom && !IsComputerUse && !IsTextEditor && IsBash;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.ToolCustom?, TResult>? custom = null,
            global::System.Func<global::Anthropic.ToolComputerUse?, TResult>? computerUse = null,
            global::System.Func<global::Anthropic.ToolTextEditor?, TResult>? textEditor = null,
            global::System.Func<global::Anthropic.ToolBash?, TResult>? bash = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }
            else if (IsComputerUse && computerUse != null)
            {
                return computerUse(ComputerUse!);
            }
            else if (IsTextEditor && textEditor != null)
            {
                return textEditor(TextEditor!);
            }
            else if (IsBash && bash != null)
            {
                return bash(Bash!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.ToolCustom?>? custom = null,
            global::System.Action<global::Anthropic.ToolComputerUse?>? computerUse = null,
            global::System.Action<global::Anthropic.ToolTextEditor?>? textEditor = null,
            global::System.Action<global::Anthropic.ToolBash?>? bash = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsComputerUse)
            {
                computerUse?.Invoke(ComputerUse!);
            }
            else if (IsTextEditor)
            {
                textEditor?.Invoke(TextEditor!);
            }
            else if (IsBash)
            {
                bash?.Invoke(Bash!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Custom,
                typeof(global::Anthropic.ToolCustom),
                ComputerUse,
                typeof(global::Anthropic.ToolComputerUse),
                TextEditor,
                typeof(global::Anthropic.ToolTextEditor),
                Bash,
                typeof(global::Anthropic.ToolBash),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Tool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ToolCustom?>.Default.Equals(Custom, other.Custom) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ToolComputerUse?>.Default.Equals(ComputerUse, other.ComputerUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ToolTextEditor?>.Default.Equals(TextEditor, other.TextEditor) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ToolBash?>.Default.Equals(Bash, other.Bash) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Tool obj1, Tool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Tool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Tool obj1, Tool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Tool o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::Anthropic.Tool? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Anthropic.Tool),
                jsonSerializerContext) as global::Anthropic.Tool?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Anthropic.Tool? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.Tool>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::Anthropic.Tool?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::Anthropic.Tool),
                jsonSerializerContext).ConfigureAwait(false)) as global::Anthropic.Tool?;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::Anthropic.Tool?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::Anthropic.Tool?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
