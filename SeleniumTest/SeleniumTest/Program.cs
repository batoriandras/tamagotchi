using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
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

            driver.Manage().Timeouts().ImplicitWait.Seconds(10);
            if (driver.Url == "http://localhost:5174/pet")
            {
                Console.WriteLine("Login successful");
            }
            else { Console.WriteLine("asd"); }
            Console.ReadKey();
            #endregion

            #region log out test
            var logout = driver.FindElement(By.Id("logout"));
            logout.Click();
            if (driver.Url== "http://localhost:5174")
            {
                Console.WriteLine("Log out successful");
            }
            #endregion
        }
    }
}
