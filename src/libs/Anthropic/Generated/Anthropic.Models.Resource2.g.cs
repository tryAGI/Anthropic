#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// What the permission applies to.<br/>
    /// A tagged union: `type` names the kind of resource and determines which<br/>
    /// identifier fields are present.
    /// </summary>
    public readonly partial struct Resource2 : global::System.IEquatable<Resource2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RbacRolePermissionResourceDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.OrganizationPermissionResource? Organization { get; init; }
#else
        public global::Anthropic.OrganizationPermissionResource? Organization { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Organization))]
#endif
        public bool IsOrganization => Organization != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOrganization(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.OrganizationPermissionResource? value)
        {
            value = Organization;
            return IsOrganization;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.OrganizationPermissionResource PickOrganization() => Organization is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Organization' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ConnectorToolPermissionResource? ConnectorTool { get; init; }
#else
        public global::Anthropic.ConnectorToolPermissionResource? ConnectorTool { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConnectorTool))]
#endif
        public bool IsConnectorTool => ConnectorTool != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConnectorTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ConnectorToolPermissionResource? value)
        {
            value = ConnectorTool;
            return IsConnectorTool;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConnectorToolPermissionResource PickConnectorTool() => ConnectorTool is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConnectorTool' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ConnectorScopePermissionResource? ConnectorScope { get; init; }
#else
        public global::Anthropic.ConnectorScopePermissionResource? ConnectorScope { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConnectorScope))]
#endif
        public bool IsConnectorScope => ConnectorScope != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConnectorScope(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ConnectorScopePermissionResource? value)
        {
            value = ConnectorScope;
            return IsConnectorScope;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConnectorScopePermissionResource PickConnectorScope() => ConnectorScope is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConnectorScope' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ConnectorPermissionResource? Connector { get; init; }
#else
        public global::Anthropic.ConnectorPermissionResource? Connector { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Connector))]
#endif
        public bool IsConnector => Connector != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickConnector(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ConnectorPermissionResource? value)
        {
            value = Connector;
            return IsConnector;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ConnectorPermissionResource PickConnector() => Connector is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Connector' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.AllConnectorsPermissionResource? AllConnectors { get; init; }
#else
        public global::Anthropic.AllConnectorsPermissionResource? AllConnectors { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AllConnectors))]
#endif
        public bool IsAllConnectors => AllConnectors != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAllConnectors(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.AllConnectorsPermissionResource? value)
        {
            value = AllConnectors;
            return IsAllConnectors;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AllConnectorsPermissionResource PickAllConnectors() => AllConnectors is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AllConnectors' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Resource2(global::Anthropic.OrganizationPermissionResource value) => new Resource2((global::Anthropic.OrganizationPermissionResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.OrganizationPermissionResource?(Resource2 @this) => @this.Organization;

        /// <summary>
        ///
        /// </summary>
        public Resource2(global::Anthropic.OrganizationPermissionResource? value)
        {
            Organization = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Resource2 FromOrganization(global::Anthropic.OrganizationPermissionResource? value) => new Resource2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Resource2(global::Anthropic.ConnectorToolPermissionResource value) => new Resource2((global::Anthropic.ConnectorToolPermissionResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ConnectorToolPermissionResource?(Resource2 @this) => @this.ConnectorTool;

        /// <summary>
        ///
        /// </summary>
        public Resource2(global::Anthropic.ConnectorToolPermissionResource? value)
        {
            ConnectorTool = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Resource2 FromConnectorTool(global::Anthropic.ConnectorToolPermissionResource? value) => new Resource2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Resource2(global::Anthropic.ConnectorScopePermissionResource value) => new Resource2((global::Anthropic.ConnectorScopePermissionResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ConnectorScopePermissionResource?(Resource2 @this) => @this.ConnectorScope;

        /// <summary>
        ///
        /// </summary>
        public Resource2(global::Anthropic.ConnectorScopePermissionResource? value)
        {
            ConnectorScope = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Resource2 FromConnectorScope(global::Anthropic.ConnectorScopePermissionResource? value) => new Resource2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Resource2(global::Anthropic.ConnectorPermissionResource value) => new Resource2((global::Anthropic.ConnectorPermissionResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ConnectorPermissionResource?(Resource2 @this) => @this.Connector;

        /// <summary>
        ///
        /// </summary>
        public Resource2(global::Anthropic.ConnectorPermissionResource? value)
        {
            Connector = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Resource2 FromConnector(global::Anthropic.ConnectorPermissionResource? value) => new Resource2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Resource2(global::Anthropic.AllConnectorsPermissionResource value) => new Resource2((global::Anthropic.AllConnectorsPermissionResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.AllConnectorsPermissionResource?(Resource2 @this) => @this.AllConnectors;

        /// <summary>
        ///
        /// </summary>
        public Resource2(global::Anthropic.AllConnectorsPermissionResource? value)
        {
            AllConnectors = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Resource2 FromAllConnectors(global::Anthropic.AllConnectorsPermissionResource? value) => new Resource2(value);

        /// <summary>
        ///
        /// </summary>
        public Resource2(
            global::Anthropic.RbacRolePermissionResourceDiscriminatorType? type,
            global::Anthropic.OrganizationPermissionResource? organization,
            global::Anthropic.ConnectorToolPermissionResource? connectorTool,
            global::Anthropic.ConnectorScopePermissionResource? connectorScope,
            global::Anthropic.ConnectorPermissionResource? connector,
            global::Anthropic.AllConnectorsPermissionResource? allConnectors
            )
        {
            Type = type;

            Organization = organization;
            ConnectorTool = connectorTool;
            ConnectorScope = connectorScope;
            Connector = connector;
            AllConnectors = allConnectors;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AllConnectors as object ??
            Connector as object ??
            ConnectorScope as object ??
            ConnectorTool as object ??
            Organization as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Organization?.ToString() ??
            ConnectorTool?.ToString() ??
            ConnectorScope?.ToString() ??
            Connector?.ToString() ??
            AllConnectors?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOrganization && !IsConnectorTool && !IsConnectorScope && !IsConnector && !IsAllConnectors || !IsOrganization && IsConnectorTool && !IsConnectorScope && !IsConnector && !IsAllConnectors || !IsOrganization && !IsConnectorTool && IsConnectorScope && !IsConnector && !IsAllConnectors || !IsOrganization && !IsConnectorTool && !IsConnectorScope && IsConnector && !IsAllConnectors || !IsOrganization && !IsConnectorTool && !IsConnectorScope && !IsConnector && IsAllConnectors;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.OrganizationPermissionResource, TResult>? organization = null,
            global::System.Func<global::Anthropic.ConnectorToolPermissionResource, TResult>? connectorTool = null,
            global::System.Func<global::Anthropic.ConnectorScopePermissionResource, TResult>? connectorScope = null,
            global::System.Func<global::Anthropic.ConnectorPermissionResource, TResult>? connector = null,
            global::System.Func<global::Anthropic.AllConnectorsPermissionResource, TResult>? allConnectors = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Organization is { } __value0 && organization != null)
            {
                return organization(__value0);
            }
            else if (ConnectorTool is { } __value1 && connectorTool != null)
            {
                return connectorTool(__value1);
            }
            else if (ConnectorScope is { } __value2 && connectorScope != null)
            {
                return connectorScope(__value2);
            }
            else if (Connector is { } __value3 && connector != null)
            {
                return connector(__value3);
            }
            else if (AllConnectors is { } __value4 && allConnectors != null)
            {
                return allConnectors(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.OrganizationPermissionResource>? organization = null,

            global::System.Action<global::Anthropic.ConnectorToolPermissionResource>? connectorTool = null,

            global::System.Action<global::Anthropic.ConnectorScopePermissionResource>? connectorScope = null,

            global::System.Action<global::Anthropic.ConnectorPermissionResource>? connector = null,

            global::System.Action<global::Anthropic.AllConnectorsPermissionResource>? allConnectors = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Organization is { } __value0)
            {
                organization?.Invoke(__value0);
            }
            else if (ConnectorTool is { } __value1)
            {
                connectorTool?.Invoke(__value1);
            }
            else if (ConnectorScope is { } __value2)
            {
                connectorScope?.Invoke(__value2);
            }
            else if (Connector is { } __value3)
            {
                connector?.Invoke(__value3);
            }
            else if (AllConnectors is { } __value4)
            {
                allConnectors?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.OrganizationPermissionResource>? organization = null,
            global::System.Action<global::Anthropic.ConnectorToolPermissionResource>? connectorTool = null,
            global::System.Action<global::Anthropic.ConnectorScopePermissionResource>? connectorScope = null,
            global::System.Action<global::Anthropic.ConnectorPermissionResource>? connector = null,
            global::System.Action<global::Anthropic.AllConnectorsPermissionResource>? allConnectors = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Organization is { } __value0)
            {
                organization?.Invoke(__value0);
            }
            else if (ConnectorTool is { } __value1)
            {
                connectorTool?.Invoke(__value1);
            }
            else if (ConnectorScope is { } __value2)
            {
                connectorScope?.Invoke(__value2);
            }
            else if (Connector is { } __value3)
            {
                connector?.Invoke(__value3);
            }
            else if (AllConnectors is { } __value4)
            {
                allConnectors?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Organization,
                typeof(global::Anthropic.OrganizationPermissionResource),
                ConnectorTool,
                typeof(global::Anthropic.ConnectorToolPermissionResource),
                ConnectorScope,
                typeof(global::Anthropic.ConnectorScopePermissionResource),
                Connector,
                typeof(global::Anthropic.ConnectorPermissionResource),
                AllConnectors,
                typeof(global::Anthropic.AllConnectorsPermissionResource),
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
        public bool Equals(Resource2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.OrganizationPermissionResource?>.Default.Equals(Organization, other.Organization) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ConnectorToolPermissionResource?>.Default.Equals(ConnectorTool, other.ConnectorTool) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ConnectorScopePermissionResource?>.Default.Equals(ConnectorScope, other.ConnectorScope) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ConnectorPermissionResource?>.Default.Equals(Connector, other.Connector) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.AllConnectorsPermissionResource?>.Default.Equals(AllConnectors, other.AllConnectors)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Resource2 obj1, Resource2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Resource2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Resource2 obj1, Resource2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Resource2 o && Equals(o);
        }
    }
}
