using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Utilities
{
    public class DataSource
    {
        public static object[] InvalidLoginData()
        {
            string[] dataSet1 = new string[3];   
            dataSet1[0] = "john";
            dataSet1[1] = "john123";
            dataSet1[2] = "Invalid credentials";

            string[] dataSet2 = new string[3];        
            dataSet2[0] = "peter";
            dataSet2[1] = "peter123";
            dataSet2[2] = "Invalid credentials";

            string[] dataSet3 = new string[3];           
            dataSet3[0] = "saul";
            dataSet3[1] = "saul123";
            dataSet3[2] = "Invalid credentials";

            object[] allDataSet = new object[3];  
            allDataSet[0] = dataSet1;
            allDataSet[1] = dataSet2;
            allDataSet[2] = dataSet3;



            return allDataSet;
        }


        public static object[] AddValidEmployeeTest1()
        {
            string[] AddData1 = new string[6];
            AddData1[0] = "Admin";
            AddData1[1] = "admin123";
            AddData1[2] = "John";
            AddData1[3] = "W";
            AddData1[4] = "Wick";
            AddData1[5] = "John Wick";

            string[] AddData2 = new string[6];
            AddData2[0] = "Admin";
            AddData2[1] = "admin123";
            AddData2[2] = "Saul";
            AddData2[3] = "G";
            AddData2[4] = "Goodman";
            AddData2[5] = "Saul Goodman";

            object[] AddAll = new object[2];
           
            AddAll[0] = AddData1;
            AddAll[1]= AddData2;
            return AddAll;
        }

        public static object[] InvaliLoginData2()
        {
            //object[] data = ExcelUtils.GetSheetIntoObjectArray(@"C:\Users\artig\Desktop\CSharp\AutomationFramework\EmployeeManagement\TestData\Orange_data.xlsx", "InvalidLoginTest");

            object[] data = ExcelUtils.GetSheetIntoObjectArray(@"C:\Users\artig\Desktop\CSharp\AutomationFramework\EmployeeManagement\TestData\Orange_data.xlsx", "AddValidEmployeeTes");

            return data;
        }

    }
}
