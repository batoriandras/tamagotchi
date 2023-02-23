﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region login test
            var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost:5174");
            var username = driver.FindElement(By.Id("username"));
            var password = driver.FindElement(By.Id("password")); 
            var login = driver.FindElement(By.XPath("//button[@type='submit']"));

            username.SendKeys("admin");
            password.SendKeys("admin123");

            login.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//img[@alt='tiger.png']")));

            if (driver.Url == "http://localhost:5174/pet")
            {
                Console.WriteLine("Login successful");
            }
            else { Console.WriteLine("Login unsuccessful"); }
            #endregion

            #region eat
            int hunger = Convert.ToInt32(driver.FindElement(By.CssSelector("li:nth-child(3)>p:nth-child(2)")).Text);
            var eatBTN = driver.FindElement(By.Id("eat"));
            eatBTN.Click();
            Console.ReadKey();
            int hunger2 = Convert.ToInt32(driver.FindElement(By.CssSelector("li:nth-child(3)>p:nth-child(2)")).Text);
            if (hunger == hunger2 - 20)
            {
                Console.WriteLine("Hunger level went up by 20");
            }
            else
            {
                Console.WriteLine("asd");
            }
            #endregion

            #region drink
            int thirst = Convert.ToInt32(driver.FindElement(By.CssSelector("li:nth-child(4)>p:nth-child(2)")).Text);
            var drinkBTN = driver.FindElement(By.Id("drink"));
            drinkBTN.Click();
            Console.ReadKey();
            int thirst2 = Convert.ToInt32(driver.FindElement(By.CssSelector("li:nth-child(3)>p:nth-child(2)")).Text);
            if (thirst == thirst2 - 20)
            {
                Console.WriteLine("Thirst level went up by 20");
            }
            else
            {
                Console.WriteLine("asd");
            }
            #endregion

            #region hunt
            int mood = Convert.ToInt32(driver.FindElement(By.CssSelector("li:nth-child(2)>p:nth-child(2)")).Text);
            var huntBTN = driver.FindElement(By.Id("hunt"));
            huntBTN.Click();
            Console.ReadKey();
            int mood2 = Convert.ToInt32(driver.FindElement(By.CssSelector("li:nth-child(3)>p:nth-child(2)")).Text);
            if (mood == mood2 - 70)
            {
                Console.WriteLine("Mood level went up by 70");
            }
            else
            {
                Console.WriteLine("asd");
            }
            #endregion

            #region pet
            var petBTN = driver.FindElement(By.Id("pet"));
            petBTN.Click();
            Console.ReadKey();
            mood = Convert.ToInt32(driver.FindElement(By.CssSelector("li:nth-child(3)>p:nth-child(2)")).Text);
            if (mood2 == mood - 20)
            {
                Console.WriteLine("Mood level went up by 20");
            }
            else
            {
                Console.WriteLine("asd");
            }
            #endregion

            #region log out test
            var logout = driver.FindElement(By.Id("logout"));
            logout.Click();
            wait.Until(ExpectedConditions.ElementExists(By.Id("username")));
            if (driver.Url == "http://localhost:5174/")
            {
                Console.WriteLine("Log out successful");
            }
            else
            {
                Console.WriteLine("Log out unsuccessful");
            }
            #endregion
            Console.ReadKey();
            driver.Close();
        }
    }
}
