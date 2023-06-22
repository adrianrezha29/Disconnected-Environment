using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected_Environment
{
    public partial class FormUtama : Form
    {
        private string stringConnection = "Data Source=REZHAA\\REZHA;" + "database=Act6;User ID=sa;Password=123";
        private SqlConnection koneksi;
        private string nim, nama, alamat, jk, prodi;
        private DateTime tgl;

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void dataStatusMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        BindingSource customersBindingSource = new BindingSource();
        private string kstr;
        public FormUtama()
        {
            InitializeComponent();
        }

        private void dataProdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
    }
}
