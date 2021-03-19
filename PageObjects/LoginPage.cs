using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specflow_Selenium.PageObjects
{
    public class LoginPage
    {
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        IWebElement txtBoxEmail => _driver.FindElement(By.CssSelector("#page_email"));
        public void EnterEmail(string email) => txtBoxEmail.SendKeys(email);

        IWebElement txtBoxPassword => _driver.FindElement(By.CssSelector("#page_password"));
        public void EnterPassword(string password) => txtBoxPassword.SendKeys(password);

        IWebElement buttonLogin => _driver.FindElement(By.CssSelector("#LoginPageButton"));
        public void clickLogin() => buttonLogin.Click();
    }
}
