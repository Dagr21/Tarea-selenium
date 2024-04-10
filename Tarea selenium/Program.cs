using System;
using System.IO;
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

            string imagesFolderPath = @"C:\Users\sacoc\Desktop\prog 3\Tarea selenium\fotos";

            // Verificar si la carpeta existe, si no, crearla
            if (!Directory.Exists(imagesFolderPath))
            {
                Directory.CreateDirectory(imagesFolderPath);
            }

            Action<string> takeScreenshot = (fileName) =>
            {
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                string filePath = Path.Combine(imagesFolderPath, fileName);
                screenshot.SaveAsFile(filePath);
            };

            // Prueba 1: Buscar en Google
            driver.Navigate().GoToUrl("https://www.google.com");
            IWebElement searchBoxGoogle = driver.FindElement(By.Name("q"));
            searchBoxGoogle.SendKeys("cómo hacer pan casero");
            searchBoxGoogle.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(5000);
            takeScreenshot("Prueba1.png");


            // Prueba 2: Ingresar a Wikipedia
            driver.Navigate().GoToUrl("https://www.wikipedia.org");
            IWebElement searchBoxWiki = driver.FindElement(By.Name("search"));
            searchBoxWiki.SendKeys("Inteligencia Artificial");
            searchBoxWiki.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(5000);
            takeScreenshot("Prueba2.png");



            // Prueba 3: Buscar en YouTube
            driver.Navigate().GoToUrl("https://www.youtube.com");
            IWebElement searchBoxYouTube = driver.FindElement(By.Name("search_query"));
            searchBoxYouTube.SendKeys("cómo hacer pan");
            searchBoxYouTube.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(5000);
            takeScreenshot("Prueba3.png");


            // Prueba 4: Buscar en Amazon
            driver.Navigate().GoToUrl("https://www.amazon.com");
            IWebElement searchBoxAmazon = driver.FindElement(By.Name("field-keywords"));
            searchBoxAmazon.SendKeys("cámara digital");
            searchBoxAmazon.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(5000);
            takeScreenshot("Prueba4.png");


            // Prueba 5: Interactuar con IMDb
            driver.Navigate().GoToUrl("https://www.imdb.com");
            IWebElement searchBoxIMDb = driver.FindElement(By.Name("q"));
            searchBoxIMDb.SendKeys("Titanic");
            searchBoxIMDb.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(5000);
            takeScreenshot("Prueba5.png");


        }
    } 
}