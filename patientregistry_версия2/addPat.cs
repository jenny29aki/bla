using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace patientregistry
{
    public partial class addPat : Form
    {
        OleDbConnection conn;
        public addPat()
        {
            InitializeComponent();
        }

        private void addPat_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\registr_v3.mdb;Persist Security Info=True;User ID=admin;Jet OLEDB:Database Password=12345");
            String count = "SELECT count(*) FROM [patient information]";
            OleDbCommand addd = new OleDbCommand(count, conn);
            conn.Open();
            textBox1.Text = System.Convert.ToString(addd.ExecuteScalar());
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void regionLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query =(@"INSERT INTO [patient information]([id patient], surname, [first name], [middle name], [contact telephone], [birth date], [sex of persone], [medical insurance policy], [social status], locality, region, street, house, corps, room) VALUES (@id, @surname, @firstName, @middleName, @numb, @birth, @sex, @policy, @socStatus, @local, @reg, @street, @house, @corp, @room) ");
            OleDbCommand addd = new OleDbCommand(query, conn);
            addd.Parameters.Add("@id", Int32.Parse(id_patientTextBox.Text));
            addd.Parameters.Add("@surname", surnameTextBox.Text);
            addd.Parameters.Add("@firstName", first_nameTextBox.Text);
            addd.Parameters.Add("@middleName", middle_nameTextBox.Text);
            addd.Parameters.Add("@numb", Convert.ToString(contact_telephoneTextBox.Text));
            addd.Parameters.Add("@birth", Convert.ToDateTime(birthDate.Value.ToString("dd/MM/yyyy")));
            addd.Parameters.Add("@sex", sex_of_personeComboBox.SelectedText);
            addd.Parameters.Add("@policy", Convert.ToString(medical_insurance_policyTextBox.Text));
            addd.Parameters.Add("@socStatus",Convert.ToString(social_statusComboBox.SelectedText));
            addd.Parameters.Add("@local", localityTextBox.Text);
            addd.Parameters.Add("@reg", Convert.ToString(regionTextBox.Text));
            addd.Parameters.Add("@street", Convert.ToString(streetTextBox.Text));
            addd.Parameters.Add("@house", Convert.ToInt32(houseTextBox.Text));
            addd.Parameters.Add("@corp", Convert.ToInt32(corpsTextBox.Text));
            addd.Parameters.Add("@room", Convert.ToInt32(roomTextBox.Text));
            addd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Запись добавлена");
        }

        private void id_patientTextBox_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void id_patientTextBox_MouseClick(object sender, MouseEventArgs e)
        {
          
 
        }

        private void id_patientTextBox_Enter(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text), b;
            b = a + 1;
            id_patientTextBox.Text = Convert.ToString(b);
        }
    }
}
