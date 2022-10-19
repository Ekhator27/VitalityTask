using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VitalityTask.Drivers;
using VitalityTask.Support;

namespace VitalityTask.Pages
{
    public class BournemouthweatherHome 
    {
        private readonly IWebDriver driver;
        public BournemouthweatherHome(IWebDriver driver)
        {
            this.driver = driver;
        }

        private string url => "https://www.bbc.co.uk/weather";
        private By Searchbar => By.Id("ls-c-search__input-label");
        private By Bbcweatherpage => By.CssSelector("h1[id=wr-location-name-id]");





        public void navigateToSite() => driver.Navigate().GoToUrl(url);
        public void enterLacation(string value)
        {
            driver.WaitForElement(Searchbar).SendKeys(value);
            driver.ClickOption();
        }

        public string IsPageDisplayed() => driver.WaitForElement(Bbcweatherpage).Text;
    }
}
