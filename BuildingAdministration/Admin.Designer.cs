using BuildingAdministrator;

namespace SubiectAtestat1
{
    partial class Admin
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
            this.locatariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blocDBDataSet1 = new BuildingAdministrator.BlocDBDataSet1();
            this.locatariTableAdapter = new BuildingAdministrator.BlocDBDataSet1TableAdapters.locatariTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNotEmployed = new System.Windows.Forms.RadioButton();
            this.rbEmployed = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNoEmployed = new System.Windows.Forms.RadioButton();
            this.rbYesEmplyed = new System.Windows.Forms.RadioButton();
            this.txtbNrAp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtbYear = new System.Windows.Forms.TextBox();
            this.txtbNrBlock = new System.Windows.Forms.TextBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLocatari = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nRAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mesajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blocDBMesajeDataSet = new BuildingAdministrator.BlocDBMesajeDataSet();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvMesaje = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nRAPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MESAJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URGENT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mesajeTableAdapter = new BuildingAdministrator.BlocDBMesajeDataSetTableAdapters.MesajeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.locatariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocDBDataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocatari)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mesajeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocDBMesajeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesaje)).BeginInit();
            this.SuspendLayout();
            // 
            // locatariBindingSource
            // 
            this.locatariBindingSource.DataMember = "locatari";
            this.locatariBindingSource.DataSource = this.blocDBDataSet1;
            // 
            // blocDBDataSet1
            // 
            this.blocDBDataSet1.DataSetName = "BlocDBDataSet1";
            this.blocDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locatariTableAdapter
            // 
            this.locatariTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(675, 438);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dgvLocatari);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(667, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Date locatari";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNotEmployed);
            this.groupBox2.Controls.Add(this.rbEmployed);
            this.groupBox2.Location = new System.Drawing.Point(245, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Afisare";
            // 
            // rbNotEmployed
            // 
            this.rbNotEmployed.AutoSize = true;
            this.rbNotEmployed.Location = new System.Drawing.Point(16, 54);
            this.rbNotEmployed.Name = "rbNotEmployed";
            this.rbNotEmployed.Size = new System.Drawing.Size(115, 17);
            this.rbNotEmployed.TabIndex = 1;
            this.rbNotEmployed.TabStop = true;
            this.rbNotEmployed.Text = "Locatari neangajati";
            this.rbNotEmployed.UseVisualStyleBackColor = true;
            // 
            // rbEmployed
            // 
            this.rbEmployed.AutoSize = true;
            this.rbEmployed.Location = new System.Drawing.Point(16, 24);
            this.rbEmployed.Name = "rbEmployed";
            this.rbEmployed.Size = new System.Drawing.Size(103, 17);
            this.rbEmployed.TabIndex = 0;
            this.rbEmployed.TabStop = true;
            this.rbEmployed.Text = "Locatari angajati";
            this.rbEmployed.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNoEmployed);
            this.groupBox1.Controls.Add(this.rbYesEmplyed);
            this.groupBox1.Controls.Add(this.txtbNrAp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtbYear);
            this.groupBox1.Controls.Add(this.txtbNrBlock);
            this.groupBox1.Controls.Add(this.txtbName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 226);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adauga locatari";
            // 
            // rbNoEmployed
            // 
            this.rbNoEmployed.AutoSize = true;
            this.rbNoEmployed.Location = new System.Drawing.Point(64, 167);
            this.rbNoEmployed.Name = "rbNoEmployed";
            this.rbNoEmployed.Size = new System.Drawing.Size(39, 17);
            this.rbNoEmployed.TabIndex = 13;
            this.rbNoEmployed.TabStop = true;
            this.rbNoEmployed.Text = "Nu";
            this.rbNoEmployed.UseVisualStyleBackColor = true;
            // 
            // rbYesEmplyed
            // 
            this.rbYesEmplyed.AutoSize = true;
            this.rbYesEmplyed.Location = new System.Drawing.Point(64, 143);
            this.rbYesEmplyed.Name = "rbYesEmplyed";
            this.rbYesEmplyed.Size = new System.Drawing.Size(39, 17);
            this.rbYesEmplyed.TabIndex = 12;
            this.rbYesEmplyed.TabStop = true;
            this.rbYesEmplyed.Text = "Da";
            this.rbYesEmplyed.UseVisualStyleBackColor = true;
            // 
            // txtbNrAp
            // 
            this.txtbNrAp.Location = new System.Drawing.Point(111, 87);
            this.txtbNrAp.Name = "txtbNrAp";
            this.txtbNrAp.Size = new System.Drawing.Size(100, 20);
            this.txtbNrAp.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numarul apartam.:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(64, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Adauga";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtbYear
            // 
            this.txtbYear.Location = new System.Drawing.Point(96, 113);
            this.txtbYear.Name = "txtbYear";
            this.txtbYear.Size = new System.Drawing.Size(100, 20);
            this.txtbYear.TabIndex = 6;
            // 
            // txtbNrBlock
            // 
            this.txtbNrBlock.Location = new System.Drawing.Point(111, 59);
            this.txtbNrBlock.Name = "txtbNrBlock";
            this.txtbNrBlock.Size = new System.Drawing.Size(100, 20);
            this.txtbNrBlock.TabIndex = 5;
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(61, 29);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(100, 20);
            this.txtbName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Angajat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Anul aparitiei:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numarul blocului:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume:";
            // 
            // dgvLocatari
            // 
            this.dgvLocatari.AutoGenerateColumns = false;
            this.dgvLocatari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocatari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.nRAPDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.dgvLocatari.DataSource = this.locatariBindingSource;
            this.dgvLocatari.Location = new System.Drawing.Point(2, 6);
            this.dgvLocatari.Name = "dgvLocatari";
            this.dgvLocatari.Size = new System.Drawing.Size(662, 150);
            this.dgvLocatari.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NUME";
            this.dataGridViewTextBoxColumn2.HeaderText = "NUME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NR_BLOC";
            this.dataGridViewTextBoxColumn3.HeaderText = "NR_BLOC";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // nRAPDataGridViewTextBoxColumn
            // 
            this.nRAPDataGridViewTextBoxColumn.DataPropertyName = "NR_AP";
            this.nRAPDataGridViewTextBoxColumn.HeaderText = "NR_AP";
            this.nRAPDataGridViewTextBoxColumn.Name = "nRAPDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ANUL_AP";
            this.dataGridViewTextBoxColumn4.HeaderText = "ANUL_AP";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "ANGAJAT";
            this.dataGridViewCheckBoxColumn1.HeaderText = "ANGAJAT";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.btnBack);
            this.tabPage2.Controls.Add(this.dgvMesaje);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(667, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mesaje locatari";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Daca cererea din mesaj a fost rezolvata,\r\n                 selectati mesajul.";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(64, 251);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Sterge";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.mesajeBindingSource;
            this.comboBox1.DisplayMember = "ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 209);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "ID";
            // 
            // mesajeBindingSource
            // 
            this.mesajeBindingSource.DataMember = "Mesaje";
            this.mesajeBindingSource.DataSource = this.blocDBMesajeDataSet;
            // 
            // blocDBMesajeDataSet
            // 
            this.blocDBMesajeDataSet.DataSetName = "BlocDBMesajeDataSet";
            this.blocDBMesajeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(563, 347);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 48);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Inapoi";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvMesaje
            // 
            this.dgvMesaje.AutoGenerateColumns = false;
            this.dgvMesaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesaje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.nRAPDataGridViewTextBoxColumn1,
            this.MESAJ,
            this.DATA,
            this.URGENT});
            this.dgvMesaje.DataSource = this.mesajeBindingSource;
            this.dgvMesaje.Location = new System.Drawing.Point(9, 7);
            this.dgvMesaje.Name = "dgvMesaje";
            this.dgvMesaje.Size = new System.Drawing.Size(652, 150);
            this.dgvMesaje.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NUME";
            this.dataGridViewTextBoxColumn6.HeaderText = "NUME";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NR_BLOC";
            this.dataGridViewTextBoxColumn7.HeaderText = "NR_BLOC";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // nRAPDataGridViewTextBoxColumn1
            // 
            this.nRAPDataGridViewTextBoxColumn1.DataPropertyName = "NR_AP";
            this.nRAPDataGridViewTextBoxColumn1.HeaderText = "NR_AP";
            this.nRAPDataGridViewTextBoxColumn1.Name = "nRAPDataGridViewTextBoxColumn1";
            // 
            // MESAJ
            // 
            this.MESAJ.DataPropertyName = "MESAJ";
            this.MESAJ.HeaderText = "MESAJ";
            this.MESAJ.Name = "MESAJ";
            // 
            // DATA
            // 
            this.DATA.DataPropertyName = "DATA";
            this.DATA.HeaderText = "DATA";
            this.DATA.Name = "DATA";
            // 
            // URGENT
            // 
            this.URGENT.DataPropertyName = "URGENT";
            this.URGENT.HeaderText = "URGENT";
            this.URGENT.Name = "URGENT";
            // 
            // mesajeTableAdapter
            // 
            this.mesajeTableAdapter.ClearBeforeFill = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locatariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocDBDataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocatari)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mesajeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocDBMesajeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRBLOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNULAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aNGAJATDataGridViewCheckBoxColumn;
        private BlocDBDataSet1 blocDBDataSet1;
        private System.Windows.Forms.BindingSource locatariBindingSource;
        private BuildingAdministrator.BlocDBDataSet1TableAdapters.locatariTableAdapter locatariTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNotEmployed;
        private System.Windows.Forms.RadioButton rbEmployed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNoEmployed;
        private System.Windows.Forms.RadioButton rbYesEmplyed;
        private System.Windows.Forms.TextBox txtbNrAp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtbYear;
        private System.Windows.Forms.TextBox txtbNrBlock;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLocatari;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvMesaje;
        private BlocDBMesajeDataSet blocDBMesajeDataSet;
        private System.Windows.Forms.BindingSource mesajeBindingSource;
        private BuildingAdministrator.BlocDBMesajeDataSetTableAdapters.MesajeTableAdapter mesajeTableAdapter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRAPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MESAJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn URGENT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

