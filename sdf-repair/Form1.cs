using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sdf_repair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FilePathOpenDialogButton_Click(object sender, EventArgs e)
        {
            // Clear the results
            ResultLabel.Text = "";
            ResultLabel.BackColor = DefaultBackColor;

            // Choose the new file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            System.Windows.Forms.DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                FilePathField.Text = openFileDialog.FileName;
            }
        }

        private void StartRepairButton_Click(object sender, EventArgs e)
        {
            // Set the be patient message
            ResultLabel.Text = "The repair process will take some time.  Please be patient.";
            ResultLabel.BackColor = DefaultBackColor;
            this.Refresh();

            // Start the repair
            string connectString = $"Data Source = {FilePathField.Text}";
            SqlCeEngine engine = new SqlCeEngine(connectString);
            if (engine.Verify())
            {
                // Database is just fine, so display result
                ResultLabel.Text = "Database was not corrupted.";
                ResultLabel.BackColor = Color.Aquamarine;
            }
            else
            {
                // Database is corrupted, so try to fix
                try
                {
                    engine.Repair(null, RepairOption.DeleteCorruptedRows);
                    ResultLabel.Text = "Database was corrupted, but repaired.";
                    ResultLabel.BackColor = Color.Aquamarine;
                }
                catch (SqlCeException ex)
                {
                    ResultLabel.Text = $"Repair Failed: {ex.Message}";
                    ResultLabel.BackColor = Color.Red;
                }
            }
        }
    }
}
