using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class DemoExcel
    {
        [Test]
        public void DemoExcelRead()
        {
            XLWorkbook book = new XLWorkbook(@"C:\Users\artig\Desktop\CSharp\AutomationFramework\EmployeeManagement\TestData\Orange_data.xlsx");
          IXLWorksheet sheet=  book.Worksheet("InvalidLoginTest");

            IXLRange range = sheet.RangeUsed();

            string value = range.Cell(2,1).GetString();
            Console.WriteLine(value);

            book.Dispose();
        }
    }
}
