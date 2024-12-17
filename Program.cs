namespace Assignment7._2._2
{
    //Given a string s, reverse only all the vowels in the string and return it.

    internal class Program
    {
        static void Main(string[] args)
        {
            //user input for the string
            Console.WriteLine("Enter a word to reverse vowels:");
            string word = Console.ReadLine();

            //call ReverseVowels method and display the result
            string result = ReverseVowels(word);
            Console.WriteLine("Result after reversing vowels:");
            Console.WriteLine(result);
        }

        //method to reverse the vowels in the string
        static string ReverseVowels(string word)
        {
            //define vowels using a hashset
            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            //convert the input string to a character array
            char[] characters = word.ToCharArray();

            //use two pointers to identify vowels
            int left = 0, right = characters.Length - 1;

            while (left < right)
            {
                //move the left pointer forward until a vowel is found
                while (left < right && !vowels.Contains(characters[left]))
                {
                    left++;
                }

                //move the right pointer backward until a vowel is found
                while (left < right && !vowels.Contains(characters[right]))
                {
                    right--;
                }

                //swap the vowels
                if (left < right)
                {
                    char temp = characters[left];
                    characters[left] = characters[right];
                    characters[right] = temp;
                    left++;
                    right--;
                }
            }

            //return the modified string
            return new string(characters);
        }
    }
}
