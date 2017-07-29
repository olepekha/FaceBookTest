using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Diagnostics;

namespace FaceBookTest
{
    [TestFixture]
    public class FBLogin
    {
        IWebDriver driver;
        WebDriverWait waitf;
        TimeSpan t = new TimeSpan(0, 0, 10);//for timer set

        [OneTimeSetUp]
        public void Init()
        {
            driver = new ChromeDriver();
            var waitChr = new WebDriverWait(driver, t);
             }
        [Test]
    
    public void LoginTest()
        {}
    
        [OneTimeTearDown]
        public void CloseAppTest() //method to close app
        {
            Debug.WriteLine("TearDown");
            driver.Quit();
        }
    }
}
