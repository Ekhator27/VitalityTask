using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalityTask.Support
{
    public static class DriverExtension
    {
        public static IWebElement FindthisElement(this IWebDriver driver, By by)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20))
            {
                PollingInterval = TimeSpan.FromSeconds(10)
            };
            return wait.Until(x => x.FindElement(by));
        }

        public static IWebElement WaitForElement(this IWebDriver driver, By by)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20))
            {
                PollingInterval = TimeSpan.FromSeconds(10)
            };
            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public static void ClickOption(this IWebDriver driver)
        {
            Actions action = new Actions(driver);
            action.SendKeys(Keys.ArrowDown).Perform();
            action.Pause(TimeSpan.FromSeconds(1));
            action.SendKeys(Keys.Enter).Perform();
            action.Pause(TimeSpan.FromSeconds(1));
            action.SendKeys(Keys.Enter).Perform();
        }
    }
}
