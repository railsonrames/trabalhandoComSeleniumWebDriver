using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPoint
{
    static void Main()
    {
        string url = "http://testing.todvachev.com/selectors/css-path/";
        string cssPath = "#post-108 > div > fig img";
        string xPath = "//*[@id=\"post-108\"]/div/figure/img";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement elementoPeloCaminhoCSS;
        IWebElement elementoPeloXPath = driver.FindElement(By.XPath(xPath));

        try
        {
            elementoPeloCaminhoCSS = driver.FindElement(By.CssSelector(cssPath));
            if (elementoPeloCaminhoCSS.Displayed)
                MensagemVerde("Vejo o elemento pelo caminho do CSS!");
        }
        catch (NoSuchElementException)
        {
            MensagemVermelha("Não vejo o elemento pelo caminho do CSS!");
        }


        if (elementoPeloXPath.Displayed)
            MensagemVerde("Vejo o elemento pelo caminho do xPath!");
        else
            MensagemVermelha("Não vejo o elemento pelo caminho do xPath!");

        driver.Quit();
    }

    private static void MensagemVermelha(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(mensagem);
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    private static void MensagemVerde(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(mensagem);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}

