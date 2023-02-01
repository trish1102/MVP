

using OpenQA.Selenium;

namespace Mars.Pages
{
    public class Skill: Comondriver
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
        public void UpdateSkill(IWebDriver driver)
        {
            //click on update button
            Thread.Sleep(1000);
            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            updateButton.Click();
            Thread.Sleep(1000);
            //get textbox for skill and clear value
           IWebElement skillTextbox1 = driver.FindElement(By.XPath("//input[@type='text' and @name='name']"));
            skillTextbox1.Clear();
            //enter new value
            Thread.Sleep(500);
            skillTextbox1.SendKeys("Selenium");
            //click update button
            IWebElement updatedButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            updatedButton.Click();

        }
        public string GetUpdatedSkill(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement newskillName = driver.FindElement(By.XPath("//tr/td[text()='Selenium']"));
            return newskillName.Text;
        }
        public void DeleteSkill(IWebDriver driver)
        {
            //click on delete button
            Thread.Sleep(500);
            IWebElement deleteButton = driver.FindElement(By.XPath("//i[@class='remove icon']"));
            deleteButton.Click();
        }
    }
}
