
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_8797AC73A857889F
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_0146E770B4C2DDA6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_04C95B565964DBA5.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_152AEAB9EB7D000C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_21414BC0DADC25F0.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_27F40D5C5B75DC45.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2832BD2DDA17B087.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4C104F84FAEDEE99.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_556E7C341F9162F9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7ECE3AE26CDE043B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_849705B502DE74B7.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8A520BE84B563CF1.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8D4C9B3E64A505B2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_95BCD9289EE150A7.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9975ABB6BCDA4021.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9D841D0101067E25.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C05CC72820FF10A9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F2059FBD03F4D190.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FB1B2AF4BFBBD5A0.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.ResponseComputerToolUseBlockUnionJsonConverter>(static () => new global::Anthropic.JsonConverters.ResponseComputerToolUseBlockUnionJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.ResponseComputerToolUseBlockUnion))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0255.Create_ResponseComputerToolUseBlockUnion2(options);
                }
                if (type == typeof(global::Anthropic.ResponseComputerToolUseBlockUnion?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0235.Create_NullableResponseComputerToolUseBlockUnion2(options);
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