
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The next step on this enforcement action: `verify` means the end user can clear the action by passing an identity check. More values may be added; read a value you do not recognize as `null`.
    /// </summary>
    public enum UserProfileEnforcementActionNextStep
    {
        /// <summary>
        /// `verify` means the end user can clear the action by passing an identity check. More values may be added; read a value you do not recognize as `null`.
        /// </summary>
        Verify,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserProfileEnforcementActionNextStepExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserProfileEnforcementActionNextStep value)
        {
            return value switch
            {
                UserProfileEnforcementActionNextStep.Verify => "verify",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserProfileEnforcementActionNextStep? ToEnum(string value)
        {
            return value switch
            {
                "verify" => UserProfileEnforcementActionNextStep.Verify,
                _ => null,
            };
        }
    }
}