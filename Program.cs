using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;

using Excel = Microsoft.Office.Interop.Excel;
namespace blockchain
{
    class Program
    {
        public static string fuseragent(int n)
        {
            string user = "Mozilla/5.0 (X11; CrOS armv7l 9592.96.0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.114 Safari/" + (300+n)+ ".36";
            return user;
        }
        public static string iuseragent(int n)
        {
            string user = "Mozilla/5.0 (Linux; U; Tizen 2.0; en-us) AppleWebKit/"+ (101 + n) +".1 (KHTML, like Gecko) Mobile TizenBrowser/2.0/";
            return user;
        }
        public static string cuseragent(int n)
        {
            string user = "Opera/9.80 (Linux armv7l) Presto/2.12."+(n+1)+" Version/12.51 , D50u-D1-UHD/V1.5.16-UHD (Vizio, D50u-D1, Wireless)" ;
            return user;
        }
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                
                ////////////////////////////////////
                try
                {
                    
                        string user1 = cuseragent(n);
                        FirefoxOptions options3 = new FirefoxOptions();
                        options3.SetPreference("general.useragent.override",   user1);

                  ///  options3.AddArguments("headless");
                    IWebDriver driver2 = new FirefoxDriver(options3);

                  //  var driverService = ChromeDriverService.CreateDefaultService();
                   // var driver = new ChromeDriver(driverService, new ChromeOptions());
                 //   driverService.HideCommandPromptWindow = true;
                    driver2.Navigate().GoToUrl("https://www.youtube.com/watch?v=brEq2Ux0cIo");
                        Actions builder = new Actions(driver2);
                    builder.SendKeys("m").Build().Perform();
                    System.Threading.Thread.Sleep(1000);
                    Actions builder1 = new Actions(driver2);
                    builder1.SendKeys(Keys.Space).Build().Perform();


                    //          System.Threading.Thread.Sleep(8000);
                    //      Actions builder3 = new Actions(driver2);
                    //        builder3.SendKeys(Keys.Space).Build().Perform();
                    System.Threading.Thread.Sleep(12000);
                    n++;
                    driver2.Quit();
                    Console.WriteLine(n);
                }
                catch (Exception e)
                {

                    Console.WriteLine("Could not find chrome.");
                }


            }

        }
    }
}
