﻿namespace WindowsFormsApplication1
{
    partial class Form9
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.filmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaFilmBoxDataSet = new WindowsFormsApplication1.BazaFilmBoxDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.actoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roluriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roluriTableAdapter = new WindowsFormsApplication1.BazaFilmBoxDataSetTableAdapters.RoluriTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.BazaFilmBoxDataSetTableAdapters.TableAdapterManager();
            this.actoriTableAdapter = new WindowsFormsApplication1.BazaFilmBoxDataSetTableAdapters.ActoriTableAdapter();
            this.filmeTableAdapter = new WindowsFormsApplication1.BazaFilmBoxDataSetTableAdapters.FilmeTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaFilmBoxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roluriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.filmeBindingSource;
            this.comboBox1.DisplayMember = "Nume";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Nume";
            // 
            // filmeBindingSource
            // 
            this.filmeBindingSource.DataMember = "Filme";
            this.filmeBindingSource.DataSource = this.bazaFilmBoxDataSet;
            // 
            // bazaFilmBoxDataSet
            // 
            this.bazaFilmBoxDataSet.DataSetName = "BazaFilmBoxDataSet";
            this.bazaFilmBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(112, 97);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(260, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // actoriBindingSource
            // 
            this.actoriBindingSource.DataMember = "Actori";
            this.actoriBindingSource.DataSource = this.bazaFilmBoxDataSet;
            // 
            // roluriBindingSource
            // 
            this.roluriBindingSource.DataMember = "Roluri";
            this.roluriBindingSource.DataSource = this.bazaFilmBoxDataSet;
            // 
            // roluriTableAdapter
            // 
            this.roluriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActoriTableAdapter = this.actoriTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilmeTableAdapter = this.filmeTableAdapter;
            this.tableAdapterManager.PremiiTableAdapter = null;
            this.tableAdapterManager.RecenzieTableAdapter = null;
            this.tableAdapterManager.RegizoriTableAdapter = null;
            this.tableAdapterManager.RoluriTableAdapter = this.roluriTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.BazaFilmBoxDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizatoriTableAdapter = null;
            // 
            // actoriTableAdapter
            // 
            this.actoriTableAdapter.ClearBeforeFill = true;
            // 
            // filmeTableAdapter
            // 
            this.filmeTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume Personaj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nume Actor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Film";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 167);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaFilmBoxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roluriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private BazaFilmBoxDataSet bazaFilmBoxDataSet;
        private System.Windows.Forms.BindingSource roluriBindingSource;
        private BazaFilmBoxDataSetTableAdapters.RoluriTableAdapter roluriTableAdapter;
        private BazaFilmBoxDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BazaFilmBoxDataSetTableAdapters.ActoriTableAdapter actoriTableAdapter;
        private System.Windows.Forms.BindingSource actoriBindingSource;
        private BazaFilmBoxDataSetTableAdapters.FilmeTableAdapter filmeTableAdapter;
        private System.Windows.Forms.BindingSource filmeBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}