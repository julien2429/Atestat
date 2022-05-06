using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UserControl2 : UserControl
    {
        public Form parentForm { get; set; }
        public UserControl2()
        {
            InitializeComponent();
        }
        public UserControl2(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
        private string _titlu;
        private Image _x;

        [Category("Custom Props")]
        public string Titlu
        {
            get { return _titlu; }
            set { _titlu = value; label1.Text = value; }
        }
        [Category("Custom Props")]
        public Image Img
        {
            get { return _x; }
            set { _x = value; pictureBox1.Image = value; }
        }
        public int index;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void UserControl2_MouseClick(object sender, MouseEventArgs e)
        {
            Form7 a = (Form7) parentForm;
            a.load(index);
        }

    }
}
