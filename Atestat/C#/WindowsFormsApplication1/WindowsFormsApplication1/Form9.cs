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

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Filme' table. You can move, or remove it, as needed.
            this.filmeTableAdapter.Fill(this.bazaFilmBoxDataSet.Filme);
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Actori' table. You can move, or remove it, as needed.
            this.actoriTableAdapter.FillByNumePrenume(this.bazaFilmBoxDataSet.Actori);
            for (int i = 0; i < this.bazaFilmBoxDataSet.Actori.Rows.Count; i++)
            {
                comboBox2.Items.Add(this.bazaFilmBoxDataSet.Actori.Rows[i]["Nume"]);
            }
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Roluri' table. You can move, or remove it, as needed.
            this.roluriTableAdapter.Fill(this.bazaFilmBoxDataSet.Roluri);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBox.Show(bazaFilmBoxDataSet.Filme.Rows[comboBox1.SelectedIndex]["IDF"].ToString());
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
    }
}
