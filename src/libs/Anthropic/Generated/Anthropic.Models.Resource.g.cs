#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// What the permission applies to.<br/>
    /// A tagged union: `type` names the kind of resource and determines which<br/>
    /// identifier fields are present.
    /// </summary>
    public readonly partial struct Resource : global::System.IEquatable<Resource>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRbacRolePermissionResourceDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaOrganizationPermissionResource? Organization { get; init; }
#else
        public global::Anthropic.BetaOrganizationPermissionResource? Organization { get; }
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
            out global::Anthropic.BetaOrganizationPermissionResource? value)
        {
            value = Organization;
            return IsOrganization;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaOrganizationPermissionResource PickOrganization() => IsOrganization
            ? Organization!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Organization' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaConnectorToolPermissionResource? ConnectorTool { get; init; }
#else
        public global::Anthropic.BetaConnectorToolPermissionResource? ConnectorTool { get; }
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
            out global::Anthropic.BetaConnectorToolPermissionResource? value)
        {
            value = ConnectorTool;
            return IsConnectorTool;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConnectorToolPermissionResource PickConnectorTool() => IsConnectorTool
            ? ConnectorTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConnectorTool' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaConnectorScopePermissionResource? ConnectorScope { get; init; }
#else
        public global::Anthropic.BetaConnectorScopePermissionResource? ConnectorScope { get; }
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
            out global::Anthropic.BetaConnectorScopePermissionResource? value)
        {
            value = ConnectorScope;
            return IsConnectorScope;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConnectorScopePermissionResource PickConnectorScope() => IsConnectorScope
            ? ConnectorScope!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ConnectorScope' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaConnectorPermissionResource? Connector { get; init; }
#else
        public global::Anthropic.BetaConnectorPermissionResource? Connector { get; }
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
            out global::Anthropic.BetaConnectorPermissionResource? value)
        {
            value = Connector;
            return IsConnector;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaConnectorPermissionResource PickConnector() => IsConnector
            ? Connector!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Connector' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaAllConnectorsPermissionResource? AllConnectors { get; init; }
#else
        public global::Anthropic.BetaAllConnectorsPermissionResource? AllConnectors { get; }
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
            out global::Anthropic.BetaAllConnectorsPermissionResource? value)
        {
            value = AllConnectors;
            return IsAllConnectors;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAllConnectorsPermissionResource PickAllConnectors() => IsAllConnectors
            ? AllConnectors!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AllConnectors' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Resource(global::Anthropic.BetaOrganizationPermissionResource value) => new Resource((global::Anthropic.BetaOrganizationPermissionResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaOrganizationPermissionResource?(Resource @this) => @this.Organization;

        /// <summary>
        ///
        /// </summary>
        public Resource(global::Anthropic.BetaOrganizationPermissionResource? value)
        {
            Organization = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Resource FromOrganization(global::Anthropic.BetaOrganizationPermissionResource? value) => new Resource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Resource(global::Anthropic.BetaConnectorToolPermissionResource value) => new Resource((global::Anthropic.BetaConnectorToolPermissionResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaConnectorToolPermissionResource?(Resource @this) => @this.ConnectorTool;

        /// <summary>
        ///
        /// </summary>
        public Resource(global::Anthropic.BetaConnectorToolPermissionResource? value)
        {
            ConnectorTool = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Resource FromConnectorTool(global::Anthropic.BetaConnectorToolPermissionResource? value) => new Resource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Resource(global::Anthropic.BetaConnectorScopePermissionResource value) => new Resource((global::Anthropic.BetaConnectorScopePermissionResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaConnectorScopePermissionResource?(Resource @this) => @this.ConnectorScope;

        /// <summary>
        ///
        /// </summary>
        public Resource(global::Anthropic.BetaConnectorScopePermissionResource? value)
        {
            ConnectorScope = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Resource FromConnectorScope(global::Anthropic.BetaConnectorScopePermissionResource? value) => new Resource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Resource(global::Anthropic.BetaConnectorPermissionResource value) => new Resource((global::Anthropic.BetaConnectorPermissionResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaConnectorPermissionResource?(Resource @this) => @this.Connector;

        /// <summary>
        ///
        /// </summary>
        public Resource(global::Anthropic.BetaConnectorPermissionResource? value)
        {
            Connector = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Resource FromConnector(global::Anthropic.BetaConnectorPermissionResource? value) => new Resource(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Resource(global::Anthropic.BetaAllConnectorsPermissionResource value) => new Resource((global::Anthropic.BetaAllConnectorsPermissionResource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaAllConnectorsPermissionResource?(Resource @this) => @this.AllConnectors;

        /// <summary>
        ///
        /// </summary>
        public Resource(global::Anthropic.BetaAllConnectorsPermissionResource? value)
        {
            AllConnectors = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Resource FromAllConnectors(global::Anthropic.BetaAllConnectorsPermissionResource? value) => new Resource(value);

        /// <summary>
        ///
        /// </summary>
        public Resource(
            global::Anthropic.BetaRbacRolePermissionResourceDiscriminatorType? type,
            global::Anthropic.BetaOrganizationPermissionResource? organization,
            global::Anthropic.BetaConnectorToolPermissionResource? connectorTool,
            global::Anthropic.BetaConnectorScopePermissionResource? connectorScope,
            global::Anthropic.BetaConnectorPermissionResource? connector,
            global::Anthropic.BetaAllConnectorsPermissionResource? allConnectors
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
            global::System.Func<global::Anthropic.BetaOrganizationPermissionResource, TResult>? organization = null,
            global::System.Func<global::Anthropic.BetaConnectorToolPermissionResource, TResult>? connectorTool = null,
            global::System.Func<global::Anthropic.BetaConnectorScopePermissionResource, TResult>? connectorScope = null,
            global::System.Func<global::Anthropic.BetaConnectorPermissionResource, TResult>? connector = null,
            global::System.Func<global::Anthropic.BetaAllConnectorsPermissionResource, TResult>? allConnectors = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrganization && organization != null)
            {
                return organization(Organization!);
            }
            else if (IsConnectorTool && connectorTool != null)
            {
                return connectorTool(ConnectorTool!);
            }
            else if (IsConnectorScope && connectorScope != null)
            {
                return connectorScope(ConnectorScope!);
            }
            else if (IsConnector && connector != null)
            {
                return connector(Connector!);
            }
            else if (IsAllConnectors && allConnectors != null)
            {
                return allConnectors(AllConnectors!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaOrganizationPermissionResource>? organization = null,

            global::System.Action<global::Anthropic.BetaConnectorToolPermissionResource>? connectorTool = null,

            global::System.Action<global::Anthropic.BetaConnectorScopePermissionResource>? connectorScope = null,

            global::System.Action<global::Anthropic.BetaConnectorPermissionResource>? connector = null,

            global::System.Action<global::Anthropic.BetaAllConnectorsPermissionResource>? allConnectors = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrganization)
            {
                organization?.Invoke(Organization!);
            }
            else if (IsConnectorTool)
            {
                connectorTool?.Invoke(ConnectorTool!);
            }
            else if (IsConnectorScope)
            {
                connectorScope?.Invoke(ConnectorScope!);
            }
            else if (IsConnector)
            {
                connector?.Invoke(Connector!);
            }
            else if (IsAllConnectors)
            {
                allConnectors?.Invoke(AllConnectors!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaOrganizationPermissionResource>? organization = null,
            global::System.Action<global::Anthropic.BetaConnectorToolPermissionResource>? connectorTool = null,
            global::System.Action<global::Anthropic.BetaConnectorScopePermissionResource>? connectorScope = null,
            global::System.Action<global::Anthropic.BetaConnectorPermissionResource>? connector = null,
            global::System.Action<global::Anthropic.BetaAllConnectorsPermissionResource>? allConnectors = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrganization)
            {
                organization?.Invoke(Organization!);
            }
            else if (IsConnectorTool)
            {
                connectorTool?.Invoke(ConnectorTool!);
            }
            else if (IsConnectorScope)
            {
                connectorScope?.Invoke(ConnectorScope!);
            }
            else if (IsConnector)
            {
                connector?.Invoke(Connector!);
            }
            else if (IsAllConnectors)
            {
                allConnectors?.Invoke(AllConnectors!);
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
                typeof(global::Anthropic.BetaOrganizationPermissionResource),
                ConnectorTool,
                typeof(global::Anthropic.BetaConnectorToolPermissionResource),
                ConnectorScope,
                typeof(global::Anthropic.BetaConnectorScopePermissionResource),
                Connector,
                typeof(global::Anthropic.BetaConnectorPermissionResource),
                AllConnectors,
                typeof(global::Anthropic.BetaAllConnectorsPermissionResource),
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
        public bool Equals(Resource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaOrganizationPermissionResource?>.Default.Equals(Organization, other.Organization) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaConnectorToolPermissionResource?>.Default.Equals(ConnectorTool, other.ConnectorTool) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaConnectorScopePermissionResource?>.Default.Equals(ConnectorScope, other.ConnectorScope) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaConnectorPermissionResource?>.Default.Equals(Connector, other.Connector) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaAllConnectorsPermissionResource?>.Default.Equals(AllConnectors, other.AllConnectors)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Resource obj1, Resource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Resource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Resource obj1, Resource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Resource o && Equals(o);
        }
    }
}
