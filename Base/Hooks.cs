using BoDi;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using TechTalk.SpecFlow;
using VitalityTask.Drivers;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace VitalityTask.Base
{
    [Binding]
    public class Hooks : DriverHelper
    {
        public ChromeOptions options;
        IObjectContainer container;
        public Hooks(IObjectContainer _container)
        {
            container = _container;
        }

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), 
                VersionResolveStrategy.MatchingBrowser);
            options = new ChromeOptions();
            options.AddArguments("--start-maximized", "--incognito");
            driver = new ChromeDriver(options);
            container.RegisterInstanceAs(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {

            driver?.Quit();

            using (var process = Process.GetCurrentProcess())

                if (process.ToString() == "chromedriver")
                {
                    process.Kill();
                }
        }
    }
}