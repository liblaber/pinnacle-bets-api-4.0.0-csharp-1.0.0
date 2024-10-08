// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using PinnacleBets.Json;

namespace PinnacleBets.Models;

public record SpecialBetRequest(
    /// <value>This unique id of the place bet requests. This is to support idempotent requests.</value>
    [property:
        JsonPropertyName("uniqueRequestId"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? UniqueRequestId = null,
    /// <value>Whether or not to accept a bet when there is a line change in favor of the client.</value>
    [property:
        JsonPropertyName("acceptBetterLine"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? AcceptBetterLine = null,
    /// <value>
    /// Bet odds format.
    /// AMERICAN = American odds format,
    /// DECIMAL = Decimal (European) odds format,
    /// HONGKONG = Hong Kong odds format,
    /// INDONESIAN = Indonesian odds format,
    /// MALAY = Malaysian odds format
    /// </value>
    [property:
        JsonPropertyName("oddsFormat"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        OddsFormat? OddsFormat = null,
    /// <value>amount in client’s currency.</value>
    [property:
        JsonPropertyName("stake"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        double? Stake = null,
    /// <value>Whether the stake amount is risk or win amount.</value>
    [property:
        JsonPropertyName("winRiskStake"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        SpecialBetRequest.SpecialBetRequestWinRiskStake? WinRiskStake = null,
    /// <value>Line identification.</value>
    [property:
        JsonPropertyName("lineId"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? LineId = null,
    /// <value>Special identification.</value>
    [property:
        JsonPropertyName("specialId"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? SpecialId = null,
    /// <value>Contestant identification.</value>
    [property:
        JsonPropertyName("contestantId"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? ContestantId = null
)
{
    /// <summary>Whether the stake amount is risk or win amount.</summary>
    public record SpecialBetRequestWinRiskStake : ValueEnum<string>
    {
        internal SpecialBetRequestWinRiskStake(string value)
            : base(value) { }

        public SpecialBetRequestWinRiskStake()
            : base("WIN") { }

        public static SpecialBetRequestWinRiskStake Win = new("WIN");
        public static SpecialBetRequestWinRiskStake Risk = new("RISK");
    }
}
