using NUnit.Framework;
using OpenQA.Selenium;

namespace Royale.Tests
{
    public class CardTests
    {
        IWebDriver driver;

        [SetUp]
        public void BeforeEach()
        {
        }

        [Test]
        public void Ice_Spirit_is_on_Cards_Page()
        {
            Assert.Pass();
        }

        public void AfterEach() => driver.Quit();
    }
}