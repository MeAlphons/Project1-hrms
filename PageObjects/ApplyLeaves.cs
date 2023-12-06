using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ApplyLeaves// apply new leave
{
    public ApplyLeaves(IWebDriver driver)
    {
        PageFactory.InitElements(driver, this);
    }
    [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/section[1]/div[2]/div[3]/div[1]/div[1]/div[1]/h5[1]/b[1]/a[1]")] IWebElement Leaves;
    [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/section[2]/div[2]/div[1]/div[1]/div[1]/a[1]/button[1]")] IWebElement addNew;
    [FindsBy(How = How.XPath, Using = "//span[@id='select2-leave_type-container']")] IWebElement Ltype;
    [FindsBy(How = How.XPath, Using = "//li[text()=' Medical']")] IWebElement medical;
    [FindsBy(How = How.XPath, Using = "//input[@class='form-control date hasDatepicker' and @name ='start_date']")] IWebElement Calendar;
    [FindsBy(How = How.XPath, Using = "//select[@class='ui-datepicker-month']")] IWebElement monthname;
    [FindsBy(How = How.XPath, Using = "//select[@class='ui-datepicker-year']")] IWebElement yearname;
    [FindsBy(How = How.XPath, Using = "//a[contains(text(),'15')]")] IWebElement Date;
    [FindsBy(How = How.XPath, Using = "//input[@class='form-control date hasDatepicker' and @name ='end_date']")] IWebElement ECalendar;
    [FindsBy(How = How.XPath, Using = "//select[@class='ui-datepicker-month']")] IWebElement Emonthname;
    [FindsBy(How = How.XPath, Using = "//select[@class='ui-datepicker-year']")] IWebElement Eyearname;
    [FindsBy(How = How.XPath, Using = "//a[contains(text(),'15')]")] IWebElement EDate;
    [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Choose an Employee')]")] IWebElement Emp_Name;
    [FindsBy(How = How.XPath, Using = " //body/span[1]/span[1]/span[1]/input[1]")] IWebElement Emp_Name_Data;
    [FindsBy(How = How.XPath, Using = "//span[@id='select2-aj_company-container']")] IWebElement Company_List;
    [FindsBy(How = How.XPath, Using = "//li[contains(text(),'CRROTHRM')]")] IWebElement Comp_Name;
    [FindsBy(How = How.XPath, Using = "//textarea[@id='reason']")] IWebElement L_reason;
    [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/section[2]/div[2]/div[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[1]/div[2]/div[1]/textarea[1]")] IWebElement remarks;
    [FindsBy(How = How.XPath, Using = "//ins[@class='iCheck-helper']")] IWebElement chkbox;
    [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/section[2]/div[2]/div[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[3]/button[1]")] IWebElement save;
    public void Leave_management()
    {
        Leaves.Click();
        addNew.Click();
        Ltype.Click();
        medical.Click();
        Calendar.Click();
        SelectElement Months = new SelectElement(monthname);
        Months.SelectByIndex(11);
        SelectElement Year = new SelectElement(yearname);
        Year.SelectByValue("2023");
        Date.Click();
        ECalendar.Click();
        SelectElement EMonths = new SelectElement(Emonthname);
        Months.SelectByIndex(11);
        SelectElement EYear = new SelectElement(Eyearname);
        Year.SelectByValue("2023");
        EDate.Click();
        Thread.Sleep(1000);
        Company_List.Click();
        Thread.Sleep(1000);
        Comp_Name.Click();
        Thread.Sleep(1000);
        Emp_Name.Click();
    }
    public void nameselection()
    {
        Emp_Name_Data.SendKeys("John Smith");
    }
    public void save_Form()
    {
        L_reason.SendKeys("Mandatory");
        remarks.SendKeys("Why should i tell to you, this is my LEAVES.Not yours!!");
        chkbox.Click();
        Thread.Sleep(1000);
        save.Click();
        Thread.Sleep(2000);
    }
}

