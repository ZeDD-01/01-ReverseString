namespace _01_ReverseString;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Welcome, this small program is able to reverse strings you entered\nand to detect if you entered a palindrome\n\nPlease enter your string without spaces and with a maximum length of 30 words: ");
        string input = Console.ReadLine().ToLower();
        string reverseString = "";

        //I start at the end of the string "array", so I can assing the last letter from the string to the first position of the new string variable"
        for (int x = input.Length-1; x >= 0; x--)
        {
            
            reverseString += input[x];
        }
        
        Console.WriteLine("Your string: " +input+ " in reverse is: " + reverseString);

        if (reverseString == input)
        {
            Console.WriteLine("Your word is also a palindrome");
        }
    }
}