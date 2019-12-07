using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BMLoginTest
{
    [TestClass]
    public class BMlogintest
    {
        private IWebDriver driver;
 
        [TestInitialize]
        public void SetUp()
        {
            driver = new ChromeDriver();
            
        }
        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }
        [TestMethod]
        public void dataBGlogintest()
        {
            driver.Navigate().GoToUrl("http://www.data.bg/login");
            driver.Manage().Window.Size = new System.Drawing.Size(1580, 840);
            driver.FindElement(By.Id("databg_user")).Click();
            driver.FindElement(By.Id("databg_user")).SendKeys("wwww");
            driver.FindElement(By.Id("databg_pass")).Click();
            driver.FindElement(By.Id("databg_pass")).SendKeys("ssss");
            driver.FindElement(By.Id("loginbtn")).Click();
            Assert.AreEqual(driver.FindElement(By.CssSelector("#errormsg > div")).Text,"Паролата и потребителят не съвпадат");
            driver.FindElement(By.Id("databg_user")).Click();
            driver.FindElement(By.Id("databg_user")).SendKeys("dsfs#fsdfsd#");
            driver.FindElement(By.Id("databg_pass")).SendKeys("FDSFS2");
            driver.FindElement(By.Id("loginbtn")).Click();
            Assert.AreEqual(driver.FindElement(By.CssSelector("#errormsg > div")).Text, "Паролата и потребителят не съвпадат");
        }
           
    }
}
