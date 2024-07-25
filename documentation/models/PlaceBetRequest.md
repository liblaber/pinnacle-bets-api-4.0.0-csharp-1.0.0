# PlaceBetRequest

Request to place a bet.

**Properties**

| Name             | Type                        | Required | Description                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| :--------------- | :-------------------------- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| OddsFormat       | OddsFormat                  | ❌       | Bet odds format. AMERICAN = American odds format, DECIMAL = Decimal (European) odds format, HONGKONG = Hong Kong odds format, INDONESIAN = Indonesian odds format, MALAY = Malaysian odds format                                                                                                                                                                                                                                              |
| UniqueRequestId  | string                      | ❌       | This is a Unique ID for PlaceBet requests. This is to support idempotent requests.                                                                                                                                                                                                                                                                                                                                                            |
| AcceptBetterLine | bool                        | ❌       | Whether or not to accept a bet when there is a line change in favor of the client.                                                                                                                                                                                                                                                                                                                                                            |
| Stake            | double                      | ❌       | amount in client’s currency.                                                                                                                                                                                                                                                                                                                                                                                                                  |
| WinRiskStake     | PlaceBetRequestWinRiskStake | ❌       | Whether the stake amount is risk or win amount.                                                                                                                                                                                                                                                                                                                                                                                               |
| LineId           | long                        | ❌       | Line identification.                                                                                                                                                                                                                                                                                                                                                                                                                          |
| AltLineId        | long                        | ❌       | Alternate line identification.                                                                                                                                                                                                                                                                                                                                                                                                                |
| FillType\_       | FillType                    | ❌       | NORMAL - bet will be placed on specified stake. FILLANDKILL - If the stake is over the max limit, bet will be placed on max limit, otherwise it will be placed on specified stake. FILLMAXLIMIT - bet will be places on max limit, stake amount will be ignored. Please note that maximum limits can change at any moment, which may result in risking more than anticipated. This option is replacement of isMaxStakeBet from v1/bets/place' |
| SportId          | long                        | ❌       |                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| EventId          | long                        | ❌       |                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| PeriodNumber     | long                        | ❌       |                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| BetType          | PlaceBetRequestBetType      | ❌       | Bet type.                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| Team\_           | Team                        | ❌       | Team type.                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| Side             | PlaceBetRequestSide         | ❌       | Side type.                                                                                                                                                                                                                                                                                                                                                                                                                                    |

# PlaceBetRequestWinRiskStake

Whether the stake amount is risk or win amount.

**Properties**

| Name | Type   | Required | Description |
| :--- | :----- | :------- | :---------- |
| Win  | string | ✅       | "WIN"       |
| Risk | string | ✅       | "RISK"      |

# FillType

NORMAL - bet will be placed on specified stake. FILLANDKILL - If the stake is over the max limit, bet will be placed on max limit, otherwise it will be placed on specified stake. FILLMAXLIMIT - bet will be places on max limit, stake amount will be ignored. Please note that maximum limits can change at any moment, which may result in risking more than anticipated. This option is replacement of isMaxStakeBet from v1/bets/place'

**Properties**

| Name         | Type   | Required | Description    |
| :----------- | :----- | :------- | :------------- |
| Normal       | string | ✅       | "NORMAL"       |
| Fillandkill  | string | ✅       | "FILLANDKILL"  |
| Fillmaxlimit | string | ✅       | "FILLMAXLIMIT" |

# PlaceBetRequestBetType

Bet type.

**Properties**

| Name            | Type   | Required | Description         |
| :-------------- | :----- | :------- | :------------------ |
| Moneyline       | string | ✅       | "MONEYLINE"         |
| TeamTotalPoints | string | ✅       | "TEAM_TOTAL_POINTS" |
| Spread          | string | ✅       | "SPREAD"            |
| TotalPoints     | string | ✅       | "TOTAL_POINTS"      |

# Team

Team type.

**Properties**

| Name  | Type   | Required | Description |
| :---- | :----- | :------- | :---------- |
| Team1 | string | ✅       | "TEAM1"     |
| Team2 | string | ✅       | "TEAM2"     |
| Draw  | string | ✅       | "DRAW"      |

# PlaceBetRequestSide

Side type.

**Properties**

| Name  | Type   | Required | Description |
| :---- | :----- | :------- | :---------- |
| Over  | string | ✅       | "OVER"      |
| Under | string | ✅       | "UNDER"     |

<!-- This file was generated by liblab | https://liblab.com/ -->
