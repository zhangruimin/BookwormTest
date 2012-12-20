﻿using BookWorm.Tests.Specs.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace BookWorm.Tests.Specs
{
    public class BaseSteps
    {
        protected IWebDriver Driver;
        protected HomePage HomePage;

        [BeforeScenario]
        public void Setup()
        {
            Driver = new FirefoxDriver();
        }

        [AfterScenario]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}