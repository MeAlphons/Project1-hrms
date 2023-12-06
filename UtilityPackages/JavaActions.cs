using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Events;

public class JavaActions
{
    public IJavaScriptExecutor js;
    public IWebDriver driver;
    public void ZoomingIn()
    {
        js = (IJavaScriptExecutor)driver;
        js.ExecuteScript("document.body.style.zoom='80%'");
    }
    public void scroll()
    {
        js = (IJavaScriptExecutor)driver;
        js.ExecuteScript("window.ScrollBy(document.body.scrollHeight,0));");
    }

}