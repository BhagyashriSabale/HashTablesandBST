namespace HashTablesandBST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Hashtable and BST Programming");

            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "Not");
            hash.Add("4", "To");
            hash.Add("5", "be");

            string hash5 = hash.Get("5");
            Console.WriteLine("5th index values: " + hash5);

            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = paragraph.Split(' ');

            MyMapNode<string, int> wordFrequencyMap = new MyMapNode<string, int>(words.Length);
            foreach (string word in words)
            {
                if (wordFrequencyMap.Get(word) != 0)
                {
                    int frequency = wordFrequencyMap.Get(word);
                    wordFrequencyMap.Add(word, frequency + 1);
                }
                else
                {
                    wordFrequencyMap.Add(word, 1);
                }
            }
            Console.WriteLine("Word Frequency in the paragraph:");
            for (int i = 0; i < words.Length; i++)
            {
                int frequency = wordFrequencyMap.Get(words[i]);
                Console.WriteLine(words[i] + ": " + frequency);
            }
            string wordToRemove = "avoidable";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals(wordToRemove))
                {
                    wordFrequencyMap.Remove(words[i]);
                    break;
                }
            }
            Console.WriteLine("\nParagraph after removing the word \"" + wordToRemove + "\":");
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nWord Frequency after removing the word \"" + wordToRemove + "\":");
            for (int i = 0; i < words.Length; i++)
            {
                int frequency = wordFrequencyMap.Get(words[i]);
                Console.WriteLine(words[i] + ": " + frequency);
            }

        }
    }
}