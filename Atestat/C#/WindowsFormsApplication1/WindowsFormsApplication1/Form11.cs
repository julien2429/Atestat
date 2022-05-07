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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void filmeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaFilmBoxDataSet);

        }
        public static int apare(int[] v,int idf,int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (v[i] == idf)
                    return 0;
            }
            return 1;
        }
        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Regizori' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Utilizatori' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Filme' table. You can move, or remove it, as needed.
            bazaFilmBoxDataSet.EnforceConstraints = false;
            this.filmeTableAdapter.FillByTopFilme(this.bazaFilmBoxDataSet.Filme);
            DataTable dt = this.bazaFilmBoxDataSet.Filme;
            UserControl2[] a = new UserControl2[20];
            flowLayoutPanel1.Controls.Clear();
            int idf = 0;
            int[] v= new int[200];
            int n=0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                if (apare(v,Convert.ToInt32(dt.Rows[i]["IDF"]),n)==1)
                {
                    idf = Convert.ToInt32(dt.Rows[i]["IDF"]);
                    v[n] = idf;
                    n++;
                    a[i] = new UserControl2(this);
                    a[i].Titlu = dt.Rows[i]["Nume"].ToString();
                    a[i].Img = (Bitmap)((new ImageConverter()).ConvertFrom(dt.Rows[i]["Poza"]));
                    a[i].index = i;
                    flowLayoutPanel1.Controls.Add(a[i]);
                }

            }
            this.utilizatoriTableAdapter.FillByNumarRecenziiUtilizatori(this.bazaFilmBoxDataSet.Utilizatori);
            dt = this.bazaFilmBoxDataSet.Utilizatori;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listBox1.Items.Add(dt.Rows[i]["Username"] + " " + dt.Rows[i]["NRecenzii"]);
            }

            this.regizoriTableAdapter.FillByNumarFilmeRegizor(this.bazaFilmBoxDataSet.Regizori);
            dt = this.bazaFilmBoxDataSet.Regizori;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listBox2.Items.Add(regizoriTableAdapter.ScalarQueryNumePrenumeIDRE(Convert.ToInt32(dt.Rows[i]["IDRE"])).ToString() + " " + dt.Rows[i]["NFilme"]);
            }
            this.filmeTableAdapter.FillByNumarPremiiFilme(this.bazaFilmBoxDataSet.Filme);
            dt = this.bazaFilmBoxDataSet.Filme;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listBox3.Items.Add(dt.Rows[i]["Nume"] + " " + dt.Rows[i]["NPremii"] + " premii");
            }

        }

        
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
