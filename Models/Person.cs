namespace NetConsole.Models
{
    public class Person
    {
        public Person()
        {
            PersonID = "PS01";
            FullName = "Nguyen Van A";
            Age = 19;
        }
        public Person(string fname, string psID, int tuoi)
        {
            PersonID = psID;
            FullName = fname;
        }
        //khai bao cac thuoc tinh
        public string PersonID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        //khai bao cac phuong thuc
        public void EnterData()
        {
            Console.WriteLine("PersonID = ");
            PersonID = Console.ReadLine();
            Console.WriteLine("Full name = ");
            FullName = Console.ReadLine();
            Console.WriteLine("Age = ");
            Age = Convert.ToInt16(Console.ReadLine());
        }
        public void Display()
        {
            Console.Write(PersonID + "-" + FullName+ "-" + Age+"-");
        }
    }
}