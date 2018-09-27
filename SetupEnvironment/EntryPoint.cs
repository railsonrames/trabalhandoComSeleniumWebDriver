using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://testing.todvachev.com/selectors/name/");

        IWebElement element = driver.FindElement(By.Name("myName"));

        if (element.Displayed)
        {
            MensagemVerde("Sucesso, eu posso ver o elemento!");
        }
        else
        {
            MensagemVermelha("Falhou, alguma bicheira aconteceu!");
        }

        driver.Quit();
    }

    private static void MensagemVermelha(string mensagem)
    {
        
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(mensagem);     
        Console.BackgroundColor = backupDeCor;
    }

    private static void MensagemVerde(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(mensagem);
    }
}