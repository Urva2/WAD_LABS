//Console.WriteLine("Enter Four Student Name:");
List<string> list = new List<string>();
//for (int i = 0; i < 5; i++)
//{
//    string name=Console.ReadLine();
//    list.Add(name);
//}
Console.WriteLine("Menu:");
Console.WriteLine("1.Add new Student:");
Console.WriteLine("2. Display all student names:");
Console.WriteLine("3.Search for a student name");
Console.WriteLine("4.Update an existing student name");
Console.WriteLine("5. Delete a student name");
Console.WriteLine("6.Exit");
while (true) {
    Console.WriteLine("Enter Choice:");
    int choice = int.Parse(Console.ReadLine());
    if (choice == 6)
    {
        Console.WriteLine("Thank you for using Our App.Good Bye!!");
        return;
    }

    while (choice < 1 || choice > 6)
    {
        Console.WriteLine("Please Enter Valide Choice:");
        choice = int.Parse(Console.ReadLine());
    }
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter Name:");
            string s = Console.ReadLine();
            list.Add(s);
            break;

        case 2:
            foreach (String s5 in list)
            {
                Console.WriteLine(s5);
            }
            break;

        case 3:
            Console.WriteLine("Enter Name:");
            string s1 = Console.ReadLine();
            if (list.Contains(s1))
            {
                Console.WriteLine(s1 + " Exist!");
            }
            else
            {
                Console.WriteLine(s1 + " Not Exist!");
            }
            break;

        case 4:
            Console.WriteLine("Enter Name:");
            string s2 = Console.ReadLine();
            int index = list.IndexOf(s2);
            if (index != -1)
            {
                Console.WriteLine("Enter new Name:");
                string s3 = Console.ReadLine();
                list[index] = s3;
            }
            else
            {
                Console.WriteLine(s2 + " Not Exist.");
            }
            break;
        case 5:
            Console.WriteLine("Enter Name:");
            string s4 = Console.ReadLine();
            int index2 = list.IndexOf(s4);
            if (index2 != -1)
            {
                list.Remove(s4);
            }
            else
            {
                Console.WriteLine(s4 + " Not Exist.");
            }
            break;
    }
}