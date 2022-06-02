using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Fujitsu.OrangeAutomation.Base
{
    public class WebDriverWraper
    {
        protected IWebDriver driver;

        //protected IWebDriver Driver
        //{
        //    get { return driver; }
        //}

        [SetUp]
        public void Init()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), version: "99.0.4844.51");

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://opensource-demo.orangehrmlive.com/";
        }

        [TearDown]
        public void End()
        {
            driver.Quit();
        }
    }
}





/*using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace OrangeAutomation.Base
{
    public class WebDriverWraper
    {
        protected IWebDriver driver;


        [SetUp]
       public void Init()
        {
            string browser = "edge";
            switch (browser.ToLower())
            {
                case "edge":
                    driver = new EdgeDriver();
                    break;
                case "ff":
                    driver = new FirefoxDriver();
                    break;



                    new DriverManager().SetUpDriver(new ChromeConfig(), version: "99.0.4844.51");

                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

                    driver.Url = "https://opensource-demo.orangehrmlive.com/";
            }
        }

        [TearDown]
        public void End()
        {
            driver.Quit();
        }
    
}
}










      /*  protected IWebDriver driver;
        [SetUp ]
        public void Init()
        {
           // new Drivermanager().SetUpDriver(new ChromeConfig(), Version: "99.0.4844.51");
           // IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://opensource-demo.orangehrmlive.com/index.php/dashboard";
        }
        [TearDown]

        [Test]
     //   public void ValidCredentialTest()
      //  {
           // driver.FindElement(By.Id("txtUsername")).SendKeys("Admin");
         //   driver.FindElement(By.Id("txtPassword")).SendKeys("admin123");
        //    driver.FindElement(By.Id("btnLogin")).Click();
            // string actualError = driver.FindElement(By.Id("spanMessage")).Text;
            // Assert.That(actualError, Is.EqualTo("Invalid credentials"));
       //     string actualUrl = driver.Url;
          //  Assert.That(actualUrl, Is.EqualTo("https://opensource-demo.orangehrmlive.com/index.php/dashboard"))
//Url =        };
  //  }
//}*/