namespace BinaryToDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValid;
            string binaryInput;

            do
            {
                Console.WriteLine("Enter a binary number (up to 8 digits):");
                binaryInput = Console.ReadLine(); // Read user input inside the loop

                // Check if the input meets the criteria
                if (binaryInput.Length > 8)
                {
                    Console.WriteLine("Error: Input must be 8 digits or fewer.");
                    isValid = false;
                }
                else if (!isBinary.IsBinary(binaryInput)) // Assuming the IsBinary function is defined elsewhere
                {
                    Console.WriteLine("Error: Input must contain only 0 or 1.");
                    isValid = false;
                }
                else
                {
                    isValid = true; // Input is valid
                }
            } while (!isValid);

            binaryConversion.binConv(binaryInput);


        }
    }
}
