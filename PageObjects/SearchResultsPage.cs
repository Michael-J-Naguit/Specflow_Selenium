using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specflow_Selenium.PageObjects
{
    public class SearchResultsPage
    {
        private IWebDriver _driver;

        public SearchResultsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        IWebElement txtSearchResults => _driver.FindElement(By.CssSelector("h1[class='inline-block search-results-text']"));
        public bool InspectSearchResultsText()
        {
            var isDisplayed = txtSearchResults.Displayed;
            return isDisplayed;
        }

        public void ClickItemNumber(string itemNumber)
        {
            IWebElement lnkItem = _driver.FindElement(By.XPath(".//div[@data-ga-identifier=" + itemNumber + "]"));
            lnkItem.Click();
        }
    }
}
