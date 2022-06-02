﻿using Fujitsu.OrangeAutomation.Base;
using Fujitsu.OrangeAutomation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Fujitsu.OrangeAutomation
{
    public class LoginTest : WebDriverWraper
    {
        [Test]
        [TestCase("Admin", "admin123", "https://opensource-demo.orangehrmlive.com/index.php/dashboard")]
        [TestCase("Admin", "admin123", "https://opensource-demo.orangehrmlive.com/index.php/dashboard")]
        public void ValidCredentialTest(string username, string password, string expectedUrl)
        {
            driver.FindElement(By.Id("txtUsername")).SendKeys(username);
            driver.FindElement(By.Id("txtPassword")).SendKeys(password);
            driver.FindElement(By.Id("btnLogin")).Click();

            //wait for page load

            string actualUrl = driver.Url;
            Assert.That(actualUrl, Is.EqualTo(expectedUrl));
        }



        [Test, TestCaseSource(typeof(DataUtils), nameof(DataUtils.InvalidCredentialData))]
        public void InvalidCredentialTest(string username, string password, string expectedError)
        {
            driver.FindElement(By.Id("txtUsername")).SendKeys(username);
            driver.FindElement(By.Id("txtPassword")).SendKeys(password);
            driver.FindElement(By.Id("btnLogin")).Click();

            string actualError = driver.FindElement(By.Id("spanMessage")).Text;
            Assert.That(actualError, Is.EqualTo(expectedError));
        }



    }
}







/*using OrangeAutomation.Base;
using Fujitsu.OrangeAutomation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using static Fujitsu.OrangeAutomation.Utilities.DataUtilities;

namespace Fujitsu.OrangeAutomation
{
    public class LoginTest : WebDriverWraper
    {
        [Test]
        [TestCase("Admin", "admin123", "https://opensource-demo.orangehrmlive.com/index.php/dashboard")]
        [TestCase("Admin", "admin123", "https://opensource-demo.orangehrmlive.com/index.php/dashboard")]
        public void ValidCredentialTest(string username, string password, string expectedUrl)
        {
            driver.FindElement(By.Id("txtUsername")).SendKeys(username);
            driver.FindElement(By.Id("txtPassword")).SendKeys(password);
            driver.FindElement(By.Id("btnLogin")).Click();

            //wait for page load

            string actualUrl = driver.Url;
            Assert.That(actualUrl, Is.EqualTo(expectedUrl));
        }



        [Test, TestCaseSource(typeof(DataUtils), nameof(DataUtils.InvalidCredentialData))]
        public void InvalidCredentialTest(string username, string password, string expectedError)
        {
            driver.FindElement(By.Id("txtUsername")).SendKeys(username);
            driver.FindElement(By.Id("txtPassword")).SendKeys(password);
            driver.FindElement(By.Id("btnLogin")).Click();

            string actualError = driver.FindElement(By.Id("spanMessage")).Text;
            Assert.That(actualError, Is.EqualTo(expectedError));
        }



    }
}*/