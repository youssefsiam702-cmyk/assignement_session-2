using System;

class Person
{
    public string Name;
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();

           
            Console.WriteLine("        C# ASSIGNMENT 2");
           
            Console.WriteLine();
            Console.WriteLine("1. Enter a number and print it");
            Console.WriteLine("2. Convert string to integer");
            Console.WriteLine("3. Floating-point arithmetic");
            Console.WriteLine("4. Extract substring");
            Console.WriteLine("5. Value type assignment");
            Console.WriteLine("6. Reference type assignment");
            Console.WriteLine("7. Combine two strings");
            Console.WriteLine("8. Boolean conversion");
            Console.WriteLine("9. Integer division and remainder");
            Console.WriteLine("10. If statement output");
            Console.WriteLine();
            Console.WriteLine("0. Exit");
            Console.WriteLine();
            Console.Write("Choose a question: ");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid choice.");
                Console.ReadKey();
                continue;
            }

            Console.Clear();

            switch (choice)
            {
                case 1:
                    Question1();
                    break;

                case 2:
                    Question2();
                    break;

                case 3:
                    Question3();
                    break;

                case 4:
                    Question4();
                    break;

                case 5:
                    Question5();
                    break;

                case 6:
                    Question6();
                    break;

                case 7:
                    Question7();
                    break;

                case 8:
                    Question8();
                    break;

                case 9:
                    Question9();
                    break;

                case 10:
                    Question10();
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
        }
    }

    // Question 1
    

    static void Question1()
    {
        Console.WriteLine("QUESTION 1");
        Console.WriteLine();

        Console.Write("Enter a number: ");

        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("You entered: " + number);
    }


    // Question 2
    

    static void Question2()
    {
        Console.WriteLine("QUESTION 2");
        Console.WriteLine();

        string text = "123ABC";

        Console.WriteLine("String: " + text);

        try
        {
            int number = Convert.ToInt32(text);

            Console.WriteLine("Converted number: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("FormatException occurred.");
            Console.WriteLine("The string contains non-numeric characters,");
            Console.WriteLine("so it cannot be converted to an integer.");
        }
    }


    // Question 3
    

    static void Question3()
    {
        Console.WriteLine("QUESTION 3");
        Console.WriteLine();

        double number1 = 10.5;
        double number2 = 2.5;

        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        double division = number1 / number2;

        Console.WriteLine("Number 1 = " + number1);
        Console.WriteLine("Number 2 = " + number2);
        Console.WriteLine();

        Console.WriteLine("Addition = " + addition);
        Console.WriteLine("Subtraction = " + subtraction);
        Console.WriteLine("Multiplication = " + multiplication);
        Console.WriteLine("Division = " + division);
    }


    // Question 4
    

    static void Question4()
    {
        Console.WriteLine("QUESTION 4");
        Console.WriteLine();

        string text = "Hello World";

        Console.WriteLine("Original string: " + text);

        string result = text.Substring(0, 5);

        Console.WriteLine("Substring: " + result);
    }


    // Question 5
   

    static void Question5()
    {
        Console.WriteLine("QUESTION 5");
        Console.WriteLine();

        int x = 10;

        int y = x;

        Console.WriteLine("Before changing y:");
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);

        y = 20;

        Console.WriteLine();
        Console.WriteLine("After changing y:");
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);

        Console.WriteLine();
        Console.WriteLine("Explanation:");
        Console.WriteLine("int is a value type.");
        Console.WriteLine("The value of x is copied into y.");
        Console.WriteLine("Changing y does not change x.");
    }


    // Question 6
    
    static void Question6()
    {
        Console.WriteLine("QUESTION 6");
        Console.WriteLine();

        Person person1 = new Person();

        person1.Name = "Ahmed";

        Person person2 = person1;

        Console.WriteLine("Before changing person2:");
        Console.WriteLine("person1.Name = " + person1.Name);
        Console.WriteLine("person2.Name = " + person2.Name);

        person2.Name = "Omar";

        Console.WriteLine();
        Console.WriteLine("After changing person2:");
        Console.WriteLine("person1.Name = " + person1.Name);
        Console.WriteLine("person2.Name = " + person2.Name);

        Console.WriteLine();
        Console.WriteLine("Explanation:");
        Console.WriteLine("Person is a reference type.");
        Console.WriteLine("Both variables refer to the same object.");
        Console.WriteLine("Therefore, changing person2 also changes person1.");
    }


    // Question 7
   
    static void Question7()
    {
        Console.WriteLine("QUESTION 7");
        Console.WriteLine();

        string firstName = "Ahmed";
        string lastName = "Ali";

        string fullName = firstName + " " + lastName;

        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Full Name: " + fullName);
    }


    // Question 8
    // int d;
    // d = Convert.ToInt32(!(30 < 20));

    static void Question8()
    {
        Console.WriteLine("QUESTION 8");
        Console.WriteLine();

        int d;

        d = Convert.ToInt32(!(30 < 20));

        Console.WriteLine("d = " + d);

        Console.WriteLine();
        Console.WriteLine("30 < 20 = false");
        Console.WriteLine("!false = true");
        Console.WriteLine("Convert.ToInt32(true) = 1");

        Console.WriteLine();
        Console.WriteLine("Correct Answer: b) A value 1 will be assigned to d.");
    }


    // Question 9
   

    static void Question9()
    {
        Console.WriteLine("QUESTION 9");
        Console.WriteLine();

        Console.WriteLine(13 / 2 + " " + 13 % 2);

        Console.WriteLine();
        Console.WriteLine("Correct Answer: d) 6 1");
    }


    // Question 10
    

    static void Question10()
    {
        Console.WriteLine("QUESTION 10");
        Console.WriteLine();

        int num = 1;
        int z = 5;

        if (!(num <= 0))
        {
            Console.WriteLine(++num + z++ + " " + ++z);
        }
        else
        {
            Console.WriteLine(--num + z-- + " " + --z);
        }

        Console.WriteLine();
        Console.WriteLine("Correct Answer: d) 7 7");
    }
}