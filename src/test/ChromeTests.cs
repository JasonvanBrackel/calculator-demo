using System;
using OpenQA.Selenium.Remote;

namespace Tests
{
    public class ChromeTests : TestBase
    {
        public ChromeTests()
        {
            Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), DesiredCapabilities.Chrome());
        }
    }
}