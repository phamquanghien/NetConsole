using System.Runtime.Intrinsics.Arm;

namespace NetConsole.Models
{
    public class Employee : Person
    {
        public string PersonID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string EmployeeID { get; set; }
        public double HeSoLuong { get; set; }
        public Employee()
        {
            EmployeeID = "EMP01";
            HeSoLuong = 2.34;
        }
        
        public void EnterData()
        {
            base.EnterData();
            Console.WriteLine("EmployeeID = ");
            EmployeeID = Console.ReadLine();
            Console.WriteLine("He so luong = ");
            HeSoLuong = Convert.ToDouble(Console.ReadLine());
        }
        public void Display()
        {
            base.Display();
            System.Console.WriteLine(EmployeeID + "-" + HeSoLuong);
        }
        public void Display(double luong)
        {
            base.Display();
            System.Console.WriteLine(EmployeeID + "-" + HeSoLuong + "-" + luong);
        }
        //Luong = HSL * LCB + PC;
        public double TinhLuong(int lcb, int pc)
        {
            double luong = HeSoLuong * lcb + pc;
            return luong;
        }
    }
}