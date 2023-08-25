namespace GestiuneaInventarierii
{
    partial class EquipmentModuleForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textdenechip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBCateg = new System.Windows.Forms.ComboBox();
            this.dateTimePickerachiz = new System.Windows.Forms.DateTimePicker();
            this.lblEchipId = new System.Windows.Forms.Label();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.comboBCom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 83);
            this.panel1.TabIndex = 12;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::GestiuneaInventarierii.Properties.Resources.close_1;
            this.pictureBoxClose.Location = new System.Drawing.Point(914, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(40, 38);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 7;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formular Echipament";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Brown;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(643, 520);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 57);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Anulează";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Peru;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(411, 520);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 57);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Modifică";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(188, 520);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 57);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Salvează";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 256);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "Data achiziție:";
            // 
            // textprice
            // 
            this.textprice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textprice.Location = new System.Drawing.Point(390, 184);
            this.textprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(486, 37);
            this.textprice.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "Pret unitar de achiziție:";
            // 
            // textdenechip
            // 
            this.textdenechip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textdenechip.Location = new System.Drawing.Point(390, 119);
            this.textdenechip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textdenechip.Name = "textdenechip";
            this.textdenechip.Size = new System.Drawing.Size(486, 37);
            this.textdenechip.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Denumire echipament:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(204, 319);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 30);
            this.label6.TabIndex = 24;
            this.label6.Text = "Categorie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(171, 386);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 30);
            this.label7.TabIndex = 26;
            this.label7.Text = "Nr unități (Q):";
            // 
            // comboBCateg
            // 
            this.comboBCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBCateg.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.comboBCateg.FormattingEnabled = true;
            this.comboBCateg.Location = new System.Drawing.Point(390, 316);
            this.comboBCateg.Name = "comboBCateg";
            this.comboBCateg.Size = new System.Drawing.Size(486, 38);
            this.comboBCateg.TabIndex = 27;
            // 
            // dateTimePickerachiz
            // 
            this.dateTimePickerachiz.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dateTimePickerachiz.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerachiz.Location = new System.Drawing.Point(390, 250);
            this.dateTimePickerachiz.Name = "dateTimePickerachiz";
            this.dateTimePickerachiz.Size = new System.Drawing.Size(486, 37);
            this.dateTimePickerachiz.TabIndex = 29;
            // 
            // lblEchipId
            // 
            this.lblEchipId.AutoSize = true;
            this.lblEchipId.Location = new System.Drawing.Point(269, 86);
            this.lblEchipId.Name = "lblEchipId";
            this.lblEchipId.Size = new System.Drawing.Size(64, 20);
            this.lblEchipId.TabIndex = 40;
            this.lblEchipId.Text = "IDechip";
            this.lblEchipId.Visible = false;
            // 
            // textBoxQ
            // 
            this.textBoxQ.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQ.Location = new System.Drawing.Point(390, 383);
            this.textBoxQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(486, 37);
            this.textBoxQ.TabIndex = 41;
            // 
            // comboBCom
            // 
            this.comboBCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBCom.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.comboBCom.FormattingEnabled = true;
            this.comboBCom.Location = new System.Drawing.Point(390, 443);
            this.comboBCom.Name = "comboBCom";
            this.comboBCom.Size = new System.Drawing.Size(486, 38);
            this.comboBCom.TabIndex = 43;
            this.comboBCom.SelectedIndexChanged += new System.EventHandler(this.comboBCom_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 446);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 30);
            this.label3.TabIndex = 42;
            this.label3.Text = "Status:";
            // 
            // textBoxSt
            // 
            this.textBoxSt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSt.Location = new System.Drawing.Point(107, 443);
            this.textBoxSt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSt.Name = "textBoxSt";
            this.textBoxSt.Size = new System.Drawing.Size(111, 37);
            this.textBoxSt.TabIndex = 44;
            this.textBoxSt.Visible = false;
            // 
            // EquipmentModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 613);
            this.Controls.Add(this.textBoxSt);
            this.Controls.Add(this.comboBCom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.lblEchipId);
            this.Controls.Add(this.dateTimePickerachiz);
            this.Controls.Add(this.comboBCateg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textdenechip);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EquipmentModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EquipmentModuleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textdenechip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox comboBCateg;
        public System.Windows.Forms.Label lblEchipId;
        public System.Windows.Forms.DateTimePicker dateTimePickerachiz;
        public System.Windows.Forms.TextBox textBoxQ;
        public System.Windows.Forms.ComboBox comboBCom;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxSt;
    }
}