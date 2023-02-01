



using Mars.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Mars.StepDefinations
{
    [Binding]
    public class MarsStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        SignInPage signInpageObj = new SignInPage();
        ProfilePage profilepageObj = new ProfilePage();
        Language languageObj = new Language();
        Skill skillObj = new Skill();
        Education educationObj=new Education();
        [Given(@"I login into mars portal using valid credentials")]
        public void GivenILoginIntoMarsPortalUsingValidCredentials()
        {
            //signin page objection intialition
            
            signInpageObj.SigninActions(driver);

        }

        


        [Then(@"I should be able to validate that I logged in successfully")]
        public void ThenIShouldBeAbleToValidateThatILoggedInSuccessfully()
        {
            
            string nameCheck=signInpageObj.GetCode(driver);
            Assert.That(nameCheck == "Hi Trupti", "Test Failed");
        }
                [Given(@"I loggedin into mars portal")]
        public void GivenILoggedinIntoMarsPortal()
        {
           
            signInpageObj.SigninActions(driver);
        }

        [Given(@"I enter language details '([^']*)'and '([^']*)'")]
        public void GivenIEnterLanguageDetailsAnd(string language, string languagelevel)
        {
            profilepageObj.ClickonLanguage(driver);
            languageObj.AddLanguage(driver, language, languagelevel);
        }
        
        [Then(@"I should be able to see new language record created")]
        public void ThenIShouldBeAbleToSeeNewLanguageRecordCreated()
        {
            profilepageObj.ClickonLanguage(driver);
            string languageName = languageObj.GetLanguage(driver);
            Assert.That(languageName == "English", "Test Failed");
        }
        [Given(@"I enter new Skill details '([^']*)'and '([^']*)'")]
        public void GivenIEnterNewSkillDetailsAnd(string skill, string skilllevel)
        {
            profilepageObj.ClickonSkill(driver);
            skillObj.Addskill(driver, skill, skilllevel);
        }
        [Then(@"I should be able to see new Skill record created")]
        public void ThenIShouldBeAbleToSeeNewSkillRecordCreated()
        {
            profilepageObj.ClickonSkill(driver);
            String skillName = skillObj.GetSkill(driver);
            Assert.That(skillName == "C#", "Test Failed");
        }
        [Given(@"I enter education details '([^']*)', '([^']*)','([^']*)','([^']*)' and '([^']*)'")]
        public void GivenIEnterEducationDetailsAnd(string university, string country, string title, string degree, string year)
        {
            profilepageObj.ClickonEducation(driver);
            educationObj.AddEducation(driver, university, country, title, degree, year);
        }
        [Then(@"I should be able to see new education record created")]
        public void ThenIShouldBeAbleToSeeNewEducationRecordCreated()
        {
            profilepageObj.ClickonEducation(driver);
            String countryName =educationObj.GetCountry(driver);
            String universityName=educationObj.GetUniversity(driver);
            String titleName=educationObj.GetTitle(driver);
            String degreeName=educationObj.GetDegree(driver);
            String yearName=educationObj.GetYear(driver);
            Assert.That(countryName == "India", "Test Failed");
            Assert.That(universityName == "Gujarat University","Test Failed");
            Assert.That(titleName == "B.Tech", "Test Failed");
            Assert.That(degreeName == "Computer", "Test Failed");
            Assert.That(yearName == "2012", "Test Failed");
        }





    }
}
