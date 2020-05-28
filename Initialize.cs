
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCsharp
{
    public class Initialize
    {

        public void FirstTest(string path)
        {
       IWebDriver driver = new ChromeDriver(Directory.GetCurrentDirectory() );

            driver.Navigate().GoToUrl("https://automationcurrypuff.home.blog");
        }
    }
}