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
    public partial class statistics : Form
    {
        OleDbConnection connection;
        public statistics()
        {
            InitializeComponent();
        }

        private void statistics_Load(object sender, EventArgs e)
        {
         connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\registr_v3.mdb;Persist Security Info=True;User ID=admin;Jet OLEDB:Database Password=12345;Data Source = D:\диплом\patientregistry\registr_v3.mdb;");
          

        }
    }
}
