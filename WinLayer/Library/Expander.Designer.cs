namespace WinLayer;

partial class Expander {
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.btnLock = new System.Windows.Forms.Button();
        this.btnExpand = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // btnLock
        // 
        this.btnLock.BackColor = System.Drawing.Color.Transparent;
        this.btnLock.BackgroundImage = global::WinLayer.Properties.Resources.PinGreenUp;
        this.btnLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        this.btnLock.Dock = System.Windows.Forms.DockStyle.Top;
        this.btnLock.FlatAppearance.BorderSize = 0;
        this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLock.Location = new System.Drawing.Point(0, 0);
        this.btnLock.Name = "btnLock";
        this.btnLock.Size = new System.Drawing.Size(13, 64);
        this.btnLock.TabIndex = 0;
        this.btnLock.UseVisualStyleBackColor = false;
        this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
        // 
        // btnExpand
        // 
        this.btnExpand.BackColor = System.Drawing.Color.Transparent;
        this.btnExpand.BackgroundImage = global::WinLayer.Properties.Resources.double_horizontal_arrow;
        this.btnExpand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        this.btnExpand.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.btnExpand.FlatAppearance.BorderSize = 0;
        this.btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnExpand.Location = new System.Drawing.Point(0, 494);
        this.btnExpand.Name = "btnExpand";
        this.btnExpand.Size = new System.Drawing.Size(13, 64);
        this.btnExpand.TabIndex = 0;
        this.btnExpand.UseVisualStyleBackColor = false;
        this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
        // 
        // Expander
        // 
        this.BackColor = System.Drawing.SystemColors.ActiveCaption;
        this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.Controls.Add(this.btnLock);
        this.Controls.Add(this.btnExpand);
        this.Dock = System.Windows.Forms.DockStyle.Left;
        this.MinimumSize = new System.Drawing.Size(5, 5);
        this.Size = new System.Drawing.Size(15, 560);
        this.DockChanged += new System.EventHandler(this.Expander_DockChanged);
        this.Paint += new System.Windows.Forms.PaintEventHandler(this.Expander_Paint);
        this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Expander_MouseDown);
        this.MouseLeave += new System.EventHandler(this.Expander_MouseLeave);
        this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Expander_MouseMove);
        this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Expander_MouseUp);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnLock;
    private System.Windows.Forms.Button btnExpand;
}
