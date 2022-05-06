namespace WindowsFormsApplication1
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label descriereLabel;
            System.Windows.Forms.Label titluLabel;
            System.Windows.Forms.Label datarLabel;
            System.Windows.Forms.Label notaLabel;
            this.lblDescriere = new System.Windows.Forms.TextBox();
            this.lbltTitlu = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            descriereLabel = new System.Windows.Forms.Label();
            titluLabel = new System.Windows.Forms.Label();
            datarLabel = new System.Windows.Forms.Label();
            notaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // descriereLabel
            // 
            descriereLabel.AutoSize = true;
            descriereLabel.Location = new System.Drawing.Point(3, 69);
            descriereLabel.Name = "descriereLabel";
            descriereLabel.Size = new System.Drawing.Size(55, 13);
            descriereLabel.TabIndex = 22;
            descriereLabel.Text = "Descriere:";
            // 
            // titluLabel
            // 
            titluLabel.AutoSize = true;
            titluLabel.Location = new System.Drawing.Point(28, 42);
            titluLabel.Name = "titluLabel";
            titluLabel.Size = new System.Drawing.Size(30, 13);
            titluLabel.TabIndex = 20;
            titluLabel.Text = "Titlu:";
            // 
            // datarLabel
            // 
            datarLabel.AutoSize = true;
            datarLabel.Location = new System.Drawing.Point(187, 46);
            datarLabel.Name = "datarLabel";
            datarLabel.Size = new System.Drawing.Size(33, 13);
            datarLabel.TabIndex = 18;
            datarLabel.Text = "Data:";
            // 
            // notaLabel
            // 
            notaLabel.AutoSize = true;
            notaLabel.Location = new System.Drawing.Point(187, 14);
            notaLabel.Name = "notaLabel";
            notaLabel.Size = new System.Drawing.Size(33, 13);
            notaLabel.TabIndex = 16;
            notaLabel.Text = "Nota:";
            // 
            // lblDescriere
            // 
            this.lblDescriere.Location = new System.Drawing.Point(64, 66);
            this.lblDescriere.Multiline = true;
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(376, 56);
            this.lblDescriere.TabIndex = 23;
            // 
            // lbltTitlu
            // 
            this.lbltTitlu.Location = new System.Drawing.Point(64, 39);
            this.lbltTitlu.Name = "lbltTitlu";
            this.lbltTitlu.Size = new System.Drawing.Size(100, 20);
            this.lbltTitlu.TabIndex = 21;
            // 
            // lblNota
            // 
            this.lblNota.Location = new System.Drawing.Point(226, 10);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(100, 20);
            this.lblNota.TabIndex = 17;
            // 
            // lblData
            // 
            this.lblData.Location = new System.Drawing.Point(226, 43);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(100, 20);
            this.lblData.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Utilizator:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(descriereLabel);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(titluLabel);
            this.Controls.Add(this.lbltTitlu);
            this.Controls.Add(datarLabel);
            this.Controls.Add(notaLabel);
            this.Controls.Add(this.lblNota);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(474, 138);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lblDescriere;
        private System.Windows.Forms.TextBox lbltTitlu;
        private System.Windows.Forms.TextBox lblNota;
        private System.Windows.Forms.TextBox lblData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
