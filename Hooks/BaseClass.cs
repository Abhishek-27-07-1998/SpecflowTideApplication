using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Serilog;
using Serilog.Core;
using OpenQA.Selenium.Chrome;
using Serilog.Events;

namespace ComprehensiveSpecflow.Hooks
{
    [Binding]
    public class BaseClass
    {
        public static IWebDriver driver;
        public static ExtentReports extents;
        public static ExtentTest feature;
        public static ExtentTest scenario;

        [BeforeFeature]
        public static void featureBrowser(FeatureContext featureContext)
        {
            feature = extents.CreateTest<Feature>(featureContext.FeatureInfo.Title);
            Log.Information("selecting feature file {0} to run", featureContext.FeatureInfo.Title);
        }

        [BeforeScenario]
        public static void OpenBrowser(ScenarioContext scenarioContext)
        {
            scenario = feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
            Log.Information("selecting scenario {0} to run", scenarioContext.ScenarioInfo.Title);
            driver = new ChromeDriver();
        }
        [BeforeTestRun]
        public static void GenerateReport()
        {
            var htmlReport = new ExtentHtmlReporter(@"C:\Users\mindc1may270\Desktop\Comprehensive Assessment\Specflow\ComprehensiveSpecflow\Reports\Index.html");
            htmlReport.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            extents = new ExtentReports();
            extents.AttachReporter(htmlReport);
            LoggingLevelSwitch loggingLevel = new LoggingLevelSwitch(LogEventLevel.Debug);
            Log.Logger = new LoggerConfiguration().MinimumLevel.ControlledBy(levelSwitch: loggingLevel).WriteTo.File(@"C:\Users\mindc1may270\Desktop\Comprehensive Assessment\Specflow\ComprehensiveSpecflow\Reports\logs", outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}").CreateLogger();
        }

        [AfterTestRun]
        public static void CloseExtentReport()
        {
            extents.Flush();
        }

        [AfterStep]
        public static void InsertReportingSteps(ScenarioContext scenarioContext)
        {
            if (scenarioContext.TestError == null)
            {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);

            }
            if (scenarioContext.TestError != null)
            {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);
                if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);
                if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);
            }
        }
        [AfterScenario]
        public static void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
