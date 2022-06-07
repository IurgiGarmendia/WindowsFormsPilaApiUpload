using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPilaApiUpload
{
    public partial class FrmOpen : Form
    {
        Form2 form2;
        public FrmOpen()
        {
            InitializeComponent();
            form2 = new Form2() ;
            this.button1.LostFocus += Button1_LostFocus;
        }

        private void Button1_LostFocus(object sender, EventArgs e)
        {
            //MessageBox.Show("galdu dek");
        }

        private void FrmOpen_Load(object sender, EventArgs e)
        {
            //Thread.Sleep(10000);
            //FrmNoChild frmNoChild = new FrmNoChild();
            //frmNoChild.Show();
           
            form2.Show();
            DataTable table = GetTable();
            dataGridView1.DataSource = table;
            DataGridViewComboBoxColumn dcombo;
            dcombo =(DataGridViewComboBoxColumn) dataGridView1.Columns["Column1"];
            
            DataTable tableCombo = GetTableCombo();
            tableCombo.Rows.Add("--select--", "0");
            //dcombo.Items.Insert(0, "--select--");
            dcombo.DataSource = tableCombo;
            dcombo.DisplayMember = "BusId";
            dcombo.ValueMember = "Id";
            //dcombo.Items.Add("--select--");
            //dcombo.DisplayIndex = 2;
            //dcombo.Value = "Select Country";


        }


        public DataTable GetTable()
        {
            // Here we create a DataTable with four columns.
            DataTable table = new DataTable();
            table.Columns.Add("Column1", typeof(string));
            table.Columns.Add("Column2", typeof(string));
            

            // Here we add five DataRows.
            table.Rows.Add("bat1","bat2");
            table.Rows.Add("bi12", "bi2");

            return table;
        }

        public DataTable GetTableCombo()
        {
            // Here we create a DataTable with four columns.
            DataTable table = new DataTable();
            table.Columns.Add("BusId", typeof(string));
            table.Columns.Add("Id", typeof(string));


            // Here we add five DataRows.
            table.Rows.Add("bat", "1");
            table.Rows.Add("bi", "2");

            return table;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var task = luzeTarea();
            task.Start();
        }

        private Task luzeTarea()
        {
            return new Task(() =>
            {
                Thread.Sleep(10000);
            });
        }
        public void closeform2()
        {
            form2.Close();
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //DataGridView senderra = (DataGridView) sender;
            //string selectedcheckbox = senderra.CurrentCell.EditedFormattedValue.ToString();
            //MessageBox.Show("Selected: " + selectedcheckbox);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView senderra = (DataGridView)sender;
            //string selectedcheckbox = senderra.CurrentCell.EditedFormattedValue.ToString();
            //MessageBox.Show("Selected: " + selectedcheckbox);
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView senderra = (DataGridView)sender;
            //string selectedcheckbox = senderra.CurrentCell.EditedFormattedValue.ToString();
            //MessageBox.Show("Selected: " + selectedcheckbox);
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //DataGridView senderra = (DataGridView)sender;
            //string selectedcheckbox = senderra.CurrentCell.EditedFormattedValue.ToString();
            //MessageBox.Show("Selected: " + selectedcheckbox);

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderra = (DataGridView)sender;

            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentCell!=null)
            {
                string headerText = dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].HeaderText;
                if (headerText == "Column1" || headerText == "Usuario" || headerText == "Estado")
                {
                    string selectedcheckbox = senderra.CurrentCell.EditedFormattedValue.ToString();
                    MessageBox.Show("Selected: " + selectedcheckbox);
                }
            }
        }
    }
}
