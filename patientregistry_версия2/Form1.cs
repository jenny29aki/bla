using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace patientregistry
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "registrDataSet.hospital". При необходимости она может быть перемещена или удалена.
            this.hospitalTableAdapter.Fill(this.registrDataSet.hospital);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "registrDataSet.treatment". При необходимости она может быть перемещена или удалена.
            this.treatmentTableAdapter.Fill(this.registrDataSet.treatment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "registrDataSet.DEXA". При необходимости она может быть перемещена или удалена.
            this.dEXATableAdapter.Fill(this.registrDataSet.DEXA);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "registrDataSet.lab". При необходимости она может быть перемещена или удалена.
            this.labTableAdapter.Fill(this.registrDataSet.lab);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "registrDataSet.interview". При необходимости она может быть перемещена или удалена.
            this.interviewTableAdapter.Fill(this.registrDataSet.interview);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "registrDataSet.interview". При необходимости она может быть перемещена или удалена.
            this.interviewTableAdapter.Fill(this.registrDataSet.interview);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "registrDataSet.sex". При необходимости она может быть перемещена или удалена.
            this.sexTableAdapter.Fill(this.registrDataSet.sex);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "registrDataSet.patient_information". При необходимости она может быть перемещена или удалена.
            this.patient_informationTableAdapter.Fill(this.registrDataSet.patient_information);
            numberOfPatient.Text = "Количество пациентов в регистре: " + Convert.ToString(patient_informationDataGridView.RowCount - 1);

        }

        private void first_nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void regionLabel_Click(object sender, EventArgs e)
        {

        }

        private void roomTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sex_of_personeLabel_Click(object sender, EventArgs e)
        {

        }

        private void social_statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void date_of_interviewMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void date_of_interviewLabel_Click(object sender, EventArgs e)
        {

        }

        private void fRAXTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void code_interviewTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_patientTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void patientRegistrySaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.patient_informationBindingSource.EndEdit();
                patient_informationTableAdapter.Update(this.registrDataSet.patient_information);
                this.tableAdapterManager.UpdateAll(this.registrDataSet);

                MessageBox.Show("Изменения сохранены", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (System.Exception)
            {
                MessageBox.Show("Изменения не сохранены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bindingNavigatorSaveRF_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.patient_informationBindingSource.EndEdit();
                this.patientInformationinterviewBindingSource.EndEdit();
                this.interviewBindingSource.EndEdit();
                interviewTableAdapter.Update(this.registrDataSet.interview);
                this.tableAdapterManager.UpdateAll(this.registrDataSet);
                MessageBox.Show("Изменения сохранены", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (System.Exception)
            {
                MessageBox.Show("Изменения не сохранены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.patient_informationBindingSource.EndEdit();
                this.patientInformationlabBindingSource.EndEdit();
                this.labBindingSource.EndEdit();
                labTableAdapter.Update(this.registrDataSet.lab);
                this.tableAdapterManager.UpdateAll(this.registrDataSet);
                MessageBox.Show("Изменения сохранены", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (System.Exception)
            {
                MessageBox.Show("Изменения не сохранены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.patient_informationBindingSource.EndEdit();
                this.patientInformationDEXABindingSource.EndEdit();
                this.dEXABindingSource.EndEdit();
                dEXATableAdapter.Update(this.registrDataSet.DEXA);
                this.tableAdapterManager.UpdateAll(this.registrDataSet);
                MessageBox.Show("Изменения сохранены", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (System.Exception)
            {
                MessageBox.Show("Изменения не сохранены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.patient_informationBindingSource.EndEdit();
                this.patientInformationtreatmentBindingSource.EndEdit();
                this.treatmentBindingSource.EndEdit();
                treatmentTableAdapter.Update(this.registrDataSet.treatment);
                this.tableAdapterManager.UpdateAll(this.registrDataSet);
                MessageBox.Show("Изменения сохранены", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (System.Exception)
            {
                MessageBox.Show("Изменения не сохранены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.patient_informationBindingSource.EndEdit();
                this.patientInformationhospitalBindingSource.EndEdit();
                this.hospitalBindingSource.EndEdit();
                hospitalTableAdapter.Update(this.registrDataSet.hospital);
                this.tableAdapterManager.UpdateAll(this.registrDataSet);
                MessageBox.Show("Изменения сохранены", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (System.Exception)
            {
                MessageBox.Show("Изменения не сохранены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            diagram Form = new diagram();
            Form.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            patient_informationBindingSource.Filter = "surname = \'" + searchTextBox.Text + "\'";
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.shef.ac.uk/FRAX/tool.aspx?country=13");
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@"javascript:function load (){document.getElementById('ContentPlaceHolder1_toolage').value=" + ageTextBox.Text + ";document.getElementById('ContentPlaceHolder1_ht').value=" + heightTextBox.Text + ";document.getElementById('ContentPlaceHolder1_toolweight').value=" + weightTextBox.Text + ";document.getElementById('ContentPlaceHolder1_previousfracture2').checked = true;document.getElementById('ContentPlaceHolder1_previousfracture1').checked = false;}load();");
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("ContentPlaceHolder1_btnCalculate").InvokeMember("click");
            FRAX.Text = webBrowser1.Document.GetElementById("ContentPlaceHolder1_lbbmi").InnerText;
            // double dbFrax = Double.Parse(FRAX.Text.Split(':')[1], CultureInfo.InvariantCulture);
            webBrowser1.Dispose();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void sex_of_personeLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewRF_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {


        }

        private void type_of_fractureLabel_Click(object sender, EventArgs e)
        {

        }

        private void добавитьПациентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPat add = new addPat();
            add.ShowDialog();
        }

        private void birth_dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            this.registrDataSet.patient_information.Clear();
            this.patient_informationTableAdapter.Fill(this.registrDataSet.patient_information);
            patient_informationDataGridView.DataSource = null;
            patient_informationDataGridView.DataSource = this.registrDataSet.patient_information;

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                Environment.Exit(0);
                // Application.ExitThread();
            }
            else e.Cancel = true;


        }

        private void houseLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            DateTime date1 = DateTime.Parse(discharge_dateDateTimePicker.Value.ToString("dd/MM/yyyy"));
            DateTime date2 = DateTime.Parse(arrival_dateDateTimePicker.Value.ToString("dd/MM/yyyy"));
            System.TimeSpan diff = date1.Subtract(date2);
            var otvet = diff.Days;
            countDay.Text = "Дней проведено в стационаре: " + otvet;

        }

        private void Fraxbtn_Click(object sender, EventArgs e)
        {


            //  HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.shef.ac.uk/FRAX/tool.aspx?country=13");
            // request.Method = "POST";
            // string postData = @"javascript:function load (){document.getElementById('ContentPlaceHolder1_toolage').value=" + ageTextBox.Text + ";document.getElementById('ContentPlaceHolder1_ht').value=" + heightTextBox.Text + ";document.getElementById('ContentPlaceHolder1_toolweight').value=" + weightTextBox.Text + ";document.getElementById('ContentPlaceHolder1_previousfracture2').checked = true;document.getElementById('ContentPlaceHolder1_previousfracture1').checked = false;}load();";

            //  HttpWebResponse response = (HttpWebResponse)request.GetResponse();



            webBrowser1.Navigate("http://www.shef.ac.uk/FRAX/tool.aspx?country=13");
            webBrowser1.Navigate(@"javascript:function load (){document.getElementById('ContentPlaceHolder1_toolage').value=" + ageTextBox.Text + ";document.getElementById('ContentPlaceHolder1_ht').value=" + heightTextBox.Text + ";document.getElementById('ContentPlaceHolder1_toolweight').value=" + weightTextBox.Text + ";document.getElementById('ContentPlaceHolder1_previousfracture2').checked = true;document.getElementById('ContentPlaceHolder1_previousfracture1').checked = false;document.getEllementById('ContentPlaceHolder1_pfracturehip1').checked = false;document.getEllementById('ContentPlaceHolder1_pfracturehip2').checked = true}load();");
            webBrowser1.Document.GetElementById("ContentPlaceHolder1_btnCalculate").InvokeMember("click");
            FRAX.Text = webBrowser1.Document.GetElementById("ContentPlaceHolder1_lbbmi").InnerText;
            double dbFrax = Double.Parse(FRAX.Text.Split(':')[1], CultureInfo.InvariantCulture);
            webBrowser1.Dispose();

        }

        private void numberOfPatient_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {

        }

        private void удалитьПациентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int result = 0;
            
            DialogResult res = MessageBox.Show("Удалить запись?", "Удаление сведений о пациенте", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (res)
            {
                case DialogResult.Yes:
                    

                    using (System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\registr_v3.mdb;Persist Security Info=True;User ID=admin;Jet OLEDB:Database Password=12345"))
                    {
                        using (System.Data.OleDb.OleDbCommand cm = new System.Data.OleDb.OleDbCommand())
                        {
                            try
                            {
                                DataGridViewRow position = patient_informationDataGridView.Rows[0];
                                cm.CommandType = CommandType.Text;
                                cm.CommandText = "DELETE FROM [patient information] WHERE [id patient] ='" + patient_informationDataGridView.SelectedRows.Contains(position) + "';";
                                cm.Connection = conn;
                                conn.Open();
                                result = cm.ExecuteNonQuery();
                                conn.Close();


                                MessageBox.Show("Запись успешно удалена");
                            }
                            catch (System.Data.OleDb.OleDbException oEx)
                            {
                                MessageBox.Show("Ошибка подключения к базе данных: " + oEx.ToString());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка удаления данных: " + ex.ToString());
                            }

                        }
                    }

                    break;
                case DialogResult.No:

                    break;

            }

            return;

            
        }




        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statistics statPat = new statistics();
            statPat.ShowDialog();
            this.Hide();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
