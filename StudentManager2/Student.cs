using System.ComponentModel;

namespace StudentManager2
{
    public class Student : INotifyPropertyChanged
    {
        private string _id = "", _name = "", _gender = "Nam", _avatar = "";
        private int _age = 18;

        public string StudentId { get => _id; set { _id = value; Notify(nameof(StudentId)); } }
        public string FullName { get => _name; set { _name = value; Notify(nameof(FullName)); } }
        public int Age { get => _age; set { _age = value; Notify(nameof(Age)); } }
        public string Gender { get => _gender; set { _gender = value; Notify(nameof(Gender)); } }
        public string AvatarPath { get => _avatar; set { _avatar = value; Notify(nameof(AvatarPath)); } }

        public event PropertyChangedEventHandler PropertyChanged;
        private void Notify(string p) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(p));
    }
}