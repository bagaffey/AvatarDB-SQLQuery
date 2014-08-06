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
            this.btSubmit = new System.Windows.Forms.Button();
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
            this.ResponseBox.Multiline = true;
            this.ResponseBox.Name = "ResponseBox";
            this.ResponseBox.ReadOnly = true;
            this.ResponseBox.Size = new System.Drawing.Size(666, 285);
            this.ResponseBox.TabIndex = 0;
            // 
            // rbtLOGICAL
            // 
            this.rbtLOGICAL.AutoSize = true;
            this.rbtLOGICAL.Checked = true;
            this.rbtLOGICAL.Location = new System.Drawing.Point(6, 19);
            this.rbtLOGICAL.Name = "rbtLOGICAL";
            this.rbtLOGICAL.Size = new System.Drawing.Size(99, 17);
            this.rbtLOGICAL.TabIndex = 1;
            this.rbtLOGICAL.TabStop = true;
            this.rbtLOGICAL.Text = "LOGICAL mode";
            this.rbtLOGICAL.UseVisualStyleBackColor = true;
            // 
            // rbtODBC
            // 
            this.rbtODBC.AutoSize = true;
            this.rbtODBC.Location = new System.Drawing.Point(6, 42);
            this.rbtODBC.Name = "rbtODBC";
            this.rbtODBC.Size = new System.Drawing.Size(84, 17);
            this.rbtODBC.TabIndex = 2;
            this.rbtODBC.Text = "ODBC mode";
            this.rbtODBC.UseVisualStyleBackColor = true;
            // 
            // rbtDISPLAY
            // 
            this.rbtDISPLAY.AutoSize = true;
            this.rbtDISPLAY.Location = new System.Drawing.Point(6, 65);
            this.rbtDISPLAY.Name = "rbtDISPLAY";
            this.rbtDISPLAY.Size = new System.Drawing.Size(99, 17);
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
            this.groupboxRuntimeModes.Location = new System.Drawing.Point(13, 23);
            this.groupboxRuntimeModes.Name = "groupboxRuntimeModes";
            this.groupboxRuntimeModes.Size = new System.Drawing.Size(119, 84);
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
            this.SQLtextbox.Location = new System.Drawing.Point(153, 52);
            this.SQLtextbox.Multiline = true;
            this.SQLtextbox.Name = "SQLtextbox";
            this.SQLtextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SQLtextbox.Size = new System.Drawing.Size(510, 55);
            this.SQLtextbox.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // configureLoginInfoToolStripMenuItem
            // 
            this.configureLoginInfoToolStripMenuItem.Name = "configureLoginInfoToolStripMenuItem";
            this.configureLoginInfoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.configureLoginInfoToolStripMenuItem.Text = "Configure Login Info";
            this.configureLoginInfoToolStripMenuItem.Click += new System.EventHandler(this.configureLoginInfoToolStripMenuItem_Click);
            // 
            // displayXMLToolStripMenuItem
            // 
            this.displayXMLToolStripMenuItem.Checked = true;
            this.displayXMLToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displayXMLToolStripMenuItem.Name = "displayXMLToolStripMenuItem";
            this.displayXMLToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.displayXMLToolStripMenuItem.Text = "Display XML";
            this.displayXMLToolStripMenuItem.Click += new System.EventHandler(this.displayXMLToolStripMenuItem_Click);
            // 
            // exportToXMLFileToolStripMenuItem
            // 
            this.exportToXMLFileToolStripMenuItem.Name = "exportToXMLFileToolStripMenuItem";
            this.exportToXMLFileToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exportToXMLFileToolStripMenuItem.Text = "Export to XML File";
            this.exportToXMLFileToolStripMenuItem.Click += new System.EventHandler(this.exportToXMLFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelSQL
            // 
            this.labelSQL.AutoSize = true;
            this.labelSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSQL.Location = new System.Drawing.Point(150, 36);
            this.labelSQL.Name = "labelSQL";
            this.labelSQL.Size = new System.Drawing.Size(35, 13);
            this.labelSQL.TabIndex = 7;
            this.labelSQL.Text = "SQL:";
            // 
            // btSubmit
            // 
            this.btSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSubmit.Location = new System.Drawing.Point(588, 23);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 8;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
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
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 285);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupboxRuntimeModes);
            this.splitContainer1.Panel1.Controls.Add(this.btSubmit);
            this.splitContainer1.Panel1.Controls.Add(this.SQLtextbox);
            this.splitContainer1.Panel1.Controls.Add(this.labelSQL);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.ResponseBox);
            this.splitContainer1.Size = new System.Drawing.Size(666, 404);
            this.splitContainer1.SplitterDistance = 115;
            this.splitContainer1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(690, 443);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.Button btSubmit;
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

