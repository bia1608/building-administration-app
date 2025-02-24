using BuildingAdministrator.BlocDBDataSet1TableAdapters;
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

namespace SubiectAtestat1
{
    public partial class Locatar : Form
    {
        const string conStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\BlocDB.mdf;Integrated Security=True";
        public Locatar()
        {
            InitializeComponent();
            dgvMsj.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void InsertMesaj(string num, string nrbl, int nrap, string msj, DateTime dt, bool urg)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string query = "INSERT INTO Mesaje ([NUME], [NR_BLOC], [NR_AP], [MESAJ], [DATA], [URGENT]) VALUES (@NUME, @NRB, @NRAP, @MESAJ, @DATA, @URGENT);";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@NUME", num);
            cmd.Parameters.AddWithValue("@NRB", nrbl);
            cmd.Parameters.AddWithValue("@NRAP", nrap);
            cmd.Parameters.AddWithValue("@MESAJ", msj);
            cmd.Parameters.AddWithValue("@DATA", dt);
            cmd.Parameters.AddWithValue("@URGENT", urg);
            cmd.ExecuteReader();
            con.Close();
            con.Dispose();
        }

        private void Locatar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nume = txtbName.Text;
            string nr_bloc = txtbNrBlock.Text;

            int nr_ap;
            bool ok1 = int.TryParse(txtbNrAp.Text, out nr_ap);
            if (!ok1)
            {
                MessageBox.Show("Numarul apartamentului nu este valid!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbNrAp.Text = "";
            }

            string msj = rtbMesaj.Text;
            DateTime dt = DateTime.Now;

            bool u = false;
            if (rbDa.Checked == true)
                u = true;
            else if (rbNu.Checked == true)
                u = false;
            else MessageBox.Show("Completati toate campurile!");

            mesajeTableAdapter.InsertMesaj(nume, nr_bloc, nr_ap, msj, dt.ToString(), u);
            this.mesajeTableAdapter.Fill(this.blocDBDataSet.Mesaje);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form wel = new WelcomeForm();
            wel.Show();
            this.Hide();
        }

        private void Locatar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blocDBDataSet.Mesaje' table. You can move, or remove it, as needed.
            this.mesajeTableAdapter.Fill(this.blocDBDataSet.Mesaje);

        }
    }
}
