using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class SignInPage
    {
        public void SigninActions(IWebDriver driver)
        {
            //open browser
            Thread.Sleep(1000);
            //goto Url("http://localhost:5000")
            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Window.Maximize();
            //click sign in button
            IWebElement signinButton = driver.FindElement(By.XPath("//a[text()='Sign In']"));
            signinButton.Click();

            //Enter username and password
            IWebElement usernameTextbox = driver.FindElement(By.Name("email"));
            usernameTextbox.SendKeys("truptisharma105@gmail.com");
            IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
            passwordTextbox.SendKeys("Trisha@105");
            // click on login button
            IWebElement loginButton = driver.FindElement(By.XPath("//button[text()='Login']"));
            loginButton.Click();
            Thread.Sleep(1000);

        }
        public string GetCode(IWebDriver driver)
        {
            IWebElement nameCheck = driver.FindElement(By.XPath("//span[@class='item ui dropdown link ']"));
            return nameCheck.Text;

        }
    }
}
