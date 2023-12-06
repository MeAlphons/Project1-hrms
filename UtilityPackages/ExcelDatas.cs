using Microsoft.Office.Interop.Excel;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

public class ExcelDatas
{
    public int row, column;
    public string email, password;
    public Excel.Application Excelapp;
    public Excel.Workbook wb;
    public Excel._Worksheet ws;
    Excel.Range values;

    public string emailId()
    {
        Excelapp = new Application();
        wb = Excelapp.Workbooks.Open(@"C:\Users\mejose\source\repos\HRMS\HRMS_Final_Proj\ReportsAndDatas\ExcelDatas\Data.xlsx");
        ws = (Excel._Worksheet)wb.Sheets[1];
        values = ws.UsedRange;
        row = ws.Rows.Count;
        column = ws.Columns.Count;

        email = values.Cells[2, 1].Value2.ToString();

        return email;
    }
    public string pswd()
    {
        Excelapp = new Application();
        wb = Excelapp.Workbooks.Open(@"C:\Users\mejose\source\repos\HRMS\HRMS_Final_Proj\ReportsAndDatas\ExcelDatas\Data.xlsx");
        ws = (Excel._Worksheet)wb.Sheets[1];
        values = ws.UsedRange;
        row = ws.Rows.Count;
        column = ws.Columns.Count;
        password = values.Cells[2, 2].Value2.ToString();

        return password;
    }

}
