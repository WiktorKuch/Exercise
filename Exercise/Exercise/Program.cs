namespace Exercise
{
    class Program
    {

        static bool TryParseToNegativeInt(string input, out int result)
        {
            if(int.TryParse(input, out result))
            {
                if(result < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                result = default;
                return  false;
            }
        }
        static void Main(string[] args)
        {
            int inputValue;
#pragma warning disable CS8604 // Możliwy argument odwołania o wartości null.
            while (!TryParseToNegativeInt(Console.ReadLine(), out inputValue))
#pragma warning restore CS8604 // Możliwy argument odwołania o wartości null.
            {
                Console.WriteLine("Insert negative number");
            }

            Console.WriteLine($"Inserted negative number = {inputValue}");

        }
    }
}