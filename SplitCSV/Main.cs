using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitCSV
{
    public partial class Main : Form
    {
        public string file_name;
        public static int totalrows;
        public static ProgressBar progressSplit;
        public static Label lblProgressSplit;

        public Main()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
               
                DialogResult result = openCSVFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    //var size = new System.IO.FileInfo(openCSVFileDialog.FileName).Length;
                    //MessageBox.Show(size.ToString());
                    if (openCSVFileDialog.SafeFileName.Contains(".csv") && new System.IO.FileInfo(openCSVFileDialog.FileName).Length > 0)
                    {
                        //clear the input and output list
                        chkManageHeaders.Checked = false;
                        lstHeaders.Items.Clear();
                        lstOutputHeaders.Items.Clear();

                        file_name = openCSVFileDialog.FileName;
                        lblFileSelected.Text = openCSVFileDialog.FileName; // openCSVFileDialog.SafeFileName;
                        string[] headers = CSVRW.getHeaders(file_name);
                        totalrows = CSVRW.getRows(file_name);
                        getSummary();
                        populatelstHeaders(headers);


                        if (numNumberOfRows.Value <= 0)
                        {
                            MessageBox.Show("Rows cannot be 0. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            btnSplitFile.Enabled = true;
                            chkManageHeaders.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select valid .CSV file", "File selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //for getting the summary 
        private void getSummary()
        {
            int numberofrowspercsv = Int16.Parse(numNumberOfRows.Value.ToString());
            lblCSVNo.Text = "Total Items: " + totalrows + "\n" +
                "Items in each splitted file: " + numNumberOfRows.Value.ToString() + "\n" +
             "Total Splits: " + Math.Ceiling((double)totalrows / (double)numberofrowspercsv).ToString();
        }

     
        private void btnSplitFile_Click(object sender, EventArgs e)
        {
            List<string> header_array = new List<string>();
            if (chkManageHeaders.Checked)
            {
                foreach (var item in lstOutputHeaders.Items)
                {
                    header_array.Add(item.ToString());
                }
            }
            else
            {
                header_array = CSVRW.getHeaders(file_name).ToList();
            }
            CSVManager.splitCSV(file_name, Int16.Parse(numNumberOfRows.Value.ToString()), header_array.ToArray());
            progressSplit.Value = 0;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            addControls();
            lblFileSelected.Text = "none";
        }

        private void addControls()
        {
            // progressSplit
            // 
            progressSplit = new ProgressBar();
            progressSplit.Location = new System.Drawing.Point(7, 317);
            progressSplit.Name = "progressSplit";
            progressSplit.Size = new System.Drawing.Size(622, 23);
            progressSplit.TabIndex = 17;
            this.Controls.Add(progressSplit);


            lblProgressSplit = new Label();
            lblProgressSplit.Location = new System.Drawing.Point(7, 300);
            lblProgressSplit.Name = "lblProgressSplit";
            lblProgressSplit.Size = new System.Drawing.Size(622, 23);
            this.Controls.Add(lblProgressSplit);
        }

        private void btnMoveSelected_Click(object sender, EventArgs e)
        {
            if (lstHeaders.SelectedItems.Count > 0)
            {
                lstOutputHeaders.Items.Add(lstHeaders.SelectedItem);
                lstHeaders.Items.Remove(lstHeaders.SelectedItem);
            }
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            if (lstOutputHeaders.SelectedItems.Count > 0)
            {
                lstHeaders.Items.Add(lstOutputHeaders.SelectedItem);
                lstOutputHeaders.Items.Remove(lstOutputHeaders.SelectedItem);
            }
        }

        public void populatelstHeaders(string[] headers)
        {
            foreach (var item in headers)
            {
                lstHeaders.Items.Add(item);
            }
        }

        private void btnMoveAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lstHeaders.Items)
            {
                lstOutputHeaders.Items.Add(item.ToString());
            }
            lstHeaders.Items.Clear();
        }

        private void btnMoveAllLeft_Click(object sender, EventArgs e)
        {
            foreach (var item in lstOutputHeaders.Items)
            {
                lstHeaders.Items.Add(item.ToString());
            }
            lstOutputHeaders.Items.Clear();
        }

        private void chkManageHeaders_CheckedChanged(object sender, EventArgs e)
        {
            if (chkManageHeaders.Checked)
            {
                groupHeaders.Enabled = true;
            }
            else
            {
                groupHeaders.Enabled = false;
            }
        }

        private void numNumberOfRows_ValueChanged(object sender, EventArgs e)
        {
            if (numNumberOfRows.Value <= 0)
            {
                MessageBox.Show("Rows cannot be 0. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSplitFile.Enabled = false;
            }
            else
            {
                getSummary();
                btnSplitFile.Enabled = true;
            }
        }

        private void numNumberOfRows_KeyUp(object sender, KeyEventArgs e)
        {
            getSummary();
        }

        public static void processComplete()
        {
            MessageBox.Show("Operation Complete", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
       
    }
}
