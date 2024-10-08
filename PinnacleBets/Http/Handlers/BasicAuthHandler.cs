// This file was generated by liblab | https://liblab.com/

using System.Text;

namespace PinnacleBets.Http.Handlers;

/// <summary>
/// A handler for adding basic authentication to the request.
/// </summary>
public class BasicAuthHandler : DelegatingHandler
{
    private string? _token;

    public BasicAuthHandler(HttpMessageHandler? innerHandler = null)
        : base(innerHandler ?? new HttpClientHandler()) { }

    protected override Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken
    )
    {
        if (_token is not null)
        {
            request.Headers.Add("Authorization", $"Basic {_token}");
        }

        return base.SendAsync(request, cancellationToken);
    }

    public void SetBasicAuthToken(string userName, string password)
    {
        _token = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{userName}:{password}"));
    }
}
