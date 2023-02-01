

namespace Mars.Pages
{
    public class ProfilePage: Comondriver
    {
        public void ClickonLanguage(IWebDriver driver)
        {  //click on Languages
            Thread.Sleep(1000);
            IWebElement languagesTab = driver.FindElement(By.XPath("//h3[text()='Languages']"));
            languagesTab.Click();
        }
        public void ClickonSkill(IWebDriver driver)
        {//click on skills
            Thread.Sleep(1000);
            IWebElement skillsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsTab.Click();
        }
        public void ClickonEducation(IWebDriver driver)
        {
            Thread.Sleep(1000);
            //click on educationtab
            IWebElement educationTab = driver.FindElement(By.XPath("//a[text()='Education']"));
            educationTab.Click();
        }
    }
}
