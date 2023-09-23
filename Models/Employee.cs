using System;
namespace NetConsole.Models
{
    public class Employee
    {
        public Employee()
        {
            MaNhanVien = "EMP01";
            TenNhanVien = "Nguyen Van A";
        }
        // public Employee()
        // {

        // }
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public float HeSoLuong { get; set; }
        //phuong thuc tinh luong cua nhan vien
        //Luong = HSL * LCB + PC;
        public int TinhLuong(int lcb, int pc)
        {
            // System.Console.WriteLine("Luong co ban = ");
            // int lcb = Convert.ToInt32(Console.ReadLine());
            int luong = Convert.ToInt32(HeSoLuong * lcb + pc);
            return luong;
        }
        public int TinhLuong(int lcb)
        {
            // System.Console.WriteLine("Luong co ban = ");
            // int lcb = Convert.ToInt32(Console.ReadLine());
            int luong = Convert.ToInt32(HeSoLuong * lcb);
            return luong;
        }
        public void HienThi()
        {
            System.Console.WriteLine(MaNhanVien + "-" + TenNhanVien);
        }
        public void HienThi(string str)
        {
            System.Console.WriteLine(MaNhanVien + "-" + TenNhanVien);
        }
    }
}