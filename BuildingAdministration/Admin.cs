using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SubiectAtestat1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blocDBMesajeDataSet.Mesaje' table. You can move, or remove it, as needed.
            this.mesajeTableAdapter.Fill(this.blocDBMesajeDataSet.Mesaje);
            // TODO: This line of code loads data into the 'blocDBDataSet1.locatari' table. You can move, or remove it, as needed.
            this.locatariTableAdapter.Fill(this.blocDBDataSet1.locatari);

            dgvMesaje.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLocatari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                
            int an;
            bool ok2 = int.TryParse(txtbYear.Text, out an);
            if (!ok2)
            {
                MessageBox.Show("Anul nu este valid!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbYear.Text = "";
            }
            bool angaj = false;
            if (rbYesEmplyed.Checked == true)
                angaj = true;
            else if (rbNoEmployed.Checked == false)
                angaj = false;

            locatariTableAdapter.InsertLocatar(nume, nr_bloc, nr_ap, an, angaj);
            this.locatariTableAdapter.Fill(this.blocDBDataSet1.locatari);
        }

        private void rbEmployed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmployed.Checked == true && rbNotEmployed.Checked == false)
                locatariTableAdapter.SelectEmployed(blocDBDataSet1.locatari);
            else if (rbEmployed.Checked == false && rbNotEmployed.Checked == true)
                locatariTableAdapter.SelectNotEmplyed(blocDBDataSet1.locatari);
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form wel = new WelcomeForm();
            wel.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string v = comboBox1.GetItemText(comboBox1.SelectedIndex);
            int id = int.Parse(v) + 1;
            this.mesajeTableAdapter.DeleteMesaj(id);
            this.mesajeTableAdapter.Fill(this.blocDBMesajeDataSet.Mesaje);
        }
    }
}
