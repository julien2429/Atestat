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
    public partial class Form6 : Form
    {
        public Form6()
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


        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Actori' table. You can move, or remove it, as needed.
            this.actoriTableAdapter.Fill(this.bazaFilmBoxDataSet.Actori);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a, b;
            a = textBox1.Text;
            b = textBox2.Text;
            DateTime data = dateTimePicker1.Value;
            try
            {
                if (a != null && b != null)
                {
                    Byte[] imgBytes = null;
                    ImageConverter imgConverter = new ImageConverter();
                    imgBytes = (System.Byte[])imgConverter.ConvertTo(pictureBox1.Image, Type.GetType("System.Byte[]"));
                    this.actoriTableAdapter.InsertQuery(a, b, data.ToString(), imgBytes);
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

        private void button2_Click(object sender, EventArgs e)
        {
            string a, b;
            try
            {
                a = comboBox1.Text;
                b = comboBox2.Text;
                Byte[] imgBytes = null;
                ImageConverter imgConverter = new ImageConverter();
                imgBytes = (System.Byte[])imgConverter.ConvertTo(pictureBox2.Image, Type.GetType("System.Byte[]"));
                this.actoriTableAdapter.UpdateQueryPozaActor(imgBytes, a + " " + b);
            }
            catch
            {
                MessageBox.Show("Updatare esuata");
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpeps|*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = openFileDialog.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a, b;
            a = comboBox4.Text;
            b = comboBox3.Text;
            try
            {
                this.actoriTableAdapter.DeleteQuery(a, b);
            }
            catch
            {
                MessageBox.Show("error");
            }
        }
    }
}
