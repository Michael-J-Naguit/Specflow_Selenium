using OpenQA.Selenium;

namespace Specflow_Selenium.PageObjects
{
    public class ItemPage
    {
        private IWebDriver _driver;

        public ItemPage(IWebDriver driver)
        {
            _driver = driver;
        }

        IWebElement buttonAddToWatchlist => _driver.FindElement(By.CssSelector("#Watchlist_SaveToWatchlistButton"));
        public void ClickWatchlistButton() => buttonAddToWatchlist.Click();

        IWebElement buttonWatching => _driver.FindElement(By.CssSelector("#Watchlist_UnWatchItemButton"));
        public bool InspectWatching()
        {
            var isDisplayed = buttonWatching.Displayed;
            return isDisplayed;
        }

        IWebElement textTitle => _driver.FindElement(By.XPath("//*[@id='ListingTitleBox_TitleText']/h1"));
        public string GetTitleText()
        {
            string text = textTitle.Text.ToString();
            return text;
        }
    }
}
