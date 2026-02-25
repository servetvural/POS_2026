using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace DTRMNS {
    public class DataGridViewCsvExporter {
        private DataGridView dgv;
        public string csvText = "";


        public DataGridViewCsvExporter(DataGridView dgv) {
            this.dgv = dgv;
        }

        /// <summary>
        /// This is for dev components
        /// </summary>
        /// <param name="obj"></param>
        public DataGridViewCsvExporter(object obj) {
            this.dgv = (DataGridView)obj;
        }

        public void ResetDataGridView(DataGridView dgv) {
            this.dgv = dgv;
        }
        public void ResetDataGridView(object obj) {
            this.dgv = (DataGridView)obj;
        }

        public void NewLine() {
            csvText += "\r\n";
        }

        public void EndReport() {
            csvText += "\r\n\r\nEnd Report\r\n\r\n";
        }
        
        public bool Generate(bool blnIncludeHeaders, bool blnVisibleCellsOnly) {
            if (dgv != null) {
                string columnseperator = ",";

                //Get Headers
                if (blnIncludeHeaders) {
                    for (int i = 0; i < dgv.Columns.Count; i++) {
                        if (blnVisibleCellsOnly && !dgv.Columns[i].Visible)
                            continue;
                        csvText += dgv.Columns[i].HeaderText + columnseperator;
                        
                    }
                }
                NewLine();

                //Get Rows
                for (int i = 0; i < dgv.Rows.Count; i++) {
                    for (int c = 0; c < dgv.Columns.Count; c++) {
                        if (blnVisibleCellsOnly && !dgv.Columns[c].Visible)
                            continue;
                        if (dgv.Rows[i].Cells[c].Value == null)
                            csvText += columnseperator;
                        else {
                            try {
                                csvText += Math.Round(decimal.Parse(dgv.Rows[i].Cells[c].Value.ToString()), 2).ToString().Replace(',', '.') + columnseperator;
                            } catch {
                                csvText += dgv.Rows[i].Cells[c].Value.ToString() + columnseperator;
                            }
                        }
                            //csvText += Math.Round(decimal.Parse(dgv.Rows[i].Cells[c].Value.ToString()),2).ToString() + ",,";
                    }
                    NewLine();
                }
                EndReport();
                
                return true;
            } else
                return false;
        }
        public bool GenerateAsTabular(bool blnIncludeHeaders, bool blnVisibleCellsOnly, int[] columnWidth) {
            if (dgv != null) {
                int headercharcount = 0;

                //Get Headers
                if (blnIncludeHeaders) {
                    int columns = 0;
                    for (int i = 0; i < dgv.Columns.Count; i++) {
                        if (blnVisibleCellsOnly && !dgv.Columns[i].Visible)
                            continue;
                        string val = dgv.Columns[i].HeaderText;
                        int len = Math.Abs(columnWidth[columns]);
                        val = val.Length > len ? val.Substring(0, len - 1) : val;
                        headercharcount += len;
                        csvText += string.Format("{0," + columnWidth[columns] + "}", val); //   .PadRight(Math.Abs(columnWidth[columns]));
                        columns++;
                    }
                }
                NewLine();
                if (blnIncludeHeaders) {
                    csvText += new string('=', headercharcount);
                    NewLine();
                }

                //Get Rows
                for (int i = 0; i < dgv.Rows.Count; i++) {
                    int columns = 0;
                    for (int c = 0; c < dgv.Columns.Count; c++) {
                        if (blnVisibleCellsOnly && !dgv.Columns[c].Visible)
                            continue;
                        if (dgv.Rows[i].Cells[c].Value == null)
                            csvText += ",";
                        else {
                            //try {
                            //    float.Parse(dgv.Rows[i].Cells[c].FormattedValue.ToString());
                            //    //this is number
                            //} catch {
                            //    //this is string

                            //}
                            string val = dgv.Rows[i].Cells[c].FormattedValue.ToString();
                            int len = Math.Abs(columnWidth[columns]);
                            val = val.Length > len?val.Substring(0,len -1):val;
                            csvText += string.Format("{0," + columnWidth[columns] + "}", val); //.PadRight(Math.Abs(columnWidth[columns]));
                        }
                        columns++;
                    }
                    NewLine();
                }

                EndReport();
                return true;
            } else
                return false;
        }

        public bool GenerateFromDataTable(DataTable dt, bool blnIncludeHeaders, CultureInfo dbCulture) {
            if (dt != null) {


                //Get Headers
                if (blnIncludeHeaders) {
                    for (int i = 0; i < dt.Columns.Count; i++) {
                        if (dt.Columns[i].ColumnName == null)
                            csvText += ",";
                        else
                            csvText += dt.Columns[i].ColumnName + ","; //,,

                    }
                }
                NewLine();

                //Get Rows
                for (int i = 0; i < dt.Rows.Count; i++) {
                    for (int c = 0; c < dt.Columns.Count; c++) {
                        if (dt.Rows[i][c] == null)
                            csvText += ",";
                        else {
                            float num = 0;
                            if (float.TryParse(dt.Rows[i][c].ToString(), out num))
                                csvText += num.ToString(dbCulture) + ",";
                            else 
                                csvText += dt.Rows[i][c].ToString() + ","; //,,

                        }
                    }
                    NewLine();
                }

                EndReport();
                return true;
            } else
                return false;
        }


        public bool Export(string filename) {
            try {
                System.IO.StreamWriter csvFileWriter = new StreamWriter(filename, false);
                csvFileWriter.Write(csvText);
                csvFileWriter.Flush();
                csvFileWriter.Close();
                
                return true;
            } catch {
                return false;
            }

        }

        public static bool Export(string filename, string csvText) {
            try {
                System.IO.StreamWriter csvFileWriter = new StreamWriter(filename, false);
                csvFileWriter.Write(csvText);
                csvFileWriter.Flush();
                csvFileWriter.Close();

                return true;
            } catch {
                return false;
            }
        }

        public bool ExportToFile() {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                string filename = dlg.FileName.EndsWith(".csv") ? dlg.FileName : dlg.FileName + ".csv";
                return Export(filename);
            } else
                return false;

        }

        public System.Net.Mail.Attachment GetAsAttachment() {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(csvText);
            writer.Flush();
            stream.Position = 0;
            return new System.Net.Mail.Attachment(stream, "report.csv", "text/csv");
        }

        public System.Net.Mail.Attachment GetAsAttachment(bool blnGenerate, bool blnIncludeHeaders, bool blnVisibleCellsOnly) {
            if (Generate(blnIncludeHeaders, blnVisibleCellsOnly)) {
                MemoryStream stream = new MemoryStream();
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(csvText);
                writer.Flush();
                stream.Position = 0;
                return new System.Net.Mail.Attachment(stream, "report.csv", "text/csv");
            } else
                return null;
        }


    }
}
