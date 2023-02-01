using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class Skill
    {
        public void Addskill(IWebDriver driver, String skill, String skilllevel)
        {

            //click on Add New
            IWebElement addnewskillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewskillButton.Click();
            Thread.Sleep(1000);
            //add value in add skill textbox
            IWebElement addskillTextbox = driver.FindElement(By.XPath("//input[@type='text' and @name='name' and @placeholder='Add Skill']"));
            addskillTextbox.SendKeys(skill);
            //select skill level from dropbox
            IWebElement chooseskillDropbox = driver.FindElement(By.XPath("//select[@name='level']"));
            chooseskillDropbox.Click();
            IWebElement beginnerOption = driver.FindElement(By.XPath("//select[@name='level']/option[@value='Beginner']"));
            beginnerOption.Click();
            //click add
            IWebElement addskillButton = driver.FindElement(By.XPath("//input[@type='button' and @value='Add']"));
            addskillButton.Click();


        }
        public string GetSkill(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement skillName = driver.FindElement(By.XPath("//tr/td[text()='C#']"));
            return skillName.Text;
        }
    }
}
