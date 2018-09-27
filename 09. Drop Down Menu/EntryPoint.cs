using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement dropDownMenu;
    static IWebElement elementFromTheDropDownMenu;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/drop-down-menu-test/";
        string indice = "2";
        string dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child("+indice+")";
        driver.Navigate().GoToUrl(url);

        dropDownMenu = driver.FindElement(By.Name("DropDownTest"));

        System.Console.WriteLine("O valor selecionado é: "+dropDownMenu.GetAttribute("value"));

        elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));

        System.Console.WriteLine("A "+indice+"ª opção do menu é: "+elementFromTheDropDownMenu.GetAttribute("value"));
        Thread.Sleep(3000);
        elementFromTheDropDownMenu.Click();

        System.Console.WriteLine("O valor selecionado é: "+dropDownMenu.GetAttribute("value"));
        Thread.Sleep(3000);

        for (int i = 1; i < 5; i++)
        {
            dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(" + i + ")";
            elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));
            System.Console.WriteLine("O valor do "+i+"º elemento do menu é: "+elementFromTheDropDownMenu.GetAttribute("value"));
        }
        Thread.Sleep(15000);

        driver.Quit();
    }
}