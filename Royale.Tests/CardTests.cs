using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Royale.Tests
{
    public class CardTests
    {
        IWebDriver driver;

        [SetUp]
        public void BeforeEach()
        {
            var path = Path.GetFullPath(@"../../../../" + "_drivers");
            driver = new ChromeDriver(path);
        }

        [Test]
        public void Ice_Spirit_is_on_Cards_Page()
        {
            // 1. go to statsroyale.com and check if ice spirit is displayed
            driver.Url = "https://statsroyale.com";
            driver.FindElement(By.CssSelector("a[href='/cards']")).Click();
            var iceSpirit = driver.FindElement(By.CssSelector("a[href*='Ice+Spirit']"));
            Assert.That(iceSpirit.Displayed);
        }

        [TearDown]
        public void AfterEach() => driver.Quit();
    }
}