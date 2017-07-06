using System;
using OpenQA.Selenium.Remote;

namespace Tests
{
    public class IETests : TestBase
    {
        public IETests()
        {
            Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), DesiredCapabilities.InternetExplorer());
        }
    }
}