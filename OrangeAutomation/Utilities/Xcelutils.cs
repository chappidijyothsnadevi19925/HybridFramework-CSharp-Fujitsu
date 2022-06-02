﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace OrangeAutomation.Utilities
{
    public class ExcelUtils
    {
        public static object[] GetSheetIntoObjectArray()
        {
            using (XLWorkbook book = new XLWorkbook(@"C:\Selenium Session\OrangeAutomation\OrangeAutomation\TestData\orange_data.xlsx"))
            {
                var sheet = book.Worksheet("InvalidCredentialTest");
                var range = sheet.RangeUsed();

                int rowCount = range.RowCount();
                int columnCount = range.ColumnCount();
                //size is based on numbe of test case - (rowcount-1)
                object[] main = new object[rowCount - 1];

                for (int r = 2; r <= rowCount; r++)
                {
                    //size is based on colcount //number of arguments
                    object[] set = new object[columnCount];

                    for (int c = 1; c <= columnCount; c++)
                    {
                        string value = range.Cell(r, c).GetString();

                        set[c - 1] = value;
                    }
                    main[r - 2] = set;
                }
                return main;
            }

        }
    }
}






/*using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeAutomation.Utilities
{
    internal class Xcelutils
    {
        public static object[] GetSheetIntObjectArray(string file,string sheetname)
        {
            using (XLWorkbook book = new XLWorkbook(file))
            {
                var sheet = book.Worksheet(sheetname);
                var range = sheet.RangeUsed();

                int rowCount = range.RowCount();
                int columnCount = range.ColumnCount();
                //size is based on numbe of test case - (rowcount-1)
                object[] main = new object[rowCount - 1];

                for (int r = 2; r <= rowCount; r++)
                {
                    //size is based on colcount //number of arguments
                    object[] set = new object[columnCount];

                    for (int c = 1; c <= columnCount; c++)
                    {
                        string value = range.Cell(r, c).GetString();

                        set[c - 1] = value;
                    }
                    main[r - 2] = set;
                }
                return main;
            }
        }
        public static string GetCellValue(string file,string sheetname,int rowNumber,string sheetname)
        {

        }

        internal static object[] GetSheetIntObjectArray(string v)
        {
            throw new NotImplementedException();
        }
    }
}*/
