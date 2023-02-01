using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class ProfilePage
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
            IWebElement skillsTab = driver.FindElement(By.XPath("//a[text()='Skills']"));
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
