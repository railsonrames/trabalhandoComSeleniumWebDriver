using OpenQA.Selenium.Interactions;

class EntryPoint
{
    public static string baseURL = "http://google.com.br";

    static void Main()
    {
        Actions.InitializerDriver();

        Driver.driver.Quit();
    }
}