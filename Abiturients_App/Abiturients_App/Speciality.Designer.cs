namespace Abiturients_App
{
    partial class Speciality
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idSpeciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfSpeciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comerc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSpeciality,
            this.nameOfSpeciality,
            this.budget,
            this.comerc});
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // idSpeciality
            // 
            this.idSpeciality.DataPropertyName = "idSpeciality";
            this.idSpeciality.HeaderText = "Номер";
            this.idSpeciality.Name = "idSpeciality";
            // 
            // nameOfSpeciality
            // 
            this.nameOfSpeciality.DataPropertyName = "nameOfSpeciality";
            this.nameOfSpeciality.HeaderText = "Наименование";
            this.nameOfSpeciality.Name = "nameOfSpeciality";
            this.nameOfSpeciality.Width = 250;
            // 
            // budget
            // 
            this.budget.DataPropertyName = "budget";
            this.budget.HeaderText = "Бюджет";
            this.budget.Name = "budget";
            this.budget.Width = 60;
            // 
            // comerc
            // 
            this.comerc.DataPropertyName = "comerc";
            this.comerc.HeaderText = "Комерция";
            this.comerc.Name = "comerc";
            this.comerc.Width = 66;
            // 
            // Speciality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 363);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Speciality";
            this.Text = "Speciality";
            this.Load += new System.EventHandler(this.Speciality_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSpeciality;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfSpeciality;
        private System.Windows.Forms.DataGridViewTextBoxColumn budget;
        private System.Windows.Forms.DataGridViewTextBoxColumn comerc;
    }
}