using Microsoft.Office.Interop.Excel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Meeting_Actions
{
    public Meeting_Actions(IWebDriver driver)
    {
        PageFactory.InitElements(driver, this);
    }
    [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Events & Meetings')]")] IWebElement Evn_Meet;
    [FindsBy(How = How.XPath, Using = "//body/div[1]/aside[1]/div[1]/section[1]/ul[1]/li[17]/ul[1]/li[2]/a[1]")] IWebElement Meetings;
    [FindsBy(How = How.XPath, Using = "//span[@id='select2-aj_company-container']")] IWebElement Company_List;
    [FindsBy(How = How.XPath, Using = "//li[contains(text(),'CRROTHRM')]")] IWebElement Comp_Name;
    [FindsBy(How = How.XPath, Using = "//span[@id='select2-select2-demo-6-container']")] IWebElement Emp;
    [FindsBy(How = How.XPath, Using = "//li[contains(text(),' John Smith')]")] IWebElement Emp_Name;
    [FindsBy(How = How.XPath, Using = "//input[@type='text' and @name='meeting_title']")] IWebElement meetings_Title;
    [FindsBy(How = How.XPath, Using = " //input[@name='meeting_date' and @class='form-control date hasDatepicker']")] IWebElement Meeting_Date;
    [FindsBy(How = How.XPath, Using = "//a[contains(text(),'13')]")] IWebElement date;
    [FindsBy(How = How.XPath, Using = "//input[@class='form-control timepicker' and @name='meeting_time']")] IWebElement time;
    [FindsBy(How = How.XPath, Using = "//body/div[18]/div[3]/div[1]/div[2]/div[4]")] IWebElement time_Hr_sel;
    [FindsBy(How = How.XPath, Using = "//div[contains(text(),'30')]")] IWebElement time_Min_sel;
    [FindsBy(How = How.XPath, Using = "//textarea[@id='meeting_note']")] IWebElement Meet_note;
    [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/form[1]/div[6]/button[1]")] IWebElement save;
    public void adding_meeting()
    {
        Thread.Sleep(8000);
        Evn_Meet.Click();
        Thread.Sleep(1000);
        Meetings.Click();
        Thread.Sleep(1000);
        Company_List.Click();
        Thread.Sleep(1000);
        Comp_Name.Click();
        Thread.Sleep(1000);
        Emp.Click();
        Thread.Sleep(1000);
        Emp_Name.Click();
        Thread.Sleep(1000);
        meetings_Title.SendKeys("Test_MJ_01012023");
        Thread.Sleep(1000);
        Meeting_Date.Click();
        Thread.Sleep(1000);
        date.Click();
        Thread.Sleep(1000);
        time.Click();
        Thread.Sleep(1000);
        time_Hr_sel.Click();
        Thread.Sleep(1000);
        time_Min_sel.Click();
        Thread.Sleep(1000);
        Meet_note.SendKeys("Mandatory");
        Thread.Sleep(1000);
        save.Click();
    }
}

