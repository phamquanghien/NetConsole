namespace NetConsole.Models
{
    public class Student : Person
    {
        public string StudentID { get; set; }
        public void NhapThongTin()
        {
            PersonID = "PS001";
            base.NhapThongTin();
            Console.WriteLine("StudentID = ");
            StudentID = Console.ReadLine();
        }
        public void HienThi()
        {
            base.HienThi();
            Console.WriteLine("-" + StudentID);
        }
    }
}