﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BookWorm.Tests.Specs.Pages
{
    public class CreateBookPage : BasePage
    {

        public CreateBookPage(IWebDriver driver) : base(driver)
        {
        }

        public bool IsCurrentPage()
        {
            return driver.Title == "Add a Book - My ASP.NET MVC Application";
        }

        public CreateBookPage FillForm(string title)
        {
            WaitForPageToLoad();
            driver.FindElement(By.Id("Book_Title")).SendKeys(title);
            driver.FindElement(By.Id("Book_Subtitle")).SendKeys("ss");
            driver.FindElement(By.Id("Book_Author")).SendKeys("ss");
            driver.FindElement(By.Id("Book_Illustrator")).SendKeys("ss");
            driver.FindElement(By.Id("Book_Editor")).SendKeys("ss");
            driver.FindElement(By.Id("Book_Isbn")).SendKeys("123456789");
            driver.FindElement(By.Id("Book_Publisher")).SendKeys("ss");
            driver.FindElement(By.Id("Book_Genre")).SendKeys("ss");
            driver.FindElement(By.Id("Book_CoverImageUrl")).SendKeys("http://images.google.co.za/intl/en_ALL/images/logos/images_logo_lg.gif");
            driver.FindElement(By.Id("Book_Description")).SendKeys("ss");
            return  new CreateBookPage(driver);
        }

        public BookDetailsPage ClickSaveButton()
        {
            driver.FindElement(By.Id("SaveButton")).Click();
            WaitForPageToLoad();
            return new BookDetailsPage(driver);
        }
    }
}
