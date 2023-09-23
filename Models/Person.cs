namespace NetConsole.Models
{
    public class Person
    {
        //khai bao cac thuoc tinh va phuong thuc
        public string PersonID { get; set; }
        public string FullName { get; set; }
        //phuong thuc nhap thong tin
        public void NhapThongTin()
        {
            //thong bao cho nguoi dung
            Console.Write("PersonID = ");
            //doc du lieu nguoi dung nhap vao
            //va gan cho thuoc tinh
            PersonID = Console.ReadLine();
            System.Console.Write("Full name = ");
            FullName = Console.ReadLine();
        }
        //phuong thuc hien thi thong tin
        public void HienThi()
        {
            Console.Write(PersonID + "-" + FullName);
        }
    }
}