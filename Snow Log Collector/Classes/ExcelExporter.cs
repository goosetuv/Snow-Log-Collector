﻿using System;
using System.Data;
using System.IO;
using OfficeOpenXml;

namespace SnowLogCollector.Classes
{
    public class ExcelExporter
    {
        /// <summary>
        /// Data Export function for DataTable to Excel, if a workbook exists it adds it as a new sheet
        /// </summary>
        /// <param name="FileName">The workbook name</param>
        /// <param name="Path">The save path for the workbook</param>
        /// <param name="DataType">What you're exporting (DUJ for instance)</param>
        /// <param name="dt">The datatable to populate the sheet</param>
        /// <param name="ReportingTableDesign">Custom Report Design</param>
        /// <param name="SheetName">The name of the worksheet</param>
        public void Save(string FileName, string Path, string DataType, DataTable dt, OfficeOpenXml.Table.TableStyles ReportingTableDesign, string SheetName = "Report")
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var ep = new ExcelPackage(new FileInfo(Path + "\\" + FileName + ".xlsx")))
            {
                ExcelWorksheet ew = ep.Workbook.Worksheets.Add(SheetName);
                ew.Cells["A1"].LoadFromDataTable(dt, true, ReportingTableDesign);
                ew.Cells.AutoFitColumns(40);
                ep.Workbook.Properties.Application = "Snow Log Collector";
                ep.Workbook.Properties.Author = Environment.UserName;
                ep.Workbook.Properties.Title = DataType + " Export";
                ep.Workbook.Properties.Company = "Goosetuv";
                ep.Workbook.Properties.Comments = "https://github.com/goosetuv";
                ep.Save();
            }
        }
    }
}
