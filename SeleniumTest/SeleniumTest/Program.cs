using OpenQA.Selenium;
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
            int hunger = Convert.ToInt32(driver.FindElement(By.CssSelector("#statul>li:nth-child(3)>p:nth-child(2)")).Text);
            var eatBTN = driver.FindElement(By.Id("eat"));
            Console.ReadKey();

            eatBTN.Click();
            driver.SwitchTo().Alert().Accept();
            Console.ReadKey();
            int hunger2 = Convert.ToInt32(driver.FindElement(By.CssSelector("#statul>li:nth-child(3)>p:nth-child(2)")).Text);
            if (hunger == hunger2 - 20 || hunger2 == 100)
            {
                Console.WriteLine("Hunger level went up by 20");
            }
            else
            {
                Console.WriteLine("error");
            }
            #endregion

            #region drink
            int thirst = Convert.ToInt32(driver.FindElement(By.CssSelector("#statul>li:nth-child(4)>p:nth-child(2)")).Text);
            var drinkBTN = driver.FindElement(By.Id("drink"));
            drinkBTN.Click();
            driver.SwitchTo().Alert().Accept();
            Console.ReadKey();
            int thirst2 = Convert.ToInt32(driver.FindElement(By.CssSelector("#statul>li:nth-child(4)>p:nth-child(2)")).Text);
            if (thirst == thirst2 - 20 || thirst2 == 100)
            {
                Console.WriteLine("Thirst level went up by 20");
            }
            else
            {
                Console.WriteLine("error");
            }
            #endregion

            #region hunt
            int mood = Convert.ToInt32(driver.FindElement(By.CssSelector("#statul>li:nth-child(2)>p:nth-child(2)")).Text);
            int fatigue = Convert.ToInt32(driver.FindElement(By.CssSelector("#statul>li:nth-child(5)>p:nth-child(2)")).Text);
            var huntBTN = driver.FindElement(By.Id("hunt"));
            huntBTN.Click();
            Console.ReadKey();
            int mood2 = Convert.ToInt32(driver.FindElement(By.CssSelector("#statul>li:nth-child(2)>p:nth-child(2)")).Text);
            int fatigue2 = Convert.ToInt32(driver.FindElement(By.CssSelector("#statul>li:nth-child(5)>p:nth-child(2)")).Text);
            if ((mood == mood2 - 40 || mood2==100) && (fatigue == fatigue2 + 20 || fatigue2==0))
            {
                Console.WriteLine("Mood level went up by 40, fatigue went down by 20");
            }
            else
            {
                Console.WriteLine("error");
            }
            #endregion

            #region pet
            var petBTN = driver.FindElement(By.Id("pet"));
            petBTN.Click();
            driver.SwitchTo().Alert().Accept();
            Console.ReadKey();
            mood = Convert.ToInt32(driver.FindElement(By.CssSelector("#statul>li:nth-child(2)>p:nth-child(2)")).Text);
            if (mood2 == mood - 20 || mood2==100)
            {
                Console.WriteLine("Mood level went up by 20");
            }
            else
            {
                Console.WriteLine("error");
            }
            #endregion

            #region medicine
            fatigue = Convert.ToInt32(driver.FindElement(By.CssSelector("#statul>li:nth-child(5)>p:nth-child(2)")).Text);
            var medicineBTN = driver.FindElement(By.Id("medicine"));
            medicineBTN.Click();
            driver.SwitchTo().Alert().Accept();
            Console.ReadKey();
            fatigue2 = Convert.ToInt32(driver.FindElement(By.CssSelector("#statul>li:nth-child(5)>p:nth-child(2)")).Text);
            mood2 = Convert.ToInt32(driver.FindElement(By.CssSelector("#statul>li:nth-child(2)>p:nth-child(2)")).Text);
            if ((fatigue == fatigue2 + 10 || fatigue2 == 0) && (mood==mood2 + 60 || mood2==0))
            {
                Console.WriteLine("Fatigue level went down by 10, mood level went down by 60");
            }
            else
            {
                Console.WriteLine("error");
            }
            #endregion

            #region sleep
            fatigue = Convert.ToInt32(driver.FindElement(By.CssSelector("#statul>li:nth-child(5)>p:nth-child(2)")).Text);
            var sleepBTN = driver.FindElement(By.Id("sleep"));
            sleepBTN.Click();
            driver.SwitchTo().Alert().Accept();
            Console.ReadKey();
            fatigue2 = Convert.ToInt32(driver.FindElement(By.CssSelector("#statul>li:nth-child(5)>p:nth-child(2)")).Text);
            thirst = Convert.ToInt32(driver.FindElement(By.CssSelector("#statul>li:nth-child(4)>p:nth-child(2)")).Text);
            hunger = Convert.ToInt32(driver.FindElement(By.CssSelector("#statul>li:nth-child(3)>p:nth-child(2)")).Text);
            if ((fatigue == fatigue2 - 60 || fatigue2==100) && (hunger2 == hunger+60 || hunger == 0) && (thirst2 == thirst + 60 || thirst == 0))
            {
                Console.WriteLine("Fatigue level went up by 70, hunger level went down by 60, thirst level went down by 60");
            }
            else
            {
                Console.WriteLine("error");
            }
            #endregion

            #region account page
            var accBTN = driver.FindElement(By.XPath("//a[@href='/account']"));
            accBTN.Click();
            if (driver.Url== "http://localhost:5174/account")
            {
                Console.WriteLine("Account page loaded successfully");
            }
            else
            {
                Console.WriteLine("Account page failed to load successfully");
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

            #region sign up
            var signupBTN = driver.FindElement(By.XPath("//a[@href='/signup']"));
            signupBTN.Click();
            if (driver.Url == "http://localhost:5174/signup")
            {
                Console.WriteLine("Sign up page loaded successfully");
            }
            else
            {
                Console.WriteLine("Sign up page failed to load successfully");
            }
            #endregion

            Console.ReadKey();
            driver.Close();
        }
    }
}
