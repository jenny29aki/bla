using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patientregistry
{
    public partial class enter : Form
    {
        public enter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "12345")
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enter_Load(object sender, EventArgs e)
        {

        }
    }
}
