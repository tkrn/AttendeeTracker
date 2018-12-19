namespace AttendeeTracker
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.openSpreadsheetDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnImportAttendeeList = new System.Windows.Forms.Button();
            this.splitContainerVerticalRight = new System.Windows.Forms.SplitContainer();
            this.splitContainerHorizontalLeft = new System.Windows.Forms.SplitContainer();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvLoadedList = new System.Windows.Forms.DataGridView();
            this.grpAttendeeFunctions = new System.Windows.Forms.GroupBox();
            this.btnCheckinAttendee = new System.Windows.Forms.Button();
            this.btnReprintNameBadge = new System.Windows.Forms.Button();
            this.btnWalkonAttendee = new System.Windows.Forms.Button();
            this.grpDataFunctions = new System.Windows.Forms.GroupBox();
            this.btnExportAttendeeList = new System.Windows.Forms.Button();
            this.grpPrinterSettings = new System.Windows.Forms.GroupBox();
            this.cmbDYMOLabel = new System.Windows.Forms.ComboBox();
            this.lblDYMOLabel = new System.Windows.Forms.Label();
            this.lblDYMOLabelPrinter = new System.Windows.Forms.Label();
            this.cmbDYMOPrinter = new System.Windows.Forms.ComboBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.dsLoadedList = new System.Data.DataSet();
            this.saveSpreadsheetDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVerticalRight)).BeginInit();
            this.splitContainerVerticalRight.Panel1.SuspendLayout();
            this.splitContainerVerticalRight.Panel2.SuspendLayout();
            this.splitContainerVerticalRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizontalLeft)).BeginInit();
            this.splitContainerHorizontalLeft.Panel1.SuspendLayout();
            this.splitContainerHorizontalLeft.Panel2.SuspendLayout();
            this.splitContainerHorizontalLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadedList)).BeginInit();
            this.grpAttendeeFunctions.SuspendLayout();
            this.grpDataFunctions.SuspendLayout();
            this.grpPrinterSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLoadedList)).BeginInit();
            this.SuspendLayout();
            // 
            // openSpreadsheetDialog
            // 
            this.openSpreadsheetDialog.Filter = "CSV File|*.csv|Excel File|.xlsx,.xls";
            // 
            // btnImportAttendeeList
            // 
            this.btnImportAttendeeList.Location = new System.Drawing.Point(43, 25);
            this.btnImportAttendeeList.Name = "btnImportAttendeeList";
            this.btnImportAttendeeList.Size = new System.Drawing.Size(229, 52);
            this.btnImportAttendeeList.TabIndex = 5;
            this.btnImportAttendeeList.TabStop = false;
            this.btnImportAttendeeList.Text = "Import Attendee List";
            this.btnImportAttendeeList.UseVisualStyleBackColor = true;
            this.btnImportAttendeeList.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // splitContainerVerticalRight
            // 
            this.splitContainerVerticalRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerVerticalRight.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerVerticalRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerVerticalRight.Name = "splitContainerVerticalRight";
            // 
            // splitContainerVerticalRight.Panel1
            // 
            this.splitContainerVerticalRight.Panel1.Controls.Add(this.splitContainerHorizontalLeft);
            // 
            // splitContainerVerticalRight.Panel2
            // 
            this.splitContainerVerticalRight.Panel2.Controls.Add(this.grpAttendeeFunctions);
            this.splitContainerVerticalRight.Panel2.Controls.Add(this.grpDataFunctions);
            this.splitContainerVerticalRight.Panel2.Controls.Add(this.grpPrinterSettings);
            this.splitContainerVerticalRight.Panel2.Controls.Add(this.btnAbout);
            this.splitContainerVerticalRight.Size = new System.Drawing.Size(1148, 635);
            this.splitContainerVerticalRight.SplitterDistance = 900;
            this.splitContainerVerticalRight.TabIndex = 3;
            // 
            // splitContainerHorizontalLeft
            // 
            this.splitContainerHorizontalLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHorizontalLeft.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerHorizontalLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerHorizontalLeft.Name = "splitContainerHorizontalLeft";
            this.splitContainerHorizontalLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerHorizontalLeft.Panel1
            // 
            this.splitContainerHorizontalLeft.Panel1.Controls.Add(this.btnClear);
            this.splitContainerHorizontalLeft.Panel1.Controls.Add(this.txtSearch);
            this.splitContainerHorizontalLeft.Panel1.Controls.Add(this.lblSearch);
            // 
            // splitContainerHorizontalLeft.Panel2
            // 
            this.splitContainerHorizontalLeft.Panel2.Controls.Add(this.dgvLoadedList);
            this.splitContainerHorizontalLeft.Size = new System.Drawing.Size(900, 635);
            this.splitContainerHorizontalLeft.SplitterDistance = 45;
            this.splitContainerHorizontalLeft.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(314, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(75, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(233, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(57, 17);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // dgvLoadedList
            // 
            this.dgvLoadedList.AllowUserToAddRows = false;
            this.dgvLoadedList.AllowUserToDeleteRows = false;
            this.dgvLoadedList.AllowUserToResizeColumns = false;
            this.dgvLoadedList.AllowUserToResizeRows = false;
            this.dgvLoadedList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoadedList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvLoadedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoadedList.Location = new System.Drawing.Point(0, 0);
            this.dgvLoadedList.MultiSelect = false;
            this.dgvLoadedList.Name = "dgvLoadedList";
            this.dgvLoadedList.ReadOnly = true;
            this.dgvLoadedList.RowTemplate.Height = 24;
            this.dgvLoadedList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoadedList.Size = new System.Drawing.Size(900, 586);
            this.dgvLoadedList.TabIndex = 3;
            // 
            // grpAttendeeFunctions
            // 
            this.grpAttendeeFunctions.Controls.Add(this.btnCheckinAttendee);
            this.grpAttendeeFunctions.Controls.Add(this.btnReprintNameBadge);
            this.grpAttendeeFunctions.Controls.Add(this.btnWalkonAttendee);
            this.grpAttendeeFunctions.Location = new System.Drawing.Point(14, 321);
            this.grpAttendeeFunctions.Name = "grpAttendeeFunctions";
            this.grpAttendeeFunctions.Size = new System.Drawing.Size(300, 229);
            this.grpAttendeeFunctions.TabIndex = 12;
            this.grpAttendeeFunctions.TabStop = false;
            this.grpAttendeeFunctions.Text = "Attendee Functions";
            // 
            // btnCheckinAttendee
            // 
            this.btnCheckinAttendee.Enabled = false;
            this.btnCheckinAttendee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckinAttendee.Location = new System.Drawing.Point(37, 34);
            this.btnCheckinAttendee.Name = "btnCheckinAttendee";
            this.btnCheckinAttendee.Size = new System.Drawing.Size(229, 52);
            this.btnCheckinAttendee.TabIndex = 13;
            this.btnCheckinAttendee.Text = "&Check-in Attendee";
            this.btnCheckinAttendee.UseVisualStyleBackColor = true;
            this.btnCheckinAttendee.Click += new System.EventHandler(this.btnCheckinAttendee_Click);
            // 
            // btnReprintNameBadge
            // 
            this.btnReprintNameBadge.Enabled = false;
            this.btnReprintNameBadge.Location = new System.Drawing.Point(36, 92);
            this.btnReprintNameBadge.Name = "btnReprintNameBadge";
            this.btnReprintNameBadge.Size = new System.Drawing.Size(229, 54);
            this.btnReprintNameBadge.TabIndex = 14;
            this.btnReprintNameBadge.Text = "&Reprint Name Badge";
            this.btnReprintNameBadge.UseVisualStyleBackColor = true;
            this.btnReprintNameBadge.Click += new System.EventHandler(this.btnReprintNameBadge_Click);
            // 
            // btnWalkonAttendee
            // 
            this.btnWalkonAttendee.Enabled = false;
            this.btnWalkonAttendee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWalkonAttendee.Location = new System.Drawing.Point(36, 152);
            this.btnWalkonAttendee.Name = "btnWalkonAttendee";
            this.btnWalkonAttendee.Size = new System.Drawing.Size(229, 55);
            this.btnWalkonAttendee.TabIndex = 15;
            this.btnWalkonAttendee.Text = "&Walk-on Attendee";
            this.btnWalkonAttendee.UseVisualStyleBackColor = true;
            this.btnWalkonAttendee.Click += new System.EventHandler(this.btnWalkonAttendee_Click);
            // 
            // grpDataFunctions
            // 
            this.grpDataFunctions.Controls.Add(this.btnImportAttendeeList);
            this.grpDataFunctions.Controls.Add(this.btnExportAttendeeList);
            this.grpDataFunctions.Location = new System.Drawing.Point(8, 12);
            this.grpDataFunctions.Name = "grpDataFunctions";
            this.grpDataFunctions.Size = new System.Drawing.Size(306, 148);
            this.grpDataFunctions.TabIndex = 4;
            this.grpDataFunctions.TabStop = false;
            this.grpDataFunctions.Text = "Data Functions";
            // 
            // btnExportAttendeeList
            // 
            this.btnExportAttendeeList.Location = new System.Drawing.Point(43, 83);
            this.btnExportAttendeeList.Name = "btnExportAttendeeList";
            this.btnExportAttendeeList.Size = new System.Drawing.Size(229, 52);
            this.btnExportAttendeeList.TabIndex = 6;
            this.btnExportAttendeeList.TabStop = false;
            this.btnExportAttendeeList.Text = "Export Attendee List";
            this.btnExportAttendeeList.UseVisualStyleBackColor = true;
            this.btnExportAttendeeList.Click += new System.EventHandler(this.btnExportAttendeeList_Click);
            // 
            // grpPrinterSettings
            // 
            this.grpPrinterSettings.Controls.Add(this.cmbDYMOLabel);
            this.grpPrinterSettings.Controls.Add(this.lblDYMOLabel);
            this.grpPrinterSettings.Controls.Add(this.lblDYMOLabelPrinter);
            this.grpPrinterSettings.Controls.Add(this.cmbDYMOPrinter);
            this.grpPrinterSettings.Location = new System.Drawing.Point(8, 166);
            this.grpPrinterSettings.Name = "grpPrinterSettings";
            this.grpPrinterSettings.Size = new System.Drawing.Size(306, 149);
            this.grpPrinterSettings.TabIndex = 7;
            this.grpPrinterSettings.TabStop = false;
            this.grpPrinterSettings.Text = "Printer Settings";
            // 
            // cmbDYMOLabel
            // 
            this.cmbDYMOLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDYMOLabel.FormattingEnabled = true;
            this.cmbDYMOLabel.Location = new System.Drawing.Point(7, 106);
            this.cmbDYMOLabel.Name = "cmbDYMOLabel";
            this.cmbDYMOLabel.Size = new System.Drawing.Size(285, 24);
            this.cmbDYMOLabel.TabIndex = 11;
            this.cmbDYMOLabel.TabStop = false;
            // 
            // lblDYMOLabel
            // 
            this.lblDYMOLabel.AutoSize = true;
            this.lblDYMOLabel.Location = new System.Drawing.Point(6, 85);
            this.lblDYMOLabel.Name = "lblDYMOLabel";
            this.lblDYMOLabel.Size = new System.Drawing.Size(92, 17);
            this.lblDYMOLabel.TabIndex = 10;
            this.lblDYMOLabel.Text = "DYMO Label:";
            // 
            // lblDYMOLabelPrinter
            // 
            this.lblDYMOLabelPrinter.AutoSize = true;
            this.lblDYMOLabelPrinter.Location = new System.Drawing.Point(6, 26);
            this.lblDYMOLabelPrinter.Name = "lblDYMOLabelPrinter";
            this.lblDYMOLabelPrinter.Size = new System.Drawing.Size(138, 17);
            this.lblDYMOLabelPrinter.TabIndex = 8;
            this.lblDYMOLabelPrinter.Text = "DYMO Label Printer:";
            // 
            // cmbDYMOPrinter
            // 
            this.cmbDYMOPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDYMOPrinter.Location = new System.Drawing.Point(6, 46);
            this.cmbDYMOPrinter.Name = "cmbDYMOPrinter";
            this.cmbDYMOPrinter.Size = new System.Drawing.Size(286, 24);
            this.cmbDYMOPrinter.TabIndex = 9;
            this.cmbDYMOPrinter.TabStop = false;
            this.cmbDYMOPrinter.SelectedValueChanged += new System.EventHandler(this.cmbDYMOPrinter_SelectedValueChanged);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(53, 556);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(227, 56);
            this.btnAbout.TabIndex = 16;
            this.btnAbout.TabStop = false;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // dsLoadedList
            // 
            this.dsLoadedList.DataSetName = "AttendeeList";
            // 
            // saveSpreadsheetDialog
            // 
            this.saveSpreadsheetDialog.DefaultExt = "csv";
            this.saveSpreadsheetDialog.Filter = "CSV File|*.csv";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 635);
            this.Controls.Add(this.splitContainerVerticalRight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "AttendeeTracker by tkrn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainerVerticalRight.Panel1.ResumeLayout(false);
            this.splitContainerVerticalRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVerticalRight)).EndInit();
            this.splitContainerVerticalRight.ResumeLayout(false);
            this.splitContainerHorizontalLeft.Panel1.ResumeLayout(false);
            this.splitContainerHorizontalLeft.Panel1.PerformLayout();
            this.splitContainerHorizontalLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizontalLeft)).EndInit();
            this.splitContainerHorizontalLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadedList)).EndInit();
            this.grpAttendeeFunctions.ResumeLayout(false);
            this.grpDataFunctions.ResumeLayout(false);
            this.grpPrinterSettings.ResumeLayout(false);
            this.grpPrinterSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLoadedList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openSpreadsheetDialog;
        private System.Windows.Forms.Button btnImportAttendeeList;
        private System.Windows.Forms.SplitContainer splitContainerVerticalRight;
        private System.Windows.Forms.ComboBox cmbDYMOPrinter;
        private System.Data.DataSet dsLoadedList;
        private System.Windows.Forms.Button btnReprintNameBadge;
        private System.Windows.Forms.Button btnCheckinAttendee;
        private System.Windows.Forms.SplitContainer splitContainerHorizontalLeft;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvLoadedList;
        private System.Windows.Forms.GroupBox grpPrinterSettings;
        private System.Windows.Forms.Button btnWalkonAttendee;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExportAttendeeList;
        private System.Windows.Forms.Label lblDYMOLabelPrinter;
        private System.Windows.Forms.GroupBox grpAttendeeFunctions;
        private System.Windows.Forms.GroupBox grpDataFunctions;
        private System.Windows.Forms.ComboBox cmbDYMOLabel;
        private System.Windows.Forms.Label lblDYMOLabel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.SaveFileDialog saveSpreadsheetDialog;
    }
}

