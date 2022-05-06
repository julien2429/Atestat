namespace WindowsFormsApplication1
{
    partial class Form11
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.userControl21 = new WindowsFormsApplication1.UserControl2();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bazaFilmBoxDataSet = new WindowsFormsApplication1.BazaFilmBoxDataSet();
            this.filmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmeTableAdapter = new WindowsFormsApplication1.BazaFilmBoxDataSetTableAdapters.FilmeTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.BazaFilmBoxDataSetTableAdapters.TableAdapterManager();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bazaFilmBoxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1313, 622);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1305, 596);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Top cele mai bune filme";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.userControl21);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(39, 49);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(239, 539);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // userControl21
            // 
            this.userControl21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userControl21.Img = null;
            this.userControl21.Location = new System.Drawing.Point(3, 3);
            this.userControl21.Name = "userControl21";
            this.userControl21.parentForm = null;
            this.userControl21.Size = new System.Drawing.Size(233, 318);
            this.userControl21.TabIndex = 2;
            this.userControl21.Titlu = null;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1305, 596);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bazaFilmBoxDataSet
            // 
            this.bazaFilmBoxDataSet.DataSetName = "BazaFilmBoxDataSet";
            this.bazaFilmBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmeBindingSource
            // 
            this.filmeBindingSource.DataMember = "Filme";
            this.filmeBindingSource.DataSource = this.bazaFilmBoxDataSet;
            // 
            // filmeTableAdapter
            // 
            this.filmeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActoriTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilmeTableAdapter = this.filmeTableAdapter;
            this.tableAdapterManager.PremiiTableAdapter = null;
            this.tableAdapterManager.RecenzieTableAdapter = null;
            this.tableAdapterManager.RegizoriTableAdapter = null;
            this.tableAdapterManager.RoluriTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.BazaFilmBoxDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizatoriTableAdapter = null;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 622);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bazaFilmBoxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UserControl2 userControl21;
        private System.Windows.Forms.TabPage tabPage2;
        private BazaFilmBoxDataSet bazaFilmBoxDataSet;
        private System.Windows.Forms.BindingSource filmeBindingSource;
        private BazaFilmBoxDataSetTableAdapters.FilmeTableAdapter filmeTableAdapter;
        private BazaFilmBoxDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}