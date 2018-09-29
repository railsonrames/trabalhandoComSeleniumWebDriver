using System;
using System.Reflection;
using System.Threading;

namespace _11.AutoTest
{
    public static class TestList
    {
        public static void ValidaLogin(bool stayLoggedIn, bool closeBrowserWhenFinished)
        {
            LoginFormElements loginForm = new LoginFormElements();

            Actions.NavToLoginForm();

            loginForm.emailField.SendKeys(@"t@gmail.com");
            loginForm.passwordField.SendKeys("1234567");
            loginForm.loginButton.Click();

            if (stayLoggedIn == false)
            {
                Actions.LogOut();
            }

            if (closeBrowserWhenFinished == true)
            {
                Actions.CloseBrowser();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Login com atributos válidos passou!");
            Console.ResetColor();
        }

        public static void InvalidLogin(bool closeBrowaserWhenFinished)
        {
            LoginFormElements loginForm = new LoginFormElements();
            HomePageElements homePage = new HomePageElements();

            Actions.NavToLoginForm();

            loginForm.emailField.SendKeys(@"t@gmail.com");
            loginForm.passwordField.SendKeys("12345678");
            loginForm.loginButton.Click();

            Thread.Sleep(300);

            try
            {
                homePage.playButton.Click();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Login com parâmetros inválidos, passou!");
                Console.ResetColor();
            }
            catch (TargetInvocationException) // Excessão de elemento não clickavel.
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Login com parâmetros inválidos, não passou!");
                Console.ResetColor();
            }

            if (closeBrowaserWhenFinished == true)
            {
                Actions.CloseBrowser();
            }
        }

        public static void ValidRegistration(string username, string password, string email, bool closeBrowserWhenFinished)
        {

        }
    }
}
