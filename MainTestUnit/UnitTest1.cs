using AventStack.ExtentReports;

public class Tests : BrowserHandelingDatas
{
    [OneTimeSetUp]
    public void Browser_Launch()
    {
        reportsetup();
        ChromeBroserLoading();
    }
    [OneTimeTearDown]
    public void Browser_shut()
    {
        BrowserClosing();
        Closereport();
    }
    [Test, Order(1)]
    public void LoggingIn_InvalidCred()
    {
        test = extent.CreateTest("TC1- using invalid credentials").Info("invalid data entered");
        Invalid_Cred cred = new Invalid_Cred(driver);
        cred.InvalidCred();
        screenshots proof = new screenshots();
        proof.Screenshot_Name(driver, "Logging with invalid credentials");
        cred.sign_In_Invalid();
        proof.Screenshot_Name(driver, "error on page with invalid credentials");
        cred.clear_values();
        test.Log(Status.Error, "Data entered was incorrect");
    }
    [Test, Order(2)]
    public void LoggingIn_validCred()
    {
        test = extent.CreateTest("TC2- using valid credentials").Info("valid data entered");
        Validlog_In cred = new Validlog_In(driver);
        cred.validCred();
        screenshots proof = new screenshots();
        proof.Screenshot_Name(driver, "Logging with valid credentials");
        cred.Submit();
        proof.Screenshot_Name(driver, "logged into homepage");
        test.Log(Status.Pass, "Data entered was correct");
    }
    [Test, Order(3)]
    public void HeaderNavigations()
    {
        test = extent.CreateTest("TC3- header navigations").Info("navigate to messages forms");
        Navigation_Bars nav = new Navigation_Bars(driver);
        nav.navigate_Messages();
        screenshots proof = new screenshots();
        proof.Screenshot_Name(driver, "navigated to messages");
        test.Log(Status.Pass, "Message form loaded");
    }
    [Test, Order(4)]
    public void HeaderNavigations1()
    {
        test = extent.CreateTest("TC4- header navigations").Info("navigate to homepage forms");
        Navigation_Bars nav = new Navigation_Bars(driver);
        nav.navigate_Home();
        screenshots proof = new screenshots();
        proof.Screenshot_Name(driver, "navigated to homepage");
        test.Log(Status.Pass, "navigated to homepage");
    }
    [Test, Order(5)]
    public void HeaderNavigations2()
    {
        test = extent.CreateTest("TC5- header navigations").Info("navigate to user forms");
        Navigation_Bars nav = new Navigation_Bars(driver);
        nav.navigate_Man_Icon();
        screenshots proof = new screenshots();
        proof.Screenshot_Name(driver, "navigated to userdetails");
        test.Log(Status.Pass, "navigated to userdetails");
    }
    [Test, Order(6)]
    public void HeaderNavigations3()
    {
        test = extent.CreateTest("TC6- header navigations").Info("navigate to customerservice forms");
        Navigation_Bars nav = new Navigation_Bars(driver);
        nav.navigate_Cus_Servise();
        screenshots proof = new screenshots();
        proof.Screenshot_Name(driver, "navigated to customerservice");
        test.Log(Status.Pass, "navigated to customerservice");
    }
    [Test, Order(7)]
    public void Adding_Employee_Details()
    {
        test = extent.CreateTest("TC7- Adding employee").Info("new rmployee is adding");
        Staff_Actions staff = new Staff_Actions(driver);
        staff.employeelist();
        screenshots proof = new screenshots();
        proof.Screenshot_Name(driver, "employee list before adding new EMPL");
        staff.Add_Empl();
        staff.sex();
        MouseAction_Enter();
        staff.add_EMP_Save();
        staff.role_Selection();
        MouseAction_Enter();
        staff.leavetyps();
        staff.saving();
        proof.Screenshot_Name(driver, "employee list after adding new EMPL");
        Thread.Sleep(1000);
        navigate_back();
        test.Log(Status.Pass, "new employee is added to the list");
    }
    [Test, Order(8)]
    public void Employee_Report()
    {
        test = extent.CreateTest("TC8- Report of employees").Info("Employee Report");
        Staff_Actions staff = new Staff_Actions(driver);
        staff.employeelist();
        staff.reportEmployees();
        screenshots proof = new screenshots();
        proof.Screenshot_Name(driver, "employee report format form");
        ChildWindow();
        staff.Excel_Download();
        proof.Screenshot_Name(driver, "employee report downloading form");
        staff.Empl_Search();
        proof.Screenshot_Name(driver, "search in employee reports");
        staff.Empl_Search_Clear();
        proof.Screenshot_Name(driver, "Clear search in employee reports");
        Parentwindow();
        navigate_back();
        test.Log(Status.Pass, "new employee is added to the list");
    }
    [Test, Order(9)]
    public void apply_Leave()
    {
        test = extent.CreateTest("TC9- Apply leaves").Info("navigate leaves and applying leaves");
        ApplyLeaves al = new ApplyLeaves(driver);
        al.Leave_management();
        al.nameselection();
        MouseAction_Enter();
        al.save_Form();
        screenshots proof = new screenshots();
        proof.Screenshot_Name(driver, "apply medical leave");
        navigate_back();
        test.Log(Status.Pass, "Leave applied");
    }
    [Test, Order(10)]
    public void AddingRoles()
    {
        test = extent.CreateTest("TC10- add new role").Info("navigate roles and create role");
        AddnewRole ar = new AddnewRole(driver);
        ar.ANR_Save();
        screenshots proof = new screenshots();
        proof.Screenshot_Name(driver, "added new role");
        navigate_back();
        test.Log(Status.Pass, "new role added");
        test.Log(Status.Warning, "new role added already existing");
        test.Log(Status.Fail, "Unable to add new role");
    }
    [Test, Order(11)]
    public void AddMeeting()
    {
        test = extent.CreateTest("TC11- add new meeting").Info("navigate Events&Meetings and add new meeting");
        Meeting_Actions ma = new Meeting_Actions(driver);
        ma.adding_meeting();
        screenshots proof = new screenshots();
        proof.Screenshot_Name(driver, "added new meeting");
        navigate_back();
        test.Log(Status.Pass, "new meeting added");
    }
    [Test, Order(12)]
    public void Logout()
    {
        test = extent.CreateTest("TC12- logged out").Info("logging off");
        Logout lout = new Logout(driver);
        lout.log_out();
        screenshots proof = new screenshots();
        proof.Screenshot_Name(driver, "logout and quit browser");
        test.Log(Status.Pass, "logout and quit browser");
    }
}
