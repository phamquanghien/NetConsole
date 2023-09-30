using System.Collections;
using NetConsole.Models;
ArrayList psList = new ArrayList();
for(int i = 0; i < 2; i++)
{
    Person ps = new Person();
    ps.NhapThongTin();
    psList.Add(ps);
}
foreach(Person a in psList)
{
    Console.WriteLine(a.PersonID + "-" + a.FullName);
}
