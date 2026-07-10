Console.WriteLine("Enter All Subject Marks Out Of 100.");
Console.WriteLine("Enter Sub1 Marks:");
int sub1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Sub2 Marks:");
int sub2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Sub3 Marks:");
int sub3 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Sub4 Marks:");
int sub4 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Sub5 Marks:");
int sub5 = int.Parse(Console.ReadLine());

int total = sub1 + sub2 + sub3 + sub4 + sub5;
double percentage = (total * 100) / 500;
string grade;
if (percentage >= 80 && percentage <= 100)
{
    grade = "A";
}
else if (percentage >= 60 && percentage <= 79)
{
    grade = "B";
}
else if (percentage >= 35 && percentage <= 59)
{
    grade = "C";
}
else
{
    grade = "Fail";
}
Console.WriteLine("Total Marks:" + total + "/500");
Console.WriteLine("Percentage:" + percentage);
Console.WriteLine("Grade:" + grade);