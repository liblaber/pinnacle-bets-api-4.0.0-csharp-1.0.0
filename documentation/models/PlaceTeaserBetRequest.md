# PlaceTeaserBetRequest

**Properties**

| Name            | Type                 | Required | Description                                                                                                                                                                                      |
| :-------------- | :------------------- | :------- | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| UniqueRequestId | string               | ❌       | Client generated GUID for uniquely identifying the bet.                                                                                                                                          |
| TeaserId        | long                 | ❌       | Unique identifier. Teaser details can be retrieved from a call to Get Teaser Groups endpoint.                                                                                                    |
| OddsFormat      | OddsFormat           | ❌       | Bet odds format. AMERICAN = American odds format, DECIMAL = Decimal (European) odds format, HONGKONG = Hong Kong odds format, INDONESIAN = Indonesian odds format, MALAY = Malaysian odds format |
| WinRiskStake    | string               | ❌       | Whether the stake amount is risk or win amount.                                                                                                                                                  |
| Stake           | double               | ❌       | amount in client’s currency.                                                                                                                                                                     |
| Legs            | List`<TeaserBetLeg>` | ❌       | Collection of legs.                                                                                                                                                                              |

<!-- This file was generated by liblab | https://liblab.com/ -->
