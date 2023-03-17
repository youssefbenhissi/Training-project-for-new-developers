using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCarApp
{
    public partial class Form2 : Form
    {
        public static bool isModify;
        public static Int64 idToBeModified;
        public static string nameToBeModified;
        public static string brandToBeModified;
        public static int horsePowerToBeModified;
        public static int mileageToBeModified;
        public static int numberOfWheelsToBeModified;
        public static string colorToBeModified;
        public static int serialNumberToBeModified;
        public static int numberOfLetersToBeModified;
        public static int ageToBeModified;
        public static bool isNew;
        private static System.Timers.Timer aTimer;
        private int rowIndex = 0;
        public Form2()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void Form2_Load(object sender, EventArgs e)
        {


            aTimer = new System.Timers.Timer(2000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {

            Cache cachOfCars = Cache.Instance;
            cachOfCars.setTimer();
            cachOfCars.printCars();
            RefreshGrid();

        }

        public void RefreshGrid()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("price", typeof(int));
            dt.Columns.Add("brand", typeof(string));
            dt.Columns.Add("horsePower", typeof(int));
            dt.Columns.Add("mileage", typeof(int));
            dt.Columns.Add("numberOfWheels", typeof(int));
            dt.Columns.Add("color", typeof(string));
            dt.Columns.Add("serialNumber", typeof(int));
            dt.Columns.Add("numberOfLeters", typeof(int));
            dt.Columns.Add("age", typeof(int));

            Cache cachOfCars = Cache.Instance;
            List<ModelsCarsApp.Car> list = cachOfCars.getListOfCars();

            foreach (ModelsCarsApp.Car c in list)
            {
                dt.Rows.Add(c.Id, c.Name, c.Price, c.Brand, c.HorsePower, c.Mileage, c.NumberOfWheels, c.Color, c.SerialNumber, c.NumberOfLeters, c.Age);
            }
            dataGridView1.Invoke(new MethodInvoker(delegate
            {
                if(dt.Rows.Count> 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }));
            
        }
        

        private void addACar(object sender, EventArgs e)
        {

            isNew = true;
            frmCars.isModify = false;
            FormOfACar formOfACar = new FormOfACar(this);
            formOfACar.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are you sure you want to delete the selected row(s) ?", "Delete a Row", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                dataGridView1.Rows.Cast<DataGridViewRow>()
                    .Where(x => !dataGridView1.SelectedRows.Contains(x) && !x.IsNewRow)
                    .ToList().ForEach(x => deleteArow(dataGridView1 , x));
                //if (!this.dataGridView1.Rows[this.rowIndex].IsNewRow)
                //{
                //    DataGridViewRow selectedRow = dataGridView1.Rows[this.rowIndex];
                //    Int64 cellValue = Convert.ToInt64(selectedRow.Cells["id"].Value);
                //    Cache cachOfCars = Cache.Instance;
                //    cachOfCars.deleteFromList(cellValue);
                //    this.dataGridView1.Rows.RemoveAt(this.rowIndex);
                //}
            }
        }
        private void deleteArow(DataGridView g,DataGridViewRow d)
        {
            Int64 cellValue = Convert.ToInt64(d.Cells["id"].Value);
            Cache cachOfCars = Cache.Instance;
            cachOfCars.deleteFromList(cellValue);
            g.Rows.Remove(d);
        }
        private void modifyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            isModify = true;

            Form2.isNew = false;
            DataGridViewRow selectedRow = dataGridView1.Rows[this.rowIndex];
            idToBeModified = Convert.ToInt64(selectedRow.Cells["id"].Value);
            nameToBeModified = Convert.ToString(selectedRow.Cells["name"].Value);
            brandToBeModified = Convert.ToString(selectedRow.Cells["brand"].Value);
            horsePowerToBeModified = Convert.ToInt16(selectedRow.Cells["horsePower"].Value);
            mileageToBeModified = Convert.ToInt16(selectedRow.Cells["mileage"].Value);
            numberOfWheelsToBeModified = Convert.ToInt16(selectedRow.Cells["numberOfWheels"].Value);
            colorToBeModified = Convert.ToString(selectedRow.Cells["color"].Value);
            serialNumberToBeModified = Convert.ToInt16(selectedRow.Cells["serialNumber"].Value);
            numberOfLetersToBeModified = Convert.ToInt16(selectedRow.Cells["numberOfLeters"].Value);
            ageToBeModified = Convert.ToInt16(selectedRow.Cells["age"].Value);

            FormOfACar formOfACar = new FormOfACar(this);
            formOfACar.Show();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {

            var hti = dataGridView1.HitTest(e.X, e.Y);
            Console.WriteLine(hti.RowIndex);
            if (hti.RowIndex != -1)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[hti.RowIndex].Selected = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                contextMenuStrip1.Show(Cursor.Position);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
    }
}
