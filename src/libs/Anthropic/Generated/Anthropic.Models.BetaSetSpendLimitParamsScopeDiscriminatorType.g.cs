
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaSetSpendLimitParamsScopeDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        User,
        /// <summary>
        ///
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaSetSpendLimitParamsScopeDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSetSpendLimitParamsScopeDiscriminatorType value)
        {
            return value switch
            {
                BetaSetSpendLimitParamsScopeDiscriminatorType.Organization => "organization",
                BetaSetSpendLimitParamsScopeDiscriminatorType.User => "user",
                BetaSetSpendLimitParamsScopeDiscriminatorType.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSetSpendLimitParamsScopeDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => BetaSetSpendLimitParamsScopeDiscriminatorType.Organization,
                "user" => BetaSetSpendLimitParamsScopeDiscriminatorType.User,
                "workspace" => BetaSetSpendLimitParamsScopeDiscriminatorType.Workspace,
                _ => null,
            };
        }
    }
}