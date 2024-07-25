// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using PinnacleBets.Json;

namespace PinnacleBets.Models;

public record ParlayLegRequest(
    /// <value>Unique id of the leg. It's used to identify and match legs in the response.</value>
    [property:
        JsonPropertyName("uniqueLegId"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? UniqueLegId = null,
    /// <value>Line identification.</value>
    [property:
        JsonPropertyName("lineId"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? LineId = null,
    /// <value>Alternate line identification.</value>
    [property: JsonPropertyName("altLineId")]
        long? AltLineId = null,
    /// <value>Sport identification.</value>
    [property:
        JsonPropertyName("sportId"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? SportId = null,
    /// <value>Event identification.</value>
    [property:
        JsonPropertyName("eventId"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? EventId = null,
    /// <value>This represents the period of the match. For example, for soccer we have: 0 -  Game, 1 - 1st Half and 2 - 2nd Half</value>
    [property:
        JsonPropertyName("periodNumber"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? PeriodNumber = null,
    /// <value>Only SPREAD, MONEYLINE and TOTAL_POINTS are supported.</value>
    [property:
        JsonPropertyName("legBetType"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ParlayLegRequest.ParlayLegRequestLegBetType? LegBetType = null,
    /// <value>Chosen team type. This is needed only for SPREAD and MONEYLINE bet types.</value>
    [property:
        JsonPropertyName("team"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Team = null,
    /// <value>Chosen side type. This is needed only for TOTAL_POINTS bet type.</value>
    [property: JsonPropertyName("side")]
        ParlayLegRequest.ParlayLegRequestSide? Side = null
)
{
    /// <summary>Only SPREAD, MONEYLINE and TOTAL_POINTS are supported.</summary>
    public record ParlayLegRequestLegBetType : ValueEnum<string>
    {
        internal ParlayLegRequestLegBetType(string value)
            : base(value) { }

        public ParlayLegRequestLegBetType()
            : base("MONEYLINE") { }

        public static ParlayLegRequestLegBetType Moneyline = new("MONEYLINE");
        public static ParlayLegRequestLegBetType Spread = new("SPREAD");
        public static ParlayLegRequestLegBetType TotalPoints = new("TOTAL_POINTS");
    }

    /// <summary>Chosen side type. This is needed only for TOTAL_POINTS bet type.</summary>
    public record ParlayLegRequestSide : ValueEnum<string>
    {
        internal ParlayLegRequestSide(string value)
            : base(value) { }

        public ParlayLegRequestSide()
            : base("OVER") { }

        public static ParlayLegRequestSide Over = new("OVER");
        public static ParlayLegRequestSide Under = new("UNDER");
    }
}
