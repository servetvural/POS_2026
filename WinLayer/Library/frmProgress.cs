using System.ComponentModel;
using WinLayer.Library;

namespace WinLayer.Forms {
    public partial class frmProgress : Form {
        private object[] args;
        private Delegate_BackGroundWork WorkDelegate;
        private bool WorkDone;
        public object AsyncResult;
        public ProgressDetailTypes DetailType;
        private int TabCount;
        private string TabBefore = "";

        private const int NoDetailedHeight = 192;
        private const int YesDetailedHeight = 506;

        private bool blnCanCancel;

        private string GetTabs(string str) {
            if (TabBefore == ">") {
                if (str == ">")
                    TabCount++;
                else if (str == "<") {
                    //nan
                } else {
                    TabCount++;
                }
            } else if (TabBefore == "<") {
                if (str == "<") {
                    if (TabCount > 0)
                        TabCount--;
                } else {
                    //nan
                }

            } else {
                if (str == "<") {
                    if (TabCount > 0)
                        TabCount--;
                } else {
                    //nan
                }
            }
            string tabs = "";     
            for (int i = 0; i < TabCount; i++)
                tabs += "     ";
            TabBefore = str;

            return tabs;           
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Message { get { return lblMessage.Text; } set { lblMessage.Text = value; } }

        public string OutputText {
            get { return txtDetails.Text; }            
        }

        private bool _NotifyMarks;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool NotifyMarks {
            get { return _NotifyMarks; }
            set { _NotifyMarks = value; }
        }

        private bool _NotifyStatus;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool NotifyStatus {
            get { return _NotifyStatus; }
            set { _NotifyStatus = value; }
        } 

        public event Delegate_Int_String MarkOccured;
        public event Delegate_String StatusOccured;
        public event Delegate_Bool ActionFinished;

        public frmProgress() {
            InitializeComponent();
            InitializeBackgroundWorker();
        }
        public frmProgress(Delegate_BackGroundWork WorkDelegate, object[] args, bool CloseWhenFinish, 
            ProgressDetailTypes DetailType, bool blnCanCancel) {
            InitializeComponent();
            this.blnCanCancel = blnCanCancel;
            this.WorkDelegate = WorkDelegate;
            this.args = args;
            chkCloseWhenFinished.Checked = CloseWhenFinish;
            this.DetailType = DetailType;
            InitializeBackgroundWorker();
            switch (DetailType) {
                case ProgressDetailTypes.NoDetails:
                    btnSaveOutput.Visible = false;
                    this.Height = NoDetailedHeight;
                    break;
                case ProgressDetailTypes.HeadersOnly:
                case ProgressDetailTypes.FullDetails:
                    btnSaveOutput.Visible = true;
                    this.Height = YesDetailedHeight;
                    break;
            }

        }
        public frmProgress(Delegate_BackGroundWork WorkDelegate, object[] args, bool CloseWhenFinish,
            ProgressDetailTypes DetailType,ProgressDialogViewTypes DialogViewType, bool blnCanCancel, Image imageIcon) {
            InitializeComponent();
            this.blnCanCancel = blnCanCancel;
            this.WorkDelegate = WorkDelegate;
            this.args = args;
            chkCloseWhenFinished.Checked = CloseWhenFinish;
            this.DetailType = DetailType;
            if (imageIcon != null)
                this.picImage.Image = imageIcon;
            InitializeBackgroundWorker();
            switch (DetailType) {
                case ProgressDetailTypes.NoDetails:
                    btnSaveOutput.Visible = false;
                    break;
                case ProgressDetailTypes.HeadersOnly:
                case ProgressDetailTypes.FullDetails:
                    btnSaveOutput.Visible = true;
                    break;
            }
            switch (DialogViewType) {
                case ProgressDialogViewTypes.CompactView:
                    this.Height = NoDetailedHeight;
                    NotifyStatus = true;
                    break;
                case ProgressDialogViewTypes.ExpandedView:
                    this.Height = YesDetailedHeight;
                    break;
            }

        }
        public frmProgress(Delegate_BackGroundWork WorkDelegate, object[] args, bool CloseWhenFinish, 
            ProgressDetailTypes DetailType, Delegate_Int_String MarkOccured, Delegate_String StatusOccured, Delegate_Bool ActionFinished) {
            InitializeComponent();
            this.WorkDelegate = WorkDelegate;
            this.args = args;
            chkCloseWhenFinished.Checked = CloseWhenFinish;
            this.DetailType = DetailType;
            if (MarkOccured != null) {
                this.MarkOccured = MarkOccured;
                NotifyMarks = true;
            }
            if (StatusOccured != null) {
                this.StatusOccured = StatusOccured;
                NotifyStatus = true;
            }
            this.ActionFinished = ActionFinished;

            InitializeBackgroundWorker();
            switch (DetailType) {
                case ProgressDetailTypes.NoDetails:
                    btnSaveOutput.Visible = false;
                    this.Height = NoDetailedHeight;
                    break;
                case ProgressDetailTypes.HeadersOnly:
                case ProgressDetailTypes.FullDetails:
                    btnSaveOutput.Visible = true;
                    this.Height = YesDetailedHeight;
                    break;
            }

        }

        private void frmProgress_Load(object sender, EventArgs e) {
          
            StartAsync();
        }
        private void InitializeBackgroundWorker() {
            bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
            bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_RunWorkerCompleted);
            bgWorker.ProgressChanged += new ProgressChangedEventHandler(bgWorker_ProgressChanged);
        }

        private void StartAsync() {
            // Reset the text in the result label.
            lblStatus.Text = String.Empty;

            // Enable the Cancel button while the asynchronous operation runs.
            btnCancel.Enabled =  blnCanCancel;

            // Start the asynchronous operation.
            bgWorker.RunWorkerAsync(args);
        }

        private void btnCancel_Click(System.Object sender, System.EventArgs e) {
            CancelProcess();
        }
        public void CancelProcess() {
            if (!WorkDone || bgWorker.IsBusy) {
                // Cancel the asynchronous operation.
                bgWorker.CancelAsync();
            }
            this.DialogResult = DialogResult.Cancel;
            AsyncResult = AsyncWorkResultTypes.Cancelled;
            Close();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e) {
            BackgroundWorker worker = sender as BackgroundWorker;
            WorkDelegate(e.Argument, worker, e);
            if (e != null)
                AsyncResult = e.Result;
        }
        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (e.Cancelled) {
                lblStatus.Text = "Canceled..........";
                Mark("Cancelled.............");
                this.DialogResult = DialogResult.Cancel;
                AsyncResult = AsyncWorkResultTypes.Cancelled;
            } else {
                // Finally, handle the case where the operation succeeded.
                if (e.Result != null) {
                    lblStatus.Text = e.Result.ToString();
                    Mark(e.Result.ToString());
                    AsyncResult = e.Result;
                }
            }
            if (chkCloseWhenFinished.Checked) {
                this.DialogResult = DialogResult.OK;
                Close();
            } else {
                Mark(".......PROCESS COMPLETED.");
                btnCancel.Text = "Close";
                WorkDone = true;
                

            }
            if (ActionFinished != null)
                ActionFinished(true);
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            pBar.Value = e.ProgressPercentage;
            if (e.UserState != null) {
                if (e.UserState.ToString().Length > 90) {
                    if (NotifyStatus) {
                        if (StatusOccured != null)
                            StatusOccured(e.UserState.ToString().Substring(0, 89));
                    } else
                        lblStatus.Text = e.UserState.ToString().Substring(0, 89);
                } else {
                    if (NotifyStatus) {
                        if (StatusOccured != null)
                            StatusOccured(e.UserState.ToString());
                        else
                            lblStatus.Text = e.UserState.ToString();
                    }
                }
                Mark(e.UserState.ToString());
            }
        }

        protected void Mark(string str) {
            string tab = "";
            if (str.Length == 0)
                tab = GetTabs("");
            else 
                tab = GetTabs(str.Substring(0,1));


            string modifiedstr = "";
            if (str == "<." || str == ".")
                modifiedstr = ".";
            else if (str.ToUpper() == "<DONE")
                modifiedstr = "..DONE";
            else 
                modifiedstr = "\r\n" + tab + str.TrimStart(new char[] { '>', '<' });
            switch (DetailType) {
                case ProgressDetailTypes.NoDetails:

                    break;
                case ProgressDetailTypes.HeadersOnly:
                    if (str.StartsWith(">") || str.StartsWith("<")) {
                        if (NotifyMarks && MarkOccured != null) {
                            MarkOccured(pBar.Value, modifiedstr);
                        } else {
                            txtDetails.AppendText(modifiedstr);
                            txtDetails.ScrollToCaret();
                        }
                    }
                    break;
                case ProgressDetailTypes.FullDetails:
                    if (NotifyMarks && MarkOccured != null) {
                        MarkOccured(pBar.Value, modifiedstr);
                    } else {
                        txtDetails.AppendText(modifiedstr);
                        txtDetails.ScrollToCaret();
                    }
                    break;
            }
        }

        private void btnSaveOutput_Click(object sender, EventArgs e) {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = DRFile.GetDialogFilter("txt");
            dlg.DefaultExt = "txt";
            dlg.AddExtension = true;
            if (dlg.ShowDialog() == DialogResult.OK) {
                StreamWriter writer = File.CreateText(dlg.FileName);
                writer.Write(txtDetails.Text);
                writer.Close();
            }
        }

        private void chkCloseWhenFinished_CheckedChanged(object sender, EventArgs e) {
            if (DetailType != ProgressDetailTypes.NoDetails) {
                btnSaveOutput.Visible = !chkCloseWhenFinished.Checked;
            }
        }

        private void btnMoreDetails_Click(object sender, EventArgs e) {
            //170, 490
            if (this.Height > NoDetailedHeight) {
                this.Height = NoDetailedHeight;
                btnMoreDetails.Text = "MORE DETAILS";
            }
            else {
                this.Height = YesDetailedHeight;
                btnMoreDetails.Text = "LESS DETAILS";
            }
        }


    }
}
