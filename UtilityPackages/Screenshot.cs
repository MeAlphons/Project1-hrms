using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Events;
public class screenshots
{
    public void Screenshot_Name(IWebDriver driver, string name)
    {
        ITakesScreenshot ss = driver as ITakesScreenshot;
        Screenshot SS = ss.GetScreenshot();
        string save = "C:\\Users\\mejose\\source\\repos\\HRMS\\HRMS_Final_Proj\\ReportsAndDatas\\ScreenShots\\";
        SS.SaveAsFile(save + name, ScreenshotImageFormat.Jpeg);
    }
}
