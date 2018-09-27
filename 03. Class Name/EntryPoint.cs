using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPoint
{
    static void Main()
    {
        string url = "http://testing.todvachev.com/selectors/class-name/";
        string className = "testClass";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement elemento = driver.FindElement(By.ClassName(className));

        Console.WriteLine(elemento.Text);

        driver.Quit();
    }

    private static void MensagemVermelha(string mensagem)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(mensagem);
    }

    private static void MensagemVerde(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(mensagem);
    }
}

