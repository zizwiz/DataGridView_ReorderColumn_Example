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
            dgv_one.Columns.Add("0", "Zero");
            dgv_one.Columns.Add("1", "One");
            dgv_one.Columns.Add("2", "Two");
            dgv_one.Columns.Add("3", "Three");
            dgv_one.Columns.Add("4", "Four");

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
                for (int j = 0; j < 5; j++)
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
            foreach (DataGridViewRow dgvr in dgv_one.Rows)
            {
                dgv_two.Rows.Add(dgvr.Clone() as DataGridViewRow);
            }

            for (int i = 0; i < 20; i++)
            {
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

        //print left-hand reordered dgv

        private void prn_dgv_one_stream_Click(object sender, EventArgs e)
        {
            //print lefthand dgv
            var sb = new StringBuilder();

            var headers = dgv_one.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in dgv_one.Rows)
            {
               var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
            }

            File.WriteAllText("StreamPrintdgv_left.csv", sb.ToString());
        }

        private void btn_prn_dgv_one_Click(object sender, EventArgs e)
        {

            //write with header
             dgv_one.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            //or
            // write without header.
           //dgv_one.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;


            // Select all the cells
            dgv_one.SelectAll();
            // Copy selected cells to DataObject
            DataObject dataObject = dgv_one.GetClipboardContent();
            // Get the text of the DataObject, and serialize it to a file
            File.WriteAllText("CopyPrintdgv_left.csv", dataObject.GetText(TextDataFormat.CommaSeparatedValue));


        }

        //print right-hand copied dgv

        private void btn_prn_dgv_two_Click(object sender, EventArgs e)
        {
            //write with header
            dgv_two.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            //or
            // write without header.
            //dgv_one.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;


            // Select all the cells
            dgv_two.SelectAll();
            // Copy selected cells to DataObject
            DataObject dataObject = dgv_two.GetClipboardContent();
            // Get the text of the DataObject, and serialize it to a file
            File.WriteAllText("CopyPrintdgv_right.csv", dataObject.GetText(TextDataFormat.CommaSeparatedValue));
        }

        private void prn_dgv_two_stream_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            var headers = dgv_two.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in dgv_two.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
            }

            File.WriteAllText("StreamPrintdgv_right.csv", sb.ToString());
        }
    }
}
