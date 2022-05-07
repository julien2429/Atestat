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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void populate()
        {
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Premii' table. You can move, or remove it, as needed.
            this.premiiTableAdapter.Fill(this.bazaFilmBoxDataSet.Premii);
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Recenzie' table. You can move, or remove it, as needed.
            this.recenzieTableAdapter.Fill(this.bazaFilmBoxDataSet.Recenzie);
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Roluri' table. You can move, or remove it, as needed.
            this.roluriTableAdapter.Fill(this.bazaFilmBoxDataSet.Roluri);
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Filme' table. You can move, or remove it, as needed.
            bazaFilmBoxDataSet.EnforceConstraints = false;

            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            this.regizoriTableAdapter.Fill(this.bazaFilmBoxDataSet.Regizori);
            DataTable dt = this.bazaFilmBoxDataSet.Regizori;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox2.Items.Add(dt.Rows[i]["Nume"] + " " + dt.Rows[i]["Prenume"]);
                comboBox3.Items.Add(dt.Rows[i]["Nume"] + " " + dt.Rows[i]["Prenume"]);
            }
            bazaFilmBoxDataSet.EnforceConstraints = false;
            this.filmeTableAdapter.Fill(this.bazaFilmBoxDataSet.Filme);
            dt = this.bazaFilmBoxDataSet.Filme;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox4.Items.Add(dt.Rows[i]["Nume"]);
            }
        }
        private void Form5_Load(object sender, EventArgs e){
        
            populate();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpeps|*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = openFileDialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a, b;
            int lungime = 0;
            a = textBox1.Text;
            b = comboBox2.SelectedItem.ToString();
            lungime = Convert.ToInt32(textBox7.Text);
            try
            {
                Byte[] imgBytes = null;
                ImageConverter imgConverter = new ImageConverter();
                imgBytes = (System.Byte[])imgConverter.ConvertTo(pictureBox1.Image, Type.GetType("System.Byte[]"));
                this.filmeTableAdapter.InsertQuery(a, dateTimePicker1.Value.ToString(), lungime, this.regizoriTableAdapter.ScalarQueryIDREviaNume(b).Value, imgBytes);
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a, b;
            a = comboBox1.Text;
            b = comboBox3.SelectedItem.ToString();
            try
            {
                Byte[] imgBytes = null;
                ImageConverter imgConverter = new ImageConverter();
                imgBytes = (System.Byte[])imgConverter.ConvertTo(pictureBox2.Image, Type.GetType("System.Byte[]"));
                this.filmeTableAdapter.UpdateQueryPozaFilm(imgBytes, a, this.regizoriTableAdapter.ScalarQueryIDREviaNume(b).Value);
            }
            catch
            {
                MessageBox.Show("eroare");
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.filmeTableAdapter.Fill(this.bazaFilmBoxDataSet.Filme);
            DataTable dt = this.bazaFilmBoxDataSet.Filme;
            int a = Convert.ToInt32(dt.Rows[comboBox4.SelectedIndex]["IDF"]);


            try
            {
                recenzieTableAdapter.DeleteFilm(a);
                premiiTableAdapter.DeleteFilm(a);
                roluriTableAdapter.DeleteFilm(a);
                this.filmeTableAdapter.DeleteQuery(a);
                MessageBox.Show("Stergere reusita");
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "eroare");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByNumeSiPrenumeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.regizoriTableAdapter.FillByNumeSiPrenume(this.bazaFilmBoxDataSet.Regizori);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
