using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace StudentManager2
{
    public partial class Form1 : Form
    {
        private BindingList<Student> students = new BindingList<Student>();
        private BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Dữ liệu mẫu
            students.Add(new Student { StudentId = "SV001", FullName = "Nguyễn Văn An", Age = 20, Gender = "Nam" });
            students.Add(new Student { StudentId = "SV002", FullName = "Trần Thị Bình", Age = 19, Gender = "Nữ" });

            // BindingSource làm trung gian
            bs.DataSource = students;
            dgvStudents.AutoGenerateColumns = true;
            dgvStudents.DataSource = bs;

            dgvStudents.Columns["StudentId"].HeaderText = "Mã SV";
            dgvStudents.Columns["FullName"].HeaderText = "Họ tên";
            dgvStudents.Columns["Age"].HeaderText = "Tuổi";
            dgvStudents.Columns["Gender"].HeaderText = "Giới tính";
            dgvStudents.Columns["AvatarPath"].HeaderText = "Đường dẫn ảnh";
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Binding hai chiều: Control <-> dòng đang chọn
            txtId.DataBindings.Add("Text", bs, "StudentId", true, DataSourceUpdateMode.OnPropertyChanged);
            txtName.DataBindings.Add("Text", bs, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAge.DataBindings.Add("Text", bs, "Age", true, DataSourceUpdateMode.OnValidation);
            cboGender.DataBindings.Add("SelectedItem", bs, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);

            // PictureBox tự nạp ảnh theo AvatarPath khi đổi dòng
            picAvatar.DataBindings.Add("ImageLocation", bs, "AvatarPath", true, DataSourceUpdateMode.Never);
        }

        // ===== THÊM =====
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var s = new Student
            {
                StudentId = "SV" + (students.Count + 1).ToString("000"),
                FullName = "",
                Age = 18,
                Gender = "Nam"
            };
            bs.Add(s);
            bs.MoveLast();
            txtName.Focus();
        }

        // ===== XÓA =====
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bs.Current == null) return;
            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bs.RemoveCurrent();
            }
        }

        // ===== CẬP NHẬT =====
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (bs.Current == null) return;

            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Mã SV và Họ tên không được để trống!");
                return;
            }
            if (!int.TryParse(txtAge.Text, out int age) || age <= 0 || age > 120)
            {
                MessageBox.Show("Tuổi phải là số nguyên hợp lệ!");
                return;
            }

            bs.EndEdit();
            dgvStudents.Refresh();
            MessageBox.Show("Cập nhật thành công!");
        }

        // ===== CHỌN ẢNH =====
        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (!(bs.Current is Student s)) return;

            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "Chọn ảnh đại diện";
                dlg.Filter = "Image files (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    s.AvatarPath = dlg.FileName;
                }
            }
        }

        // ===== XUẤT CSV =====
        private void btnExport_Click(object sender, EventArgs e)
        {
            using (var dlg = new SaveFileDialog())
            {
                dlg.Title = "Xuất danh sách sinh viên";
                dlg.Filter = "CSV file (*.csv)|*.csv";
                dlg.FileName = "DanhSachSinhVien.csv";
                if (dlg.ShowDialog() != DialogResult.OK) return;

                try
                {
                    using (var sw = new StreamWriter(dlg.FileName, false, new UTF8Encoding(true)))
                    {
                        sw.WriteLine("StudentId,FullName,Age,Gender,AvatarPath");
                        foreach (var st in students)
                        {
                            sw.WriteLine(string.Join(",",
                                Csv(st.StudentId), Csv(st.FullName), st.Age,
                                Csv(st.Gender), Csv(st.AvatarPath)));
                        }
                    }
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi ghi file: " + ex.Message);
                }
            }
        }

        private static string Csv(string value)
        {
            if (value == null) return "";
            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            return value;
        }
    }
}