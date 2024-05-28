namespace Substring
{
    internal class Program
    {
        static void Main()
        {
            string input = "hall";
            FindAllSubstrings(input);
        }

        static void FindAllSubstrings(string input)
        {
            Console.WriteLine("All possible substrings of the string \"" + input + "\":");
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j <= input.Length; j++)
                {
                    Console.WriteLine(input.Substring(i, j - i));
                }
            }
        }

    }
}
