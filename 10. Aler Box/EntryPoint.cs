using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IAlert alert;

    static IWebElement image;

    public static object Tread { get; private set; }

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/alert-box/";

        driver.Navigate().GoToUrl(url);

        alert = driver.SwitchTo().Alert();

        System.Console.WriteLine(alert.Text);

        alert.Accept();

        image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));

        try
        {
            if (image.Displayed)
            {
                System.Console.WriteLine("O alerta foi aceito e eu posso ver a imagem!");
            }
        }
        catch (NoSuchElementException)
        {
            System.Console.WriteLine("Alguma bicheira happens!");
        }


        Thread.Sleep(2000);

        driver.Quit();
    }
}