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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.utilizatoriTableAdapter.Fill(this.bazaFilmBoxDataSet.Utilizatori);
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;
            DateTime data = dateTimePicker1.Value;
            string d = textBox4.Text;
            try
            {
                int z = this.utilizatoriTableAdapter.ScalarQueryIDviaUsername(a).Value;
                MessageBox.Show("Exista Acest Utilizator");
            }
            catch
            {
                if (b == c)
                {
                    try
                    {
                        Byte[] imgBytes = null;                                                                            //!!!!!!!!!!!!!!!!!!!!
                        ImageConverter imgConverter = new ImageConverter();                                                //!!!!!!!!!!!!!!!!!!!!
                        imgBytes = (System.Byte[])imgConverter.ConvertTo(pictureBox1.Image, Type.GetType("System.Byte[]"));//!!!!!!!!!!!!!!!!!!!!

                        this.utilizatoriTableAdapter.InsertQuery(a, d, data.ToString(), b,          imgBytes            ,checkBox1.Checked);
                        this.Close();
                    }
                    catch
                    {
                        this.utilizatoriTableAdapter.InsertQuery(a, d, data.ToString(), b, null, checkBox1.Checked);
                    }
                }
                else
                {
                    MessageBox.Show("Parolele nu sunt la fel");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            if (s1.IndexOf("Admin") != -1)
            {
                checkBox1.Visible = true;
            }
            else
                checkBox1.Visible = false;
        }

        private void utilizatoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilizatoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaFilmBoxDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Utilizatori' table. You can move, or remove it, as needed.
            //this.utilizatoriTableAdapter.Fill(this.bazaFilmBoxDataSet.Utilizatori);
            bazaFilmBoxDataSet.EnforceConstraints = false;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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
        }
    }
}
