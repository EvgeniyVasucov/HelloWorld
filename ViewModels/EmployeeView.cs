
using MySqlConnector;

namespace LessonASPNET.ViewModels
{
    public class EmployeeView
    {
        //static void Main()
        //{
        //    var connect = "Host=localhost;Username=cp38915_students;Port=3306;Password=Qwerty123;Database=students";
        //    var con = new MySqlConnection(connect);
        //    con.Open();
        //}
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Patronymic { get; set; }
        public int Age { get; set; }
    }
}
