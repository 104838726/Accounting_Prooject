namespace CSVAccounting_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            cbxIncome = new CheckBox();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            nudAmount = new NumericUpDown();
            lblAmount = new Label();
            txtNote = new TextBox();
            lblNote = new Label();
            dtpDate = new DateTimePicker();
            panel3 = new Panel();
            lblTotal = new Label();
            lblOutgoing = new Label();
            lblIncoming = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnLoad = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            panel2 = new Panel();
            dgvItems = new DataGridView();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            noteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CategoryType = new DataGridViewTextBoxColumn();
            isIncomeDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            itemBindingSource1 = new BindingSource(components);
            itemBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cbxIncome);
            panel1.Controls.Add(cmbCategory);
            panel1.Controls.Add(lblCategory);
            panel1.Controls.Add(nudAmount);
            panel1.Controls.Add(lblAmount);
            panel1.Controls.Add(txtNote);
            panel1.Controls.Add(lblNote);
            panel1.Controls.Add(dtpDate);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 63);
            panel1.TabIndex = 0;
            // 
            // cbxIncome
            // 
            cbxIncome.AutoSize = true;
            cbxIncome.Location = new Point(857, 9);
            cbxIncome.Name = "cbxIncome";
            cbxIncome.Size = new Size(72, 27);
            cbxIncome.TabIndex = 7;
            cbxIncome.Text = "收入";
            cbxIncome.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(724, 7);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(125, 31);
            cmbCategory.TabIndex = 6;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(670, 11);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(46, 23);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "類別";
            // 
            // nudAmount
            // 
            nudAmount.Location = new Point(513, 7);
            nudAmount.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(149, 30);
            nudAmount.TabIndex = 4;
            nudAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(459, 11);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(46, 23);
            lblAmount.TabIndex = 3;
            lblAmount.Text = "金額";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(301, 7);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(150, 30);
            txtNote.TabIndex = 2;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(247, 11);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(46, 23);
            lblNote.TabIndex = 1;
            lblNote.Text = "項目";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(3, 7);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(236, 30);
            dtpDate.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(lblTotal);
            panel3.Controls.Add(lblOutgoing);
            panel3.Controls.Add(lblIncoming);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnLoad);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(btnAdd);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 472);
            panel3.Name = "panel3";
            panel3.Size = new Size(978, 72);
            panel3.TabIndex = 2;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.ForestGreen;
            lblTotal.Location = new Point(512, 19);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(60, 23);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "結餘:0";
            // 
            // lblOutgoing
            // 
            lblOutgoing.AutoSize = true;
            lblOutgoing.ForeColor = Color.Red;
            lblOutgoing.Location = new Point(431, 19);
            lblOutgoing.Name = "lblOutgoing";
            lblOutgoing.Size = new Size(60, 23);
            lblOutgoing.TabIndex = 7;
            lblOutgoing.Text = "支出:0";
            // 
            // lblIncoming
            // 
            lblIncoming.AutoSize = true;
            lblIncoming.BackColor = SystemColors.Control;
            lblIncoming.ForeColor = Color.FromArgb(0, 0, 192);
            lblIncoming.Location = new Point(359, 19);
            lblIncoming.Name = "lblIncoming";
            lblIncoming.Size = new Size(60, 23);
            lblIncoming.TabIndex = 6;
            lblIncoming.Text = "收入:0";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 255, 192);
            btnDelete.Location = new Point(864, 14);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "刪除";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 255, 192);
            btnUpdate.Location = new Point(746, 15);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "更新";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 255, 192);
            btnClear.Location = new Point(628, 15);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 3;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.FromArgb(255, 255, 192);
            btnLoad.Location = new Point(238, 14);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "讀取";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 255, 192);
            btnSave.Location = new Point(120, 14);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 255, 192);
            btnAdd.Location = new Point(2, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvItems);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(978, 409);
            panel2.TabIndex = 3;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AutoGenerateColumns = false;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { dateDataGridViewTextBoxColumn, noteDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, CategoryType, isIncomeDataGridViewCheckBoxColumn });
            dgvItems.DataSource = itemBindingSource1;
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new Point(0, 0);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersWidth = 62;
            dgvItems.Size = new Size(978, 409);
            dgvItems.TabIndex = 0;
            dgvItems.CellDoubleClick += dgvItems_CellDoubleClick;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "日期";
            dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            noteDataGridViewTextBoxColumn.HeaderText = "事項";
            noteDataGridViewTextBoxColumn.MinimumWidth = 8;
            noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            noteDataGridViewTextBoxColumn.ReadOnly = true;
            noteDataGridViewTextBoxColumn.Width = 150;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "金額";
            amountDataGridViewTextBoxColumn.MinimumWidth = 8;
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            amountDataGridViewTextBoxColumn.Width = 150;
            // 
            // CategoryType
            // 
            CategoryType.DataPropertyName = "CategoryType";
            CategoryType.HeaderText = "分類";
            CategoryType.MinimumWidth = 8;
            CategoryType.Name = "CategoryType";
            CategoryType.ReadOnly = true;
            CategoryType.Width = 150;
            // 
            // isIncomeDataGridViewCheckBoxColumn
            // 
            isIncomeDataGridViewCheckBoxColumn.DataPropertyName = "IsIncome";
            isIncomeDataGridViewCheckBoxColumn.HeaderText = "收入";
            isIncomeDataGridViewCheckBoxColumn.MinimumWidth = 8;
            isIncomeDataGridViewCheckBoxColumn.Name = "isIncomeDataGridViewCheckBoxColumn";
            isIncomeDataGridViewCheckBoxColumn.ReadOnly = true;
            isIncomeDataGridViewCheckBoxColumn.Width = 150;
            // 
            // itemBindingSource1
            // 
            itemBindingSource1.DataSource = typeof(Item);
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(Item);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 544);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private DateTimePicker dtpDate;
        private NumericUpDown nudAmount;
        private Label lblAmount;
        private TextBox txtNote;
        private Label lblNote;
        private ComboBox cmbCategory;
        private Label lblCategory;
        private CheckBox cbxIncome;
        private Panel panel2;
        private Button btnAdd;
        private Button btnLoad;
        private Button btnSave;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private DataGridView dgvItems;
        private BindingSource itemBindingSource;
        private BindingSource itemBindingSource1;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CategoryType;
        private DataGridViewCheckBoxColumn isIncomeDataGridViewCheckBoxColumn;
        private Label lblOutgoing;
        private Label lblIncoming;
        private Label lblTotal;
    }
}
