using BoDi;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using VitalityTask.Pages;

namespace VitalityTask.StepDefinitions
{
    [Binding]
    public class BournemouthweatherStepDefinitions
    {
        BournemouthweatherHome WeatherHome;
        public BournemouthweatherStepDefinitions(IObjectContainer container)
        {
            WeatherHome = container.Resolve<BournemouthweatherHome>();
        }

        [Given(@"I navigate to weather page on the BBC website")]
        public void GivenINavigateToWeatherPageOnTheBBCWebsite()
        {
            WeatherHome.navigateToSite();
        }

        [When(@"I search for '(.*)' weather results")]
        public void WhenISearchForBournemouthWeatherResults(string location)
        {
            WeatherHome.enterLacation(location);
        }

        [Then(@"I should be taken to '(.*)' BBC weather page")]
        public void WhenIShouldBeTakenToTheBBCWeatherPage(string isDisplayed)
        {
            bool displayed = WeatherHome.IsPageDisplayed().Equals(isDisplayed);
            Assert.IsTrue(displayed);
        }
    }
}
