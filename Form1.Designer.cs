namespace GymMembershipManagement
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.membershipsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymMembershipDataSet = new GymMembershipManagement.gymMembershipDataSet();
            this.numberTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.durationTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipsTableAdapter = new GymMembershipManagement.gymMembershipDataSetTableAdapters.MembershipsTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.saveBT = new System.Windows.Forms.Button();
            this.deleteBT = new System.Windows.Forms.Button();
            this.closeBT = new System.Windows.Forms.Button();
            this.occupationCB = new System.Windows.Forms.ComboBox();
            this.pdfBT = new System.Windows.Forms.Button();
            this.addBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.membershipsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMembershipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME";
            // 
            // nameTB
            // 
            this.nameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membershipsBindingSource, "Name", true));
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(192, 109);
            this.nameTB.Margin = new System.Windows.Forms.Padding(4);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(184, 29);
            this.nameTB.TabIndex = 1;
            // 
            // membershipsBindingSource
            // 
            this.membershipsBindingSource.DataMember = "Memberships";
            this.membershipsBindingSource.DataSource = this.gymMembershipDataSet;
            // 
            // gymMembershipDataSet
            // 
            this.gymMembershipDataSet.DataSetName = "gymMembershipDataSet";
            this.gymMembershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numberTB
            // 
            this.numberTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membershipsBindingSource, "Number", true));
            this.numberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTB.Location = new System.Drawing.Point(192, 166);
            this.numberTB.Margin = new System.Windows.Forms.Padding(4);
            this.numberTB.Name = "numberTB";
            this.numberTB.Size = new System.Drawing.Size(184, 29);
            this.numberTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "PHONE NO.";
            // 
            // durationTB
            // 
            this.durationTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membershipsBindingSource, "Duration", true));
            this.durationTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationTB.Location = new System.Drawing.Point(192, 214);
            this.durationTB.Margin = new System.Windows.Forms.Padding(4);
            this.durationTB.Name = "durationTB";
            this.durationTB.Size = new System.Drawing.Size(184, 29);
            this.durationTB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "DURATION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "OCCUPATION";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.occupationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.membershipsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(485, 101);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(693, 209);
            this.dataGridView1.TabIndex = 9;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // occupationDataGridViewTextBoxColumn
            // 
            this.occupationDataGridViewTextBoxColumn.DataPropertyName = "Occupation";
            this.occupationDataGridViewTextBoxColumn.HeaderText = "Occupation";
            this.occupationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.occupationDataGridViewTextBoxColumn.Name = "occupationDataGridViewTextBoxColumn";
            // 
            // membershipsTableAdapter
            // 
            this.membershipsTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(481, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "MEMBERSHIPS";
            // 
            // saveBT
            // 
            this.saveBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBT.Location = new System.Drawing.Point(143, 314);
            this.saveBT.Margin = new System.Windows.Forms.Padding(4);
            this.saveBT.Name = "saveBT";
            this.saveBT.Size = new System.Drawing.Size(100, 38);
            this.saveBT.TabIndex = 11;
            this.saveBT.Text = "SAVE";
            this.saveBT.UseVisualStyleBackColor = true;
            this.saveBT.Click += new System.EventHandler(this.saveBT_Click);
            // 
            // deleteBT
            // 
            this.deleteBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBT.Location = new System.Drawing.Point(251, 314);
            this.deleteBT.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBT.Name = "deleteBT";
            this.deleteBT.Size = new System.Drawing.Size(112, 38);
            this.deleteBT.TabIndex = 12;
            this.deleteBT.Text = "DELETE";
            this.deleteBT.UseVisualStyleBackColor = true;
            this.deleteBT.Click += new System.EventHandler(this.deleteBT_Click);
            // 
            // closeBT
            // 
            this.closeBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBT.Location = new System.Drawing.Point(143, 364);
            this.closeBT.Margin = new System.Windows.Forms.Padding(4);
            this.closeBT.Name = "closeBT";
            this.closeBT.Size = new System.Drawing.Size(100, 38);
            this.closeBT.TabIndex = 13;
            this.closeBT.Text = "CLOSE";
            this.closeBT.UseVisualStyleBackColor = true;
            this.closeBT.Click += new System.EventHandler(this.closeBT_Click);
            // 
            // occupationCB
            // 
            this.occupationCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membershipsBindingSource, "Occupation", true));
            this.occupationCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupationCB.FormattingEnabled = true;
            this.occupationCB.Items.AddRange(new object[] {
            "Member",
            "Staff",
            "VIP"});
            this.occupationCB.Location = new System.Drawing.Point(192, 266);
            this.occupationCB.Margin = new System.Windows.Forms.Padding(4);
            this.occupationCB.Name = "occupationCB";
            this.occupationCB.Size = new System.Drawing.Size(184, 32);
            this.occupationCB.TabIndex = 14;
            this.occupationCB.SelectedIndexChanged += new System.EventHandler(this.occupationCB_SelectedIndexChanged);
            // 
            // pdfBT
            // 
            this.pdfBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdfBT.Location = new System.Drawing.Point(966, 318);
            this.pdfBT.Margin = new System.Windows.Forms.Padding(4);
            this.pdfBT.Name = "pdfBT";
            this.pdfBT.Size = new System.Drawing.Size(212, 38);
            this.pdfBT.TabIndex = 15;
            this.pdfBT.Text = "CONVERT TO PDF";
            this.pdfBT.UseVisualStyleBackColor = true;
            this.pdfBT.Click += new System.EventHandler(this.pdfBT_Click);
            // 
            // addBT
            // 
            this.addBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBT.Location = new System.Drawing.Point(35, 314);
            this.addBT.Margin = new System.Windows.Forms.Padding(4);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(100, 38);
            this.addBT.TabIndex = 16;
            this.addBT.Text = "ADD";
            this.addBT.UseVisualStyleBackColor = true;
            this.addBT.Click += new System.EventHandler(this.addBT_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1228, 554);
            this.Controls.Add(this.addBT);
            this.Controls.Add(this.pdfBT);
            this.Controls.Add(this.occupationCB);
            this.Controls.Add(this.closeBT);
            this.Controls.Add(this.deleteBT);
            this.Controls.Add(this.saveBT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.durationTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Gym Membership Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.membershipsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMembershipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox numberTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox durationTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private gymMembershipDataSet gymMembershipDataSet;
        private System.Windows.Forms.BindingSource membershipsBindingSource;
        private gymMembershipDataSetTableAdapters.MembershipsTableAdapter membershipsTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveBT;
        private System.Windows.Forms.Button deleteBT;
        private System.Windows.Forms.Button closeBT;
        private System.Windows.Forms.ComboBox occupationCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button pdfBT;
        private System.Windows.Forms.Button addBT;
    }
}

