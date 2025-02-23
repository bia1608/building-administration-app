namespace SubiectAtestat1
{
    partial class Locatar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbDa = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbMesaj = new System.Windows.Forms.RichTextBox();
            this.txtbNrAp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtbNrBlock = new System.Windows.Forms.TextBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvMsj = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mESAJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRGENTDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mesajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blocDBDataSet = new SubiectAtestat1.BlocDBDataSet();
            this.mesajeTableAdapter = new SubiectAtestat1.BlocDBDataSetTableAdapters.MesajeTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMsj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesajeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNu);
            this.groupBox1.Controls.Add(this.rbDa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rtbMesaj);
            this.groupBox1.Controls.Add(this.txtbNrAp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtbNrBlock);
            this.groupBox1.Controls.Add(this.txtbName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 340);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transmite mesaj";
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(70, 267);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 15;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nu";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbDa
            // 
            this.rbDa.AutoSize = true;
            this.rbDa.Location = new System.Drawing.Point(70, 244);
            this.rbDa.Name = "rbDa";
            this.rbDa.Size = new System.Drawing.Size(39, 17);
            this.rbDa.TabIndex = 14;
            this.rbDa.TabStop = true;
            this.rbDa.Text = "Da";
            this.rbDa.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Urgent:";
            // 
            // rtbMesaj
            // 
            this.rtbMesaj.Location = new System.Drawing.Point(19, 141);
            this.rtbMesaj.Name = "rtbMesaj";
            this.rtbMesaj.Size = new System.Drawing.Size(192, 96);
            this.rtbMesaj.TabIndex = 12;
            this.rtbMesaj.Text = "";
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
            this.btnAdd.Location = new System.Drawing.Point(71, 300);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Adauga";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mesaj:";
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
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.RosyBrown;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(532, 293);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 48);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Inapoi";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nerezolvate";
            // 
            // dgvMsj
            // 
            this.dgvMsj.AutoGenerateColumns = false;
            this.dgvMsj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMsj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.mESAJDataGridViewTextBoxColumn,
            this.dATADataGridViewTextBoxColumn,
            this.uRGENTDataGridViewCheckBoxColumn});
            this.dgvMsj.DataSource = this.mesajeBindingSource;
            this.dgvMsj.Location = new System.Drawing.Point(265, 41);
            this.dgvMsj.Name = "dgvMsj";
            this.dgvMsj.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMsj.Size = new System.Drawing.Size(351, 150);
            this.dgvMsj.TabIndex = 11;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mESAJDataGridViewTextBoxColumn
            // 
            this.mESAJDataGridViewTextBoxColumn.DataPropertyName = "MESAJ";
            this.mESAJDataGridViewTextBoxColumn.HeaderText = "MESAJ";
            this.mESAJDataGridViewTextBoxColumn.Name = "mESAJDataGridViewTextBoxColumn";
            // 
            // dATADataGridViewTextBoxColumn
            // 
            this.dATADataGridViewTextBoxColumn.DataPropertyName = "DATA";
            this.dATADataGridViewTextBoxColumn.HeaderText = "DATA";
            this.dATADataGridViewTextBoxColumn.Name = "dATADataGridViewTextBoxColumn";
            // 
            // uRGENTDataGridViewCheckBoxColumn
            // 
            this.uRGENTDataGridViewCheckBoxColumn.DataPropertyName = "URGENT";
            this.uRGENTDataGridViewCheckBoxColumn.HeaderText = "URGENT";
            this.uRGENTDataGridViewCheckBoxColumn.Name = "uRGENTDataGridViewCheckBoxColumn";
            // 
            // mesajeBindingSource
            // 
            this.mesajeBindingSource.DataMember = "Mesaje";
            this.mesajeBindingSource.DataSource = this.blocDBDataSet;
            // 
            // blocDBDataSet
            // 
            this.blocDBDataSet.DataSetName = "BlocDBDataSet";
            this.blocDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mesajeTableAdapter
            // 
            this.mesajeTableAdapter.ClearBeforeFill = true;
            // 
            // Locatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(624, 353);
            this.Controls.Add(this.dgvMsj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Name = "Locatar";
            this.Text = "Locatar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Locatar_FormClosed);
            this.Load += new System.EventHandler(this.Locatar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMsj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesajeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbNrAp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtbNrBlock;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbMesaj;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbDa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvMsj;
        private BlocDBDataSet blocDBDataSet;
        private System.Windows.Forms.BindingSource mesajeBindingSource;
        private BlocDBDataSetTableAdapters.MesajeTableAdapter mesajeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mESAJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uRGENTDataGridViewCheckBoxColumn;
    }
}