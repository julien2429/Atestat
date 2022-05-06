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
    public partial class Form10 : Form
    {
        public int IDA;
        public Form10(int ida)
        {
            InitializeComponent();
            IDA = ida - 1;
        }


        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Actori' table. You can move, or remove it, as needed.
            bazaFilmBoxDataSet.EnforceConstraints = false;
            this.actoriTableAdapter.Fill(this.bazaFilmBoxDataSet.Actori);
            DataTable dt = this.bazaFilmBoxDataSet.Actori;
            textBox1.Text = dt.Rows[IDA]["Prenume"] + " " + dt.Rows[IDA]["Nume"];
            textBox2.Text = dt.Rows[IDA]["datan"].ToString();
            Image x = (Bitmap)((new ImageConverter()).ConvertFrom(dt.Rows[IDA]["Imagine"]));
            pictureBox1.Image = x;
            this.actoriTableAdapter.FillByRoluriViaIDA(this.bazaFilmBoxDataSet.Actori, IDA+1);
            DataTable b = this.bazaFilmBoxDataSet.Actori;
            try
            {


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listBox1.Items.Add(b.Rows[i]["Npersonaj"].ToString());
                }
            }
            catch
            {
            }



        }

        private void actoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.actoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaFilmBoxDataSet);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
