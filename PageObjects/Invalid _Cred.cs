using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Invalid_Cred// login with invalid data
{

    public Invalid_Cred(IWebDriver driver)
    {
        PageFactory.InitElements(driver, this);
    }
    [FindsBy(How = How.Id, Using = "iusername")] IWebElement username;
    [FindsBy(How = How.Id, Using = "ipassword")] IWebElement pswd;
    [FindsBy(How = How.XPath, Using = "//button[@name='hrsale_form']")] IWebElement signin;

    public void InvalidCred()
    {
        username.SendKeys("wwww");
        Thread.Sleep(1000);
        pswd.SendKeys("234");
        Thread.Sleep(1000);
    }
    public void sign_In_Invalid()
    {
        signin.Click();
    }
    public void clear_values()
    {
        username.Clear();
        Thread.Sleep(1000);
        pswd.Clear();
    }
}

