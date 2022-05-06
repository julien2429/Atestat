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
    public partial class Form7 : Form
    {
        DataTable dt = new DataTable();
        int ID,IDF;
        public Form7(int IDU)
        {
            InitializeComponent();
            ID = IDU;
        }


        private void filmeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaFilmBoxDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Recenzie' table. You can move, or remove it, as needed.
            this.recenzieTableAdapter.Fill(this.bazaFilmBoxDataSet.Recenzie);
            // TODO: This line of code loads data into the 'bazaFilmBoxDataSet.Filme' table. You can move, or remove it, as needed
            bazaFilmBoxDataSet.EnforceConstraints = false;
            this.filmeTableAdapter.Fill(this.bazaFilmBoxDataSet.Filme);
            DataTable dt = this.bazaFilmBoxDataSet.Filme;
            UserControl2[] a = new UserControl2[20];
            flowLayoutPanel2.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                a[i] = new UserControl2(this);
                a[i].Titlu = dt.Rows[i]["Nume"].ToString();
                a[i].Img = (Bitmap)((new ImageConverter()).ConvertFrom(dt.Rows[i]["Poza"]));
                a[i].index = i;
                flowLayoutPanel2.Controls.Add(a[i]);

            }


        }

        private void dataRepeater1_CurrentItemIndexChanged(object sender, EventArgs e)
        {

        }

        private void filmeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pozaPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pozaPictureBox_Click_1(object sender, EventArgs e)
        {

        }

        private void pozaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {


        }
        private void pictureBox1(object sender, EventArgs e)
        {

        }

        private void dataRepeater1_CurrentItemIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void pozaLabel_Click(object sender, EventArgs e)
        {

        }

        private void pozaPictureBox_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void dataRepeater1_DrawItem(object sender, Microsoft.VisualBasic.PowerPacks.DataRepeaterItemEventArgs e)
        {
        }

        private void filmeBindingSource_PositionChanged(object sender, EventArgs e)
        {

        }

        private void dataRepeater1_CurrentItemIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void dataRepeater1_ItemsAdded(object sender, Microsoft.VisualBasic.PowerPacks.DataRepeaterAddRemoveItemsEventArgs e)
        {


        }

        private void pozaPictureBox_Click_2(object sender, EventArgs e)
        {

        }

        private void dataRepeater1_ItemTemplate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataRepeater1_CurrentItemIndexChanged_3(object sender, EventArgs e)
        {



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataRepeater1_CurrentItemIndexChanged_4(object sender, EventArgs e)
        {
            ///dataRepeater1.ItemTemplate.ItemIndex;

        }

        private void dataRepeater1_ItemTemplate_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataRepeater1_ItemTemplate_Layout(object sender, LayoutEventArgs e)
        {
            DataTable dt = this.bazaFilmBoxDataSet.Filme;

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {


        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
        private void populate(int index)
        {
            UserControl1[] a = new UserControl1[20];
            this.recenzieTableAdapter.FillByRecenziiCuNumeViaIDF(this.bazaFilmBoxDataSet.Recenzie, index + 1);
            DataTable dt = this.bazaFilmBoxDataSet.Recenzie;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                a[i] = new UserControl1();
                a[i].listBox1 = dt.Rows[i]["Titlu"].ToString();
                a[i].listBox2 = dt.Rows[i]["Nota"].ToString();
                a[i].utilizator = dt.Rows[i]["Username"].ToString();
                a[i].listBox3 = dt.Rows[i]["Descriere"].ToString();
                if (dt.Rows[i]["Datar"].ToString() != "")
                    a[i].datarDateTimePicker = Convert.ToDateTime(dt.Rows[i]["Datar"]);
                else
                {
                    a[i].datarDateTimePicker = DateTime.Now;
                }
                
                flowLayoutPanel1.Controls.Add(a[i]);
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }
        public void load(int index)
        {
 
            panel1.Visible = true;
            this.filmeTableAdapter.Fill(this.bazaFilmBoxDataSet.Filme);
            DataTable dt = this.bazaFilmBoxDataSet.Filme;
            Image x = (Bitmap)((new ImageConverter()).ConvertFrom(dt.Rows[index]["Poza"]));//!!!!!!!!!!!!!!!!!!!!!!!!!
            pictureBox2.Image = x;
            label2.Text = dt.Rows[index]["Nume"].ToString();
            int idf = Convert.ToInt32(dt.Rows[index]["IDF"]);
            IDF = idf;
            
            textBox1.Text = this.filmeTableAdapter.ScalarQueryNumeRegizorViaIDF(idf).ToString();
            this.filmeTableAdapter.FillByActoriRoluri(this.bazaFilmBoxDataSet.Filme, idf);
            dt = this.bazaFilmBoxDataSet.Filme;
            listBox2.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listBox2.Items.Add(dt.Rows[i]["Nume"] + " " + dt.Rows[i]["Prenume"] + " jucand rolul lui " + dt.Rows[i]["Npersonaj"]);
            }
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }
            populate(index);
            filmeTableAdapter.FillByNota(this.bazaFilmBoxDataSet.Filme, idf);
            DataTable b = this.bazaFilmBoxDataSet.Filme;
            double nota = 0;
            for (int i = 0; i < b.Rows.Count; i++)
            {
                nota += Convert.ToDouble(b.Rows[i]["Nota"]);
            }
            nota /= b.Rows.Count;
            textBox2.Text = nota.ToString();
            
        }
        private void userControl21_Click(object sender, EventArgs e)
        {
    
            
        }

        private void userControl21_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void userControl21_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 a = new Form8(ID, IDF);
            a.Show();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filmeTableAdapter.FillByActoriRoluri(this.bazaFilmBoxDataSet.Filme, IDF);
            dt = this.bazaFilmBoxDataSet.Filme;

            try
            {
                Form10 a = new Form10(Convert.ToInt32(dt.Rows[listBox2.SelectedIndex]["IDA"]));
                a.ShowDialog();
            }
            catch
            {
            }
        }
    }
}
