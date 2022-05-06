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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
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

        private void regizoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.regizoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaFilmBoxDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Actori' table. You can move, or remove it, as needed.
            this.actoriTableAdapter.Fill(this.bazaFilmBoxDataSet.Actori);
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Regizori' table. You can move, or remove it, as needed.
            this.regizoriTableAdapter.Fill(this.bazaFilmBoxDataSet.Regizori);
            bazaFilmBoxDataSet.EnforceConstraints = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a, b;
            a=textBox1.Text;
            b=textBox2.Text;
            DateTime data = dateTimePicker1.Value;
            try
            {
                if (a != null && b != null)
                {
                    Byte[] imgBytes = null;
                    ImageConverter imgConverter = new ImageConverter();
                    imgBytes = (System.Byte[])imgConverter.ConvertTo(pictureBox1.Image, Type.GetType("System.Byte[]"));
                    this.regizoriTableAdapter.InsertQuery(a, b, data.ToString(), imgBytes);
                }
                else
                {
                    MessageBox.Show("Introduceti nume si prenume");
                }
            }
            catch
            {
                MessageBox.Show("eroare");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpeps|*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = openFileDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a, b;
            try
            {
                a = textBox3.Text;
                b = textBox4.Text;
                Byte[] imgBytes = null;
                ImageConverter imgConverter = new ImageConverter();
                imgBytes = (System.Byte[])imgConverter.ConvertTo(pictureBox2.Image, Type.GetType("System.Byte[]"));
                this.regizoriTableAdapter.UpdateQueryImagineRegizor(imgBytes, a, b);
            }
            catch
            {
                MessageBox.Show("Updatare esuata");
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a, b;
            try
            {
                a = textBox3.Text;
                b = textBox4.Text;
                this.regizoriTableAdapter.DeleteQuery(a, b);
                
            }
            catch
            {
                MessageBox.Show("Stergere esuata");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
