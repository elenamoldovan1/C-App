namespace GestiuneaInventarierii
{
    partial class EquipmentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentForm));
            this.dgvEquip = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.cautare = new System.Windows.Forms.Label();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.btnAdauga = new GestiuneaInventarierii.SelectionButton();
            this.Formular = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dbInvAppDataSet2 = new GestiuneaInventarierii.dbInvAppDataSet2();
            this.tbStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbStatusTableAdapter = new GestiuneaInventarierii.dbInvAppDataSet2TableAdapters.tbStatusTableAdapter();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquip)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdauga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbInvAppDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEquip
            // 
            this.dgvEquip.AllowUserToAddRows = false;
            this.dgvEquip.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(132)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEquip.ColumnHeadersHeight = 30;
            this.dgvEquip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEquip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.ID,
            this.Column2,
            this.Column5,
            this.Column8,
            this.Column9,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Edit,
            this.Delete});
            this.dgvEquip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEquip.EnableHeadersVisualStyles = false;
            this.dgvEquip.Location = new System.Drawing.Point(0, 0);
            this.dgvEquip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEquip.Name = "dgvEquip";
            this.dgvEquip.RowHeadersVisible = false;
            this.dgvEquip.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEquip.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEquip.Size = new System.Drawing.Size(1348, 742);
            this.dgvEquip.TabIndex = 3;
            this.dgvEquip.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquip_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.cautare);
            this.panel1.Controls.Add(this.textsearch);
            this.panel1.Controls.Add(this.btnAdauga);
            this.panel1.Controls.Add(this.Formular);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 742);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 93);
            this.panel1.TabIndex = 2;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExport.Location = new System.Drawing.Point(1028, 24);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(153, 52);
            this.btnExport.TabIndex = 26;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cautare
            // 
            this.cautare.AutoSize = true;
            this.cautare.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cautare.ForeColor = System.Drawing.Color.White;
            this.cautare.Location = new System.Drawing.Point(397, 37);
            this.cautare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cautare.Name = "cautare";
            this.cautare.Size = new System.Drawing.Size(231, 25);
            this.cautare.TabIndex = 20;
            this.cautare.Text = "Caută  echipament:";
            // 
            // textsearch
            // 
            this.textsearch.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsearch.Location = new System.Drawing.Point(654, 34);
            this.textsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(317, 34);
            this.textsearch.TabIndex = 19;
            this.textsearch.TextChanged += new System.EventHandler(this.textsearch_TextChanged);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Image = ((System.Drawing.Image)(resources.GetObject("btnAdauga.Image")));
            this.btnAdauga.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnAdauga.ImageHover")));
            this.btnAdauga.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnAdauga.ImageNormal")));
            this.btnAdauga.Location = new System.Drawing.Point(1251, 20);
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
            this.Formular.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formular.ForeColor = System.Drawing.Color.White;
            this.Formular.Location = new System.Drawing.Point(14, 34);
            this.Formular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Formular.Name = "Formular";
            this.Formular.Size = new System.Drawing.Size(199, 34);
            this.Formular.TabIndex = 2;
            this.Formular.Text = "Echipamente";
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
            // dbInvAppDataSet2
            // 
            this.dbInvAppDataSet2.DataSetName = "dbInvAppDataSet2";
            this.dbInvAppDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbStatusBindingSource
            // 
            this.tbStatusBindingSource.DataMember = "tbStatus";
            this.tbStatusBindingSource.DataSource = this.dbInvAppDataSet2;
            // 
            // tbStatusTableAdapter
            // 
            this.tbStatusTableAdapter.ClearBeforeFill = true;
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
            this.ID.HeaderText = "ID Echipament";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 174;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Denumire echipament";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 245;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Pret Achiziție";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 158;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Data achiziție";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 166;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "Categorie";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.Width = 135;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Q";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 61;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID Status";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Status";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 96;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.Width = 8;
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
            // EquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 835);
            this.Controls.Add(this.dgvEquip);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EquipmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EquipmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquip)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdauga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbInvAppDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStatusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEquip;
        private System.Windows.Forms.Panel panel1;
        private SelectionButton btnAdauga;
        private System.Windows.Forms.Label Formular;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label cautare;
        public System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.Button btnExport;
        private dbInvAppDataSet2 dbInvAppDataSet2;
        private System.Windows.Forms.BindingSource tbStatusBindingSource;
        private dbInvAppDataSet2TableAdapters.tbStatusTableAdapter tbStatusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}