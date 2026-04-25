namespace BSLayer {
    partial class frmGenericImageEditor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenericImageEditor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImageID = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAutoSize = new System.Windows.Forms.RadioButton();
            this.rbStrech = new System.Windows.Forms.RadioButton();
            this.rbCenter = new System.Windows.Forms.RadioButton();
            this.rbZoom = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.grbCrop = new System.Windows.Forms.GroupBox();
            this.btnCrop = new System.Windows.Forms.Button();
            this.btnCropShow = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudH = new System.Windows.Forms.NumericUpDown();
            this.nudW = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.udHeight = new System.Windows.Forms.NumericUpDown();
            this.lblRatio = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnApplyResize = new System.Windows.Forms.Button();
            this.btnSetHeight = new System.Windows.Forms.Button();
            this.btnSetWidth = new System.Windows.Forms.Button();
            this.udWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDimensions = new System.Windows.Forms.TextBox();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.chkRatio = new System.Windows.Forms.CheckBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbCrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDimensions);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.grbCrop);
            this.panel1.Controls.Add(this.btnSaveAs);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnLoadImage);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtExtra);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFileName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtImageID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(340, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 496);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(253, 421);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "SAVE && CLOSE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(12, 421);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Extra Text";
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(68, 101);
            this.txtExtra.Multiline = true;
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(286, 104);
            this.txtExtra.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Name";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(68, 71);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(286, 20);
            this.txtFileName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image ID";
            // 
            // txtImageID
            // 
            this.txtImageID.Location = new System.Drawing.Point(68, 17);
            this.txtImageID.Name = "txtImageID";
            this.txtImageID.Size = new System.Drawing.Size(228, 20);
            this.txtImageID.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAutoSize);
            this.groupBox1.Controls.Add(this.rbStrech);
            this.groupBox1.Controls.Add(this.rbCenter);
            this.groupBox1.Controls.Add(this.rbZoom);
            this.groupBox1.Controls.Add(this.rbNormal);
            this.groupBox1.Location = new System.Drawing.Point(12, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 48);
            this.groupBox1.TabIndex = 115;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Mode";
            // 
            // rbAutoSize
            // 
            this.rbAutoSize.AutoSize = true;
            this.rbAutoSize.Location = new System.Drawing.Point(144, 19);
            this.rbAutoSize.Name = "rbAutoSize";
            this.rbAutoSize.Size = new System.Drawing.Size(70, 17);
            this.rbAutoSize.TabIndex = 0;
            this.rbAutoSize.Text = "Auto Size";
            this.rbAutoSize.UseVisualStyleBackColor = true;
            this.rbAutoSize.CheckedChanged += new System.EventHandler(this.ViewMode_CheckedChanged);
            // 
            // rbStrech
            // 
            this.rbStrech.AutoSize = true;
            this.rbStrech.Location = new System.Drawing.Point(217, 19);
            this.rbStrech.Name = "rbStrech";
            this.rbStrech.Size = new System.Drawing.Size(56, 17);
            this.rbStrech.TabIndex = 0;
            this.rbStrech.Text = "Strech";
            this.rbStrech.UseVisualStyleBackColor = true;
            this.rbStrech.CheckedChanged += new System.EventHandler(this.ViewMode_CheckedChanged);
            // 
            // rbCenter
            // 
            this.rbCenter.AutoSize = true;
            this.rbCenter.Location = new System.Drawing.Point(279, 19);
            this.rbCenter.Name = "rbCenter";
            this.rbCenter.Size = new System.Drawing.Size(56, 17);
            this.rbCenter.TabIndex = 0;
            this.rbCenter.Text = "Center";
            this.rbCenter.UseVisualStyleBackColor = true;
            this.rbCenter.CheckedChanged += new System.EventHandler(this.ViewMode_CheckedChanged);
            // 
            // rbZoom
            // 
            this.rbZoom.AutoSize = true;
            this.rbZoom.Location = new System.Drawing.Point(77, 19);
            this.rbZoom.Name = "rbZoom";
            this.rbZoom.Size = new System.Drawing.Size(52, 17);
            this.rbZoom.TabIndex = 0;
            this.rbZoom.Text = "Zoom";
            this.rbZoom.UseVisualStyleBackColor = true;
            this.rbZoom.CheckedChanged += new System.EventHandler(this.ViewMode_CheckedChanged);
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Location = new System.Drawing.Point(6, 19);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(58, 17);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.ViewMode_CheckedChanged);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.FlatAppearance.BorderSize = 0;
            this.btnSaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSaveAs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaveAs.Location = new System.Drawing.Point(131, 421);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(100, 50);
            this.btnSaveAs.TabIndex = 116;
            this.btnSaveAs.Text = "EXPORT AS";
            this.btnSaveAs.UseVisualStyleBackColor = false;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // grbCrop
            // 
            this.grbCrop.Controls.Add(this.btnCrop);
            this.grbCrop.Controls.Add(this.btnCropShow);
            this.grbCrop.Controls.Add(this.label9);
            this.grbCrop.Controls.Add(this.label8);
            this.grbCrop.Controls.Add(this.label7);
            this.grbCrop.Controls.Add(this.label5);
            this.grbCrop.Controls.Add(this.nudH);
            this.grbCrop.Controls.Add(this.nudW);
            this.grbCrop.Controls.Add(this.nudY);
            this.grbCrop.Controls.Add(this.nudX);
            this.grbCrop.Location = new System.Drawing.Point(13, 294);
            this.grbCrop.Name = "grbCrop";
            this.grbCrop.Size = new System.Drawing.Size(341, 60);
            this.grbCrop.TabIndex = 126;
            this.grbCrop.TabStop = false;
            this.grbCrop.Text = "Crop Box";
            // 
            // btnCrop
            // 
            this.btnCrop.Location = new System.Drawing.Point(282, 26);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(50, 23);
            this.btnCrop.TabIndex = 2;
            this.btnCrop.Text = "CROP";
            this.btnCrop.UseVisualStyleBackColor = true;
            this.btnCrop.Click += new System.EventHandler(this.btnCrop_Click);
            // 
            // btnCropShow
            // 
            this.btnCropShow.Location = new System.Drawing.Point(223, 26);
            this.btnCropShow.Name = "btnCropShow";
            this.btnCropShow.Size = new System.Drawing.Size(50, 23);
            this.btnCropShow.TabIndex = 2;
            this.btnCropShow.Text = "DRAW";
            this.btnCropShow.UseVisualStyleBackColor = true;
            this.btnCropShow.Click += new System.EventHandler(this.btnCropShow_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(184, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "H";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(131, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "W";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "X";
            // 
            // nudH
            // 
            this.nudH.Location = new System.Drawing.Point(170, 29);
            this.nudH.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudH.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.nudH.Name = "nudH";
            this.nudH.Size = new System.Drawing.Size(46, 20);
            this.nudH.TabIndex = 0;
            this.nudH.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudH.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // nudW
            // 
            this.nudW.Location = new System.Drawing.Point(117, 29);
            this.nudW.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudW.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.nudW.Name = "nudW";
            this.nudW.Size = new System.Drawing.Size(46, 20);
            this.nudW.TabIndex = 0;
            this.nudW.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudW.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(63, 29);
            this.nudY.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudY.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(46, 20);
            this.nudY.TabIndex = 0;
            this.nudY.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(8, 29);
            this.nudX.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudX.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(46, 20);
            this.nudX.TabIndex = 0;
            this.nudX.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFileSize);
            this.groupBox2.Controls.Add(this.chkRatio);
            this.groupBox2.Controls.Add(this.udHeight);
            this.groupBox2.Controls.Add(this.lblRatio);
            this.groupBox2.Controls.Add(this.btnReload);
            this.groupBox2.Controls.Add(this.btnApplyResize);
            this.groupBox2.Controls.Add(this.btnSetHeight);
            this.groupBox2.Controls.Add(this.btnSetWidth);
            this.groupBox2.Controls.Add(this.udWidth);
            this.groupBox2.Location = new System.Drawing.Point(12, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 76);
            this.groupBox2.TabIndex = 127;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size Box";
            // 
            // udHeight
            // 
            this.udHeight.Location = new System.Drawing.Point(119, 19);
            this.udHeight.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.udHeight.Name = "udHeight";
            this.udHeight.Size = new System.Drawing.Size(63, 20);
            this.udHeight.TabIndex = 122;
            this.udHeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.udHeight_KeyDown);
            // 
            // lblRatio
            // 
            this.lblRatio.AutoSize = true;
            this.lblRatio.Location = new System.Drawing.Point(80, 49);
            this.lblRatio.Name = "lblRatio";
            this.lblRatio.Size = new System.Drawing.Size(13, 13);
            this.lblRatio.TabIndex = 119;
            this.lblRatio.Text = "1";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(198, 44);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(85, 23);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnApplyResize
            // 
            this.btnApplyResize.Location = new System.Drawing.Point(198, 16);
            this.btnApplyResize.Name = "btnApplyResize";
            this.btnApplyResize.Size = new System.Drawing.Size(85, 23);
            this.btnApplyResize.TabIndex = 2;
            this.btnApplyResize.Text = "Apply Resize";
            this.btnApplyResize.UseVisualStyleBackColor = true;
            this.btnApplyResize.Click += new System.EventHandler(this.btnApplyResize_Click);
            // 
            // btnSetHeight
            // 
            this.btnSetHeight.Location = new System.Drawing.Point(119, 45);
            this.btnSetHeight.Name = "btnSetHeight";
            this.btnSetHeight.Size = new System.Drawing.Size(65, 23);
            this.btnSetHeight.TabIndex = 2;
            this.btnSetHeight.Text = "Set Height";
            this.btnSetHeight.UseVisualStyleBackColor = true;
            this.btnSetHeight.Click += new System.EventHandler(this.btnSetHeight_Click);
            // 
            // btnSetWidth
            // 
            this.btnSetWidth.Location = new System.Drawing.Point(10, 45);
            this.btnSetWidth.Name = "btnSetWidth";
            this.btnSetWidth.Size = new System.Drawing.Size(65, 23);
            this.btnSetWidth.TabIndex = 2;
            this.btnSetWidth.Text = "Set Width";
            this.btnSetWidth.UseVisualStyleBackColor = true;
            this.btnSetWidth.Click += new System.EventHandler(this.btnSetWidth_Click);
            // 
            // udWidth
            // 
            this.udWidth.Location = new System.Drawing.Point(11, 19);
            this.udWidth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.udWidth.Name = "udWidth";
            this.udWidth.Size = new System.Drawing.Size(63, 20);
            this.udWidth.TabIndex = 122;
            this.udWidth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.udWidth_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 129;
            this.label4.Text = "Dimensions";
            // 
            // txtDimensions
            // 
            this.txtDimensions.Enabled = false;
            this.txtDimensions.Location = new System.Drawing.Point(68, 45);
            this.txtDimensions.Name = "txtDimensions";
            this.txtDimensions.Size = new System.Drawing.Size(228, 20);
            this.txtDimensions.TabIndex = 128;
            // 
            // pbox
            // 
            this.pbox.BackColor = System.Drawing.Color.White;
            this.pbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox.Location = new System.Drawing.Point(0, 24);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(340, 496);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbox.TabIndex = 1;
            this.pbox.TabStop = false;
            this.pbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbox_MouseDown);
            this.pbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbox_MouseMove);
            this.pbox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbox_MouseUp);
            // 
            // chkRatio
            // 
            this.chkRatio.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkRatio.BackgroundImage = global::BSLayer.Properties.Resources.LockClosedRed32;
            this.chkRatio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkRatio.Checked = true;
            this.chkRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRatio.Location = new System.Drawing.Point(80, 18);
            this.chkRatio.Name = "chkRatio";
            this.chkRatio.Size = new System.Drawing.Size(28, 28);
            this.chkRatio.TabIndex = 118;
            this.chkRatio.UseVisualStyleBackColor = true;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Image = global::BSLayer.Properties.Resources.FolderOpen_32;
            this.btnLoadImage.Location = new System.Drawing.Point(302, 17);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(52, 48);
            this.btnLoadImage.TabIndex = 104;
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(292, 21);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(23, 13);
            this.lblFileSize.TabIndex = 123;
            this.lblFileSize.Text = "0 K";
            // 
            // frmGenericImageEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 520);
            this.Controls.Add(this.pbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGenericImageEditor";
            this.Text = "IMAGE EDITOR";
            this.Load += new System.EventHandler(this.frmGenericImageEditor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbCrop.ResumeLayout(false);
            this.grbCrop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImageID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkRatio;
        private System.Windows.Forms.NumericUpDown udHeight;
        private System.Windows.Forms.Label lblRatio;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnApplyResize;
        private System.Windows.Forms.Button btnSetHeight;
        private System.Windows.Forms.Button btnSetWidth;
        private System.Windows.Forms.NumericUpDown udWidth;
        private System.Windows.Forms.GroupBox grbCrop;
        private System.Windows.Forms.Button btnCrop;
        private System.Windows.Forms.Button btnCropShow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudH;
        private System.Windows.Forms.NumericUpDown nudW;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAutoSize;
        private System.Windows.Forms.RadioButton rbStrech;
        private System.Windows.Forms.RadioButton rbCenter;
        private System.Windows.Forms.RadioButton rbZoom;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDimensions;
        private System.Windows.Forms.Label lblFileSize;
    }
}