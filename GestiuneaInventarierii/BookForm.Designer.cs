namespace GestiuneaInventarierii
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblnrinreg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cautare = new System.Windows.Forms.Label();
            this.textsearchBook = new System.Windows.Forms.TextBox();
            this.btnAdauga = new GestiuneaInventarierii.SelectionButton();
            this.Formular = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvReg = new System.Windows.Forms.DataGridView();
            this.tbStatusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbInvAppDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbInvAppDataSet3 = new GestiuneaInventarierii.dbInvAppDataSet3();
            this.tbEchipamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbInvAppDataSet = new GestiuneaInventarierii.dbInvAppDataSet();
            this.tbEchipamentTableAdapter = new GestiuneaInventarierii.dbInvAppDataSetTableAdapters.tbEchipamentTableAdapter();
            this.dbInvAppDataSet1 = new GestiuneaInventarierii.dbInvAppDataSet1();
            this.tbEchipamentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbEchipamentTableAdapter1 = new GestiuneaInventarierii.dbInvAppDataSet1TableAdapters.tbEchipamentTableAdapter();
            this.tbStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbStatusTableAdapter = new GestiuneaInventarierii.dbInvAppDataSet3TableAdapters.tbStatusTableAdapter();
            this.fKtbEchipamentTotbStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbEchipamentTableAdapter2 = new GestiuneaInventarierii.dbInvAppDataSet3TableAdapters.tbEchipamentTableAdapter();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdauga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStatusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbInvAppDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbInvAppDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEchipamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbInvAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbInvAppDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEchipamentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtbEchipamentTotbStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.lblnrinreg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cautare);
            this.panel1.Controls.Add(this.textsearchBook);
            this.panel1.Controls.Add(this.btnAdauga);
            this.panel1.Controls.Add(this.Formular);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 714);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 121);
            this.panel1.TabIndex = 4;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExport.Location = new System.Drawing.Point(982, 39);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(153, 52);
            this.btnExport.TabIndex = 25;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblnrinreg
            // 
            this.lblnrinreg.AutoSize = true;
            this.lblnrinreg.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnrinreg.ForeColor = System.Drawing.Color.White;
            this.lblnrinreg.Location = new System.Drawing.Point(571, 79);
            this.lblnrinreg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnrinreg.Name = "lblnrinreg";
            this.lblnrinreg.Size = new System.Drawing.Size(0, 25);
            this.lblnrinreg.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(378, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Total înregistrări:";
            // 
            // cautare
            // 
            this.cautare.AutoSize = true;
            this.cautare.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cautare.ForeColor = System.Drawing.Color.White;
            this.cautare.Location = new System.Drawing.Point(358, 26);
            this.cautare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cautare.Name = "cautare";
            this.cautare.Size = new System.Drawing.Size(199, 26);
            this.cautare.TabIndex = 22;
            this.cautare.Text = "Caută în Registru:";
            // 
            // textsearchBook
            // 
            this.textsearchBook.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsearchBook.Location = new System.Drawing.Point(571, 23);
            this.textsearchBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textsearchBook.Name = "textsearchBook";
            this.textsearchBook.Size = new System.Drawing.Size(317, 34);
            this.textsearchBook.TabIndex = 21;
            this.textsearchBook.TextChanged += new System.EventHandler(this.textsearchBook_TextChanged);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Image = ((System.Drawing.Image)(resources.GetObject("btnAdauga.Image")));
            this.btnAdauga.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnAdauga.ImageHover")));
            this.btnAdauga.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnAdauga.ImageNormal")));
            this.btnAdauga.Location = new System.Drawing.Point(1247, 30);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(70, 61);
            this.btnAdauga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdauga.TabIndex = 8;
            this.btnAdauga.TabStop = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // Formular
            // 
            this.Formular.AutoSize = true;
            this.Formular.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.Formular.ForeColor = System.Drawing.Color.White;
            this.Formular.Location = new System.Drawing.Point(13, 39);
            this.Formular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Formular.Name = "Formular";
            this.Formular.Size = new System.Drawing.Size(299, 34);
            this.Formular.TabIndex = 2;
            this.Formular.Text = "Registru echipament";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.MinimumWidth = 8;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 150;
            // 
            // dgvReg
            // 
            this.dgvReg.AllowUserToAddRows = false;
            this.dgvReg.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(132)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReg.ColumnHeadersHeight = 30;
            this.dgvReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.ID,
            this.Datap,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column8,
            this.Column2,
            this.Column9,
            this.Column10,
            this.Delete});
            this.dgvReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReg.EnableHeadersVisualStyles = false;
            this.dgvReg.Location = new System.Drawing.Point(0, 0);
            this.dgvReg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReg.Name = "dgvReg";
            this.dgvReg.RowHeadersVisible = false;
            this.dgvReg.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReg.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReg.Size = new System.Drawing.Size(1348, 714);
            this.dgvReg.TabIndex = 6;
            this.dgvReg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReg_CellContentClick);
            // 
            // tbStatusBindingSource1
            // 
            this.tbStatusBindingSource1.DataMember = "tbStatus";
            this.tbStatusBindingSource1.DataSource = this.dbInvAppDataSet3BindingSource;
            // 
            // dbInvAppDataSet3BindingSource
            // 
            this.dbInvAppDataSet3BindingSource.DataSource = this.dbInvAppDataSet3;
            this.dbInvAppDataSet3BindingSource.Position = 0;
            // 
            // dbInvAppDataSet3
            // 
            this.dbInvAppDataSet3.DataSetName = "dbInvAppDataSet3";
            this.dbInvAppDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbEchipamentBindingSource
            // 
            this.tbEchipamentBindingSource.DataMember = "tbEchipament";
            this.tbEchipamentBindingSource.DataSource = this.dbInvAppDataSet;
            // 
            // dbInvAppDataSet
            // 
            this.dbInvAppDataSet.DataSetName = "dbInvAppDataSet";
            this.dbInvAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbEchipamentTableAdapter
            // 
            this.tbEchipamentTableAdapter.ClearBeforeFill = true;
            // 
            // dbInvAppDataSet1
            // 
            this.dbInvAppDataSet1.DataSetName = "dbInvAppDataSet1";
            this.dbInvAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbEchipamentBindingSource1
            // 
            this.tbEchipamentBindingSource1.DataMember = "tbEchipament";
            this.tbEchipamentBindingSource1.DataSource = this.dbInvAppDataSet1;
            // 
            // tbEchipamentTableAdapter1
            // 
            this.tbEchipamentTableAdapter1.ClearBeforeFill = true;
            // 
            // tbStatusBindingSource
            // 
            this.tbStatusBindingSource.DataMember = "tbStatus";
            this.tbStatusBindingSource.DataSource = this.dbInvAppDataSet3BindingSource;
            // 
            // tbStatusTableAdapter
            // 
            this.tbStatusTableAdapter.ClearBeforeFill = true;
            // 
            // fKtbEchipamentTotbStatusBindingSource
            // 
            this.fKtbEchipamentTotbStatusBindingSource.DataMember = "FK_tbEchipament_TotbStatus";
            this.fKtbEchipamentTotbStatusBindingSource.DataSource = this.tbStatusBindingSource;
            // 
            // tbEchipamentTableAdapter2
            // 
            this.tbEchipamentTableAdapter2.ClearBeforeFill = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "No";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 71;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "ID Registru";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 137;
            // 
            // Datap
            // 
            this.Datap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Datap.HeaderText = "Dată predare";
            this.Datap.MinimumWidth = 8;
            this.Datap.Name = "Datap";
            this.Datap.Width = 165;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "ID Echipament";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 174;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Denumire Echipament";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 242;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "ID Angajat";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            this.Column5.Width = 139;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Nume Angajat";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 174;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Nr unități";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 123;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "ID Status";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            this.Column9.Width = 119;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "Status";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.Width = 96;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.Width = 8;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 835);
            this.Controls.Add(this.dgvReg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdauga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStatusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbInvAppDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbInvAppDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEchipamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbInvAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbInvAppDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEchipamentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtbEchipamentTotbStatusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private SelectionButton btnAdauga;
        private System.Windows.Forms.Label Formular;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridView dgvReg;
        private System.Windows.Forms.Label cautare;
        public System.Windows.Forms.TextBox textsearchBook;
        private System.Windows.Forms.Label lblnrinreg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private dbInvAppDataSet dbInvAppDataSet;
        private System.Windows.Forms.BindingSource tbEchipamentBindingSource;
        private dbInvAppDataSetTableAdapters.tbEchipamentTableAdapter tbEchipamentTableAdapter;
        private dbInvAppDataSet1 dbInvAppDataSet1;
        private System.Windows.Forms.BindingSource tbEchipamentBindingSource1;
        private dbInvAppDataSet1TableAdapters.tbEchipamentTableAdapter tbEchipamentTableAdapter1;
        private dbInvAppDataSet3 dbInvAppDataSet3;
        private System.Windows.Forms.BindingSource dbInvAppDataSet3BindingSource;
        private System.Windows.Forms.BindingSource tbStatusBindingSource;
        private dbInvAppDataSet3TableAdapters.tbStatusTableAdapter tbStatusTableAdapter;
        private System.Windows.Forms.BindingSource fKtbEchipamentTotbStatusBindingSource;
        private dbInvAppDataSet3TableAdapters.tbEchipamentTableAdapter tbEchipamentTableAdapter2;
        private System.Windows.Forms.BindingSource tbStatusBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}