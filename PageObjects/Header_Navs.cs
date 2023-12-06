using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Navigation_Bars
{
    public Navigation_Bars(IWebDriver driver)
    {
        PageFactory.InitElements(driver, this);
    }
    [FindsBy(How = How.XPath, Using = "//b[contains(text(),'Demo HRMS')]")] IWebElement LOGO;
    [FindsBy(How = How.XPath, Using = "//header/nav[1]/div[1]/ul[1]/li[1]/a[1]/i[1]")] IWebElement messages;
    [FindsBy(How = How.XPath, Using = "//header/nav[1]/div[1]/ul[1]/li[5]/a[1]/img[1]")] IWebElement man_Icon;
    [FindsBy(How = How.XPath, Using = "//header/nav[1]/div[1]/ul[1]/li[3]/a[1]/i[1]")] IWebElement cus_Servise;
    public void navigate_Home() { LOGO.Click(); }
    public void navigate_Messages() { messages.Click();}
    public void navigate_Man_Icon()
    { man_Icon.Click(); }
    public void navigate_Cus_Servise()
    { cus_Servise.Click(); }



}



