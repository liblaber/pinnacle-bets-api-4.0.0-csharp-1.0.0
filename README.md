# PinnacleBets C# SDK 1.0.0

Welcome to the PinnacleBets SDK documentation. This guide will help you get started with integrating and using the PinnacleBets SDK in your project.

## Versions

- API version: `4.0.0`
- SDK version: `1.0.0`

## About the API

All about bets, place bets, get your bet history or current bet status. # Authentication Please note that API has restriction that client password can be maximum up 10 characters long. API uses HTTP Basic access authentication. You need to send Authorization HTTP Request header: `Authorization: Basic <Base64 value of UTF-8 encoded  username:password >` Example: `Authorization: Basic U03MyOT23YbzMDc6d3c3O1DQ1`

## Table of Contents

- [Setup & Configuration](#setup--configuration)
  - [Supported Language Versions](#supported-language-versions)
  - [Installation](#installation)
- [Authentication](#authentication)
  - [Basic Authentication](#basic-authentication)
- [Sample Usage](#sample-usage)
- [Services](#services)
- [Models](#models)
- [License](#license)

# Setup & Configuration

## Supported Language Versions

This SDK is compatible with the following versions: `C# >= .NET 6`

## Installation

To get started with the SDK, we recommend installing using `nuget`:

```bash
dotnet add package PinnacleBets
```

## Authentication

### Basic Authentication

The pinnacle_bets API uses Basic Authentication.

You need to provide your username and password when initializing the SDK.

#### Setting the Username and Password

When you initialize the SDK, you can set the username and password as follows:

```cs
using PinnacleBets;
using PinnacleBets.Config;

var config = new PinnacleBetsConfig()
{
	BasicAuth = new BasicAuthConfig("YOUR_USERNAME", "YOUR_PASSWORD")
};

var client = new PinnacleBetsClient(config);
```

If you need to set or update the username and password after initializing the SDK, you can use:

```cs
client.SetBasicAuth("YOUR_USERNAME", "YOUR_PASSWORD")
```

# Sample Usage

Below is a comprehensive example demonstrating how to authenticate and call a simple endpoint:

```cs
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
var betids = new List<long>() { 7 };
var uniqueRequestIds = new List<string>() { "uniqueRequestIds" };
var betType = new List<BetsGetBetsByTypeV4BetType>() { BetsGetBetsByTypeV4BetType.Spread };

var response = await client.GetBets.BetsGetBetsByTypeV4Async(Betlist.Settled, betStatuses, "fromDate", "toDate", SortDir.Asc, 1000, 8, betids, uniqueRequestIds, betType);

Console.WriteLine(response);

```

## Services

The SDK provides various services to interact with the API.

<details> 
<summary>Below is a list of all available services with links to their detailed documentation:</summary>

| Name                                                                   |
| :--------------------------------------------------------------------- |
| [PlaceBetsService](documentation/services/PlaceBetsService.md)         |
| [GetBetsService](documentation/services/GetBetsService.md)             |
| [BettingStatusService](documentation/services/BettingStatusService.md) |

</details>

## Models

The SDK includes several models that represent the data structures used in API requests and responses. These models help in organizing and managing the data efficiently.

<details> 
<summary>Below is a list of all available models with links to their detailed documentation:</summary>

| Name                                                                                             | Description                                                                                                                                                                                                                                                                                     |
| :----------------------------------------------------------------------------------------------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [PlaceBetRequest](documentation/models/PlaceBetRequest.md)                                       | Request to place a bet.                                                                                                                                                                                                                                                                         |
| [PlaceStraightBetResponse](documentation/models/PlaceStraightBetResponse.md)                     |                                                                                                                                                                                                                                                                                                 |
| [PlaceParlayBetRequest](documentation/models/PlaceParlayBetRequest.md)                           | Request to place a bet                                                                                                                                                                                                                                                                          |
| [PlaceParlayBetResponse](documentation/models/PlaceParlayBetResponse.md)                         |                                                                                                                                                                                                                                                                                                 |
| [PlaceTeaserBetRequest](documentation/models/PlaceTeaserBetRequest.md)                           |                                                                                                                                                                                                                                                                                                 |
| [PlaceTeaserBetResponse](documentation/models/PlaceTeaserBetResponse.md)                         |                                                                                                                                                                                                                                                                                                 |
| [MultiBetRequestSpecialBetRequest](documentation/models/MultiBetRequestSpecialBetRequest.md)     |                                                                                                                                                                                                                                                                                                 |
| [MultiBetResponseSpecialBetResponse](documentation/models/MultiBetResponseSpecialBetResponse.md) |                                                                                                                                                                                                                                                                                                 |
| [GetBetsByTypeResponseV4](documentation/models/GetBetsByTypeResponseV4.md)                       |                                                                                                                                                                                                                                                                                                 |
| [Betlist](documentation/models/Betlist.md)                                                       |                                                                                                                                                                                                                                                                                                 |
| [BetStatuses](documentation/models/BetStatuses.md)                                               |                                                                                                                                                                                                                                                                                                 |
| [SortDir](documentation/models/SortDir.md)                                                       |                                                                                                                                                                                                                                                                                                 |
| [BetsGetBetsByTypeV4BetType](documentation/models/BetsGetBetsByTypeV4BetType.md)                 |                                                                                                                                                                                                                                                                                                 |
| [BettingStatusResponse](documentation/models/BettingStatusResponse.md)                           |                                                                                                                                                                                                                                                                                                 |
| [OddsFormat](documentation/models/OddsFormat.md)                                                 | Bet odds format. AMERICAN = American odds format, DECIMAL = Decimal (European) odds format, HONGKONG = Hong Kong odds format, INDONESIAN = Indonesian odds format, MALAY = Malaysian odds format                                                                                                |
| [ParlayLegRequest](documentation/models/ParlayLegRequest.md)                                     |                                                                                                                                                                                                                                                                                                 |
| [RoundRobinOptionWithOdds](documentation/models/RoundRobinOptionWithOdds.md)                     |                                                                                                                                                                                                                                                                                                 |
| [ParlayLegResponse](documentation/models/ParlayLegResponse.md)                                   |                                                                                                                                                                                                                                                                                                 |
| [TeaserBetLeg](documentation/models/TeaserBetLeg.md)                                             |                                                                                                                                                                                                                                                                                                 |
| [PlaceTeaserBetLegResponse](documentation/models/PlaceTeaserBetLegResponse.md)                   |                                                                                                                                                                                                                                                                                                 |
| [SpecialBetRequest](documentation/models/SpecialBetRequest.md)                                   |                                                                                                                                                                                                                                                                                                 |
| [SpecialBetResponse](documentation/models/SpecialBetResponse.md)                                 |                                                                                                                                                                                                                                                                                                 |
| [StraightBetV4](documentation/models/StraightBetV4.md)                                           |                                                                                                                                                                                                                                                                                                 |
| [ParlayBet](documentation/models/ParlayBet.md)                                                   |                                                                                                                                                                                                                                                                                                 |
| [TeaserBet](documentation/models/TeaserBet.md)                                                   |                                                                                                                                                                                                                                                                                                 |
| [SpecialBet](documentation/models/SpecialBet.md)                                                 |                                                                                                                                                                                                                                                                                                 |
| [ManualBet](documentation/models/ManualBet.md)                                                   |                                                                                                                                                                                                                                                                                                 |
| [CancellationReason](documentation/models/CancellationReason.md)                                 | Possible keys \: _ correctTeam1Id _ correctTeam2Id _ correctListedPitcher1 _ correctListedPitcher2 _ correctSpread _ correctTotalPoints _ correctTeam1TotalPoints _ correctTeam2TotalPoints _ correctTeam1Score _ correctTeam2Score _ correctTeam1TennisSetsScore _ correctTeam2TennisSetsScore |
| [CancellationDetailsItem](documentation/models/CancellationDetailsItem.md)                       |                                                                                                                                                                                                                                                                                                 |
| [ParlayLeg](documentation/models/ParlayLeg.md)                                                   |                                                                                                                                                                                                                                                                                                 |
| [TeaserLeg](documentation/models/TeaserLeg.md)                                                   |                                                                                                                                                                                                                                                                                                 |

</details>

## License

This SDK is licensed under the MIT License.

See the [LICENSE](LICENSE) file for more details.

<!-- This file was generated by liblab | https://liblab.com/ -->
