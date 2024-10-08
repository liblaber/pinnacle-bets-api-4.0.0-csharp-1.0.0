// This file was generated by liblab | https://liblab.com/

using System.Net.Http.Json;
using PinnacleBets.Http;
using PinnacleBets.Http.Exceptions;
using PinnacleBets.Http.Extensions;
using PinnacleBets.Http.Serialization;
using PinnacleBets.Models;

namespace PinnacleBets.Services;

public class PlaceBetsService : BaseService
{
    internal PlaceBetsService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>
    /// Place straight bet (SPREAD, MONEYLINE, TOTAL_POINTS, TEAM_TOTAL_POINTS).
    ///
    /// Please note when the status is PENDING_ACCEPTANCE and if the live delay was applied, the response will not have betId. Client would have to call /bets by uniqueRequestId to check the status if the bet was ACCEPTED.  For more details please see [How to place a bet on live events?](https://github.com/pinnacleapi/pinnacleapi-documentation/blob/master/FAQ.md#how-to-place-a-bet-on-live-events)
    ///
    /// Make sure you handle properly the case of an unexpected error as per
    ///  [How to handle error on placing a bet?](https://github.com/pinnacleapi/pinnacleapi-documentation/blob/master/FAQ.md#how-to-handle-unexpected-error-on-placing-a-bet)
    /// </summary>
    public async Task<PlaceStraightBetResponse> BetsStraightV2Async(
        PlaceBetRequest input,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        var request = new RequestBuilder(HttpMethod.Post, "v4/bets/straight")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<PlaceStraightBetResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>
    /// Make sure you handle properly the case of an unexpected error as per
    ///  [How to handle error on placing a bet?](https://github.com/pinnacleapi/pinnacleapi-documentation/blob/master/FAQ.md#how-to-handle-unexpected-error-on-placing-a-bet)
    /// </summary>
    /// <param name="input">The Parlay request.</param>
    public async Task<PlaceParlayBetResponse> BetsParlayV2Async(
        PlaceParlayBetRequest input,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        var request = new RequestBuilder(HttpMethod.Post, "v4/bets/parlay")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<PlaceParlayBetResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>
    /// Make sure you handle properly the case of an unexpected error as per
    ///  [How to handle error on placing a bet?](https://github.com/pinnacleapi/pinnacleapi-documentation/blob/master/FAQ.md#how-to-handle-unexpected-error-on-placing-a-bet)
    /// </summary>
    /// <param name="input">The PlaceTeaser request.</param>
    public async Task<PlaceTeaserBetResponse> BetsTeaserAsync(
        PlaceTeaserBetRequest input,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        var request = new RequestBuilder(HttpMethod.Post, "v4/bets/teaser")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<PlaceTeaserBetResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>
    /// Make sure you handle properly the case of an unexpected error as per
    ///  [How to handle error on placing a bet?](https://github.com/pinnacleapi/pinnacleapi-documentation/blob/master/FAQ.md#how-to-handle-unexpected-error-on-placing-a-bet)
    /// </summary>
    /// <param name="input">The SpecialBet request.</param>
    public async Task<MultiBetResponseSpecialBetResponse> BetsSpecialAsync(
        MultiBetRequestSpecialBetRequest input,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        var request = new RequestBuilder(HttpMethod.Post, "v4/bets/special")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<MultiBetResponseSpecialBetResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
