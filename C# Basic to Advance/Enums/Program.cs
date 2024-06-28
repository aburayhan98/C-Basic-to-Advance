
using Enums;

Console.WriteLine((int)Months.June);

Months  MyBirthMonth = Months.December;

void DoSomething(Months month)
{

}

Status userStatus = Status.Blocked;
int userStatus2 = 6;
Console.WriteLine((int)userStatus); //4

DateTime d = new DateTime(2003, 2, 4); //Datetime must be a value type
DateTime d2 = d;

Console.WriteLine(DateTime.Now);  //DateTime.Now is a property

Console.WriteLine(DateTime.UtcNow);



