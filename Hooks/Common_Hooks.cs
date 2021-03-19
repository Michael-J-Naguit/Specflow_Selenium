using Microsoft.Edge.SeleniumTools;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Specflow_Selenium.Contexts;
using Specflow_Selenium.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Specflow_Selenium.Hooks
{
    [Binding]
    public sealed class Common_Hooks
    {
        private DataContext _data;

        public Common_Hooks(DataContext data)
        {
            _data = data;
        }
        
        [BeforeScenario (Order = 0)]
        public void OpenBrowser()
        {
            if (TestContext.Parameters["browser"] == "chrome")
                _data.driver = new ChromeDriver();
            else if (TestContext.Parameters["browser"] == "edge")
                _data.driver = new EdgeDriver();

            _data.driver.Manage().Window.Maximize();
            _data.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterScenario]
        public void CloseBrowser()
        {
            Thread.Sleep(3000);
            _data.driver.Close();
        }

        [BeforeScenario(Order = 1)]
        public void SetPageOjects()
        {
            _data.homePage = new HomePage(_data.driver);
            _data.loginPage = new LoginPage(_data.driver);
            _data.searchResultsPage = new SearchResultsPage(_data.driver);
            _data.itemPage = new ItemPage(_data.driver);
            _data.watchlistPage = new WatchlistPage(_data.driver);
        }
    }
}
