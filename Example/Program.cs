// This file was generated by liblab | https://liblab.com/

using PinnacleBets;
using PinnacleBets.Config;
using PinnacleBets.Models;
using Environment = PinnacleBets.Http.Environment;

var basicAuthConfig = new BasicAuthConfig("YOUR_USER_NAME", "YOUR_PASSWORD");

var config = new PinnacleBetsConfig
{
    Environment = Environment.Default,
    BasicAuth = basicAuthConfig
};

var client = new PinnacleBetsClient(config);

var betStatuses = new List<BetStatuses>() { BetStatuses.Won };
var betids = new List<long>() { 9 };
var uniqueRequestIds = new List<string>() { "uniqueRequestIds" };
var betType = new List<BetsGetBetsByTypeV4BetType>() { BetsGetBetsByTypeV4BetType.Spread };

var response = await client.GetBets.BetsGetBetsByTypeV4Async(
    Betlist.Settled,
    betStatuses,
    "fromDate",
    "toDate",
    SortDir.Asc,
    1000,
    0,
    betids,
    uniqueRequestIds,
    betType
);

Console.WriteLine(response);
