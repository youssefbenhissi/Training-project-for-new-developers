using System;
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
    public partial class FormOfACar : Form
    {
        private readonly Form2 frm2;
        public FormOfACar(Form2 frm)
        {
            InitializeComponent();
            frm2 = frm;
            if (Form2.isNew && !Form2.isModify)
            {
                buttonConfirm.Text = "Add";
                this.Text = "Add Car";
            }
            else
            {
                buttonConfirm.Text = "Modify";
                this.Text = "Modify Car";
                textBoxName.Text = Form2.nameToBeModified;
                textBoxBrand.Text = Form2.brandToBeModified;
                textBoxHorsePower.Text = Form2.horsePowerToBeModified.ToString();
                textBoxMileage.Text = Form2.mileageToBeModified.ToString();
                textBoxNumberOfWheels.Text = Form2.numberOfWheelsToBeModified.ToString();
                textBoxColor.Text = Form2.colorToBeModified;
                textBoxSerialNumber.Text = Form2.serialNumberToBeModified.ToString();
                textBoxNumberOfLeters.Text = Form2.numberOfLetersToBeModified.ToString();
                textBoxAge.Text = Form2.ageToBeModified.ToString();

            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text == "" || textBoxBrand.Text == "" || textBoxHorsePower.Text == "" || textBoxMileage.Text == "" || textBoxNumberOfWheels.Text == "" ||textBoxColor.Text == "" || textBoxSerialNumber.Text == "" || textBoxNumberOfLeters.Text == "" || textBoxAge.Text == "")
            {
                MessageBox.Show("Make sure taht all the fields are not empty", "Add a car");

            }
            else
            {
                Random rnd = new Random();
                Cache cachOfCars = Cache.Instance;
                
                if (Form2.isNew && !frmCars.isModify)
                {
                    ModelsCarsApp.Car car = new ModelsCarsApp.Car(rnd.Next(), textBoxName.Text, textBoxBrand.Text, Int16.Parse(textBoxHorsePower.Text), Int16.Parse(textBoxMileage.Text), Int16.Parse(textBoxNumberOfWheels.Text), textBoxColor.Text, Int16.Parse(textBoxSerialNumber.Text), Int16.Parse(textBoxNumberOfLeters.Text), Int16.Parse(textBoxAge.Text));
                    cachOfCars.AddCar(car);
                    MessageBox.Show("The car is added successfully", "Add a car");
                    frm2.RefreshGrid();
                }
                else
                {
                    ModelsCarsApp.Car car = new ModelsCarsApp.Car(rnd.Next(), textBoxName.Text, textBoxBrand.Text, Int16.Parse(textBoxHorsePower.Text), Int16.Parse(textBoxMileage.Text), Int16.Parse(textBoxNumberOfWheels.Text), textBoxColor.Text, Int16.Parse(textBoxSerialNumber.Text), Int16.Parse(textBoxNumberOfLeters.Text), Int16.Parse(textBoxAge.Text));
                    cachOfCars.modifyFromList(Form2.idToBeModified, textBoxName.Text, textBoxBrand.Text, Int16.Parse(textBoxHorsePower.Text), Int16.Parse(textBoxMileage.Text), Int16.Parse(textBoxNumberOfWheels.Text), textBoxColor.Text, Int16.Parse(textBoxSerialNumber.Text), Int16.Parse(textBoxNumberOfLeters.Text), Int16.Parse(textBoxAge.Text));
                    MessageBox.Show("The car is modified successfully", "Modify a car");
                    frm2.RefreshGrid();

                }
                this.Hide();
            }
        }

        private void FormOfACar_Load(object sender, EventArgs e)
        {

        }

        private void textBoxHorsePower_TextChanged(object sender, EventArgs e)
        {

        }

        private void horse_powerkey_press(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
