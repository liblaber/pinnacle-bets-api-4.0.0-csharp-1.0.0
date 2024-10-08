// This file was generated by liblab | https://liblab.com/

using System.Net.Http.Json;
using PinnacleBets.Http;
using PinnacleBets.Http.Exceptions;
using PinnacleBets.Http.Extensions;
using PinnacleBets.Http.Serialization;
using PinnacleBets.Models;

namespace PinnacleBets.Services;

public class BettingStatusService : BaseService
{
    internal BettingStatusService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Returns current betting status. During maintenance windows betting could be disabled, you can call this operation to check the current betting status.</summary>
    public async Task<BettingStatusResponse> BetsGetBettingStatusAsync(
        CancellationToken cancellationToken = default
    )
    {
        var request = new RequestBuilder(HttpMethod.Get, "v4/bets/betting-status").Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<BettingStatusResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
