
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Anthropic's enforcement status of this profile: `unrestricted`, `pending`, `restricted` or `banned`. More values may be added; read a value you do not recognize as `restricted`.
    /// </summary>
    public enum UserProfileEnforcementStatus
    {
        /// <summary>
        /// `unrestricted`, `pending`, `restricted` or `banned`. More values may be added; read a value you do not recognize as `restricted`.
        /// </summary>
        Banned,
        /// <summary>
        /// `unrestricted`, `pending`, `restricted` or `banned`. More values may be added; read a value you do not recognize as `restricted`.
        /// </summary>
        Pending,
        /// <summary>
        /// `unrestricted`, `pending`, `restricted` or `banned`. More values may be added; read a value you do not recognize as `restricted`.
        /// </summary>
        Restricted,
        /// <summary>
        /// `unrestricted`, `pending`, `restricted` or `banned`. More values may be added; read a value you do not recognize as `restricted`.
        /// </summary>
        Unrestricted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserProfileEnforcementStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserProfileEnforcementStatus value)
        {
            return value switch
            {
                UserProfileEnforcementStatus.Banned => "banned",
                UserProfileEnforcementStatus.Pending => "pending",
                UserProfileEnforcementStatus.Restricted => "restricted",
                UserProfileEnforcementStatus.Unrestricted => "unrestricted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserProfileEnforcementStatus? ToEnum(string value)
        {
            return value switch
            {
                "banned" => UserProfileEnforcementStatus.Banned,
                "pending" => UserProfileEnforcementStatus.Pending,
                "restricted" => UserProfileEnforcementStatus.Restricted,
                "unrestricted" => UserProfileEnforcementStatus.Unrestricted,
                _ => null,
            };
        }
    }
}