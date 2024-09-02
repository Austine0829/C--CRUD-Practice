namespace CRUDPractice_1
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
            label1 = new Label();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            dgvNames = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            firstName = new DataGridViewTextBoxColumn();
            middleName = new DataGridViewTextBoxColumn();
            lastName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvNames).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "FIrst Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(12, 32);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(234, 27);
            txtFirstName.TabIndex = 1;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(252, 32);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(234, 27);
            txtMiddleName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 9);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 2;
            label2.Text = "Middle Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(492, 32);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(234, 27);
            txtLastName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(492, 9);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 65);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 135);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 170);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 100);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvNames
            // 
            dgvNames.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNames.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNames.Columns.AddRange(new DataGridViewColumn[] { id, firstName, middleName, lastName });
            dgvNames.Location = new Point(112, 65);
            dgvNames.Name = "dgvNames";
            dgvNames.ReadOnly = true;
            dgvNames.RowHeadersVisible = false;
            dgvNames.RowHeadersWidth = 51;
            dgvNames.Size = new Size(614, 188);
            dgvNames.TabIndex = 10;
            dgvNames.CellClick += dgvNames_CellClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // firstName
            // 
            firstName.HeaderText = "First Name";
            firstName.MinimumWidth = 6;
            firstName.Name = "firstName";
            firstName.ReadOnly = true;
            // 
            // middleName
            // 
            middleName.HeaderText = "Middle Name";
            middleName.MinimumWidth = 6;
            middleName.Name = "middleName";
            middleName.ReadOnly = true;
            // 
            // lastName
            // 
            lastName.HeaderText = "Last Name";
            lastName.MinimumWidth = 6;
            lastName.Name = "lastName";
            lastName.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 268);
            Controls.Add(dgvNames);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtMiddleName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNames).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private DataGridView dgvNames;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn firstName;
        private DataGridViewTextBoxColumn middleName;
        private DataGridViewTextBoxColumn lastName;
    }
}
