// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using PinnacleBets.Json;

namespace PinnacleBets.Models;

public record BettingStatusResponse(
    /// <value>
    /// Betting status.
    /// </value>
    [property: JsonPropertyName("status")]
        BettingStatusResponse.BettingStatusResponseStatus Status
)
{
    /// <summary>
    /// Betting status.
    /// </summary>
    public record BettingStatusResponseStatus : ValueEnum<string>
    {
        internal BettingStatusResponseStatus(string value)
            : base(value) { }

        public BettingStatusResponseStatus()
            : base("ALL_BETTING_ENABLED") { }

        public static BettingStatusResponseStatus AllBettingEnabled = new("ALL_BETTING_ENABLED");
        public static BettingStatusResponseStatus AllLiveBettingClosed =
            new("ALL_LIVE_BETTING_CLOSED");
        public static BettingStatusResponseStatus AllBettingClosed = new("ALL_BETTING_CLOSED");
    }
}
