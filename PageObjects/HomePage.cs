using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Specflow_Selenium.PageObjects
{
    public class HomePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        IWebElement buttonLogin => _driver.FindElement(By.CssSelector("#LoginLink"));
        public void ClickLogin() => buttonLogin.Click();

        IWebElement lnkLogout => _driver.FindElement(By.CssSelector("input[name='logout']"));
        public void ClickLogout() => lnkLogout.Click();
        public bool InspectLogout()
        {
            var isDisplayed = lnkLogout.Displayed;
            return isDisplayed;
        }

        IWebElement txtBoxSearch => _driver.FindElement(By.CssSelector("#searchString"));
        public void EnterSearchItem(string item) => txtBoxSearch.SendKeys(item);


        IWebElement drpDwnSearchType => _driver.FindElement(By.CssSelector("#SearchType"));
        public void SelectSearchType(string type)
        {        
            SelectElement selectElement = new SelectElement(drpDwnSearchType);
            selectElement.SelectByText(type);
        }

        IWebElement buttonSearch => _driver.FindElement(By.CssSelector("button[value='Search']"));
        public void ClickSearch() => buttonSearch.Click();

        IWebElement buttonMyTradeMe => _driver.FindElement(By.CssSelector("#SiteHeader_SiteTabs_myTradeMeDropDownLink"));
        public void ClickMyTradeMe() => buttonMyTradeMe.Click();

        IWebElement lnkWatchlist => _driver.FindElement(By.CssSelector("#SiteHeader_SiteTabs_mtmWatchlistLink"));
        public void ClickMyTradeMeWatchlist() => lnkWatchlist.Click();
    }
}
