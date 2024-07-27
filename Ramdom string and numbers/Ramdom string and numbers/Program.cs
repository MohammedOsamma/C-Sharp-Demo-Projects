using System.Text;

internal class Program
{
    static void GenerateRandomNumber(int min, int max)
    {
        var ran = new Random();
        var value = ran.Next(min, max);
        Console.WriteLine($"Random Number : {value}");

    }

    private const string Buffer = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm0123456789!@#$%^&*()";
    private const string CapitalBuffer = "QWERTYUIOPASDFGHJKLZXCVBNM";
    private const string LowerBuffer = "qwertyuiopasdfghjklzxcvbnm";
    private const string NumberBuffer = "0123456789";
    private const string SymbolsBuffer = "!@#$%^&*()";

    private static void GenerateRandomString(int stringLength, string selectedBuffer)
    {
        var sb = new StringBuilder();
        var rnd = new Random();
        while (sb.Length < stringLength)
        {
            var randomIndex = rnd.Next(0, selectedBuffer.Length - 1);
            sb.Append(selectedBuffer[randomIndex]);
        }
        Console.WriteLine($"random string : {sb}");
    }
    private static void Main(string[] args)
    {

        // practice enum vedio number 48
        //random value and random string
        while (true)
        {
            Console.WriteLine("===========================================");

            Console.WriteLine("Please select Option :");
            Console.WriteLine("[1] Generate random number \t [2] Generate random string ");
            var selectedOption = Console.ReadLine();

            Console.WriteLine("===========================================");

            if (selectedOption == "1")
            {
                Console.WriteLine("Please enter min number and max number  :");
                int min = int.Parse(Console.ReadLine());
                int max = int.Parse(Console.ReadLine());


                GenerateRandomNumber(min, max);

            }
            else if (selectedOption == "2")

            {
                Console.WriteLine("Please enter number of string :");
                int stringLength = int.Parse(Console.ReadLine());
                if (stringLength < 0)
                {
                    Console.WriteLine("Please enter valid number :");
                }
                else
                {
                    Console.WriteLine("[1] Inlcude Capital Letters ? \n[2] Include Small Letters ? \n[3] Include Numbers ? \n[4] Include Symbols ?");
                    int Option = int.Parse(Console.ReadLine());
                    switch (Option)
                    {
                        case 1:
                            GenerateRandomString(stringLength, CapitalBuffer);
                            break;
                        case 2:
                            GenerateRandomString(stringLength, LowerBuffer);
                            break;
                        case 3:
                            GenerateRandomString(stringLength, NumberBuffer);
                            break;
                        case 4:
                            GenerateRandomString(stringLength, SymbolsBuffer);
                            break;
                        default:
                            GenerateRandomString(stringLength, Buffer);
                            break;
                    }

                }
            }
        }
    }
}