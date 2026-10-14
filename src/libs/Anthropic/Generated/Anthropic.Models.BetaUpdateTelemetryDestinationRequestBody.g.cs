
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaUpdateTelemetryDestinationRequestBody
    {
        /// <summary>
        /// New human-readable name, 1 to 255 characters. Null clears it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The new base URL of the destination's OTLP/HTTP endpoint. The same rules as on create apply.<br/>
        /// A change of hostname or port first removes every registered header, so send the headers for the new endpoint in the same request. When the destination has a `traces.endpoint_url`, such a change must also set `traces.endpoint_url` to a URL with the new hostname and port, or to `null`. A change of the path alone keeps the headers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_url")]
        public string? EndpointUrl { get; set; }

        /// <summary>
        /// Headers to set or remove. The API merges them into the destination's headers by name.<br/>
        /// Names compare case-insensitively. A string value sets or replaces that header. A `null` value removes it. Headers that you omit don't change. The field itself can't be `null`.<br/>
        /// A request that sets a header value must also include `endpoint_url`. The current URL is accepted.<br/>
        /// The resulting set must stay within the same limits as on create. When the request sets a value, each stored value that it doesn't set counts as 4,096 bytes toward the 16,384-byte limit, because you can't read its real length. So to change one header of a destination that has four or more other headers, send the values of the others again in the same request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// The traces settings to change. Omitted settings keep their stored values.<br/>
        /// `null` sets every traces setting to its create default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traces")]
        public global::Anthropic.BetaTelemetryDestinationTracesParams? Traces { get; set; }

        /// <summary>
        /// Whether the destination receives deliveries after the update. The field can't be `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaTelemetryDestinationStateParamsJsonConverter))]
        public global::Anthropic.BetaTelemetryDestinationStateParams? State { get; set; }

        /// <summary>
        /// The new workspace scope, in the same form as on create. The field can't be `null`.<br/>
        /// The API refuses an update that changes the type or sends `workspace_ids` while the destination's list has more than 750 workspaces. Remove workspaces one at a time until 750 or fewer remain, then send the update again.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaces")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaTelemetryDestinationWorkspacesParamsJsonConverter))]
        public global::Anthropic.BetaTelemetryDestinationWorkspacesParams? Workspaces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUpdateTelemetryDestinationRequestBody" /> class.
        /// </summary>
        /// <param name="displayName">
        /// New human-readable name, 1 to 255 characters. Null clears it.
        /// </param>
        /// <param name="endpointUrl">
        /// The new base URL of the destination's OTLP/HTTP endpoint. The same rules as on create apply.<br/>
        /// A change of hostname or port first removes every registered header, so send the headers for the new endpoint in the same request. When the destination has a `traces.endpoint_url`, such a change must also set `traces.endpoint_url` to a URL with the new hostname and port, or to `null`. A change of the path alone keeps the headers.
        /// </param>
        /// <param name="headers">
        /// Headers to set or remove. The API merges them into the destination's headers by name.<br/>
        /// Names compare case-insensitively. A string value sets or replaces that header. A `null` value removes it. Headers that you omit don't change. The field itself can't be `null`.<br/>
        /// A request that sets a header value must also include `endpoint_url`. The current URL is accepted.<br/>
        /// The resulting set must stay within the same limits as on create. When the request sets a value, each stored value that it doesn't set counts as 4,096 bytes toward the 16,384-byte limit, because you can't read its real length. So to change one header of a destination that has four or more other headers, send the values of the others again in the same request.
        /// </param>
        /// <param name="traces">
        /// The traces settings to change. Omitted settings keep their stored values.<br/>
        /// `null` sets every traces setting to its create default.
        /// </param>
        /// <param name="state">
        /// Whether the destination receives deliveries after the update. The field can't be `null`.
        /// </param>
        /// <param name="workspaces">
        /// The new workspace scope, in the same form as on create. The field can't be `null`.<br/>
        /// The API refuses an update that changes the type or sends `workspace_ids` while the destination's list has more than 750 workspaces. Remove workspaces one at a time until 750 or fewer remain, then send the update again.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUpdateTelemetryDestinationRequestBody(
            string? displayName,
            string? endpointUrl,
            object? headers,
            global::Anthropic.BetaTelemetryDestinationTracesParams? traces,
            global::Anthropic.BetaTelemetryDestinationStateParams? state,
            global::Anthropic.BetaTelemetryDestinationWorkspacesParams? workspaces)
        {
            this.DisplayName = displayName;
            this.EndpointUrl = endpointUrl;
            this.Headers = headers;
            this.Traces = traces;
            this.State = state;
            this.Workspaces = workspaces;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUpdateTelemetryDestinationRequestBody" /> class.
        /// </summary>
        public BetaUpdateTelemetryDestinationRequestBody()
        {
        }

    }
}