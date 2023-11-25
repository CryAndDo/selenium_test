using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace selenium_test
{
    [TestFixture]
    public class sibsuti_test
    {
        IWebDriver webDriver = new ChromeDriver();

        [TestCase]
        public void MainTitle()
        {
            webDriver.Url = "https://xn--h1adlhdnlo2c.xn--p1ai/";
            Assert.AreEqual("Урок Цифры — всероссийский образовательный проект в сфере цифровой экономики", webDriver.Title);
            webDriver.Close();
        }
        [TestCase]
        public void Мisibility_check()
        {
            webDriver.Url = "https://xn--h1adlhdnlo2c.xn--p1ai/";
            IWebElement element = webDriver.FindElement(By.XPath("//*[@id=\"home-page\"]/header/div/img"));
            bool status = element.Displayed;
            webDriver.Close();
        }
        [TestCase]
        public void Following_the_link()
        {
            webDriver.Url = "https://xn--h1adlhdnlo2c.xn--p1ai/";
            IWebElement element = webDriver.FindElement(By.XPath("/html/body/header/div[3]/div/nav[2]/div/a[1]"));
            element.Click();
            webDriver.Close();
        }   
        [TestCase]
        public void Text_completion()
        {
            webDriver.Url = "https://xn--h1adlhdnlo2c.xn--p1ai/";
            IWebElement element = webDriver.FindElement(By.XPath("/html/body/footer/div/div/div[1]/div[2]/form/div[1]/div[1]/input"));
            element.SendKeys("какой-то текст");
            webDriver.Close();
        }
        [TestCase]
        public void Emulation_of_a_button_press()
        {
            webDriver.Url = "https://xn--h1adlhdnlo2c.xn--p1ai/";
            IWebElement element = webDriver.FindElement(By.XPath("/html/body/footer/div/div/div[1]/div[2]/form/div[2]/button"));
            element.Click();
            webDriver.Close();
        }
        [TearDown]
        public void TestEnd()
        {
            webDriver.Quit();
        }
    }
}
