namespace CacheXMLService
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResponseBox = new System.Windows.Forms.TextBox();
            this.rbtLOGICAL = new System.Windows.Forms.RadioButton();
            this.rbtODBC = new System.Windows.Forms.RadioButton();
            this.rbtDISPLAY = new System.Windows.Forms.RadioButton();
            this.groupboxRuntimeModes = new System.Windows.Forms.GroupBox();
            this.SQLtextbox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureLoginInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToXMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSQL = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.saveXMLFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupboxRuntimeModes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResponseBox
            // 
            this.ResponseBox.AccessibleDescription = "Response from web service";
            this.ResponseBox.BackColor = System.Drawing.Color.Azure;
            this.ResponseBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResponseBox.Location = new System.Drawing.Point(0, 0);
            this.ResponseBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResponseBox.Multiline = true;
            this.ResponseBox.Name = "ResponseBox";
            this.ResponseBox.ReadOnly = true;
            this.ResponseBox.Size = new System.Drawing.Size(999, 439);
            this.ResponseBox.TabIndex = 0;
            // 
            // rbtLOGICAL
            // 
            this.rbtLOGICAL.AutoSize = true;
            this.rbtLOGICAL.Checked = true;
            this.rbtLOGICAL.Location = new System.Drawing.Point(9, 29);
            this.rbtLOGICAL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtLOGICAL.Name = "rbtLOGICAL";
            this.rbtLOGICAL.Size = new System.Drawing.Size(148, 24);
            this.rbtLOGICAL.TabIndex = 1;
            this.rbtLOGICAL.TabStop = true;
            this.rbtLOGICAL.Text = "LOGICAL mode";
            this.rbtLOGICAL.UseVisualStyleBackColor = true;
            // 
            // rbtODBC
            // 
            this.rbtODBC.AutoSize = true;
            this.rbtODBC.Location = new System.Drawing.Point(9, 65);
            this.rbtODBC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtODBC.Name = "rbtODBC";
            this.rbtODBC.Size = new System.Drawing.Size(124, 24);
            this.rbtODBC.TabIndex = 2;
            this.rbtODBC.Text = "ODBC mode";
            this.rbtODBC.UseVisualStyleBackColor = true;
            // 
            // rbtDISPLAY
            // 
            this.rbtDISPLAY.AutoSize = true;
            this.rbtDISPLAY.Location = new System.Drawing.Point(9, 100);
            this.rbtDISPLAY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtDISPLAY.Name = "rbtDISPLAY";
            this.rbtDISPLAY.Size = new System.Drawing.Size(147, 24);
            this.rbtDISPLAY.TabIndex = 3;
            this.rbtDISPLAY.Text = "DISPLAY mode";
            this.rbtDISPLAY.UseVisualStyleBackColor = true;
            // 
            // groupboxRuntimeModes
            // 
            this.groupboxRuntimeModes.AccessibleDescription = "Runtime Modes";
            this.groupboxRuntimeModes.BackColor = System.Drawing.SystemColors.Control;
            this.groupboxRuntimeModes.Controls.Add(this.rbtLOGICAL);
            this.groupboxRuntimeModes.Controls.Add(this.rbtDISPLAY);
            this.groupboxRuntimeModes.Controls.Add(this.rbtODBC);
            this.groupboxRuntimeModes.Location = new System.Drawing.Point(20, 35);
            this.groupboxRuntimeModes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupboxRuntimeModes.Name = "groupboxRuntimeModes";
            this.groupboxRuntimeModes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupboxRuntimeModes.Size = new System.Drawing.Size(178, 129);
            this.groupboxRuntimeModes.TabIndex = 4;
            this.groupboxRuntimeModes.TabStop = false;
            this.groupboxRuntimeModes.Text = "Runtime Modes";
            // 
            // SQLtextbox
            // 
            this.SQLtextbox.AccessibleDescription = "SQL Query text";
            this.SQLtextbox.AllowDrop = true;
            this.SQLtextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SQLtextbox.BackColor = System.Drawing.SystemColors.Info;
            this.SQLtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQLtextbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SQLtextbox.Location = new System.Drawing.Point(230, 80);
            this.SQLtextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SQLtextbox.Multiline = true;
            this.SQLtextbox.Name = "SQLtextbox";
            this.SQLtextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SQLtextbox.Size = new System.Drawing.Size(763, 82);
            this.SQLtextbox.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1035, 35);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureLoginInfoToolStripMenuItem,
            this.displayXMLToolStripMenuItem,
            this.exportToXMLFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // configureLoginInfoToolStripMenuItem
            // 
            this.configureLoginInfoToolStripMenuItem.Name = "configureLoginInfoToolStripMenuItem";
            this.configureLoginInfoToolStripMenuItem.Size = new System.Drawing.Size(260, 30);
            this.configureLoginInfoToolStripMenuItem.Text = "Configure Login Info";
            this.configureLoginInfoToolStripMenuItem.Click += new System.EventHandler(this.configureLoginInfoToolStripMenuItem_Click);
            // 
            // displayXMLToolStripMenuItem
            // 
            this.displayXMLToolStripMenuItem.Checked = true;
            this.displayXMLToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displayXMLToolStripMenuItem.Name = "displayXMLToolStripMenuItem";
            this.displayXMLToolStripMenuItem.Size = new System.Drawing.Size(260, 30);
            this.displayXMLToolStripMenuItem.Text = "Display XML";
            this.displayXMLToolStripMenuItem.Click += new System.EventHandler(this.displayXMLToolStripMenuItem_Click);
            // 
            // exportToXMLFileToolStripMenuItem
            // 
            this.exportToXMLFileToolStripMenuItem.Name = "exportToXMLFileToolStripMenuItem";
            this.exportToXMLFileToolStripMenuItem.Size = new System.Drawing.Size(260, 30);
            this.exportToXMLFileToolStripMenuItem.Text = "Export to XML File";
            this.exportToXMLFileToolStripMenuItem.Click += new System.EventHandler(this.exportToXMLFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(260, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(146, 30);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelSQL
            // 
            this.labelSQL.AutoSize = true;
            this.labelSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSQL.Location = new System.Drawing.Point(225, 55);
            this.labelSQL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSQL.Name = "labelSQL";
            this.labelSQL.Size = new System.Drawing.Size(52, 20);
            this.labelSQL.TabIndex = 7;
            this.labelSQL.Text = "SQL:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(882, 35);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 35);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // saveXMLFileDialog
            // 
            this.saveXMLFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveXMLFileDialog_FileOk);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(999, 439);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(18, 42);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupboxRuntimeModes);
            this.splitContainer1.Panel1.Controls.Add(this.btnSubmit);
            this.splitContainer1.Panel1.Controls.Add(this.SQLtextbox);
            this.splitContainer1.Panel1.Controls.Add(this.labelSQL);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.ResponseBox);
            this.splitContainer1.Size = new System.Drawing.Size(999, 622);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1035, 682);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "SQL Query";
            this.groupboxRuntimeModes.ResumeLayout(false);
            this.groupboxRuntimeModes.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResponseBox;
        private System.Windows.Forms.RadioButton rbtLOGICAL;
        private System.Windows.Forms.RadioButton rbtODBC;
        private System.Windows.Forms.RadioButton rbtDISPLAY;
        private System.Windows.Forms.GroupBox groupboxRuntimeModes;
        private System.Windows.Forms.TextBox SQLtextbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label labelSQL;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ToolStripMenuItem configureLoginInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToXMLFileToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveXMLFileDialog;
        private System.Windows.Forms.ToolStripMenuItem displayXMLToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

