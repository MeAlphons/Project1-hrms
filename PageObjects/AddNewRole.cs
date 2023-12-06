using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AddnewRole//create new role
{
    public AddnewRole(IWebDriver driver)
    {
        PageFactory.InitElements(driver, this);
    }
    [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/section[1]/div[2]/div[2]/div[1]/div[1]/div[1]/h5[1]/b[1]/a[1]")]
    IWebElement Roles;
    [FindsBy(How = How.XPath, Using = "//button[@type='button' and @class='btn btn-xs btn-primary']")] IWebElement addnew;
    [FindsBy(How = How.XPath, Using = "//input[@name='role_name' and @class='form-control']")] IWebElement roleN;
    [FindsBy(How = How.Id, Using = "select2-role_access-container")] IWebElement access;
    [FindsBy(How = How.XPath, Using = "//li[text()='Custom Menu Access']")] IWebElement ddvalue1;
    [FindsBy(How = How.XPath, Using = "//button[@name='hrsale_form']")] IWebElement save;
    [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and@value='103']")] IWebElement chkbx1;
    [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and@value='97']")] IWebElement chkbx2;
    [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and@value='43']")] IWebElement chkbx3;
    [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and@value='89']")] IWebElement chkbx4;
    public void ANR_Save()
    {
        Roles.Click();
        Thread.Sleep(1000);
        addnew.Click();
        Thread.Sleep(1000);
        roleN.SendKeys("Test_MJ_02");
        access.Click();
        Thread.Sleep(1000);
        ddvalue1.Click();
        Thread.Sleep(1000);
        chkbx1.Click();
        Thread.Sleep(1000);
        chkbx2.Click();
        Thread.Sleep(1000);
        chkbx3.Click();
        Thread.Sleep(1000);
        chkbx4.Click();
        Thread.Sleep(1000);
        save.Click();
    }

}

