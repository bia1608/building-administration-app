using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SubiectAtestat1
{
    public partial class WelcomeForm : Form
    {
        string res = Directory.GetCurrentDirectory() + @"\square-apartments.jpg";
        public WelcomeForm()
        {
            //Bitmap original = (Bitmap)Image.FromFile(res);
            //Bitmap resized = new Bitmap(original, new Size(ClientRectangle.Width, ClientRectangle.Height));
            //using (Graphics g = Graphics.FromImage(resized))
            //{
            //    g.DrawImage(this.BackgroundImage,
            //        new Rectangle(0, 0, resized.Width, resized.Height));
            //}
            ////this.BackgroundImage = (Image)resized;
            InitializeComponent();
            txtbPar.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num = txtbNum.Text;
            string par = txtbPar.Text;

            if(num == "admin" && par == "admin")
            {
                Form admin = new Admin();
                admin.Show();
                this.Hide();
            }
            else if(num == "locatar" && par == "locatar")
            {
                Form loc = new Locatar();
                loc.Show();
                this.Hide();
            }
        }
    }
}
