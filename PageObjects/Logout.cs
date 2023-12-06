using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Logout
{
    public Logout(IWebDriver driver)
    {
        PageFactory.InitElements(driver, this);
    }
    [FindsBy(How = How.XPath, Using = "//body/div[1]/aside[1]/div[1]/section[1]/div[1]/div[2]/a[3]/i[1]")] IWebElement logout;
    public void log_out()
    {
        logout.Click();
    }
}

