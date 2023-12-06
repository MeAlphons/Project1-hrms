using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Staff_Actions
{
    public Staff_Actions(IWebDriver driver)
    {
        PageFactory.InitElements(driver, this);
    }
    [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Staff')]")] IWebElement staff;
    [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Employees')]")] IWebElement Employees;
    [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/section[2]/div[3]/div[1]/div[1]/div[1]/a[1]/button[1]")] IWebElement add_NewEmp;
    [FindsBy(How = How.XPath, Using = "//input[@name='first_name' and @class='form-control']")] IWebElement Emp_Fname;
    [FindsBy(How = How.XPath, Using = "//input[@name='last_name' and @class='form-control']")] IWebElement Emp_Lname;
    [FindsBy(How = How.XPath, Using = "//input[@name='employee_id' and @class='form-control']")] IWebElement Emp_ID;
    [FindsBy(How = How.XPath, Using = "//input[@name='date_of_joining' and @class='form-control date_of_joining hasDatepicker']")] IWebElement Calendar_DOJ;
    [FindsBy(How = How.XPath, Using = "//select[@class='ui-datepicker-month' and @data-handler='selectMonth']")] IWebElement DOJ_Month;
    [FindsBy(How = How.XPath, Using = "//select[@class='ui-datepicker-year' and @data-handler='selectYear']")] IWebElement DOJ_Year;
    [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[6]/a[1]")] IWebElement day;
    [FindsBy(How = How.XPath, Using = "//span[@id='select2-aj_company-container']")] IWebElement Company_List;
    [FindsBy(How = How.XPath, Using = "//li[contains(text(),'CRROTHRM')]")] IWebElement Comp_Name;
    [FindsBy(How = How.XPath, Using = "//span[@id='select2-aj_location_id-container']")] IWebElement Comp_Location;
    [FindsBy(How = How.XPath, Using = "//li[contains(text(),'Chennai Branch')]")] IWebElement Comp_Location_CHN;
    [FindsBy(How = How.XPath, Using = "//span[@id='select2-aj_subdepartments-container']")] IWebElement Emp_MD;
    [FindsBy(How = How.XPath, Using = "//li[contains(text(),'Accounts and  Finances')]")] IWebElement Emp_MD_Opt;
    [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Designation')]")] IWebElement Emp_Desig;
    [FindsBy(How = How.XPath, Using = "//li[contains(text(),'Developer')]")] IWebElement Emp_Desig_Opt;
    [FindsBy(How = How.XPath, Using = "//input[@name='username' and @class='form-control']")] IWebElement USER_Name;
    [FindsBy(How = How.XPath, Using = "//input[@name='email' and @class='form-control']")] IWebElement Emp_email;
    [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Male')]")] IWebElement Emp_Sex;
    [FindsBy(How = How.XPath, Using = "//body/span[1]/span[1]/span[1]/input[1]")] IWebElement Emp_Female;
    [FindsBy(How = How.XPath, Using = "//input[@name='date_of_birth']")] IWebElement Emp_DOB;
    [FindsBy(How = How.XPath, Using = "//select[@class='ui-datepicker-month' and @data-handler='selectMonth']")] IWebElement DOB_Month;
    [FindsBy(How = How.XPath, Using = "//select[@class='ui-datepicker-year' and @data-handler='selectYear']")] IWebElement DOB_Year;
    [FindsBy(How = How.XPath, Using = "//a[contains(text(),'26')]")] IWebElement DOB_Day;
    [FindsBy(How = How.XPath, Using = "//input[@class='form-control' and @name='contact_no']")] IWebElement Emp_Phone;
    [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Role')]")] IWebElement role;
    [FindsBy(How = How.XPath, Using = "//body/span[1]/span[1]/span[1]/input[1]")] IWebElement role_Selected;
    [FindsBy(How = How.XPath, Using = "//input[@class='select2-search__field']")] IWebElement Leave_Type;
    [FindsBy(How = How.XPath, Using = "//li[@class='select2-results__option']")] IWebElement CL;
    [FindsBy(How = How.XPath, Using = "//li[@class='select2-results__option select2-results__option--highlighted']")] IWebElement MedL;
    [FindsBy(How = How.XPath, Using = "//input[@class='form-control' and @name='password']")] IWebElement Emp_Pswd;
    [FindsBy(How = How.XPath, Using = "//input[@class='form-control' and @name='confirm_password']")] IWebElement Emp_Pswd_Confrm;
    [FindsBy(How = How.XPath, Using = "//input[@name='address' and @type='text']")] IWebElement Address;
    [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/section[2]/div[3]/div[1]/div[2]/div[1]/form[1]/div[2]/button[1]")] IWebElement Save;
    [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/section[2]/div[4]/div[1]/div[1]/button[1]")] IWebElement Reports;
    [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Employement Report')]")] IWebElement Emplment_Report;
    [FindsBy(How = How.XPath, Using = "//span[contains(text(),'CSV')]")] IWebElement Empl_Report_CSV_Format;
    [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Excel')]")] IWebElement Empl_Report_Excel_Format;
    [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/section[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/label[1]/input[1]")] IWebElement Empl_Report_Search;
    [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Print')]")] IWebElement Empl_Report_Print_Format;
    public void employeelist()
    {
        staff.Click();
        Thread.Sleep(1000);
        Employees.Click();
        Thread.Sleep(2000);

    }
    public void Add_Empl()
    {
        add_NewEmp.Click();
        Thread.Sleep(1000);
        Emp_Fname.SendKeys("Miss.MJ01");
        Thread.Sleep(1000);
        Emp_Lname.SendKeys("Test0312");
        Thread.Sleep(1000);
        Emp_ID.SendKeys("20K230527");
        Thread.Sleep(1000);
        Calendar_DOJ.Click();
        Thread.Sleep(1000);
        SelectElement Months = new SelectElement(DOJ_Month);
        Months.SelectByIndex(11);
        Thread.Sleep(1000);
        SelectElement Year = new SelectElement(DOJ_Year);
        Year.SelectByValue("2023");
        Thread.Sleep(1000);
        day.Click();
        Thread.Sleep(1000);
        Company_List.Click();
        Thread.Sleep(1000);
        Comp_Name.Click();
        Thread.Sleep(1000);
        Comp_Location.Click();
        Thread.Sleep(1000);
        Comp_Location_CHN.Click();
        Thread.Sleep(1000);
        Emp_MD.Click();
        Thread.Sleep(1000);
        Emp_MD_Opt.Click();
        Thread.Sleep(1000);
        Emp_Desig.Click();
        Thread.Sleep(1000);
        Emp_Desig_Opt.Click();
        Thread.Sleep(1000);
        USER_Name.SendKeys("MJ_User");
        Thread.Sleep(1000);
        Emp_email.SendKeys("Test12032023@hrms.com");
        Thread.Sleep(1000);
        Thread.Sleep(1000);
    }
    public void sex()
    {
        Emp_Sex.Click();
        Thread.Sleep(1000);
        Emp_Female.SendKeys("Female");
    }
    public void add_EMP_Save()
    {
        Thread.Sleep(1000);
        Emp_DOB.Click();
        Thread.Sleep(1000);
        SelectElement DOBMonths = new SelectElement(DOB_Month);
        Thread.Sleep(1000);
        DOBMonths.SelectByIndex(6);
        Thread.Sleep(1000);
        SelectElement DOBYear = new SelectElement(DOB_Year);
        Thread.Sleep(1000);
        DOBYear.SelectByValue("2003");
        Thread.Sleep(1000);
        DOB_Day.Click();
        Emp_Phone.SendKeys("9823455455");
        Thread.Sleep(1000);
        Emp_Pswd.SendKeys("Password@123");
        Thread.Sleep(1000);
        Emp_Pswd_Confrm.SendKeys("Password@123");
    }
    public void role_Selection()
    {
        role.Click();
        role_Selected.SendKeys("Super Admin");

    }
    public void leavetyps()
    {
        Leave_Type.Click();
        //CL.Click();
        MedL.Click();
        Thread.Sleep(1000);
    }
    public void saving()
    {
        Address.SendKeys("A block, 2nd Floor,Trivandrum");
        Save.Click();
        Thread.Sleep(1000);
    }

    public void reportEmployees()
    {

        Reports.Click();
        Thread.Sleep(2000);
        Emplment_Report.Click();
        Thread.Sleep(2000);
    }
    public void Excel_Download()
    {
        Empl_Report_CSV_Format.Click();
        Empl_Report_Excel_Format.Click();
    }
    public void Empl_Search()
    {
        Empl_Report_Search.SendKeys("Miss");
    }
    public void Empl_Search_Clear()
    {
        Empl_Report_Search.Clear();
        //Empl_Report_Print_Format.Click();
    }
}

