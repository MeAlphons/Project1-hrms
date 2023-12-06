using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

public class Validlog_In// login with valid data
{
    public Validlog_In(IWebDriver driver)
    {
        PageFactory.InitElements(driver, this);
    }
    [FindsBy(How = How.Id, Using = "iusername")]
    IWebElement username;
    [FindsBy(How = How.Id, Using = "ipassword")]
    IWebElement paaswd;
    [FindsBy(How = How.XPath, Using = "//button[@name='hrsale_form']")]
    IWebElement signin;

    public void validCred()
    {
        ExcelDatas datadriver = new ExcelDatas();
        string str1 = datadriver.emailId();
        string str2 = datadriver.pswd();
        username.SendKeys(str1);
        Thread.Sleep(1000);
        paaswd.SendKeys(str2);
    }
    public void Submit()
    {
        signin.Click();
        Thread.Sleep(1000);
    }
}

