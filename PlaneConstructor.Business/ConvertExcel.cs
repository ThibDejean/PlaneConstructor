using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using System.Data;
using Microsoft.VisualBasic.FileIO;
using PlaneConstructor.Business;


namespace PlaneConstructor
{
    public class ConvertExcel
    {
        /// <summary>
        /// import CSV file into subset
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public Subset GetDataTableFromCsv(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) { throw new ArgumentException();}

            Subset mySubset = new Subset();
            TextFieldParser parser = new TextFieldParser(path);
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            while (!parser.EndOfData)
            {
                Line myline = new Line();
                //Processing row
                string[] fields = parser.ReadFields();
                foreach (string field in fields)
                {
                    //TODO: Process field
                    string t = field;
                    myline.LineInformation.Add(field);
                }
                mySubset.Nomenclature.Add(myline);                
            }
            parser.Close();
            return mySubset;
        }


        /// <summary>
        /// Convert Xlsx to a CSV file
        /// </summary>
        /// <param name="excelFilePath"></param>
        /// <param name="csvOutputFile"></param>
        /// <param name="worksheetNumber"></param>
        public void ConvertExcelToCsv(string excelFilePath, string csvOutputFile, int worksheetNumber)
        {
            if (string.IsNullOrWhiteSpace(excelFilePath)) { throw new ArgumentException(); }
            if (string.IsNullOrWhiteSpace(csvOutputFile)) { throw new ArgumentException(); }
            if (!File.Exists(excelFilePath)) throw new FileNotFoundException(excelFilePath);
            if (File.Exists(csvOutputFile)) { File.Delete(csvOutputFile); }                

            // connection string
            var cnnStr = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\"", excelFilePath);
            var cnn = new OleDbConnection(cnnStr);

            // get schema, then data
            var dt = new System.Data.DataTable();
            try
            {
                cnn.Open();
                var schemaTable = cnn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                if (schemaTable.Rows.Count < worksheetNumber) throw new ArgumentException("The worksheet number provided cannot be found in the spreadsheet");
                string worksheet = schemaTable.Rows[worksheetNumber - 1]["table_name"].ToString().Replace("'", "");
                string sql = String.Format("select * from [{0}]", worksheet);
                var da = new OleDbDataAdapter(sql, cnn);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                // ???
                throw e;
            }
            finally
            {
                // free resources
                cnn.Close();
            }

            // write out CSV data
            using (var wtr = new StreamWriter(csvOutputFile))
            {
                foreach (DataRow row in dt.Rows)
                {
                    bool firstLine = true;
                    foreach (DataColumn col in dt.Columns)
                    {
                        if (!firstLine) 
                        { 
                            wtr.Write(","); 
                        }
                        else
                        {
                            firstLine = false; 
                        }
                        var data = row[col.ColumnName].ToString().Replace("\"", "\"\"");
                        wtr.Write(String.Format("\"{0}\"", data));
                    }
                    wtr.WriteLine();
                }
            }
        }

       

    }
}
