
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum InviteStatusSchema
    {
        /// <summary>
        ///
        /// </summary>
        Accepted,
        /// <summary>
        ///
        /// </summary>
        Deleted,
        /// <summary>
        ///
        /// </summary>
        Expired,
        /// <summary>
        ///
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InviteStatusSchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InviteStatusSchema value)
        {
            return value switch
            {
                InviteStatusSchema.Accepted => "accepted",
                InviteStatusSchema.Deleted => "deleted",
                InviteStatusSchema.Expired => "expired",
                InviteStatusSchema.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InviteStatusSchema? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => InviteStatusSchema.Accepted,
                "deleted" => InviteStatusSchema.Deleted,
                "expired" => InviteStatusSchema.Expired,
                "pending" => InviteStatusSchema.Pending,
                _ => null,
            };
        }
    }
}