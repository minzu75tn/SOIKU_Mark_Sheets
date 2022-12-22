using System;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.XSSF.Util;

namespace CommonBase.Excels
{
    /// <summary>
    /// NPOI Definition Class
    /// </summary>
    public class NPOIexcel1
    {
        /// <summary>
        /// Templete Excel File Path   
        /// </summary>
        private string TEMPLETE_FILE_PATH = null;

        /// <summary>
        /// Workbook   
        /// </summary>
        private IWorkbook workbook = null;

        /// <summary>
        /// Constructor   
        /// </summary>
        public NPOIexcel1()
        {
        }

        /// <summary>
        /// Templete Workbook 取得
        /// </summary>
        public bool GetTempleteWorkbook(string original)
        {
            try
            {
                TEMPLETE_FILE_PATH = original;
                workbook = WorkbookFactory.Create(original);
            }
            catch (Exception ex)
            {
                throw;
            }
            return workbook is null ? false : true;
        }

        /// <summary>
        /// Workbook 保存
        /// </summary>
        public bool WriteWorkbook(string filepath)
        {
            try
            {
                // Create Directory (When Not Exist)
                Commons.CommonLogic1.SafeCreateDirectory(Path.GetDirectoryName(filepath));
                // Create Excel File
                using (var file = new FileStream(filepath, FileMode.CreateNew, FileAccess.Write))
                {
                    workbook.Write(file);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return true;
        }

        /// <summary>
        /// Templete Sheet 複製
        /// </summary>
        public ISheet CopyTempleteSheet(string templetesheet, string newsheet)
        {
            try
            {
                ISheet templete = workbook.GetSheet(templetesheet) as ISheet;
                if (templete == null)
                {
                    throw new Exception("「Templete Sheet」名に誤りがあります。");
                }
                templete.CopyTo(workbook, newsheet, true, true);
                            }
            catch (Exception ex)
            {
                throw;
            }
            return GetWorkSheet(newsheet); 
        }

        /// <summary>
        /// Templete Sheet 取得
        /// </summary>
        public ISheet GetTempleteSheet(string templetesheet)
        {
            ISheet templete = null;

            try
            {
                templete = workbook.GetSheet(templetesheet) as ISheet;
                if (templete == null)
                {
                    throw new Exception("「Templete Sheet」名に誤りがあります。");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return templete;
        }

        /// <summary>
        /// Templete Sheet 行Templete取得
        /// </summary>
        public bool GetTempleteRowFormat(ISheet sourcesheet, ISheet destinationsheet, int sourceRowNum, int destinationRowNum)
        {
            try
            {
                IRow sourceRow = sourcesheet.GetRow(sourceRowNum);
                IRow destinationtRow = destinationsheet.GetRow(destinationRowNum);
                destinationtRow = destinationsheet.CreateRow(destinationRowNum);

                // Copy Cell, Style, Value Etc...
                for (int ii = 0 ; ii < sourceRow.LastCellNum ; ii++)
                {
                    ICell oldCell = sourceRow.GetCell(ii);
                    ICell newCell = destinationtRow.CreateCell(ii);

                    // Copy元 Nothing
                    if (oldCell == null)
                    {
                        newCell = null;
                        continue;
                    }

                    // Copy Style
                    ICellStyle newCellStyle = workbook.CreateCellStyle();
                    newCellStyle.CloneStyleFrom(oldCell.CellStyle);
                    newCell.CellStyle = newCellStyle;

                    // Copy Comment
                    if (oldCell.CellComment != null)
                    {
                        newCell.CellComment = oldCell.CellComment;
                    }

                    // Copy Hyper Link
                    if (oldCell.Hyperlink != null)
                    {
                        newCell.Hyperlink = oldCell.Hyperlink;
                    }

                    // Cell Type
                    newCell.SetCellType(oldCell.CellType);

                    //セルの値をコピー
                    string NullString = null;
                    newCell.SetCellValue(NullString);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return true;
        }

        /// <summary>
        /// Templete Sheet 削除
        /// </summary>
        public bool RemoveTempleteSheet(string templetesheet)
        {
            try
            {
                workbook.RemoveSheetAt(workbook.GetSheetIndex(templetesheet));
            }
            catch (Exception ex)
            {
                throw;
            }
            return true;
        }

        /// <summary>
        /// Sheet 取得
        /// </summary>
        public ISheet GetWorkSheet(string sheet)
        {
            ISheet results = null;

            try
            {
                results = workbook.GetSheet(sheet) as ISheet;
                if (results == null)
                {
                    throw new Exception("「Sheet」名に誤りがあります。");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return results;
        }

        /// <summary>
        /// シート(Sheet)から行を取得
        /// </summary>
        public IRow GetRow(ISheet worksheet, int rownum)
        {
            var row = worksheet.GetRow(rownum);
            // 行が存在しない場合のみ、行を生成
            if (row == null)
            {
                // シートへ行を生成
                row = worksheet.CreateRow(rownum);
            }
            return row;
        }

        /// <summary>
        /// 行から列を取得
        /// </summary>
        public ICell GetCell(IRow row, int cellnum)
        {
            var cell = row.GetCell(cellnum);
            // セルが存在しない場合のみ、セルを生成
            if (cell == null)
            {
                // 行へ列（Cell）を生成
                cell = row.CreateCell(cellnum); 
            }
            return cell;
        }

        /// <summary>
        /// エクセルシート(Sheet)からセル取得
        /// </summary>
        public ICell GetCell(ISheet sheet, int rownum, int cellnum)
        {
            var row = GetRow(sheet, rownum);
            return GetCell(row, cellnum);
        }

    }
}
