namespace StudentManager2
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
            dgvStudents = new DataGridView();
            txtId = new TextBox();
            txtName = new TextBox();
            txtAge = new TextBox();
            cboGender = new ComboBox();
            picAvatar = new PictureBox();
            btnChooseImage = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnExport = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(1, 1);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(798, 205);
            dgvStudents.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(90, 225);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(90, 266);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(90, 312);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 3;
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Nam", "", "Nữ" });
            cboGender.Location = new Point(90, 354);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(121, 23);
            cboGender.TabIndex = 4;
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(258, 225);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(150, 180);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 5;
            picAvatar.TabStop = false;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Location = new Point(12, 415);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(75, 23);
            btnChooseImage.TabIndex = 6;
            btnChooseImage.Text = "Chọn ảnh";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(90, 415);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(171, 415);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(252, 415);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(333, 415);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(89, 23);
            btnExport.TabIndex = 10;
            btnExport.Text = "Xuất file CSV";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 233);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 11;
            label1.Text = "Mã SV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 274);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 12;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 320);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 13;
            label3.Text = "Tuổi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 362);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 14;
            label4.Text = "Giới tính";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExport);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnChooseImage);
            Controls.Add(picAvatar);
            Controls.Add(cboGender);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(dgvStudents);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudents;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAge;
        private ComboBox cboGender;
        private PictureBox picAvatar;
        private Button btnChooseImage;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnExport;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
