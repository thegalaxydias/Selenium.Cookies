using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace Selenium.Cookies
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://itechcraft.com/");

            driver.Manage().Cookies.AddCookie(new Cookie("lol", "loooool"));
        
            Cookie cookie = driver.Manage().Cookies.GetCookieNamed("lol");
           
            Console.WriteLine("KYKU = " + cookie.Value);
            driver.Quit();
        }
    }
}
