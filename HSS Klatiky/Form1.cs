using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSS_Klatiky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            this.WindowState = FormWindowState.Maximized;
        }       

        private void InitializeDataGridView()
        {
            // Handle the CellValueChanged event
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;

            // Handle the CurrentCellDirtyStateChanged event to commit edit
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the row index is valid
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
            {
                return; // Exit the method if the row index is invalid
            }

            // Check if the column index is valid
            if (e.ColumnIndex != 1) // We are only interested in changes in the first column
            {
                return; // Exit the method if the column index is invalid
            }

            try
            {
                // Get the value of the cell in the first column
                var secondColumnValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();

                // Use a switch statement to handle different cases
                switch (secondColumnValue)
                {
                    case "22/36":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2022/132";
                        break;

                    case "2213":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2022/132";
                        break;

                    case "2214":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2022/132";
                        break;

                    case "2237":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2022-142";
                        break;

                    case "2240":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2022-142, 2022-146";
                        break;
                    
                    case "2241":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2022-146";
                        break;

                    case "2244":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2022-150";
                        break;

                    case "2245":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2022-150";
                        break;

                    case "2246":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2022/153";
                        break;

                    case "2247":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2022/153";
                        break;

                    case "22/51":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023/03";
                        break;

                    case "22/52":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023/03";
                        break;

                    case "2305":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023/16";
                        break;

                    case "2306":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023/16";
                        break;

                    case "2307":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023/17, 2023/26";
                        break;

                    case "2308":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023/17, 2023/23, 2023/26";
                        break;                    

                    case "2311":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023/23";
                        break;

                    case "2309":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023/27";
                        break;

                    case "2310":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023/27";
                        break;

                    case "2314":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023-33";
                        break;

                    case "2316":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023/35";
                        break;

                    case "2317":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023/35";
                        break;

                    case "3164":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023-38";
                        break;

                    case "2334":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023-77";
                        break;

                    case "2335":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023-78, 2023-79";
                        break;

                    case "2336":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023-80";
                        break;

                    case "2337":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023-81, 2023-82";
                        break;

                    case "2339":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023-83, 2023/87";
                        break;

                    case "2341":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023/87";
                        break;

                    case "2345":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023/92";
                        break;

                    case "2346":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023/92";
                        break;

                    case "3483":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023/95";
                        break;

                    case "3484":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023/95";
                        break;

                    case "3485":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023/96";
                        break;

                    case "3493":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2023/96";
                        break;

                    case "3494":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2024/02";
                        break;

                    case "3501":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2024/02";
                        break;

                    case "4023":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2024/03";
                        break;

                    case "4029":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2024/03";
                        break;

                    case "4025":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2024/07";
                        break;

                    case "4033":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2024/07";
                        break;

                    case "4040":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2024/08";
                        break;

                    case "4043":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2024/08, 2024/12";
                        break;

                    case "4045":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2024/12";
                        break;

                    case "4063":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2024/13, 2024/14";
                        break;

                    case "4052":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2024/13, 2024/19";
                        break;

                    case "4072":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2024/14";
                        break;

                    case "4074":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2024/15, 2024/19, 2024/32";
                        break;

                    case "4075":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2024/15, 2024/16, 2024/20, 2024/32";
                        break;

                    case "4084":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2024/20, 2024/21, 2024/33";
                        break;

                    case "4111":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2024/21, 2024/26";
                        break;

                    case "4112":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2024/22, 2024/27";
                        break;

                    case "4113":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2024/22, 2024/27";
                        break;

                    case "4091":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2024/33";
                        break;

                    case "4092":
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "2024/34";
                        break;

                    default:
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = string.Empty; // Or any default value
                        break;
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Handle the exception (optional logging or user notification)
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // This will commit the edit in the cell, which will trigger CellValueChanged event
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Update the ID column with row numbers
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["ID"].Value = i + 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
