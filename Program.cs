using System;

public class HelloWorld
{
    public static void Main()
    {
        Console.WriteLine("Enter name here");
        string name;
        name = Console.ReadLine();
        Console.WriteLine("what is your hobby?");
        string hobby;
        hobby = Console.ReadLine();
        Console.WriteLine("Hello " + name + "!");
        Console.WriteLine("Wow! " + hobby + " what a interesting hobby!");
        Console.WriteLine(" do you want to create some art with code?");
        Console.WriteLine("if so type yes if not type no");
        string answer;
        answer = Console.ReadLine();
        if (answer == "yes")
        {
            Console.WriteLine("Great! let's get started");
        }
        else
        {
            Console.WriteLine("oh well have a nice day!");
            if (answer == "no")
            {
                return;
            }
        
            
        }
        char symbol = '*';
        Console.WriteLine("how many " + symbol + " would you like to see"); 
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || number < 1)
        {
            Console.WriteLine("Please enter a valid positive integer.");
        }   
        for (int i = 0; i < number; i++)
        {
            Console.Write(symbol);
        }

        Console.WriteLine();
        Console.WriteLine("how many rows of " + symbol + " would you like to see");
        int rows;       
        while (!int.TryParse(Console.ReadLine(), out rows) || rows < 1)
        {
            Console.WriteLine("Please enter a valid positive integer.");
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < number; j++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }           

       Console.WriteLine("how many columns of " + symbol + " would you like to see");
        int columns;
        while (!int.TryParse(Console.ReadLine(), out columns) || columns < 1)   
        {
            Console.WriteLine("Please enter a valid positive integer.");
        }           

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }       
            Console.WriteLine("Finally, how many rows and columns of " + symbol + " would you like to see");
        int size;               
        while (!int.TryParse(Console.ReadLine(), out size) || size < 1)
        {
            Console.WriteLine("Please enter a valid positive integer.");
        }           
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
       Console.WriteLine("now choose a different symbol to draw with " + name + "!");
        char newSymbol;
        while (!char.TryParse(Console.ReadLine(), out newSymbol))
        {
            Console.WriteLine("Please enter a valid character.");
        }   

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(newSymbol);
            }
            Console.WriteLine();
        }
            Console.WriteLine("how many rows of " + newSymbol + " would you like to see");
        int newRows;                
        while (!int.TryParse(Console.ReadLine(), out newRows) || newRows < 1)
        {
            Console.WriteLine("Please enter a valid positive integer.");
        }
        for (int i = 0; i < newRows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(newSymbol);
            }
            Console.WriteLine();
        }            Console.WriteLine("how many columns of " + newSymbol + " would you like to see");
        int newColumns; 
        while (!int.TryParse(Console.ReadLine(), out newColumns) || newColumns < 1)
        {
            Console.WriteLine("Please enter a valid positive integer.");
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < newColumns; j++)
            {
                Console.Write(newSymbol);
            }
            Console.WriteLine();
        }       
            Console.WriteLine("Finally, how many rows and columns of " + newSymbol + " would you like to see");
        int newSize;
        while (!int.TryParse(Console.ReadLine(), out newSize) || newSize < 1)
        {
            Console.WriteLine("Please enter a valid positive integer.");
        }

        for (int i = 0; i < newSize; i++)
        {
            for (int j = 0; j < newSize; j++)
            {
                Console.Write(newSymbol);
            }
            Console.WriteLine();
        }
        Console.WriteLine("now let me see if i can combine both symbols into one picture");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    Console.Write(symbol);
                }
                else
                {
                    Console.Write(newSymbol);
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("Here is your Art!!" + name + "!");



        Console.WriteLine("It was very nice to meet you. Goodbye!");
    }
}


   