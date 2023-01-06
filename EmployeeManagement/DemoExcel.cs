using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    //No needed 
    public class DemoExcel
    {
        [Test]
        public void DemoExcelRead()
        {
            XLWorkbook book = new XLWorkbook(@"C:\Users\artig\Desktop\CSharp\AutomationFramework\EmployeeManagement\TestData\Orange_data.xlsx");
          IXLWorksheet sheet=  book.Worksheet("InvalidLoginTest");

            IXLRange range = sheet.RangeUsed();

            int rowCount = range.RowCount();
            int columnCount = range.ColumnCount();

            //string value = range.Cell(2,1).GetString();
            //Console.WriteLine(value);

            object[] alldata = new object[3];

            for (int r=2; r<=4; r++)
            {
                string[] arr = new string[3];
                
                 

                for(int c=1; c<=3; c++)
                {
                    // Console.WriteLine(r);
                    //Console.WriteLine(c);
                    string value = range.Cell(r,c).GetString();
                    Console.WriteLine(value);

                    arr[c-1] = value;

                    // Console.WriteLine("------------------------------");

                }
                alldata[r-1] = arr;
                
            }

            
            book.Dispose();

            
        }
    }
}
