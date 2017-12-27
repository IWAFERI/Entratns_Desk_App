namespace Abiturients_App
{
    partial class AbiturMenu
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
            this.idPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciality2_idSpeciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField7 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField8 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPeople,
            this.surName,
            this.name,
            this.lastName,
            this.dateBirth,
            this.phoneNumber,
            this.schoolNumber,
            this.speciality2_idSpeciality});
            this.dataGridView1.Location = new System.Drawing.Point(408, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 452);
            this.dataGridView1.TabIndex = 0;
            // 
            // idPeople
            // 
            this.idPeople.DataPropertyName = "idPeople";
            this.idPeople.HeaderText = "Номер";
            this.idPeople.Name = "idPeople";
            // 
            // surName
            // 
            this.surName.DataPropertyName = "surName";
            this.surName.HeaderText = "Фамилия";
            this.surName.Name = "surName";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "lastName";
            this.lastName.HeaderText = "Отчество";
            this.lastName.Name = "lastName";
            // 
            // dateBirth
            // 
            this.dateBirth.DataPropertyName = "dateBirth";
            this.dateBirth.HeaderText = "Дата рождения";
            this.dateBirth.Name = "dateBirth";
            // 
            // phoneNumber
            // 
            this.phoneNumber.DataPropertyName = "phoneNumber";
            this.phoneNumber.HeaderText = "Номер телефона";
            this.phoneNumber.Name = "phoneNumber";
            // 
            // schoolNumber
            // 
            this.schoolNumber.DataPropertyName = "schoolNumber";
            this.schoolNumber.HeaderText = "Школа";
            this.schoolNumber.Name = "schoolNumber";
            // 
            // speciality2_idSpeciality
            // 
            this.speciality2_idSpeciality.DataPropertyName = "speciality2_idSpeciality";
            this.speciality2_idSpeciality.HeaderText = "Жел. Специальность";
            this.speciality2_idSpeciality.Name = "speciality2_idSpeciality";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 103);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(390, 423);
            this.materialTabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialSingleLineTextField8);
            this.tabPage1.Controls.Add(this.materialSingleLineTextField7);
            this.tabPage1.Controls.Add(this.materialSingleLineTextField6);
            this.tabPage1.Controls.Add(this.materialSingleLineTextField5);
            this.tabPage1.Controls.Add(this.materialSingleLineTextField4);
            this.tabPage1.Controls.Add(this.materialSingleLineTextField3);
            this.tabPage1.Controls.Add(this.materialSingleLineTextField2);
            this.tabPage1.Controls.Add(this.materialSingleLineTextField1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(382, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Люди";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(382, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сертификат";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialTabSelector1.Location = new System.Drawing.Point(12, 74);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(390, 23);
            this.materialTabSelector1.TabIndex = 12;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(382, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Аттестат";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Abiturients_App.Properties.Resources.ic_keyboard_arrow_left_white_48dp;
            this.pictureBox1.Location = new System.Drawing.Point(1211, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Личный номер";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(6, 6);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(201, 23);
            this.materialSingleLineTextField1.TabIndex = 0;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "Фамилия";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(6, 35);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(201, 23);
            this.materialSingleLineTextField2.TabIndex = 1;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "Имя";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(6, 64);
            this.materialSingleLineTextField3.MaxLength = 32767;
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(201, 23);
            this.materialSingleLineTextField3.TabIndex = 2;
            this.materialSingleLineTextField3.TabStop = false;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField4
            // 
            this.materialSingleLineTextField4.Depth = 0;
            this.materialSingleLineTextField4.Hint = "Отчество";
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(6, 93);
            this.materialSingleLineTextField4.MaxLength = 32767;
            this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            this.materialSingleLineTextField4.PasswordChar = '\0';
            this.materialSingleLineTextField4.SelectedText = "";
            this.materialSingleLineTextField4.SelectionLength = 0;
            this.materialSingleLineTextField4.SelectionStart = 0;
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(201, 23);
            this.materialSingleLineTextField4.TabIndex = 3;
            this.materialSingleLineTextField4.TabStop = false;
            this.materialSingleLineTextField4.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField5
            // 
            this.materialSingleLineTextField5.Depth = 0;
            this.materialSingleLineTextField5.Hint = "Дата рождения";
            this.materialSingleLineTextField5.Location = new System.Drawing.Point(6, 122);
            this.materialSingleLineTextField5.MaxLength = 32767;
            this.materialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField5.Name = "materialSingleLineTextField5";
            this.materialSingleLineTextField5.PasswordChar = '\0';
            this.materialSingleLineTextField5.SelectedText = "";
            this.materialSingleLineTextField5.SelectionLength = 0;
            this.materialSingleLineTextField5.SelectionStart = 0;
            this.materialSingleLineTextField5.Size = new System.Drawing.Size(201, 23);
            this.materialSingleLineTextField5.TabIndex = 4;
            this.materialSingleLineTextField5.TabStop = false;
            this.materialSingleLineTextField5.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField6
            // 
            this.materialSingleLineTextField6.Depth = 0;
            this.materialSingleLineTextField6.Hint = "Номер телефона";
            this.materialSingleLineTextField6.Location = new System.Drawing.Point(6, 151);
            this.materialSingleLineTextField6.MaxLength = 32767;
            this.materialSingleLineTextField6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField6.Name = "materialSingleLineTextField6";
            this.materialSingleLineTextField6.PasswordChar = '\0';
            this.materialSingleLineTextField6.SelectedText = "";
            this.materialSingleLineTextField6.SelectionLength = 0;
            this.materialSingleLineTextField6.SelectionStart = 0;
            this.materialSingleLineTextField6.Size = new System.Drawing.Size(201, 23);
            this.materialSingleLineTextField6.TabIndex = 5;
            this.materialSingleLineTextField6.TabStop = false;
            this.materialSingleLineTextField6.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField7
            // 
            this.materialSingleLineTextField7.Depth = 0;
            this.materialSingleLineTextField7.Hint = "Школа";
            this.materialSingleLineTextField7.Location = new System.Drawing.Point(6, 180);
            this.materialSingleLineTextField7.MaxLength = 32767;
            this.materialSingleLineTextField7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField7.Name = "materialSingleLineTextField7";
            this.materialSingleLineTextField7.PasswordChar = '\0';
            this.materialSingleLineTextField7.SelectedText = "";
            this.materialSingleLineTextField7.SelectionLength = 0;
            this.materialSingleLineTextField7.SelectionStart = 0;
            this.materialSingleLineTextField7.Size = new System.Drawing.Size(201, 23);
            this.materialSingleLineTextField7.TabIndex = 6;
            this.materialSingleLineTextField7.TabStop = false;
            this.materialSingleLineTextField7.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField8
            // 
            this.materialSingleLineTextField8.Depth = 0;
            this.materialSingleLineTextField8.Hint = "Желаемая специальность";
            this.materialSingleLineTextField8.Location = new System.Drawing.Point(6, 209);
            this.materialSingleLineTextField8.MaxLength = 32767;
            this.materialSingleLineTextField8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField8.Name = "materialSingleLineTextField8";
            this.materialSingleLineTextField8.PasswordChar = '\0';
            this.materialSingleLineTextField8.SelectedText = "";
            this.materialSingleLineTextField8.SelectionLength = 0;
            this.materialSingleLineTextField8.SelectionStart = 0;
            this.materialSingleLineTextField8.Size = new System.Drawing.Size(201, 23);
            this.materialSingleLineTextField8.TabIndex = 7;
            this.materialSingleLineTextField8.TabStop = false;
            this.materialSingleLineTextField8.UseSystemPasswordChar = false;
            // 
            // AbiturMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 538);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AbiturMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AbiturMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AbiturMenu_FormClosing);
            this.Load += new System.EventHandler(this.AbiturMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn surName;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciality2_idSpeciality;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField8;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField7;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField6;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField5;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
    }
}