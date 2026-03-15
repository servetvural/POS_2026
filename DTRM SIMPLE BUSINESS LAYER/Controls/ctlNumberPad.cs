using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using POSLayer.Library;
using POSLayer.Models;

namespace DTRMNS {

    /// <summary>
    /// Summary description for frmKeyboard.
    /// </summary>
    public class ctlNumberPad : System.Windows.Forms.UserControl {
        private Button button107;
        private Button button93;
        private Button button94;
        private Button button95;
        private Button button75;
        private Button button86;
        private Button button89;
        private Button btnAdd;
        private Button button57;
        private Button button58;
        private Button button61;


        //private bool blnShiftOn;
        //private bool blnCapsOn;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button10;
        private Button btnC;
        private Button button7;

        private DTRMSimpleBusiness bslayer;
        private string ItemPrice;
        private HoldingActions elde;
        private TextBox txtDisplay;
        private Button button2;
        private Button button13;
        private Button button15;
        private Button button17;
        private Button button18;
        private GenericFunctionCall CloseFunction;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnMinus;
        private Button btnCE;

        private float Reg2;
        private float Reg1;
        private float Reg0;
        private Button button8;
        private TableLayoutPanel pnlCalculator;
        private Panel panel1;
        private FlowLayoutPanel pnlDistributions;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;


        public ctlNumberPad() {
            InitializeComponent();
        }

        public ctlNumberPad(DTRMSimpleBusiness bslayer, GenericFunctionCall CloseFunction) {
            InitializeComponent();
            this.bslayer = bslayer;
            this.CloseFunction = CloseFunction;
            ItemPrice = "";
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlNumberPad));
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button107 = new System.Windows.Forms.Button();
            this.button93 = new System.Windows.Forms.Button();
            this.button94 = new System.Windows.Forms.Button();
            this.button95 = new System.Windows.Forms.Button();
            this.button75 = new System.Windows.Forms.Button();
            this.button86 = new System.Windows.Forms.Button();
            this.button89 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button57 = new System.Windows.Forms.Button();
            this.button58 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.button61 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pnlCalculator = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDistributions = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCalculator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.White;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplay.Enabled = false;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.txtDisplay.ForeColor = System.Drawing.Color.Navy;
            this.txtDisplay.Location = new System.Drawing.Point(3, 16);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(237, 44);
            this.txtDisplay.TabIndex = 128;
            this.txtDisplay.Text = "0.00";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCE
            // 
            this.btnCE.AutoEllipsis = true;
            this.btnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCE.BackgroundImage")));
            this.btnCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCE.Location = new System.Drawing.Point(3, 507);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(76, 76);
            this.btnCE.TabIndex = 141;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.AutoEllipsis = true;
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinus.BackgroundImage")));
            this.btnMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.btnMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinus.Location = new System.Drawing.Point(85, 507);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(76, 76);
            this.btnMinus.TabIndex = 139;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Visible = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.AutoEllipsis = true;
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDivide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDivide.BackgroundImage")));
            this.btnDivide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btnDivide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDivide.Location = new System.Drawing.Point(167, 507);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(76, 76);
            this.btnDivide.TabIndex = 138;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Visible = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.AutoEllipsis = true;
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMultiply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMultiply.BackgroundImage")));
            this.btnMultiply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.btnMultiply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMultiply.Location = new System.Drawing.Point(85, 423);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(76, 76);
            this.btnMultiply.TabIndex = 137;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // button2
            // 
            this.button2.AutoEllipsis = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(331, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 77);
            this.button2.TabIndex = 136;
            this.button2.Text = "50.00";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.SpecialTextHandler);
            // 
            // button13
            // 
            this.button13.AutoEllipsis = true;
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button13.Location = new System.Drawing.Point(249, 423);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(76, 77);
            this.button13.TabIndex = 134;
            this.button13.Text = "20.00";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.SpecialTextHandler);
            // 
            // button15
            // 
            this.button15.AutoEllipsis = true;
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button15.BackgroundImage")));
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button15.Location = new System.Drawing.Point(331, 339);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(80, 77);
            this.button15.TabIndex = 132;
            this.button15.Text = "15.00";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.SpecialTextHandler);
            // 
            // button17
            // 
            this.button17.AutoEllipsis = true;
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button17.BackgroundImage")));
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button17.Location = new System.Drawing.Point(331, 255);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(80, 77);
            this.button17.TabIndex = 130;
            this.button17.Text = "5.00";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.SpecialTextHandler);
            // 
            // button18
            // 
            this.button18.AutoEllipsis = true;
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button18.BackgroundImage")));
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button18.Location = new System.Drawing.Point(249, 339);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(76, 77);
            this.button18.TabIndex = 129;
            this.button18.Text = "10.00";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.SpecialTextHandler);
            // 
            // button7
            // 
            this.button7.AutoEllipsis = true;
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button7.Location = new System.Drawing.Point(249, 255);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 77);
            this.button7.TabIndex = 127;
            this.button7.Text = "4.00";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.SpecialTextHandler);
            // 
            // button10
            // 
            this.button10.AutoEllipsis = true;
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button10.Location = new System.Drawing.Point(331, 171);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(80, 77);
            this.button10.TabIndex = 125;
            this.button10.Text = "3.00";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.SpecialTextHandler);
            // 
            // button6
            // 
            this.button6.AutoEllipsis = true;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.Location = new System.Drawing.Point(249, 171);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 77);
            this.button6.TabIndex = 124;
            this.button6.Text = "2.00";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.SpecialTextHandler);
            // 
            // button3
            // 
            this.button3.AutoEllipsis = true;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(331, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 77);
            this.button3.TabIndex = 121;
            this.button3.Text = "1.00";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.SpecialTextHandler);
            // 
            // button4
            // 
            this.button4.AutoEllipsis = true;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(249, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 77);
            this.button4.TabIndex = 120;
            this.button4.Text = "0.50";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.SpecialTextHandler);
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(85, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 76);
            this.button1.TabIndex = 117;
            this.button1.Text = "00";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button107
            // 
            this.button107.AutoEllipsis = true;
            this.button107.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button107.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button107.BackgroundImage")));
            this.button107.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button107.FlatAppearance.BorderSize = 0;
            this.button107.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button107.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button107.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button107.Location = new System.Drawing.Point(3, 339);
            this.button107.Name = "button107";
            this.button107.Size = new System.Drawing.Size(76, 76);
            this.button107.TabIndex = 108;
            this.button107.Text = "0";
            this.button107.UseVisualStyleBackColor = false;
            this.button107.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button93
            // 
            this.button93.AutoEllipsis = true;
            this.button93.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button93.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button93.BackgroundImage")));
            this.button93.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button93.FlatAppearance.BorderSize = 0;
            this.button93.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button93.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button93.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button93.Location = new System.Drawing.Point(167, 255);
            this.button93.Name = "button93";
            this.button93.Size = new System.Drawing.Size(76, 76);
            this.button93.TabIndex = 106;
            this.button93.Text = "3";
            this.button93.UseVisualStyleBackColor = false;
            this.button93.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button94
            // 
            this.button94.AutoEllipsis = true;
            this.button94.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button94.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button94.BackgroundImage")));
            this.button94.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button94.FlatAppearance.BorderSize = 0;
            this.button94.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button94.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button94.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button94.Location = new System.Drawing.Point(85, 255);
            this.button94.Name = "button94";
            this.button94.Size = new System.Drawing.Size(76, 76);
            this.button94.TabIndex = 105;
            this.button94.Text = "2";
            this.button94.UseVisualStyleBackColor = false;
            this.button94.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button95
            // 
            this.button95.AutoEllipsis = true;
            this.button95.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button95.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button95.BackgroundImage")));
            this.button95.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button95.FlatAppearance.BorderSize = 0;
            this.button95.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button95.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button95.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button95.Location = new System.Drawing.Point(3, 255);
            this.button95.Name = "button95";
            this.button95.Size = new System.Drawing.Size(76, 76);
            this.button95.TabIndex = 104;
            this.button95.Text = "1";
            this.button95.UseVisualStyleBackColor = false;
            this.button95.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button75
            // 
            this.button75.AutoEllipsis = true;
            this.button75.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button75.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button75.BackgroundImage")));
            this.button75.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button75.FlatAppearance.BorderSize = 0;
            this.button75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button75.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button75.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button75.Location = new System.Drawing.Point(167, 171);
            this.button75.Name = "button75";
            this.button75.Size = new System.Drawing.Size(76, 76);
            this.button75.TabIndex = 102;
            this.button75.Text = "6";
            this.button75.UseVisualStyleBackColor = false;
            this.button75.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button86
            // 
            this.button86.AutoEllipsis = true;
            this.button86.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button86.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button86.BackgroundImage")));
            this.button86.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button86.FlatAppearance.BorderSize = 0;
            this.button86.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button86.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button86.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button86.Location = new System.Drawing.Point(85, 171);
            this.button86.Name = "button86";
            this.button86.Size = new System.Drawing.Size(76, 76);
            this.button86.TabIndex = 101;
            this.button86.Text = "5";
            this.button86.UseVisualStyleBackColor = false;
            this.button86.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button89
            // 
            this.button89.AutoEllipsis = true;
            this.button89.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button89.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button89.BackgroundImage")));
            this.button89.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button89.FlatAppearance.BorderSize = 0;
            this.button89.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button89.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button89.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button89.Location = new System.Drawing.Point(3, 171);
            this.button89.Name = "button89";
            this.button89.Size = new System.Drawing.Size(76, 76);
            this.button89.TabIndex = 100;
            this.button89.Text = "4";
            this.button89.UseVisualStyleBackColor = false;
            this.button89.Click += new System.EventHandler(this.KeyHandle);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoEllipsis = true;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(167, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 76);
            this.btnAdd.TabIndex = 99;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button57
            // 
            this.button57.AutoEllipsis = true;
            this.button57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button57.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button57.BackgroundImage")));
            this.button57.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button57.FlatAppearance.BorderSize = 0;
            this.button57.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button57.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button57.Location = new System.Drawing.Point(167, 87);
            this.button57.Name = "button57";
            this.button57.Size = new System.Drawing.Size(76, 76);
            this.button57.TabIndex = 98;
            this.button57.Text = "9";
            this.button57.UseVisualStyleBackColor = false;
            this.button57.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button58
            // 
            this.button58.AutoEllipsis = true;
            this.button58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button58.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button58.BackgroundImage")));
            this.button58.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button58.FlatAppearance.BorderSize = 0;
            this.button58.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button58.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button58.Location = new System.Drawing.Point(85, 87);
            this.button58.Name = "button58";
            this.button58.Size = new System.Drawing.Size(76, 76);
            this.button58.TabIndex = 97;
            this.button58.Text = "8";
            this.button58.UseVisualStyleBackColor = false;
            this.button58.Click += new System.EventHandler(this.KeyHandle);
            // 
            // btnC
            // 
            this.btnC.AutoEllipsis = true;
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnC.BackgroundImage")));
            this.btnC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnC.Location = new System.Drawing.Point(3, 423);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(76, 76);
            this.btnC.TabIndex = 31;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // button61
            // 
            this.button61.AutoEllipsis = true;
            this.button61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button61.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button61.BackgroundImage")));
            this.button61.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button61.FlatAppearance.BorderSize = 0;
            this.button61.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button61.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button61.Location = new System.Drawing.Point(3, 87);
            this.button61.Name = "button61";
            this.button61.Size = new System.Drawing.Size(76, 76);
            this.button61.TabIndex = 96;
            this.button61.Text = "7";
            this.button61.UseVisualStyleBackColor = false;
            this.button61.Click += new System.EventHandler(this.KeyHandle);
            // 
            // button8
            // 
            this.button8.AutoEllipsis = true;
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.BackgroundImage = global::DTRMNS.Properties.Resources.CLOSEBig;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(331, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 77);
            this.button8.TabIndex = 142;
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlCalculator
            // 
            this.pnlCalculator.BackColor = System.Drawing.Color.Black;
            this.pnlCalculator.ColumnCount = 5;
            this.pnlCalculator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.pnlCalculator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.pnlCalculator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.pnlCalculator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.pnlCalculator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.pnlCalculator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlCalculator.Controls.Add(this.button6, 3, 2);
            this.pnlCalculator.Controls.Add(this.button3, 4, 1);
            this.pnlCalculator.Controls.Add(this.button4, 3, 1);
            this.pnlCalculator.Controls.Add(this.panel1, 0, 0);
            this.pnlCalculator.Controls.Add(this.button61, 0, 1);
            this.pnlCalculator.Controls.Add(this.btnCE, 0, 6);
            this.pnlCalculator.Controls.Add(this.btnDivide, 2, 6);
            this.pnlCalculator.Controls.Add(this.btnMinus, 1, 6);
            this.pnlCalculator.Controls.Add(this.button58, 1, 1);
            this.pnlCalculator.Controls.Add(this.button57, 2, 1);
            this.pnlCalculator.Controls.Add(this.button89, 0, 2);
            this.pnlCalculator.Controls.Add(this.button86, 1, 2);
            this.pnlCalculator.Controls.Add(this.btnMultiply, 1, 5);
            this.pnlCalculator.Controls.Add(this.button95, 0, 3);
            this.pnlCalculator.Controls.Add(this.button94, 1, 3);
            this.pnlCalculator.Controls.Add(this.button93, 2, 3);
            this.pnlCalculator.Controls.Add(this.button75, 2, 2);
            this.pnlCalculator.Controls.Add(this.button107, 0, 4);
            this.pnlCalculator.Controls.Add(this.button1, 1, 4);
            this.pnlCalculator.Controls.Add(this.btnAdd, 2, 4);
            this.pnlCalculator.Controls.Add(this.btnC, 0, 5);
            this.pnlCalculator.Controls.Add(this.button13, 3, 5);
            this.pnlCalculator.Controls.Add(this.button10, 4, 2);
            this.pnlCalculator.Controls.Add(this.button8, 4, 0);
            this.pnlCalculator.Controls.Add(this.button7, 3, 3);
            this.pnlCalculator.Controls.Add(this.button17, 4, 3);
            this.pnlCalculator.Controls.Add(this.button18, 3, 4);
            this.pnlCalculator.Controls.Add(this.button15, 4, 4);
            this.pnlCalculator.Controls.Add(this.button2, 4, 5);
            this.pnlCalculator.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCalculator.Location = new System.Drawing.Point(0, 0);
            this.pnlCalculator.Name = "pnlCalculator";
            this.pnlCalculator.RowCount = 7;
            this.pnlCalculator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.pnlCalculator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.pnlCalculator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.pnlCalculator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.pnlCalculator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.pnlCalculator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.pnlCalculator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.pnlCalculator.Size = new System.Drawing.Size(416, 836);
            this.pnlCalculator.TabIndex = 143;
            // 
            // panel1
            // 
            this.pnlCalculator.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.txtDisplay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 78);
            this.panel1.TabIndex = 0;
            // 
            // pnlDistributions
            // 
            this.pnlDistributions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDistributions.BackColor = System.Drawing.Color.Black;
            this.pnlDistributions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDistributions.Location = new System.Drawing.Point(416, 0);
            this.pnlDistributions.Name = "pnlDistributions";
            this.pnlDistributions.Size = new System.Drawing.Size(339, 836);
            this.pnlDistributions.TabIndex = 140;
            // 
            // ctlNumberPad
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pnlDistributions);
            this.Controls.Add(this.pnlCalculator);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "ctlNumberPad";
            this.Size = new System.Drawing.Size(755, 836);
            this.Load += new System.EventHandler(this.ctlNumberPad_Load);
            this.pnlCalculator.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private void btnClose_Click(object sender, System.EventArgs e) {
            CloseFunction();
        }

        private void KeyHandle(object sender, System.EventArgs e) {
            string key = ((Button)sender).Text.Trim().ToLower();
            ItemPrice += key;

            try {
                float value = float.Parse(ItemPrice, System.Globalization.NumberStyles.Any);
                Reg0 = value / 100;
                Display(Reg0);
                //txtDisplay.Text = value.ToString("c");
            } catch { }

        }

        private void SpecialTextHandler(object sender, System.EventArgs e) {
            try {
                string strPrice = ((Button)sender).Text.Trim().ToLower().Replace(".", "").Replace(",", "");
                float value = float.Parse(strPrice, System.Globalization.NumberStyles.Any) / 100;
                Reg2 += value;
                ItemPrice = "";
                Display(Reg2);
            } catch { }
        }

        private void Display(float num) {
            txtDisplay.Text = num.ToString("f2");
        }
        private void btnAdd_Click(object sender, EventArgs e) {
            if (Reg0 > 0) {
                Reg2 += Reg0;
                Reg0 = 0f;
                Display(Reg2);
                ItemPrice = "";
            }
        }
        private void btnMinus_Click(object sender, EventArgs e) {
            ItemPrice = "";
        }
        private void btnMultiply_Click(object sender, EventArgs e) {
            if (Reg1 > 0) {
                //multiplication can happen now
                Reg2 += Reg0 * Reg1 * 100;
                Reg0 = 0f;
                Reg1 = 0f;
                elde = HoldingActions.None;
            } else {
                //not ready for multiplication so add to register 1
                Reg1 = Reg0;
                Reg0 = 0f;
                elde = HoldingActions.Multiply;
            }
            ItemPrice = "";
            Display(Reg2);
        }

        private void btnDivide_Click(object sender, EventArgs e) {
            ItemPrice = "";
            elde = HoldingActions.Divide;
        }

        private void ctlNumberPad_Load(object sender, EventArgs e) {
            LoadEntities();
            switch (bslayer.config.OrderPad_Orientation) {
                case POSLayer.Library.OrientationTypes.Landscape:
                    pnlCalculator.Dock = DockStyle.Left;
                    pnlCalculator.Width = 416;
                    break;
                case POSLayer.Library.OrientationTypes.Portrait:
                    pnlCalculator.Dock = DockStyle.Top;
                    pnlCalculator.Height = 593;
                    break;
            }
            pnlDistributions.BringToFront();
        }
        private void btnC_Click(object sender, EventArgs e) {
            //ClearHolders();
            Reg0 = 0f;
            Reg1 = 0f;
            Reg2 = 0f;
            ItemPrice = "";
            Display(Reg2);

        }
        private void btnCE_Click(object sender, EventArgs e) {
            Reg0 = 0f;
            Reg1 = 0f;
            ItemPrice = "";
            Display(Reg2);
        }
        private async Task LoadEntities() {
            pnlDistributions.Controls.Clear();

            //DataTable dt = bslayer.GetDataTable("SELECT EntityButton.*, Entity.DistributionIID, Entity.EntityName FROM EntityButton LEFT OUTER JOIN " +
            //          " Entity ON EntityButton.ParentEntityIID = Entity.IID WHERE  EntityButton.PadFlag > 0 and EntityButton.ParentMenuIID = '" + bslayer.config.ActiveMenuIID + "' Order by Entitybutton.EntityButtonName");

            List<EntityButton> entityButtons = await bslayer.GetEntityButtonsForNumberPad();

            List<Entity> entities =await bslayer.GetAllEntities(bslayer.config.ActiveMenuIID);
           
            foreach (var entitybutton in entityButtons)
            {
                Entity parentEntity = entities.Where(x => x.IID == entitybutton.ParentEntityIID).FirstOrDefault();
                EntityButtonSpecial btn = new EntityButtonSpecial();

                btn.BackColor = Color.FromArgb(entitybutton.ButtonColor);

                btn.ForeColor = Color.FromArgb(entitybutton.ForeColor);
                btn.MinimumSize = new Size(132, 76);
                btn.AutoSize = true;
                btn.Text = entitybutton.EntityButtonName;
                btn.Font = new Font("Arial", 9f, FontStyle.Bold);
                btn.Tag = entitybutton;
                btn.PrintableTypeIID = parentEntity.DistributionIID;
                btn.EntityName = parentEntity.EntityName; // dt.Rows[i]["EntityName"].ToString();
                pnlDistributions.Controls.Add(btn);
                btn.Click += new EventHandler(btnEntityButton_Click);
            }
            //for (int i = 0; i < dt.Rows.Count; i++) {
            //    EntityButton entitybutton = new EntityButton(dt.Rows[i]);
            //    EntityButtonSpecial btn = new EntityButtonSpecial();
            //    btn.BackColor = Color.FromArgb(entitybutton.ButtonColor);

            //    btn.ForeColor = Color.FromArgb(entitybutton.ForeColor);
            //    btn.MinimumSize = new Size(132, 76);
            //    btn.AutoSize = true;
            //    btn.Text = entitybutton.EntityButtonName;
            //    btn.Font = new Font("Arial", 9f, FontStyle.Bold);
            //    btn.Tag = entitybutton;
            //    btn.PrintableTypeIID = dt.Rows[i]["DistributionIID"].ToString();
            //    btn.EntityName = dt.Rows[i]["EntityName"].ToString();
            //    pnlDistributions.Controls.Add(btn);
            //    btn.Click += new EventHandler(btnEntityButton_Click);
            //}
        }
        
        void btnEntityButton_Click(object sender, EventArgs e) {
            EntityButtonSpecial btn = (EntityButtonSpecial)sender;
            EntityButton entitybutton = (EntityButton)btn.Tag;
            try {              

                if (Reg1 > 0) {
                    //There is a pending action so execute it 
                    switch (elde) {
                        case HoldingActions.Multiply:
                            btnMultiply_Click(null, null);
                            break;
                        case HoldingActions.Divide:
                            btnDivide_Click(null, null);
                            break;
                        default:
                            Reg1 = 0f;
                            break;
                    }
                }
                if (Reg0 > 0)
                    btnAdd_Click(null, null);

                if (Reg2 == 0)
                    return;

                bslayer.AttachedOrder.AddOrderItem(entitybutton.ParentEntityIID, "", 1, 
                   Reg2, "", entitybutton.EntityButtonName,  btn.PrintableTypeIID /*DistributionIID*/, 
                   OrderItemTypes.NormalOrderItem, 0, btn.EntityName, 0, bslayer.GetEBTaxPercent(entitybutton));
                bslayer.OnDisplayOrder();

                btnC_Click(null, null);

                //ClearHolders();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }           
        }        
    }
}
