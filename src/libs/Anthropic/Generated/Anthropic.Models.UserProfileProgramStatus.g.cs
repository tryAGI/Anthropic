
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A user profile's status in a program. Each program's `status` field says what the values mean there.
    /// </summary>
    public enum UserProfileProgramStatus
    {
        /// <summary>
        /// The profile is in the program.
        /// </summary>
        Active,
        /// <summary>
        /// The profile is not in the program yet, and something is still awaited.
        /// </summary>
        Pending,
        /// <summary>
        /// The profile is not in the program and nothing is awaited: Anthropic has declined, or has withdrawn an earlier approval.
        /// </summary>
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserProfileProgramStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserProfileProgramStatus value)
        {
            return value switch
            {
                UserProfileProgramStatus.Active => "active",
                UserProfileProgramStatus.Pending => "pending",
                UserProfileProgramStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserProfileProgramStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => UserProfileProgramStatus.Active,
                "pending" => UserProfileProgramStatus.Pending,
                "rejected" => UserProfileProgramStatus.Rejected,
                _ => null,
            };
        }
    }
}