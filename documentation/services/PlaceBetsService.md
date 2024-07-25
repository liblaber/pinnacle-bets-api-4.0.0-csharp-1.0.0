# PlaceBetsService

A list of all methods in the `PlaceBetsService` service. Click on the method name to view detailed information about that method.

| Methods                                     | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| :------------------------------------------ | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| [BetsStraightV2Async](#betsstraightv2async) | Place straight bet (SPREAD, MONEYLINE, TOTAL_POINTS, TEAM_TOTAL_POINTS). Please note when the status is PENDING_ACCEPTANCE and if the live delay was applied, the response will not have betId. Client would have to call /bets by uniqueRequestId to check the status if the bet was ACCEPTED. For more details please see [How to place a bet on live events?](https://github.com/pinnacleapi/pinnacleapi-documentation/blob/master/FAQ.md#how-to-place-a-bet-on-live-events) Make sure you handle properly the case of an unexpected error as per [How to handle error on placing a bet?](https://github.com/pinnacleapi/pinnacleapi-documentation/blob/master/FAQ.md#how-to-handle-unexpected-error-on-placing-a-bet) |
| [BetsParlayV2Async](#betsparlayv2async)     | Make sure you handle properly the case of an unexpected error as per [How to handle error on placing a bet?](https://github.com/pinnacleapi/pinnacleapi-documentation/blob/master/FAQ.md#how-to-handle-unexpected-error-on-placing-a-bet)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [BetsTeaserAsync](#betsteaserasync)         | Make sure you handle properly the case of an unexpected error as per [How to handle error on placing a bet?](https://github.com/pinnacleapi/pinnacleapi-documentation/blob/master/FAQ.md#how-to-handle-unexpected-error-on-placing-a-bet)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [BetsSpecialAsync](#betsspecialasync)       | Make sure you handle properly the case of an unexpected error as per [How to handle error on placing a bet?](https://github.com/pinnacleapi/pinnacleapi-documentation/blob/master/FAQ.md#how-to-handle-unexpected-error-on-placing-a-bet)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |

## BetsStraightV2Async

Place straight bet (SPREAD, MONEYLINE, TOTAL_POINTS, TEAM_TOTAL_POINTS). Please note when the status is PENDING_ACCEPTANCE and if the live delay was applied, the response will not have betId. Client would have to call /bets by uniqueRequestId to check the status if the bet was ACCEPTED. For more details please see [How to place a bet on live events?](https://github.com/pinnacleapi/pinnacleapi-documentation/blob/master/FAQ.md#how-to-place-a-bet-on-live-events) Make sure you handle properly the case of an unexpected error as per [How to handle error on placing a bet?](https://github.com/pinnacleapi/pinnacleapi-documentation/blob/master/FAQ.md#how-to-handle-unexpected-error-on-placing-a-bet)

- HTTP Method: `POST`
- Endpoint: `/v4/bets/straight`

**Parameters**

| Name  | Type            | Required | Description       |
| :---- | :-------------- | :------- | :---------------- |
| input | PlaceBetRequest | ✅       | The request body. |

**Return Type**

`PlaceStraightBetResponse`

**Example Usage Code Snippet**

```csharp
using PinnacleBets;
using PinnacleBets.Models;

var client = new PinnacleBetsClient();

var input = new PlaceBetRequest();

var response = await client.PlaceBets.BetsStraightV2Async(input);

Console.WriteLine(response);
```

## BetsParlayV2Async

Make sure you handle properly the case of an unexpected error as per [How to handle error on placing a bet?](https://github.com/pinnacleapi/pinnacleapi-documentation/blob/master/FAQ.md#how-to-handle-unexpected-error-on-placing-a-bet)

- HTTP Method: `POST`
- Endpoint: `/v4/bets/parlay`

**Parameters**

| Name  | Type                  | Required | Description       |
| :---- | :-------------------- | :------- | :---------------- |
| input | PlaceParlayBetRequest | ✅       | The request body. |

**Return Type**

`PlaceParlayBetResponse`

**Example Usage Code Snippet**

```csharp
using PinnacleBets;
using PinnacleBets.Models;

var client = new PinnacleBetsClient();

var input = new PlaceParlayBetRequest();

var response = await client.PlaceBets.BetsParlayV2Async(input);

Console.WriteLine(response);
```

## BetsTeaserAsync

Make sure you handle properly the case of an unexpected error as per [How to handle error on placing a bet?](https://github.com/pinnacleapi/pinnacleapi-documentation/blob/master/FAQ.md#how-to-handle-unexpected-error-on-placing-a-bet)

- HTTP Method: `POST`
- Endpoint: `/v4/bets/teaser`

**Parameters**

| Name  | Type                  | Required | Description       |
| :---- | :-------------------- | :------- | :---------------- |
| input | PlaceTeaserBetRequest | ✅       | The request body. |

**Return Type**

`PlaceTeaserBetResponse`

**Example Usage Code Snippet**

```csharp
using PinnacleBets;
using PinnacleBets.Models;

var client = new PinnacleBetsClient();

var input = new PlaceTeaserBetRequest();

var response = await client.PlaceBets.BetsTeaserAsync(input);

Console.WriteLine(response);
```

## BetsSpecialAsync

Make sure you handle properly the case of an unexpected error as per [How to handle error on placing a bet?](https://github.com/pinnacleapi/pinnacleapi-documentation/blob/master/FAQ.md#how-to-handle-unexpected-error-on-placing-a-bet)

- HTTP Method: `POST`
- Endpoint: `/v4/bets/special`

**Parameters**

| Name  | Type                             | Required | Description       |
| :---- | :------------------------------- | :------- | :---------------- |
| input | MultiBetRequestSpecialBetRequest | ✅       | The request body. |

**Return Type**

`MultiBetResponseSpecialBetResponse`

**Example Usage Code Snippet**

```csharp
using PinnacleBets;
using PinnacleBets.Models;

var client = new PinnacleBetsClient();

var input = new MultiBetRequestSpecialBetRequest();

var response = await client.PlaceBets.BetsSpecialAsync(input);

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
