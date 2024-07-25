// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using PinnacleBets.Json;

namespace PinnacleBets.Models;

public record SpecialBet(
    /// <value>Bet identification</value>
    [property: JsonPropertyName("betId")]
        long BetId,
    /// <value>Wager identification. All bets placed thru the API will have value 1. Website Classic view supports multiple contest(special) bets placement in the same bet slip in that case the bet would have appropriate wager number, as well as all round robin parlay bets.</value>
    [property: JsonPropertyName("wagerNumber")]
        long WagerNumber,
    /// <value>Date time when the bet was placed.</value>
    [property: JsonPropertyName("placedAt")]
        string PlacedAt,
    /// <value>
    /// Bet Status.
    /// ACCEPTED = Bet was accepted,
    /// CANCELLED = Bet is cancelled as per Pinnacle betting rules,
    /// LOSE = The bet is settled as lose,
    /// REFUNDED = When an event is cancelled or when the bet is settled as push, the bet will have REFUNDED status,
    /// WON = The bet is settled as won
    /// PUSHED = The bet is settled as a push.
    /// </value>
    [property: JsonPropertyName("betStatus")]
        SpecialBet.SpecialBetBetStatus BetStatus,
    [property: JsonPropertyName("betType")] string BetType,
    /// <value>Win amount.</value>
    [property: JsonPropertyName("win")]
        double Win,
    /// <value>Risk amount.</value>
    [property: JsonPropertyName("risk")]
        double Risk,
    /// <value>
    /// Bet odds format.
    /// AMERICAN = American odds format,
    /// DECIMAL = Decimal (European) odds format,
    /// HONGKONG = Hong Kong odds format,
    /// INDONESIAN = Indonesian odds format,
    /// MALAY = Malaysian odds format
    /// </value>
    [property: JsonPropertyName("oddsFormat")]
        OddsFormat OddsFormat,
    /// <value>Update Sequence. It gets updated when the bet status change.</value>
    [property: JsonPropertyName("updateSequence")]
        long UpdateSequence,
    [property: JsonPropertyName("specialId")] long SpecialId,
    [property: JsonPropertyName("specialName")] string SpecialName,
    [property: JsonPropertyName("contestantId")] long ContestantId,
    [property: JsonPropertyName("contestantName")] string ContestantName,
    [property: JsonPropertyName("price")] double Price,
    [property: JsonPropertyName("sportId")] long SportId,
    [property: JsonPropertyName("leagueId")] long LeagueId,
    /// <value>Unique Request Id</value>
    [property:
        JsonPropertyName("uniqueRequestId"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? UniqueRequestId = null,
    /// <value>Win-Loss for settled bets.</value>
    [property: JsonPropertyName("winLoss")]
        double? WinLoss = null,
    /// <value>Client’s commission on the bet.</value>
    [property: JsonPropertyName("customerCommission")]
        double? CustomerCommission = null,
    /// <value>
    /// Possible keys \:
    /// * correctTeam1Id
    /// * correctTeam2Id
    /// * correctListedPitcher1
    /// * correctListedPitcher2
    /// * correctSpread
    /// * correctTotalPoints
    /// * correctTeam1TotalPoints
    /// * correctTeam2TotalPoints
    /// * correctTeam1Score
    /// * correctTeam2Score
    /// * correctTeam1TennisSetsScore
    /// * correctTeam2TennisSetsScore
    /// </value>
    [property:
        JsonPropertyName("cancellationReason"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        CancellationReason? CancellationReason = null,
    [property:
        JsonPropertyName("handicap"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        double? Handicap = null,
    [property:
        JsonPropertyName("units"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Units = null,
    /// <value>Populated if bet was placed on a special linked to the event.</value>
    [property: JsonPropertyName("eventId")]
        long? EventId = null,
    /// <value>Populated if bet was placed on a special linked to the event.</value>
    [property: JsonPropertyName("periodNumber")]
        long? PeriodNumber = null,
    /// <value>Populated if bet was placed on a special linked to the event.</value>
    [property: JsonPropertyName("team1")]
        string? Team1 = null,
    /// <value>Populated if bet was placed on a special linked to the event.</value>
    [property: JsonPropertyName("team2")]
        string? Team2 = null,
    /// <value>Date time when the event starts</value>
    [property:
        JsonPropertyName("eventStartTime"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? EventStartTime = null
)
{
    /// <summary>
    /// Bet Status.
    /// ACCEPTED = Bet was accepted,
    /// CANCELLED = Bet is cancelled as per Pinnacle betting rules,
    /// LOSE = The bet is settled as lose,
    /// REFUNDED = When an event is cancelled or when the bet is settled as push, the bet will have REFUNDED status,
    /// WON = The bet is settled as won
    /// PUSHED = The bet is settled as a push.
    /// </summary>
    public record SpecialBetBetStatus : ValueEnum<string>
    {
        internal SpecialBetBetStatus(string value)
            : base(value) { }

        public SpecialBetBetStatus()
            : base("ACCEPTED") { }

        public static SpecialBetBetStatus Accepted = new("ACCEPTED");
        public static SpecialBetBetStatus Cancelled = new("CANCELLED");
        public static SpecialBetBetStatus Lose = new("LOSE");
        public static SpecialBetBetStatus Refunded = new("REFUNDED");
        public static SpecialBetBetStatus Won = new("WON");
    }
}
