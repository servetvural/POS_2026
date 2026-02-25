using System;
using System.Drawing;
using System.Data;
using DronaxLibrary.DBSpace;
using DronaxLibrary;

namespace DTRMNS {
    public class AppButton  {
        public string IID { get; set; }
        public string ButtonText { get; set; }
        public string ProcessName { get; set; }
        public string ShellCommand { get; set; }
        public int DisplayOrder { get; set; }
        public ButtonTypes ButtonType { get; set; }
        public ProcessTypes ProcessType { get; set; }
        public Color BackColour { get; set; }
        public Color ForeColour { get; set; }

        public AppButton() {

            IID = ShortGuid.NewGuid().ToString();
            ButtonType = ButtonTypes.Application;
            ProcessType = ProcessTypes.SingleProcess;
            BackColour = Color.Green;
            ForeColour = Color.White;
        }

        public AppButton(DataTable dt) {
            IID = dt.Rows[0]["IID"].ToString();
            ButtonText = dt.Rows[0]["ButtonText"].ToString();
            ProcessName = dt.Rows[0]["ProcessName"].ToString();
            ShellCommand = dt.Rows[0]["ShellCommand"].ToString();
            DisplayOrder = int.Parse(dt.Rows[0]["DisplayOrder"].ToString());
            ButtonType = (ButtonTypes)int.Parse(dt.Rows[0]["ButtonType"].ToString());
            ProcessType = (ProcessTypes)int.Parse(dt.Rows[0]["ProcessType"].ToString());
            BackColour =Color.FromArgb( int.Parse(dt.Rows[0]["BackColour"].ToString()));
            ForeColour =Color.FromArgb( int.Parse(dt.Rows[0]["ForeColour"].ToString()));
        }
        public AppButton(DataRow dr) {
            IID = dr["IID"].ToString();
            ButtonText = dr["ButtonText"].ToString();
            ProcessName = dr["ProcessName"].ToString();
            ShellCommand = dr["ShellCommand"].ToString();
            DisplayOrder = int.Parse(dr["DisplayOrder"].ToString());
            ButtonType = (ButtonTypes)int.Parse(dr["ButtonType"].ToString());
            ProcessType = (ProcessTypes)int.Parse(dr["ProcessType"].ToString());
            BackColour = Color.FromArgb(int.Parse(dr["BackColour"].ToString()));
            ForeColour = Color.FromArgb(int.Parse(dr["ForeColour"].ToString()));
        }
        public bool Delete(DB db) {
            return db.RunQuery("DeleteAppButton " +
            "'" + IID.Replace("'", "''") + "'");
        }
        public bool Save(DB db) {
            return db.RunQuery("SaveAppButton " +
            "'" + IID.Replace("'", "''") + "','" + ButtonText.Replace("'", "''") + "','" +
           ProcessName.Replace("'", "''") + "','" + ShellCommand.Replace("'", "''") + "','" +
           DisplayOrder + "','" + (int)ButtonType + "','" + (int)ProcessType + "','" +
           BackColour + "','" + ForeColour + "','0'");
        }
    }

}
