using System;
using OpenQA.Selenium.Remote;

namespace Tests
{
    public class FirefoxTests : TestBase
    {
        public FirefoxTests()
        {
            Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), DesiredCapabilities.Firefox());
        }
    }
}