namespace WindowsFormsApplication1
{
    partial class Form10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bazaFilmBoxDataSet = new WindowsFormsApplication1.BazaFilmBoxDataSet();
            this.actoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actoriTableAdapter = new WindowsFormsApplication1.BazaFilmBoxDataSetTableAdapters.ActoriTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.BazaFilmBoxDataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bazaFilmBoxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Nasterii";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 256);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(327, 121);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Roluri";
            // 
            // bazaFilmBoxDataSet
            // 
            this.bazaFilmBoxDataSet.DataSetName = "BazaFilmBoxDataSet";
            this.bazaFilmBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actoriBindingSource
            // 
            this.actoriBindingSource.DataMember = "Actori";
            this.actoriBindingSource.DataSource = this.bazaFilmBoxDataSet;
            // 
            // actoriTableAdapter
            // 
            this.actoriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActoriTableAdapter = this.actoriTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilmeTableAdapter = null;
            this.tableAdapterManager.PremiiTableAdapter = null;
            this.tableAdapterManager.RecenzieTableAdapter = null;
            this.tableAdapterManager.RegizoriTableAdapter = null;
            this.tableAdapterManager.RoluriTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.BazaFilmBoxDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizatoriTableAdapter = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(247, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 415);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form10";
            this.Text = "Actori";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaFilmBoxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private BazaFilmBoxDataSet bazaFilmBoxDataSet;
        private System.Windows.Forms.BindingSource actoriBindingSource;
        private BazaFilmBoxDataSetTableAdapters.ActoriTableAdapter actoriTableAdapter;
        private BazaFilmBoxDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}