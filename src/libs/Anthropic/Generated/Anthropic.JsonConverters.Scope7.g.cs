#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class Scope7JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Scope7>
    {
        /// <inheritdoc />
        public override global::Anthropic.Scope7 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.SpendSummaryScopeDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.SpendSummaryScopeDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.SpendSummaryScopeDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.UserScope? user = default;
            if (discriminator?.Type == global::Anthropic.SpendSummaryScopeDiscriminatorType.User)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.UserScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.UserScope> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.UserScope)}");
                user = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.SeatTierScope? seatTier = default;
            if (discriminator?.Type == global::Anthropic.SpendSummaryScopeDiscriminatorType.SeatTier)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.SeatTierScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.SeatTierScope> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.SeatTierScope)}");
                seatTier = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.RbacGroupScope? rbacGroup = default;
            if (discriminator?.Type == global::Anthropic.SpendSummaryScopeDiscriminatorType.RbacGroup)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RbacGroupScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RbacGroupScope> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RbacGroupScope)}");
                rbacGroup = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.OrgServiceScope? organizationService = default;
            if (discriminator?.Type == global::Anthropic.SpendSummaryScopeDiscriminatorType.OrganizationService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.OrgServiceScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.OrgServiceScope> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.OrgServiceScope)}");
                organizationService = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.OrganizationScope? organization = default;
            if (discriminator?.Type == global::Anthropic.SpendSummaryScopeDiscriminatorType.Organization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.OrganizationScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.OrganizationScope> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.OrganizationScope)}");
                organization = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.WorkspaceScope? workspace = default;
            if (discriminator?.Type == global::Anthropic.SpendSummaryScopeDiscriminatorType.Workspace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.WorkspaceScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.WorkspaceScope> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.WorkspaceScope)}");
                workspace = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.UsageTierScope? usageTier = default;
            if (discriminator?.Type == global::Anthropic.SpendSummaryScopeDiscriminatorType.UsageTier)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.UsageTierScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.UsageTierScope> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.UsageTierScope)}");
                usageTier = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.Scope7(
                discriminator?.Type,
                user,

                seatTier,

                rbacGroup,

                organizationService,

                organization,

                workspace,

                usageTier
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Scope7 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.UserScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.UserScope?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.UserScope).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUser(), typeInfo);
            }
            else if (value.IsSeatTier)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.SeatTierScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.SeatTierScope?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.SeatTierScope).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSeatTier(), typeInfo);
            }
            else if (value.IsRbacGroup)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RbacGroupScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RbacGroupScope?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RbacGroupScope).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRbacGroup(), typeInfo);
            }
            else if (value.IsOrganizationService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.OrgServiceScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.OrgServiceScope?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.OrgServiceScope).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOrganizationService(), typeInfo);
            }
            else if (value.IsOrganization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.OrganizationScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.OrganizationScope?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.OrganizationScope).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOrganization(), typeInfo);
            }
            else if (value.IsWorkspace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.WorkspaceScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.WorkspaceScope?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.WorkspaceScope).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWorkspace(), typeInfo);
            }
            else if (value.IsUsageTier)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.UsageTierScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.UsageTierScope?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.UsageTierScope).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUsageTier(), typeInfo);
            }
        }
    }
}