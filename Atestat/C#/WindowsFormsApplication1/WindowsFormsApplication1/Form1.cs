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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Select();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.utilizatoriTableAdapter.Fill(this.bazaFilmBoxDataSet.Utilizatori);
            string a = textBox1.Text;
            string b = textBox2.Text;
            try
            {
                
                int id = this.utilizatoriTableAdapter.ScalarQueryReturnIdUtilizator(a, b).Value;
                Form3 pag = new Form3(a);
                pag.ShowDialog();
                

            }
            catch
            {
                MessageBox.Show("Logare esuata");
            }
        }

        private void utilizatoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilizatoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaFilmBoxDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Utilizatori' table. You can move, or remove it, as needed.
            ///this.utilizatoriTableAdapter.Fill(this.bazaFilmBoxDataSet.Utilizatori);
            ///bazaFilmBoxDataSet.EnforceConstraints = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form2 a = new Form2();
            a.ShowDialog();

        }
    }
}
