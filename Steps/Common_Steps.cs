using NUnit.Framework;
using Specflow_Selenium.Contexts;
using System.Threading;
using TechTalk.SpecFlow;

namespace Specflow_Selenium.Steps
{
    [Binding]
    public sealed class Common_Steps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private DataContext _data;

        public Common_Steps(ScenarioContext scenarioContext, DataContext data)
        {
            _scenarioContext = scenarioContext;
            _data = data;
        }

        [Given(@"Open browser and navigate to TradeMe sandbox website")]
        public void GivenOpenBrowserAndNavigateToTradeMeSandboxWebsite()
        {
            _data.driver.Navigate().GoToUrl("https://www.tmsandbox.co.nz/");

            // Verify Homepage Title is displayed
            Assert.AreEqual(_data.driver.Title, "TRADEME SANDBOX - Buy online and sell with NZ's #1 auction & classifieds site | Trade Me SANDBOX");
        }

        [Given(@"Log In User")]
        public void GivenLogInUser(Table table)
        {
            // Click Login Button in Home Page
            _data.homePage.ClickLogin();

            // Enter Email Address
            _data.loginPage.EnterEmail(table.Rows[0]["Email"]);

            // Enter Password
            _data.loginPage.EnterPassword(table.Rows[0]["Password"]);

            // Click Login Button in Login Page
            _data.loginPage.clickLogin();

            // Verify Logout Button is displayed
            Assert.IsTrue(_data.homePage.InspectLogout());
        }

        [When(@"Search for an item in a category")]
        public void WhenSearchForAnItemInACategory(Table table)
        {
            // Enter item into search bar
            _data.homePage.EnterSearchItem(table.Rows[0]["Item"]);

            // Select item category or type
            _data.homePage.SelectSearchType(table.Rows[0]["Category"]);

            // Click Search button
            _data.homePage.ClickSearch();

            // Verify Search Result Text is displayed
            Assert.IsTrue(_data.searchResultsPage.InspectSearchResultsText());
        }

        [When(@"Click on item number (.*)")]
        public void WhenClickOnItemNumber(string item)
        {
            // Click on selected Item Number
            _data.searchResultsPage.ClickItemNumber(item);

            // Get Item Title and store in global variable
            _data.itemTitle = _data.itemPage.GetTitleText();
        }

        [When(@"Click on Add to Watchlist")]
        public void WhenClickOnAddToWatchlist()
        {
            // Click on Add to Watchlist button
            _data.itemPage.ClickWatchlistButton();
        }

        [When(@"Click on My Trade Me Watchlist")]
        public void WhenClickOnMyTradeMe()
        {
            // Click "My Trade Me" button in Home Page
            _data.homePage.ClickMyTradeMe();

            // Click "My Trade Me" - Watchlist link
            _data.homePage.ClickMyTradeMeWatchlist();
        }

    }
}
