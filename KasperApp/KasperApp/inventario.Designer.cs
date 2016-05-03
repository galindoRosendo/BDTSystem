namespace KasperApp
{
    partial class inventario
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpbCat = new System.Windows.Forms.GroupBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCatOk = new System.Windows.Forms.Button();
            this.btnCatCancel = new System.Windows.Forms.Button();
            this.txtCatString = new System.Windows.Forms.TextBox();
            this.rdnItem = new System.Windows.Forms.RadioButton();
            this.rdnCatAll = new System.Windows.Forms.RadioButton();
            this.gpbNew = new System.Windows.Forms.GroupBox();
            this.txtNewId = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.txtNewDesc = new System.Windows.Forms.TextBox();
            this.txtNewQuan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddItemOk = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOutQuan = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.cmbOutId = new System.Windows.Forms.ComboBox();
            this.cmbOutName = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbInName = new System.Windows.Forms.ComboBox();
            this.cmbInIdItem = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInQuant = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gpbCat.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gpbNew.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1021, 554);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gpbCat);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1013, 523);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Catalog";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1013, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Input Stock";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(355, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 74);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1013, 523);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Output Stock";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(16, 19);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.Size = new System.Drawing.Size(979, 285);
            this.dgvResult.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvResult);
            this.groupBox1.Location = new System.Drawing.Point(6, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1001, 310);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result Set";
            // 
            // gpbCat
            // 
            this.gpbCat.Controls.Add(this.rdnCatAll);
            this.gpbCat.Controls.Add(this.rdnItem);
            this.gpbCat.Controls.Add(this.txtCatString);
            this.gpbCat.Controls.Add(this.btnCatCancel);
            this.gpbCat.Controls.Add(this.btnCatOk);
            this.gpbCat.Location = new System.Drawing.Point(12, 6);
            this.gpbCat.Name = "gpbCat";
            this.gpbCat.Size = new System.Drawing.Size(572, 197);
            this.gpbCat.TabIndex = 2;
            this.gpbCat.TabStop = false;
            this.gpbCat.Text = "Search Type";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gpbNew);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1013, 523);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "New Item";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCatOk
            // 
            this.btnCatOk.Location = new System.Drawing.Point(448, 50);
            this.btnCatOk.Name = "btnCatOk";
            this.btnCatOk.Size = new System.Drawing.Size(87, 33);
            this.btnCatOk.TabIndex = 0;
            this.btnCatOk.Text = "OK";
            this.btnCatOk.UseVisualStyleBackColor = true;
            this.btnCatOk.Click += new System.EventHandler(this.btnCatOk_Click);
            // 
            // btnCatCancel
            // 
            this.btnCatCancel.Location = new System.Drawing.Point(448, 102);
            this.btnCatCancel.Name = "btnCatCancel";
            this.btnCatCancel.Size = new System.Drawing.Size(87, 33);
            this.btnCatCancel.TabIndex = 1;
            this.btnCatCancel.Text = "Cancel";
            this.btnCatCancel.UseVisualStyleBackColor = true;
            this.btnCatCancel.Click += new System.EventHandler(this.btnCatCancel_Click);
            // 
            // txtCatString
            // 
            this.txtCatString.Location = new System.Drawing.Point(151, 106);
            this.txtCatString.Name = "txtCatString";
            this.txtCatString.Size = new System.Drawing.Size(209, 24);
            this.txtCatString.TabIndex = 2;
            // 
            // rdnItem
            // 
            this.rdnItem.AutoSize = true;
            this.rdnItem.Location = new System.Drawing.Point(16, 107);
            this.rdnItem.Name = "rdnItem";
            this.rdnItem.Size = new System.Drawing.Size(86, 22);
            this.rdnItem.TabIndex = 3;
            this.rdnItem.Text = "Item Text";
            this.rdnItem.UseVisualStyleBackColor = true;
            // 
            // rdnCatAll
            // 
            this.rdnCatAll.AutoSize = true;
            this.rdnCatAll.Checked = true;
            this.rdnCatAll.Location = new System.Drawing.Point(16, 55);
            this.rdnCatAll.Name = "rdnCatAll";
            this.rdnCatAll.Size = new System.Drawing.Size(84, 22);
            this.rdnCatAll.TabIndex = 4;
            this.rdnCatAll.TabStop = true;
            this.rdnCatAll.Text = "All Stock";
            this.rdnCatAll.UseVisualStyleBackColor = true;
            // 
            // gpbNew
            // 
            this.gpbNew.Controls.Add(this.button4);
            this.gpbNew.Controls.Add(this.label4);
            this.gpbNew.Controls.Add(this.label3);
            this.gpbNew.Controls.Add(this.btnAddItemOk);
            this.gpbNew.Controls.Add(this.label2);
            this.gpbNew.Controls.Add(this.label1);
            this.gpbNew.Controls.Add(this.txtNewQuan);
            this.gpbNew.Controls.Add(this.txtNewDesc);
            this.gpbNew.Controls.Add(this.txtNewName);
            this.gpbNew.Controls.Add(this.txtNewId);
            this.gpbNew.Location = new System.Drawing.Point(200, 99);
            this.gpbNew.Name = "gpbNew";
            this.gpbNew.Size = new System.Drawing.Size(613, 324);
            this.gpbNew.TabIndex = 0;
            this.gpbNew.TabStop = false;
            this.gpbNew.Text = "Item Info";
            // 
            // txtNewId
            // 
            this.txtNewId.Location = new System.Drawing.Point(158, 47);
            this.txtNewId.Name = "txtNewId";
            this.txtNewId.Size = new System.Drawing.Size(120, 24);
            this.txtNewId.TabIndex = 0;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(158, 77);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(189, 24);
            this.txtNewName.TabIndex = 1;
            // 
            // txtNewDesc
            // 
            this.txtNewDesc.Location = new System.Drawing.Point(158, 107);
            this.txtNewDesc.Multiline = true;
            this.txtNewDesc.Name = "txtNewDesc";
            this.txtNewDesc.Size = new System.Drawing.Size(243, 90);
            this.txtNewDesc.TabIndex = 2;
            // 
            // txtNewQuan
            // 
            this.txtNewQuan.Location = new System.Drawing.Point(158, 203);
            this.txtNewQuan.Name = "txtNewQuan";
            this.txtNewQuan.Size = new System.Drawing.Size(82, 24);
            this.txtNewQuan.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity";
            // 
            // btnAddItemOk
            // 
            this.btnAddItemOk.Location = new System.Drawing.Point(514, 240);
            this.btnAddItemOk.Name = "btnAddItemOk";
            this.btnAddItemOk.Size = new System.Drawing.Size(84, 31);
            this.btnAddItemOk.TabIndex = 8;
            this.btnAddItemOk.Text = "Ok";
            this.btnAddItemOk.UseVisualStyleBackColor = true;
            this.btnAddItemOk.Click += new System.EventHandler(this.btnAddItemOk_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(514, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 31);
            this.button4.TabIndex = 9;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbOutName);
            this.groupBox5.Controls.Add(this.cmbOutId);
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtOutQuan);
            this.groupBox5.Controls.Add(this.textBox11);
            this.groupBox5.Location = new System.Drawing.Point(200, 99);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(613, 324);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Item Info";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(514, 277);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 31);
            this.button7.TabIndex = 9;
            this.button7.Text = "Cancel";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "Description";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(514, 240);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 31);
            this.button8.TabIndex = 8;
            this.button8.Text = "Remove";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(313, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 18);
            this.label11.TabIndex = 5;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 18);
            this.label12.TabIndex = 4;
            this.label12.Text = "Id Item";
            // 
            // txtOutQuan
            // 
            this.txtOutQuan.Location = new System.Drawing.Point(139, 203);
            this.txtOutQuan.Name = "txtOutQuan";
            this.txtOutQuan.Size = new System.Drawing.Size(82, 24);
            this.txtOutQuan.TabIndex = 3;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(138, 107);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(243, 90);
            this.textBox11.TabIndex = 2;
            // 
            // cmbOutId
            // 
            this.cmbOutId.FormattingEnabled = true;
            this.cmbOutId.Location = new System.Drawing.Point(138, 47);
            this.cmbOutId.Name = "cmbOutId";
            this.cmbOutId.Size = new System.Drawing.Size(121, 26);
            this.cmbOutId.TabIndex = 10;
            // 
            // cmbOutName
            // 
            this.cmbOutName.FormattingEnabled = true;
            this.cmbOutName.Location = new System.Drawing.Point(378, 47);
            this.cmbOutName.Name = "cmbOutName";
            this.cmbOutName.Size = new System.Drawing.Size(202, 26);
            this.cmbOutName.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbInName);
            this.groupBox4.Controls.Add(this.cmbInIdItem);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtInQuant);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Location = new System.Drawing.Point(200, 99);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(613, 324);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Item Info";
            // 
            // cmbInName
            // 
            this.cmbInName.FormattingEnabled = true;
            this.cmbInName.Location = new System.Drawing.Point(378, 47);
            this.cmbInName.Name = "cmbInName";
            this.cmbInName.Size = new System.Drawing.Size(202, 26);
            this.cmbInName.TabIndex = 11;
            // 
            // cmbInIdItem
            // 
            this.cmbInIdItem.FormattingEnabled = true;
            this.cmbInIdItem.Location = new System.Drawing.Point(138, 47);
            this.cmbInIdItem.Name = "cmbInIdItem";
            this.cmbInIdItem.Size = new System.Drawing.Size(121, 26);
            this.cmbInIdItem.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(514, 277);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 31);
            this.button5.TabIndex = 9;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Description";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(514, 240);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 31);
            this.button6.TabIndex = 8;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Id Item";
            // 
            // txtInQuant
            // 
            this.txtInQuant.Location = new System.Drawing.Point(139, 203);
            this.txtInQuant.Name = "txtInQuant";
            this.txtInQuant.Size = new System.Drawing.Size(82, 24);
            this.txtInQuant.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(138, 107);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(243, 90);
            this.textBox7.TabIndex = 2;
            // 
            // inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 658);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Inventario";
            this.Load += new System.EventHandler(this.inventario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gpbCat.ResumeLayout(false);
            this.gpbCat.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.gpbNew.ResumeLayout(false);
            this.gpbNew.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gpbCat;
        private System.Windows.Forms.RadioButton rdnCatAll;
        private System.Windows.Forms.RadioButton rdnItem;
        private System.Windows.Forms.TextBox txtCatString;
        private System.Windows.Forms.Button btnCatCancel;
        private System.Windows.Forms.Button btnCatOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbInName;
        private System.Windows.Forms.ComboBox cmbInIdItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInQuant;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbOutName;
        private System.Windows.Forms.ComboBox cmbOutId;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOutQuan;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox gpbNew;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddItemOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewQuan;
        private System.Windows.Forms.TextBox txtNewDesc;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.TextBox txtNewId;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}