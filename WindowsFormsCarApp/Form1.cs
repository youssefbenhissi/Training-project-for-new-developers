using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsCarApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(
               this.ClientSize.Width / 2 - panel1.Size.Width / 2,
               this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;

            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
            panel1.Height, 30, 30));
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            // Define a regular expression for repeated words.
            Regex rx = new Regex(@"(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^A-Za-z0-9])(?=.{8,})",
              RegexOptions.Compiled | RegexOptions.IgnoreCase);

            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("your userName is empty","Wrong Credentials",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("your password is empty", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (!rx.IsMatch(passwordTextBox.Text))
            {
                MessageBox.Show("your password is wrong", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                Form2 form = new Form2();
                form.Show();
            }
        }
    }
}
