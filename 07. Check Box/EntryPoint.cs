using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement checkBox;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/check-button-test-3/";
        string option = "3";
        driver.Navigate().GoToUrl(url);

        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child("+option+")"));
                   
        if (checkBox.GetAttribute("checked") == "true")
        {
            System.Console.WriteLine("O checkbox está marcado!");
        }
        else
        {
            System.Console.WriteLine("O checkbox não está marcado!");

        }

        driver.Quit();
    }
}