
#nullable enable
namespace Anthropic
{
    // Instances reference only this component and its outgoing dependency components.
    internal sealed partial class SourceGenerationContextMetadataScope : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
    {

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(string))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0305.Create_String(options);
                }
                if (type == typeof(object))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0242.Create_Object(options);
                }
                if (type == typeof(bool))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0151.Create_Boolean(options);
                }
                if (type == typeof(byte))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0156.Create_Byte(options);
                }
                if (type == typeof(int))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0181.Create_Int32(options);
                }
                if (type == typeof(long))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0181.Create_Int64(options);
                }
                if (type == typeof(double))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0176.Create_Double(options);
                }
                if (type == typeof(byte[]))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0156.Create_ByteArray(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0175.Create_DateTime(options);
                }
                if (type == typeof(global::System.Guid))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0180.Create_Guid(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0181.Create_JsonElement(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0232.Create_NullableJsonElement(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, string>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0303.Create_SourceGenerationContextMetadataType_FC0ACBA26C044EC8(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, object>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0282.Create_SourceGenerationContextMetadataType_8219E7AD6AEFA4B4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IDictionary<string, object>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0279.Create_SourceGenerationContextMetadataType_7024F6984ED20EB8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<object>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0284.Create_SourceGenerationContextMetadataType_92E1ACA86984772C(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }

        private static readonly SharedMetadataResolver Intrinsic = new();
        private readonly global::System.Lazy<ScopedContext> _default;
        internal global::System.Text.Json.Serialization.JsonSerializerContext Default => _default.Value;
        // One options-bound context implementation serves every internal component.
        // Options are created lazily, after all component initializers have completed.
        private sealed class ScopedContext : global::System.Text.Json.Serialization.JsonSerializerContext
        {
            private readonly SourceGenerationContextMetadataScope _scope;
            internal ScopedContext(SourceGenerationContextMetadataScope scope) : base(scope.CreateOptions()) => _scope = scope;
            protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => Options;
            public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
                _scope.GetTypeInfo(type, Options);
        }
        private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver? _own;
        private readonly global::System.Func<SourceGenerationContextMetadataScope>[] _dependencies;
        private readonly global::System.Action<ConverterCollector>? _contribute;
        internal SourceGenerationContextMetadataScope(global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver? own,
            global::System.Func<SourceGenerationContextMetadataScope>[] dependencies, global::System.Action<ConverterCollector>? contribute)
        {
            _default = new global::System.Lazy<ScopedContext>(() => new ScopedContext(this));
            _own = own;
            _dependencies = dependencies;
            _contribute = contribute;
        }
        // Iteration bounds deep graphs and visits a shared diamond dependency only once.
        private global::System.Collections.Generic.IEnumerable<SourceGenerationContextMetadataScope> Traverse()
        {
            var visited = new global::System.Collections.Generic.HashSet<SourceGenerationContextMetadataScope>();
            var pending = new global::System.Collections.Generic.Stack<SourceGenerationContextMetadataScope>();
            pending.Push(this);
            while (pending.Count != 0)
            {
                var scope = pending.Pop();
                if (!visited.Add(scope)) continue;
                yield return scope;
                for (var index = scope._dependencies.Length - 1; index >= 0; index--)
                    pending.Push(scope._dependencies[index]());
            }
        }
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
            global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
        {
            foreach (var scope in Traverse())
                if (scope._own?.GetTypeInfo(type, options) is { } info) return info;
            return Intrinsic.GetTypeInfo(type, options);
        }
        internal global::System.Text.Json.JsonSerializerOptions CreateOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = this,
            };
            AddConverters(options);
            return options;
        }
        internal void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            var collector = new ConverterCollector(options);
            foreach (var scope in Traverse()) scope._contribute?.Invoke(collector);
            collector.Complete();
        }
        internal sealed class ConverterCollector(global::System.Text.Json.JsonSerializerOptions options)
        {
            private readonly global::System.Collections.Generic.Dictionary<global::System.Type,
                global::System.Func<global::System.Text.Json.Serialization.JsonConverter>> _enums = new();
            private readonly global::System.Collections.Generic.HashSet<global::System.Type> _eager = new();
            internal void AddEnum(global::System.Type type,
                global::System.Func<global::System.Text.Json.Serialization.JsonConverter> factory) => _enums.TryAdd(type, factory);
            internal void AddEager<T>(global::System.Func<T> factory) where T : global::System.Text.Json.Serialization.JsonConverter
            {
                if (!_eager.Add(typeof(T))) return;
                foreach (var converter in options.Converters) if (converter is T) return;
                options.Converters.Add(factory());
            }
            internal void Complete()
            {
                if (_enums.Count != 0) options.Converters.Add(new EnumConverters(_enums));
            }
        }
        private sealed class EnumConverters(global::System.Collections.Generic.Dictionary<global::System.Type,
            global::System.Func<global::System.Text.Json.Serialization.JsonConverter>> factories)
            : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert) => factories.ContainsKey(typeToConvert);
            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert, global::System.Text.Json.JsonSerializerOptions options) =>
                factories.TryGetValue(typeToConvert, out var factory) ? factory() :
                    throw new global::System.NotSupportedException(typeToConvert.FullName);
        }
    }

    // A lookup facade only: never assign it to JsonSerializerOptions.TypeInfoResolver.
    // The framework cache stays owned by the caller's options and handles recursive graphs.
    internal sealed class AutoSDKJsonMetadataCachedResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
    {
        internal static readonly AutoSDKJsonMetadataCachedResolver Instance = new();
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
            global::System.Type type, global::System.Text.Json.JsonSerializerOptions options) =>
            options.TryGetTypeInfo(type, out var info) ? info : null;
    }
}