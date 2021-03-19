using OpenQA.Selenium;
using Specflow_Selenium.PageObjects;

namespace Specflow_Selenium.Contexts
{
    public class DataContext
    {
        public IWebDriver driver;
        public HomePage homePage;
        public LoginPage loginPage;
        public SearchResultsPage searchResultsPage;
        public ItemPage itemPage;
        public WatchlistPage watchlistPage;
        public string itemTitle;
    }
}
