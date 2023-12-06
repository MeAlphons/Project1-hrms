using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

public class BrowserHandelingDatas
{
    public IWebDriver driver;
    public IJavaScriptExecutor js;
    public ExtentReports extent;
    public ExtentTest test;
    public void ChromeBroserLoading()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Url = "http://hrm.qabible.in/hrms/admin";
        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
    }
    public void BrowserClosing()
    {
        Thread.Sleep(1000);
        driver.Quit();
    }
    public void Parentwindow()
    {
        List<string> Child = driver.WindowHandles.ToList();
        string Child1 = Child[0];
        driver.SwitchTo().Window(Child1);
    }
    public void ChildWindow()
    {
        List<string> Child = driver.WindowHandles.ToList();
        string Child1 = Child[1];
        driver.SwitchTo().Window(Child1);
       
    }
    public void EdgeBroserLoading()
    {
        driver = new EdgeDriver();
        driver.Manage().Window.Maximize();
        driver.Url = "http://hrm.qabible.in/hrms/admin";
        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
    }
    public void FfBroserLoading()
    {
        driver = new FirefoxDriver();
        driver.Manage().Window.Maximize();
        driver.Url = "http://hrm.qabible.in/hrms/admin";
        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
    }
    public void MouseAction_Enter()
    {
        Actions act = new Actions(driver);
        act.KeyDown(Keys.Enter).Perform();
    }
    public void MouseAction_scroll()
    {
        Actions act = new Actions(driver);
        act.KeyDown(Keys.PageDown).Perform();
    }
    public void scrollto()
    {
        js = (IJavaScriptExecutor)driver;
        js.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");
    }
    public void navigate_back()
    {
        driver.Navigate().Back();       
    }
    public void navigate_forward() 
    {
        driver.Navigate().Forward();
    }
    public void navigate_Refresh()
    {
        driver.Navigate().Refresh();
    }
    public void reportsetup()
    {
        var path = new ExtentHtmlReporter(@"C:\Users\mejose\source\repos\HRMS\HRMS_Final_Proj\ReportsAndDatas\Reports\extentReport.html");
        extent = new ExtentReports();
        extent.AttachReporter(path);
    }
    public void Closereport()
    {
        extent.Flush();
    }
}