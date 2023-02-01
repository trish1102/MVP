

namespace Mars.Utilities
{
    [Binding]
    public class Comondriver
    {
       public static IWebDriver driver;

         [AfterScenario]
        public void CloseTestRun()
        {
            
            driver.Quit();
        }
    }
}
