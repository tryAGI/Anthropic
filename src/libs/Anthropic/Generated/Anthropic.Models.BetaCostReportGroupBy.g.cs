
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaCostReportGroupBy
    {
        /// <summary>
        ///
        /// </summary>
        Description,
        /// <summary>
        ///
        /// </summary>
        WorkspaceId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCostReportGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCostReportGroupBy value)
        {
            return value switch
            {
                BetaCostReportGroupBy.Description => "description",
                BetaCostReportGroupBy.WorkspaceId => "workspace_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCostReportGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "description" => BetaCostReportGroupBy.Description,
                "workspace_id" => BetaCostReportGroupBy.WorkspaceId,
                _ => null,
            };
        }
    }
}