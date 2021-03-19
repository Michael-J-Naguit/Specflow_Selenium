using NUnit.Framework;
using Specflow_Selenium.Contexts;
using TechTalk.SpecFlow;

namespace Specflow_Selenium.Steps
{
    [Binding]
    public sealed class MyTradeMe_Steps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private DataContext _data;

        public MyTradeMe_Steps(ScenarioContext scenarioContext, DataContext data)
        {
            _scenarioContext = scenarioContext;
            _data = data;
        }

        [Then(@"Verify item is in the list")]
        public void ThenVerifyItemIsInTheList()
        {
            // Get item title string from global variable
            string item = _data.itemTitle;

            // Check if item is on the watchlist
            Assert.IsTrue(_data.watchlistPage.InspectItemOnList(item));
        }


    }
}
