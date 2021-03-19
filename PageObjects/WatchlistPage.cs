using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specflow_Selenium.PageObjects
{
    public class WatchlistPage
    {
        private IWebDriver _driver;

        public WatchlistPage(IWebDriver driver)
        {
            _driver = driver;
        }
     
        public bool InspectItemOnList(string item)
        {
            IWebElement buttonWatching = _driver.FindElement(By.XPath("//*[text()='"+ item + "']"));
            
            var isDisplayed = buttonWatching.Displayed;
            return isDisplayed;
        }
    }
}
