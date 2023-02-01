using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class Education
    {
        public void AddEducation(IWebDriver driver, String university, String country, String title, String degree, String year)
        {

            //click on add new button
            IWebElement addneweducationButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addneweducationButton.Click();
            //enter collage name in textbbox
            IWebElement collagenameTextbox = driver.FindElement(By.XPath("//input[@name='instituteName']"));
            collagenameTextbox.SendKeys(university);
            //select country from drilldown
            IWebElement countryDrilldown = driver.FindElement(By.XPath("//select/option[@value='India']"));
            countryDrilldown.Click();
            //select title from drilldown
            IWebElement titleDrilldown = driver.FindElement(By.XPath("//select/option[@value='B.Tech']"));
            titleDrilldown.Click();

            //enter degree name in textbox
            IWebElement degreenameTextbox = driver.FindElement(By.XPath("//input[@name='degree']"));
            degreenameTextbox.SendKeys(degree);
            //select year of graduation from drill down
            IWebElement yearDrilldown = driver.FindElement(By.XPath("//select/option[@value='2012']"));
            yearDrilldown.Click();
            //click on add
            IWebElement addeducationButton = driver.FindElement(By.XPath("//input[@type='button' and @class='ui teal button ']"));
            addeducationButton.Click();
            Thread.Sleep(1000);
        }
        public string GetCountry(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement countryName = driver.FindElement(By.XPath("//tr/td[text()='India']"));
            return countryName.Text;

        }
        public string GetUniversity(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement universityName = driver.FindElement(By.XPath("//tr/td[text()='Gujarat University']"));
            return universityName.Text;
        }
        public string GetTitle(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement titleName = driver.FindElement(By.XPath("//tr/td[text()='B.Tech']"));
            return titleName.Text;
        }
        public string GetDegree(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement degreeName = driver.FindElement(By.XPath("//tr/td[text()='Computer']"));
            return degreeName.Text;
        }
        public string GetYear(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement yearName = driver.FindElement(By.XPath("//tr/td[text()='2012']"));
            return yearName.Text;
        }
    }
}
