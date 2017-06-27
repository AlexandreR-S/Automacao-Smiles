using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Microsoft.Office.Interop.Excel;

namespace POCSmiles
{
	public class ExcelRanorex
	{
                //Requires Microsoft.Office.Interop.Excel COM Reference

        public static Microsoft.Office.Interop.Excel.Application OpenExcel()
        {
            /************************************************************************
             * Function         : OpenExcel()
             *
             * Description      : This method will open and return an Excel COM object. 
             *                         
             * Parameters       : N/A
             *                  
             * Return Type      : Microsoft.Office.Interop.Excel.Application
             * 
             * Return Value     : Valid Excel Object for success, null for failure
             * 
             * Revision History
             * Date       : Author                    : Reason/Change
             * ---------- : ------------------------- : ------------------------------
             * 03/23/2009 : Chris Gendreau            : Initial Creation 
             ************************************************************************/
            Microsoft.Office.Interop.Excel.Application objXL;

            try
            {
                //Create the Excel Object
                objXL = new Microsoft.Office.Interop.Excel.Application();

                //Return the Excel Object
                return objXL;
            }
            catch (Exception ex)
            {
                Report.Failure("Unable to open Excel: " + ex.ToString());
                return null;
            }
        } //End OpenExcel

        public static Microsoft.Office.Interop.Excel.Workbook OpenExcelWorkbook(Microsoft.Office.Interop.Excel.Application objXL, string strExcelFileName)
        {
            /************************************************************************
             * Function         : OpenExcelWorkbook()
             *
             * Description      : This method will open and return an Excel Workbook COM object. 
             *                         
             * Parameters       : objXL             - An existing Excel Object
             *                  : strExcelFileName  - path & filename of the Excel Workbook
             *                  
             * Return Type      : Microsoft.Office.Interop.Excel.Workbook
             * 
             * Return Value     : Valid Excel Workbook Object for success, null for failure
             * 
             * Revision History
             * Date       : Author                    : Reason/Change
             * ---------- : ------------------------- : ------------------------------
             * 07/10/2009 : Chris Gendreau            : Initial Creation 
             * 11/30/2009 : Chris Gendreau            : Added objXLWorkBook.Saved = true
             ************************************************************************/
            Microsoft.Office.Interop.Excel.Workbook objXLWorkBook;

            if (objXL != null)
            {
                try
                {
                	objXL.DisplayAlerts = false;
                    objXLWorkBook = objXL.Workbooks.Open(strExcelFileName, 0, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value, true, false,
                        System.Reflection.Missing.Value, false, false, false);

                    //Mark the workbook as saved so that the "Do you want to save" dialog does not appear.
                    objXLWorkBook.Saved = true;

                    //Return the Excel Workbook Object
                    return objXLWorkBook;
                }
                catch (Exception ex)
                {
                    Report.Failure("Unable to open Excel: " + ex.ToString());
                    return null;
                }
            }
            return null;
        } //End OpenExcelWorkbook

        public static string ExcelReadSingleCell(string strExcelFileName, string strCell)
        {
            string ReturnString = ExcelReadSingleCell(strExcelFileName, strCell, "");
            return ReturnString;
        }
        public static string ExcelReadSingleCell(string strExcelFileName, string strCell, string strSheet)
        {
            /************************************************************************
             * Function         : ExcelReadSingleCell(string strExcelFileName, string strCell, string strSheet)
             *
             * Description      : This method will read and return the data of a single cell 
             *                  :  in the specified Excel workbook.
             *                         
             * Parameters       : strExcelFileName  - Full path and filename of the Excel spreadsheet to open
             *                  : strCell           - Cell to return (i.e. "A1")
             *                  : strSheet          - OPTIONAL - Name of the sheet in the spreadsheet the cell is on
             *                  :                   -            If not supplied will default to the 1st sheet.
             *                  
             * Return Type      : String
             * 
             * Return Value     : Data from the cell for success, null for failure
             * 
             * Revision History
             * Date       : Author                    : Reason/Change
             * ---------- : ------------------------- : ------------------------------
             * 03/23/2009 : Chris Gendreau            : Initial Creation 
             ************************************************************************/

            Microsoft.Office.Interop.Excel.Application objXL;
            Microsoft.Office.Interop.Excel.Workbook objXLWorkBook;
            Microsoft.Office.Interop.Excel.Sheets objXLSheets;
            Microsoft.Office.Interop.Excel.Worksheet objXLWorkSheet;
            Microsoft.Office.Interop.Excel.Range objXLRange;

            if (strSheet == "")
            {
                Report.Debug("Reading data from Cell: '" + strCell + "' in spreadsheet: '" + strExcelFileName + "' on sheet: '1'.");
            }
            else
            {
                Report.Debug("Reading data from Cell: '" + strCell + "' in spreadsheet: '" + strExcelFileName + "' on sheet: '" + strSheet + "'.");
            }

            //Open Excel
            objXL = OpenExcel();

            if (objXL != null)
            {
                try
                {
                	objXL.DisplayAlerts = false;
                    //Open the Excel Workbook
                    objXLWorkBook = objXL.Workbooks.Open(strExcelFileName, 0, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value, true, false,
                        System.Reflection.Missing.Value, false, false, false);

                    //Get the sheets from the workbook
                    objXLSheets = objXLWorkBook.Sheets;

                    if (strSheet == "")
                    {
                        //Select the first worksheet
                        objXLWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)objXLSheets[1];
                    }
                    else
                    {
                        //Select the requested worksheet
                        objXLWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)objXLSheets[strSheet];
                    }

                    //Select the cell in the workbook
                    objXLRange = (Microsoft.Office.Interop.Excel.Range)objXLWorkSheet.get_Range(strCell + ":" + strCell, Type.Missing);

                    //Read the data from the cell
                    string ExcelString = objXLRange.Cells.Value2.ToString();

                    ////Print the value of the cell for a single cell selection
                    //Console.WriteLine(" Text in cell " + strCell + " is: " + ExcelString);

                    //Close Excel
                    objXL.Quit();

                    //Return the data
                    return ExcelString;
                }

                catch (Exception ex)
                {
                    String errorMessage;
                    errorMessage = "Error: ";
                    errorMessage = String.Concat(errorMessage, ex.Message);
                    errorMessage = String.Concat(errorMessage, " Line: ");
                    errorMessage = String.Concat(errorMessage, ex.Source);
                    errorMessage = String.Concat(errorMessage, ex.ToString());

                    Report.Failure("Error reading a cell from Excel: " + errorMessage);

                    //Close Excel
                    objXL.Quit();

                    return null;
                }
            }
            return null;
        } //End ExcelReadSingleCell

        public static int ExcelWriteSingleCell(string strExcelFileName, string strCell, string strData)
        {
            int ReturnInt = ExcelWriteSingleCell(strExcelFileName, strCell, strData, "");
            return ReturnInt;
        }
        public static int ExcelWriteSingleCell(string strExcelFileName, string strCell, string strData, string strSheet)
        {
            /************************************************************************
             * Function         : ExcelWriteSingleCell(string strExcelFileName, string strCell, string strData, string strSheet)
             *
             * Description      : This method will write the data specified to a single cell 
             *                  :  in the specified Excel workbook.
             *                         
             * Parameters       : strExcelFileName  - Full path and filename of the Excel spreadsheet to open
             *                  : strCell           - Cell to write to (i.e. "A1")
             *                  : strData           - Data to write to the cell
             *                  : strSheet          - OPTIONAL - Name of the sheet in the spreadsheet the cell is on
             *                  :                   -            If not supplied will default to the 1st sheet.
             *                  
             * Return Type      : Integer
             * 
             * Return Value     : 0 for success, -1 for failure
             * 
             * Revision History
             * Date       : Author                    : Reason/Change
             * ---------- : ------------------------- : ------------------------------
             * 03/23/2009 : Chris Gendreau            : Initial Creation 
             ************************************************************************/

            Microsoft.Office.Interop.Excel.Application objXL;
            Microsoft.Office.Interop.Excel.Workbook objXLWorkBook;
            Microsoft.Office.Interop.Excel.Sheets objXLSheets;
            Microsoft.Office.Interop.Excel.Worksheet objXLWorkSheet;
            Microsoft.Office.Interop.Excel.Range objXLRange;

            if (strSheet == "")
            {
                Report.Debug("Writing data to Cell: '" + strCell + "' in spreadsheet: '" + strExcelFileName + "' on sheet: '1'.");
            }
            else
            {
                Report.Debug("Writing data to Cell: '" + strCell + "' in spreadsheet: '" + strExcelFileName + "' on sheet: '" + strSheet + "'.");
            }

            //Open Excel
            objXL = OpenExcel();

            if (objXL != null)
            {
                try
                {
                	objXL.DisplayAlerts = false;
                    //Open the Excel Workbook
                    objXLWorkBook = objXL.Workbooks.Open(strExcelFileName, 0, false, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value, true, false,
                        System.Reflection.Missing.Value, false, false, false);
                    
                    //Get the sheets from the workbook
                    objXLSheets = objXLWorkBook.Sheets;

                    if (strSheet == "")
                    {
                        //Select the first worksheet
                        objXLWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)objXLSheets[1];
                    }
                    else
                    {
                        //Select the requested worksheet
                        objXLWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)objXLSheets[strSheet];
                    }

                    //Select the cell in the workbook
                    objXLRange = (Microsoft.Office.Interop.Excel.Range)objXLWorkSheet.get_Range(strCell + ":" + strCell, Type.Missing);

                    //Write to the cell
                    objXLRange.Cells.Value2 = strData;
                    
                    //Save the Workbook
                    objXLWorkBook.Save();

                    //Close Excel
                    objXL.Quit();

                    //Return success
                    return 0;
                }

                catch (Exception ex)
                {
                    String errorMessage;
                    errorMessage = "Error: ";
                    errorMessage = String.Concat(errorMessage, ex.Message);
                    errorMessage = String.Concat(errorMessage, " Line: ");
                    errorMessage = String.Concat(errorMessage, ex.Source);
                    errorMessage = String.Concat(errorMessage, ex.ToString());

                    Report.Failure("Error writing to a cell in Excel: " + errorMessage);

                    //Close Excel
                    objXL.Quit();

                    return -1;
                }
            }
            return -1;
        } //End ExcelWriteSingleCell
        
        public static int ExcelWriteCountA(string strExcelFileName, string strCell, string range, string strSheet)
        {
            /************************************************************************
             * Function         : ExcelWriteSingleCell(string strExcelFileName, string strCell, string strData, string strSheet)
             *
             * Description      : This method will write the data specified to a single cell 
             *                  :  in the specified Excel workbook.
             *                         
             * Parameters       : strExcelFileName  - Full path and filename of the Excel spreadsheet to open
             *                  : strCell           - Cell to write to (i.e. "A1")
             *                  : strData           - Data to write to the cell
             *                  : strSheet          - OPTIONAL - Name of the sheet in the spreadsheet the cell is on
             *                  :                   -            If not supplied will default to the 1st sheet.
             *                  
             * Return Type      : Integer
             * 
             * Return Value     : 0 for success, -1 for failure
             * 
             * Revision History
             * Date       : Author                    : Reason/Change
             * ---------- : ------------------------- : ------------------------------
             * 03/23/2009 : Chris Gendreau            : Initial Creation 
             ************************************************************************/

            Microsoft.Office.Interop.Excel.Application objXL;
            Microsoft.Office.Interop.Excel.Workbook objXLWorkBook;
            Microsoft.Office.Interop.Excel.Sheets objXLSheets;
            Microsoft.Office.Interop.Excel.Worksheet objXLWorkSheet;
            Microsoft.Office.Interop.Excel.Range objXLRange;
            Microsoft.Office.Interop.Excel.Range objXLRangeFormula;

            if (strSheet == "")
            {
                Report.Debug("Writing data to Cell: '" + strCell + "' in spreadsheet: '" + strExcelFileName + "' on sheet: '1'.");
            }
            else
            {
                Report.Debug("Writing data to Cell: '" + strCell + "' in spreadsheet: '" + strExcelFileName + "' on sheet: '" + strSheet + "'.");
            }

            //Open Excel
            objXL = OpenExcel();

            if (objXL != null)
            {
                try
                {
                	objXL.DisplayAlerts = false;
                    //Open the Excel Workbook
                    objXLWorkBook = objXL.Workbooks.Open(strExcelFileName, 0, false, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value, true, false,
                        System.Reflection.Missing.Value, false, false, false);
                    //Get the sheets from the workbook
                    objXLSheets = objXLWorkBook.Sheets;

                    if (strSheet == "")
                    {
                        //Select the first worksheet
                        objXLWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)objXLSheets[1];
                    }
                    else
                    {
                        //Select the requested worksheet
                        objXLWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)objXLSheets[strSheet];
                    }

                    //Select the cell in the workbook
                    objXLRangeFormula = (Microsoft.Office.Interop.Excel.Range)objXLWorkSheet.get_Range(range, Type.Missing);
                    objXLRange = (Microsoft.Office.Interop.Excel.Range)objXLWorkSheet.get_Range(strCell, Type.Missing);

                    //Write to the cell
//                    objXLRange.Cells.Value2 = objXL.WorksheetFunction.CountA(range);
					objXLRange.Cells.Value2 = objXL.WorksheetFunction.CountA(objXLRangeFormula);
                    
                    //Save the Workbook
                    objXLWorkBook.Save();

                    //Close Excel
                    objXL.Quit();

                    //Return success
                    return 0;
                }

                catch (Exception ex)
                {
                    String errorMessage;
                    errorMessage = "Error: ";
                    errorMessage = String.Concat(errorMessage, ex.Message);
                    errorMessage = String.Concat(errorMessage, " Line: ");
                    errorMessage = String.Concat(errorMessage, ex.Source);
                    errorMessage = String.Concat(errorMessage, ex.ToString());

                    Report.Failure("Error writing to a cell in Excel: " + errorMessage);

                    //Close Excel
                    objXL.Quit();

                    return -1;
                }
            }
            return -1;
        } //End ExcelWriteSingleCell

//        public static string[] ExcelReadRange(string strExcelFileName, string strCellStart, string strCellEnd)
//        {
//            string[] ReturnString = ExcelReadRange(strExcelFileName, strCellStart, strCellEnd, "");
//            return ReturnString;
//        }
//        public static string[] ExcelReadRange(string strExcelFileName, string strCellStart, string strCellEnd, string strSheet)
//        {
//            /************************************************************************
//             * Function         : ExcelReadRange(string strExcelFileName, string strCellStart, string strCellEnd, string strSheet)
//             *
//             * Description      : This method will read and return the data of a range of cells 
//             *                  :  in the specified Excel workbook.
//             *                         
//             * Parameters       : strExcelFileName  - Full path and filename of the Excel spreadsheet to open
//             *                  : strCellStart      - Start of range of data to return (i.e. "A1")
//             *                  : strCellEnd        - End of range of data to return (i.e. "B5")
//             *                  : strSheet          - OPTIONAL - Name of the sheet in the spreadsheet the range of data is on
//             *                  :                   -            If not supplied will default to the 1st sheet.
//             *                  
//             * Return Type      : String array
//             * 
//             * Return Value     : Data from the cells for success, null for failure
//             * 
//             * Revision History
//             * Date       : Author                    : Reason/Change
//             * ---------- : ------------------------- : ------------------------------
//             * 03/23/2009 : Chris Gendreau            : Initial Creation 
//             ************************************************************************/
//
//            Microsoft.Office.Interop.Excel.Application objXL;
//            Microsoft.Office.Interop.Excel.Workbook objXLWorkBook;
//            Microsoft.Office.Interop.Excel.Sheets objXLSheets;
//            Microsoft.Office.Interop.Excel.Worksheet objXLWorkSheet;
//            Microsoft.Office.Interop.Excel.Range objXLRange;
//
//            if (strSheet == "")
//            {
//                Report.Debug("Reading Range starting at Cell: '" + strCellStart + "' ending at Cell: '" + strCellEnd + "' in spreadsheet: '" + strExcelFileName + "' on sheet: '1'.");
//            }
//            else
//            {
//                Report.Debug("Reading Range starting at Cell: '" + strCellStart + "' ending at Cell: '" + strCellEnd + "' in spreadsheet: '" + strExcelFileName + "' on sheet: '" + strSheet + "'.");
//            }
//
//            //Open Excel
//            objXL = OpenExcel();
//
//            if (objXL != null)
//            {
//                try
//                {
//                    //Open the Excel Workbook
//                    objXLWorkBook = objXL.Workbooks.Open(strExcelFileName, 0, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
//                        System.Reflection.Missing.Value, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value, true, false,
//                        System.Reflection.Missing.Value, false, false, false);
//
//                    //Get the sheets from the workbook
//                    objXLSheets = objXLWorkBook.Sheets;
//
//                    if (strSheet == "")
//                    {
//                        //Select the first worksheet
//                        objXLWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)objXLSheets[1];
//                    }
//                    else
//                    {
//                        //Select the requested worksheet
//                        objXLWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)objXLSheets[strSheet];
//                    }
//
//                    //Select the cell in the workbook
//                    objXLRange = (Microsoft.Office.Interop.Excel.Range)objXLWorkSheet.get_Range(strCellStart + ":" + strCellEnd, Type.Missing);
//
//                    ////Read the data from the cell range
//                    System.Array myvalues = (System.Array)objXLRange.Cells.Value2;
//					
//                    //Convert the array into a String array
//                    string[] strArray = ConvertToStringArray(myvalues);
//
//                    ////Print the value of the cell for a single cell selection
//                    //foreach (string str in strArray)
//                    //{
//                    //    Console.WriteLine(" Text in cell " + str);
//                    //}
//
//                    //Close Excel
//                    objXL.Quit();
//
//                    //Return the data
//                    return strArray;
//                }
//
//                catch (Exception ex)
//                {
//                    String errorMessage;
//                    errorMessage = "Error: ";
//                    errorMessage = String.Concat(errorMessage, ex.Message);
//                    errorMessage = String.Concat(errorMessage, " Line: ");
//                    errorMessage = String.Concat(errorMessage, ex.Source);
//                    errorMessage = String.Concat(errorMessage, ex.ToString());
//
//                    Report.Failure("Error reading a range of cells from Excel: " + errorMessage);
//
//                    //Close Excel
//                    objXL.Quit();
//
//                    return null;
//                }
//            }
//            return null;
//        } //End ExcelReadRange

        public static int ExcelWriteRange(string strExcelFileName, string strCellStart, string[] strData)
        {
            int ReturnInt = ExcelWriteRange(strExcelFileName, strCellStart, strData, "");
            return ReturnInt;
        }
        public static int ExcelWriteRange(string strExcelFileName, string strCellStart, string[] strData, string strSheet)
        {
            /************************************************************************
             * Function         : ExcelWriteRange(string strExcelFileName, string strCellStart, string[] strData, string strSheet)
             *
             * Description      : This method will write the data specified starting with the specified cell 
             *                  :  in the specified Excel workbook.
             *                         
             * Parameters       : strExcelFileName  - Full path and filename of the Excel spreadsheet to open
             *                  : strCellStart      - Leftmost cell of a row to write to (i.e. "A1")
             *                  : strData           - Array of Data to write to the cell (must be a 1D array)
             *                  : strSheet          - OPTIONAL - Name of the sheet in the spreadsheet the range is on
             *                  :                   -            If not supplied will default to the 1st sheet.
             *                  
             * Return Type      : Integer
             * 
             * Return Value     : 0 for success, -1 for failure
             * 
             * Revision History
             * Date       : Author                    : Reason/Change
             * ---------- : ------------------------- : ------------------------------
             * 03/24/2009 : Chris Gendreau            : Initial Creation 
             ************************************************************************/

            Microsoft.Office.Interop.Excel.Application objXL;
            Microsoft.Office.Interop.Excel.Workbook objXLWorkBook;
            Microsoft.Office.Interop.Excel.Sheets objXLSheets;
            Microsoft.Office.Interop.Excel.Worksheet objXLWorkSheet;
            Microsoft.Office.Interop.Excel.Range objXLRange;

            if (strSheet == "")
            {
                Report.Debug("Writing To Range starting at Cell: '" + strCellStart + "' in spreadsheet: '" + strExcelFileName + "' on sheet: '1'.");
            }
            else
            {
                Report.Debug("Writing To Range starting at Cell: '" + strCellStart + "' in spreadsheet: '" + strExcelFileName + "' on sheet: '" + strSheet + "'.");
            }

            //Open Excel
            objXL = OpenExcel();

            if (objXL != null)
            {
                try
                {
                	objXL.DisplayAlerts = false;
                    //Open the Excel Workbook
                    objXLWorkBook = objXL.Workbooks.Open(strExcelFileName, 0, false, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value, true, false,
                        System.Reflection.Missing.Value, false, false, false);
					
                    //Get the sheets from the workbook
                    objXLSheets = objXLWorkBook.Sheets;

                    if (strSheet == "")
                    {
                        //Select the first worksheet
                        objXLWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)objXLSheets[1];
                    }
                    else
                    {
                        //Select the requested worksheet
                        objXLWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)objXLSheets[strSheet];
                    }

                    //Select the cell for the start of the range
                    objXLRange = (Microsoft.Office.Interop.Excel.Range)objXLWorkSheet.get_Range(strCellStart, Type.Missing);

                    //Resize the range to the length of the passed in data
                    objXLRange = objXLRange.get_Resize(1, strData.Length);

                    //Write to the range
                    objXLRange.Value2 = strData;

                    //Save the Workbook
                    objXLWorkBook.Save();

                    //Close Excel
                    objXL.Quit();

                    //Return success
                    return 0;
                }

                catch (Exception ex)
                {
                    String errorMessage;
                    errorMessage = "Error: ";
                    errorMessage = String.Concat(errorMessage, ex.Message);
                    errorMessage = String.Concat(errorMessage, " Line: ");
                    errorMessage = String.Concat(errorMessage, ex.Source);
                    errorMessage = String.Concat(errorMessage, ex.ToString());

                    Report.Failure("Error writing to a range in Excel: " + errorMessage);

                    //Close Excel
                    objXL.Quit();

                    return -1;
                }
            }
            return -1;
        } //End ExcelWriteRange

//        public static string[] ExcelReadNamedRange(Microsoft.Office.Interop.Excel.Application objXL, Microsoft.Office.Interop.Excel.Workbook objXLWorkBook, string strExcelFileName, string RangeName)
//        {
//            string[] ReturnString = ExcelReadNamedRange(objXL, objXLWorkBook, strExcelFileName, RangeName, "");
//            return ReturnString;
//        }
//        public static string[] ExcelReadNamedRange(Microsoft.Office.Interop.Excel.Application objXL, Microsoft.Office.Interop.Excel.Workbook objXLWorkBook, string strExcelFileName, string RangeName, string strSheet)
//        {
//            /************************************************************************
//             * Function         : ExcelReadNamedRange(string strExcelFileName, string RangeName, string strSheet)
//             *
//             * Description      : This method will read and return the data of a named range of cells 
//             *                  :  in the specified Excel workbook.
//             *                         
//             * Parameters       : objXL             - An existing Excel Object. Pass in NULL if you want to open & close excel within this function
//             *                  : objXLWorkbook     - An existing Excel Workbook Object. Pass in NULL if you want to open a workbook/spreadsheet within this function
//             *                  : strExcelFileName  - Full path and filename of the Excel spreadsheet to open
//             *                  : RangeName         - Name of range of data to return (i.e. "MyRange")
//             *                  : strSheet          - OPTIONAL - Name of the sheet in the spreadsheet the cell is on
//             *                  :                   -            If not supplied will default to the 1st sheet.
//             *                  
//             * Return Type      : String array
//             * 
//             * Return Value     : Data from the cells for success, null for failure
//             * 
//             * Revision History
//             * Date       : Author                    : Reason/Change
//             * ---------- : ------------------------- : ------------------------------
//             * 03/24/2009 : Chris Gendreau            : Initial Creation 
//             * 07/10/2009 : Chris Gendreau            : Added pass in ObjXL & ObjXLWoorkbook
//             * 08/18/2009 : Chris Gendreau            : Added check if Named Range is only 1 cell in length
//             ************************************************************************/
//
//            //Microsoft.Office.Interop.Excel.Application objXL;
//            //Microsoft.Office.Interop.Excel.Workbook objXLWorkBook;
//            Microsoft.Office.Interop.Excel.Sheets objXLSheets;
//            Microsoft.Office.Interop.Excel.Worksheet objXLWorkSheet;
//            Microsoft.Office.Interop.Excel.Range objXLRange;
//            bool boolCloseExcel = false;
//
//            if (strSheet == "")
//            {
//                Report.Debug("Reading Named Range: '" + RangeName + "' from spreadsheet: '" + strExcelFileName + "' on sheet: '1'.");
//            }
//            else
//            {
//                Report.Debug("Reading Named Range: '" + RangeName + "' from spreadsheet: '" + strExcelFileName + "' on sheet: '" + strSheet + "'.");
//            }
//
//            //Only open Excel if an existing Excel object was not passed in 
//            if (objXL == null)
//            {
//                //Open Excel
//                objXL = OpenExcel();
//                boolCloseExcel = true;
//            }
//
//            if (objXL != null)
//            {
//                try
//                {
//                    //Only open the work book if an existing work book object was not passed in 
//                    if (objXLWorkBook == null)
//                    {
//                        //Open the Excel Workbook
//                        objXLWorkBook = objXL.Workbooks.Open(strExcelFileName, 0, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
//                            System.Reflection.Missing.Value, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value, true, false,
//                            System.Reflection.Missing.Value, false, false, false);
//                    }
//
//                    //Get the sheets from the workbook
//                    objXLSheets = objXLWorkBook.Sheets;
//
//                    if (strSheet == "")
//                    {
//                        //Select the first worksheet
//                        objXLWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)objXLSheets[1];
//                    }
//                    else
//                    {
//                        //Select the requested worksheet
//                        objXLWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)objXLSheets[strSheet];
//                    }
//
//                    try
//                    {
//                        //Select the Named Range in the workbook
//                        objXLRange = (Microsoft.Office.Interop.Excel.Range)objXLWorkSheet.get_Range(RangeName, Type.Missing);
//                    }
//                    catch (Exception ex)
//                    {
//                        //If this fails then the requested named range does not exist.
//                        Report.Failure("Requested Named Range: '" + RangeName + "' does not exist.");
//
//                        //Close Excel
//                        objXL.Quit();
//
//                        return null;
//                    }
//
//                    ////Read the data from the Named Range
//                    //Report.Warn(objXLRange.Count.ToString());
//                    string[] strArray = null;
//                    //check if the named range is more than 1 cell in length
//                    if (objXLRange.Count > 1)
//                    {
//                        System.Array myvalues = (System.Array)objXLRange.Cells.Value2;
//                        //Convert the array into a String array
//                        strArray = ConvertToStringArray(myvalues);
//                    }
//                    else
//                    {
//                        strArray = new string[1];
//                        //Check if the singe named range cell is empty or not
//                        if (objXLRange.Cells.Value2 != null)
//                        {
//                            strArray[0] = objXLRange.Cells.Value2.ToString();
//                            //strArray[0] = objXLRange.Cells.Text;
//                        }
//                        else
//                        {
//                            strArray[0] = "";
//                        }
//                    }
//
//                    ////Print the value of the cell for a single cell selection
//                    //foreach (string str in strArray)
//                    //{
//                    //    Console.WriteLine(" Text in cell " + str);
//                    //}
//
//                    if (boolCloseExcel == true)
//                    {
//                        //Close Excel
//                        objXL.Quit();
//                    }
//
//                    //Return the data
//                    return strArray;
//                }
//
//                catch (Exception ex)
//                {
//                    String errorMessage;
//                    errorMessage = "Error: ";
//                    errorMessage = String.Concat(errorMessage, ex.Message);
//                    errorMessage = String.Concat(errorMessage, " Line: ");
//                    errorMessage = String.Concat(errorMessage, ex.Source);
//                    errorMessage = String.Concat(errorMessage, ex.ToString());
//
//                    Report.Failure("Error reading named range values from Excel: " + errorMessage);
//
//                    //Close Excel
//                    objXL.Quit();
//
//                    return null;
//                }
//            }
//            return null;
//        } //End ExcelReadNamedRange

        public static string[] ExcelGetNamedRanges(string strExcelFileName)
        {
            /************************************************************************
             * Function         : ExcelGetNamedRanges(string strExcelFileName)
             *
             * Description      : This method will return a string array of all Range Names 
             *                  :  in the specified Excel workbook.
             *                         
             * Parameters       : strExcelFileName  - Full path and filename of the Excel spreadsheet to open
             *                  
             * Return Type      : String array
             * 
             * Return Value     : All Range Names for success, null for failure
             * 
             * Revision History
             * Date       : Author                    : Reason/Change
             * ---------- : ------------------------- : ------------------------------
             * 03/24/2009 : Chris Gendreau            : Initial Creation 
             ************************************************************************/

            Microsoft.Office.Interop.Excel.Application objXL;
            Microsoft.Office.Interop.Excel.Workbook objXLWorkBook;
            Microsoft.Office.Interop.Excel.Names objNames;

            System.Collections.ArrayList myList = new System.Collections.ArrayList();

            Report.Debug("Getting Named Ranges from spreadsheet: '" + strExcelFileName + "'.");

            //Open Excel
            objXL = OpenExcel();

            if (objXL != null)
            {
                try
                {
                	objXL.DisplayAlerts = false;
                    //Open the Excel Workbook
                    objXLWorkBook = objXL.Workbooks.Open(strExcelFileName, 0, false, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value, true, false,
                        System.Reflection.Missing.Value, false, false, false);

                    //Reference the Workbook Names collection
                    objNames = objXLWorkBook.Names;

                    //Assign each range name to the ArrayList
                    foreach (Microsoft.Office.Interop.Excel.Name Name in objNames)
                    {
                        //Console.WriteLine(" Named Range Area " + Name.Value);
                        //Console.WriteLine(" Named Range Name " + Name.Name);
                        myList.Add(Name.Name);
                    }

                    //Convert the ArrayList into a String array
                    string[] stringArray = (string[])myList.ToArray(typeof(string));

                    //Close Excel
                    objXL.Quit();

                    //Return success
                    return stringArray;
                }

                catch (Exception ex)
                {
                    String errorMessage;
                    errorMessage = "Error: ";
                    errorMessage = String.Concat(errorMessage, ex.Message);
                    errorMessage = String.Concat(errorMessage, " Line: ");
                    errorMessage = String.Concat(errorMessage, ex.Source);
                    errorMessage = String.Concat(errorMessage, ex.ToString());

                    Report.Failure("Error reading named ranges from Excel: " + errorMessage);

                    //Close Excel
                    objXL.Quit();

                    return null;
                }
            }
            return null;
        } //End ExcelGetNamedRanges

        public static int ExcelCreateWorkbook(string strExcelFileName)
        {
            /************************************************************************
             * Function         : ExcelCreateWorkbook(string strExcelFileName)
             *
             * Description      : This method will create a new Excel Workbook. 
             *                         
             * Parameters       : strExcelFileName  - Full path and filename of the Excel workbook to create
             *                  
             * Return Type      : integer
             * 
             * Return Value     : 0 success, -1 for failure
             * 
             * Revision History
             * Date       : Author                    : Reason/Change
             * ---------- : ------------------------- : ------------------------------
             * 03/25/2009 : Chris Gendreau            : Initial Creation 
             ************************************************************************/

            Microsoft.Office.Interop.Excel.Application objXL;
            Microsoft.Office.Interop.Excel.Workbook objXLWorkBook;

            Report.Debug("Creating new Excel workbook: '" + strExcelFileName + "'.");

            //Open Excel
            objXL = OpenExcel();

            if (objXL != null)
            {
                try
                {
                	objXL.DisplayAlerts = false;
                    //Create the Workbook
                    objXLWorkBook = objXL.Workbooks.Add(System.Reflection.Missing.Value);

                    //Save AS the Workbook
                    objXLWorkBook.SaveAs(strExcelFileName, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                        false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, System.Reflection.Missing.Value, false,
                        System.Reflection.Missing.Value, System.Reflection.Missing.Value, true);

                    //Close Excel
                    objXL.Quit();

                    //Return success
                    return 0;
                }
                catch (Exception ex)
                {
                    String errorMessage;
                    errorMessage = "Error: ";
                    errorMessage = String.Concat(errorMessage, ex.Message);
                    errorMessage = String.Concat(errorMessage, " Line: ");
                    errorMessage = String.Concat(errorMessage, ex.Source);
                    errorMessage = String.Concat(errorMessage, ex.ToString());

                    Report.Failure("Error creating new workbook: " + errorMessage);

                    //Close Excel
                    objXL.Quit();

                    //Return failure
                    return -1;
                }
            }
            return -1;
        } //End ExcelCreateWorkbook

        public static int ExcelCreateSheet(string strExcelFileName)
        {
            int ReturnInt = ExcelCreateSheet(strExcelFileName, "");
            return ReturnInt;
        }
        public static int ExcelCreateSheet(string strExcelFileName, string strSheet)
        {
            /************************************************************************
             * Function         : ExcelCreateSheet(string strExcelFileName, string strSheet)
             *
             * Description      : This method will create a new sheet at the end of an existing Excel Workbook. 
             *                         
             * Parameters       : strExcelFileName  - Full path and filename of the Excel spreadsheet to open
             *                  : strSheet          - OPTIONAL - Name of the Sheet to create
             *                  :                   -            If not supplied will default to the next available 
             *                  :                                sheet name (i.e. Sheet4).
             *                  
             * Return Type      : integer
             * 
             * Return Value     : 0 success, -1 for failure
             * 
             * Revision History
             * Date       : Author                    : Reason/Change
             * ---------- : ------------------------- : ------------------------------
             * 03/25/2009 : Chris Gendreau            : Initial Creation 
             ************************************************************************/

            Microsoft.Office.Interop.Excel.Application objXL;
            Microsoft.Office.Interop.Excel.Workbook objXLWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet objXLWorkSheet;

            Int32 WorksheetsCount;
            if (strSheet == "")
            {
                Report.Debug("Adding new sheeet to Excel workbook: '" + strExcelFileName + "'.");
            }
            else
            {
                Report.Debug("Adding new sheeet: '" + strSheet + "' to Excel workbook: '" + strExcelFileName + "'.");
            }

            //Open Excel
            objXL = OpenExcel();

            if (objXL != null)
            {
                try
                {
                	objXL.DisplayAlerts = false;
                    //Open the Excel Workbook
                    objXLWorkBook = objXL.Workbooks.Open(strExcelFileName, 0, false, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value, true, false,
                        System.Reflection.Missing.Value, false, false, false);

                    //Get the current number of Worksheets
                    WorksheetsCount = objXLWorkBook.Worksheets.Count;

                    //Create the Sheet
                    objXLWorkBook.Worksheets.Add(System.Reflection.Missing.Value, objXLWorkBook.Worksheets[WorksheetsCount],
                        System.Reflection.Missing.Value, System.Reflection.Missing.Value);

                    //Name the sheet
                    if (strSheet != "")
                    {
                        objXLWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)objXLWorkBook.ActiveSheet;
                        objXLWorkSheet.Name = strSheet;
                    }

                    //Save the Workbook
                    objXLWorkBook.Save();

                    //Close Excel
                    objXL.Quit();

                    //Return success
                    return 0;
                }
                catch (Exception ex)
                {
                    String errorMessage;
                    errorMessage = "Error: ";
                    errorMessage = String.Concat(errorMessage, ex.Message);
                    errorMessage = String.Concat(errorMessage, " Line: ");
                    errorMessage = String.Concat(errorMessage, ex.Source);
                    errorMessage = String.Concat(errorMessage, ex.ToString());

                    Report.Failure("Error creating new workbook: " + errorMessage);

                    //Close Excel
                    objXL.Quit();

                    //Return failure
                    return -1;
                }
            }
            return -1;
        } //End ExcelCreateWorkbook

        public static int ExcelRowDelete(string strExcelFileName, int intRowNumber)
        {
            int ReturnInt = ExcelRowDelete(strExcelFileName, intRowNumber, "");
            return ReturnInt;
        }
        public static int ExcelRowDelete(string strExcelFileName, int intRowNumber, string strSheet)
        {
            /************************************************************************
             * Function         : ExcelRowDelete(string strExcelFileName, int intRowNumber, string strSheet)
             *
             * Description      : This method will delete a Row in an Excel Workbook. 
             *                         
             * Parameters       : strExcelFileName  - Full path and filename of the Excel spreadsheet to open
             *                  : intRowNumber      - Row number to delete
             *                  : strSheet          - OPTIONAL - Name of the sheet in the spreadsheet the row to delete is on
             *                  :                   -            If not supplied will default to the 1st sheet.
             *                  
             * Return Type      : integer
             * 
             * Return Value     : 0 success, -1 for failure
             * 
             * Revision History
             * Date       : Author                    : Reason/Change
             * ---------- : ------------------------- : ------------------------------
             * 03/25/2009 : Chris Gendreau            : Initial Creation 
             ************************************************************************/

            Microsoft.Office.Interop.Excel.Application objXL;
            Microsoft.Office.Interop.Excel.Workbook objXLWorkBook;
            Microsoft.Office.Interop.Excel.Sheets objXLSheets;
            Microsoft.Office.Interop.Excel.Worksheet objXLWorkSheet;

            if (strSheet == "")
            {
                Report.Debug("Deleting Row: '" + intRowNumber + "' in Excel workbook: '" + strExcelFileName + "' on Sheet '1'.");
            }
            else
            {
                Report.Debug("Deleting Row: '" + intRowNumber + "' in Excel workbook: '" + strExcelFileName + "' on Sheet '" + strSheet + "'.");
            }

            //Open Excel
            objXL = OpenExcel();

            if (objXL != null)
            {
                try
                {
                	objXL.DisplayAlerts = false;
                    //Open the Excel Workbook
                    objXLWorkBook = objXL.Workbooks.Open(strExcelFileName, 0, false, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value, true, false,
                        System.Reflection.Missing.Value, false, false, false);

                    //Get the sheets from the workbook
                    objXLSheets = objXLWorkBook.Sheets;

                    if (strSheet == "")
                    {
                        //Select the first worksheet
                        objXLWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)objXLSheets[1];
                    }
                    else
                    {
                        //Select the requested worksheet
                        objXLWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)objXLSheets[strSheet];
                    }

                    //Delete the Row
                    ((Microsoft.Office.Interop.Excel.Range)objXLWorkSheet.Rows[intRowNumber, System.Reflection.Missing.Value]).Delete(Microsoft.Office.Interop.Excel.XlDeleteShiftDirection.xlShiftUp);

                    //Save the Workbook
                    objXLWorkBook.Save();

                    //Close Excel
                    objXL.Quit();

                    //Return success
                    return 0;
                }
                catch (Exception ex)
                {
                    String errorMessage;
                    errorMessage = "Error: ";
                    errorMessage = String.Concat(errorMessage, ex.Message);
                    errorMessage = String.Concat(errorMessage, " Line: ");
                    errorMessage = String.Concat(errorMessage, ex.Source);
                    errorMessage = String.Concat(errorMessage, ex.ToString());

                    Report.Failure("Error deleting Row: " + errorMessage);

                    //Close Excel
                    objXL.Quit();

                    //Return failure
                    return -1;
                }
            }
            return -1;
        } //End ExcelRowDelete

        public static int ExcelRowInsert(string strExcelFileName, int intRowNumber)
        {
            int ReturnInt = ExcelRowInsert(strExcelFileName, intRowNumber, "");
            return ReturnInt;
        }
        public static int ExcelRowInsert(string strExcelFileName, int intRowNumber, string strSheet)
        {
            /************************************************************************
            * Function         : ExcelRowInsert(string strExcelFileName, int intRowNumber, string strSheet)
            *
            * Description      : This method will insert a Row in an Excel Workbook. 
            *                         
            * Parameters       : strExcelFileName  - Full path and filename of the Excel spreadsheet to open
            *                  : intRowNumber      - Row number to insert
            *                  : strSheet          - OPTIONAL - Name of the sheet in the spreadsheet the row to insert is on
            *                  :                   -            If not supplied will default to the 1st sheet.
            *                  
            * Return Type      : integer
            * 
            * Return Value     : 0 success, -1 for failure
            * 
            * Revision History
            * Date       : Author                    : Reason/Change
            * ---------- : ------------------------- : ------------------------------
            * 03/25/2009 : Chris Gendreau            : Initial Creation 
            ************************************************************************/

            Microsoft.Office.Interop.Excel.Application objXL;
            Microsoft.Office.Interop.Excel.Workbook objXLWorkBook;
            Microsoft.Office.Interop.Excel.Sheets objXLSheets;
            Microsoft.Office.Interop.Excel.Worksheet objXLWorkSheet;

            if (strSheet == "")
            {
                Report.Debug("Inserting Row: '" + intRowNumber + "' in Excel workbook: '" + strExcelFileName + "' on Sheet '1'.");
            }
            else
            {
                Report.Debug("Inserting Row: '" + intRowNumber + "' in Excel workbook: '" + strExcelFileName + "' on Sheet '" + strSheet + "'.");
            }

            //Open Excel
            objXL = OpenExcel();

            if (objXL != null)
            {
                try
                {
                	objXL.DisplayAlerts = false;
                    //Open the Excel Workbook
                    objXLWorkBook = objXL.Workbooks.Open(strExcelFileName, 0, false, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value, true, false,
                        System.Reflection.Missing.Value, false, false, false);

                    //Get the sheets from the workbook
                    objXLSheets = objXLWorkBook.Sheets;

                    if (strSheet == "")
                    {
                        //Select the first worksheet
                        objXLWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)objXLSheets[1];
                    }
                    else
                    {
                        //Select the requested worksheet
                        objXLWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)objXLSheets[strSheet];
                    }

                    //Insert the Row
                    ((Microsoft.Office.Interop.Excel.Range)objXLWorkSheet.Rows[intRowNumber, System.Reflection.Missing.Value]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, System.Reflection.Missing.Value);

                    //Save the Workbook
                    objXLWorkBook.Save();

                    //Close Excel
                    objXL.Quit();

                    //Return success
                    return 0;
                }
                catch (Exception ex)
                {
                    String errorMessage;
                    errorMessage = "Error: ";
                    errorMessage = String.Concat(errorMessage, ex.Message);
                    errorMessage = String.Concat(errorMessage, " Line: ");
                    errorMessage = String.Concat(errorMessage, ex.Source);
                    errorMessage = String.Concat(errorMessage, ex.ToString());

                    Report.Failure("Error inserting Row: " + errorMessage);

                    //Close Excel
                    objXL.Quit();

                    //Return failure
                    return -1;
                }
            }
            return -1;
        } //End ExcelRowInsert

        public static int ExcelColumnDelete(string strExcelFileName, string strColumnLetter)
        {
            int ReturnInt = ExcelColumnDelete(strExcelFileName, strColumnLetter, "");
            return ReturnInt;
        }
        public static int ExcelColumnDelete(string strExcelFileName, string strColumnLetter, string strSheet)
        {
            /************************************************************************
             * Function         : ExcelColumnDelete(string strExcelFileName, string strColumnLetter, string strSheet)
             *
             * Description      : This method will delete a Column in an Excel Workbook. 
             *                         
             * Parameters       : strExcelFileName  - Full path and filename of the Excel spreadsheet to open
             *                  : strColumnLetter   - Column letter to delete
             *                  : strSheet          - OPTIONAL - Name of the sheet in the spreadsheet the column to delete is on
             *                  :                   -            If not supplied will default to the 1st sheet.
             *                  
             * Return Type      : integer
             * 
             * Return Value     : 0 success, -1 for failure
             * 
             * Revision History
             * Date       : Author                    : Reason/Change
             * ---------- : ------------------------- : ------------------------------
             * 03/25/2009 : Chris Gendreau            : Initial Creation 
             ************************************************************************/

            Microsoft.Office.Interop.Excel.Application objXL;
            Microsoft.Office.Interop.Excel.Workbook objXLWorkBook;
            Microsoft.Office.Interop.Excel.Sheets objXLSheets;
            Microsoft.Office.Interop.Excel.Worksheet objXLWorkSheet;

            if (strSheet == "")
            {
                Report.Debug("Deleting Column: '" + strColumnLetter + "' in Excel workbook: '" + strExcelFileName + "' on Sheet '1'.");
            }
            else
            {
                Report.Debug("Deleting Column: '" + strColumnLetter + "' in Excel workbook: '" + strExcelFileName + "' on Sheet '" + strSheet + "'.");
            }

            //Open Excel
            objXL = OpenExcel();

            if (objXL != null)
            {
                try
                {
                	objXL.DisplayAlerts = false;
                    //Open the Excel Workbook
                    objXLWorkBook = objXL.Workbooks.Open(strExcelFileName, 0, false, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value, true, false,
                        System.Reflection.Missing.Value, false, false, false);

                    //Get the sheets from the workbook
                    objXLSheets = objXLWorkBook.Sheets;

                    if (strSheet == "")
                    {
                        //Select the first worksheet
                        objXLWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)objXLSheets[1];
                    }
                    else
                    {
                        //Select the requested worksheet
                        objXLWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)objXLSheets[strSheet];
                    }

                    //Delete the Column
                    objXLWorkSheet.get_Range(strColumnLetter + ":" + strColumnLetter, System.Reflection.Missing.Value).Delete(Microsoft.Office.Interop.Excel.XlDeleteShiftDirection.xlShiftToLeft);

                    //Save the Workbook
                    objXLWorkBook.Save();

                    //Close Excel
                    objXL.Quit();

                    //Return success
                    return 0;
                }
                catch (Exception ex)
                {
                    String errorMessage;
                    errorMessage = "Error: ";
                    errorMessage = String.Concat(errorMessage, ex.Message);
                    errorMessage = String.Concat(errorMessage, " Line: ");
                    errorMessage = String.Concat(errorMessage, ex.Source);
                    errorMessage = String.Concat(errorMessage, ex.ToString());

                    Report.Failure("Error deleting Column: " + errorMessage);

                    //Close Excel
                    objXL.Quit();

                    //Return failure
                    return -1;
                }
            }
            return -1;
        } //End ExcelColumnDelete

        public static int ExcelColumnInsert(string strExcelFileName, string strColumnLetter)
        {
            int ReturnInt = ExcelColumnInsert(strExcelFileName, strColumnLetter, "");
            return ReturnInt;
        }
        public static int ExcelColumnInsert(string strExcelFileName, string strColumnLetter, string strSheet)
        {
            /************************************************************************
             * Function         : ExcelColumnInsert(string strExcelFileName, string strColumnLetter, string strSheet)
             *
             * Description      : This method will insert a Column in an Excel Workbook. 
             *                         
             * Parameters       : strExcelFileName  - Full path and filename of the Excel spreadsheet to open
             *                  : strColumnLetter   - Column letter to insert
             *                  : strSheet          - OPTIONAL - Name of the sheet in the spreadsheet the column to insert is on
             *                  :                   -            If not supplied will default to the 1st sheet.
             *                  
             * Return Type      : integer
             * 
             * Return Value     : 0 success, -1 for failure
             * 
             * Revision History
             * Date       : Author                    : Reason/Change
             * ---------- : ------------------------- : ------------------------------
             * 03/25/2009 : Chris Gendreau            : Initial Creation 
             ************************************************************************/

            Microsoft.Office.Interop.Excel.Application objXL;
            Microsoft.Office.Interop.Excel.Workbook objXLWorkBook;
            Microsoft.Office.Interop.Excel.Sheets objXLSheets;
            Microsoft.Office.Interop.Excel.Worksheet objXLWorkSheet;

            if (strSheet == "")
            {
                Report.Debug("Inserting Column: '" + strColumnLetter + "' in Excel workbook: '" + strExcelFileName + "' on Sheet '1'.");
            }
            else
            {
                Report.Debug("Inserting Column: '" + strColumnLetter + "' in Excel workbook: '" + strExcelFileName + "' on Sheet '" + strSheet + "'.");
            }

            //Open Excel
            objXL = OpenExcel();

            if (objXL != null)
            {
                try
                {
                    //Open the Excel Workbook
                    objXL.DisplayAlerts = false;
                    objXLWorkBook = objXL.Workbooks.Open(strExcelFileName, 0, false, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                        System.Reflection.Missing.Value, true, System.Reflection.Missing.Value, System.Reflection.Missing.Value, true, false,
                        System.Reflection.Missing.Value, false, false, false);

                    //Get the sheets from the workbook
                    objXLSheets = objXLWorkBook.Sheets;

                    if (strSheet == "")
                    {
                        //Select the first worksheet
                        objXLWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)objXLSheets[1];
                    }
                    else
                    {
                        //Select the requested worksheet
                        objXLWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)objXLSheets[strSheet];
                    }

                    //Insert the Column
                    //objXLWorkSheet.get_Range(strColumnLetter + ":" + strColumnLetter, System.Reflection.Missing.Value).Delete(Microsoft.Office.Interop.Excel.XlDeleteShiftDirection.xlShiftToLeft);
                    objXLWorkSheet.get_Range(strColumnLetter + ":" + strColumnLetter, System.Reflection.Missing.Value).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, System.Reflection.Missing.Value);

                    //Save the Workbook
                    objXLWorkBook.Save();

                    //Close Excel
                    objXL.Quit();

                    //Return success
                    return 0;
                }
                catch (Exception ex)
                {
                    String errorMessage;
                    errorMessage = "Error: ";
                    errorMessage = String.Concat(errorMessage, ex.Message);
                    errorMessage = String.Concat(errorMessage, " Line: ");
                    errorMessage = String.Concat(errorMessage, ex.Source);
                    errorMessage = String.Concat(errorMessage, ex.ToString());

                    Report.Failure("Error inserting Column: " + errorMessage);

                    //Close Excel
                    objXL.Quit();

                    //Return failure
                    return -1;
                }
            }
            return -1;
        } //End ExcelColumnInsert
	}
}
