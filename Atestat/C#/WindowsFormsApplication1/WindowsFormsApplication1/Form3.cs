using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public static string a;
        public Form3(string A)
        {
            InitializeComponent();
            a = A;
        }

        private void utilizatoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilizatoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaFilmBoxDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Utilizatori' table. You can move, or remove it, as needed.
            this.utilizatoriTableAdapter.Fill(this.bazaFilmBoxDataSet.Utilizatori);
            bazaFilmBoxDataSet.EnforceConstraints = false;
            label1.Text = "Hello " + a;
            try
            {
                bool ok = this.utilizatoriTableAdapter.ScalarQueryIsAdmin(a).Value;
                if (ok == true)
                {
                    button2.Visible = true;
                    button1.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    button6.Visible = true;
                }

            }
            catch
            {
            }
            try
            {
                Image x = (Bitmap)((new ImageConverter()).ConvertFrom(this.utilizatoriTableAdapter.ScalarQueryReturnPoza(a)));
                pictureBox1.Image = x;
            }
            catch
            {
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpeps|*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
            try
            {
                this.utilizatoriTableAdapter.UpdateQueryAdaugarePoza(null, a);
                Byte[] imgBytes = null;
                ImageConverter imgConverter = new ImageConverter();
                imgBytes = (System.Byte[])imgConverter.ConvertTo(pictureBox1.Image, Type.GetType("System.Byte[]"));
                this.utilizatoriTableAdapter.UpdateQueryAdaugarePoza(imgBytes, a);
            }
            catch
            {
                MessageBox.Show("Nu s-a reusit adaugarea pozei");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7(utilizatoriTableAdapter.ScalarQueryIDviaUsername(a).Value);
            f7.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form11 a = new Form11();
            a.Show();
        }
    }
}
