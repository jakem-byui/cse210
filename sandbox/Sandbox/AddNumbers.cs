public class AddNumbers
{
    Console.Write("Enter first whole number: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Enter second whole number: ");
    int num2 = int.Parse(Console.ReadLine());

    int result = AddNumbers(num1, num2);
    Console.WriteLine($"The sum of {num1} and {num2} is: {result}");
    
    
    public virtual int AddNumbers(int num1, int num2)
    {
        int numCombined = num1 + num2;
        return numCombined;
    }
}

