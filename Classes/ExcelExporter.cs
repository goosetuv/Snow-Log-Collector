using System;
using System.Data;
using System.IO;
using OfficeOpenXml;

namespace SnowLogCollector.Classes
{
    public class ExcelExporter
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ExcelExporter));

        public enum DataType
        {
            DataUpdateJob,
            Microsoft365,
            AdobeCreativeCloud,
            GenericSaaS,
            PlatformData
        }

        /// <summary>
        /// Data Export function for DataTable to Excel, if a workbook exists it adds it as a new sheet
        /// </summary>
        /// <param name="FileName">The workbook name</param>
        /// <param name="Path">The save path for the workbook</param>
        /// <param name="DataType">What you're exporting (DUJ for instance)</param>
        /// <param name="dt">The datatable to populate the sheet</param>
        /// <param name="ReportingTableDesign">Custom Report Design</param>
        /// <param name="SheetName">The name of the worksheet</param>
        public void Save(Guid FileName, string Path, DataType DataType, DataTable dt, OfficeOpenXml.Table.TableStyles ReportingTableDesign, string appVersion, string SheetName = "Report")
        {
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (var ep = new ExcelPackage(new FileInfo(Path + "\\" + FileName + ".xlsx")))
                {
                    ExcelWorksheet ew = ep.Workbook.Worksheets.Add(SheetName);
                    ew.Cells["A1"].LoadFromDataTable(dt, true, ReportingTableDesign);
                    ew.Cells.AutoFitColumns(40);
                    ep.Workbook.Properties.Application = string.Format("{0} - {1}", "Snow Log Collector", appVersion);
                    ep.Workbook.Properties.Author = Environment.UserName;
                    ep.Workbook.Properties.Title = DataType + " Export";
                    ep.Workbook.Properties.Company = "Goosetuv";
                    ep.Workbook.Properties.Comments = "https://github.com/goosetuv";
                    ep.Save();
                    log.Info(string.Format("{0} export written to disk. File {1}, Sheet {2}", DataType.ToString(), FileName, SheetName));
                }
            } catch (Exception ex)
            {
                log.Error(string.Format("{0} - Sheet {1}", ex.Message, SheetName));
            }
        }
    }
}
