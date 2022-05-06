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
    public partial class Form8 : Form
    {
        public int idu, idf;
        public Form8(int IDU,int IDF)
        {
            InitializeComponent();
            idu = IDU;
            idf = IDF;
        }
        
        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Recenzie' table. You can move, or remove it, as needed.
            this.recenzieTableAdapter.Fill(this.bazaFilmBoxDataSet.Recenzie);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox2.Text != "")
                {
                    recenzieTableAdapter.InsertQuery(numericUpDown1.Value.ToString(), DateTime.Now.ToString(), textBox3.Text, textBox2.Text, idu, idf);
                    this.Close();
                }
            }
            catch
            {
            }
        }

        private void recenzieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.recenzieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaFilmBoxDataSet);

        }
    }
}
