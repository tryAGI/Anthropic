#nullable enable

namespace Anthropic
{
    public sealed partial class BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponse2
    {
        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerContext.Options.GetTypeInfo(this.GetType()));
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the generated default JsonSerializerContext.
        /// </summary>
        public string ToJson()
        {
            return ToJson(global::Anthropic.SourceGenerationContextComponent_E6215E5582074E1F.Default);
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
            if (jsonSerializerOptions is null)
            {
                return ToJson(global::Anthropic.SourceGenerationContextComponent_E6215E5582074E1F.Default);
            }

            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponse2? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                jsonSerializerContext.Options.GetTypeInfo(typeof(global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponse2))) as global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponse2;
        }

        /// <summary>
        /// Deserializes a JSON string using the generated default JsonSerializerContext.
        /// </summary>
        public static global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponse2? FromJson(
            string json)
        {
            return FromJson(
                json,
                global::Anthropic.SourceGenerationContextComponent_E6215E5582074E1F.Default);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponse2? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            if (jsonSerializerOptions is null)
            {
                return FromJson(
                    json,
                    global::Anthropic.SourceGenerationContextComponent_E6215E5582074E1F.Default);
            }

            return global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponse2>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponse2?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                jsonSerializerContext.Options.GetTypeInfo(typeof(global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponse2))).ConfigureAwait(false)) as global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponse2;
        }

        /// <summary>
        /// Deserializes a JSON stream using the generated default JsonSerializerContext.
        /// </summary>
        public static global::System.Threading.Tasks.ValueTask<global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponse2?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream)
        {
            return FromJsonStreamAsync(
                jsonStream,
                global::Anthropic.SourceGenerationContextComponent_E6215E5582074E1F.Default);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponse2?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            if (jsonSerializerOptions is null)
            {
                return FromJsonStreamAsync(
                    jsonStream,
                    global::Anthropic.SourceGenerationContextComponent_E6215E5582074E1F.Default);
            }

            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::Anthropic.BetaValidatePluginMarketplaceArchiveV1OrganizationsPluginMarketplacesValidateArchivePostResponse2?>(
                jsonStream,
                jsonSerializerOptions);
        }
    }
}
