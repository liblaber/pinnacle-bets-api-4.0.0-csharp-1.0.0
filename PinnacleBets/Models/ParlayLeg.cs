// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using PinnacleBets.Json;

namespace PinnacleBets.Models;

public record ParlayLeg(
    [property:
        JsonPropertyName("sportId"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? SportId = null,
    /// <value>Parlay leg type.</value>
    [property:
        JsonPropertyName("legBetType"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ParlayLeg.ParlayLegLegBetType? LegBetType = null,
    /// <value>
    /// Parlay Leg status.
    /// CANCELLED = The leg is canceled- the stake on this leg will be transferred to the next one. In this case the leg will be ignored when calculating the winLoss.
    /// LOST = The leg is a loss or a push-lose. When Push-lose happens, the half of the stake on the leg will be pushed to the next leg, and the other half will be a lose. This can happen only when the leg is placed on a quarter points handicap.
    /// PUSHED = The leg is a push - the stake on this leg will be transferred to the next one. In this case the leg will be ignored when calculating the winLoss.
    /// REFUNDED = The leg is refunded - the stake on this leg will be transferred to the next one. In this case the leg will be ignored when calculating the winLoss.
    /// WON = The leg is a won or a push-won. When Push-won happens, the half of the stake on the leg will be pushed to the next leg, and the other half is won. This can happen only when the leg is placed on a quarter points handicap.
    /// HALF_WON_HALF_PUSHED = The bet is settled as half won half pushed. Only for asian handicap legs.
    /// HALF_LOST_HALF_PUSHED =  The bet is settled as half lost half pushed. Only for asian handicap legs.
    /// </value>
    [property:
        JsonPropertyName("legBetStatus"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ParlayLeg.ParlayLegLegBetStatus? LegBetStatus = null,
    [property:
        JsonPropertyName("leagueId"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? LeagueId = null,
    [property:
        JsonPropertyName("eventId"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? EventId = null,
    /// <value>Date time when the event starts.</value>
    [property:
        JsonPropertyName("eventStartTime"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? EventStartTime = null,
    [property: JsonPropertyName("handicap")] double? Handicap = null,
    [property:
        JsonPropertyName("price"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        double? Price = null,
    [property:
        JsonPropertyName("teamName"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? TeamName = null,
    /// <value>Side type.</value>
    [property: JsonPropertyName("side")]
        ParlayLeg.ParlayLegSide? Side = null,
    /// <value>Wellington Phoenix</value>
    [property:
        JsonPropertyName("team1"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Team1 = null,
    /// <value>Adelaide United</value>
    [property:
        JsonPropertyName("team2"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Team2 = null,
    [property:
        JsonPropertyName("periodNumber"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? PeriodNumber = null,
    /// <value>Full time team 1 score</value>
    [property: JsonPropertyName("ftTeam1Score")]
        double? FtTeam1Score = null,
    /// <value>Full time team 2 score</value>
    [property: JsonPropertyName("ftTeam2Score")]
        double? FtTeam2Score = null,
    /// <value>End of period team 1 score. If the bet was placed on Game period (periodNumber =0) , this will be null</value>
    [property: JsonPropertyName("pTeam1Score")]
        double? PTeam1Score = null,
    /// <value>End of period team 2 score. If the bet was placed on Game period (periodNumber =0) , this will be null</value>
    [property: JsonPropertyName("pTeam2Score")]
        double? PTeam2Score = null,
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
        CancellationReason? CancellationReason = null
)
{
    /// <summary>Parlay leg type.</summary>
    public record ParlayLegLegBetType : ValueEnum<string>
    {
        internal ParlayLegLegBetType(string value)
            : base(value) { }

        public ParlayLegLegBetType()
            : base("MONEYLINE") { }

        public static ParlayLegLegBetType Moneyline = new("MONEYLINE");
        public static ParlayLegLegBetType Spread = new("SPREAD");
        public static ParlayLegLegBetType TotalPoints = new("TOTAL_POINTS");
    }

    /// <summary>
    /// Parlay Leg status.
    /// CANCELLED = The leg is canceled- the stake on this leg will be transferred to the next one. In this case the leg will be ignored when calculating the winLoss.
    /// LOST = The leg is a loss or a push-lose. When Push-lose happens, the half of the stake on the leg will be pushed to the next leg, and the other half will be a lose. This can happen only when the leg is placed on a quarter points handicap.
    /// PUSHED = The leg is a push - the stake on this leg will be transferred to the next one. In this case the leg will be ignored when calculating the winLoss.
    /// REFUNDED = The leg is refunded - the stake on this leg will be transferred to the next one. In this case the leg will be ignored when calculating the winLoss.
    /// WON = The leg is a won or a push-won. When Push-won happens, the half of the stake on the leg will be pushed to the next leg, and the other half is won. This can happen only when the leg is placed on a quarter points handicap.
    /// HALF_WON_HALF_PUSHED = The bet is settled as half won half pushed. Only for asian handicap legs.
    /// HALF_LOST_HALF_PUSHED =  The bet is settled as half lost half pushed. Only for asian handicap legs.
    /// </summary>
    public record ParlayLegLegBetStatus : ValueEnum<string>
    {
        internal ParlayLegLegBetStatus(string value)
            : base(value) { }

        public ParlayLegLegBetStatus()
            : base("CANCELLED") { }

        public static ParlayLegLegBetStatus Cancelled = new("CANCELLED");
        public static ParlayLegLegBetStatus Lost = new("LOST");
        public static ParlayLegLegBetStatus Pushed = new("PUSHED");
        public static ParlayLegLegBetStatus Refunded = new("REFUNDED");
        public static ParlayLegLegBetStatus Won = new("WON");
        public static ParlayLegLegBetStatus Accepted = new("ACCEPTED");
        public static ParlayLegLegBetStatus HalfWonHalfPushed = new("HALF_WON_HALF_PUSHED");
        public static ParlayLegLegBetStatus HalfLostHalfPushed = new("HALF_LOST_HALF_PUSHED");
    }

    /// <summary>Side type.</summary>
    public record ParlayLegSide : ValueEnum<string>
    {
        internal ParlayLegSide(string value)
            : base(value) { }

        public ParlayLegSide()
            : base("OVER") { }

        public static ParlayLegSide Over = new("OVER");
        public static ParlayLegSide Under = new("UNDER");
    }
}
