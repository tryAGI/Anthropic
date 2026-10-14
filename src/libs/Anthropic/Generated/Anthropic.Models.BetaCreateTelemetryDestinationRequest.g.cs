
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The settings of a new telemetry destination for the organization.
    /// </summary>
    public sealed partial class BetaCreateTelemetryDestinationRequest
    {
        /// <summary>
        /// Human-readable name for the destination. Optional. 1 to 255 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The base URL of your collector's OTLP/HTTP endpoint, for example `https://gateway.example.com`.<br/>
        /// The URL must use `https` and a hostname, not an IP address. The port, if given, must be 443. The URL must not contain a query string, a fragment, or a username and password. At most 2,048 characters.<br/>
        /// A path prefix, such as `/otlp`, is allowed. Don't include the per-signal path (`/v1/traces`), because the API appends it on delivery. If your collector takes traces on another path, also set `traces.endpoint_url`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointUrl { get; set; }

        /// <summary>
        /// Request headers that the API sends with every delivery, typically your collector's authentication header (for example `authorization`).<br/>
        /// The API stores the values encrypted and never returns them. Reads show only `header_names`.<br/>
        /// At most 20 headers. Names are at most 128 characters. Two names can't differ only in case. Values are printable ASCII, at most 4,096 characters, and can't begin or end with a space. Names and values together are at most 16,384 bytes.<br/>
        /// Reserved names are rejected, for example `host`, `cookie`, `user-agent`, and names that start with `content-`, `proxy-`, `x-forwarded-`, or `anthropic-`. For this check, `_` in a name counts as `-`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// The settings for the traces that the destination receives. If you leave it out, every setting takes its default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traces")]
        public global::Anthropic.BetaTelemetryDestinationTracesParams? Traces { get; set; }

        /// <summary>
        /// Which of the organization's workspaces the destination covers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaces")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaTelemetryDestinationWorkspacesParamsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaTelemetryDestinationWorkspacesParams Workspaces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateTelemetryDestinationRequest" /> class.
        /// </summary>
        /// <param name="endpointUrl">
        /// The base URL of your collector's OTLP/HTTP endpoint, for example `https://gateway.example.com`.<br/>
        /// The URL must use `https` and a hostname, not an IP address. The port, if given, must be 443. The URL must not contain a query string, a fragment, or a username and password. At most 2,048 characters.<br/>
        /// A path prefix, such as `/otlp`, is allowed. Don't include the per-signal path (`/v1/traces`), because the API appends it on delivery. If your collector takes traces on another path, also set `traces.endpoint_url`.
        /// </param>
        /// <param name="workspaces">
        /// Which of the organization's workspaces the destination covers.
        /// </param>
        /// <param name="displayName">
        /// Human-readable name for the destination. Optional. 1 to 255 characters.
        /// </param>
        /// <param name="headers">
        /// Request headers that the API sends with every delivery, typically your collector's authentication header (for example `authorization`).<br/>
        /// The API stores the values encrypted and never returns them. Reads show only `header_names`.<br/>
        /// At most 20 headers. Names are at most 128 characters. Two names can't differ only in case. Values are printable ASCII, at most 4,096 characters, and can't begin or end with a space. Names and values together are at most 16,384 bytes.<br/>
        /// Reserved names are rejected, for example `host`, `cookie`, `user-agent`, and names that start with `content-`, `proxy-`, `x-forwarded-`, or `anthropic-`. For this check, `_` in a name counts as `-`.
        /// </param>
        /// <param name="traces">
        /// The settings for the traces that the destination receives. If you leave it out, every setting takes its default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCreateTelemetryDestinationRequest(
            string endpointUrl,
            global::Anthropic.BetaTelemetryDestinationWorkspacesParams workspaces,
            string? displayName,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::Anthropic.BetaTelemetryDestinationTracesParams? traces)
        {
            this.DisplayName = displayName;
            this.EndpointUrl = endpointUrl ?? throw new global::System.ArgumentNullException(nameof(endpointUrl));
            this.Headers = headers;
            this.Traces = traces;
            this.Workspaces = workspaces;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateTelemetryDestinationRequest" /> class.
        /// </summary>
        public BetaCreateTelemetryDestinationRequest()
        {
        }

    }
}