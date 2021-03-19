Feature: MyTradeMe
	UI Tests for "My Trade Me" feature

	Background:
	Given Open browser and navigate to TradeMe sandbox website

@mytag
Scenario: Add an item to watchlist
	Given Log In User
		| Email                   | Password          |
		| flux_test_004@test.test | caughtthinghold38 |
	When Search for an item in a category
		| Item          | Category      |
		| German Fokker | Toys & models |
	And Click on item number '2'
	And Click on Add to Watchlist
	And Click on My Trade Me Watchlist
	Then Verify item is in the list
