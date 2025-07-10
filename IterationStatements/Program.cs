namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
       public static void PrintNumbers()
       {
	       int forPrintNumbers = 1000;
	       do
	       {
		       Console.WriteLine($"{forPrintNumbers}");
		       forPrintNumbers--;
	       } while (forPrintNumbers > -1001);

       } 
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        
       public static void PrintEveryThirdNumber()
       {
	       int forEveryThird = 3;
	       Console.WriteLine($"{forEveryThird}");
	       while (forEveryThird < 999)
	       {
		       forEveryThird = forEveryThird + 3;
		       Console.WriteLine($"{forEveryThird}");
	       }
       }
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        
	public static bool AreNumbersEqual (int firstNumber, int secondNumber)
	{
		if (firstNumber != secondNumber)
		{
			Console.WriteLine("Your numbers are different.");
			return false;
		}
		else
		{
			Console.WriteLine("Those numbers are the same!");
			return true;
		}

	}

        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        public static void IsEven(int forEvenOrOdd)
	{
		if (forEvenOrOdd % 2 == 0)
		{
			Console.WriteLine("Your number is even.");
		}
		else
		{
			Console.WriteLine("Your number is odd.");
		}
	}


        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        public static bool IsPositive(int posOrNeg)
	{
		if (posOrNeg > 0)
		{
			Console.WriteLine("Your number is positive.");
			return true;
		}
		else
		{
			Console.WriteLine("Your number is negative.");
			return false;
		}
	}

        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        public static bool CanVote(int votingAge)
	{ 
		if (votingAge >= 18)
		{
			Console.WriteLine("You are of voting age.");
			return true;
		}
		else
		{
			Console.WriteLine($"Sorry, you are too young to vote by {18 - votingAge} years.");
			return false;
		}

	}


        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        
	public static bool IsInRange(int fromTenToTen)
	{	
		if (fromTenToTen <= 10 && fromTenToTen >= -10)
		{
			Console.WriteLine("Your number is between ten and negative ten.");
			return true;
		}
		Console.WriteLine("Your number is not between negative and positive ten.");
		return false;

	}

        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
	public static void DisplayMultiplicationTable(int forMult)
	{
		for (int i = 1; i < 13; i++)
		{
			Console.WriteLine($"{i} * {forMult} = {i * forMult}.");
		}
	
	}

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
		PrintNumbers(); // for #1.
            	PrintEveryThirdNumber(); // for #2
		
		Console.WriteLine("Please give me an integer."); // for #3
		int firstNumber; // create a variable for the first bit of input
	        string tmp =(Console.ReadLine()); // read in a line of input from the user
		if (tmp != null) 
		{
			firstNumber = int.Parse(tmp); // make sure that the input isn't null
		}
		else
		{
		
			throw new ArgumentException("Input can't be null!"); // throw an error if don't give you an input
		}

		
			
		Console.WriteLine("Thank you. Please give me a second integer."); // asking for the second number
		
		int secondNumber;
	        string test1 = (Console.ReadLine()); // input for the second number automatically made an int
		if (test1 != null)
		{
			secondNumber = int.Parse(test1); // parse the second number
		}
		else
		{
		
			throw new ArgumentException("Input can't be null!"); // throw an error if don't give you an input
		}
		AreNumbersEqual(firstNumber, secondNumber); // Calls the method for #3
		
		Console.WriteLine("Thanks! Let me have another integer so we can figure out if it is even or odd."); // asking for 3rd number
		int forEvenOrOdd;
		string forEtest =(Console.ReadLine()); // input for the third number automatically made an int
		if (forEtest != null)
		{
			forEvenOrOdd = int.Parse(forEtest); // if the input isn't null, send it
		}
		else
		{

			throw new ArgumentException("Input can't be null!"); // throw an error if don't give you an input
		}
		IsEven(forEvenOrOdd); // for #4
		
		Console.WriteLine("Thank you. How about another number to see if it is positive or negative?"); // for #5
		
		int posOrNeg;
	        string pOnTest=(Console.ReadLine()); // read input from user
		if (pOnTest != null)
		{
			posOrNeg = int.Parse(pOnTest); // if input isn't null, senderoni
		}
		else
		{
			throw new ArgumentException("Input can't be null!"); // throw an error if don't give you an input
		}
		IsPositive(posOrNeg); // calls the method for #5

		Console.WriteLine("Alright cool thanks. Now how old are you?"); // for #6
		int votingAge;
		string vAge=(Console.ReadLine()); // read the voting age into a string
		if (vAge != null)
		{
			votingAge = int.Parse(vAge); //parse the string
		}
		else
		{
			throw new ArgumentException("Input can't be null!"); // throw an error if don't give you an input
		}
		CanVote(votingAge); // Calling the method for #6

		// all right, now we are heating up!

		Console.WriteLine("Alright, we finished the first section. Now we are heating up. Let me have another integer plz."); // for #1
		int fromTenToTen;
	        string tToT =(Console.ReadLine()); // requests user input
		if (tToT != null)
		{
			fromTenToTen = int.Parse(tToT); // if the input isn't null, send it
		}
		else
		{
			throw new ArgumentException("Input can't be null!"); // throw an error if don't give you an input
		}
	        IsInRange(fromTenToTen); // calls the method for heating up section #1

		Console.WriteLine("Last thing to do. We need to do a multiplication table for a number - but I need the number from you!"); // for #2 in the heating up section
		int forMult;
	        string fMut =(Console.ReadLine()); // requests user input 
		if (fMut != null)
		{
			forMult = int.Parse(fMut); // if the input isn't null, send
		}
		else
		{
			throw new ArgumentException("Input can't be null!"); // throw an error if don't give you an input
		}
		DisplayMultiplicationTable(forMult); // for heating up #2		
        }
    }
}
