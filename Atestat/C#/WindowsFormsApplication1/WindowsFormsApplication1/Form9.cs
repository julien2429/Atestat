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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void roluriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roluriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaFilmBoxDataSet);

        }

        public void populate()
        {
            this.filmeTableAdapter.Fill(this.bazaFilmBoxDataSet.Filme);
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Actori' table. You can move, or remove it, as needed.
            this.actoriTableAdapter.FillByNumePrenume(this.bazaFilmBoxDataSet.Actori);
            comboBox3.Items.Clear();
            comboBox2.Items.Clear();
            for (int i = 0; i < this.bazaFilmBoxDataSet.Actori.Rows.Count; i++)
            {
                comboBox2.Items.Add(this.bazaFilmBoxDataSet.Actori.Rows[i]["Nume"]);
            }
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Roluri' table. You can move, or remove it, as needed.
            this.actoriTableAdapter.Fill(this.bazaFilmBoxDataSet.Actori);
            for (int i = 0; i < this.bazaFilmBoxDataSet.Actori.Rows.Count; i++)
            {
                comboBox3.Items.Add(this.bazaFilmBoxDataSet.Actori.Rows[i]["Nume"] +" "+ this.bazaFilmBoxDataSet.Actori.Rows[i]["Prenume"]);
            }
        }


        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Filme' table. You can move, or remove it, as needed.
            populate();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBox.Show("Adaugare reusita");
                roluriTableAdapter.InsertQuery(textBox1.Text, Convert.ToInt32(bazaFilmBoxDataSet.Actori.Rows[comboBox2.SelectedIndex]["IDA"]), Convert.ToInt32(bazaFilmBoxDataSet.Filme.Rows[comboBox1.SelectedIndex]["IDF"]));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.actoriTableAdapter.FillBy(this.bazaFilmBoxDataSet.Actori);
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByNumePrenumeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.actoriTableAdapter.FillByNumePrenume(this.bazaFilmBoxDataSet.Actori);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByNumePrenume1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.actoriTableAdapter.FillByNumePrenume1(this.bazaFilmBoxDataSet.Actori);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByNumePrenumeToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.actoriTableAdapter.FillByNumePrenume(this.bazaFilmBoxDataSet.Actori);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.actoriTableAdapter.Fill(this.bazaFilmBoxDataSet.Actori);
            this.roluriTableAdapter.FillByRoluriActor(this.bazaFilmBoxDataSet.Roluri, Convert.ToInt32(bazaFilmBoxDataSet.Actori.Rows[comboBox3.SelectedIndex]["IDA"]));
            comboBox4.Items.Clear();
            for (int i = 0; i < this.bazaFilmBoxDataSet.Roluri.Rows.Count; i++)
            {
                    comboBox4.Items.Add(this.bazaFilmBoxDataSet.Roluri.Rows[i]["Npersonaj"]);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.roluriTableAdapter.FillByRoluriActor(this.bazaFilmBoxDataSet.Roluri, Convert.ToInt32(bazaFilmBoxDataSet.Actori.Rows[comboBox3.SelectedIndex]["IDA"]));
            try
            {
                roluriTableAdapter.DeleteIDRO(Convert.ToInt32(bazaFilmBoxDataSet.Roluri[comboBox4.SelectedIndex]["IDRO"]));
                MessageBox.Show("Stergere Reusita");
                populate();
            }
            catch
            {
                MessageBox.Show("Eroare");
            }
            
        }
    }
}
