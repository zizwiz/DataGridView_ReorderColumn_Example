using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReorderDataGridViewColumns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Create Columns
            //col 0, 1, 2 = text
            dgv_one.Columns.Add("0", "Zero");
            dgv_one.Columns.Add("1", "One");
            dgv_one.Columns.Add("2", "Two");

            //col 3 = checkbox
            DataGridViewCheckBoxColumn chkbx = new DataGridViewCheckBoxColumn();
            chkbx.HeaderText = "Three";
            chkbx.Name = "3";
            dgv_one.Columns.Add(chkbx);

            //col 4 = Combobox
            DataGridViewComboBoxColumn Animal_Cmbobx = new DataGridViewComboBoxColumn();
            Animal_Cmbobx.HeaderText = "Farm";
            Animal_Cmbobx.Items.Add("Pig");
            Animal_Cmbobx.Items.Add("Cow");
            Animal_Cmbobx.Items.Add("Goat");
            Animal_Cmbobx.Name = "4";
            dgv_one.Columns.Add(Animal_Cmbobx);

            dgv_one.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_one.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_one.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_one.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_one.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //Create rows
            for (int i = 0; i < 20; i++)
            {

                dgv_one.Rows.Add(); // add new row
                dgv_one.Rows[i].HeaderCell.Value = i.ToString(); //put row number inside left margin
            }

            //Populate rows
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dgv_one.Rows[i].Cells[j].Value = (i * j); //put the data into the cell
                }
            }
        }

        private void btn_cpy_reorder_Click(object sender, EventArgs e)
        {
            //copy columns
            dgv_two.Columns.Add((DataGridViewColumn)dgv_one.Columns[4].Clone());
            dgv_two.Columns.Add((DataGridViewColumn)dgv_one.Columns[0].Clone());
            dgv_two.Columns.Add((DataGridViewColumn)dgv_one.Columns[3].Clone());
            dgv_two.Columns.Add((DataGridViewColumn)dgv_one.Columns[1].Clone());
            dgv_two.Columns.Add((DataGridViewColumn)dgv_one.Columns[2].Clone());


            //copy data
            for (int i = 0; i < 20; i++)
            {
                dgv_two.Rows.Add();
                dgv_two.Rows[i].Cells[0].Value = dgv_one.Rows[i].Cells[4].Value;
                dgv_two.Rows[i].Cells[1].Value = dgv_one.Rows[i].Cells[0].Value;
                dgv_two.Rows[i].Cells[2].Value = dgv_one.Rows[i].Cells[3].Value;
                dgv_two.Rows[i].Cells[3].Value = dgv_one.Rows[i].Cells[1].Value;
                dgv_two.Rows[i].Cells[4].Value = dgv_one.Rows[i].Cells[2].Value;
            }
        }

        private void btn_reorder_Click(object sender, EventArgs e)
        {
            //reorder left hand dgv
            dgv_one.Columns["4"].DisplayIndex = 0;
            dgv_one.Columns["0"].DisplayIndex = 1;
            dgv_one.Columns["3"].DisplayIndex = 2;
            dgv_one.Columns["1"].DisplayIndex = 3;
            dgv_one.Columns["2"].DisplayIndex = 4;

        }

        //print left-hand reordered dgv via stream
        private void prn_dgv_one_stream_Click(object sender, EventArgs e)
        {
            StreamSavePrint(dgv_one);
        }

        //print right-hand reordered dgv via stream
        private void prn_dgv_two_stream_Click(object sender, EventArgs e)
        {
            StreamSavePrint(dgv_two);
        }

        //print left-hand reordered dgv via copy
        private void btn_prn_dgv_one_Click(object sender, EventArgs e)
        {
            CopySavePrint(dgv_one);
        }

        //print right-hand reordered dgv via copy
        private void btn_prn_dgv_two_Click(object sender, EventArgs e)
        {
            CopySavePrint(dgv_two);
        }

       

        private void CopySavePrint(DataGridView dgv)
        {
            //write with header
            dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            //or
            // write without header.
            //dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;


            // Select all the cells
            dgv.SelectAll();
            // Copy selected cells to DataObject
            DataObject dataObject = dgv.GetClipboardContent();
            // Get the text of the DataObject, and serialize it to a file
            File.WriteAllText(dgv.Name + "_copy.csv", dataObject.GetText(TextDataFormat.CommaSeparatedValue));
        }

        private void StreamSavePrint(DataGridView dgv)
        {
            var sb = new StringBuilder();
             

            var headers = dgv.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in dgv.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
            }

            File.WriteAllText(dgv.Name + "_stream.csv", sb.ToString());
        }
    }
}
