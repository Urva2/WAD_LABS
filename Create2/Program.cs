Console.WriteLine("1. Addition (+)");
Console.WriteLine("2. Subtraction (-)");
Console.WriteLine("3. Multiplication (*)");
Console.WriteLine("4. Division (/)");
Console.WriteLine("5. Modulus (%)");
Console.WriteLine("6. Exit");
Console.Write("\nSelect an option (1-6): ");

int choice=int.Parse(Console.ReadLine());
if (choice == 6)
{
    Console.WriteLine("Thank you for using Calculator.Good Bye!!");
    return;
}

while(choice < 1 || choice > 6)
{
    Console.WriteLine("Please Enter Valide Choice:");
    choice=int.Parse(Console.ReadLine());
}
Console.WriteLine("Enter Number1:");
double num1=double.Parse(Console.ReadLine());
Console.WriteLine("Enter Number2:");
double num2 = double.Parse(Console.ReadLine());
switch (choice)
{
    case 1:
        Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
        break;

    case 2:
        Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
        break;

    case 3:
        Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
        break;

    case 4:
        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero is mathematically undefined.");
        }
        else
        {
            Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
        }
        break;
    case 5:
        if (num2 == 0)
        {
            Console.WriteLine("Error: Modulus by zero is not allowed.");
        }
        else
        {
            Console.WriteLine($"Result: {num1} % {num2} = {num1 % num2}");
        }
        break;

}
