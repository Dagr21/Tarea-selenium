using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tarea_selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            IWebDriver driver = new ChromeDriver(options);
            System.Threading.Thread.Sleep(3000);

            // Prueba 1: Buscar en Google
            driver.Navigate().GoToUrl("https://www.google.com");
            IWebElement searchBoxGoogle = driver.FindElement(By.Name("q"));
            searchBoxGoogle.SendKeys("cómo hacer pan casero");
            searchBoxGoogle.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(5000);

            // Prueba 2: Ingresar a Wikipedia
            driver.Navigate().GoToUrl("https://www.wikipedia.org");
            IWebElement searchBoxWiki = driver.FindElement(By.Name("search"));
            searchBoxWiki.SendKeys("Inteligencia Artificial");
            searchBoxWiki.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(5000);

            // Prueba 3: Buscar en YouTube
            driver.Navigate().GoToUrl("https://www.youtube.com");
            IWebElement searchBoxYouTube = driver.FindElement(By.Name("search_query"));
            searchBoxYouTube.SendKeys("cómo hacer pan");
            searchBoxYouTube.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(5000);

            // Prueba 4: Buscar en Amazon
            driver.Navigate().GoToUrl("https://www.amazon.com");
            IWebElement searchBoxAmazon = driver.FindElement(By.Name("field-keywords"));
            searchBoxAmazon.SendKeys("cámara digital");
            searchBoxAmazon.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(5000);

            // Prueba 5: Interactuar con IMDb
            driver.Navigate().GoToUrl("https://www.imdb.com");
            IWebElement searchBoxIMDb = driver.FindElement(By.Name("q"));
            searchBoxIMDb.SendKeys("Titanic");
            searchBoxIMDb.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(5000);

        }
    } 
}