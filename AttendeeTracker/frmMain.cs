using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Drawing.Printing;
using LumenWorks.Framework.IO.Csv;

namespace AttendeeTracker
{

    public partial class frmMain : Form
    {

       // private PrintDocument pd;
        private Boolean saveSinceLastEdit = true;
        private DataTable dtCSVTable = new DataTable();
        private List<PaperSize> listPaperSizes = new List<PaperSize>();
        private IEnumerable<String> hiddenColumns;

        private string[] RequiredCompiledAssemblies = {
            "LumenWorks.Framework.IO.dll"
        };

        private string SearchBoxString = 
            "FirstName LIKE '%{0}%'" +
            " OR LastName LIKE '%{0}%'" +
            " OR Company LIKE '%{0}%'";

        //
        // FORM/GUI METHODS
        //
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                hiddenColumns = File.ReadLines("HiddenColumns.ini");
            }
            catch (Exception)
            {

            }

            foreach (string assembly in RequiredCompiledAssemblies) {
                if (!System.IO.File.Exists(assembly))
                {
                    MessageBox.Show( 
                        String.Format("Error loading {0}", assembly),
                        "Error!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    Environment.Exit(1);
                }
            }

            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cmbDYMOPrinter.Items.Add(printer);
            }  

            cmbDYMOPrinter.SelectedIndex = cmbDYMOPrinter.FindString("DYMO");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saveSinceLastEdit)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "Your data has been modified but not saved/exported" +
                    System.Environment.NewLine +
                    System.Environment.NewLine +
                    "Do you want to export your unsaved data?", 
                    "Export data?",
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Exclamation
                    );

                if (dialogResult == DialogResult.Yes)
                {
                    ExportAttendeeList();
                }
            }
        }

        private void cmbDYMOPrinter_SelectedValueChanged(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrinterSettings.PrinterName = cmbDYMOPrinter.SelectedItem.ToString();
            List<String> listToSort = new List<String>();

            foreach (PaperSize item in pd.PrinterSettings.PaperSizes)
            {
                listPaperSizes.Add(item);
                listToSort.Add(item.PaperName);
            }

            listToSort.Sort();
            cmbDYMOLabel.Items.AddRange(listToSort.ToArray<String>());
            cmbDYMOLabel.SelectedItem = "30857 Badge Label";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtCSVTable.DefaultView.RowFilter = string.Format(SearchBoxString, txtSearch.Text);
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                dtCSVTable.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                dtCSVTable.DefaultView.RowFilter = string.Format(SearchBoxString, txtSearch.Text);
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            if (openSpreadsheetDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (CsvReader csvReader =
                    new CsvReader(new StreamReader(openSpreadsheetDialog.FileName), true))
                    {
                        dtCSVTable.Load(csvReader);
                    }

                    btnWalkonAttendee.Enabled = true;
                    btnReprintNameBadge.Enabled = true;
                    btnCheckinAttendee.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show(
                        String.Format("Error opening up {0}", openSpreadsheetDialog.SafeFileName),
                        "Error!",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                        );
                }

                if (MinimumColumns(dtCSVTable))
                {
                    dgvLoadedList.DataSource = dtCSVTable;

                    // hide particular columns, statically defined
                    foreach (string column in hiddenColumns)
                    {
                        dgvLoadedList.Columns[column].Visible = false;
                    }

                    
                    dgvLoadedList.AutoResizeColumns();

                    dtCSVTable.Columns["Attended"].ReadOnly = false;

                    DataColumnCollection columns = dtCSVTable.Columns;    
    
                    // if Email column doesnt exist, add it (very likely)
                    if (!dtCSVTable.Columns.Contains("Email")) 
                    {
                        dtCSVTable.Columns.Add("Email");
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Cannot import!" +
                        System.Environment.NewLine +
                        System.Environment.NewLine +
                        "The data source does not have the minimum required columns:" +
                        System.Environment.NewLine +
                        System.Environment.NewLine +
                        "Attended, FirstName, LastName, Company",
                        "Error!",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                        );
                }
            }

        }

        private void btnExportAttendeeList_Click(object sender, EventArgs e)
        {
            ExportAttendeeList();
        }

        private void btnCheckinAttendee_Click(object sender, EventArgs e)
        {
            dtCSVTable.Rows[dgvLoadedList.CurrentCell.RowIndex].SetField("Attended", "Yes");
            AttendeeBadge abSelected = CreateAttendeeBadgeFromSelectedRow();
            if (!abSelected.Equals(null))
            {
                PrintAttendeeBadge(abSelected);
            }
            saveSinceLastEdit = false;
        }

        private void btnReprintNameBadge_Click(object sender, EventArgs e)
        {
            AttendeeBadge abSelected = CreateAttendeeBadgeFromSelectedRow();
            if (!abSelected.Equals(null))
            {
                PrintAttendeeBadge(abSelected);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = String.Empty;
        }

        private void btnWalkonAttendee_Click(object sender, EventArgs e)
        {
            frmWalkonRegistration frmWalkon = new frmWalkonRegistration();
            frmWalkon.ShowDialog();
            WalkonResult newWalkon = frmWalkon.GetWalkonResult();

            DataRow newAttendeeRecord = dtCSVTable.NewRow();
            newAttendeeRecord["FirstName"] = newWalkon.FirstName;
            newAttendeeRecord["LastName"] = newWalkon.LastName;
            newAttendeeRecord["Company"] = newWalkon.Company;
            newAttendeeRecord["Email"] = newWalkon.Email;
            newAttendeeRecord["Attended"] = "Yes";

            dtCSVTable.Rows.Add(newAttendeeRecord);

            AttendeeBadge abWalkon = CreateAttendeeBadgeFromInputs(
                newWalkon.FirstName, 
                newWalkon.LastName, 
                newWalkon.Company);

            if (!abWalkon.Equals(null))
            {
                PrintAttendeeBadge(abWalkon);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private AttendeeBadge CreateAttendeeBadgeFromSelectedRow()
        {
            // Cleanup strings for printed output  
            String cleanedName = String.Format("{0} {1}",
                dtCSVTable.Rows[dgvLoadedList.CurrentCell.RowIndex]["FirstName"].ToString(),
                dtCSVTable.Rows[dgvLoadedList.CurrentCell.RowIndex]["LastName"].ToString()
                );
            String Company = dtCSVTable.Rows[dgvLoadedList.CurrentCell.RowIndex]["Company"].ToString();

            AttendeeBadge ab = new AttendeeBadge();

            if (ab.CreateNameBadge(cleanedName, Company))
            {
                return ab;
            }
            else
            {
                MessageBox.Show(
                       "Cannot create name badge!" +
                       System.Environment.NewLine +
                       System.Environment.NewLine +
                       "The temporary directory cannot be writen to:" +
                       System.Environment.NewLine +
                       System.Environment.NewLine +
                       @"%TEMP%\AttendeeTracker",
                       "Error!",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                       );
                return null;
            }
        }

        private AttendeeBadge CreateAttendeeBadgeFromInputs(String FirstName, String LastName, String Company)
        {
            // Cleanup strings for printed output  
            String cleanedName = String.Format("{0} {1}",
                FirstName,
                LastName
                );

            AttendeeBadge ab = new AttendeeBadge();

            if (ab.CreateNameBadge(cleanedName, Company))
            {
                return ab;
            }
            else
            {
                MessageBox.Show(
                       "Cannot create name badge!" +
                       System.Environment.NewLine +
                       System.Environment.NewLine +
                       "The temporary directory cannot be writen to:" +
                       System.Environment.NewLine +
                       System.Environment.NewLine +
                       @"%TEMP%\AttendeeTracker",
                       "Error!",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                       );
                return null;
            }
        }

        //
        // INTERNAL METHODS
        //
        private void PrintAttendeeBadge(AttendeeBadge InputBadge)
        {
            // Set printer settings
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = true;
            pd.DefaultPageSettings.PrinterSettings.PrinterName = cmbDYMOPrinter.SelectedItem.ToString();

            foreach (PaperSize paper in listPaperSizes)
            {
                if (paper.PaperName.Equals(cmbDYMOLabel.SelectedItem.ToString()))
                {
                    pd.DefaultPageSettings.PaperSize = paper;
                    break;
                }
            }

            // Set printer handler
            pd.PrintPage += (obj, ppea) => PrintPage(InputBadge, pd, obj, ppea);
            pd.Print();
        }

        private void PrintPage(AttendeeBadge abadge, PrintDocument pd, object sender, PrintPageEventArgs args)
        {
            if (File.Exists(abadge.GetPath()))
            {
                // Load the image from the file
                Image img = Image.FromFile(abadge.GetPath());

                // Grab a copy of our "soft margins" (configured printer settings)
                // Defaults to 1 inch margins, but could be configured otherwise by 
                // the end user. You can also specify some default page margins in 
                // your printDocument.DefaultPageSetting properties.
                RectangleF marginBounds = args.MarginBounds;

                // Grab a copy of our "hard margins" (printer's capabilities) 
                // This varies between printer models. Software printers like 
                // CutePDF will have no "physical limitations" and so will return 
                // the full page size 850,1100 for a letter page size.
                RectangleF printableArea = args.PageSettings.PrintableArea;

                // Are we using soft margins or hard margins? Lets grab the correct 
                // width/height from either the soft/hard margin rectangles. The 
                // hard margins are usually a little wider than the soft margins.
                // ----------
                // Note: Margins are automatically applied to the rotated page size 
                // when the page is set to landscape, but physical hard margins are 
                // not (the printer is not physically rotating any mechanics inside, 
                // the paper still travels through the printer the same way. So we 
                // rotate in software for landscape)
                int availableWidth = (int)Math.Floor(pd.OriginAtMargins
                    ? marginBounds.Width
                    : (args.PageSettings.Landscape
                        ? printableArea.Height
                        : printableArea.Width));
                int availableHeight = (int)Math.Floor(pd.OriginAtMargins
                    ? marginBounds.Height
                    : (args.PageSettings.Landscape
                        ? printableArea.Width
                        : printableArea.Height));

                args.Graphics.DrawImage(img, 0, 0, availableWidth - 1, availableHeight - 1);
            }
        }

        private bool MinimumColumns(DataTable dt)
        {
            try
            {
                if (dt.Columns["Attended"].ColumnName == null)
                {
                    return false;
                }

                if (dt.Columns["FirstName"].ColumnName == null)
                {
                    return false;
                }

                if (dt.Columns["LastName"].ColumnName == null)
                {
                    return false;
                }

                if (dt.Columns["Company"].ColumnName == null)
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        private void ExportAttendeeList()
        {
            // Set defaults for file save
            saveSpreadsheetDialog.InitialDirectory = Path.GetDirectoryName(openSpreadsheetDialog.FileName);
            saveSpreadsheetDialog.FileName = String.Format(
                "AttendeeTracker_Export_{0}",
                DateTime.Now.ToString("yyyyMMdd_HHmm")
                );

            if (saveSpreadsheetDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dtCSVTable.WriteToCsvFile(saveSpreadsheetDialog.FileName);
                    saveSinceLastEdit = true;
                }
                catch (Exception)
                {
                    MessageBox.Show(
                       "Cannot export!" +
                       System.Environment.NewLine +
                       System.Environment.NewLine +
                       "Check permissions? Overwriting file lock?",
                       "Error!",
                       MessageBoxButtons.OK, 
                       MessageBoxIcon.Error
                       );
                }
            }
        }

    }
}