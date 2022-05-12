Dictionary<int, string> employee = new Dictionary<int, string>();

employee[1] = "James Earl Jones";
employee[2] = "Chris Rogers";
employee[3] = "Tony Stark";
employee[4] = "Natasha Romanova";
employee[5] = "Dr. Strange";
string textChoice;
bool isValidChoice;
int choice;


do
{
    Console.Write("Enter a number 1-5 (6 to quit) to look up an employee: ");
    textChoice = Console.ReadLine();

    isValidChoice = int.TryParse(textChoice, out choice);

    if (choice < 1 || choice > 6)
    {
        Console.WriteLine("\nYou must choose a number between 1-6 only.\n");
    }

    switch (choice)
    {
        case 1:
            Console.WriteLine($"\nThe employee with ID 1 is { employee[1]}\n");
            break;

        case 2:
            Console.WriteLine($"\nThe employee with ID 2 is {employee[2]}\n");
            break;

        case 3:
            Console.WriteLine($"\nThe employee with ID 3 is {employee[3]}\n");
            break;

        case 4:
            Console.WriteLine($"\nThe employee with ID 4 is {employee[4]}\n");
            break;

        case 5:
            Console.WriteLine($"\nThe employee with ID 5 is {employee[5]}\n");
            break;

        case 6:
            Console.WriteLine("\n...goodbye");
            break;
    }
    } while (isValidChoice == false || choice != 6);
