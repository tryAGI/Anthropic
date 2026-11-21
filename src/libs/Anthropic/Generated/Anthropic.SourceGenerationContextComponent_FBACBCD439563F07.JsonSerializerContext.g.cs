
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_FBACBCD439563F07
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_0ECF4825A42D435B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D25598F808A4B0FC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F4F491BBCEE0E836.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.CodeExecutionToolResultError, global::Anthropic.ResponseCodeExecutionResultBlock, global::Anthropic.ResponseEncryptedCodeExecutionResultBlock>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.CodeExecutionToolResultError, global::Anthropic.ResponseCodeExecutionResultBlock, global::Anthropic.ResponseEncryptedCodeExecutionResultBlock>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.CodeExecutionToolResultError, global::Anthropic.ResponseCodeExecutionResultBlock, global::Anthropic.ResponseEncryptedCodeExecutionResultBlock>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0342.Create_SourceGenerationContextMetadataType_FBACBCD439563F07(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.CodeExecutionToolResultError, global::Anthropic.ResponseCodeExecutionResultBlock, global::Anthropic.ResponseEncryptedCodeExecutionResultBlock>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0331.Create_SourceGenerationContextMetadataType_CE6683C093B2C260(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }

    }
}