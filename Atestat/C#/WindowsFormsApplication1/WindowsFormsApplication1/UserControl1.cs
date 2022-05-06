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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
        }

        private string _titlu;
        private string _review;
        private string _descriere;
        private DateTime _data;
        private string _nume;

        [Category("Custom Props")]
        public string listBox1
        {
            get { return _titlu; }
            set { _titlu = value; lbltTitlu.Text = value; }
        }
        
        [Category("Custom Props")]
        public string listBox2
        {
            get { return _review; }
            set { _review = value; lblNota.Text = value; }
        }
        
        [Category("Custom Props")]
        public string listBox3
        {
            get { return _descriere; }
            set { _descriere = value; lblDescriere.Text = value; }
        }
        
        [Category("Custom Props")]
        public DateTime datarDateTimePicker
        {
            get { return _data; }
            set { _data = value; lblData.Text = value.ToString(); }
        }
        public string utilizator
        {
            get {return _nume; }
            set { _nume = value; textBox1.Text = value; }
        }

        private void dataDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
